using OOP63.Model;
using System;
using System.Collections.Generic;

namespace OOP63.Utils
{
    class Checkout
    {
        int totalPrice = 0;
        int totalItems = 0;
        int money = 0;
        public void View(List<Cart> carts)
        {
            foreach (Cart n in carts)
            {
                totalPrice += (n.Price * n.TotalItems);
                totalItems += n.TotalItems;
            }
            PayOrders(totalPrice);
            Receipt(carts, money, Changes(money, totalPrice));
        }

        private void PayOrders(int total)
        {
            bool check = false;

            Console.WriteLine("Jumlah Total Bayar = " + total);
            do
            {
                Console.Write("Masukan Uang Bayar = ");
                money = Convert.ToInt32(Console.ReadLine());
                if (money < total)
                {
                    Console.WriteLine("Uang Tidak Cukup, Masukan Kembali");
                    money = 0;
                    check = true;
                }
                else
                {
                    check = false;
                }
            } while (check);
        }

        private int Changes(int money, int total)
        {
            return money - total;
        }

        private void Receipt(List<Cart> carts, int money, int changes)
        {
            int i = 0;

            Invoice invoice = new Invoice();

            Console.Clear();
            Console.WriteLine("=======================================");
            Console.WriteLine("\tPesanan Frozen Food");
            Console.WriteLine("=======================================");
            Console.WriteLine(" No | Nama Barang |\tHarga\t| Jumlah");
            Console.WriteLine("---------------------------------------");
            foreach (Cart n in carts)
            {
                i++;
                Console.WriteLine($"{i}\t{n.Name}\t{n.Price}\t\t{n.TotalItems}");
            }
            Console.WriteLine("=======================================");
            Console.WriteLine($"Bayar\t\t: {money}");
            Console.WriteLine($"Kembalian\t: {changes}");
            Console.WriteLine("=======================================");
            Console.WriteLine(invoice.CreateInvoice(10843 + totalItems));
            Console.WriteLine("=======================================");
            Console.WriteLine("          TERIMA KASIH            ");
            Console.WriteLine("=======================================");
            Console.Read();
        }
    }
}
