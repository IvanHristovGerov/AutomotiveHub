using AutomotiveHub.Core.Models.Cars;
using AutomotiveHub.Infrastructure.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotiveHub.Core.Extension
{
    public static class IQueryableCarExtension
    {
        public static IQueryable<CarServiceModel> ProjectToCarServiceModel(this IQueryable<Car> cars)
        {
            return cars
                .Select(c => new CarServiceModel()
                {
                    Id=c.Id,
                    Brand = c.Brand,
                    Model = c.Model,
                    ImageUrl = c.ImageUrl,
                    PricePerDay = c.PricePerDay,
                    IsRented = c.RenterId !=null,
                    Transmission = c.Transmission,
                    Fuel = c.Fuel
                });
        }
    }
}
