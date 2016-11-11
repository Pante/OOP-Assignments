using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesEmployee {
    class Program {

        public static List<SalesEmployee> employeeList = new List<SalesEmployee>();

        static void Main(string[] args) {
            employeeList = initEmployeeList(employeeList);

            listEmployees(employeeList);
            listEmployeePay(employeeList);
            listSalesBelowTarget(employeeList);
            calculateAverageSales(employeeList);
            findLowestSales(employeeList);
            
            Console.ReadLine();
        }

        // Disgusting hardcode
        static List<SalesEmployee> initEmployeeList(List<SalesEmployee> employeeList) {
            employeeList.Add(new SalesEmployee(101, "Angie", 1200, 15000));
            employeeList.Add(new SalesEmployee(105, "Cindy", 1000, 12000));
            employeeList.Add(new SalesEmployee(108, "David", 1500, 20000));
            employeeList.Add(new SalesEmployee(112, "Jason", 3000, 30000));
            employeeList.Add(new SalesEmployee(127, "Vivian", 2000, 25000));
            return employeeList;
        }

        static void listEmployees(List<SalesEmployee> employeeList) {
            Console.WriteLine(String.Format("{0,-20} {1,-20} {2,-20} {3,-20}", "Id", "Name", "Basic Salary", "Sales"));
            for(int i = 0; i < employeeList.Count; i++) {
                Console.WriteLine(String.Format("{0,-20} {1,-20} {2,-20} {3,-20}", employeeList[i].id, employeeList[i].name, employeeList[i].basicSalary, employeeList[i].sales));
            }
        }

        static void listEmployeePay(List<SalesEmployee> employeeList) {
            Console.WriteLine(String.Format("{0,-20} {1,-20} {2,-20}", "Id", "Name", "Pay"));
            for(int i = 0; i < employeeList.Count; i++) {
                Console.WriteLine(String.Format("{0,-20} {1,-20} {2,-20}", employeeList[i].id, employeeList[i].name, employeeList[i].calculatePay()));
            }
        }

        public static int getSalesTarget(string rawinput) {
            try {
                //return Int32.Parse(Console.ReadLine());
                int input = Int32.Parse(rawinput);
                if(input > 0)
                    return input;
                else
                    return 0;
            } catch(FormatException e) {
                Console.WriteLine(e);
                return 0;
            }
        }

        // Void method that prints out sales below target
        public static List<SalesEmployee> listSalesBelowTarget(List<SalesEmployee> employeeList, int target = -1) {

            if(target < 0) {
                Console.Write("Enter the sales target: $");
                target = getSalesTarget(Wrapper.readLine());
            }

            List<SalesEmployee> belowTarget = new List<SalesEmployee>();

            for(int i = 0; i < employeeList.Count; i++) {
                if(employeeList[i].sales < target)
                    belowTarget.Add(employeeList[i]);
            }

            Console.WriteLine("Sales employee with sales below $" + target);
            Console.WriteLine(String.Format("{0,-20} {1,-20} {2,-20}", "Id", "Name", "Sales"));
            for(int i = 0; i < belowTarget.Count; i++) {
                Console.WriteLine(String.Format("{0,-20} {1,-20} ${2,-20}", belowTarget[i].id, belowTarget[i].name, belowTarget[i].sales));
            }

            return belowTarget;
        }

        public static void calculateAverageSales(List<SalesEmployee> employeeList) {
            double total = 0;
            foreach(SalesEmployee s in employeeList)
                total += s.sales;
            Console.WriteLine("Average sales of all emplyees: $" + total/employeeList.Count());
        }

        public static void findLowestSales(List<SalesEmployee> employeeList) {
            Console.WriteLine("Employee with lowest sales");
            Console.WriteLine(String.Format("{0,-20} {1,-20} {2,-20}", "Id", "Name", "Sales"));
            double lowest = employeeList[0].sales;
            int check = 0;
            for(int i = 1; i < employeeList.Count-1; i++) {
                if(employeeList[i].sales < lowest) {
                    lowest = employeeList[i].sales;
                    check = i;
                }
            }
            Console.WriteLine(String.Format("{0,-20} {1,-20} {2,-20}", employeeList[check].id, employeeList[check].name, employeeList[check].sales));
        }
    }

}
