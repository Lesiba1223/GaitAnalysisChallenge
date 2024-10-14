using Emgu.CV;
using Emgu.CV.CvEnum;
using System.Globalization;
using Timer = System.Windows.Forms.Timer;

namespace GaitAnalysisChallenge
{
	public partial class Form1 : Form
	{
		private static List<AccelerometerData> ? _accelerometerData;
		string csvPath = @"C:\Users\...";
		string videoPath = @"C:\Users\...";
		VideoCapture capture;
		Mat frame = new Mat();
		private Timer videoTimer;

		#region Form
		public Form1()
		{
			InitializeComponent();
			videoTimer = new Timer();
			videoTimer.Interval = 33;
			videoTimer.Tick += VideoTimer_Tick;
		}
		#endregion

		#region Buttons
		private void captureButton_Click(object sender, EventArgs e)
		{
			if (capture == null)
			{
				MessageBox.Show("Video not started. Please start the video first.");
				return;
			}

			_accelerometerData = ReadCSV(csvPath);
			foreach (AccelerometerData x in _accelerometerData)
			{
				Console.WriteLine($"{x.TimeStamp}| {x.UtcTime} | {x.AccelX} | {x.AccelY} | {x.AccelZ}");
			}

			double videoTimestamp = (capture.Get(CapProp.PosMsec) / 1000);
			var closestData = GetClosestAccelerometerData(videoTimestamp);

			if (closestData != null)
			{

				lblTimeStamp.Text = closestData.TimeStamp.ToString();
				lblUtcTime.Text = closestData.UtcTime.ToString();
				lblAccelX.Text = closestData.AccelX.ToString();
				lblAccelY.Text = closestData.AccelY.ToString();
				lblAccelZ.Text = closestData.AccelZ.ToString();
			}
			else
			{
				MessageBox.Show("No matching accelerometer data found.");
			}
		}

		private void exitButton_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void buttonStart_Click(object sender, EventArgs e)
		{
			lblTimeStamp.Text = "0";
			lblUtcTime.Text = "0";
			lblAccelX.Text = "0";
			lblAccelY.Text = "0";
			lblAccelZ.Text = "0";

			capture = new VideoCapture(videoPath);

			if (!capture.IsOpened)
			{
				MessageBox.Show("Failed to open video file.");
				return;
			}
			videoTimer.Start();
		}

		private void buttonSaveData_Click(object sender, EventArgs e)
		{
			string projectDirectory = Directory.GetCurrentDirectory();
			string filePath = Path.Combine(projectDirectory, "gait_data.txt");
			StreamWriter streamWriter;

			string AccelerometerData = $"Time stamp: {lblTimeStamp.Text}\nUTC Time: {lblUtcTime.Text}\n" +
					$"Accel X: {lblAccelX.Text}\nAccel Y: {lblAccelY.Text}" +
					$"\nAccel Z: {lblAccelZ.Text}";

			if (!File.Exists(filePath))
			{
				using (streamWriter = new StreamWriter(filePath))
				{
					streamWriter.WriteLine("File created: " + DateTime.Now);
					streamWriter.WriteLine(AccelerometerData);
				}
			}
			else
			{
				streamWriter = new StreamWriter(filePath);
				streamWriter.WriteLine(AccelerometerData);
				streamWriter.Close();
			}

			MessageBox.Show("Accelerometer Data Saved");
		}
		#endregion

		#region Methods

		private static List<AccelerometerData> ReadCSV(string pathName)
		{
			List<AccelerometerData> accelerometerDataList = new List<AccelerometerData>();
			var lines = File.ReadAllLines(pathName);

			try
			{
				foreach (var line in lines.Skip(1))
				{
					var columns = line.Split(',');
					double.TryParse(columns[0], NumberStyles.Float, CultureInfo.InvariantCulture, out double timestamp);
					double.TryParse(columns[1].Trim('"'), NumberStyles.Float, CultureInfo.InvariantCulture, out double utcTime);

					AccelerometerData data = new AccelerometerData
					{
						TimeStamp = timestamp / 10000,
						UtcTime = utcTime,
						AccelX = int.Parse(columns[2]),
						AccelY = int.Parse(columns[3]),
						AccelZ = int.Parse(columns[4]),
					};
					accelerometerDataList.Add(data);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
			}
			return accelerometerDataList;
		}

		private static AccelerometerData GetClosestAccelerometerData(double videoTimestamp)
		{
			const double tolerance = 0.5;

			var closestData = _accelerometerData?
				.Where(d => Math.Abs(d.TimeStamp - videoTimestamp) <= tolerance)
				.OrderBy(d => Math.Abs(d.TimeStamp - videoTimestamp))
				.FirstOrDefault();


			if (closestData == null)
			{
				Console.WriteLine($"No accelerometer data found for video timestamp {videoTimestamp}");
			}

			return closestData;
		}

		private void VideoTimer_Tick(object sender, EventArgs e)
		{

			if (capture.Read(frame))
			{
				Mat resizedFrame = new Mat();
				CvInvoke.Resize(frame, resizedFrame, WalkVideo.Size);

				WalkVideo.SizeMode = PictureBoxSizeMode.Zoom;

				WalkVideo.Image = resizedFrame.ToBitmap();
			}
		}

		#endregion
	}
}

