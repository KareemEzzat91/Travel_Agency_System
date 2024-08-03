namespace Travel_Agency_System
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new destination in Egypt
            Destination destination = new Destination();
            destination.Name = "Luxor";
            destination.Description = "Explore the ancient wonders of Luxor, Egypt";
            destination.Seats = 50;

            // Create a new tour
            Tour tour = new Tour();
            tour.Name = "Luxor Adventure";
            tour.Description = "Experience the magic of Luxor and its historical sites";
            tour.Duration = 5;
            tour.Price = 1500.00f;

            // Add the destination to the tour
            tour.AddDestination(destination);

            // Create a new customer
            Customer customer = new Customer();
            customer.Name = "Yasser Mohammed";
            customer.Email = "yasser.mohammed@example.com";

            // Make a booking for the customer
            tour.MakeBooking(customer, 2);

            // Get the list of bookings for the tour
            List<Booking> bookings = tour.GetBookings();

            // Print out the booking information
            Console.WriteLine("Bookings for tour: {0}", tour.Name);
            foreach (Booking booking in bookings)
            {
                Console.WriteLine("{0} - {1} seats - {2}", booking.Customer.Name, booking.NumberOfSeats, booking.Tour.Name);
            }

            // Cancel the booking
            Booking bookingToCancel = bookings[0];
            tour.CancelBooking(bookingToCancel);

            // Print out the updated booking information
            bookings = tour.GetBookings();
            Console.WriteLine("Bookings for tour: {0}", tour.Name);
            foreach (Booking booking in bookings)
            {
                Console.WriteLine("{0} - {1} seats - {2}", booking.Customer.Name, booking.NumberOfSeats, booking.Tour.Name);
            }
        }
    }
}