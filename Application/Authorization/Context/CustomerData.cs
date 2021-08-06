using Authorization.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Authorization.Context
{
    public class CustomerData 
    {

        public List<Customer> Customers = new List<Customer>() {
                new Customer(){ Username = "Raghav", Password = "123", PortfolioId=1 },
                new Customer(){ Username = "Subhashish", Password = "456", PortfolioId=2 },
                new Customer(){ Username = "Rishit", Password = "789", PortfolioId=3 },
                new Customer(){ Username = "Rohit", Password = "123", PortfolioId=4 },
                new Customer(){ Username = "Alice", Password = "456", PortfolioId=5 },
            };
    }
}
