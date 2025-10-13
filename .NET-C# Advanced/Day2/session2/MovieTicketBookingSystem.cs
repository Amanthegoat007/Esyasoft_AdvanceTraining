using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Task 2:Movie Ticket Booking System
//Create a class Movie with fields: movieName, totalSeats, bookedSeats.

//Implement:

//Constructor to initialize movie details.

//Methods: BookSeats(int), CancelSeats(int), DisplayAvailableSeats().

//Create objects and simulate booking and cancellation.

//Challenge: Prevent booking more seats than available.
namespace session2
{
    internal class MovieTicketBookingSystem(string movie, int totalSeats)
    {
        public string movieName = movie;
        public int totalSeats = totalSeats;
        public int bookedSeats = 0;
        public void BookSeats(int noOfSeats)
        {
            if (bookedSeats + noOfSeats <= totalSeats)
            {
                bookedSeats += noOfSeats;
                Console.WriteLine("Your Tickets has been booked!");
            }
            else
            {
                Console.WriteLine($"Seats are full Can't book all the tickets!,Your total tickets booked are {bookedSeats + noOfSeats - totalSeats}");
            }
        }
        public void CancelSeats(int noOfSeats)
        {
            if (bookedSeats - noOfSeats >= 0)
            {
                bookedSeats -= noOfSeats;
                Console.WriteLine("Your Tickets has been Cancelled!");
            }
            else
            {
                bookedSeats = 0;
            }
        }
        public void AvailableSeats()
        {
            Console.WriteLine($"The available Seats are {totalSeats - bookedSeats}");
        }
    }
}
