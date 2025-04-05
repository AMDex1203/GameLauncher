namespace GameLauncher
{
    partial class CheckForm
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
            this.STR_CHECK = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // STR_CHECK
            // 
            this.STR_CHECK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.STR_CHECK.Location = new System.Drawing.Point(0, 15);
            this.STR_CHECK.Name = "STR_CHECK";
            this.STR_CHECK.Size = new System.Drawing.Size(400, 20);
            this.STR_CHECK.TabIndex = 0;
            this.STR_CHECK.Text = "STR_CHECK";
            this.STR_CHECK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CheckForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(400, 50);
            this.Controls.Add(this.STR_CHECK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CheckForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CheckForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label STR_CHECK;
    }
}