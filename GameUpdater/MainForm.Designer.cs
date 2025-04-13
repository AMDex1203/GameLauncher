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
            this.components = new System.ComponentModel.Container();
            this.DownloadBar = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.MinimizeButton = new Guna.UI2.WinForms.Guna2ControlBox();
            this.SuspendLayout();
            // 
            // DownloadBar
            // 
            this.DownloadBar.Location = new System.Drawing.Point(0, 226);
            this.DownloadBar.Name = "DownloadBar";
            this.DownloadBar.ProgressColor = System.Drawing.Color.Black;
            this.DownloadBar.ProgressColor2 = System.Drawing.Color.Black;
            this.DownloadBar.ShadowDecoration.Color = System.Drawing.Color.Red;
            this.DownloadBar.ShadowDecoration.Enabled = true;
            this.DownloadBar.Size = new System.Drawing.Size(547, 10);
            this.DownloadBar.TabIndex = 0;
            this.DownloadBar.Text = "guna2ProgressBar1";
            this.DownloadBar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinimizeButton.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.MinimizeButton.CustomIconSize = 15F;
            this.MinimizeButton.FillColor = System.Drawing.Color.Transparent;
            this.MinimizeButton.IconColor = System.Drawing.Color.Red;
            this.MinimizeButton.Location = new System.Drawing.Point(497, 3);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(45, 29);
            this.MinimizeButton.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(547, 294);
            this.Controls.Add(this.MinimizeButton);
            this.Controls.Add(this.DownloadBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ProgressBar DownloadBar;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2ControlBox MinimizeButton;
    }
}

