namespace DDETest
{
    partial class DDETest
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameValueLabel = new System.Windows.Forms.Label();
            this.azimuthLabel = new System.Windows.Forms.Label();
            this.azimuthValueLabel = new System.Windows.Forms.Label();
            this.elevationLabel = new System.Windows.Forms.Label();
            this.elevationValueLabel = new System.Windows.Forms.Label();
            this.downlinkLabel = new System.Windows.Forms.Label();
            this.downlinkValueLabel = new System.Windows.Forms.Label();
            this.uplinkLabel = new System.Windows.Forms.Label();
            this.uplinkValueLabel = new System.Windows.Forms.Label();
            this.ddeLabel = new System.Windows.Forms.Label();
            this.ddeStatusLabel = new System.Windows.Forms.Label();
            this.ddeBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.altitudeLabel = new System.Windows.Forms.Label();
            this.altitudeValueLabel = new System.Windows.Forms.Label();
            this.ddeTimer = new System.Windows.Forms.Timer(this.components);
            this.baseFreqLabel = new System.Windows.Forms.Label();
            this.baseFreqValueLabel = new System.Windows.Forms.Label();
            this.pipeBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.pipeTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(49, 13);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(38, 13);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "Name:";
            // 
            // nameValueLabel
            // 
            this.nameValueLabel.AutoSize = true;
            this.nameValueLabel.Location = new System.Drawing.Point(93, 13);
            this.nameValueLabel.Name = "nameValueLabel";
            this.nameValueLabel.Size = new System.Drawing.Size(13, 13);
            this.nameValueLabel.TabIndex = 2;
            this.nameValueLabel.Text = "0";
            // 
            // azimuthLabel
            // 
            this.azimuthLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.azimuthLabel.AutoSize = true;
            this.azimuthLabel.Location = new System.Drawing.Point(196, 13);
            this.azimuthLabel.Name = "azimuthLabel";
            this.azimuthLabel.Size = new System.Drawing.Size(47, 13);
            this.azimuthLabel.TabIndex = 2;
            this.azimuthLabel.Text = "Azimuth:";
            // 
            // azimuthValueLabel
            // 
            this.azimuthValueLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.azimuthValueLabel.AutoSize = true;
            this.azimuthValueLabel.Location = new System.Drawing.Point(249, 13);
            this.azimuthValueLabel.Name = "azimuthValueLabel";
            this.azimuthValueLabel.Size = new System.Drawing.Size(13, 13);
            this.azimuthValueLabel.TabIndex = 2;
            this.azimuthValueLabel.Text = "0";
            // 
            // elevationLabel
            // 
            this.elevationLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.elevationLabel.AutoSize = true;
            this.elevationLabel.Location = new System.Drawing.Point(189, 35);
            this.elevationLabel.Name = "elevationLabel";
            this.elevationLabel.Size = new System.Drawing.Size(54, 13);
            this.elevationLabel.TabIndex = 2;
            this.elevationLabel.Text = "Elevation:";
            // 
            // elevationValueLabel
            // 
            this.elevationValueLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.elevationValueLabel.AutoSize = true;
            this.elevationValueLabel.Location = new System.Drawing.Point(249, 35);
            this.elevationValueLabel.Name = "elevationValueLabel";
            this.elevationValueLabel.Size = new System.Drawing.Size(13, 13);
            this.elevationValueLabel.TabIndex = 2;
            this.elevationValueLabel.Text = "0";
            // 
            // downlinkLabel
            // 
            this.downlinkLabel.AutoSize = true;
            this.downlinkLabel.Location = new System.Drawing.Point(9, 34);
            this.downlinkLabel.Name = "downlinkLabel";
            this.downlinkLabel.Size = new System.Drawing.Size(78, 13);
            this.downlinkLabel.TabIndex = 2;
            this.downlinkLabel.Text = "Downlink Freq:";
            // 
            // downlinkValueLabel
            // 
            this.downlinkValueLabel.AutoSize = true;
            this.downlinkValueLabel.Location = new System.Drawing.Point(93, 34);
            this.downlinkValueLabel.Name = "downlinkValueLabel";
            this.downlinkValueLabel.Size = new System.Drawing.Size(13, 13);
            this.downlinkValueLabel.TabIndex = 2;
            this.downlinkValueLabel.Text = "0";
            // 
            // uplinkLabel
            // 
            this.uplinkLabel.AutoSize = true;
            this.uplinkLabel.Location = new System.Drawing.Point(23, 55);
            this.uplinkLabel.Name = "uplinkLabel";
            this.uplinkLabel.Size = new System.Drawing.Size(64, 13);
            this.uplinkLabel.TabIndex = 2;
            this.uplinkLabel.Text = "Uplink Freq:";
            // 
            // uplinkValueLabel
            // 
            this.uplinkValueLabel.AutoSize = true;
            this.uplinkValueLabel.Location = new System.Drawing.Point(93, 55);
            this.uplinkValueLabel.Name = "uplinkValueLabel";
            this.uplinkValueLabel.Size = new System.Drawing.Size(13, 13);
            this.uplinkValueLabel.TabIndex = 2;
            this.uplinkValueLabel.Text = "0";
            // 
            // ddeLabel
            // 
            this.ddeLabel.AutoSize = true;
            this.ddeLabel.Location = new System.Drawing.Point(76, 121);
            this.ddeLabel.Name = "ddeLabel";
            this.ddeLabel.Size = new System.Drawing.Size(66, 13);
            this.ddeLabel.TabIndex = 3;
            this.ddeLabel.Text = "DDE Status:";
            // 
            // ddeStatusLabel
            // 
            this.ddeStatusLabel.AutoSize = true;
            this.ddeStatusLabel.Location = new System.Drawing.Point(148, 121);
            this.ddeStatusLabel.Name = "ddeStatusLabel";
            this.ddeStatusLabel.Size = new System.Drawing.Size(73, 13);
            this.ddeStatusLabel.TabIndex = 3;
            this.ddeStatusLabel.Text = "Disconnected";
            // 
            // ddeBackgroundWorker
            // 
            this.ddeBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.ddeBackgroundWorker_DoWork);
            this.ddeBackgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.ddeBackgroundWorker_RunWorkerCompleted);
            // 
            // altitudeLabel
            // 
            this.altitudeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.altitudeLabel.AutoSize = true;
            this.altitudeLabel.Location = new System.Drawing.Point(198, 57);
            this.altitudeLabel.Name = "altitudeLabel";
            this.altitudeLabel.Size = new System.Drawing.Size(45, 13);
            this.altitudeLabel.TabIndex = 2;
            this.altitudeLabel.Text = "Altitude:";
            // 
            // altitudeValueLabel
            // 
            this.altitudeValueLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.altitudeValueLabel.AutoSize = true;
            this.altitudeValueLabel.Location = new System.Drawing.Point(249, 57);
            this.altitudeValueLabel.Name = "altitudeValueLabel";
            this.altitudeValueLabel.Size = new System.Drawing.Size(13, 13);
            this.altitudeValueLabel.TabIndex = 2;
            this.altitudeValueLabel.Text = "0";
            // 
            // ddeTimer
            // 
            this.ddeTimer.Interval = 1000;
            this.ddeTimer.Tick += new System.EventHandler(this.ddeTimer_Tick);
            // 
            // baseFreqLabel
            // 
            this.baseFreqLabel.AutoSize = true;
            this.baseFreqLabel.Location = new System.Drawing.Point(29, 76);
            this.baseFreqLabel.Name = "baseFreqLabel";
            this.baseFreqLabel.Size = new System.Drawing.Size(58, 13);
            this.baseFreqLabel.TabIndex = 2;
            this.baseFreqLabel.Text = "Base Freq:";
            this.baseFreqLabel.Visible = false;
            // 
            // baseFreqValueLabel
            // 
            this.baseFreqValueLabel.AutoSize = true;
            this.baseFreqValueLabel.Location = new System.Drawing.Point(93, 76);
            this.baseFreqValueLabel.Name = "baseFreqValueLabel";
            this.baseFreqValueLabel.Size = new System.Drawing.Size(13, 13);
            this.baseFreqValueLabel.TabIndex = 2;
            this.baseFreqValueLabel.Text = "0";
            this.baseFreqValueLabel.Visible = false;
            //// 
            //// pipeBackgroundWorker
            //// 
            //this.pipeBackgroundWorker.WorkerSupportsCancellation = true;
            //this.pipeBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.pipeBackgroundWorker_DoWork);
            //// 
            //// pipeTimer
            //// 
            //this.pipeTimer.Interval = 1000;
            //this.pipeTimer.Tick += new System.EventHandler(this.pipeTimer_Tick);
            // 
            // DDETest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 146);
            this.Controls.Add(this.ddeStatusLabel);
            this.Controls.Add(this.ddeLabel);
            this.Controls.Add(this.baseFreqValueLabel);
            this.Controls.Add(this.uplinkValueLabel);
            this.Controls.Add(this.downlinkValueLabel);
            this.Controls.Add(this.altitudeValueLabel);
            this.Controls.Add(this.elevationValueLabel);
            this.Controls.Add(this.azimuthValueLabel);
            this.Controls.Add(this.nameValueLabel);
            this.Controls.Add(this.baseFreqLabel);
            this.Controls.Add(this.uplinkLabel);
            this.Controls.Add(this.downlinkLabel);
            this.Controls.Add(this.altitudeLabel);
            this.Controls.Add(this.elevationLabel);
            this.Controls.Add(this.azimuthLabel);
            this.Controls.Add(this.nameLabel);
            this.Name = "DDETest";
            this.Text = "DDETest";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DDETest_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label nameValueLabel;
        private System.Windows.Forms.Label azimuthLabel;
        private System.Windows.Forms.Label azimuthValueLabel;
        private System.Windows.Forms.Label elevationLabel;
        private System.Windows.Forms.Label elevationValueLabel;
        private System.Windows.Forms.Label downlinkLabel;
        private System.Windows.Forms.Label downlinkValueLabel;
        private System.Windows.Forms.Label uplinkLabel;
        private System.Windows.Forms.Label uplinkValueLabel;
        private System.Windows.Forms.Label ddeLabel;
        private System.Windows.Forms.Label ddeStatusLabel;
        private System.ComponentModel.BackgroundWorker ddeBackgroundWorker;
        private System.Windows.Forms.Label altitudeLabel;
        private System.Windows.Forms.Label altitudeValueLabel;
        private System.Windows.Forms.Timer ddeTimer;
        private System.Windows.Forms.Label baseFreqLabel;
        private System.Windows.Forms.Label baseFreqValueLabel;
        private System.ComponentModel.BackgroundWorker pipeBackgroundWorker;
        private System.Windows.Forms.Timer pipeTimer;
    }
}

