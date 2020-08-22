using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using VendingMachineClasses;

namespace VendingMachineKata_CSharp
{
    [TestClass]
    public class VendingMachineUnitTests
    {
        [TestMethod]
        public void VendingMachineConstructorCreatesVendingMachines()
        {
            // Arrangement and Activation
            VendingMachine underTest = new VendingMachine();
            VendingMachine underTest2 = new VendingMachine();

            // Assertion
            Assert.AreEqual(underTest.GetType(), underTest2.GetType());
        }

        [TestMethod]
        public void VendingMachinesCreatedWithMoneyContainMoney()
        {
            // Arrangement and Activation
            VendingMachine underTest = new VendingMachine(0.05m);

            // Assertion
            Assert.AreEqual(0.05m, underTest.AmountInserted);
        }

        [TestMethod]
        public void QuarterHasCoinTypeQuarter()
        {
            // Arrangment and Activation
            Coin testQuarter = new Coin("quarter");

            // Assertion
            Assert.AreEqual("quarter", testQuarter.CoinType);
        }

        [TestMethod]
        public void VendingMachineAcceptsQuarters()
        {
            // Arrangement
            VendingMachine underTest = new VendingMachine();
            Coin quarter = new Coin("quarter");
            Console.WriteLine(quarter.CoinType);

            // Activation
            underTest.TakeCoin(quarter);

            // Assertion
            Assert.AreEqual(0.25m, underTest.AmountInserted);
        }
    }
}