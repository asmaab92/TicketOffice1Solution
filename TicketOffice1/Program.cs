﻿// See https://aka.ms/new-console-template for more information
using System.Reflection.Metadata.Ecma335;
using System.Transactions;
using TicketOffice1;

namespace TicketOffice1
{
    class program
    {
        static void Main(string[] args)
        {
            TicketOffice ticket = new TicketOffice();
            int price = 0;
           
            Console.WriteLine("Enter your age please.");
            ticket.Age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("If you prefer a seated ticket type 'Seated', if you prefer a standing ticket type 'Standing'");
            string value = Console.ReadLine();

           
            switch (value)
            {
                case "Seated":
                    ticket.Place = PlacePreference.Seated;
                    price = ticket.PriceSetter();
                    break;

                case "Standing":
                    ticket.Place = PlacePreference.Standing;
                    price = ticket.PriceSetter();
                    break;

                default:
                    Console.WriteLine("invalid value");
                    break;
            }

            ticket.TaxCalculator(price);
            ticket.TicketNumberGenerator();
        }

    }
}











