using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arcitecture
{
    public class BusStation
    {
        private readonly TicketProvider _ticketProvider;

        public BusStation(TicketProvider ticketProvider)
        {
            _ticketProvider = ticketProvider;
        }

        public bool CheckTicket(string qrcode) => _ticketProvider.CheckTicket(qrcode);
    }
}
