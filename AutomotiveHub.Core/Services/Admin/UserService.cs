using AutomotiveHub.Core.Contracts.Admin;
using AutomotiveHub.Core.Models.Admin;
using AutomotiveHub.Infrastructure.Data.Models;
using AutomotiveHub.Infrastructure.Data.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotiveHub.Core.Services.Admin
{
    public class UserService : IUserService
    {
        private readonly IRepository repository;

        public UserService(IRepository _repository)
        {
            repository = _repository;
        }


        public async Task<string> UserFullNameAsync(string userId)
        {
            var user = await repository.GetByIdAsync<ApplicationUser>(userId);

            return user.FirstName + " " + user.LastName;
        }

        public async Task<IEnumerable<UserServiceModel>> GetAllAsync()
        {
            List<UserServiceModel> result;

            result = await repository.AllReadOnly<Dealer>()
                .Where(r => r.User.IsActive)
                .Select(r => new UserServiceModel()
                {
                    UserId = r.UserId,
                    FullName = r.User.FirstName + " " + r.User.LastName,
                    Email = r.User.Email,
                    PhoneNumber = r.PhoneNumber
                })
                .ToListAsync();

            string [] dealerIds=result
                .Select(d =>d.UserId)
                .ToArray();

            result.AddRange(await repository.AllReadOnly<ApplicationUser>()
                .Where(r => r.IsActive)
                .Where(d => dealerIds.Contains(d.Id) == false)
                .Select(r => new UserServiceModel()
                {
                    UserId = r.Id,
                    Email = r.Email,
                    FullName = r.FirstName + " " + r.LastName
                })
                .ToListAsync());

            return result;
        }

        public async Task DeleteUserAsync(string userId)
        {
            var user = await repository.GetByIdAsync<ApplicationUser>(userId);

            if (user !=null)
            {
                user.IsActive = false;

                await repository.SaveChangesAsync();
            }
        }




    }
}
