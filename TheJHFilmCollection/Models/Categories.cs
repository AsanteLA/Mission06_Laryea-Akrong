using System.ComponentModel.DataAnnotations;

namespace TheJHFilmCollection.Models
{
    public class Categories
    {
        //CategoryId
        [Key]
        public int CategoryId { get; set; }

        //Category
        public string Category {  get; set; }
    }
}
