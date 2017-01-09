using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlsApp
{
    public class Product
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }


        public Product(string code = "", string name = "", double price = 0) {
            Code = code;
            Name = name;
            Price = price;
        }


        public override string ToString() {
            throw new AbusedToStringException();
        }
    }
}
