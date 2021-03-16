using System;
namespace EnsureTheBread.Domain.Entities
{
    public class Customer : BaseEntity
    {
        public string FistName {get;set;}
        public string LastName {get;set;}
        public string Address {get;set;}
        public DateTime InsertedIn {get; private set;}

        public Customer(){

        }
    }
}