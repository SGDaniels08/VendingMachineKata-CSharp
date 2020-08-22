using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net.Http.Headers;

namespace VendingMachineClasses
{
	public class VendingMachine
	{
		// Instance Variables and Properties
		private decimal valueInMachine;
		public decimal ValueInMachine { get; private set; }

		private List<Product> inventory;
		public List<Product> Inventory { get; private set; }

		// Constructors
		public VendingMachine() 
		{
			ValueInMachine = 0.0m;
		}
		public VendingMachine(decimal amountInserted)
        {
			this.ValueInMachine = amountInserted;
        }
		public VendingMachine(decimal amountInserted, List<Product> inventory)
		{
			this.ValueInMachine = amountInserted;
			this.Inventory = inventory;
		}

		// Other methods
		public void TakeCoin(Coin insertedCoin)
        {
			if (insertedCoin.CoinType == "quarter")
			{
				ValueInMachine += 0.25m;
			}
			else if (insertedCoin.CoinType == "dime")
            {
				ValueInMachine += 0.10m;
            }
			else if (insertedCoin.CoinType == "nickel")
            {
				ValueInMachine += 0.05m;
            }
        }

		public string DisplayStatus()
        {
			if (valueInMachine > 0.0m)
            {
				return $"{ValueInMachine}";
            }
			else
            {
				return "INSERT COIN";
            }
        }
	}
}