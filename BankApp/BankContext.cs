using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp
{
    class BankContext : DbContext
    {
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BankApr20;Integrated Security=True;Connect Timeout=30;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>(entity =>
            {
                entity.ToTable("Accounts");
                entity.HasKey(a => a.AccountNumber);
                entity.Property(a => a.AccountNumber)
                    .ValueGeneratedOnAdd();

                entity.Property(a => a.EmailAddress)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(a => a.AccountName)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(a => a.AccountType)
                    .IsRequired();

            });

            modelBuilder.Entity<Transaction>(entity =>
            {
                entity.ToTable("Transactions");
                entity.HasKey(t => t.Id);
                entity.Property(t => t.Id)
                    .ValueGeneratedOnAdd();

                entity.Property(t => t.Amount)
                    .IsRequired();

            });
        }
    }
}
