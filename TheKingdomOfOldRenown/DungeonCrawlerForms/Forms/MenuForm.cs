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
    public partial class MenuForm : Form
    {
        public MenuForm()
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
                foreach (Mob mob in GameAttributes.mobs)
                {
                    OptionsResults.Items.Add($"{mob.ID} \t|\t {mob.Name}");
                }
            }
            else if (OptionList.SelectedItem.ToString() == "Items")
            {
                OptionsResults.Visible = true;
                OptionsResults.Items.Clear();
                foreach (Item item in GameAttributes.items)
                {
                    OptionsResults.Items.Add($"{item.ID} \t|\t {item.Name}");
                }
            }
            else if (OptionList.SelectedItem.ToString() == "Weapons")
            {
                OptionsResults.Visible = true;
                OptionsResults.Items.Clear();
                foreach (Weapon weapon in GameAttributes.weapons)
                {
                    OptionsResults.Items.Add($"{weapon.ID} \t|\t {weapon.Name}");
                }
            }
            else if (OptionList.SelectedItem.ToString() == "Potions")
            {
                OptionsResults.Visible = true;
                OptionsResults.Items.Clear();
                foreach (Potion potion in GameAttributes.potions)
                {
                    OptionsResults.Items.Add($"{potion.ID} \t|\t {potion.Name}");
                }
            }
            else if (OptionList.SelectedItem.ToString() == "Treasures")
            {
                OptionsResults.Visible = true;
                OptionsResults.Items.Clear();
                foreach (Treasure treasure in GameAttributes.treasures)
                {
                    OptionsResults.Items.Add($"{treasure.ID} \t|\t {treasure.Name}");
                }
            }
        }
        private void Room_Click(object sender, EventArgs e)
        {
            RoomCreation roomForm = new RoomCreation();
            roomForm.Show();
        }

        private void Weapon_Click(object sender, EventArgs e)
        {
            WeaponCreation weaponform = new WeaponCreation();
            weaponform.Show();
        }

        private void Item_Click(object sender, EventArgs e)
        {
            ItemForm itemForm = new ItemForm();
            itemForm.Show();
        }

        private void Mob_Click(object sender, EventArgs e)
        {
            MobForm mobForm = new MobForm();
            mobForm.Show();
        }

        private void Potion_Click(object sender, EventArgs e)
        {
            PotionForm potionForm = new PotionForm();
            potionForm.Show();
        }

        private void Treasure_Click(object sender, EventArgs e)
        {
            TreasureForm treasureForm = new TreasureForm();
            treasureForm.Show();
        }
    }
}
