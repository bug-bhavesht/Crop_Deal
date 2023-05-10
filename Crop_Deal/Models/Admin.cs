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

        [Required(ErrorMessage = "Please enter the name")]
        public string? Admin_Name { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string? Admin_Password { get; set; }

        [Required(ErrorMessage = "Please enter your email id")]
        [DataType(DataType.EmailAddress)]
        public string? Admin_Email { get; set; }

        [Required(ErrorMessage = "Please enter contact number")]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Contact Number")]
        public string? Admin_Contact { get; set; }
    }
}
