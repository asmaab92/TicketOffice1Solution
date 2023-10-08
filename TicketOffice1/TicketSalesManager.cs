using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketOffice1
{
    public class TicketSalesManager
    {
        List<Ticket> tickets = new List<Ticket>();
         
        public static int TicketNumberGenerator()
        {
            var random = new Random();
            int number = random.Next(0, 8000);
            
            return number;
        }

        public  Ticket AddTicket(Ticket ticket)
        {
            tickets.Add(new Ticket() { Age = 4, Place = PlacePreference.Seated, ticketPrice = 50, Number = 654});
            tickets.Add(new Ticket() { Age = 15, Place = PlacePreference.Seated, ticketPrice = 170, Number = 1436 });
            tickets.Add(new Ticket() { Age = 70, Place = PlacePreference.Seated, ticketPrice = 100, Number = 1512 });
            tickets.Add(new Ticket() { Age = 35, Place = PlacePreference.Standing, ticketPrice = 110, Number = 876 }) ;
            tickets.Add(new Ticket() { Age = 2, Place = PlacePreference.Seated, ticketPrice = 50, Number = 877 });

            
            foreach (Ticket ticket1 in tickets)
            {
                Console.WriteLine(ticket1);
            }
            return ticket; 
        }

        public Boolean RemoveTicket(Ticket ticket)
        {
            tickets.Remove(new Ticket() {Number = 1512});

            foreach (Ticket ticket1 in tickets)
            {
                Console.WriteLine(ticket1);
            }

            return true;
        }

        public decimal SalesTotal()
        {
           
           decimal sum = tickets.Sum(ticket => ticket.ticketPrice);

            Console.WriteLine("The total price of the tickets is:  " + sum);
            return sum;
        }

        public int AmountOfTickets()
        {
           int count = tickets.Count();

            Console.WriteLine("the number of tickets is; " + count);
            return count;
        }

    }
}
