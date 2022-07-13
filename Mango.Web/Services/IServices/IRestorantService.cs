using Mango.Web.Models;

namespace Mango.Web.Services.IServices
{
    public interface IRestorantService
    {

        Task<T> GetRestorantsAsync<T>(string token);
        Task<T> GetRestorantByIdAsync<T>(int id, string token);
        Task<T> CreateRestorantAsync<T>(RestorantDto restorantDto, string token);
        Task<T> UpdateRestorantAsync<T>(RestorantDto restorantDto, string token);
        Task<T> DeleteRestorantAsync<T>(int id, string token);


    }
}
