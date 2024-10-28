using System.ComponentModel.DataAnnotations;

namespace LibraryManagementSystem.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }                
        public string Title { get; set; }          
        public int AuthorId { get; set; }           
        public string Genre { get; set; }          
        public int PublishedYear { get; set; }
    }
}
