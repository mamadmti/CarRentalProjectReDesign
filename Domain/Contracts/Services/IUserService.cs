using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarRentalWebApiReDesign.Domain.Context;
using MyProject.Domain.Contracts.Services;

namespace CarRentalWebApiReDesign.Domain.Contracts.Services
{
    public interface IUserService : IService<User, long>
    {
    }
}
