namespace lab5
{
    internal class BaseInform
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = !string.IsNullOrEmpty(value) ? value : throw new ArgumentException("Name cannot be null or empty"); }
        }

        private int _id;
        public int Id
        {
            get { return _id; }
            set { _id = value > 0 ? value : throw new ArgumentException("Id should be a positive integer"); }
        }

        private string _description;
        public string Description
        {
            get { return _description; }
            set { _description = !string.IsNullOrEmpty(value) ? value : throw new ArgumentException("Description cannot be null or empty"); }
        }

        private double _price;
        public double Price
        {
            get { return _price; }
            set { _price = value >= 0 ? value : throw new ArgumentException("Price cannot be negative"); }
        }

        private string _location;
        public string Location
        {
            get { return _location; }
            set { _location = !string.IsNullOrEmpty(value) ? value : throw new ArgumentException("Location cannot be null or empty"); }
        }

        public bool IsEdited { get; set; }
        public bool IsDeleted { get; set; }

        public BaseInform(string name, int id, string description, double price, string location)
        {
            Name = name;
            Id = id;
            Description = description;
            Price = price;
            Location = location;
            IsEdited = false;
            IsDeleted = false;
        }

        public override string ToString()
        {
            return $"Name: {Name}, ID: {Id}, Description: {Description}, Price: {Price}, Location: {Location}";
        }
    }
}