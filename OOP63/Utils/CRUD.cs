using OOP63.Model;
using System;
using System.Collections.Generic;

namespace OOP63.Utils
{
    class CRUD
    {
        public string Add(List<Menu> menus, Menu menu)
        {
            menus.Add(menu);
            return Success("Ditambahkan");
        }

        public string Add(List<Cart> menus, Cart menu)
        {
            menus.Add(menu);
            return Success("Ditambahkan");
        }

        public string Edit(List<Menu> menus, Menu menu, int id)
        {
            if (menus.Contains(menu))
            {
                menus[id - 1].Name = menu.Name;
                menus[id - 1].Price = menu.Price;
                return Success("Dihapus");
            }
            else
            {
                return NotFound();
            }
        }
        public string Delete(List<Menu> menus, int id)
        {
            if (id <= menus.Count)
            {
                menus.RemoveAt(id - 1);
                return Success("Dihapus");
            }
            else
            {
                return NotFound();
            }
        }

        public string Delete(List<Cart> menus, int id)
        {
            if (id <= menus.Count)
            {
                menus.RemoveAt(id - 1);
                return Success("Dihapus");
            }
            else
            {
                return NotFound();
            }
        }

        public void View(List<Menu> menuList)
        {
            int i = 0;

            Console.Clear();
            Console.WriteLine("id\tNama\t\tHarga");
            foreach (Menu n in menuList)
            {
                i++;
                Console.WriteLine($"{i}\t{n.Name}\tRp.{n.Price}");
            }
        }

        public void View(List<Cart> menuList)
        {
            int i = 0;

            Console.Clear();
            Console.WriteLine("id\tNama\t\tHarga\tTotal");
            foreach (Cart n in menuList)
            {
                i++;
                Console.WriteLine($"{i}\t{n.Name}\tRp.{n.Price}\t{n.TotalItems}");
            }
        }

        private string NotFound()
        {
            return "Id Tidak Ditemukan!!!";
        }
        private string Success(string value)
        {
            return $"Berhasil {value}!!!";
        }
    }
}
