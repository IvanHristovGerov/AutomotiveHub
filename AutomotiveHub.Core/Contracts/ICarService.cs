﻿using AutomotiveHub.Core.Enumerations;
using AutomotiveHub.Core.Models.Cars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotiveHub.Core.Contracts
{
    public interface ICarService
    {
        Task<IEnumerable<CarServiceModel>> AllCarsAsync();

        Task<CarQueryServiceModel> AllAsync(
            string? category = null,
            string? searchQuery = null,
            CarSorting sorting = CarSorting.Newest,
            int currentPage = 1,
            int carsPerPage = 1);

        Task<IEnumerable<string>> AllCategoriesNamesAsync();

        Task<IEnumerable<CarServiceModel>> AllCarsByUserId(string userId);
        Task<IEnumerable<CarServiceModel>> AllCarsByDealerId(int dealerId);


    }
}