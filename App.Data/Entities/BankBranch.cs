using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.Data.Entities
{
    [Table("bankbranchs")]
    public class BankBranch
    {
        [Key]
        public Guid id { get; set; } = Guid.NewGuid();
        public Guid bankid { get; set; }
        [ForeignKey("bankid")]
        public virtual Bank BankData { get; set; }
        public string name { get; set; }

        public string cretauserid { get; set; }
        public DateTime? createat { get; set; }
        public string updateuserid { get; set; }
        public DateTime? updateat { get; set; }
        public Boolean status { get; set; } = true;
    }
}
