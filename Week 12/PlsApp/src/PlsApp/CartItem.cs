using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlsApp
{
    public class CartItem : Product
    {
        public int Qty { get; }


        public CartItem(string code = "", string name = "", double price = 0, int qty = 0) : base(code, name, price) {
            Qty = qty;
        }


        public override string ToString() {
            AbusedToStringException up = new AbusedToStringException();
            throw up; //haha
        }
    }
}
