using DebtManager.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DebtManager.Infra.Data.Context
{
    public class DebtManagerContext : DbContext
    {
        public DebtManagerContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Teste> Testes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Teste>().ToTable("Teste");
        }

    }
}
