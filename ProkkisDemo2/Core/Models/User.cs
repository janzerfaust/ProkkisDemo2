using System.ComponentModel.DataAnnotations;

namespace ProkkisDemo2.Core.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MinLength(4)]
        [MaxLength(22)]
        public string UserName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
