using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EnsureTheBread.Domain.Entities;
using EnsureTheBread.Domain.Services.Interfaces;

namespace EnsureTheBread.Domain.Services
{
  public class CustomerService : ServiceBase<Customer>
  {
    private readonly ICustomerRepository _repository;
    public CustomerService(ICustomerRepository baseRepository)
        : base(baseRepository)
    {
        _repository = baseRepository;
    }

    public async Task<Guid> SaveCustomerAsync(Customer entity)
    {
      return await Task.FromResult(Guid.NewGuid());
    }

    public async Task<Customer> GetCustomerByIdAsync(Guid id)
    {
      return await Task.FromResult(new Customer());
    }

    public async Task<IEnumerable<Customer>> GetAllAsync()
    {
      return await Task.FromResult(new List<Customer>());
    }

    public async Task<bool> DeleteCustomerAsync()
    {
      return await Task.FromResult(true);
    }
  }
}