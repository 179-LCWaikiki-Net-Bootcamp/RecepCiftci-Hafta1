using LCWaikiki_Bootcamp_Week_2_Homework.DBOperations.Commands.Bases.BaseInsert;
using LCWaikiki_Bootcamp_Week_2_Homework.DTOs;
using LCWaikiki_Bootcamp_Week_2_Homework.Repositories.BaseRepository;

namespace LCWaikiki_Bootcamp_Week_2_Homework.DBOperations.Commands.Foods.FoodInsert
{
    public class FoodInsertCommandHandler : BaseInsertCommandHandler<FoodDto>
    {
        public FoodInsertCommandHandler(IBaseRepository<FoodDto> baseRepository) : base(baseRepository) { }
    }
}
