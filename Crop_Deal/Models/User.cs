using System.ComponentModel.DataAnnotations;

namespace Crop_Deal.Models
{
    public class User
    {
        public User()
        {

        }
        [Key]
        public int User_id { get; set; }


        [Required(ErrorMessage = "Please enter your name")]
        public string? User_Name { get; set; }


        [Required(ErrorMessage = "Please enter contact number")]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Contact Number")]
        public string? User_Contact { get; set; }


        public string? User_Role { get; set; } = string.Empty;


        [Required(ErrorMessage = "Please enter your email id")]
        [DataType(DataType.EmailAddress)]
        public string? User_EmailId { get; set; }


        [Required]
        public string? User_Password { get; set; }


        [Required(ErrorMessage = "Please enter your Address")]
        public string? User_Address { get; set; }


        public bool Is_Subscribed { get; set; } = false;

        public bool Is_Active { get; set; } = false;






        //public List<Crop> Crops { get; set; }
        //public List<Invoice> Invoices { get; set; }
    }
}
