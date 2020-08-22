using System;
using System.Transactions;

namespace VendingMachineClasses
{
	public class Coin
	{
		// Instance Variable and Properties
		private string coinType;
		public string CoinType
        {
			get; private set;
        }

		// Constructors
		public Coin()
		{
		}

		public Coin(string coinType)
        {
			this.coinType = coinType;
        }
	}

}