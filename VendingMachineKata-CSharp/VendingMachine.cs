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

		private List<Coin> coinReturn;
		public List<Coin> CoinReturn { get; private set; }

		private List<Product> inventory;
		public List<Product> Inventory { get; private set; }

		// Constructors
		public VendingMachine() 
		{
			ValueInMachine = 0.0m;
			this.CoinReturn = new List<Coin>();
			this.Inventory = new List<Product>();
		}
		public VendingMachine(decimal valueInMachine)
        {
			this.ValueInMachine = valueInMachine;
			this.CoinReturn = new List<Coin>();
			this.Inventory = new List<Product>();
        }
		public VendingMachine(decimal amountInserted, List<Coin> coinReturn,  List<Product> inventory)
		{
			this.ValueInMachine = amountInserted;
			this.CoinReturn = coinReturn;
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
			else 
			{
				CoinReturn.Add(insertedCoin);
			}
        }

		public string DisplayStatus()
        {
			if (ValueInMachine > 0.0m)
            {
				return $"${ValueInMachine}";
            }
			else
            {
				return "INSERT COIN";
            }
        }

		public Product SelectProduct(int choice)
        {
			if (choice == 1) { return new Product("cola"); }
			else if (choice == 2) { return new Product("chips"); }
			else if (choice == 3) { return new Product("candy"); }
			else { return null; }
        }
	}
}