using AutomotiveHub.Core.Contracts;
using AutomotiveHub.Core.Models.Dealer;
using AutomotiveHub.Infrastructure.Data.Models;
using AutomotiveHub.Infrastructure.Data.Repository;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotiveHub.Core.Services
{
    public class DealerService : IDealerService
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly IRepository repository;

        public DealerService(IRepository _repository,UserManager<ApplicationUser> _userManager)
        {
            repository = _repository;
            userManager = _userManager;
        }



        public async Task CreateAsync(string userId, string phoneNumber, string name)
        {
            var user = await userManager.FindByIdAsync(userId);

            var dealer = new Dealer()
            {
                UserId = userId,
                PhoneNumber = phoneNumber,
                Name = name,
            };

            await repository.AddAsync(dealer);

            await repository.SaveChangesAsync();
        }

        public async Task<bool> ExistsByIdAsync(string userId)
        {
            return await repository.AllReadOnly<Dealer>()
                .AnyAsync(d => d.UserId == userId);
        }



        public async Task<int> GetDealerId(string userId)
        {
            return (await repository.AllReadOnly<Dealer>()
                .FirstOrDefaultAsync(d => d.UserId == userId))?.Id ?? 0;
        }

        public async Task<bool> HasDealerPhoneNumber(string phoneNumber)
        {
            return await repository.AllReadOnly<Dealer>()
                .AnyAsync(d => d.PhoneNumber == phoneNumber);
        }

        public async Task AddDealershipAsync(string userId, AddDealershipServiceModel model)
        {
            var dealer = await repository.AllReadOnly<Dealer>()
                .FirstOrDefaultAsync(d => d.UserId == userId);

            var dealership = new Dealership()
            {
                Name = model.Name,
                Address = model.Address,
                CityId = model.CityId,
                DealerId = dealer?.Id ?? 0
            };

            await repository.AddAsync(dealership);
            await repository.SaveChangesAsync();

        }
        public async Task<IEnumerable<AllCitiesServiceModel>> AllCitiesAsync()
        {
            return await repository.All<City>()
                .OrderBy(c => c.Id)
                .Select(c => new AllCitiesServiceModel()
                {
                    Id = c.Id,
                    Name = c.Name
                })
                .ToListAsync();
        }

        public async Task<bool> CityExistsById(int cityId)
        {
            return await repository.AllReadOnly<City>()
                 .AnyAsync(c => c.Id == cityId);
        }
    }
}
