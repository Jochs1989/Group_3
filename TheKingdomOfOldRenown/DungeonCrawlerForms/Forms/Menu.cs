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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            OptionsResults.Visible = false;
        }

        private void OptionList_DoubleClick(object sender, EventArgs e)
        {
            if(OptionList.SelectedItem.ToString() == "Rooms")
            {
                OptionsResults.Visible = true;
                OptionsResults.Items.Clear();
                foreach (DungeonCrawlerLibrary.Room room in GameAttributes.rooms)
                {
                    OptionsResults.Items.Add($"{room.ID} \t|\t {room.RoomName}");
                }
            }
            else if (OptionList.SelectedItem.ToString() == "Mobs")
            {
                OptionsResults.Visible = true;
                OptionsResults.Items.Clear();
                foreach (DungeonCrawlerLibrary.Mob mob in GameAttributes.mobs)
                {
                    OptionsResults.Items.Add($"{mob.ID} \t|\t {mob.Name}");
                }
            }
            else if (OptionList.SelectedItem.ToString() == "Items")
            {
                OptionsResults.Visible = true;
                OptionsResults.Items.Clear();
                foreach (DungeonCrawlerLibrary.Item item in GameAttributes.items)
                {
                    OptionsResults.Items.Add($"{item.ID} \t|\t {item.Name}");
                }
            }
            else if (OptionList.SelectedItem.ToString() == "Weapons")
            {
                OptionsResults.Visible = true;
                OptionsResults.Items.Clear();
                foreach (DungeonCrawlerLibrary.Weapon weapon in GameAttributes.weapons)
                {
                    OptionsResults.Items.Add($"{weapon.ID} \t|\t {weapon.Name}");
                }
            }
            else if (OptionList.SelectedItem.ToString() == "Potions")
            {
                OptionsResults.Visible = true;
                OptionsResults.Items.Clear();
                foreach (DungeonCrawlerLibrary.Potion potion in GameAttributes.potions)
                {
                    OptionsResults.Items.Add($"{potion.ID} \t|\t {potion.Name}");
                }
            }
            else if (OptionList.SelectedItem.ToString() == "Treasures")
            {
                OptionsResults.Visible = true;
                OptionsResults.Items.Clear();
                foreach (DungeonCrawlerLibrary.Treasure treasure in GameAttributes.treasures)
                {
                    OptionsResults.Items.Add($"{treasure.ID} \t|\t {treasure.Name}");
                }
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
