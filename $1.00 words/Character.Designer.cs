namespace _1._00_words
{
    partial class Character
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
            this.remove = new System.Windows.Forms.Label();
            this.idRemove = new System.Windows.Forms.ComboBox();
            this.doRemove = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Label();
            this.value = new System.Windows.Forms.TextBox();
            this.doAdd = new System.Windows.Forms.Button();
            this.cent = new System.Windows.Forms.Label();
            this.idAdd = new System.Windows.Forms.TextBox();
            this.showSpecial = new System.Windows.Forms.LinkLabel();
            this.shutDown = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // remove
            // 
            this.remove.AutoSize = true;
            this.remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remove.Location = new System.Drawing.Point(13, 12);
            this.remove.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.remove.Name = "remove";
            this.remove.Size = new System.Drawing.Size(273, 31);
            this.remove.TabIndex = 0;
            this.remove.Text = "Remove Characters";
            // 
            // idRemove
            // 
            this.idRemove.FormattingEnabled = true;
            this.idRemove.Items.AddRange(new object[] {
            "Select a character..."});
            this.idRemove.Location = new System.Drawing.Point(20, 49);
            this.idRemove.Margin = new System.Windows.Forms.Padding(4);
            this.idRemove.Name = "idRemove";
            this.idRemove.Size = new System.Drawing.Size(160, 24);
            this.idRemove.TabIndex = 1;
            this.idRemove.Enter += new System.EventHandler(this.changeDefaultButton);
            // 
            // doRemove
            // 
            this.doRemove.Location = new System.Drawing.Point(20, 105);
            this.doRemove.Margin = new System.Windows.Forms.Padding(4);
            this.doRemove.Name = "doRemove";
            this.doRemove.Size = new System.Drawing.Size(100, 28);
            this.doRemove.TabIndex = 2;
            this.doRemove.Text = "Remove character";
            this.doRemove.UseVisualStyleBackColor = true;
            this.doRemove.Click += new System.EventHandler(this.destroy);
            // 
            // add
            // 
            this.add.AutoSize = true;
            this.add.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.Location = new System.Drawing.Point(20, 209);
            this.add.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(211, 31);
            this.add.TabIndex = 3;
            this.add.Text = "Add characters";
            // 
            // value
            // 
            this.value.Location = new System.Drawing.Point(20, 283);
            this.value.Margin = new System.Windows.Forms.Padding(4);
            this.value.Name = "value";
            this.value.Size = new System.Drawing.Size(132, 22);
            this.value.TabIndex = 5;
            this.value.Text = "Value...";
            this.value.Enter += new System.EventHandler(this.changeDefaultButton);
            // 
            // doAdd
            // 
            this.doAdd.Location = new System.Drawing.Point(20, 314);
            this.doAdd.Margin = new System.Windows.Forms.Padding(4);
            this.doAdd.Name = "doAdd";
            this.doAdd.Size = new System.Drawing.Size(100, 28);
            this.doAdd.TabIndex = 6;
            this.doAdd.Text = "Add";
            this.doAdd.UseVisualStyleBackColor = true;
            this.doAdd.Click += new System.EventHandler(this.create);
            // 
            // cent
            // 
            this.cent.AutoSize = true;
            this.cent.Location = new System.Drawing.Point(161, 287);
            this.cent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cent.Name = "cent";
            this.cent.Size = new System.Drawing.Size(16, 17);
            this.cent.TabIndex = 7;
            this.cent.Text = "¢";
            // 
            // idAdd
            // 
            this.idAdd.Location = new System.Drawing.Point(20, 246);
            this.idAdd.Margin = new System.Windows.Forms.Padding(4);
            this.idAdd.Name = "idAdd";
            this.idAdd.Size = new System.Drawing.Size(160, 22);
            this.idAdd.TabIndex = 8;
            this.idAdd.Text = "Select a character...";
            this.idAdd.Enter += new System.EventHandler(this.changeDefaultButton);
            // 
            // showSpecial
            // 
            this.showSpecial.ActiveLinkColor = System.Drawing.Color.Blue;
            this.showSpecial.AutoSize = true;
            this.showSpecial.Location = new System.Drawing.Point(193, 251);
            this.showSpecial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.showSpecial.Name = "showSpecial";
            this.showSpecial.Size = new System.Drawing.Size(65, 17);
            this.showSpecial.TabIndex = 9;
            this.showSpecial.TabStop = true;
            this.showSpecial.Text = "Charmap";
            this.showSpecial.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.charmap);
            this.showSpecial.Enter += new System.EventHandler(this.changeDefaultButton);
            // 
            // shutDown
            // 
            this.shutDown.Location = new System.Drawing.Point(93, 351);
            this.shutDown.Margin = new System.Windows.Forms.Padding(4);
            this.shutDown.Name = "shutDown";
            this.shutDown.Size = new System.Drawing.Size(133, 31);
            this.shutDown.TabIndex = 10;
            this.shutDown.Text = "Close";
            this.shutDown.UseVisualStyleBackColor = true;
            this.shutDown.Click += new System.EventHandler(this.exit);
            // 
            // Character
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(312, 399);
            this.Controls.Add(this.shutDown);
            this.Controls.Add(this.showSpecial);
            this.Controls.Add(this.idAdd);
            this.Controls.Add(this.cent);
            this.Controls.Add(this.doAdd);
            this.Controls.Add(this.value);
            this.Controls.Add(this.add);
            this.Controls.Add(this.doRemove);
            this.Controls.Add(this.idRemove);
            this.Controls.Add(this.remove);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Character";
            this.Text = "Special Characters";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.Label remove;
        private System.Windows.Forms.ComboBox idRemove;
        private System.Windows.Forms.Button doRemove;
        private System.Windows.Forms.Label add;
        private System.Windows.Forms.TextBox value;
        private System.Windows.Forms.Button doAdd;
        private System.Windows.Forms.Label cent;
        private System.Windows.Forms.TextBox idAdd;
        private System.Windows.Forms.LinkLabel showSpecial;
        private System.Windows.Forms.Button shutDown;
    }
}