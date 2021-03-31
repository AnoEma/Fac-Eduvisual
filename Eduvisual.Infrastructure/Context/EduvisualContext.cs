using Eduvisual.Domain;
using Microsoft.EntityFrameworkCore;

namespace Eduvisual.Infrastructure.Context
{
    public class EduvisualContext : DbContext
    {
        public EduvisualContext(DbContextOptions<EduvisualContext> options) : base(options)
        {
        }

        public DbSet<CadastroClientes> CadastroClientes { get; set; }
        public DbSet<EquipamentoDeInformatica> EquipamentoDeInformaticas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CadastroClientes>().HasKey(m => m.Id);
            modelBuilder.Entity<EquipamentoDeInformatica>().HasKey(m => m.Id);
            base.OnModelCreating(modelBuilder);
        }
    }
}