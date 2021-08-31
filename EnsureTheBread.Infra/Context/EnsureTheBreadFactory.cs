using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace EnsureTheBread.Infra.Context
{
  public class EnsureTheBreadFactory : IDesignTimeDbContextFactory<EnsureTheBreadContext>
  {
    private const string CONNECTIONSTRING = @"Server=localhost;Database=EnsureTheBread;User Id=sa;Password=Admin001;";
    public EnsureTheBreadContext CreateDbContext(string[] args)
    {
      var optionsBuilder = new DbContextOptionsBuilder<EnsureTheBreadContext>();
        optionsBuilder.UseSqlServer(CONNECTIONSTRING);

        return new EnsureTheBreadContext(optionsBuilder.Options);
    }
  }
}