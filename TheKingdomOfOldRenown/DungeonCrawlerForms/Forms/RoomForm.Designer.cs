namespace DungeonCrawlerForms
{
    partial class RoomCreation
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
            this.ID = new System.Windows.Forms.Label();
            this.IDBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.MobRating = new System.Windows.Forms.Label();
            this.Down = new System.Windows.Forms.Label();
            this.UpBox = new System.Windows.Forms.TextBox();
            this.DownBox = new System.Windows.Forms.TextBox();
            this.MobRatingBox = new System.Windows.Forms.TextBox();
            this.Up = new System.Windows.Forms.Label();
            this.WestBox = new System.Windows.Forms.TextBox();
            this.EastBox = new System.Windows.Forms.TextBox();
            this.West = new System.Windows.Forms.Label();
            this.East = new System.Windows.Forms.Label();
            this.South = new System.Windows.Forms.Label();
            this.SouthBox = new System.Windows.Forms.TextBox();
            this.NorthBox = new System.Windows.Forms.TextBox();
            this.North = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.DescriptionBox = new System.Windows.Forms.TextBox();
            this.Description = new System.Windows.Forms.Label();
            this.Name = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.Add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            // IDBox
            // 
            this.IDBox.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.IDBox.Location = new System.Drawing.Point(72, 29);
            this.IDBox.Name = "IDBox";
            this.IDBox.Size = new System.Drawing.Size(282, 20);
            this.IDBox.TabIndex = 1;
            this.IDBox.Text = "Enter Room ID";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.MobRating);
            this.groupBox1.Controls.Add(this.Down);
            this.groupBox1.Controls.Add(this.UpBox);
            this.groupBox1.Controls.Add(this.DownBox);
            this.groupBox1.Controls.Add(this.MobRatingBox);
            this.groupBox1.Controls.Add(this.Up);
            this.groupBox1.Controls.Add(this.WestBox);
            this.groupBox1.Controls.Add(this.EastBox);
            this.groupBox1.Controls.Add(this.West);
            this.groupBox1.Controls.Add(this.East);
            this.groupBox1.Controls.Add(this.South);
            this.groupBox1.Controls.Add(this.SouthBox);
            this.groupBox1.Controls.Add(this.NorthBox);
            this.groupBox1.Controls.Add(this.North);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.DescriptionBox);
            this.groupBox1.Controls.Add(this.Description);
            this.groupBox1.Controls.Add(this.Name);
            this.groupBox1.Controls.Add(this.NameBox);
            this.groupBox1.Controls.Add(this.IDBox);
            this.groupBox1.Controls.Add(this.ID);
            this.groupBox1.Location = new System.Drawing.Point(12, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(374, 309);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // MobRating
            // 
            this.MobRating.AutoSize = true;
            this.MobRating.Location = new System.Drawing.Point(6, 266);
            this.MobRating.Name = "MobRating";
            this.MobRating.Size = new System.Drawing.Size(59, 13);
            this.MobRating.TabIndex = 20;
            this.MobRating.Tag = "Exit South";
            this.MobRating.Text = "MobRating";
            // 
            // Down
            // 
            this.Down.AutoSize = true;
            this.Down.Location = new System.Drawing.Point(6, 240);
            this.Down.Name = "Down";
            this.Down.Size = new System.Drawing.Size(52, 13);
            this.Down.TabIndex = 19;
            this.Down.Tag = "";
            this.Down.Text = "ExitDown";
            // 
            // UpBox
            // 
            this.UpBox.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.UpBox.Location = new System.Drawing.Point(72, 211);
            this.UpBox.Multiline = true;
            this.UpBox.Name = "UpBox";
            this.UpBox.Size = new System.Drawing.Size(282, 20);
            this.UpBox.TabIndex = 18;
            this.UpBox.Text = "Enter ID of the room above of this room or -1 for no Exit";
            // 
            // DownBox
            // 
            this.DownBox.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.DownBox.Location = new System.Drawing.Point(72, 237);
            this.DownBox.Multiline = true;
            this.DownBox.Name = "DownBox";
            this.DownBox.Size = new System.Drawing.Size(282, 20);
            this.DownBox.TabIndex = 17;
            this.DownBox.Text = "Enter ID of the room below of this room or -1 for no Exit";
            // 
            // MobRatingBox
            // 
            this.MobRatingBox.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.MobRatingBox.Location = new System.Drawing.Point(72, 263);
            this.MobRatingBox.Multiline = true;
            this.MobRatingBox.Name = "MobRatingBox";
            this.MobRatingBox.Size = new System.Drawing.Size(282, 20);
            this.MobRatingBox.TabIndex = 16;
            this.MobRatingBox.Text = "Enter a number starting at 0. Higher # means stronger mob ";
            // 
            // Up
            // 
            this.Up.AutoSize = true;
            this.Up.Location = new System.Drawing.Point(6, 214);
            this.Up.Name = "Up";
            this.Up.Size = new System.Drawing.Size(42, 13);
            this.Up.TabIndex = 15;
            this.Up.Tag = "";
            this.Up.Text = "Exit UP";
            // 
            // WestBox
            // 
            this.WestBox.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.WestBox.Location = new System.Drawing.Point(72, 185);
            this.WestBox.Multiline = true;
            this.WestBox.Name = "WestBox";
            this.WestBox.Size = new System.Drawing.Size(282, 20);
            this.WestBox.TabIndex = 14;
            this.WestBox.Text = "Enter ID of the room West of this room or -1 for no Exit";
            // 
            // EastBox
            // 
            this.EastBox.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.EastBox.Location = new System.Drawing.Point(72, 159);
            this.EastBox.Multiline = true;
            this.EastBox.Name = "EastBox";
            this.EastBox.Size = new System.Drawing.Size(282, 20);
            this.EastBox.TabIndex = 13;
            this.EastBox.Text = "Enter ID of the room East of this room or -1 for no Exit";
            // 
            // West
            // 
            this.West.AutoSize = true;
            this.West.Location = new System.Drawing.Point(6, 188);
            this.West.Name = "West";
            this.West.Size = new System.Drawing.Size(52, 13);
            this.West.TabIndex = 12;
            this.West.Tag = "";
            this.West.Text = "Exit West";
            // 
            // East
            // 
            this.East.AutoSize = true;
            this.East.Location = new System.Drawing.Point(6, 162);
            this.East.Name = "East";
            this.East.Size = new System.Drawing.Size(48, 13);
            this.East.TabIndex = 11;
            this.East.Tag = "Exit South";
            this.East.Text = "Exit East";
            // 
            // South
            // 
            this.South.AutoSize = true;
            this.South.Location = new System.Drawing.Point(6, 136);
            this.South.Name = "South";
            this.South.Size = new System.Drawing.Size(55, 13);
            this.South.TabIndex = 10;
            this.South.Tag = "Exit South";
            this.South.Text = "Exit South";
            // 
            // SouthBox
            // 
            this.SouthBox.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.SouthBox.Location = new System.Drawing.Point(72, 133);
            this.SouthBox.Multiline = true;
            this.SouthBox.Name = "SouthBox";
            this.SouthBox.Size = new System.Drawing.Size(282, 20);
            this.SouthBox.TabIndex = 9;
            this.SouthBox.Text = "Enter ID of the room South of this room or -1 for no Exit";
            // 
            // NorthBox
            // 
            this.NorthBox.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.NorthBox.Location = new System.Drawing.Point(72, 107);
            this.NorthBox.Multiline = true;
            this.NorthBox.Name = "NorthBox";
            this.NorthBox.Size = new System.Drawing.Size(282, 20);
            this.NorthBox.TabIndex = 8;
            this.NorthBox.Text = "Enter ID of the room North of this room or -1 for no Exit";
            // 
            // North
            // 
            this.North.AutoSize = true;
            this.North.Location = new System.Drawing.Point(6, 110);
            this.North.Name = "North";
            this.North.Size = new System.Drawing.Size(53, 13);
            this.North.TabIndex = 7;
            this.North.Text = "Exit North";
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
            this.DescriptionBox.Text = "Enter a short desciption of the room";
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
            this.NameBox.Text = "Enter Room Name";
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(160, 358);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 3;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(100, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Room Creation";
            // 
            // RoomCreation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 390);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.groupBox1);
            this.Text = "Room";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.TextBox IDBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox NorthBox;
        private System.Windows.Forms.Label North;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox DescriptionBox;
        private System.Windows.Forms.Label Description;
        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label South;
        private System.Windows.Forms.TextBox SouthBox;
        private System.Windows.Forms.TextBox WestBox;
        private System.Windows.Forms.TextBox EastBox;
        private System.Windows.Forms.Label West;
        private System.Windows.Forms.Label East;
        private System.Windows.Forms.Label MobRating;
        private System.Windows.Forms.Label Down;
        private System.Windows.Forms.TextBox UpBox;
        private System.Windows.Forms.TextBox DownBox;
        private System.Windows.Forms.TextBox MobRatingBox;
        private System.Windows.Forms.Label Up;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Label label1;
    }
}