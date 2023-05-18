using Crop_Deal.Models;

namespace Crop_Deal.Infrastructure
{
    public interface ICrops
    {
        Task<Crops> CreateCrop(Crops crop);
        Task<IEnumerable<Crops>> GetCrops();
        Task<Crops> GetCrop(int id);
        Task<Crops> UpdateCrop(int id, Crops crop);
        Task<Crops> DeleteCrop(int id);

    }
}
