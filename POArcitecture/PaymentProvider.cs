using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arcitecture
{
    public class PaymentProvider
    {
        public bool BuyTicket(int orderId, string cardNumber, double amount)
        {
            //todo: обращентие к платежному шлюзу
            return true;
        }
    }
}
