using Crop_Deal.Context;
using Crop_Deal.Infrastructure;
using Crop_Deal.Models;
using Microsoft.EntityFrameworkCore;

namespace Crop_Deal.Service
{
    public class Bank_DetailsRepository : IBank_Details
    {
        private readonly CD_DbContext context;
        public Bank_DetailsRepository(CD_DbContext context)
        {
            this.context = context;
        }

        public async Task<List<Bank_Details>> Get_Bank_Details()
        {
            return await context.Bank.ToListAsync();
        }

        public async Task<Bank_Details> Create_BankAcc(Bank_Details bank_detail)
        {
            context.Bank.Add(bank_detail);
            await context.SaveChangesAsync();
            return bank_detail;
        }

        public async Task<Bank_Details> Update_BankAcc(int id, Bank_Details bank_detail)
        {
            context.Entry(bank_detail).State = EntityState.Modified;
            await context.SaveChangesAsync();
            return bank_detail;
        }

        public async Task<Bank_Details?> Delete_BankAcc(int id)
        {
            var BankInfo = await context.Bank.FindAsync(id);
            if (BankInfo == null)
            {
                return null;
            }
            context.Bank.Remove(BankInfo);
            await context.SaveChangesAsync();
            return BankInfo;
        }
    }
}
