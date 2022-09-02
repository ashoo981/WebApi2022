using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.Data.DBContext;
using App.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace App.Business.Services
{

    public class BankAccountService

    {
        private readonly CrmdbDBContext _dBContext;

        public BankAccountService(CrmdbDBContext crmdbDBContext)

        {
            _dBContext = crmdbDBContext;

        }

        public async Task<List<BankAccount>> GetList()
        {
            var list = await _dBContext.BankAccounts.Include(i => i.BankBranchData).ThenInclude(bb => bb.BankData).ToListAsync();
            return list;

        }

        public async Task AddBankAccount(BankAccount bankaccount)
        {
            _dBContext.BankAccounts.Add(bankaccount);
            _dBContext.SaveChanges();

        }

        public async Task UpdateBankAccount(BankAccount bankaccount)
        {
            _dBContext.BankAccounts.Update(bankaccount);
            _dBContext.SaveChanges();


        }

        public async Task DeleteBankAccount(BankAccount bankaccount)
        {
            _dBContext.BankAccounts.Remove(bankaccount);
            _dBContext.SaveChanges();

        }

        public async Task<BankAccount> BankAccountGetById(string id)
        {
            var record = await _dBContext.BankAccounts.Include(i => i.BankBranchData).Where(x => x.id.ToString() == id).FirstOrDefaultAsync();
            return record;

        }


        public async Task<BankAccount> BaGetByeId(string id)
        {

            var record = await _dBContext.BankAccounts.Where(x => x.id.ToString() == id).FirstOrDefaultAsync();
            return null;

        }



    }
}
