using System;

namespace FarmManagement.Services.FarmService
{
    public class FarmService:IFarmService
    {
        private readonly DataContext _context;

        public FarmService(DataContext context)
        {
            _context = context;
        }

        public async Task<ServiceResponse<Farm>> GetFarmById(int farmId)
        {
            var response = new ServiceResponse<Farm>();
            var farm = await _context.Farms
                .Include(f=>f.Workers)
                .FirstOrDefaultAsync(f => f.Id == farmId);

            if (farm is null)
            {
                response.Success = false;
                response.Message = "Sorry, but this farm does not exists";
            }
            else
            {
                response.Data = farm;
            }

            return response;
        }

        public async Task<ServiceResponse<List<Farm>>> GetFarms()
        {
            var result = await _context.Farms
                .Include(f=>f.Workers)
                .ToListAsync();

            var response = new ServiceResponse<List<Farm>>
            {
                Data = result
            };
            return response;
        }

        public async Task<ServiceResponse<List<Farm>>> SaveFarm(Farm farm)
        {
            var saved = await _context.Farms.AddAsync(farm);
            await _context.SaveChangesAsync();

            var result = await _context.Farms
                .Include(f=>f.Workers)
                .ToListAsync();

            var response = new ServiceResponse<List<Farm>>
            {
                Data = result
            };
            return response;

        }
    }
}

