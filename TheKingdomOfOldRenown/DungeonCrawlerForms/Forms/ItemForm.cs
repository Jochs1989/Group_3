using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonCrawlerLibrary;
using System.Windows.Forms;

namespace DungeonCrawlerForms
{
    public partial class ItemForm : Form
    {
        public ItemForm()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            try
            {
                GameAttributes.items.Add(new Item(int.Parse(IDBox.Text), NameBox.Text, DescriptionBox.Text, int.Parse(PriceBox.Text), bool.Parse(CanUseBox.Text)));
                MessageBox.Show("Room Added!");
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }
    }
}
