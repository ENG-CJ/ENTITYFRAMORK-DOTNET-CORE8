using System.ComponentModel.DataAnnotations;

namespace LibraryManagementSystem.Models
{
    public class Author
    {

             [Key]
            public int Id { get; set; }

                [Required]
            public string Name { get; set; }              

        
    }
}
