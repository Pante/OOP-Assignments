using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace SalesEmployee {
    [TestClass]
    public class UnitTest1 {

        [TestMethod]
        public void getSalesTarget() {
            Assert.AreEqual(Program.getSalesTarget("-5"), 0);
            Assert.AreEqual(Program.getSalesTarget("1800"), 1800);
            Assert.AreEqual(Program.getSalesTarget("Whoops, a word"), 0);
        }

        [TestMethod]
        public void listSalesBelowTarget() {
            Boolean correct = true;
            int TARGET = 18000;
            List<SalesEmployee> list = new List<SalesEmployee>(Program.listSalesBelowTarget(Program.employeeList, TARGET));
            foreach(SalesEmployee s in list) {
                if(s.sales >= TARGET)
                    correct = false;
            }
            Assert.AreEqual(correct, true);
        }
    }
}
