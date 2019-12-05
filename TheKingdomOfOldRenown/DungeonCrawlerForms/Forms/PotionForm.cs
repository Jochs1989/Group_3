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
    public partial class PotionForm : Form
    {
        public PotionForm()
        {
            InitializeComponent();
        }

        private void AddPotion_Click(object sender, EventArgs e)
        {
            try
            {
                GameAttributes.potions.Add(new Potion(int.Parse(textBox1.Text), textBox2.Text, textBox3.Text, int.Parse(textBox4.Text), int.Parse(textBox5.Text), int.Parse(textBox6.Text),
                    int.Parse(textBox7.Text)));
            }
            catch 
            {
                MessageBox.Show("Error");
            }
        }
    }
}
