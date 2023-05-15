using Crop_Deal.Context;
using Crop_Deal.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Crop_Deal.Models;
using Crop_Deal.Dtos;

namespace Crop_Deal.Controllers
{

    [ApiController]
    [Route("api/[Controller]")]
    public class UserController : Controller
    {
        private readonly IUser repo;
        public UserController(IUser repo) 
        {
            this.repo = repo;
        }

        [HttpGet]
        public async Task<ActionResult<User>> GetAll()
        {
            var user = await repo.GetAllUsers();
            if (user == null)
            {
                return BadRequest();
            }

            // By using this, it will retrieve password also. Hence we need to do mapping.
            // return Ok(user);

            var userList = new List<UserSignUpDto>();

            //Here we are mapping
            foreach (var i in user)
            {
                userList.Add(new UserSignUpDto()
                {
                    User_Name = i.User_Name,
                    User_EmailId = i.User_EmailId,
                    User_Contact = i.User_Contact,
                    User_Address = i.User_Address,
                    User_Role = i.User_Role,
                });
            }
            return Ok(userList);
        }

        [HttpPost]
        public async Task<ActionResult<User>> PostUser(UserSignUpDto userd)
        {
            if (userd == null)
            {
                return BadRequest();
            }
            var user = new User()
            {
                User_Name = userd.User_Name,
                User_Password = userd.User_Password,
                User_EmailId = userd.User_EmailId,
                User_Contact = userd.User_Contact,
                User_Address = userd.User_Address,
                User_Role = userd.User_Role,
                Is_Subscribed = userd.Is_Subscribed
            };

            user = await repo.UserInsert(user);
            return Ok(user);
        }

        [HttpPut]

        public async Task<ActionResult<User>> EditUser(int id, User user)
        {
            if(id != user.User_id)
            {
                return BadRequest();
            }
            
            var Update_Result = await repo.UserUpdate(id, user);
            return Ok(Update_Result);
        }

        [HttpDelete]
        public async Task<ActionResult<User>> DeleteUser(int id)
        {
            var Delete_User = await repo.UserDelete(id);
            if(Delete_User == null)
            {
                return NotFound();
            }
            return Ok(Delete_User);
        }
    }
}
