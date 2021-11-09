using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarRentalWebApiReDesign.Domain.Context;
using MyProject.Domain.Entities;

namespace MyProject.Domain.Contracts.Services
{
  public  interface ICarService:IService<Car,long>
    {
    }
}
