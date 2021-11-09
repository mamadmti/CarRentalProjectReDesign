using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarRentalWebApiReDesign.Domain.Context;
using MyProject.Domain.Contracts.Services;
using MyProject.Domain.Entities;
using MyProject.Repositories;

namespace MyProject.Service
{
    public class CarService : ICarService
    {
        private readonly IRepositoryFactory _repositoryFactory;

        public CarService(IRepositoryFactory repositoryFactory )
        {
            _repositoryFactory = repositoryFactory;
        }
        public async Task<Car> AddNew(Car item)
        {
            return await _repositoryFactory.Repository.Add(item);
        }

        public async Task<Car> GetById(long id)
        {
            return await _repositoryFactory.Repository.GetById<Car>(id);
        }

        public async Task Remove(Car item)
        {
            await _repositoryFactory.Repository.Delete(item);
        }

        public async Task Update(Car item)
        {
            await _repositoryFactory.Repository.Update(item);
        }
    }
}
