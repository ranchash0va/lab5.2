namespace lab5
{
    internal class Service : BaseInform
    {
        private string _provider;
        public string Provider
        {
            get { return _provider; }
            set { _provider = !string.IsNullOrEmpty(value) ? value : throw new ArgumentException("Provider cannot be null or empty"); }
        }

        private int _duration;
        public int Duration
        {
            get { return _duration; }
            set { _duration = value >= 0 ? value : throw new ArgumentException("Duration cannot be negative"); }
        }

        private bool _isAvailable;
        public bool IsAvailable
        {
            get { return _isAvailable; }
            set { _isAvailable = value; }
        }

        public Service(string name, int id, string description, double price, string location, string provider, int duration, bool isAvailable)
                 : base(name, id, description, price, location)
        {
            Provider = provider;
            Duration = duration;
            IsAvailable = isAvailable;
        }

        public override string ToString()
        {
            return base.ToString() + $", Provider: {Provider}, Duration: {Duration}, Is Available: {IsAvailable}";
        }
    }
}