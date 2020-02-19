namespace GUIffmpeg
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.inputButton = new System.Windows.Forms.Button();
            this.inputDialog = new System.Windows.Forms.OpenFileDialog();
            this.inputLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.startLabel = new System.Windows.Forms.Label();
            this.startTime = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.duration = new System.Windows.Forms.TextBox();
            this.durationLabel = new System.Windows.Forms.Label();
            this.videoBitrateLabel1 = new System.Windows.Forms.Label();
            this.videoBitrateLabel2 = new System.Windows.Forms.Label();
            this.videoBitrate = new System.Windows.Forms.TextBox();
            this.folderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.outputButton = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.scale = new System.Windows.Forms.TextBox();
            this.rescaleLabel = new System.Windows.Forms.Label();
            this.audioBitrate = new System.Windows.Forms.TextBox();
            this.audioBitrateLabel1 = new System.Windows.Forms.Label();
            this.audioBitrateLabel2 = new System.Windows.Forms.Label();
            this.scaleCheck = new System.Windows.Forms.CheckBox();
            this.passLabel = new System.Windows.Forms.Label();
            this.passCheck = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // inputButton
            // 
            this.inputButton.Location = new System.Drawing.Point(12, 12);
            this.inputButton.Name = "inputButton";
            this.inputButton.Size = new System.Drawing.Size(146, 23);
            this.inputButton.TabIndex = 0;
            this.inputButton.Text = "Сhoose Input File";
            this.inputButton.UseVisualStyleBackColor = true;
            this.inputButton.Click += new System.EventHandler(this.InputButton_Click);
            // 
            // inputDialog
            // 
            this.inputDialog.FileName = "openFileDialog1";
            // 
            // inputLabel
            // 
            this.inputLabel.AutoSize = true;
            this.inputLabel.Location = new System.Drawing.Point(164, 17);
            this.inputLabel.Name = "inputLabel";
            this.inputLabel.Size = new System.Drawing.Size(84, 13);
            this.inputLabel.TabIndex = 1;
            this.inputLabel.Text = "File not selected";
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startButton.Location = new System.Drawing.Point(708, 406);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(80, 32);
            this.startButton.TabIndex = 2;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // startLabel
            // 
            this.startLabel.AutoSize = true;
            this.startLabel.Location = new System.Drawing.Point(40, 80);
            this.startLabel.Name = "startLabel";
            this.startLabel.Size = new System.Drawing.Size(29, 13);
            this.startLabel.TabIndex = 3;
            this.startLabel.Text = "Start";
            // 
            // startTime
            // 
            this.startTime.Location = new System.Drawing.Point(76, 77);
            this.startTime.Name = "startTime";
            this.startTime.Size = new System.Drawing.Size(109, 20);
            this.startTime.TabIndex = 4;
            this.startTime.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(389, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 12;
            // 
            // duration
            // 
            this.duration.Location = new System.Drawing.Point(76, 103);
            this.duration.Name = "duration";
            this.duration.Size = new System.Drawing.Size(109, 20);
            this.duration.TabIndex = 17;
            this.duration.Text = "0";
            // 
            // durationLabel
            // 
            this.durationLabel.AutoSize = true;
            this.durationLabel.Location = new System.Drawing.Point(23, 106);
            this.durationLabel.Name = "durationLabel";
            this.durationLabel.Size = new System.Drawing.Size(47, 13);
            this.durationLabel.TabIndex = 16;
            this.durationLabel.Text = "Duration";
            // 
            // videoBitrateLabel1
            // 
            this.videoBitrateLabel1.AutoSize = true;
            this.videoBitrateLabel1.Location = new System.Drawing.Point(4, 132);
            this.videoBitrateLabel1.Name = "videoBitrateLabel1";
            this.videoBitrateLabel1.Size = new System.Drawing.Size(66, 13);
            this.videoBitrateLabel1.TabIndex = 28;
            this.videoBitrateLabel1.Text = "Video bitrate";
            // 
            // videoBitrateLabel2
            // 
            this.videoBitrateLabel2.AutoSize = true;
            this.videoBitrateLabel2.Location = new System.Drawing.Point(192, 132);
            this.videoBitrateLabel2.Name = "videoBitrateLabel2";
            this.videoBitrateLabel2.Size = new System.Drawing.Size(14, 13);
            this.videoBitrateLabel2.TabIndex = 29;
            this.videoBitrateLabel2.Text = "K";
            // 
            // videoBitrate
            // 
            this.videoBitrate.Location = new System.Drawing.Point(77, 129);
            this.videoBitrate.Name = "videoBitrate";
            this.videoBitrate.Size = new System.Drawing.Size(109, 20);
            this.videoBitrate.TabIndex = 30;
            this.videoBitrate.Text = "1000";
            // 
            // outputButton
            // 
            this.outputButton.Location = new System.Drawing.Point(12, 415);
            this.outputButton.Name = "outputButton";
            this.outputButton.Size = new System.Drawing.Size(146, 23);
            this.outputButton.TabIndex = 31;
            this.outputButton.Text = "Сhoose Output Folder";
            this.outputButton.UseVisualStyleBackColor = true;
            this.outputButton.Click += new System.EventHandler(this.OutputButton_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Location = new System.Drawing.Point(164, 420);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(97, 13);
            this.outputLabel.TabIndex = 32;
            this.outputLabel.Text = "Folder not selected";
            // 
            // scale
            // 
            this.scale.Location = new System.Drawing.Point(76, 181);
            this.scale.Name = "scale";
            this.scale.ReadOnly = true;
            this.scale.Size = new System.Drawing.Size(109, 20);
            this.scale.TabIndex = 33;
            // 
            // rescaleLabel
            // 
            this.rescaleLabel.AutoSize = true;
            this.rescaleLabel.Location = new System.Drawing.Point(24, 184);
            this.rescaleLabel.Name = "rescaleLabel";
            this.rescaleLabel.Size = new System.Drawing.Size(46, 13);
            this.rescaleLabel.TabIndex = 34;
            this.rescaleLabel.Text = "Rescale";
            // 
            // audioBitrate
            // 
            this.audioBitrate.Location = new System.Drawing.Point(76, 155);
            this.audioBitrate.Name = "audioBitrate";
            this.audioBitrate.Size = new System.Drawing.Size(109, 20);
            this.audioBitrate.TabIndex = 35;
            this.audioBitrate.Text = "120";
            // 
            // audioBitrateLabel1
            // 
            this.audioBitrateLabel1.AutoSize = true;
            this.audioBitrateLabel1.Location = new System.Drawing.Point(4, 158);
            this.audioBitrateLabel1.Name = "audioBitrateLabel1";
            this.audioBitrateLabel1.Size = new System.Drawing.Size(66, 13);
            this.audioBitrateLabel1.TabIndex = 36;
            this.audioBitrateLabel1.Text = "Audio bitrate";
            // 
            // audioBitrateLabel2
            // 
            this.audioBitrateLabel2.AutoSize = true;
            this.audioBitrateLabel2.Location = new System.Drawing.Point(192, 158);
            this.audioBitrateLabel2.Name = "audioBitrateLabel2";
            this.audioBitrateLabel2.Size = new System.Drawing.Size(14, 13);
            this.audioBitrateLabel2.TabIndex = 37;
            this.audioBitrateLabel2.Text = "K";
            // 
            // scaleCheck
            // 
            this.scaleCheck.AutoSize = true;
            this.scaleCheck.Location = new System.Drawing.Point(191, 184);
            this.scaleCheck.Name = "scaleCheck";
            this.scaleCheck.Size = new System.Drawing.Size(15, 14);
            this.scaleCheck.TabIndex = 39;
            this.scaleCheck.UseVisualStyleBackColor = true;
            this.scaleCheck.CheckedChanged += new System.EventHandler(this.ScaleCheckedChanged);
            // 
            // passLabel
            // 
            this.passLabel.AutoSize = true;
            this.passLabel.Location = new System.Drawing.Point(32, 209);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(38, 13);
            this.passLabel.TabIndex = 40;
            this.passLabel.Text = "2 pass";
            // 
            // passCheck
            // 
            this.passCheck.AutoSize = true;
            this.passCheck.Location = new System.Drawing.Point(77, 209);
            this.passCheck.Name = "passCheck";
            this.passCheck.Size = new System.Drawing.Size(15, 14);
            this.passCheck.TabIndex = 41;
            this.passCheck.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.passCheck);
            this.Controls.Add(this.passLabel);
            this.Controls.Add(this.scaleCheck);
            this.Controls.Add(this.audioBitrateLabel2);
            this.Controls.Add(this.audioBitrateLabel1);
            this.Controls.Add(this.audioBitrate);
            this.Controls.Add(this.rescaleLabel);
            this.Controls.Add(this.scale);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.outputButton);
            this.Controls.Add(this.videoBitrate);
            this.Controls.Add(this.videoBitrateLabel2);
            this.Controls.Add(this.videoBitrateLabel1);
            this.Controls.Add(this.duration);
            this.Controls.Add(this.durationLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.startTime);
            this.Controls.Add(this.startLabel);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.inputLabel);
            this.Controls.Add(this.inputButton);
            this.Name = "Form1";
            this.Text = "GUIffmpeg";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button inputButton;
        private System.Windows.Forms.OpenFileDialog inputDialog;
        private System.Windows.Forms.Label inputLabel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label startLabel;
        private System.Windows.Forms.TextBox startTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox duration;
        private System.Windows.Forms.Label durationLabel;
        private System.Windows.Forms.Label videoBitrateLabel1;
        private System.Windows.Forms.Label videoBitrateLabel2;
        private System.Windows.Forms.TextBox videoBitrate;
        private System.Windows.Forms.FolderBrowserDialog folderDialog;
        private System.Windows.Forms.Button outputButton;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.TextBox scale;
        private System.Windows.Forms.Label rescaleLabel;
        private System.Windows.Forms.TextBox audioBitrate;
        private System.Windows.Forms.Label audioBitrateLabel1;
        private System.Windows.Forms.Label audioBitrateLabel2;
        private System.Windows.Forms.CheckBox scaleCheck;
        private System.Windows.Forms.Label passLabel;
        private System.Windows.Forms.CheckBox passCheck;
    }
}

