using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Data.Entities
{
    [Table("banks")]
    public class Bank
    {

        [Key]
        public Guid id { get; set; } = Guid.NewGuid();
        
        public string name { get; set; }
        public string cretauserid { get; set; }
        public DateTime? createat { get; set; }
        public string updateuserid { get; set; }
        public DateTime? updateat { get; set; }
        public Boolean status { get; set; } = true;





    }
}
