namespace DungeonCrawlerForms
{
    partial class ItemForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.Add = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.South = new System.Windows.Forms.Label();
            this.CanUseBox = new System.Windows.Forms.TextBox();
            this.PriceBox = new System.Windows.Forms.TextBox();
            this.North = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.DescriptionBox = new System.Windows.Forms.TextBox();
            this.Description = new System.Windows.Forms.Label();
            this.Name = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.IDBox = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(107, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 31);
            this.label1.TabIndex = 10;
            this.label1.Text = "Item Creation";
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(165, 220);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 9;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.South);
            this.groupBox1.Controls.Add(this.CanUseBox);
            this.groupBox1.Controls.Add(this.PriceBox);
            this.groupBox1.Controls.Add(this.North);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.DescriptionBox);
            this.groupBox1.Controls.Add(this.Description);
            this.groupBox1.Controls.Add(this.Name);
            this.groupBox1.Controls.Add(this.NameBox);
            this.groupBox1.Controls.Add(this.IDBox);
            this.groupBox1.Controls.Add(this.ID);
            this.groupBox1.Location = new System.Drawing.Point(12, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(374, 170);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // South
            // 
            this.South.AutoSize = true;
            this.South.Location = new System.Drawing.Point(6, 136);
            this.South.Name = "South";
            this.South.Size = new System.Drawing.Size(48, 13);
            this.South.TabIndex = 10;
            this.South.Tag = "Exit South";
            this.South.Text = "Can Use";
            // 
            // CanUseBox
            // 
            this.CanUseBox.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.CanUseBox.Location = new System.Drawing.Point(72, 133);
            this.CanUseBox.Multiline = true;
            this.CanUseBox.Name = "CanUseBox";
            this.CanUseBox.Size = new System.Drawing.Size(282, 20);
            this.CanUseBox.TabIndex = 9;
            this.CanUseBox.Text = "Enter if the player can use the item (true/false)";
            // 
            // PriceBox
            // 
            this.PriceBox.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.PriceBox.Location = new System.Drawing.Point(72, 107);
            this.PriceBox.Multiline = true;
            this.PriceBox.Name = "PriceBox";
            this.PriceBox.Size = new System.Drawing.Size(282, 20);
            this.PriceBox.TabIndex = 8;
            this.PriceBox.Text = "Enter how much the item is worth";
            // 
            // North
            // 
            this.North.AutoSize = true;
            this.North.Location = new System.Drawing.Point(6, 110);
            this.North.Name = "North";
            this.North.Size = new System.Drawing.Size(31, 13);
            this.North.TabIndex = 7;
            this.North.Text = "Price";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(72, 161);
            this.textBox3.MaximumSize = new System.Drawing.Size(4, 100);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(0, 20);
            this.textBox3.TabIndex = 6;
            this.textBox3.Text = "Enter ID to room north of this room or -1 for nothing";
            // 
            // DescriptionBox
            // 
            this.DescriptionBox.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.DescriptionBox.Location = new System.Drawing.Point(72, 81);
            this.DescriptionBox.Name = "DescriptionBox";
            this.DescriptionBox.Size = new System.Drawing.Size(282, 20);
            this.DescriptionBox.TabIndex = 5;
            this.DescriptionBox.Text = "Enter Description of the item";
            // 
            // Description
            // 
            this.Description.AutoSize = true;
            this.Description.Location = new System.Drawing.Point(6, 84);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(60, 13);
            this.Description.TabIndex = 4;
            this.Description.Text = "Description";
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Location = new System.Drawing.Point(6, 58);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(35, 13);
            this.Name.TabIndex = 3;
            this.Name.Text = "Name";
            // 
            // NameBox
            // 
            this.NameBox.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.NameBox.Location = new System.Drawing.Point(72, 55);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(282, 20);
            this.NameBox.TabIndex = 2;
            this.NameBox.Text = "Enter Item Name";
            // 
            // IDBox
            // 
            this.IDBox.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.IDBox.Location = new System.Drawing.Point(72, 29);
            this.IDBox.Name = "IDBox";
            this.IDBox.Size = new System.Drawing.Size(282, 20);
            this.IDBox.TabIndex = 1;
            this.IDBox.Text = "Enter Item ID";
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(8, 32);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(18, 13);
            this.ID.TabIndex = 0;
            this.ID.Text = "ID";
            // 
            // ItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 251);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.groupBox1);
            this.Text = "Item";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label South;
        private System.Windows.Forms.TextBox CanUseBox;
        private System.Windows.Forms.TextBox PriceBox;
        private System.Windows.Forms.Label North;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox DescriptionBox;
        private System.Windows.Forms.Label Description;
        private new System.Windows.Forms.Label Name;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox IDBox;
        private System.Windows.Forms.Label ID;
    }
}