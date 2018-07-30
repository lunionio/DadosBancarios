using Financeiro.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;

namespace FInanceiro.Infra
{
    public class Contexto: DbContext
    {

        public DbSet<DadosBancarios> DadosBancarios { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=34.226.175.244;Initial Catalog=StaffProFinanceiro;Persist Security Info=True;User ID=sa;Password=StaffPro@123;");
        }
    }
}
