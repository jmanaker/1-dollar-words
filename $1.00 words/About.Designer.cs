namespace _1._00_words
{
    partial class About
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
            this.aboutDisplay = new System.Windows.Forms.Label();
            this.happy = new System.Windows.Forms.PictureBox();
            this.closeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.happy)).BeginInit();
            this.SuspendLayout();
            // 
            // aboutDisplay
            // 
            this.aboutDisplay.AutoSize = true;
            this.aboutDisplay.Location = new System.Drawing.Point(13, 43);
            this.aboutDisplay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.aboutDisplay.Name = "aboutDisplay";
            this.aboutDisplay.Size = new System.Drawing.Size(360, 17);
            this.aboutDisplay.TabIndex = 0;
            this.aboutDisplay.Text = "Created by Jacob Manaker for Mrs. Yantosh.\r\n\u00a92010";
            this.aboutDisplay.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // happy
            // 
            this.happy.Image = global::_1._00_words.Properties.Resources.Face;
            this.happy.InitialImage = global::_1._00_words.Properties.Resources.Face;
            this.happy.Location = new System.Drawing.Point(160, 12);
            this.happy.Margin = new System.Windows.Forms.Padding(4);
            this.happy.Name = "happy";
            this.happy.Size = new System.Drawing.Size(24, 27);
            this.happy.TabIndex = 1;
            this.happy.TabStop = false;
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(130, 97);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 2;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.close);
            // 
            // About
            // 
            this.AcceptButton = this.closeButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 132);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.happy);
            this.Controls.Add(this.aboutDisplay);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "About";
            this.Text = "About";
            ((System.ComponentModel.ISupportInitialize)(this.happy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label aboutDisplay;
        private System.Windows.Forms.PictureBox happy;
        private System.Windows.Forms.Button closeButton;
    }
}