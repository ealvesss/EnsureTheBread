using System;
using EnsureTheBread.Domain.Entities;
using EnsureTheBread.Domain.Service.Validators;
using EnsureTheBread.Domain.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace EnsureTheBread.Api.Controllers
{
    [ApiController]
    [Route("v1/customer")]
    public class CustomerController : ControllerBase
    {
        private IBaseService<Customer> _baseUserService;
        public CustomerController(IBaseService<Customer> service)
        {
            _baseUserService = service;
        }

        [HttpPost]
         public IActionResult Post([FromBody] Customer customer){
             if (customer == null)
                return NotFound();

             return Execute(() => _baseUserService.Add<CustomerValidator>(customer).Id);
         } 

         private IActionResult Execute(Func<object> func)
        {
            try
            {
                var result = func();

                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}