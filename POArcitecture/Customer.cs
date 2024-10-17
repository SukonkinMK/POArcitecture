using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arcitecture
{
    public class Customer
    {
        private static int customerCounter = 0;
        public Customer()
        {
            Id = ++customerCounter;
        }
        public int Id { get; }
        public List<Ticket> Tickets { get; set; }
    }
}
