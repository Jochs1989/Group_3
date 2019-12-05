namespace DungeonCrawlerForms
{
    partial class Menu
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
            this.OptionList = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Room = new System.Windows.Forms.Button();
            this.Mob = new System.Windows.Forms.Button();
            this.Weapon = new System.Windows.Forms.Button();
            this.Potion = new System.Windows.Forms.Button();
            this.Item = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.OptionsResults = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(201, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Admin Screen";
            // 
            // OptionList
            // 
            this.OptionList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OptionList.FormattingEnabled = true;
            this.OptionList.ItemHeight = 16;
            this.OptionList.Items.AddRange(new object[] {
            "Rooms",
            "Mobs",
            "Weapons",
            "Potions",
            "Items",
            "Treasures"});
            this.OptionList.Location = new System.Drawing.Point(83, 89);
            this.OptionList.Name = "OptionList";
            this.OptionList.Size = new System.Drawing.Size(120, 100);
            this.OptionList.TabIndex = 1;
            this.OptionList.DoubleClick += new System.EventHandler(this.OptionList_DoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(104, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "OPTIONS";
            // 
            // Room
            // 
            this.Room.Location = new System.Drawing.Point(50, 212);
            this.Room.Name = "Room";
            this.Room.Size = new System.Drawing.Size(86, 23);
            this.Room.TabIndex = 3;
            this.Room.Text = "Add Rooms";
            this.Room.UseVisualStyleBackColor = true;
            this.Room.Click += new System.EventHandler(this.Room_Click);
            // 
            // Mob
            // 
            this.Mob.Location = new System.Drawing.Point(142, 212);
            this.Mob.Name = "Mob";
            this.Mob.Size = new System.Drawing.Size(86, 23);
            this.Mob.TabIndex = 4;
            this.Mob.Text = "Add Mobs";
            this.Mob.UseVisualStyleBackColor = true;
            this.Mob.Click += new System.EventHandler(this.Mob_Click);
            // 
            // Weapon
            // 
            this.Weapon.Location = new System.Drawing.Point(50, 253);
            this.Weapon.Name = "Weapon";
            this.Weapon.Size = new System.Drawing.Size(86, 23);
            this.Weapon.TabIndex = 5;
            this.Weapon.Text = "Add Weapons";
            this.Weapon.UseVisualStyleBackColor = true;
            this.Weapon.Click += new System.EventHandler(this.Weapon_Click);
            // 
            // Potion
            // 
            this.Potion.Location = new System.Drawing.Point(142, 253);
            this.Potion.Name = "Potion";
            this.Potion.Size = new System.Drawing.Size(86, 23);
            this.Potion.TabIndex = 6;
            this.Potion.Text = "Add Potions";
            this.Potion.UseVisualStyleBackColor = true;
            this.Potion.Click += new System.EventHandler(this.Potion_Click);
            // 
            // Item
            // 
            this.Item.Location = new System.Drawing.Point(50, 294);
            this.Item.Name = "Item";
            this.Item.Size = new System.Drawing.Size(86, 23);
            this.Item.TabIndex = 7;
            this.Item.Text = "Add items";
            this.Item.UseVisualStyleBackColor = true;
            this.Item.Click += new System.EventHandler(this.Item_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(142, 294);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(86, 23);
            this.button6.TabIndex = 8;
            this.button6.Text = "Add Treasures";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Treasure_Click);
            // 
            // OptionsResults
            // 
            this.OptionsResults.FormattingEnabled = true;
            this.OptionsResults.Location = new System.Drawing.Point(301, 73);
            this.OptionsResults.Name = "OptionsResults";
            this.OptionsResults.Size = new System.Drawing.Size(274, 251);
            this.OptionsResults.TabIndex = 9;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 357);
            this.Controls.Add(this.OptionsResults);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.Item);
            this.Controls.Add(this.Potion);
            this.Controls.Add(this.Weapon);
            this.Controls.Add(this.Mob);
            this.Controls.Add(this.Room);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.OptionList);
            this.Controls.Add(this.label1);
            this.Name = "Menu";
            this.Text = "Menu";    
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox OptionList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Room;
        private System.Windows.Forms.Button Mob;
        private System.Windows.Forms.Button Weapon;
        private System.Windows.Forms.Button Potion;
        private System.Windows.Forms.Button Item;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ListBox OptionsResults;
    }
}

