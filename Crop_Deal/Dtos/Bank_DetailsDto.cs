using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Crop_Deal.Dtos
{
    public class Bank_DetailsDto
    {
        [ForeignKey("User")]
        public int User_id { get; set; }

        [Required(ErrorMessage = "Please enter your Bank Name")]
        public string? Bank_Name { get; set; }


        [Required(ErrorMessage = "Please enter your Bank Account number")]
        public string? Bank_Acc_No { get; set; }


        [Required(ErrorMessage = "Please enter the IFSC code")]
        public string? Bank_IFSC { get; set; }
    }
}
