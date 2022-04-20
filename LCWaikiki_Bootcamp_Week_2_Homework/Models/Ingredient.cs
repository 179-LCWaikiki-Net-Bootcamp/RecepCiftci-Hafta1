using System.Text.Json.Serialization;

namespace LCWaikiki_Bootcamp_Week_2_Homework.Models
{
    public class Ingredient : BaseEntity
    {
        public int CategoryId { get; set; }
        [JsonIgnore]
        public ICollection<Food> Foods { get; set; }
    }
}
