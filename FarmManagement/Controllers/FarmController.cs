using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FarmManagement.Services.FarmService;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FarmManagement.Controllers
{
    [Route("api/[controller]")]
    public class FarmController : Controller
    {
        private readonly IFarmService _farmService;

        public FarmController(IFarmService farmService)
        {
            _farmService = farmService;
        }

        // POST api/values
        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<Farm>>>> GetFarms()
        {
            var result = await _farmService.GetFarms();
            return Ok(result);
        }

        // POST api/values
        [HttpGet("{farmId}")]
        public async Task<ActionResult<ServiceResponse<Farm>>> GetFarmById(int farmId)
        {

            var result = await _farmService.GetFarmById(farmId);
            return Ok(result);
        }

        // POST api/values
        [HttpPost]
        public async Task<ActionResult<ServiceResponse<List<Farm>>>> SaveFarm(Farm farm)
        {

            var result = await _farmService.SaveFarm(farm);
            return Ok(result);
        }
    }
}

