using System;
using Crop_Deal.Context;
using Crop_Deal.Infrastructure;
using Crop_Deal.Models;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Crop_Deal.Service
{
    // Repository patterns works in layer between Business layer and database layer
    // How repository is used in CRUD operation
    // All the below methods works in repository class
    // Through this class we can communicate with the database table.

    public class UserRepository : IUser
    {
        private readonly CD_DbContext context;

        public UserRepository(CD_DbContext context)
        {
            this.context = context;
        }

        public async Task<List<User>> GetAllUsers()
        {
            return await context.Users.ToListAsync();
        }

        public async Task<User> UserDelete(User user)
        {
            context.Users.Remove(user);
            await context.SaveChangesAsync();
            return user;
        }

        public async Task<User> UserInsert(User user)
        {
            context.Users.Add(user);
            await context.SaveChangesAsync();
            return user;
        }

        public async Task<User> UserUpdate(User user)
        {
            context.Entry(user).State = EntityState.Modified;
            await context.SaveChangesAsync();
            return user;
        }
    }
}
