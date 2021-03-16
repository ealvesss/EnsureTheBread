using System.Collections.Generic;

namespace EnsureTheBread.Domain.Entities
{
    public class Product : BaseEntity
    {
        public string Description {get;set;}
        public int BarCode {get;set;}

        public IEnumerable<ProductProperties> Properties {get;set;}
    }
}