using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace exam
{
    internal class Event : IComparable <Event>
    {
        public string Name { get; set; }

        public DateTime EventDate { get; set; }

        public List<Ticket> Tickets { get; set; }

        public enum EventType
        {
            Music,
            Comedy,
            Theater,
        }

        public EventType TypeOfEvent { get; set; }

        public override string ToString()
        {
            return $"{Name}, {EventDate}, {TypeOfEvent}";
        }

        public int CompareTo(Event other)
        {
            return EventDate.CompareTo(other.EventDate);
        }
    }
}

