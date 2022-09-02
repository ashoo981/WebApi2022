using App.Data.DBContext;
using App.Data.Entities;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

using System.Threading.Tasks;
using System.Linq;

namespace App.Business.Services
{
    public class BanksService
    {
        private readonly CrmdbDBContext _dbContext;

        public BanksService(CrmdbDBContext crmdbDBContext)
        {
            _dbContext = crmdbDBContext;



        }

        public async Task<List<Bank>> GetList()
        {
            var list = await _dbContext.Banks.ToListAsync();
            return list;

        }

        public async Task AddBank(Bank banks)
        {
            _dbContext.Banks.Add(banks);
            await _dbContext.SaveChangesAsync();
        }


        public async Task UpdateBank(Bank banks)
        {
            _dbContext.Banks.Update(banks);
            _dbContext.SaveChanges();


        }


        public async Task DeleteBank(Bank banks)
        {
            _dbContext.Banks.Remove(banks);
            _dbContext.SaveChanges();
        }

        public async Task<Bank> BankGetByID(string id)
        {
            var record = await _dbContext.Banks.Where(x => x.id.ToString() == id).FirstOrDefaultAsync();
            return record;

        }

    }
}
