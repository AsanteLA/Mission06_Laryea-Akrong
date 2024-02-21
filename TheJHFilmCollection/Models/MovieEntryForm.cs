using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TheJHFilmCollection.Models
{
    public class MovieEntryForm
    {
        //MovieID
        [Key]
        [Required]
        public int MovieID { get; set; }

        //CategoryID
        [ForeignKey("CategoryId")]
        public int? CategoryId { get; set; }

        public Category? Category { get; set; }

        //Title
        [Required]
        public string Title { get; set; }

        //Year
        [Required]
        [Range(/*minValue*/ 1888, int.MaxValue, ErrorMessage = "Year must be greater than or equal to 1888")]
        public int Year { get; set; }

        //Director
        public string? Director { get; set; }

        //Rating
        public string? Rating { get; set; }

        //Edited
        [Required(ErrorMessage = "Please indicate whether edited or not.")]
        public bool Edited { get; set; }

        //LentTo
        public string? LentTo { get; set; }

        //CopiedtoPlex
        [Required(ErrorMessage ="Please indicate whether movie is copied to Plex or not")]
        public bool CopiedtoPlex { get; set; }

        //Notes
        [MaxLength(25)]
        public string? Notes { get; set; }
        
    }
}
