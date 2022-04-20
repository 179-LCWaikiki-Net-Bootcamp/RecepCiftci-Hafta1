using AutoMapper;
using LCWaikiki_Bootcamp_Week_2_Homework.DBOperations.Commands.Bases.BaseUpdate;
using LCWaikiki_Bootcamp_Week_2_Homework.DTOs;
using LCWaikiki_Bootcamp_Week_2_Homework.Models;
using LCWaikiki_Bootcamp_Week_2_Homework.ViewModels;

namespace LCWaikiki_Bootcamp_Week_2_Homework.Mappers
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            CreateMap<Food, FoodDto>()
                .ReverseMap();

            CreateMap<Food, FoodViewModel>()
                .ReverseMap()
                .ForMember(x => x.Ingredients, opt => opt.MapFrom(o => o.Ingredients));


            CreateMap<Ingredient, IngredientDto>()
                .ReverseMap();

            CreateMap<Ingredient, IngredientViewModel>()
                .ReverseMap()
                .ForMember(x => x.Foods, opt => opt.MapFrom(o => o.Foods));

            CreateMap<BaseUpdateCommand<FoodViewModel>, Food>().ReverseMap();
            CreateMap<BaseUpdateCommand<IngredientViewModel>, Ingredient>().ReverseMap();
        }
    }
}