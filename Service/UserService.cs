using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarRentalWebApiReDesign.Domain.Context;
using CarRentalWebApiReDesign.Domain.Contracts.Services;
using MyProject.Domain.Contracts.Services;
using MyProject.Domain.Entities;
using MyProject.Repositories;

namespace MyProject.Service
{

    public class UserService : IUserService
    {
        private readonly IRepositoryFactory _repositoryFactory;

        public UserService(IRepositoryFactory repositoryFactory)
        {
            _repositoryFactory = repositoryFactory;
        }

        public async Task<User> AddNew(User item)
        {
            return await _repositoryFactory.Repository.Add(item);
        }

        public async Task<User> GetById(long id)
        {
            return await _repositoryFactory.Repository.GetById<User>(id);
        }

        public async Task Remove(User item)
        {
            await _repositoryFactory.Repository.Delete(item);
        }

        public async Task Update(User item)
        {
            await _repositoryFactory.Repository.Update(item);
        }
    }
}

