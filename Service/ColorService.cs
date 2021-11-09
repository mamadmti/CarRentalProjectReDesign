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
    public class ColorService : IColorService
    {
        private readonly IRepositoryFactory _repositoryFactory;

        public ColorService(IRepositoryFactory repositoryFactory )
        {
            _repositoryFactory = repositoryFactory;
        }
        public async Task<Color> AddNew(Color item)
        {
            return await _repositoryFactory.Repository.Add(item);
        }

        public async Task<Color> GetById(long id)
        {
            return await _repositoryFactory.Repository.GetById<Color>(id);
        }

        public async Task Remove(Color item)
        {
            await _repositoryFactory.Repository.Delete(item);
        }

        public async Task Update(Color item)
        {
            await _repositoryFactory.Repository.Update(item);
        }
    }
}
