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

    }
    internal class Ticket
    {
        public string Name { get; set; }

        public decimal Price { get; set; }

        public int AvailableTickets { get; set; }

    }
}
