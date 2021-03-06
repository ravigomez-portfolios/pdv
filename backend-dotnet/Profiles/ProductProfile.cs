using AutoMapper;
using POS.Backend.DTOs;
using POS.Backend.Models;

namespace POS.Backend.Profiles
{
    public class ProductsProfile : Profile
    {
        public ProductsProfile()
        {
            //Source -> Target
            CreateMap<Product, ProductViewDataDTO>();
            CreateMap<ProductInsertDTO, Product>();
            CreateMap<ProductUpdateDTO, Product>();
            CreateMap<Product, ProductUpdateDTO>();
        }

    }
    
}