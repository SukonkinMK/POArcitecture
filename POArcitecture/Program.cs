// See https://aka.ms/new-console-template for more information
using Arcitecture;

Core core = new();
MobileApp mobileApp = new(core.GetTicketProvider(), core.GetCustomerProvider(), "Misha123","pasword");
BusStation busStation = new(core.GetTicketProvider());

if (mobileApp.BuyTicket("10001001001"))
{
    Console.WriteLine("Клиент успешно купил билет");
    mobileApp.SearchTicket(new DateTime());
    Ticket ticket = mobileApp.GetTickets().First();
    if(busStation.CheckTicket(ticket.QRCode))
        Console.WriteLine("Клиент успешно прошел в автобус");
}