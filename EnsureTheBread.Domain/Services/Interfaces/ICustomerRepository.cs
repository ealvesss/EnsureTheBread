using System;
using System.Linq;
using System.Linq.Expressions;
using EnsureTheBread.Domain.Entities;
using EnsureTheBread.Domain.Services.Interfaces;

namespace EnsureTheBread.Domain.Services.Interfaces
{
  public interface ICustomerRepository : IRepositoryBase<Customer>
  {
    
  }
}
