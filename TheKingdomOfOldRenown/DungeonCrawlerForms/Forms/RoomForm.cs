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
    public partial class RoomCreation : Form
    {
        public RoomCreation()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            try
            {
                GameAttributes.rooms.Add(new Room(int.Parse(IDBox.Text), NameBox.Text, DescriptionBox.Text, int.Parse(NorthBox.Text), int.Parse(SouthBox.Text),
                    int.Parse(EastBox.Text), int.Parse(WestBox.Text), int.Parse(UpBox.Text), int.Parse(DownBox.Text), int.Parse(MobRatingBox.Text)));
                MessageBox.Show("Room Added!");
            }
            catch
            {
                MessageBox.Show("Error");
            }
            

        }
    }
}
