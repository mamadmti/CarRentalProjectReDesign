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
    public class RentService : IRentService
    {
        private readonly IRepositoryFactory _repositoryFactory;

        public RentService(IRepositoryFactory repositoryFactory )
        {
            _repositoryFactory = repositoryFactory;
        }
        public async Task<Rent> AddNew(Rent item)
        {
            return await _repositoryFactory.Repository.Add(item);
        }

        public async Task<Rent> GetById(long id)
        {
            return await _repositoryFactory.Repository.GetById<Rent>(id);
        }

        public async Task Remove(Rent item)
        {
            await _repositoryFactory.Repository.Delete(item);
        }

        public async Task Update(Rent item)
        {
            await _repositoryFactory.Repository.Update(item);
        }
    }
}
