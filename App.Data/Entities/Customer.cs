using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.Data.Entities
{
    [Table("customers")]
    public class Customer
    {
        [Key]
        public Guid id { get; set; } = Guid.NewGuid();
        public string name { get; set; }
        public string fax { get; set; }
        public string vkn { get; set; }
        public string tkn { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string shortname { get; set; }
        public string taxoffice { get; set; }
        public string secretinfo { get; set; }
        public string customernumber { get; set; }
        public string maturityoption { get; set; }
       

        public DateTime? createat { get; set; }
        public string updateuserid { get; set; }
        public DateTime? updateat { get; set; }
        public Boolean status { get; set; } = true;
    }
}
