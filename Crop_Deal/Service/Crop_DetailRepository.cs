using Crop_Deal.Context;
using Crop_Deal.Infrastructure;
using Crop_Deal.Models;
using Microsoft.EntityFrameworkCore;

namespace Crop_Deal.Service
{
    public class Crop_DetailRepository : ICrop_Detail
    {
        private readonly CD_DbContext context;

        public Crop_DetailRepository(CD_DbContext context)
        {
            this.context = context;
        }

        public async Task<Crop_Details> CreateCrop(Crop_Details user)
        {
            await context.Crop_Detail.AddAsync(user);
            await context.SaveChangesAsync();
            return user;
        }

        public async Task<Crop_Details> DeleteCrop_detail(int id)
        {
            var user = await context.Crop_Detail.FindAsync(id);
            if (user == null)
            {
                return null;
            }
            context.Crop_Detail.Remove(user);
            await context.SaveChangesAsync();
            return user;
        }

        public async Task<Crop_Details> GetCrop_detail(int id)
        {
            var user = await context.Crop_Detail.FindAsync(id);
            if (user == null)
            {
                return null;
            }
            return user;
        }

        public async Task<IEnumerable<Crop_Details>> GetCrop_details()
        {
            return await context.Crop_Detail.ToListAsync();
        }

        public async Task<Crop_Details> UpdateCrop_detail(int id, Crop_Details user)
        {
            var u = await context.Crop_Detail.FindAsync(id);
            if (u == null)
            {
                return null;
            }
            u.CropDetail_Id = id;
            u.Crop_Name = user.Crop_Name;
            u.Crop_Type = user.Crop_Type;
            u.CropDetail_Description = user.CropDetail_Description;
            u.Crop_Quantity = user.Crop_Quantity;
            u.Crop_Price = user.Crop_Price;
            u.Crop_Location = user.Crop_Location;

            await context.SaveChangesAsync();

            return u;
        }

    }
}
