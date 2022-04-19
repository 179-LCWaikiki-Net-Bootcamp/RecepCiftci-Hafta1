namespace LCWaikiki_Bootcamp_Week_2_Homework.Models
{
    public class Food : BaseEntity
    {
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
        public ICollection<Ingredient> Ingredients { get; set; }
    }
}
