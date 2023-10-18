namespace lab5
{
	internal class Goods : BaseInform
	{
		private string _category;
		public string Category
		{
			get { return _category; }
			set { _category = !string.IsNullOrEmpty(value) ? value : throw new ArgumentException("Category cannot be null or empty"); }
		}

		private int _stockQuantity;
		public int StockQuantity
		{
			get { return _stockQuantity; }
			set { _stockQuantity = value >= 0 ? value : throw new ArgumentException("StockQuantity cannot be negative"); }
		}

		private string _manufacturer;
		public string Manufacturer
		{
			get { return _manufacturer; }
			set { _manufacturer = !string.IsNullOrEmpty(value) ? value : throw new ArgumentException("Manufacturer cannot be null or empty"); }
		}

		public Goods(string name, int id, string description, double price, string location, string category, int stockQuantity, string manufacturer)
				: base(name, id, description, price, location)
		{
			Category = category;
			StockQuantity = stockQuantity;
			Manufacturer = manufacturer;
		}

		public override string ToString()
		{
			return base.ToString() + $", Category: {Category}, Stock Quantity: {StockQuantity}, Manufacturer: {Manufacturer}";
		}
	}
}