using System;

namespace FarmManagement.Services.WorkerService
{
    public class WorkerService : IWorkerService
    {
        private readonly DataContext _context;

        public WorkerService(DataContext context)
        {
            _context = context;
        }

        public async Task<ServiceResponse<List<Worker>>> GetWorkers()
        {
            var workers = await
                _context.Workers.ToListAsync();

            var response = new ServiceResponse<List<Worker>>
            {
                Data = workers
            };

            return response;
        }

        public async Task<ServiceResponse<List<Worker>>> SaveWorker(Worker worker)
        {
            var saved = await _context.Workers.AddAsync(worker);
            await _context.SaveChangesAsync();

            var result = await _context.Workers.ToListAsync();
            var response = new ServiceResponse<List<Worker>>
            {
                Data = result
            };
            return response;
        }
    }
}

