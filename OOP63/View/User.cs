using OOP63.Model;
using OOP63.Utils;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OOP63.View
{
    class User
    {
        List<Menu> menuList = new List<Menu>();
        List<Cart> cartList = new List<Cart>();
        CRUD crud = new CRUD();
        Cart cart;

        public void View(List<Menu> menus)
        {
            menuList = menus;
            crud.View(menus);

            bool cek = true;
            while (cek)
            {
                Console.Write("\nPilih Item : ");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.Write("Jumlah : ");
                int jumlah = Convert.ToInt32(Console.ReadLine());

                cart = new Cart(menus[id - 1].Name, menus[id - 1].Price, jumlah);

                cartList.Add(cart);

                Console.Write("Ingin Membeli Item Yang Lain?(y/n) : ");
                string ulang = Console.ReadLine();
                if (ulang == "N" || ulang == "n")
                {
                    CartMenu();
                    cek = false;
                }
            }
        }

        public void CartMenu()
        {
            DuplicateCart(cartList);
            Console.WriteLine("Keranjang :");
            crud.View(cartList);

            Console.WriteLine("\n1.Hapus");
            Console.WriteLine("2.Beli Lagi");
            Console.WriteLine("3.Bayar Sekarang");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    deleteView(cartList);
                    break;
                case 2:
                    View(menuList);
                    break;
                case 3:
                    Checkout checkout = new Checkout();
                    checkout.View(cartList);
                    break;
            }
        }

        private void DuplicateCart(List<Cart> cart)
        {
            cartList = cart.GroupBy(i => i.Name)
                .Select(g => new Cart
                {
                    Name = g.Key,
                    Price = cart.First().Price,
                    TotalItems = g.Sum(i => i.TotalItems)
                }).ToList();
        }

        private void deleteView(List<Cart> cart)
        {
            Console.Write("\nMasukan Id Yang Ingin Dihapus : ");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(crud.Delete(cart, id));
            Console.ReadKey();
            CartMenu();
        }
    }
}
