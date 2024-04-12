using AutomotiveHub.Core.Models.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotiveHub.Core.Contracts.Admin
{
    public interface IRentService
    {
        Task<IEnumerable<AllRentsModel>> AllRentsAsync();
    }
}
