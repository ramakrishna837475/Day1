using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{
    class Program
    {
        class Passanger
        {
            public string Name { get; set; }
            public int Age { get; set; }
            Ticket Ticket { get; set; }
            public Passanger(string name, int age)
            {
                Name = name;
                Age = age;
                Ticket = new Ticket();
            }
            public void TicketBooking(int tickets)
            {
                Ticket.Tickets = tickets;
                Console.WriteLine("Ticket Booked Successfully");
            }
        }




        class Ticket
        {
            public int tickets;
            public int Tickets
            {
                get => tickets;
                set
                {
                    if (value > 2)
                        throw new Exception("Cannot book more than 2 tickets");
                    else
                        tickets = value;
                }
            }




        }
        static void Main(string[] args)
        {
            Passanger psang = new Passanger("Ramya", 22);
            Console.Write("Enter the number of tickets :");
            psang.TicketBooking(int.Parse(Console.ReadLine()));
            Console.Read();
        }




    }
}

