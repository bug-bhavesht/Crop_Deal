using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Crop_Deal.Models
{
    public class Bank_Details
    {
        [Key]
        public int Bank_DetailId { get; set; }

        //[ForeignKey("User")]
        public int User_Id { get; set; }


        [Required(ErrorMessage = "Please enter your Bank Name")]
        public string? Bank_Name { get; set; }


        [Required(ErrorMessage = "Please enter your Bank Account number")]
        public string? Bank_Acc_No { get; set; }


        [Required(ErrorMessage = "Please enter the IFSC code")]
        public string? Bank_IFSC { get; set; }
       









        //[JsonIgnore]
        //public User? User { get; set; }
    }
}
