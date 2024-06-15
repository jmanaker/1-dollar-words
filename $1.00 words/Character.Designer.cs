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
            this.remove.Location = new System.Drawing.Point(10, 10);
            this.remove.Name = "remove";
            this.remove.Size = new System.Drawing.Size(219, 25);
            this.remove.TabIndex = 0;
            this.remove.Text = "Remove Characters";
            // 
            // idRemove
            // 
            this.idRemove.FormattingEnabled = true;
            this.idRemove.Items.AddRange(new object[] {
            "Select a character..."});
            this.idRemove.Location = new System.Drawing.Point(15, 40);
            this.idRemove.Name = "idRemove";
            this.idRemove.Size = new System.Drawing.Size(121, 21);
            this.idRemove.TabIndex = 1;
            // 
            // doRemove
            // 
            this.doRemove.Location = new System.Drawing.Point(15, 85);
            this.doRemove.Name = "doRemove";
            this.doRemove.Size = new System.Drawing.Size(75, 23);
            this.doRemove.TabIndex = 2;
            this.doRemove.Text = "Remove character";
            this.doRemove.UseVisualStyleBackColor = true;
            this.doRemove.Click += new System.EventHandler(this.destroy);
            // 
            // add
            // 
            this.add.AutoSize = true;
            this.add.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.Location = new System.Drawing.Point(15, 170);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(171, 25);
            this.add.TabIndex = 3;
            this.add.Text = "Add characters";
            // 
            // value
            // 
            this.value.Location = new System.Drawing.Point(15, 230);
            this.value.Name = "value";
            this.value.Size = new System.Drawing.Size(100, 20);
            this.value.TabIndex = 5;
            this.value.Text = "Value...";
            // 
            // doAdd
            // 
            this.doAdd.Location = new System.Drawing.Point(15, 255);
            this.doAdd.Name = "doAdd";
            this.doAdd.Size = new System.Drawing.Size(75, 23);
            this.doAdd.TabIndex = 6;
            this.doAdd.Text = "Add";
            this.doAdd.UseVisualStyleBackColor = true;
            this.doAdd.Click += new System.EventHandler(this.create);
            // 
            // cent
            // 
            this.cent.AutoSize = true;
            this.cent.Location = new System.Drawing.Point(121, 233);
            this.cent.Name = "cent";
            this.cent.Size = new System.Drawing.Size(13, 13);
            this.cent.TabIndex = 7;
            this.cent.Text = "¢";
            // 
            // idAdd
            // 
            this.idAdd.Location = new System.Drawing.Point(15, 200);
            this.idAdd.Name = "idAdd";
            this.idAdd.Size = new System.Drawing.Size(121, 20);
            this.idAdd.TabIndex = 8;
            this.idAdd.Text = "Select a character...";
            // 
            // showSpecial
            // 
            this.showSpecial.ActiveLinkColor = System.Drawing.Color.Blue;
            this.showSpecial.AutoSize = true;
            this.showSpecial.Location = new System.Drawing.Point(145, 204);
            this.showSpecial.Name = "showSpecial";
            this.showSpecial.Size = new System.Drawing.Size(49, 13);
            this.showSpecial.TabIndex = 9;
            this.showSpecial.TabStop = true;
            this.showSpecial.Text = "Charmap";
            this.showSpecial.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.charmap);
            // 
            // shutDown
            // 
            this.shutDown.Location = new System.Drawing.Point(70, 285);
            this.shutDown.Name = "shutDown";
            this.shutDown.Size = new System.Drawing.Size(100, 25);
            this.shutDown.TabIndex = 10;
            this.shutDown.Text = "Close";
            this.shutDown.UseVisualStyleBackColor = true;
            this.shutDown.Click += new System.EventHandler(this.exit);
            // 
            // Character
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(234, 324);
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