namespace DungeonCrawlerForms
{
    partial class Room
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
            this.IDLabel = new System.Windows.Forms.Label();
            this.IDBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.NorthLabel = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.SouthLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Location = new System.Drawing.Point(8, 32);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(18, 13);
            this.IDLabel.TabIndex = 0;
            this.IDLabel.Text = "ID";
            // 
            // IDBox
            // 
            this.IDBox.Location = new System.Drawing.Point(72, 29);
            this.IDBox.Name = "IDBox";
            this.IDBox.Size = new System.Drawing.Size(265, 20);
            this.IDBox.TabIndex = 1;
            this.IDBox.Text = "Enter Room ID";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox7);
            this.groupBox1.Controls.Add(this.textBox6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.SouthLabel);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.NorthLabel);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.DescriptionLabel);
            this.groupBox1.Controls.Add(this.NameLabel);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.IDBox);
            this.groupBox1.Controls.Add(this.IDLabel);
            this.groupBox1.Location = new System.Drawing.Point(24, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(374, 309);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(72, 107);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(265, 20);
            this.textBox4.TabIndex = 8;
            this.textBox4.Text = "Enter ID of the room North of this room or -1 for no Exit";
            // 
            // NorthLabel
            // 
            this.NorthLabel.AutoSize = true;
            this.NorthLabel.Location = new System.Drawing.Point(6, 110);
            this.NorthLabel.Name = "NorthLabel";
            this.NorthLabel.Size = new System.Drawing.Size(53, 13);
            this.NorthLabel.TabIndex = 7;
            this.NorthLabel.Text = "Exit North";
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
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(72, 81);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(265, 20);
            this.textBox2.TabIndex = 5;
            this.textBox2.Text = "Enter a short desciption of the room";
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Location = new System.Drawing.Point(6, 84);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(60, 13);
            this.DescriptionLabel.TabIndex = 4;
            this.DescriptionLabel.Text = "Description";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(6, 58);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(35, 13);
            this.NameLabel.TabIndex = 3;
            this.NameLabel.Text = "Name";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(72, 55);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(265, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Enter Room Name";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(72, 133);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(265, 20);
            this.textBox5.TabIndex = 9;
            this.textBox5.Text = "Enter ID of the room South of this room or -1 for no Exit";
            // 
            // SouthLabel
            // 
            this.SouthLabel.AutoSize = true;
            this.SouthLabel.Location = new System.Drawing.Point(6, 136);
            this.SouthLabel.Name = "SouthLabel";
            this.SouthLabel.Size = new System.Drawing.Size(55, 13);
            this.SouthLabel.TabIndex = 10;
            this.SouthLabel.Tag = "Exit South";
            this.SouthLabel.Text = "Exit South";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 11;
            this.label1.Tag = "Exit South";
            this.label1.Text = "Exit East";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 12;
            this.label2.Tag = "Exit South";
            this.label2.Text = "Exit West";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(72, 159);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(265, 20);
            this.textBox6.TabIndex = 13;
            this.textBox6.Text = "Enter ID of the room South of this room or -1 for no Exit";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(72, 185);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(265, 20);
            this.textBox7.TabIndex = 14;
            this.textBox7.Text = "Enter ID of the room South of this room or -1 for no Exit";
            // 
            // Room
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 375);
            this.Controls.Add(this.groupBox1);
            this.Name = "Room";
            this.Text = "Room";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.TextBox IDBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label NorthLabel;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label SouthLabel;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}