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
    public class RentService : IRentService
    {
        private readonly IRepository repository;

        public RentService(IRepository _repository)
        {
            repository = _repository;
        }

        public async Task<IEnumerable<AllRentsModel>> AllRentsAsync()
        {
            return await repository.All<Reservation>()
                .Select(r => new AllRentsModel()
                {
                    Id = r.Id,
                    CarId = r.CarId,
                    ReservationPeriodId = r.ReservationPeriodId,
                    StartDate = r.StartDate,
                    EndDate = r.EndDate,
                    Price = r.TotalPrice,
                    IsActive = r.IsActive
                })
                .ToListAsync();
        }
    }
}
