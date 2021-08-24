using System;
using EnsureTheBread.Domain.Entities;
using EnsureTheBread.Infra.Context;
using EnsureTheBread.Domain.Services.Interfaces;

namespace EnsureTheBread.Infra.Repository
{
  public class CustomerRepository : RepositoryBase<Customer>, ICustomerRepository
  {
    public CustomerRepository(EnsureTheBreadContext repositoryContext)
            : base(repositoryContext)
    {
    }
  }
}
