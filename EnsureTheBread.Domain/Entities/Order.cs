using System;
using System.Collections.Generic;

namespace EnsureTheBread.Domain.Entities
{
    public class Order : BaseEntity
    {
        public DateTime OrderDate {get;set;}
        public Guid CustomerId {get;set;}
        public IEnumerable<Items> Items {get;set;}
    }
}