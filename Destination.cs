namespace Travel_Agency_System
{
    class Destination:TravelEntity
    {
        private int seats;

        public Destination() : base() 
        {
            this.seats = 0;
        }
        public Destination(string name,string destination,int seats):base(name,destination) 
        { 
            this.seats = seats;
        }

        public int Seats
        {
            set { this.seats = value; }
            get { return this.seats; }
        }
    }
}
