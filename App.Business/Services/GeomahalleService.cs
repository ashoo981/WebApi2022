using App.Data.DBContext;
using App.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Business.Services
{
    public class GeomahalleService
    {
        private readonly AbbgisDBContext _dBContext;

        public GeomahalleService(AbbgisDBContext abbgisDBContext)
        {
            _dBContext = abbgisDBContext;
        }
        public List<Geomahalle> GetList()
        {
            var list = _dBContext.Geomahalles.ToList();
            return list;
        }

       
    }
}
