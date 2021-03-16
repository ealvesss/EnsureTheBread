using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EnsureTheBread.Domain.Entities;

namespace EnsureTheBread.Domain.Services
{
    public class CustomerService
    {
        public CustomerService()
        {
            
        }

        public async Task<Guid> SaveCustomerAsync(Customer entity){
            return await Task.FromResult(Guid.NewGuid());
        }

        public async Task<Customer> GetCustomerByIdAsync(Guid id){
            return await Task.FromResult(new Customer());
        }

        public async Task<IEnumerable<Customer>> GetAllAsync(){
            return await Task.FromResult(new List<Customer>());
        }

        public async Task<bool> DeleteCustomerAsync(){
            return await Task.FromResult(true);
        }
    }
}