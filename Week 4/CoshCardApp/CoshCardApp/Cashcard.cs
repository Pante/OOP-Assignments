using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoshCardApp {
    class Cashcard {

        public string id { get; set; }
        public double balance { get; set; }


        public Cashcard(string id = null, double balance = 0) {
            this.id = id;
            if (balance >= 0) {
                this.balance = balance;

            } else {
                throw new FormatException("Balance must be a positive number");
            }
            
        }


        public void TopUp(double amount) {
            if (amount >= 0) {
                balance += amount;

            } else {
                throw new FormatException("Top amount must be a positive number");
            }
        }

        
        public bool Deduct(double amount) {
            bool deduction = balance >= amount;

            if (deduction) {
                balance -= amount;
            }

            return deduction;
        }

    }
}
