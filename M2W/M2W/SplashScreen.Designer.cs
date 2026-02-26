
namespace M2W
{
    partial class SplashScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashScreen));
            pictureBoxLogo = new PictureBox();
            lblAppName = new Label();
            lblVersion = new Label();
            lblStatus = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Dock = DockStyle.Fill;
            pictureBoxLogo.Image = (Image)resources.GetObject("pictureBoxLogo.Image");
            pictureBoxLogo.Location = new Point(0, 0);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(496, 217);
            pictureBoxLogo.TabIndex = 0;
            pictureBoxLogo.TabStop = false;
            // 
            // lblAppName
            // 
            lblAppName.AccessibleDescription = "For the app name";
            lblAppName.AutoSize = true;
            lblAppName.Location = new Point(12, 163);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(74, 15);
            lblAppName.TabIndex = 1;
            lblAppName.Text = "lblAppName";
            // 
            // lblVersion
            // 
            lblVersion.AccessibleDescription = "To display the version";
            lblVersion.AutoSize = true;
            lblVersion.Location = new Point(12, 193);
            lblVersion.Name = "lblVersion";
            lblVersion.Size = new Size(58, 15);
            lblVersion.TabIndex = 2;
            lblVersion.Text = "lblVersion";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(12, 178);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(52, 15);
            lblStatus.TabIndex = 3;
            lblStatus.Text = "lblStatus";
            // 
            // SplashScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(496, 217);
            Controls.Add(lblStatus);
            Controls.Add(lblVersion);
            Controls.Add(lblAppName);
            Controls.Add(pictureBoxLogo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "SplashScreen";
            Text = "SplashScreen";
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxLogo;
        private Label lblAppName;
        private Label lblVersion;
        private Label lblStatus;
    }
}