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
            ((System.ComponentModel.ISupportInitialize)(this.happy)).BeginInit();
            this.SuspendLayout();
            // 
            // aboutDisplay
            // 
            this.aboutDisplay.AutoSize = true;
            this.aboutDisplay.Location = new System.Drawing.Point(10, 60);
            this.aboutDisplay.Name = "aboutDisplay";
            this.aboutDisplay.Size = new System.Drawing.Size(241, 13);
            this.aboutDisplay.TabIndex = 0;
            this.aboutDisplay.Text = "created by Jacob Manaker for Mrs. Yantosh 2010";
            // 
            // happy
            // 
            this.happy.Image = global::_1._00_words.Properties.Resources.Face;
            this.happy.InitialImage = global::_1._00_words.Properties.Resources.Face;
            this.happy.Location = new System.Drawing.Point(120, 10);
            this.happy.Name = "happy";
            this.happy.Size = new System.Drawing.Size(24, 22);
            this.happy.TabIndex = 1;
            this.happy.TabStop = false;
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 89);
            this.Controls.Add(this.happy);
            this.Controls.Add(this.aboutDisplay);
            this.Name = "About";
            this.Text = "About";
            ((System.ComponentModel.ISupportInitialize)(this.happy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label aboutDisplay;
        private System.Windows.Forms.PictureBox happy;
    }
}