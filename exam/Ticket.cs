using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    internal class VIPticket : Ticket
    {
        public string AdditionalExtras { get; set; }

        public decimal AdditionalCost { get; set; }

        public VIPticket(string name, decimal price, int availableTickets) : base(name, price, availableTickets)
        {
        }
    }
    internal class Ticket
    {
        public string Name { get; set; }

        public decimal Price { get; set; }

        public int availableTickets { get; set; }

        public Ticket(string name, decimal price, int availableTickets)
        {
            Name = name;
            Price = price;
            availableTickets = availableTickets;
        }

    }
}
