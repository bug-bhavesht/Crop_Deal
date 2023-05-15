using System.ComponentModel.DataAnnotations;

namespace Crop_Deal.Dtos
{
    public class UserSignUpDto
    {
        // We need to solve three problems if we need to change our entities in future without knowing to the client.
        // All these three problems can be solved by adding a service layer around our domain entities

        // This layer will expose different sets of classes which look similar to our domain entities but those can be
        // changed & evolved independently. These classes are called 'dto'
        // Our controller will take 'dto' as input & return 'dto' as output.

        // So 'DTOs' are the public interface to the domain entities and changes in the domain entities do not impact the client 
        // until and unless our service layer is modified.


        [Required(ErrorMessage = "Please enter your name")]
        public string? User_Name { get; set; }

        [Required]
        public string? User_Password { get; set; }

        [Required(ErrorMessage = "Please enter contact number")]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Contact Number")]
        public string? User_Contact { get; set; }

        [Required(ErrorMessage = "Please enter your email id")]
        [DataType(DataType.EmailAddress)]
        public string? User_EmailId { get; set; }

        [Required(ErrorMessage = "Please enter your Address")]
        public string? User_Address { get; set; }

        [Required]
        public string? User_Role { get; set; } = string.Empty;

        public bool Is_Subscribed { get; set; } = false;
    }
}
