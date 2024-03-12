using System.ComponentModel.DataAnnotations;

namespace JamesThewWebMVC.Models
{
    public class RecipeModel
    {
        public int? RecipeId { get; set; }
        public string Title { get; set; }
        public string? Details { get; set; }
        public string Ingredients { get; set; }
        public DateTime? DatePosted { get; set; }
        public bool? Status { get; set; }
        public string? Type { get; set; }
        public int? ContestId { get; set; }
    }
}
