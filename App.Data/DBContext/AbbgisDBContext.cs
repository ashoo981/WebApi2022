using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
//using Npgsql.EntityFrameworkCore.PostgreSQL;
using App.Data.Entities;

namespace App.Data.DBContext
{
    public class AbbgisDBContext : DbContext
    {
        public AbbgisDBContext(DbContextOptions<AbbgisDBContext> options) : base(options)
        { 
        
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        { 
        
        }

        public DbSet<Geomahalle> Geomahalles { get; set; }
    }
}
