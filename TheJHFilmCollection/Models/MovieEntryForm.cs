using System.ComponentModel.DataAnnotations;

namespace TheJHFilmCollection.Models
{
    public class MovieEntryForm
    {
        //MovieID
        [Key]
        [Required]
        public int MovieID { get; set; }

        //CategoryID
        public int? CategoryId { get; set; }

        //Title
        [Required]
        public string Title { get; set; }

        //Year
        [Required]
        public int Year { get; set; }

        //Director
        public string? Director { get; set; }

        //Rating
        public string? Rating { get; set; }

        //Edited
        [Required]
        public bool Edited { get; set; }

        //LentTo
        public string? LentTo { get; set; }

        //CopiedtoPlex
        [Required]
        public bool CopiedtoPlex { get; set; }

        //Notes
        [MaxLength(25)]
        public string? Notes { get; set; }
        
    }
}
