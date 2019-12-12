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

        public static void ItemUse(Player player, string noun)
        {
            if (noun != "")
            {
                if (player.Inventory.Find(x => x.Name == FirstLetterToCap.MakeFirstLetterCap(noun)).Name == noun)
                {
                    Console.WriteLine($"Do you wish to use {noun}");
                    if(Console.ReadLine().ToLower() == "yes")
                    {
                        if(player.HP < player.PlayerMaxHP)
                        {
                            player.HP += GameAttributes.PlayerPotionByName(FirstLetterToCap.MakeFirstLetterCap(noun)).HPRecovery;
                            if(player.PlayerMaxHP < player.HP)
                            {
                                player.HP = player.PlayerMaxHP;
                            }
                        }
                        else
                        {
                            Console.WriteLine("You are already at max hp.");
                        }
                    }
                }
                else
                {
                    Console.WriteLine($"You do not have {noun}");
                }

            }
            else
            {
                Console.WriteLine("Please enter an iteme");
            }
        }
    }
}
