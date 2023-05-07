using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Crop_Deal.Models
{
    public class Crops
    {
        public Crops() 
        {

        }


        [Key]
        [Required]
        public int Crop_Id { get; set; }


        //[ForeignKey("User")]
        public int User_Id { get; set; }

        [Required]
        public string? Crop_name { get; set; }

        [Required]
        public string? Crop_img { get; set; }


        /*  [JsonIgnore]*/
        /*       [ForeignKey("Crop_Detail")]
        */
        //public int Crop_detailid { get; set; }
        //[JsonIgnore]
        //public Crop_detail Crop_Detail { get; set; }

        
        //[JsonIgnore]
        //public User User { get; set; }
    }
}
