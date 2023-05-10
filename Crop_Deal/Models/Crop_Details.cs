using System.ComponentModel.DataAnnotations;

namespace Crop_Deal.Models
{
    public class Crop_Details
    {
        public Crop_Details() 
        {
            
        }

        [Key]
        [Required]
        public int CropDetail_Id{ get; set; }


        [Required]
        public string? Crop_Name { get; set; }


        [Required]
        public string? CropDetail_Description { get; set; }


        [Required]
        public string? Crop_Type { get; set; }


        [Required]
        public int Crop_Quantity { get; set; }


        [Required]
        public int Crop_Price { get; set; }


        [Required]
        public string? Crop_Location { get; set; }


    }
}
