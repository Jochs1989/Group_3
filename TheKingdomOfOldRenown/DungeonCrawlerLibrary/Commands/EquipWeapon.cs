using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonCrawlerLibrary
{
    public class EquipWeapon
    {
        public static void EquipmentChange(Player player, string noun)
        {
            if(player.Equipment.Name.ToLower() != noun)
            {
                if (string.IsNullOrEmpty(noun))
                {
                    Console.WriteLine("Please Enter the weapons name!");
                }
                else
                {
                    InheritItem weapon = player.ItemByName(player, noun);

                    if (noun == weapon.Name.ToLower())
                    {
                        player.Inventory.Add(new InheritItem(player.Equipment.ID, player.Equipment.Name, player.Equipment.Description, player.Equipment.Price));
                        player.Equipment = GameAttributes.PlayerWeaponByName(noun);
                        player.RemoveItembyName(player, noun);
                    }
                    else
                    {
                        Console.WriteLine($"{noun} is not in your inventory.");
                    }
                }
                    
            }
            else
            {
                Console.WriteLine("You already have this weapon equip!");
            }
        }
    }
}
