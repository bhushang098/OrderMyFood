using AutoMapper;
using Food.Services.ProductAPI.Models.Dtos;
using Food.Services.RestorantAPI1.Models;
using Food.Services.RestorantAPI1.Models.Dto;
using Mango.Services.ProductAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Food.Services.ProductAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<ProductDto, Product>();
                config.CreateMap<Product, ProductDto>();

                //For restorant 
                config.CreateMap<RestorantDto, Restorant>();
                config.CreateMap<Restorant, RestorantDto>();
            });

            return mappingConfig;
        }
    }
}
