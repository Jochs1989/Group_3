using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DungeonCrawlerForms
{
    public partial class Mob : Form
    {
        public Mob()
        {
            InitializeComponent();
        }
        private void mobID_Click(object sender, EventArgs e)
        {

        }

        private void addMob_Click(object sender, EventArgs e)
        {
            DungeonCrawlerLibrary.GameAttributes.mobs.Add(new DungeonCrawlerLibrary.Mob(textBox1_TextChanged, textBox2_TextChanged, textBox3_TextChanged, textBox4_TextChanged,
                textBox5_TextChanged, textBox6_TextChanged, textBox7_TextChanged, textBox8_TextChanged, textBox9_TextChanged, textBox10_TextChanged));
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
