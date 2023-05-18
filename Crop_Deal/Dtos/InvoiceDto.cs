namespace Crop_Deal.Dtos
{
    public class InvoiceDto
    {
        public int Crop_Quantity { get; set; }
        public double Crop_Price { get; set; }

        public string Payment_Mode { get; set; } = string.Empty;


        public string Status { get; set; } = "Pending";

    }
}
