using System.ComponentModel.DataAnnotations;

namespace Portfolio_Project.Models
{
    public class Form
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        [Required]
        [StringLength(500, ErrorMessage = "Message must be at most 500 characters.")]
        public string Message { get; set; } = string.Empty;
    }
}
