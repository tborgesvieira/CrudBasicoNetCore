using CrudBasico.Infra.Data.Mapping;
using Microsoft.EntityFrameworkCore;

namespace CrudBasico.Infra.Data.Context
{
    public class CrudBasicoContext : DbContext
    {
        public CrudBasicoContext(DbContextOptions<CrudBasicoContext> contextOptions) : base(contextOptions)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Forma que lê todas as classes que herdam do IEntityTypeConfiguration e faz automático
            //modelBuilder.ApplyConfigurationsFromAssembly(this.GetType().Assembly);

            //Forma manual informando um a um
            modelBuilder.ApplyConfiguration(new PessoaMap());
        }
    }
}
