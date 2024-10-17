using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arcitecture
{
    public class Database
    {
        private static int counter = 0;
        public List<Ticket> Tickets { get; private set; } = new();
        public List<Customer> Customers { get; private set; } = new();

        public double GetTicketAmount() => 45;
        public int CreateTicketOrder(int clientId) => ++counter;
    }
}
