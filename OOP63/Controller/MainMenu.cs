using OOP63.Model;
using OOP63.View;
using System;
using System.Collections.Generic;

namespace OOP63.Utils
{
    class MainMenu
    {
        public void App(List<Menu> menuList)
        {
            Console.Clear();
            Console.WriteLine("SELAMAT DATANG DI FROZEN FOOD");
            Console.WriteLine("1. Admin");
            Console.WriteLine("2. User");
            Console.WriteLine("3. Keluar");

            Console.Write("\nMasukan : ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Admin admin = new Admin();
                    admin.View(menuList);
                    break;
                case 2:
                    User user = new User();
                    user.View(menuList);
                    break;
                case 3:
                    Environment.Exit(0);
                    break;
            }
        }
    }
}
