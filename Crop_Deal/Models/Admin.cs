using System.ComponentModel.DataAnnotations;

namespace Crop_Deal.Models
{
    public class Admin
    {
        public Admin() 
        {

        }

        [Key]
        public int Admin_Id { get; set; }

        [Required]
        public string? Admin_Name { get; set; }

        [Required]
        public string? Admin_Password { get; set; }

        [Required]
        public string? Admin_Email { get; set; }

        [Required]
        public string? Admin_Contact { get; set; }
    }
}
