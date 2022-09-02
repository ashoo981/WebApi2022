using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.Data.Entities
{
    [Table("customeradresses")]
    public class CustomerAdress
    {
        [Key]
        public Guid id { get; set; } = Guid.NewGuid();
        public Guid customerid { get; set; }
        public string adresstitle { get; set; }
        public Guid? cityid { get; set; }
        public Guid? countryid { get; set; }
        public string address { get; set; }

        [ForeignKey("customerid")]
        public virtual Customer  CustomerAdressData { get; set; }

        public DateTime? createat { get; set; }
        public string updateuserid { get; set; }
        public DateTime? updateat { get; set; }
        public Boolean status { get; set; } = true;
    }
}
