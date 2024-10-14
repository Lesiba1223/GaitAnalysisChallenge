namespace GaitAnalysisChallenge
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			WalkVideo = new PictureBox();
			captureButton = new Button();
			exitButton = new Button();
			buttonStart = new Button();
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			label4 = new Label();
			label5 = new Label();
			lblTimeStamp = new Label();
			lblUtcTime = new Label();
			lblAccelX = new Label();
			lblAccelY = new Label();
			lblAccelZ = new Label();
			label6 = new Label();
			buttonSaveData = new Button();
			label7 = new Label();
			((System.ComponentModel.ISupportInitialize)WalkVideo).BeginInit();
			SuspendLayout();
			// 
			// WalkVideo
			// 
			WalkVideo.BorderStyle = BorderStyle.FixedSingle;
			WalkVideo.ImageLocation = "";
			WalkVideo.Location = new Point(39, 31);
			WalkVideo.Name = "WalkVideo";
			WalkVideo.Size = new Size(769, 344);
			WalkVideo.TabIndex = 0;
			WalkVideo.TabStop = false;
			// 
			// captureButton
			// 
			captureButton.BackColor = SystemColors.ButtonShadow;
			captureButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			captureButton.Location = new Point(395, 396);
			captureButton.Name = "captureButton";
			captureButton.Size = new Size(75, 23);
			captureButton.TabIndex = 1;
			captureButton.Text = "Capture";
			captureButton.UseVisualStyleBackColor = false;
			captureButton.Click += captureButton_Click;
			// 
			// exitButton
			// 
			exitButton.BackColor = Color.Red;
			exitButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			exitButton.ForeColor = Color.Black;
			exitButton.Location = new Point(733, 396);
			exitButton.Name = "exitButton";
			exitButton.Size = new Size(75, 23);
			exitButton.TabIndex = 2;
			exitButton.Text = "Exit";
			exitButton.UseVisualStyleBackColor = false;
			exitButton.Click += exitButton_Click;
			// 
			// buttonStart
			// 
			buttonStart.BackColor = Color.FromArgb(0, 192, 0);
			buttonStart.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			buttonStart.Location = new Point(39, 396);
			buttonStart.Name = "buttonStart";
			buttonStart.Size = new Size(75, 23);
			buttonStart.TabIndex = 3;
			buttonStart.Text = "Start";
			buttonStart.UseVisualStyleBackColor = false;
			buttonStart.Click += buttonStart_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(814, 67);
			label1.Name = "label1";
			label1.Size = new Size(80, 15);
			label1.TabIndex = 4;
			label1.Text = "Time Stamp: ";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(814, 96);
			label2.Name = "label2";
			label2.Size = new Size(64, 15);
			label2.TabIndex = 5;
			label2.Text = "UTC Time:";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(814, 126);
			label3.Name = "label3";
			label3.Size = new Size(51, 15);
			label3.TabIndex = 6;
			label3.Text = "Accel X:";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(814, 155);
			label4.Name = "label4";
			label4.Size = new Size(50, 15);
			label4.TabIndex = 7;
			label4.Text = "Accel Y:";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(814, 186);
			label5.Name = "label5";
			label5.Size = new Size(50, 15);
			label5.TabIndex = 8;
			label5.Text = "Accel Z:";
			// 
			// lblTimeStamp
			// 
			lblTimeStamp.AutoSize = true;
			lblTimeStamp.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
			lblTimeStamp.Location = new Point(896, 67);
			lblTimeStamp.Name = "lblTimeStamp";
			lblTimeStamp.Size = new Size(13, 15);
			lblTimeStamp.TabIndex = 9;
			lblTimeStamp.Text = "0";
			// 
			// lblUtcTime
			// 
			lblUtcTime.AutoSize = true;
			lblUtcTime.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
			lblUtcTime.Location = new Point(896, 96);
			lblUtcTime.Name = "lblUtcTime";
			lblUtcTime.Size = new Size(13, 15);
			lblUtcTime.TabIndex = 10;
			lblUtcTime.Text = "0";
			// 
			// lblAccelX
			// 
			lblAccelX.AutoSize = true;
			lblAccelX.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
			lblAccelX.Location = new Point(896, 126);
			lblAccelX.Name = "lblAccelX";
			lblAccelX.Size = new Size(13, 15);
			lblAccelX.TabIndex = 11;
			lblAccelX.Text = "0";
			// 
			// lblAccelY
			// 
			lblAccelY.AutoSize = true;
			lblAccelY.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
			lblAccelY.Location = new Point(896, 155);
			lblAccelY.Name = "lblAccelY";
			lblAccelY.Size = new Size(13, 15);
			lblAccelY.TabIndex = 12;
			lblAccelY.Text = "0";
			// 
			// lblAccelZ
			// 
			lblAccelZ.AutoSize = true;
			lblAccelZ.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
			lblAccelZ.Location = new Point(896, 186);
			lblAccelZ.Name = "lblAccelZ";
			lblAccelZ.Size = new Size(13, 15);
			lblAccelZ.TabIndex = 13;
			lblAccelZ.Text = "0";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label6.Location = new Point(844, 31);
			label6.Name = "label6";
			label6.Size = new Size(157, 21);
			label6.TabIndex = 14;
			label6.Text = "Initial Heel Contact";
			label6.TextAlign = ContentAlignment.TopCenter;
			// 
			// buttonSaveData
			// 
			buttonSaveData.BackColor = SystemColors.ButtonShadow;
			buttonSaveData.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			buttonSaveData.Location = new Point(886, 230);
			buttonSaveData.Name = "buttonSaveData";
			buttonSaveData.Size = new Size(75, 23);
			buttonSaveData.TabIndex = 15;
			buttonSaveData.Text = "Save Data";
			buttonSaveData.UseVisualStyleBackColor = false;
			buttonSaveData.Click += buttonSaveData_Click;
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label7.Location = new Point(830, 271);
			label7.Name = "label7";
			label7.Size = new Size(194, 15);
			label7.TabIndex = 16;
			label7.Text = "(Press Start if you want to try again)";
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1049, 450);
			Controls.Add(label7);
			Controls.Add(buttonSaveData);
			Controls.Add(label6);
			Controls.Add(lblAccelZ);
			Controls.Add(lblAccelY);
			Controls.Add(lblAccelX);
			Controls.Add(lblUtcTime);
			Controls.Add(lblTimeStamp);
			Controls.Add(label5);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(buttonStart);
			Controls.Add(exitButton);
			Controls.Add(captureButton);
			Controls.Add(WalkVideo);
			Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			Name = "Form1";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Gait Analysis ";
			((System.ComponentModel.ISupportInitialize)WalkVideo).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private PictureBox WalkVideo;
		private Button captureButton;
		private Button exitButton;
		private Button buttonStart;
		private Label label1;
		private Label label2;
		private Label label3;
		private Label label4;
		private Label label5;
		private Label lblTimeStamp;
		private Label lblUtcTime;
		private Label lblAccelX;
		private Label lblAccelY;
		private Label lblAccelZ;
		private Label label6;
		private Button buttonSaveData;
		private Label label7;
	}
}
