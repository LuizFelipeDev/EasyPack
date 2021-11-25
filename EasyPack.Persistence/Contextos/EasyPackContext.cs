using EasyPack.Domain.model;
using Microsoft.EntityFrameworkCore;

namespace EasyPack.Persistence.Contexto
{
    public class EasyPackContext: DbContext
    {

        public EasyPackContext(DbContextOptions<EasyPackContext> options) : base(options)
        {
            //mysql -h localhost -u root -p
        }
        public DbSet<Entrega> Entregas {get;set;}
        public DbSet<Carga> Cargas {get;set;}

        protected override void OnModelCreating(ModelBuilder builder)
        {
            //builder.Entity<Entrega>().HasKey(E=> new {E. })  
        }
    }
}