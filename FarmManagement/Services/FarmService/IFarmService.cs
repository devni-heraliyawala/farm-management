using System;

namespace FarmManagement.Services.FarmService
{
    public interface IFarmService
    {
        Task<ServiceResponse<Farm>> GetFarmById(int farmId);

        Task<ServiceResponse<List<Farm>>> GetFarms();

        Task<ServiceResponse<List<Farm>>> SaveFarm(Farm farm);
    }
}

