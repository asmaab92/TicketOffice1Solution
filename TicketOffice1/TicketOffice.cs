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
        

       
        public int TicketNumberGenerator()
        {
            var random = new Random();
            int number = random.Next(0, 8000);
            Console.WriteLine("The ticket number is: {0} ", number);
            return number;
        }
    }

}
