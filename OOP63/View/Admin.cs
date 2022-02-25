using OOP63.Model;
using OOP63.Utils;
using System;
using System.Collections.Generic;

namespace OOP63.View
{
    class Admin
    {
        Menu menu = new Menu();
        CRUD crud = new CRUD();

        public void View(List<Menu> menus)
        {
            crud.View(menus);
            Console.WriteLine("\nTAMPILAN ADMIN");
            Console.WriteLine("1. Tambah Makanan");
            Console.WriteLine("2. Edit Makanan");
            Console.WriteLine("3. Hapus Makanan");
            Console.WriteLine("4. Kembali");

            Console.Write("Masukan : ");
            int pilih = Convert.ToInt32(Console.ReadLine());
            switch (pilih)
            {
                case 1:
                    addView(menus, menu);
                    break;
                case 2:
                    editView(menus, menu);
                    break;
                case 3:
                    deleteView(menus);
                    break;
                case 4:
                    MainMenu main = new MainMenu();
                    main.App(menus);
                    break;
            }
        }

        private void deleteView(List<Menu> menus)
        {
            Console.Write("\nMasukan Id Yang Ingin Dihapus : ");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(crud.Delete(menus, id));
            Console.ReadKey();
            View(menus);
        }

        private void editView(List<Menu> menus, Menu menu)
        {
            Console.Write("Id Yang Ingin Diubah : "); int id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nama : "); menu.Name = Console.ReadLine();
            Console.Write("Harga : "); menu.Price = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(crud.Edit(menus, menu, id));
            Console.ReadKey();
            View(menus);
        }

        private void addView(List<Menu> menus, Menu menu)
        {
            Console.Write("Masukan Nama\t: "); menu.Name = Console.ReadLine();
            Console.Write("Masukan Harga\t: "); menu.Price = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(crud.Add(menus, menu));
            Console.ReadKey();
            View(menus);
        }
    }
}
