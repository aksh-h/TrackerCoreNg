using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RevenueTracker.Data;
using RevenueTracker.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RevenueTracker.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MasterController : ControllerBase
    {
        private ICountry _repo;

        public MasterController(ICountry country)
        {
            _repo = country;
        }
        [HttpGet("countries")]
        public async Task<IActionResult> GetAllCountry()
        {
            return Ok(await _repo.GetAllCountry());
        }
    }
}
