using System;
using MicroRabbit.Banking.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace MicroRabbit.Banking.Data.Context
{
    public class BankingDbContext : DbContext
    {
        public BankingDbContext() : base()
        {

        }
        public BankingDbContext(DbContextOptions<BankingDbContext> options): base(options)
        {
            
        }

        public DbSet<Account> Accounts {get;set;}

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured)
            {
               options.UseSqlServer("Server=localhost\\SQLEXPRESS;Initial Catalog=BankingDB;Integrated Security=True;");
            }
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);            
        }
    }
}
