using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlsApp
{
    class Menu {

        private List<Product> products;
        private ShoppingCart cart;

        public Menu(List<Product> products, ShoppingCart cart) {
            this.products = products;
            this.cart = cart;
        }


        public void Display() {
            Console.WriteLine("\n----------------------------------M E N U------------------------------------------" +
                            "\n[1]  List all products and prices" +
                            "\n[2]  Add item to cart" +
                            "\n[3]  View cart items" +
                            "\n[4]  Remove item from cart" +
                            "\n[5]  Clear cart items" +
                            "\n[0]  Exit" +
                            "\n---------------------------------------------------------------------------------------- -"
                            );
        }

        public void ListProducts() {
            string productsView = "Product No.     Name       Price";
            for (int i = 0; i < products.Count; i++) {
                productsView += "\n" + (i + 1) + "     " + products[i].Name + "    " + products[i].Price;
            }

            Console.WriteLine(productsView);
        }

        public void ListCartItems() {
            string itemsView = "Cart Item No.      Name      Price      Qty      Subtotal";
            double total = 0;

            for (int i = 0; i < cart.GetItemList().Count; i++) {
                CartItem item = cart.GetItemList()[i];
                double subtotal = item.Qty * item.Price;
                total += subtotal;

                itemsView += "\n" + (i + 1) + "      " + item.Name + "      " + item.Price + "     " + item.Qty + "       " + subtotal;
            }

            Console.WriteLine(itemsView);
        }


        public void AddItemToCart() {
            ListProducts();
            Product product = products[selectItem()];
            Console.WriteLine("Enter Qty: ");
            int qty;

            while (true) {
                try {
                    qty = int.Parse(Console.ReadLine());
                    if (qty > 0) {
                        break;
                    }

                } catch (FormatException e) { }
                Console.WriteLine("Invalid Qty");
            }

            cart.AddItem(new CartItem(product.Code, product.Name, product.Price, qty));
        }


        public void RemoveItemFromCart() {
            ListCartItems();
            int number = selectItem();
            cart.RemoveItem(number);
        }


        private int selectItem() {
            while (true) {
                Console.WriteLine("Enter item number: ");
                try {
                    int number = int.Parse(Console.ReadLine()) - 1;

                    if (number >= 0) {
                        return number;
                    }

                } catch (FormatException e) {}
                Console.WriteLine("Invalid item number");
            }
        }


        public void ClearCart() {
            Console.WriteLine("Shopping Cart has been cleared");
            cart.ClearCart();
        }


    }
}
