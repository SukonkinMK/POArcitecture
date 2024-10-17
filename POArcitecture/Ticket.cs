using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arcitecture
{
    public class Ticket
    {
        private static int ticketCounter = 0;
        public Ticket(int customerId, DateTime date)
        {
            CustomerId = customerId;
            Date = date;            
            Id = ++ticketCounter;
            QRCode = $"qwerty{Id}";
            Enable = false;
        }

        public int Id { get;  }
        public int CustomerId { get;  }
        public DateTime Date { get;  }
        public string QRCode { get; }
        public bool Enable { get; set; }
    }
}
