namespace DungeonCrawlerForms
{
    partial class WeaponCreation
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
            this.WeaponCreationLabel = new System.Windows.Forms.Label();
            this.Add = new System.Windows.Forms.Button();
            this.DiceSidesBox = new System.Windows.Forms.TextBox();
            this.Up = new System.Windows.Forms.Label();
            this.DiceAmountBox = new System.Windows.Forms.TextBox();
            this.DamageBox = new System.Windows.Forms.TextBox();
            this.West = new System.Windows.Forms.Label();
            this.East = new System.Windows.Forms.Label();
            this.South = new System.Windows.Forms.Label();
            this.CanEquipBox = new System.Windows.Forms.TextBox();
            this.PriceBox = new System.Windows.Forms.TextBox();
            this.North = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.DescriptionBox = new System.Windows.Forms.TextBox();
            this.Description = new System.Windows.Forms.Label();
            this.Name = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.IDBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ID = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // WeaponCreationLabel
            // 
            this.WeaponCreationLabel.AutoSize = true;
            this.WeaponCreationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeaponCreationLabel.Location = new System.Drawing.Point(89, 13);
            this.WeaponCreationLabel.Name = "WeaponCreationLabel";
            this.WeaponCreationLabel.Size = new System.Drawing.Size(239, 31);
            this.WeaponCreationLabel.TabIndex = 7;
            this.WeaponCreationLabel.Text = "Weapon Creation";
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(173, 302);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 6;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            // 
            // DiceSidesBox
            // 
            this.DiceSidesBox.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.DiceSidesBox.Location = new System.Drawing.Point(72, 211);
            this.DiceSidesBox.Multiline = true;
            this.DiceSidesBox.Name = "DiceSidesBox";
            this.DiceSidesBox.Size = new System.Drawing.Size(282, 20);
            this.DiceSidesBox.TabIndex = 18;
            this.DiceSidesBox.Text = "Enter the amount of sides the dice rolled has";
            // 
            // Up
            // 
            this.Up.AutoSize = true;
            this.Up.Location = new System.Drawing.Point(6, 214);
            this.Up.Name = "Up";
            this.Up.Size = new System.Drawing.Size(58, 13);
            this.Up.TabIndex = 15;
            this.Up.Tag = "";
            this.Up.Text = "Dice Sides";
            // 
            // DiceAmountBox
            // 
            this.DiceAmountBox.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.DiceAmountBox.Location = new System.Drawing.Point(72, 185);
            this.DiceAmountBox.Multiline = true;
            this.DiceAmountBox.Name = "DiceAmountBox";
            this.DiceAmountBox.Size = new System.Drawing.Size(282, 20);
            this.DiceAmountBox.TabIndex = 14;
            this.DiceAmountBox.Text = "Enter the amount of dice rolled for weapon attack";
            // 
            // DamageBox
            // 
            this.DamageBox.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.DamageBox.Location = new System.Drawing.Point(72, 159);
            this.DamageBox.Multiline = true;
            this.DamageBox.Name = "DamageBox";
            this.DamageBox.Size = new System.Drawing.Size(282, 20);
            this.DamageBox.TabIndex = 13;
            this.DamageBox.Text = "Enter the damage type (blunt/slashing/piercing)";
            // 
            // West
            // 
            this.West.AutoSize = true;
            this.West.Location = new System.Drawing.Point(6, 188);
            this.West.Name = "West";
            this.West.Size = new System.Drawing.Size(68, 13);
            this.West.TabIndex = 12;
            this.West.Tag = "";
            this.West.Text = "Dice Amount";
            // 
            // East
            // 
            this.East.AutoSize = true;
            this.East.Location = new System.Drawing.Point(6, 162);
            this.East.Name = "East";
            this.East.Size = new System.Drawing.Size(47, 13);
            this.East.TabIndex = 11;
            this.East.Tag = "Exit South";
            this.East.Text = "Damage";
            // 
            // South
            // 
            this.South.AutoSize = true;
            this.South.Location = new System.Drawing.Point(6, 136);
            this.South.Name = "South";
            this.South.Size = new System.Drawing.Size(53, 13);
            this.South.TabIndex = 10;
            this.South.Tag = "Exit South";
            this.South.Text = "CanEquip";
            // 
            // CanEquipBox
            // 
            this.CanEquipBox.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.CanEquipBox.Location = new System.Drawing.Point(72, 133);
            this.CanEquipBox.Multiline = true;
            this.CanEquipBox.Name = "CanEquipBox";
            this.CanEquipBox.Size = new System.Drawing.Size(282, 20);
            this.CanEquipBox.TabIndex = 9;
            this.CanEquipBox.Text = "Enter if the player can equipt the weapon (true/false)";
            // 
            // PriceBox
            // 
            this.PriceBox.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.PriceBox.Location = new System.Drawing.Point(72, 107);
            this.PriceBox.Multiline = true;
            this.PriceBox.Name = "PriceBox";
            this.PriceBox.Size = new System.Drawing.Size(282, 20);
            this.PriceBox.TabIndex = 8;
            this.PriceBox.Text = "Enter how much the weapon is worth";
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
            this.DescriptionBox.Text = "Enter Description of the weapon";
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
            this.NameBox.Text = "Enter Weapon Name";
            // 
            // IDBox
            // 
            this.IDBox.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.IDBox.Location = new System.Drawing.Point(72, 29);
            this.IDBox.Name = "IDBox";
            this.IDBox.Size = new System.Drawing.Size(282, 20);
            this.IDBox.TabIndex = 1;
            this.IDBox.Text = "Enter Weapon ID";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DiceSidesBox);
            this.groupBox1.Controls.Add(this.Up);
            this.groupBox1.Controls.Add(this.DiceAmountBox);
            this.groupBox1.Controls.Add(this.DamageBox);
            this.groupBox1.Controls.Add(this.West);
            this.groupBox1.Controls.Add(this.East);
            this.groupBox1.Controls.Add(this.South);
            this.groupBox1.Controls.Add(this.CanEquipBox);
            this.groupBox1.Controls.Add(this.PriceBox);
            this.groupBox1.Controls.Add(this.North);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.DescriptionBox);
            this.groupBox1.Controls.Add(this.Description);
            this.groupBox1.Controls.Add(this.Name);
            this.groupBox1.Controls.Add(this.NameBox);
            this.groupBox1.Controls.Add(this.IDBox);
            this.groupBox1.Controls.Add(this.ID);
            this.groupBox1.Location = new System.Drawing.Point(14, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(374, 249);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
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
            // WeaponCreation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 337);
            this.Controls.Add(this.WeaponCreationLabel);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.groupBox1);
            this.Text = "Weapon";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WeaponCreationLabel;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.TextBox DiceSidesBox;
        private System.Windows.Forms.Label Up;
        private System.Windows.Forms.TextBox DiceAmountBox;
        private System.Windows.Forms.TextBox DamageBox;
        private System.Windows.Forms.Label West;
        private System.Windows.Forms.Label East;
        private System.Windows.Forms.Label South;
        private System.Windows.Forms.TextBox CanEquipBox;
        private System.Windows.Forms.TextBox PriceBox;
        private System.Windows.Forms.Label North;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox DescriptionBox;
        private System.Windows.Forms.Label Description;
        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox IDBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label ID;
    }
}