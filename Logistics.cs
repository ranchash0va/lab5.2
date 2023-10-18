namespace lab5
{
    internal class Logistics : BaseInform
    {
        private string _transportType;
        public string TransportType
        {
            get { return _transportType; }
            set { _transportType = !string.IsNullOrEmpty(value) ? value : throw new ArgumentException("TransportType cannot be null or empty"); }
        }

        private string _destination;
        public string Destination
        {
            get { return _destination; }
            set { _destination = !string.IsNullOrEmpty(value) ? value : throw new ArgumentException("Destination cannot be null or empty"); }
        }

        private DateTime _deliveryDate;
        public DateTime DeliveryDate
        {
            get { return _deliveryDate; }
            set { _deliveryDate = value; }
        }

        public Logistics(string name, int id, string description, double price, string location, string transportType, string destination, DateTime deliveryDate)
               : base(name, id, description, price, location)
        {
            TransportType = transportType;
            Destination = destination;
            DeliveryDate = deliveryDate;
        }

        public override string ToString()
        {
            return base.ToString() + $", Transport Type: {TransportType}, Destination: {Destination}, Delivery Date: {DeliveryDate}";
        }
    }
}