using System.ComponentModel.DataAnnotations.Schema;

namespace LCWaikiki_Bootcamp_Week_1_Homework.Models
{
    public class Product
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Stock { get; set; }
        public int CategoryId { get; set; }
        public string Color { get; set; }
        public decimal Price { get; set; }
    }
}
