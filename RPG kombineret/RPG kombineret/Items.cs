using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_kombineret
{
    internal class Items
    {
        public string name;
        public int liv;
        public ConsoleColor Color;
        public Items(string itemName, ConsoleColor itemColor, int itemLiv)
        {
            name = itemName;
            liv = itemLiv;
            Color = itemColor;
        }
        public void Use()
        {
            Console.Write("Du brugte ");
            Console.ForegroundColor = Color;
            Console.Write(name);
            Console.ResetColor();
            Console.Write(" og healed ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(liv);
            Console.ResetColor();
            Console.WriteLine(" liv");
        }
    }
}
