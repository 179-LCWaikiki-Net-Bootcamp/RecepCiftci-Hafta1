namespace LCWaikiki_Bootcamp_Week_2_Homework.DTOs
{
    public class FoodDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public decimal Price { get; set; }
        public ICollection<int> IngredientIds { get; set; }
    }
}