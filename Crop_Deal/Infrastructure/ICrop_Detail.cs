using Crop_Deal.Models;

namespace Crop_Deal.Infrastructure
{
    public interface ICrop_Detail
    {
        Task<Crop_Details> CreateCrop(Crop_Details user);
        Task<IEnumerable<Crop_Details>> GetCrop_details();
        Task<Crop_Details> GetCrop_detail(int id);
        Task<Crop_Details> UpdateCrop_detail(int id, Crop_Details user);
        Task<Crop_Details> DeleteCrop_detail(int id);
    }
}
