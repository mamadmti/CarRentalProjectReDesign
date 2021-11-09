using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarRentalWebApiReDesign.Domain.Context;
using MyProject.Domain.Contracts.Services;
using MyProject.Domain.Entities;
using MyProject.Domain.ViewModel;
using MyProject.Service;

namespace MyProject.Apis
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandController : ControllerBase
    {
        private readonly IServiceFactory _serviceFactory;

        public BrandController(IServiceFactory serviceFactory)
        {
            _serviceFactory = serviceFactory;
        }

        private IBrandService BrandService { get; set; }
        
        [HttpGet("GetBrandById")]
        public async Task<Brand> GetBrandById(long id)
        {
            BrandService = _serviceFactory.BrandService;
            return await BrandService.GetById(id);
        }


        [HttpPost("AddNewBrand")]
        public async Task<Brand> AddNewBrand(BrandDto item)
        {
            BrandService = _serviceFactory.BrandService;
            var res = await BrandService.AddNew(new ()
            {
              UserId = Guid.Parse("e4246c59-4357-4c5e-a5a9-af4307c4f751"),
              BrandName = item.BrandName,
              RecordStatus = 0,
              CreateAt = DateTime.Now
            });
            var result = await _serviceFactory.SaveAsync();
            return res;
        }

        [HttpPut("UpdateBrand")]
        public async Task<IActionResult> UpdateBrand(BrandDto item)
        {
            BrandService = _serviceFactory.BrandService;
            var brand = await BrandService.GetById(item.Id ?? 0);
            brand.BrandName = item.BrandName;
            
            
            await BrandService.Update(brand);
            var result = await _serviceFactory.SaveAsync();
            return Ok("Operation is Successfull");

        }

        [HttpDelete("DeleteBrandById")]
        public async Task<IActionResult> DeleteBrandById(long id)
        {
            BrandService = _serviceFactory.BrandService;
            var address = await BrandService.GetById(id);
            await BrandService.Remove(address);
            var result = await _serviceFactory.SaveAsync();
            return Ok("Operation is succefull");
        }

    }
}
