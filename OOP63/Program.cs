using OOP63.Model;
using OOP63.Utils;
using System.Collections.Generic;
using System.Linq;

namespace OOP63
{
    class Program
    {
        static List<Menu> menuList = new List<Menu>();

        static void Main(string[] args)
        {
            MainMenu mainMenu = new MainMenu();

            Dummy();
            mainMenu.App(menuList);
        }

        private static void Dummy()
        {
            string[] barang = new string[5] { "Ayam 1kg", "Sapi 1kg", "Ikan Mas 1kg", "Bebek 1kg", "Kambing 1kg" };
            int[] harga = new int[5] { 15000, 25000, 12000, 20000, 25000 };

            if (!menuList.Any())
            {
                for (int n = 0; n < barang.Length; n++)
                {
                    Menu menu = new Menu();
                    menu.Name = barang[n];
                    menu.Price = harga[n];

                    menuList.Add(menu);
                }
            }
        }
    }
}
