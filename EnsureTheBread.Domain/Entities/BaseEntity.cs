using System;
namespace EnsureTheBread.Domain.Entities
{
    public abstract class BaseEntity : IEquatable<BaseEntity>
    {
        public Guid Id { get; private set; }

        public BaseEntity()
        {
            this.Id = Guid.NewGuid();

        }

        public bool Equals(BaseEntity other)
        {
            return Id == other.Id;
        }
    }
}