using Microsoft.VisualStudio.TestTools.UnitTesting;
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
    }
}