using AutoMapper;
using LCWaikiki_Bootcamp_Week_2_Homework.DTOs;
using LCWaikiki_Bootcamp_Week_2_Homework.Models;

namespace LCWaikiki_Bootcamp_Week_2_Homework.Mappers
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            CreateMap<Food, FoodDto>().ReverseMap();
            CreateMap<Ingredient, IngredientDto>().ReverseMap();
        }
    }
}
