namespace LCWaikiki_Bootcamp_Week_2_Homework.ViewModels
{
    public class FoodViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
        public ICollection<IngredientViewModel> Ingredients { get; set; }
    }
}
