namespace GameUpdater
{
    partial class MainForm
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
            this.DownloadBar = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.SuspendLayout();
            // 
            // DownloadBar
            // 
            this.DownloadBar.Location = new System.Drawing.Point(12, 240);
            this.DownloadBar.Name = "DownloadBar";
            this.DownloadBar.ProgressColor = System.Drawing.Color.Black;
            this.DownloadBar.ProgressColor2 = System.Drawing.Color.Black;
            this.DownloadBar.ShadowDecoration.Color = System.Drawing.Color.Red;
            this.DownloadBar.ShadowDecoration.Enabled = true;
            this.DownloadBar.Size = new System.Drawing.Size(530, 10);
            this.DownloadBar.TabIndex = 0;
            this.DownloadBar.Text = "guna2ProgressBar1";
            this.DownloadBar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(547, 294);
            this.Controls.Add(this.DownloadBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ProgressBar DownloadBar;
    }
}

