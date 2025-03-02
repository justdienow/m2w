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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // txtInputPath
            // 
            txtInputPath.AccessibleDescription = "For the MP3 file path.";
            txtInputPath.Location = new Point(80, 15);
            txtInputPath.Name = "txtInputPath";
            txtInputPath.Size = new Size(294, 23);
            txtInputPath.TabIndex = 0;
            // 
            // btnBrowseInput
            // 
            btnBrowseInput.AccessibleDescription = "For selecting an MP3 file.";
            btnBrowseInput.Location = new Point(406, 15);
            btnBrowseInput.Name = "btnBrowseInput";
            btnBrowseInput.Size = new Size(75, 23);
            btnBrowseInput.TabIndex = 1;
            btnBrowseInput.Text = "Select";
            btnBrowseInput.UseVisualStyleBackColor = true;
            btnBrowseInput.Click += btnBrowseInput_Click;
            // 
            // txtOutputPath
            // 
            txtOutputPath.AccessibleDescription = "For the WAV file path.";
            txtOutputPath.Location = new Point(80, 53);
            txtOutputPath.Name = "txtOutputPath";
            txtOutputPath.Size = new Size(294, 23);
            txtOutputPath.TabIndex = 2;
            // 
            // btnBrowseOutput
            // 
            btnBrowseOutput.AccessibleDescription = "For selecting output location.";
            btnBrowseOutput.Location = new Point(406, 53);
            btnBrowseOutput.Name = "btnBrowseOutput";
            btnBrowseOutput.Size = new Size(75, 23);
            btnBrowseOutput.TabIndex = 3;
            btnBrowseOutput.Text = "Select";
            btnBrowseOutput.UseVisualStyleBackColor = true;
            btnBrowseOutput.Click += btnBrowseOutput_Click;
            // 
            // btnConvert
            // 
            btnConvert.AccessibleDescription = "To start conversion.";
            btnConvert.Location = new Point(299, 103);
            btnConvert.Name = "btnConvert";
            btnConvert.Size = new Size(75, 23);
            btnConvert.TabIndex = 4;
            btnConvert.Text = "Convert";
            btnConvert.UseVisualStyleBackColor = true;
            btnConvert.Click += btnConvert_Click;
            // 
            // btnCancel
            // 
            btnCancel.AccessibleDescription = "To cancel conversion.";
            btnCancel.Location = new Point(406, 103);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // progressBar
            // 
            progressBar.AccessibleDescription = "To show conversion progress.";
            progressBar.Location = new Point(12, 82);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(469, 15);
            progressBar.TabIndex = 6;
            // 
            // lblStatus
            // 
            lblStatus.AccessibleDescription = "To display status messages.";
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(10, 107);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(45, 15);
            lblStatus.TabIndex = 7;
            lblStatus.Text = "Status: ";
            // 
            // rtbLog
            // 
            rtbLog.AccessibleDescription = "To log messages.";
            rtbLog.Location = new Point(12, 160);
            rtbLog.Name = "rtbLog";
            rtbLog.Size = new Size(469, 173);
            rtbLog.TabIndex = 8;
            rtbLog.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 9;
            label1.Text = "Source file:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 56);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 10;
            label2.Text = "Output file:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 142);
            label3.Name = "label3";
            label3.Size = new Size(32, 15);
            label3.TabIndex = 11;
            label3.Text = "Logs";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(490, 343);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
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
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
