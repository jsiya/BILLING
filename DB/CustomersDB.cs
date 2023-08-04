using BILLING.Models;
using BILLING.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BILLING.DB
{
    public class CustomersDB : IRepository<Customer>
    {
        public ObservableCollection<Customer>? Customers { get; set; }
        public CustomersDB()
        {
            List<Tariff> tariffs = new List<Tariff>
        {
            new Tariff() { Id = Guid.NewGuid(), Tax = 15, Speed = 20 },
            new Tariff() { Id = Guid.NewGuid(), Tax = 20, Speed = 30 },
            new Tariff() { Id = Guid.NewGuid(), Tax = 35, Speed = 60 }
        };

            DataGenerator.tarifs = tariffs;
            DataGenerator.BogusData();
            Customers = new(DataGenerator.customers);
        }
        public void Add(Customer entity)
        {
            throw new NotImplementedException();
        }

        public Customer? Get(Func<Customer, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public IList<Customer>? GetList(Func<Customer, bool>? predicate = null)
        {
            throw new NotImplementedException();
        }

        public void Remove(Customer entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Customer entity)
        {
            throw new NotImplementedException();
        }
    }
}
