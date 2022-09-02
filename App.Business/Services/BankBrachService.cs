using App.Data.DBContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using App.Data.Entities;


namespace App.Business.Services
{
    public class BankBrachService
    {
        private readonly CrmdbDBContext _dbContext;

        public BankBrachService(CrmdbDBContext crmdbDBContext)
        {
            _dbContext = crmdbDBContext;
        }

        public async Task<List<BankBranch>> GetList()

        {
            var list = await _dbContext.BankBranchs.Include(i => i.BankData).ToListAsync();
            return list;


        }
        public async Task AddBankBranch(BankBranch bankbranch)
        {
            _dbContext.BankBranchs.Add(bankbranch);
            await _dbContext.SaveChangesAsync();

        }

        public async Task UpdateBankBranch(BankBranch bankbranch)
        {
            _dbContext.BankBranchs.Update(bankbranch);
            await _dbContext.SaveChangesAsync();

        }

        public async Task DeleteBankBranch(BankBranch bankbranch)
        {
            _dbContext.BankBranchs.Remove(bankbranch);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<BankBranch> BankBranchGetById(string id)
        {
            var record = await _dbContext.BankBranchs.Include(i => i.BankData).Where(x => x.id.ToString() == id).FirstOrDefaultAsync();
            return record;

        }
    }
}
