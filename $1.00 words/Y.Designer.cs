namespace _1._00_words
{
    partial class Y
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
            this.details = new System.Windows.Forms.Label();
            this.holder = new System.Windows.Forms.GroupBox();
            this.sometimesVowel = new System.Windows.Forms.RadioButton();
            this.neverVowel = new System.Windows.Forms.RadioButton();
            this.alwaysVowel = new System.Windows.Forms.RadioButton();
            this.close = new System.Windows.Forms.Button();
            this.holder.SuspendLayout();
            this.SuspendLayout();
            // 
            // details
            // 
            this.details.AutoSize = true;
            this.details.Location = new System.Drawing.Point(15, 15);
            this.details.Name = "details";
            this.details.Size = new System.Drawing.Size(74, 13);
            this.details.TabIndex = 0;
            this.details.Text = "Y settings are:";
            // 
            // holder
            // 
            this.holder.Controls.Add(this.sometimesVowel);
            this.holder.Controls.Add(this.neverVowel);
            this.holder.Controls.Add(this.alwaysVowel);
            this.holder.Location = new System.Drawing.Point(18, 32);
            this.holder.Name = "holder";
            this.holder.Size = new System.Drawing.Size(269, 105);
            this.holder.TabIndex = 1;
            this.holder.TabStop = false;
            // 
            // sometimesVowel
            // 
            this.sometimesVowel.AutoSize = true;
            this.sometimesVowel.Location = new System.Drawing.Point(5, 70);
            this.sometimesVowel.Name = "sometimesVowel";
            this.sometimesVowel.Size = new System.Drawing.Size(248, 17);
            this.sometimesVowel.TabIndex = 2;
            this.sometimesVowel.TabStop = true;
            this.sometimesVowel.Text = "Y is only a vowel if it is not at the start of a word";
            this.sometimesVowel.UseVisualStyleBackColor = true;
            // 
            // neverVowel
            // 
            this.neverVowel.AutoSize = true;
            this.neverVowel.Location = new System.Drawing.Point(5, 45);
            this.neverVowel.Name = "neverVowel";
            this.neverVowel.Size = new System.Drawing.Size(112, 17);
            this.neverVowel.TabIndex = 1;
            this.neverVowel.TabStop = true;
            this.neverVowel.Text = "Y is never a vowel";
            this.neverVowel.UseVisualStyleBackColor = true;
            // 
            // alwaysVowel
            // 
            this.alwaysVowel.AutoSize = true;
            this.alwaysVowel.Location = new System.Drawing.Point(5, 20);
            this.alwaysVowel.Name = "alwaysVowel";
            this.alwaysVowel.Size = new System.Drawing.Size(117, 17);
            this.alwaysVowel.TabIndex = 0;
            this.alwaysVowel.TabStop = true;
            this.alwaysVowel.Text = "Y is always a vowel";
            this.alwaysVowel.UseVisualStyleBackColor = true;
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(145, 135);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(75, 25);
            this.close.TabIndex = 2;
            this.close.Text = "OK";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.exit);
            // 
            // Y
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 169);
            this.ControlBox = false;
            this.Controls.Add(this.close);
            this.Controls.Add(this.holder);
            this.Controls.Add(this.details);
            this.Name = "Y";
            this.Text = "Y";
            this.holder.ResumeLayout(false);
            this.holder.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label details;
        private System.Windows.Forms.GroupBox holder;
        private System.Windows.Forms.RadioButton neverVowel;
        private System.Windows.Forms.RadioButton alwaysVowel;
        private System.Windows.Forms.RadioButton sometimesVowel;
        private System.Windows.Forms.Button close;
    }
}