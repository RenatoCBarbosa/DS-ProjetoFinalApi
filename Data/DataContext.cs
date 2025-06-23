using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjetoFinalApi.Locacao.Models;
using ProjetoFinalApi.Locacao.Enuns;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace ProjetoFinalApi.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<LocacaoApi> TB_LOCACOES { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LocacaoApi>().ToTable("TB_LOCACOES");

            modelBuilder.Entity<LocacaoApi>().HasData
            (
            new LocacaoApi() {Id = 1, IdUsuario = 1, Nome="Anual", Valor=ValorEnum.Anual},
            new LocacaoApi() {Id = 2, IdUsuario = 2 ,Nome="Mensal", Valor=ValorEnum.Mensal},
            new LocacaoApi() {Id = 3, IdUsuario = 3, Nome="Diario", Valor=ValorEnum.Diario}
            );
        }
        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            configurationBuilder.Properties<string>().HaveColumnType("varchar").HaveMaxLength(200);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.ConfigureWarnings(warnings => warnings
            .Ignore(RelationalEventId.PendingModelChangesWarning));
        }
    }
}