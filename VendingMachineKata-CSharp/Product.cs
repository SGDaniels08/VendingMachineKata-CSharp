using System;

namespace VendingMachineClasses
{ 
	public class Product
	{
		// Fields and Properties
		private string productType;
		public string ProductType { get; private set; }
	
		// Constructors
		public Product()
		{
		}
		
		public Product(string productType)
        {
			this.ProductType = productType;
        }

	}
}