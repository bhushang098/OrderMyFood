using Food.Services.ProductAPI.Models.Dto;
using Food.Services.ProductAPI.Models.Dtos;
using Food.Services.RestorantAPI1.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Food.Services.RestorantAPI1.Controllers
{
    [Route("api/restorants")]
    public class RestorantController : ControllerBase
    {
        protected ResponseDto _response;
        private IRestorantRepository _restorantRepository;

        public RestorantController(IRestorantRepository restorantRepository)
        {
            this._response = new ResponseDto();
            _restorantRepository = restorantRepository;
        }


        [HttpGet]
        public async Task<object> Get()
        {
            try
            {
                IEnumerable<RestorantDto> restorantDtos = await _restorantRepository.GetRestorants();
                _response.Result = restorantDtos;
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages
                     = new List<string>() { ex.ToString() };
            }
            return _response;
        }
    }
}
