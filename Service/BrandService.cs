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

    public class BrandService : IBrandService
    {
        private readonly IRepositoryFactory _repositoryFactory;

        public BrandService(IRepositoryFactory repositoryFactory)
        {
            _repositoryFactory = repositoryFactory;
        }

        public async Task<Brand> AddNew(Brand item)
        {
            return await _repositoryFactory.Repository.Add(item);
        }

        public async Task<Brand> GetById(long id)
        {
            return await _repositoryFactory.Repository.GetById<Brand>(id);
        }

        public async Task Remove(Brand item)
        {
            await _repositoryFactory.Repository.Delete(item);
        }

        public async Task Update(Brand item)
        {
            await _repositoryFactory.Repository.Update(item);
        }
    }
}

