namespace Travel_Agency_System
{
    class Tour:TravelEntity
    {
        private int duration;
        private List<Destination> destinations;
        private float price;
        private List<Booking> bookings;

        public Tour() : base() 
        {
            duration = 0;
            destinations = new List<Destination>();
            price = 0;
            bookings = new List<Booking>();
            
        }
        public Tour(string name, string description, int duration, List<Destination> destinations, float price,List<Booking> bookings):base(name, description)
        {
            this.duration = duration;
            this.destinations = destinations;
            this.price = price;
            this.bookings = bookings;
        }
        public int Duration
        {
            set { this.duration = value; }
            get { return this.duration; }   
        }
        public List<Destination> Destinations
        {
            set { destinations = value; }
            get { return destinations; }
        }
        public float Price
        {
            set { this.price = value; }
            get { return price; }
        }
        public List<Booking> Bookings 
        {
            set { this.bookings = value; }
            get { return bookings; }
        }

        public void AddDestination(Destination destination)
        {
            Destinations.Add(destination);
        }

        public void RemoveDestination(Destination destination)
        {
            Destinations.Remove(destination);
        }

        public int GetAvailableSeats()
        {
            int bookedSeats = Bookings.Sum(booking => booking.NumberOfSeats);
            int available = Destinations.Sum(destination => destination.Seats) - bookedSeats;
            return available;
        }

        public void MakeBooking(Customer customer, int numberOfSeats)
        {
            if (GetAvailableSeats() >= numberOfSeats)
            {
                Booking booking = new Booking(customer, this, numberOfSeats);
                Bookings.Add(booking);

                Console.WriteLine("Booking created successfully.");
            }
            else
            {
                Console.WriteLine("Not enough available seats for booking.");
            }
        }
        public void CancelBooking(Booking booking)
        {
            Bookings.Remove(booking);
        }

        public List<Booking> GetBookings()
        {
            return Bookings;
        }

        public List<Destination> GetDestinations()
        {
            return Destinations;
        }

        public float GetPrice()
        {
            return Price;
        }
    }
}
