using AutoMapper;
using Food.Services.ProductAPI.DbContexts;
using Food.Services.ProductAPI.Models.Dtos;
using Mango.Services.ProductAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace Food.Services.RestorantAPI1.Repository
{
    public class RestorantRepository : IRestorantRepository
    {

        private readonly ApplicationDbContext _db;
        private IMapper _mapper;

        public RestorantRepository(ApplicationDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public Task<RestorantDto> CreateUpdateRestorant(RestorantDto restorantDto)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteRestorant(int restorantId)
        {
            throw new NotImplementedException();
        }

        public Task<RestorantDto> GetRestorantById(int restorantId)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<RestorantDto>> GetRestorants()
        {
            List<Restorant> restorantList = await _db.Restorants.ToListAsync();
            return _mapper.Map<List<RestorantDto>>(restorantList);
        }
    }
}
