using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inlamning1ASP.NET.models
{
    public class AttenderEvent
    {
        public int AttenderEventId { get; set; }
        public int EventId { get; set; }
        public int AttenderId { get; set; }

        public Attender Attender { get; set; }
        public Event Event { get; set; }
    }
}