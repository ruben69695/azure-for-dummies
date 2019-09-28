using System.Reflection;
using Microsoft.EntityFrameworkCore;

using AppService.Models;
using AppService.Infrastructure.Data.Configurations;
using Microsoft.EntityFrameworkCore.Design;

namespace AppService.Infrastructure.Data
{
    public class AppServiceDbContext : DbContext
    {
        public virtual DbSet<Superhero> Heroes { get; set; }

        public AppServiceDbContext(DbContextOptions<AppServiceDbContext> options) : base(options)
        { }

        public virtual void Commit() {
            base.SaveChanges();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {

            modelBuilder
                .ApplyConfigurationsFromAssembly(Assembly.GetAssembly(typeof(SuperheroConfiguration)));
            
            base.OnModelCreating(modelBuilder);
        }
    }

    class Factory : IDesignTimeDbContextFactory<AppServiceDbContext>
    {
        public AppServiceDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppServiceDbContext>();
            optionsBuilder.UseInMemoryDatabase("heroes");
            return new AppServiceDbContext(optionsBuilder.Options);
        }
    }
}