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
    public class CustomerAdressService

    {
        private readonly CrmdbDBContext _dbContext;


        public CustomerAdressService(CrmdbDBContext crmdbDBContext)
        {
            _dbContext = crmdbDBContext;
        }

        public async Task<List<CustomerAdress>> GetCusAdresList()
        {
            var list = await _dbContext.CustomerAdresses.ToListAsync();
            return list;

        }

        public async Task AddCustomerAdress(CustomerAdress customeradress)
        {
            _dbContext.CustomerAdresses.Add(customeradress);
            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdateCustomerAdress(CustomerAdress customeradress)
        {
            _dbContext.CustomerAdresses.Update(customeradress);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteCustomerAdress(CustomerAdress customeradress)
        {
            _dbContext.CustomerAdresses.Remove(customeradress);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<CustomerAdress> CustomerAdressGetById(string id)
        {
            var record = await _dbContext.CustomerAdresses.Include(i => i.CustomerAdressData).Where(x => x.id.ToString() == id).FirstOrDefaultAsync();
            return record;

        }
    }
}
