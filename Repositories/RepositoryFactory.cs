using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarRentalWebApiReDesign.Domain.Context;
using MyProject.Domain.Contracts.Repositories;

namespace MyProject.Repositories
{
    public interface IRepositoryFactory
    {
        public IRepository Repository { get; }
        Task<int> SaveAsync();
    }

    public class RepositoryFactory : IDisposable, IRepositoryFactory
    {
        private readonly CarRentalContext _context;
        public IRepository Repository { get; }
        public RepositoryFactory(CarRentalContext context, IRepository rep)
        {
            _context = context;
            Repository = rep;
        }



       


        #region SaveChange
        public async Task<int> SaveAsync()
        {

            int result = await _context.SaveChangesAsync();

            return result;


        }
        #endregion

        private bool _disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this._disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this._disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
