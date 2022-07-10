using Microsoft.EntityFrameworkCore;
using MyCarOffice.Domain.Entities;

namespace MyCarOffice.Infra.Context
{
    public class MyCarOfficeContext : DbContext
    {
        public DbSet<Cliente>? tbClientes { get; set; }
        public DbSet<Especializacao>? tbEspecializacoes { get; set; }
        public DbSet<Oficina>? tbOficinas { get; set; }
        public DbSet<OrdemDeServico>? tbOrdensDeServico { get; set; }
        public DbSet<Profissional>? tbProfissionais { get; set; }
        public DbSet<Servico>? tbServicos { get; set; }
        public DbSet<Veiculo>? tbVeiculos { get; set; }

        // Overrides

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseLazyLoadingProxies();
            optionsBuilder.UseSqlServer("Server =.\\SQLEXPRESS; Database = MyCarOffice; Trusted_Connection = True; TrustServerCertificate = true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(MyCarOfficeContext).Assembly);
        }
    }
}
