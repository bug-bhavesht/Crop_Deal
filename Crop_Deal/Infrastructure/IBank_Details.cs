using Crop_Deal.Models;

namespace Crop_Deal.Infrastructure
{
    public interface IBank_Details
    {
        Task<List<Bank_Details>> Get_Bank_Details();

        Task<Bank_Details> Create_BankAcc(Bank_Details bank_detail);

        Task<Bank_Details> Update_BankAcc(int id, Bank_Details bank_detail);

        Task<Bank_Details?> Delete_BankAcc(int id);
    }
}
