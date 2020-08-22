using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net.Http.Headers;

namespace VendingMachineClasses
{
	public class VendingMachine
	{
		// Instance Variables and Properties
		private decimal amountInserted;
		public decimal AmountInserted { get; private set; }

		private List<Product> inventory;
		public List<Product> Inventory { get; private set; }

		// Constructors
		public VendingMachine() { }
		public VendingMachine(decimal amountInserted)
        {
			this.AmountInserted = amountInserted;
        }
		public VendingMachine(decimal amountInserted, List<Product> inventory)
		{
			this.AmountInserted = amountInserted;
			this.Inventory = inventory;
		}
	}
}