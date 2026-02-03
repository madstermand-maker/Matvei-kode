using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_kombineret
{
    internal class Items
    {
        //Mads: Vi laver variable til at gemme navnet, liv og farve, her så det kan bruges af andre metoder
        public string name;
        public int liv;
        public ConsoleColor Color;
        //Mads: Når man laver et item skal man skrive i paranteset (navn af item, farve, liv det healer)
        public Items(string itemName, ConsoleColor itemColor, int itemLiv)
        {
            //Mads: Så gemmer vi varibler for det item her.
            name = itemName;
            liv = itemLiv;
            Color = itemColor;
        }
        //Mads: Dette er til at bruge et item
        public void Use()
        {
            //Mads: Vi bruger console.Write da det ikke laver en ny linje så vi kan skrive alt i et stykke
            Console.Write("Du brugte ");
            //Mads: Så ændre vi farven til itemfarven
            Console.ForegroundColor = Color;
            Console.Write(name);
            //Mads: ændre den til normal
            Console.ResetColor();
            Console.Write(" og healed ");
            //Mads: Gør livet den healed rød
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(liv);
            //Mads: Gør farven tilbage til normal.
            Console.ResetColor();
            Console.WriteLine(" liv");
        }
    }
}
