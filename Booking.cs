namespace Travel_Agency_System
{
    class Booking
    {
        private Customer customer ;
        private Tour tour ;
        private int numberOfSeats;

        public Booking(Customer customer, Tour tour, int numberOfSeats)
        {
            this.customer = customer;
            this.tour = tour;
            this.numberOfSeats = numberOfSeats;
        }

        public Customer Customer
        {
            set { this.customer = value; }
            get { return this.customer; }
        }
        public Tour Tour 
        {
            set { this.tour = value; }
            get { return this.tour; } 
        }
        public int NumberOfSeats
        {
            set { numberOfSeats = value; }
            get { return numberOfSeats; }
        }
    }
}
