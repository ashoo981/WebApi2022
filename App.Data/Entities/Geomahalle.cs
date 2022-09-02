using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using NetTopologySuite.Geometries;

namespace App.Data.Entities
{
    [Table("geomahalle")]
    public class Geomahalle
    {
        [Key]
        public int objectid { get; set; }
        public bool geo_durum { get; set; }
        public string adi_numarasi { get; set; }

        //public Geometry poly { get; set; }
    }
}
