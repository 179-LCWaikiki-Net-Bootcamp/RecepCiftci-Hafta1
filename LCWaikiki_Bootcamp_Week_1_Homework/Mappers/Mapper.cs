using AutoMapper;
using LCWaikiki_Bootcamp_Week_1_Homework.DBOperations.Commands.ProductInsert;
using LCWaikiki_Bootcamp_Week_1_Homework.DBOperations.Commands.ProductUpdate;
using LCWaikiki_Bootcamp_Week_1_Homework.DTOs;
using LCWaikiki_Bootcamp_Week_1_Homework.Models;

namespace LCWaikiki_Bootcamp_Week_1_Homework.Mappers
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            CreateMap<Product, ProductDto>()
                .ForMember(dest => dest.Category, opt => opt.MapFrom(src => ((Category)src.CategoryId).ToString())).ReverseMap();

            CreateMap<ProductInsertCommand, Product>().ReverseMap();

            CreateMap<ProductUpdateCommand, Product>().ReverseMap();
        }
    }
}
