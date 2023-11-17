using CrudBasico.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CrudBasico.Infra.Data.Mapping
{
    public class PessoaMap : IEntityTypeConfiguration<Pessoa>
    {
        public void Configure(EntityTypeBuilder<Pessoa> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .HasColumnName("ID")
                .IsRequired();

            builder.Property(x => x.Nome)
                .HasColumnName("NOME")
                .HasMaxLength(255)
                .IsRequired();

            builder.Property(x => x.DataNascimento)
                .HasColumnName("DATANASCIMENTO")
                .IsRequired();

            builder.Property(x => x.Endereco)
                .HasColumnName("ENDERECO")
                .IsRequired()
                .HasMaxLength(1000);

            builder.ToTable("PESSOA");
        }
    }
}
