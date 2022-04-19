using LCWaikiki_Bootcamp_Week_2_Homework.DBOperations.Commands.Bases.BaseDelete;
using LCWaikiki_Bootcamp_Week_2_Homework.DTOs;
using LCWaikiki_Bootcamp_Week_2_Homework.Repositories.BaseRepository;

namespace LCWaikiki_Bootcamp_Week_2_Homework.DBOperations.Commands.Foods.FoodDelete
{
    public class FoodDeleteCommandHandler : BaseDeleteCommandHandler<FoodDto>
    {
        public FoodDeleteCommandHandler(IBaseRepository<FoodDto> baseRepository) : base(baseRepository) { }
    }
}
