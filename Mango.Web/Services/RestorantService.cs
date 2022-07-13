using Mango.Web.Models;
using Mango.Web.Services.IServices;

namespace Mango.Web.Services
{
    public class RestorantService : BaseService, IRestorantService
    {

        private readonly IHttpClientFactory _clientFactory;

        public RestorantService(IHttpClientFactory clientFactory) : base(clientFactory)
        {
            _clientFactory = clientFactory;
        }

        public Task<T> CreateRestorantAsync<T>(RestorantDto restorantDto, string token)
        {
            throw new NotImplementedException();
        }

        public Task<T> DeleteRestorantAsync<T>(int id, string token)
        {
            throw new NotImplementedException();
        }

        public Task<T> GetRestorantByIdAsync<T>(int id, string token)
        {
            throw new NotImplementedException();
        }

        public async Task<T> GetRestorantsAsync<T>(string token)
        {
            return await this.SendAsync<T>(new ApiRequest()
            {
                ApiType = SD.ApiType.GET,
                Url = SD.RestorantAPIBase + "/api/restorants",
                AccessToken = token
            });
        }

        public Task<T> UpdateRestorantAsync<T>(RestorantDto restorantDto, string token)
        {
            throw new NotImplementedException();
        }
    }
}
