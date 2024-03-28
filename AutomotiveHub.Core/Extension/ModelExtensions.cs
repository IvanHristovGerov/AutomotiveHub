using AutomotiveHub.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotiveHub.Core.Extension
{
    public static  class ModelExtensions
    {

        public static string GetInformation(this ICarServiceModel car)
        {
            var sb = new StringBuilder();

            sb.Append(car.Brand.Replace(" ", "-"));
            sb.Append("-");
            sb.Append(car.PricePerDay);
            sb.Append("-");
            sb.Append(car.Model.Replace(" ", "-"));

            return sb.ToString();
        }
    }
}
