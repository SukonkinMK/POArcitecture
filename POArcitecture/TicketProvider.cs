using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arcitecture
{
    public class TicketProvider
    {
        private readonly Database _database;
        private readonly PaymentProvider _paymentProvider;

        public TicketProvider(Database database, PaymentProvider paymentProvider)
        {
            _database = database;
            _paymentProvider = paymentProvider;
        }

        public List<Ticket> SearchTicket(int clientId, DateTime date)
        {
            //Предусловие
            if (_database.Tickets.Count() == 0)
                throw new Exception("База данных билетов пуста");

            List<Ticket> tickets = new();
            foreach (var ticket in _database.Tickets)
            {
                if (ticket.CustomerId == clientId && ticket.Date == date)
                    tickets.Add(ticket);
            }
            return tickets;
        }

        public bool BuyTicket(int clientId, string cardNumber)
        {
            //Предусловие
            if(clientId < 0  || cardNumber is null)
                throw new ArgumentException("Id клиента больше нуля и номер карты не может быть пустым");

            int orderId = _database.CreateTicketOrder(clientId);
            double amount = _database.GetTicketAmount();
            bool result = _paymentProvider.BuyTicket(orderId, cardNumber, amount);
            if (result)
                _database.Tickets.Add(new Ticket(clientId,new DateTime()));
            //Постусловие
            if (result && _database.Tickets.Count == 0)
                throw new Exception("Билет куплен, но не добавлен в базу");
            return result;
        }

        public bool CheckTicket(string qrcode)
        {
            //Предусловие
            if (_database.Tickets.Count() == 0)
                throw new Exception("База данных билетов пуста");

            foreach (var ticket in _database.Tickets)
            {
                if (ticket.QRCode.Equals(qrcode))
                {
                    ticket.Enable = false;
                    return true;
                }
            }
            return false;
        }
    }
}
