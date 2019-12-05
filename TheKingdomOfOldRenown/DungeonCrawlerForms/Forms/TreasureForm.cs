using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DungeonCrawlerLibrary;

namespace DungeonCrawlerForms
{
    public partial class TreasureForm : Form
    {
        public TreasureForm()
        {
            InitializeComponent();
        }

        private void AddTreasure_Click(object sender, EventArgs e)
        {
            GameAttributes.treasures.Add(new Treasure(int.Parse(textBox1.Text), textBox2.Text, textBox3.Text, int.Parse(textBox4.Text), bool.Parse(textBox5.Text), bool.Parse(textBox6.Text)));
        }
    }
}
