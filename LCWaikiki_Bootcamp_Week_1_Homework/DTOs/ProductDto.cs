using LCWaikiki_Bootcamp_Week_1_Homework.Models;

namespace LCWaikiki_Bootcamp_Week_1_Homework.DTOs
{
    public class ProductDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Stock { get; set; }
        public string Category { get; set; }
        public string Color { get; set; }
        public decimal Price { get; set; }
    }
}