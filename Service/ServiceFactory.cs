using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyProject.Domain.Contracts.Services;
using MyProject.Repositories;

namespace MyProject.Service
{
    public interface IServiceFactory
    {
        public CarService CarService { get; }
        public BrandService BrandService { get; }
        public ColorService ColorService { get; }
        public RentService RentService { get; }
        public UserService UserService { get; }
        Task<int> SaveAsync();
    }

    public class ServiceFactory:IServiceFactory,IDisposable
    {
        private readonly IRepositoryFactory _factory;
        public ServiceFactory(IRepositoryFactory repositoryFactory)
        {
            _factory = repositoryFactory;

        }


        private BrandService _brandService;
        public BrandService BrandService
        {
            get
            {
                this._brandService ??= new BrandService(_factory); //اگه نال بود جدید ایجاد کن در غیر اینصورت خودش رو بفرست
                return _brandService;
            }
        }



        private CarService _carService;
        public CarService CarService
        {
            get
            {
                this._carService ??= new CarService(_factory); //اگه نال بود جدید ایجاد کن در غیر اینصورت خودش رو بفرست
                return _carService;
            }
        }


        private ColorService _colorService;
        public ColorService ColorService
        {
            get
            {
                this._carService ??= new CarService(_factory); 
                return _colorService;
            }
        }

        private RentService _rentService;
        public RentService RentService
        {
            get
            {
                this._rentService ??= new RentService(_factory);
                return _rentService;
            }
        }


        private UserService _userService;
        public UserService UserService
        {
            get
            {
                this._userService ??= new UserService(_factory);
                return _userService;
            }
        }





        #region SaveChange
        public async Task<int> SaveAsync()
        {
            return await _factory.SaveAsync();
        }
        #endregion

        private bool _disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this._disposed)
            {
                if (disposing)
                {
                    ((IDisposable)_factory).Dispose();
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
