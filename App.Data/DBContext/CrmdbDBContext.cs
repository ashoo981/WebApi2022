using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
//using Npgsql.EntityFrameworkCore.PostgreSQL;
using App.Data.Entities;

namespace App.Data.DBContext
{
    public class CrmdbDBContext : DbContext
    {
        public CrmdbDBContext(DbContextOptions<CrmdbDBContext> options) : base(options)
        { 
        
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        { 
        
        }

        public DbSet<Bank> Banks { get; set; }

        public DbSet<BankBranch> BankBranchs { get; set; }
        public DbSet<BankAccount> BankAccounts { get; set; }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<CustomerAdress> CustomerAdresses { get; set; }


    }
}
