namespace M2W
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
            txtInputPath = new TextBox();
            btnBrowseInput = new Button();
            txtOutputPath = new TextBox();
            btnBrowseOutput = new Button();
            btnConvert = new Button();
            btnCancel = new Button();
            progressBar = new ProgressBar();
            lblStatus = new Label();
            rtbLog = new RichTextBox();
            SuspendLayout();
            // 
            // txtInputPath
            // 
            txtInputPath.AccessibleDescription = "For the MP3 file path.";
            txtInputPath.Location = new Point(12, 12);
            txtInputPath.Name = "txtInputPath";
            txtInputPath.Size = new Size(294, 23);
            txtInputPath.TabIndex = 0;
            txtInputPath.TextChanged += textBox1_TextChanged;
            // 
            // btnBrowseInput
            // 
            btnBrowseInput.AccessibleDescription = "For selecting an MP3 file.";
            btnBrowseInput.Location = new Point(338, 12);
            btnBrowseInput.Name = "btnBrowseInput";
            btnBrowseInput.Size = new Size(75, 23);
            btnBrowseInput.TabIndex = 1;
            btnBrowseInput.Text = "Select";
            btnBrowseInput.UseVisualStyleBackColor = true;
            // 
            // txtOutputPath
            // 
            txtOutputPath.AccessibleDescription = "For the WAV file path.";
            txtOutputPath.Location = new Point(12, 50);
            txtOutputPath.Name = "txtOutputPath";
            txtOutputPath.Size = new Size(294, 23);
            txtOutputPath.TabIndex = 2;
            // 
            // btnBrowseOutput
            // 
            btnBrowseOutput.AccessibleDescription = "For selecting output location.";
            btnBrowseOutput.Location = new Point(338, 50);
            btnBrowseOutput.Name = "btnBrowseOutput";
            btnBrowseOutput.Size = new Size(75, 23);
            btnBrowseOutput.TabIndex = 3;
            btnBrowseOutput.Text = "Select";
            btnBrowseOutput.UseVisualStyleBackColor = true;
            // 
            // btnConvert
            // 
            btnConvert.AccessibleDescription = "To start conversion.";
            btnConvert.Location = new Point(231, 100);
            btnConvert.Name = "btnConvert";
            btnConvert.Size = new Size(75, 23);
            btnConvert.TabIndex = 4;
            btnConvert.Text = "Convert";
            btnConvert.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.AccessibleDescription = "To cancel conversion.";
            btnCancel.Location = new Point(338, 100);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // progressBar
            // 
            progressBar.AccessibleDescription = "To show conversion progress.";
            progressBar.Location = new Point(12, 79);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(401, 15);
            progressBar.TabIndex = 6;
            // 
            // lblStatus
            // 
            lblStatus.AccessibleDescription = "To display status messages.";
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(12, 108);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(38, 15);
            lblStatus.TabIndex = 7;
            lblStatus.Text = "label1";
            // 
            // rtbLog
            // 
            rtbLog.AccessibleDescription = "To log messages.";
            rtbLog.Location = new Point(12, 142);
            rtbLog.Name = "rtbLog";
            rtbLog.Size = new Size(401, 173);
            rtbLog.TabIndex = 8;
            rtbLog.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(426, 327);
            Controls.Add(rtbLog);
            Controls.Add(lblStatus);
            Controls.Add(progressBar);
            Controls.Add(btnCancel);
            Controls.Add(btnConvert);
            Controls.Add(btnBrowseOutput);
            Controls.Add(txtOutputPath);
            Controls.Add(btnBrowseInput);
            Controls.Add(txtInputPath);
            Name = "Form1";
            Text = "M2W";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtInputPath;
        private Button btnBrowseInput;
        private TextBox txtOutputPath;
        private Button btnBrowseOutput;
        private Button btnConvert;
        private Button btnCancel;
        private ProgressBar progressBar;
        private Label lblStatus;
        private RichTextBox rtbLog;
    }
}
