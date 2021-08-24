namespace EnsureTheBread.Domain.Entities
{
    public class Item : BaseEntity
    {
        public string Description {get;set;}
        public Product Product {get;set;}
        public int Quantity {get;set;}
    }
}