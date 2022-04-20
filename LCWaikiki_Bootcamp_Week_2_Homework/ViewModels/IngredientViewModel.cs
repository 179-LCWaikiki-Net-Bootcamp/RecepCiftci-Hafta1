using System.Text.Json.Serialization;

namespace LCWaikiki_Bootcamp_Week_2_Homework.ViewModels
{
    public class IngredientViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        [JsonIgnore]
        public ICollection<FoodViewModel> Foods { get; set; }
    }
}
