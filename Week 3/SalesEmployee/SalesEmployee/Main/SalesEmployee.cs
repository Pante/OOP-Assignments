using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesEmployee {
    class SalesEmployee {
        public int id { get; set; }
        public string name { get; set; }
        public double basicSalary { get; set; }
        public double sales { get; set; }

        public SalesEmployee(int id, string name, double basicSalary, double sales) {
            this.id = id;
            this.name = name;
            this.basicSalary = basicSalary;
            this.sales = sales;
        }

        public double calculateCommission() {
            return sales * 0.05;
        }

        public double calculatePay() {
            return basicSalary + calculateCommission();
        }
    }
}
