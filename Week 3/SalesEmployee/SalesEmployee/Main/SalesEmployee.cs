using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesEmployee {
    class SalesEmployee {
        public int Id {get; set; }
        public string Name { get; set; }
        public double BasicSalary { get; set; }
        public double Sales { get; set; }

        public SalesEmployee(int d, string n, double bSalary, double s) {
            Id = d;
            Name = n;
            BasicSalary = bSalary;
            Sales = s;
        }

        public double calculateCommission() {
            return Sales * 0.05;
        }

        public double calculatePay() {
            return BasicSalary + calculateCommission();
        }
    }
}
