using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SalesEmployee {
    [TestClass]
    public class UnitTest1 {
        [TestMethod]
        public void calculateCommission() {
            SalesEmployee employee = new SalesEmployee(5, "n", 500.00, 100);
            Assert.AreEqual(employee.calculateCommission(), 100.05, "Account not debited correctly");
        }
    }
}
