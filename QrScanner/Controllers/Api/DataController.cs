using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using QrScanner.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace QrScanner.Controllers.Api
{
    [Route("api/[controller]")]
    public class DataController : Controller
    {
        public DataController()
        {

        }
        // GET: api/values
        [HttpPut("AddQr")]
        public async Task<bool> AddQr(QrData qr)
        {
            var x = 1;
            return true;
        }
    }
}

