// See https://aka.ms/new-console-template for more information
using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;
using System.Text.Json;
using System.Transactions;
using TicketOffice1;

namespace TicketOffice1
{
    class program
    {
        static void Main(string[] args)
        {
            string concertData = File.ReadAllText("C:\\Users\\deltagaren\\source\\repos\\TicketOffice1Solution\\TicketOffice1\\concert_data.json");

            List<Concert> concerts = JsonSerializer.Deserialize<List<Concert>>(concertData);




            List<Concert>presntConcerts = concerts
                .OrderBy(concerts => concerts.Date)
                .ToList();

            Console.WriteLine("The ordered list going from the present date is: ");

            foreach(Concert i in presntConcerts)
            {
              Console.WriteLine($"Id: {i.Id} , Reduced: {i.ReducedVenue} , Date: {i.Date} , Performers: {i.Performer} , Begins at: {i.BeginsAt} , Capacity sales: {i.FullCapacitySales} ");
            }

            Console.WriteLine("       ----------------------------------------------");
            Console.WriteLine("The list with all concerts of a ReducedVenue (true).");

            List<Concert> reduced = concerts
                .Where(i => i.ReducedVenue == true)
                .ToList();

            foreach (Concert i in reduced)
            {
                Console.WriteLine($"Id: {i.Id} , Reduced: {i.ReducedVenue} , Date: {i.Date} , Performers: {i.Performer} , Begins at: {i.BeginsAt} , Capacity sales: {i.FullCapacitySales} ");
            }

            Console.WriteLine("       ----------------------------------------------");
            Console.WriteLine("The list with all concerts in year 2024.");

            List<Concert> nextYearConcerts = concerts
            .Where(i => i.Date.Year == 2024)
            .ToList();

            foreach (Concert i in nextYearConcerts)
            {
                Console.WriteLine($"Id: {i.Id} , Reduced: {i.ReducedVenue} , Date: {i.Date} , Performers: {i.Performer} , Begins at: {i.BeginsAt} , Capacity sales: {i.FullCapacitySales} ");
            }

            Console.WriteLine("       ----------------------------------------------");
            Console.WriteLine("The list of the the five biggest projected sales figures is: ");

            List<Concert> biggestProjectedSalesFigures = concerts
                .OrderByDescending(i => i.FullCapacitySales)
                .Take(5)
                .ToList();

            foreach (Concert i in biggestProjectedSalesFigures)
            {
                Console.WriteLine($"Id: {i.Id} , Reduced: {i.ReducedVenue} , Date: {i.Date} , Performers: {i.Performer} , Begins at: {i.BeginsAt} , Capacity sales: {i.FullCapacitySales} ");
            }

            Console.WriteLine("       ----------------------------------------------");
            Console.WriteLine("The list with all concerts taking place on a Friday is: ");

            List<Concert> concertsOnFriday = concerts
                .Where(i => i.Date.DayOfWeek == DayOfWeek.Friday)
                .ToList() ;

            foreach (Concert i in concertsOnFriday)
            {
                Console.WriteLine($"Id: {i.Id} , Reduced: {i.ReducedVenue} , Date: {i.Date} , Performers: {i.Performer} , Begins at: {i.BeginsAt} , Capacity sales: {i.FullCapacitySales} ");
            }
            Console.ReadLine();




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












