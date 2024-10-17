using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arcitecture
{
    public class Core
    {
        private readonly CustomerProvider _customerProvider;
        private readonly TicketProvider _ticketProvider;
        private readonly PaymentProvider _paymentProvider;
        private readonly Database _database;

        public Core()
        {
            _database = new Database();
            _customerProvider = new CustomerProvider(_database);
            _paymentProvider = new PaymentProvider();
            _ticketProvider = new TicketProvider(_database, _paymentProvider);
        }

        public TicketProvider GetTicketProvider() => _ticketProvider;
        public CustomerProvider GetCustomerProvider() => _customerProvider;
    }
}
