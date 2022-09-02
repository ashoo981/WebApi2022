using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Data.DBContext;
using App.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace App.Business.Services
{
   public class CustomerService
    {
        private readonly CrmdbDBContext _dbContext;


        public CustomerService(CrmdbDBContext crmdbDBContext)
        {
            _dbContext = crmdbDBContext;
        }

        public async Task<List<Customer>> GetCusList()
        {
            var list = await _dbContext.Customers.ToListAsync();
            return list;
        
        }

        public async Task AddCustomer(Customer customer)
        {
            _dbContext.Customers.Add(customer);
            _dbContext.SaveChanges();
        }

        public async Task UpdateCustomer(Customer customer)
        {
            _dbContext.Customers.Update(customer);
            await _dbContext.SaveChangesAsync();

        }

        public async Task DeleteCustomer(Customer customer)
        {
            _dbContext.Customers.Remove(customer);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<Customer> CustomerGetById(string id)
        {
            var record = await _dbContext.Customers.Where(x => x.id.ToString() == id).FirstOrDefaultAsync();
            return record;
        }
    }
}
