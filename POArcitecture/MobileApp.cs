using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arcitecture
{
    public class MobileApp
    {
        private readonly Customer _customer;
        private readonly TicketProvider _ticketProvider;
        private readonly CustomerProvider _customerProvider;

        public MobileApp(TicketProvider ticketProvider, CustomerProvider customerProvider, string login, string pasw)
        {
            _ticketProvider = ticketProvider;
            _customerProvider = customerProvider;
            _customer = _customerProvider.GetCustomer(login, pasw);
        }
        public List<Ticket> GetTickets()
        {
            return _customer.Tickets;
        }
        public void SearchTicket(DateTime date)
        {
            _customer.Tickets = _ticketProvider.SearchTicket(_customer.Id, new DateTime());
        }
        public bool BuyTicket(string cardNumber)
        {
            return _ticketProvider.BuyTicket(_customer.Id, cardNumber);
        }
    }
}
