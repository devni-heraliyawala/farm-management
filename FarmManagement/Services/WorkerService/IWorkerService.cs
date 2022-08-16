using System;

namespace FarmManagement.Services.WorkerService
{
    public interface IWorkerService
    {
        Task<ServiceResponse<List<Worker>>> GetWorkers();

        Task<ServiceResponse<List<Worker>>> SaveWorker(Worker worker);
    }
}

