using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_kombineret
{
    internal class Gamecode
    {
        //Mads:Vi starter med at oprette et inventory til spilleren
        public List<Items> inventory = new List<Items>();
        //Mads: vi opretter de to loot variabler hvor som bruges til at man kan samle det op hvis man vil.
        public Items LootItem = null;
        public Items LootItem2 = null;
        //Mads: Muligheder() giver en muligheder for hvad man vil gøre
        public void Muligheder()
        {
            //Mads: Vi starter med at skrive hvad man vil
            //Mads: Dog vil vi gerne have at der står mulighederene man kan hvor man f.eks nogen gange kan loot og andre gange ik.
            string InventoryFull = null;
            //Mads: Hvis der er noget i inventory kalder vi den det der skal skrives for man har muligheden.
            if (inventory.Count > 0)
            {
                InventoryFull = "Inventory / ";
            }
            string LootKropText = null;
            //Mads: Hvis man kan der er gemt noget som lootitem giver det en muligheden for at gøre det og skriver det.
            if (LootItem != null)
            {
                LootKropText = "Loot / ";
            }
            Console.WriteLine("Hvad vil du gøre nu? (" + InventoryFull + LootKropText + "gå videre)");
            //Mads: Vi laver en fri linje for bedre overblik
            Console.WriteLine();
            //Mads: Så kører vi Brugersvar()
            BrugerSvar();
        }
        string Svar()
        {
            //Mads:Vi gemmer brugerinputet og gør alle bogstaverne lille så du godt må skrive med stort.
            string BrugerInput = Console.ReadLine().ToLower();
            return BrugerInput;
        }
        //Mads:vi tjekker hvad brugern har svaret
        void TjekSvar(string BrugerInput)
        {
            //Mads: vi bruger switch da vi vil tjekke efter flere muligheder
            switch (BrugerInput)
            {
                //Mads: Vi tjekker om de har skrevet loot og så kører vi loot funktionen
                case "loot":
                    loot();
                    //Mads: Bag efter køer vi muligheder igen for at de kan gøre mere på en gang
                    Muligheder();
                    break;
                //Mads: samme som loot
                case "inventory":
                    Inventory();
                    Muligheder();
                    break;
                case "gå":
                case "gå videre":
                case "videre":
                    //Mads: Hvis de vil gå videre fjerner vi deres mulighed til at loot et item og koden muligheder er så færdig
                    LootItem = null;
                    LootItem2 = null;
                    break;
                default:
                    //Mads: User idiot hvis de ik skriver en af mulighederene
                    Console.WriteLine("Det er ikke en af mulighederene");
                    Muligheder();
                    break;
            }
        }
        void loot()
        {
            //Mads: Vi starter med at tjekke om de har noget at loot
            if (LootItem != null)
            {
                //Mads: Hvis de har noget så tilføjer vi det til deres inventory
                AddItem(LootItem);
                //Mads: Og bagefter fjerner itemet så de ik kan loot det igen
                LootItem = null;
            }
            else
            {
                //Mads: Hvis man ik har noget at loot skriver vi:
                Console.WriteLine("Der er ik noget at loot");
            }
            //Mads: Hvis der er 2 items at tilføje gør vi også det.
            if (LootItem2 != null)
            {
                AddItem(LootItem2);
                LootItem2 = null;
            }
        }
        //Mads: Dette er inventoryet.
        void Inventory()
        {
            //Mads: Vi tjekker om de er noget i inventoryey
            if (inventory.Count > 0)
            {
                //Mads: Så kører vi dette loop for hvert item i deres inventory
                for (int i = 0; i < inventory.Count; i++)
                {
                    //Mads: Vi starter med at skrive det tal vi er noget til i inventoryet.
                    Console.Write("[" + (i + 1) + "] ");
                    //Mads: Vi ændre tekst farven til itemets farve
                    Console.ForegroundColor = inventory[i].Color;
                    //Mads: Vi skriver itemets navn.
                    Console.WriteLine(inventory[i].name);
                    //Mads: Så sætter vi farven tilbage til normal.
                    Console.ResetColor();
                }
                Console.WriteLine("Brug item ved at skrive dets tal / luk inventory ved at skrive \"luk\"");
                //Mads: Vi laver en linje for mere overblik
                Console.WriteLine();
                //Mads: Vi gemmer bruger input for at tjekke hvad de vil
                string BrugerInput = Svar();
                switch (BrugerInput)
                {
                    //Mads: Vi tjekker om de skriver et tal
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
                        //Mads: Vi laver det om til en int og minuser med en for at få det til at matche pladsen i inventoryet
                        int inttal = Convert.ToInt32(BrugerInput) - 1;
                        if (inttal <= inventory.Count - 1)
                        {
                            //Mads: Vi finder ud af hvilket item det er
                            Items item = inventory[inttal];
                            //Mads: Så fjerner vi det fra inventory listen
                            inventory.RemoveAt(inttal);
                            //Mads: Så bruger vi det med Use metoden
                            item.Use();
                        }
                        else
                        {
                            //Mads: Hvis man har skrevet et tal højere end den mængde items man har skriver den dette.
                            Console.WriteLine("Du har ik så mange items");
                        }
                        break;
                    //Mads: Hvis de vil luk inventoryet ender den bare metoden
                    case "luk":
                        break;
                    default:
                        //Mads: Hvis man skriver noget andet lukkes inventoryet alligevel.
                        Console.WriteLine("Det er ik en mulighed så inventory lukkes");
                        break;
                }
            }
            else
            {
                //Mads: Hvis man ikke har nogen items så kan man ikke åbne inventoryet
                Console.WriteLine("Du har ikke flere items tilbage");
            }
        }
        //Mads:Her returnere vi brugernes input som en string.
        void BrugerSvar()
        {
            //Mads: vi kalder svar som skaffer brugerinput
            string BrugerInput = Svar();
            //Mads: Vi tjekker så hvad svaret er med tjeksvar()
            TjekSvar(BrugerInput);
        }
        //Mads: Når vi vil tilføje et item til inventoryet bruger vi add item
        void AddItem(Items item)
        {
            //Mads: Først tilføjer vi det til inventoryet
            inventory.Add(item);
            //Mads: Så skriver vi at man har fået itemet
            Console.Write("Du har opsamplet: ");
            //Mads: Og søger for dens farve
            Console.ForegroundColor = item.Color;
            Console.WriteLine(item.name);
            //Mads: Bag efter gør vi farven tilbage til normal
            Console.ResetColor();
        }
    }
}
