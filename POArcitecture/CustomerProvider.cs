using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arcitecture
{
    public class CustomerProvider
    {
        private Database _database;

        public CustomerProvider(Database database)
        {
            _database = database;
        }
        public Customer GetCustomer(string login, string pasw)
        {
            return new Customer();
        }
    }
}
