using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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

        [ForeignKey("User")]
        public int User_id { get; set; }

        [ForeignKey("Crop_Details")]
        public int CropDetail_Id { get; set; }

        [Required]
        public int Crop_Quantity { get; set; }

        [Required]
        public double Crop_Price { get; set;}

        [Required]
        public string? Payment_Mode { get; set; } = string.Empty;

        [Required]
        public string? Status { get; set; } = string.Empty;

        [Required]
        public DateTime Date_created { get; set; }


        [JsonIgnore]
        public User? User { get; set; }

        [JsonIgnore]
        public Crop_Details? Crop_Details { get; set; }
    }
}
