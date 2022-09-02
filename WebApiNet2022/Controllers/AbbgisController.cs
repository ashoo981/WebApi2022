using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.Data.DBContext;
using Microsoft.Extensions.Logging;
using App.Business.Services;

namespace App.WebApi.Controllers
{
   
    [ApiController]
    [Route("[controller]/[action]")]
    public class AbbgisController : ControllerBase
    {
        private readonly ILogger<AbbgisController> _logger;
        private readonly GeomahalleService _service;

        public AbbgisController(ILogger<AbbgisController> logger, GeomahalleService service)
        {
            _logger = logger;
            _service = service;
        }

        [HttpGet]

        public IActionResult MahalleGetir()
        {
            var list = _service.GetList();
            return Ok(list);
        }


    }
}
