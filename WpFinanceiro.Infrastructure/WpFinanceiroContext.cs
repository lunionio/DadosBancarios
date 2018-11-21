using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WpFinanceiro.Entities;

namespace WpFinanceiro.Infrastructure
{
    public class WpFinanceiroContext : DbContext
    {
        public DbSet<Extrato> Extratos { get; set; }
        public DbSet<Natureza> Naturezas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Data Source=34.226.175.244;Initial Catalog=StaffProFinanceiro;Persist Security Info=True;User ID=sa;Password=StaffPro@123;");
        }
    }
}
