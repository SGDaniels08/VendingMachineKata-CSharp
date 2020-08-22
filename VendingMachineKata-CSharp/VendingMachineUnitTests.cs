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
            Assert.AreEqual(0.05m, underTest.ValueInMachine);
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
        public void DimeHasCoinTypeDime()
        {
            // Arrangement and Activation
            Coin testDime = new Coin("dime");

            // Assertion
            Assert.AreEqual("dime", testDime.CoinType);
        }

        [TestMethod]
        public void NickenHasCoinTypeNickel()
        {
            // Arrangement and Activation
            Coin testNickel = new Coin("nickel");

            // Assertion
            Assert.AreEqual("nickel", testNickel.CoinType);
        }

        [TestMethod]
        public void PennyHasCoinTypePenny()
        {
            // Arrangement and Activation
            Coin testPenny = new Coin("penny");

            // Assertion
            Assert.AreEqual("penny", testPenny.CoinType);
        }

        [TestMethod]
        public void VendingMachineAcceptsQuarters()
        {
            // Arrangement
            VendingMachine underTest = new VendingMachine();
            Coin quarter = new Coin("quarter");

            // Activation
            underTest.TakeCoin(quarter);

            // Assertion
            Assert.AreEqual(0.25m, underTest.ValueInMachine);
        }

        [TestMethod]
        public void VendingMachineAcceptsDimes()
        {
            // Arrangement
            VendingMachine underTest = new VendingMachine();
            Coin dime = new Coin("dime");

            // Activation
            underTest.TakeCoin(dime);

            // Assertion
            Assert.AreEqual(0.10m, underTest.ValueInMachine);

        }

        [TestMethod]
        public void VendingMachineAcceptsNickels()
        {
            // Arrangement
            VendingMachine underTest = new VendingMachine();
            Coin nickel = new Coin("nickel");

            // Activation
            underTest.TakeCoin(nickel);

            // Assertion
            Assert.AreEqual(0.05m, underTest.ValueInMachine);

        }

        [TestMethod]
        public void VendingMachineRejectsPennies()
        {
            // Arrangement
            VendingMachine underTest = new VendingMachine(0.15m);
            Coin penny = new Coin("penny");

            // Activation
            underTest.TakeCoin(penny);

            // Assertion
            Assert.AreEqual(0.15m, underTest.ValueInMachine);
        }

        [TestMethod]
        public void EmptyConstructorSetsAmountToZero()
        {
            // Arrangement and Activation
            VendingMachine testMachine = new VendingMachine();

            // Assertion
            Assert.AreEqual(0.0m, testMachine.ValueInMachine);

        }

        [TestMethod]
        public void VendingMachineDisplaysINSERTCOINIfNoMoney()
        {
            // Arrangement
            VendingMachine testMachine = new VendingMachine();

            // Activation
            string result = testMachine.DisplayStatus();

            // Assertion
            Assert.AreEqual("INSERT COIN", result);
        }

        [TestMethod]
        public void VendingMachineDisplaysAmountIfMoneyInMachine()
        {
            // Arrangement
            VendingMachine testMachine = new VendingMachine(0.35m);

            // Activation
            string result = testMachine.DisplayStatus();

            // Assertion
            Assert.AreEqual("$0.35", result);
        }

        [TestMethod]
        public void AcceptedCoinDoesNotEnterCoinReturn()
        {
            // Arrangement
            VendingMachine testMachine = new VendingMachine();
            Coin testQuarter = new Coin("quarter");

            // Activation
            testMachine.TakeCoin(testQuarter);

            // Assertion
            Assert.AreEqual(0, testMachine.CoinReturn.Count);
        }

        [TestMethod]
        public void RejectedCoinGoesIntoCoinReturn()
        {
            // Arrangement
            VendingMachine testMachine = new VendingMachine();
            Coin testPenny = new Coin("penny");

            // Activation
            testMachine.TakeCoin(testPenny);

            // Assertion
            Assert.AreEqual(1, testMachine.CoinReturn.Count);
        }

        [TestMethod]
        public void RejectedCoinInCoinReturnIsCorrectType()
        {
            // Arrangement
            VendingMachine testMachine = new VendingMachine();
            Coin testPenny = new Coin("penny");
            Coin testLoon = new Coin("loon");

            // Activation
            testMachine.TakeCoin(testPenny);
            testMachine.TakeCoin(testLoon);

            // Assertion
            Assert.AreEqual("loon", testMachine.CoinReturn[1].CoinType);
        }

        

    }
}