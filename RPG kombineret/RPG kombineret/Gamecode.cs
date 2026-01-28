using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_kombineret
{
    internal class Gamecode
    {
        public List<Items> inventory = new List<Items>();
        public Items LootItem = null;
        public Items LootItem2 = null;
        public void Muligheder()
        {
            string InventoryFull = null;
            if (inventory.Count > 0)
            {
                InventoryFull = "Inventory / ";
            }
            string LootKropText = null;
            if (LootItem != null)
            {
                LootKropText = "Loot / ";
            }
            Console.WriteLine("Hvad vil du gøre nu? (" + InventoryFull + LootKropText + "gå videre)");
            Console.WriteLine();
            BrugerSvar();
        }
        string Svar()
        {
            string BrugerInput = Console.ReadLine().ToLower();
            return BrugerInput;
        }
        void TjekSvar(string BrugerInput)
        {
            switch (BrugerInput)
            {
                case "loot":
                    loot();
                    Muligheder();
                    break;
                case "inventory":
                    Inventory();
                    Muligheder();
                    break;
                case "gå":
                case "gå videre":
                case "videre":
                    LootItem = null;
                    LootItem2 = null;
                    break;
                default:
                    Console.WriteLine("Det er ikke en af mulighederene");
                    Muligheder();
                    break;
            }
        }
        void loot()
        {
            if (LootItem != null)
            {
                AddItem(LootItem);
                LootItem = null;
            }
            else
            {
                Console.WriteLine("Der er ik noget at loot");
            }
            if (LootItem2 != null)
            {
                AddItem(LootItem2);
                LootItem2 = null;
            }
        }
        void Inventory()
        {
            if (inventory.Count > 0)
            {
                for (int i = 0; i < inventory.Count; i++)
                {
                    Console.Write("[" + (i + 1) + "] ");
                    Console.ForegroundColor = inventory[i].Color;
                    Console.WriteLine(inventory[i].name);
                    Console.ResetColor();
                }
                Console.WriteLine("Brug item ved at skrive dets tal / luk inventory ved at skrive \"luk\"");
                Console.WriteLine();
                string BrugerInput = Svar();
                switch (BrugerInput)
                {
                    case "0":
                    case "1":
                    case "2":
                    case "3":
                    case "4":
                    case "5":
                    case "6":
                    case "7":
                    case "8":
                    case "9":
                    case "10":
                        int inttal = Convert.ToInt32(BrugerInput) - 1;
                        if (inttal <= inventory.Count - 1)
                        {
                            Items item = inventory[inttal];
                            inventory.RemoveAt(inttal);
                            item.Use();
                        }
                        else
                        {
                            Console.WriteLine("Du har ik så mange items");
                        }
                        break;
                    case "luk":
                        break;
                    default:
                        Console.WriteLine("Det er ik en mulighed så inventory lukkes");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Du har ikke flere items tilbage");
            }
        }
        void BrugerSvar()
        {
            string BrugerInput = Svar();
            TjekSvar(BrugerInput);
        }
        void AddItem(Items item)
        {
            inventory.Add(item);

            Console.Write("Du har opsamplet: ");
            Console.ForegroundColor = item.Color;
            Console.WriteLine(item.name);
            Console.ResetColor();
        }
    }
}
