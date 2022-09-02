using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace App.Data.Entities
{
    [Table("bankaccounts")]
    public class BankAccount
    {
        [Key]
        public Guid id { get; set; } = Guid.NewGuid();
        public string customerid { get; set; }
        public string businessid { get; set; }
        public string currencyunitid { get; set; }
        public Guid bankbranchid { get; set; }

        [ForeignKey("bankbranchid")]
        public virtual BankBranch BankBranchData { get; set; }

        public string iban { get; set; }
        public string accountnumber { get; set; }
        public string cretauserid { get; set; }
        public DateTime? createat { get; set; }
        public string updateuserid { get; set; }
        public DateTime? updateat { get; set; }
        public Boolean status { get; set; } = true;
    }
}
