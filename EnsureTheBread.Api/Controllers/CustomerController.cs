using System;
using EnsureTheBread.Api.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace EnsureTheBread.Api.Controllers
{
    [ApiController]
    [Route("v1/customer")]
    public class CustomerController
    {
        public CustomerController()
        {
            
        }

        [HttpPost]
         public Guid Post([FromBody] CustomerViewModel model){
             

             return Guid.NewGuid();
         } 
    }
}