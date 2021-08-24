using System;
using System.Linq;
using System.Linq.Expressions;
using EnsureTheBread.Domain.Services.Interfaces;
using EnsureTheBread.Infra.Context;
using Microsoft.EntityFrameworkCore;

namespace EnsureTheBread.Infra.Repository
{
  public class RepositoryBase<T> : IRepositoryBase<T> where T : class
  {
    protected EnsureTheBreadContext RepositoryContext { get; set; }

    public RepositoryBase(EnsureTheBreadContext context)
    {
      this.RepositoryContext = context;
    }

    public void Create(T entity)
    {
      this.RepositoryContext.Set<T>().Add(entity);
      Save();
    }

    public void Delete(T entity)
    {
      this.RepositoryContext.Set<T>().Remove(entity);
    }

    public IQueryable<T> FindAll()
    {
      return this.RepositoryContext.Set<T>().AsNoTracking();
    }

    public void Update(T entity)
    {
      this.RepositoryContext.Set<T>().Update(entity);
    }

    public IQueryable<T> FindById(Expression<Func<T, bool>> expression)
    {
      return this.RepositoryContext.Set<T>().Where(expression).AsNoTracking();
    }

    private void Save()
    {
      this.RepositoryContext.SaveChanges();
    }
  }
}
