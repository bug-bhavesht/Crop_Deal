using Crop_Deal.Dtos;
using Crop_Deal.Infrastructure;
using Crop_Deal.Models;
using Microsoft.AspNetCore.Mvc;

namespace Crop_Deal.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class BankDetailsController : Controller
    {
        private readonly IBank_Details repo; 
        public BankDetailsController(IBank_Details repo)
        {
            this.repo = repo;
        }

        [HttpGet]
        public async Task<ActionResult<Bank_Details>> GetAll()
        {
            var bank = await repo.Get_Bank_Details();
            if (bank == null)
            {
                return BadRequest();
            }

            var UserBankList = new List<Bank_DetailsDto>();

            foreach (var i in bank)
            {
                UserBankList.Add(new Bank_DetailsDto()
                {
                    Bank_Name = i.Bank_Name,
                    Bank_Acc_No = i.Bank_Acc_No,
                    Bank_IFSC = i.Bank_IFSC
                });
            }
            return Ok(UserBankList);
        }

        [HttpPost]
        public async Task<ActionResult<Bank_Details>> PostBank(Bank_DetailsDto bank)
        {
            if (bank == null)
            {
                return NotFound();
            }

            var userBank = new Bank_Details()
            {
                User_id = bank.User_id,
                Bank_Name = bank.Bank_Name,
                Bank_Acc_No = bank.Bank_Acc_No,
                Bank_IFSC = bank.Bank_IFSC
            };
            userBank = await repo.Create_BankAcc(userBank);
            return Ok();
        }

        [HttpPut]
        public async Task<ActionResult<Bank_Details>> UpdateBank(int id, Bank_Details bank_Detail)
        {
            if(id != bank_Detail.Bank_DetailId)
            {
                return BadRequest();
            }
            var Update_Bank = await repo.Update_BankAcc(id, bank_Detail);
            return Ok(Update_Bank);
        }

        [HttpDelete]
        public async Task<ActionResult<Bank_Details>> DeleteBank(int id)
        {
            var Delete_Bank = await repo.Delete_BankAcc(id);
            if(Delete_Bank == null)
            {
                return NotFound();
            }
            return Ok();
        }
    }
}
