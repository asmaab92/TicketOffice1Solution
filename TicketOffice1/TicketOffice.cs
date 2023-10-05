using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketOffice1
{
    public class TicketOffice
    {
       public int Age {  get; set; }
       public PlacePreference Place {  get; set; }

        public TicketOffice()
        {
        }

        public TicketOffice(int age, PlacePreference place)
        {
            Age = age;
            Place = place;
        }
        public  int PriceSetter()
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

        public  decimal TaxCalculator(int price)
        {
            
            decimal tax = Convert.ToDecimal(1 - 1 / 1.06) * price;
            Console.WriteLine("The paid tax is: " + tax + "SEK");
            return tax;
        }
        public int TicketNumberGenerator()
        {
            var random = new Random();
            int n = random.Next(0, 8000);
            Console.WriteLine("The ticket number is: {0} ", n);
            return n;
        }
    }

}
