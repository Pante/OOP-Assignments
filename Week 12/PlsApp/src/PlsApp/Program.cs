using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlsApp
{
    public class Program
    {
        private static List<Product> productList = new List<Product>();


        public static void Main(string[] args)
        {
            productList.Add(new Product("1001", "Apple iPhone", 1088));
            productList.Add(new Product("1005", "HTC Sensation", 888));
            productList.Add(new Product("1013", "LG Optimus 2X", 788));
            productList.Add(new Product("1022", "Motorla Atrix", 958));
            productList.Add(new Product("1027", "Samsing Galaxy", 988));

            Menu menu = new Menu(productList, new ShoppingCart());
            while (true) {
                menu.Display();
                Console.WriteLine("Enter option: ");

                switch (Console.ReadLine()) {
                    case "1":
                        menu.ListProducts();
                        break;

                    case "2":
                        menu.AddItemToCart();
                        break;

                    case "3":
                        menu.ListCartItems();
                        break;

                    case "4":
                        menu.RemoveItemFromCart();
                        break;

                    case "5":
                        menu.ClearCart();
                        break;

                    case "0":
                        return;

                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }
        }
    }
}
