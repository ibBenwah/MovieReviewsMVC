using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieReviewsMVC.Models
{
    public class Review
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey(nameof(Movie))]
        [Required]
        public int MovieId { get; set; }

        public virtual Movie? Movie { get; set; }

        [Required]
        public string ReviewerName { get; set; }

        [Required]
        [Range(1,100)]
        public int Rating { get; set; }

        public string? ReviewContent { get; set; }

        public DateTime CreatedTimestamp { get; set; } = DateTime.Now;
    }
}
