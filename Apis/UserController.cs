using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarRentalWebApiReDesign.Domain.Context;
using CarRentalWebApiReDesign.Domain.Contracts.Services;
using MyProject.Domain.Contracts.Services;
using MyProject.Domain.Entities;
using MyProject.Domain.ViewModel;
using MyProject.Service;

namespace MyProject.Apis
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IServiceFactory _serviceFactory;

        public UserController(IServiceFactory serviceFactory)
        {
            _serviceFactory = serviceFactory;
        }

        private IUserService UserService { get; set; }
        
        [HttpGet("GetUserById")]
        public async Task<User> GetUserById(long id)
        {
            UserService = _serviceFactory.UserService;
            return await UserService.GetById(id);
        }


        [HttpPost("AddNewUser")]
        public async Task<User> AddNewUser(UserDto item)
        {
            UserService = _serviceFactory.UserService;
            var res = await UserService.AddNew(new ()
            {
              UserId = Guid.Parse("e4246c59-4357-4c5e-a5a9-af4307c4f751"),
              UserName = item.UserName,
              IsAdmin = false,
              RecordStatus = 0,
              CreateAt = DateTime.Now
            });
            var result = await _serviceFactory.SaveAsync();
            return res;
        }

        [HttpPut("UpdateUser")]
        public async Task<IActionResult> UpdateUser(UserDto item)
        {
            UserService = _serviceFactory.UserService;
            var user = await UserService.GetById(item.Id ?? 0);
            user.IsAdmin = false;
            user.UserName = item.UserName;
            user.UserId = Guid.Parse("e4246c59-4357-4c5e-a5a9-af4307c4f751");
            user.RecordStatus = 0;


            await UserService.Update(user);
            var result = await _serviceFactory.SaveAsync();
            return Ok("Operation is Successfull");

        }

        [HttpDelete("DeleteUserById")]
        public async Task<IActionResult> DeleteUserById(long id)
        {
            UserService = _serviceFactory.UserService;
            var user = await UserService.GetById(id);
            await UserService.Remove(user);
            var result = await _serviceFactory.SaveAsync();
            return Ok("Operation is succefull");
        }

    }
}
