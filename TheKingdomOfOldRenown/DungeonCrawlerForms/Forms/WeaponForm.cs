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
    public partial class WeaponCreation : Form
    {
        public WeaponCreation()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            try
            { 
                GameAttributes.weapons.Add(new Weapon(int.Parse(IDBox.Text), NameBox.Text, DescriptionBox.Text, int.Parse(PriceBox.Text), bool.Parse(CanEquipBox.Text),
                    DamageBox.Text, int.Parse(DiceAmountBox.Text), int.Parse(DiceSidesBox.Text)));
                MessageBox.Show("Room Added!");
            }
            catch
            {
                MessageBox.Show("Error");
            }
}
    }
}
