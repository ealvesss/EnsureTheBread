using System;
using System.Linq;
using System.Linq.Expressions;
using FluentValidation;

namespace EnsureTheBread.Domain.Services.Interfaces
{
    public interface IServiceBase<T>
    {
        T Create<TValidator>(T obj) where TValidator : AbstractValidator<T>;

        void Delete(T entity);

        IQueryable<T> Get();

        IQueryable<T> GetById(Expression<Func<T, bool>> entity);

        T Update<TValidator>(T obj) where TValidator : AbstractValidator<T>;
    }
}
