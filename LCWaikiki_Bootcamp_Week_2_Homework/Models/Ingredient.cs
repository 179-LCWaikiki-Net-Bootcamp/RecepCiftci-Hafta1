namespace LCWaikiki_Bootcamp_Week_2_Homework.Models
{
    public class Ingredient : BaseEntity
    {
        public int CategoryId { get; set; }
        public ICollection<Food> Foods { get; set; }
    }
}
