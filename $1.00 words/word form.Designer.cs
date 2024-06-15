namespace _1._00_words
{
    partial class WordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WordForm));
            this.title = new System.Windows.Forms.Label();
            this.instructions = new System.Windows.Forms.Label();
            this.wordBox = new System.Windows.Forms.TextBox();
            this.value = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.personalizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCharacterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vowelsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ySettings = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(290, 30);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(200, 45);
            this.title.TabIndex = 0;
            this.title.Text = "$1.00 Words";
            // 
            // instructions
            // 
            this.instructions.Location = new System.Drawing.Point(15, 95);
            this.instructions.Name = "instructions";
            this.instructions.Size = new System.Drawing.Size(710, 46);
            this.instructions.TabIndex = 1;
            this.instructions.Text = resources.GetString("instructions.Text");
            // 
            // wordBox
            // 
            this.wordBox.AcceptsReturn = true;
            this.wordBox.AllowDrop = true;
            this.wordBox.Location = new System.Drawing.Point(110, 160);
            this.wordBox.Multiline = true;
            this.wordBox.Name = "wordBox";
            this.wordBox.Size = new System.Drawing.Size(500, 40);
            this.wordBox.TabIndex = 2;
            // 
            // value
            // 
            this.value.AutoSize = true;
            this.value.Location = new System.Drawing.Point(110, 220);
            this.value.Name = "value";
            this.value.Size = new System.Drawing.Size(0, 13);
            this.value.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personalizeToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(824, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // personalizeToolStripMenuItem
            // 
            this.personalizeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCharacterToolStripMenuItem,
            this.vowelsToolStripMenuItem,
            this.ySettings});
            this.personalizeToolStripMenuItem.Name = "personalizeToolStripMenuItem";
            this.personalizeToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.personalizeToolStripMenuItem.Text = "Personalize";
            // 
            // addCharacterToolStripMenuItem
            // 
            this.addCharacterToolStripMenuItem.Name = "addCharacterToolStripMenuItem";
            this.addCharacterToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.addCharacterToolStripMenuItem.Text = "Special Characters";
            this.addCharacterToolStripMenuItem.Click += new System.EventHandler(this.showCharacters);
            // 
            // vowelsToolStripMenuItem
            // 
            this.vowelsToolStripMenuItem.Name = "vowelsToolStripMenuItem";
            this.vowelsToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.vowelsToolStripMenuItem.Text = "Vowels";
            this.vowelsToolStripMenuItem.Click += new System.EventHandler(this.askVowels);
            // 
            // ySettings
            // 
            this.ySettings.Name = "ySettings";
            this.ySettings.Size = new System.Drawing.Size(170, 22);
            this.ySettings.Text = "Y settings";
            this.ySettings.Click += new System.EventHandler(this.showY);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.showAbout);
            // 
            // WordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(824, 439);
            this.Controls.Add(this.value);
            this.Controls.Add(this.wordBox);
            this.Controls.Add(this.instructions);
            this.Controls.Add(this.title);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "WordForm";
            this.Text = "$1.00 words";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckCalc);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label instructions;
        private System.Windows.Forms.TextBox wordBox;
        private System.Windows.Forms.Label value;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem personalizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCharacterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vowelsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ySettings;
    }
}

