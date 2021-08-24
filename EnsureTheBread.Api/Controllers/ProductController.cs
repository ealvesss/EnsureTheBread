using System;
using Microsoft.AspNetCore.Mvc;

namespace EnsureTheBread.Api.Controllers
{
    [ApiController]
    [Route("v1/products")]
    public class ProductController
    {
        public ProductController()
        {}

         [HttpPost]
         public Guid Post([FromBody] string model){
             return Guid.NewGuid();
         } 
    }
}
