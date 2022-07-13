using Food.Services.ProductAPI.Models.Dtos;

namespace Food.Services.RestorantAPI1.Repository
{
    public interface IRestorantRepository
    {
        Task<IEnumerable<RestorantDto>> GetRestorants();
        Task<RestorantDto> GetRestorantById(int restorantId);
        Task<RestorantDto> CreateUpdateRestorant(RestorantDto restorantDto);
        Task<bool> DeleteRestorant(int restorantId);


    }
}
