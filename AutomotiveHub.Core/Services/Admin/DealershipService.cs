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
    public class DealershipService : IDealershipService
    {
        private readonly IRepository repository;

        public DealershipService(IRepository _repository)
        {
            repository = _repository;
        }

        public async Task<IEnumerable<AllDealershipsServiceModel>> AllDealershipsAsync()
        {
            return await repository.All<Dealership>()
                .OrderBy(d => d.Id)
                .Select(d => new AllDealershipsServiceModel()
                {
                    Id = d.Id,
                    Name = d.Name,
                    Address = d.Address,
                    City = d.City.Name

                })
                .ToListAsync();
        }
    }
}
