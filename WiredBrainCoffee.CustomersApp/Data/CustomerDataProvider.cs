using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WiredBrainCoffee.CustomersApp.Model;

namespace WiredBrainCoffee.CustomersApp.Data
{
    public class CustomerDataProvider : ICustomerDataProvider
    {
        public async Task<IEnumerable<Customer>?> GetAllAsync()
        {
            await Task.Delay(100); // Simulate a bit of server work

            return new List<Customer>
            {
                new Customer{Id = 1, FirstName="Eslam",LastName="Sallam",IsDeveloper=true},
                new Customer{Id = 2, FirstName="Alex",LastName="Rider"},
                new Customer{Id = 3, FirstName="Ahmed",LastName="Hassan",IsDeveloper=true},
                new Customer{Id = 4, FirstName="Ali",LastName="Magdy"},
                new Customer{Id = 5, FirstName="Mostafa",LastName="Ahmed"},
                new Customer{Id = 6, FirstName="Hamdy",LastName="Osama"}
            };
        }
    }
}
