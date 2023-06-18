using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Reflection.Metadata.Ecma335;

namespace MovieReviewsMVC.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        public string? Genre { get; set; }

        [Range(1, 300)]
        public int? RunTime { get; set; }

        public string? ParentalRating { get; set; }

        public string? Director { get; set; }

        public virtual List<Review> Reviews { get; set; } = new List<Review>();
    }
}
