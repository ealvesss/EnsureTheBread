using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using EnsureTheBread.Domain.Entities;
using EnsureTheBread.Domain.Services.Interfaces;
using FluentValidation;

namespace EnsureTheBread.Domain.Services
{
  public  class ServiceBase<T> : IServiceBase<T> where T : BaseEntity
  {
    private readonly IRepositoryBase<T> _baseRepository;

     public ServiceBase(IRepositoryBase<T> baseRepository)
     {
       _baseRepository = baseRepository;
     }

     public T Create<TValidator>(T obj) where TValidator : AbstractValidator<T>
     {
       Validate(obj, Activator.CreateInstance<TValidator>());
       _baseRepository.Create(obj);
       return obj;
     }

     public void Delete(T id) => _baseRepository.Delete(id);

     public IQueryable<T> Get() => _baseRepository.FindAll();

     public IQueryable<T> GetById(Expression<Func<T, bool>> entity) => _baseRepository.FindById(entity);

    public T Update<TValidator>(T obj) where TValidator : AbstractValidator<T>
    {
      Validate(obj, Activator.CreateInstance<TValidator>());
      _baseRepository.Update(obj);
      return obj;
    }

    private void Validate(T obj, AbstractValidator<T> validator)
    {
      if (obj == null)
        throw new Exception("Registros não detectados!");
      validator.ValidateAndThrow(obj);
    }
  }
}
