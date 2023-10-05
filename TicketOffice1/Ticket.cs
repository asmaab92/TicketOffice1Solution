using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace TicketOffice1
{
    public class Ticket
    {
        public Ticket() 
        {
        }
        public int Age { get; set; }
        public PlacePreference Place { get; set; }
        public int Number { get; set; }

        public Ticket(int age, PlacePreference place)
        {
            this.Age = age;
            this.Place = place;

           
            this.Number = TicketOffice.TicketNumberGenerator();

            
        }

        public int Price()
        {
            int age = Age;
            PlacePreference place = Place;
            int price = 0;

            if (age <= 11 && place == PlacePreference.Seated)
            {
                price = 50;


            }
            else if (age <= 11 && place == PlacePreference.Standing)
            {
                price = 25;
            }
            else if (age >= 12 && age <= 64 && place == PlacePreference.Seated)
            {
                price = 170;
            }
            else if (age >= 12 && age <= 64 && place == PlacePreference.Standing)
            {
                price = 110;
            }
            else if (age >= 65 && place == PlacePreference.Seated)
            {
                price = 100;
            }
            else if (age >= 65 && place == PlacePreference.Standing)
            {
                price = 60;
            }
            Console.WriteLine("The price of the ticket is: " + price + "SEK");

            return price;
        }
        public decimal Tax()
        {
            int price = Price();

            decimal tax = Convert.ToDecimal(1 - 1 / 1.06) * price;
            Console.WriteLine("The paid tax is: " + tax + "SEK");
            return tax;
        }
    }
}
