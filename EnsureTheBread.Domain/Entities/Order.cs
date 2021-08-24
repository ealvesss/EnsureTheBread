using System;
using System.Collections.Generic;

namespace EnsureTheBread.Domain.Entities
{
    public class Order : BaseEntity
    {
        public DateTime OrderDate {get;set;}
        public Customer Customer {get;set;}
        public IEnumerable<Item> Items {get;set;}
    }
}