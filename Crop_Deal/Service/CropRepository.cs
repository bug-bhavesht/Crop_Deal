using Crop_Deal.Context;
using Crop_Deal.Infrastructure;
using Crop_Deal.Models;
using Microsoft.EntityFrameworkCore;

namespace Crop_Deal.Service
{
    public class CropRepository : ICrops
    {
        private readonly CD_DbContext context;

        public CropRepository(CD_DbContext context)
        {
            this.context = context;
        }

        public async Task<Crops> CreateCrop(Crops user)
        {
            await context.Crop.AddAsync(user);
            await context.SaveChangesAsync();
            return user;
        }

        public async Task<Crops> DeleteCrop(int id)
        {
            var user = await context.Crop.FindAsync(id);
            if (user == null)
            {
                return null;
            }
            context.Crop.Remove(user);
            await context.SaveChangesAsync();
            return user;
        }

        public async Task<Crops> GetCrop(int id)
        {
            var user = await context.Crop.FindAsync(id);
            if (user == null)
            {
                return null;
            }
            return user;
        }

        public async Task<IEnumerable<Crops>> GetCrops()
        {
            return await context.Crop.ToListAsync();
        }

        public async Task<Crops> UpdateCrop(int id, Crops user)
        {
            var u = await context.Crop.FindAsync(id);
            if (u == null)
            {
                return null;
            }
            u.Crop_Id = id;
            u.Crop_name = user.Crop_name;
            u.Crop_img = user.Crop_img;


            await context.SaveChangesAsync();

            return u;
        }
    }
}
