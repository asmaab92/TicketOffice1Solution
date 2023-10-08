// See https://aka.ms/new-console-template for more information
using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;
using System.Transactions;
using TicketOffice1;

namespace TicketOffice1
{
    class program
    {
        static void Main(string[] args)
        {
            Ticket ticket = new Ticket();
            int price = 0;
            
            List<Ticket> tickets = new List<Ticket>();


                Console.WriteLine("Enter your age please.");
                ticket.Age = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("If you prefer a seated ticket type 'Seated', if you prefer a standing ticket type 'Standing'");
                string value = Console.ReadLine();


                switch (value)
                {
                    case "Seated":
                        ticket.Place = PlacePreference.Seated;
                        price = ticket.Price();
                        break;

                    case "Standing":
                        ticket.Place = PlacePreference.Standing;
                        price = ticket.Price();
                        break;

                    default:
                        Console.WriteLine("invalid value");
                        break;
                }

                Console.WriteLine("The price of the ticket is: " + price + "SEK");
                ticket.Tax();
                int number = TicketSalesManager.TicketNumberGenerator();
                Console.WriteLine("The ticket number is: {0}  ", number);


            TicketSalesManager ticketInstance = new TicketSalesManager(); // Create an instance of the TicketSalesManager class
            ticketInstance.AddTicket(ticket);

            Console.WriteLine("       ----------------------------------------------");
            Console.WriteLine("the list after removing the ticket number: 1512");


            ticketInstance.RemoveTicket(ticket);

            Console.WriteLine("       ----------------------------------------------");

            ticketInstance.SalesTotal();

            Console.WriteLine("       ----------------------------------------------");
            ticketInstance.AmountOfTickets();


        }


    }
}












