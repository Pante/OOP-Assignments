using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlsApp
{
    public class ShoppingCart
    {
        public List<CartItem> itemList { get; set; }

        public ShoppingCart() {
            itemList = new List<CartItem>();
        }

        public void AddItem(CartItem item) {
            itemList.Add(item);
        }

        public List<CartItem> GetItemList() {
            return itemList;
        }

        public bool RemoveItem(int index) {
            bool value;
            if (value = index < itemList.Count) {
                itemList.RemoveAt(index);
            }

            return value;
        }


        public void ClearCart() {
            itemList.Clear();
        }


        public int Size() {
            return itemList.Count();
        }

        public bool IsEmpty() {
            return itemList.Count == 0;
        }


    }
}
