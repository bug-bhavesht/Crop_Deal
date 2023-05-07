using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Crop_Deal.Models
{
    public class Invoice
    {
        public Invoice()
        {

        }

        [Key]
        public int Invoice_id { get; set; }


        public int CropDetail_id { get; set; }

        [Required]
        public int Crop_Quantity { get; set; }

        [Required]
        public string Payment_Mode { get; set; } = string.Empty;

        [Required]
        public string Status { get; set; } = string.Empty;

        [Required]
        public DateTime Date_created { get; set; }









        /*        [Required]
                //-----------------------------------------------------------------
                public string User_id { get; set; } = string.Empty;*/
        /*        [Required]
                public string CropDetails_id{ get; set; } = string.Empty;*/


        /*   [JsonIgnore]*/
        /*  public User user { get; set; }*/

        //public int Userid { get; set; }
        //[JsonIgnore]
        //public User User { get; set; }


        //[JsonIgnore]
        //public Crop_Details Crop_Detail { get; set; }
    }
}
