using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FarmManagement.Services.WorkerService;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FarmManagement.Controllers
{
    [Route("api/[controller]")]
    public class WorkerController : Controller
    {
        private readonly IWorkerService _workerService;
        public WorkerController(IWorkerService workerService)
        {
            _workerService = workerService;
        }

        // POST api/values
        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<Worker>>>> GetWorkers()
        {

            var result = await _workerService.GetWorkers();
            return Ok(result);
        }

        // POST api/values
        [HttpPost]
        public async Task<ActionResult<ServiceResponse<List<Worker>>>> SaveWorker(Worker worker)
        {

            var result = await _workerService.SaveWorker(worker);
            return Ok(result);
        }

    }
}

