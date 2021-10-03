using System;
using MicroRabbit.Transfer.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace MicroRabbit.Transfer.Data.Context
{
    public class TransferDbContext : DbContext
    {
        public TransferDbContext() : base()
        {

        }
        public TransferDbContext(DbContextOptions<TransferDbContext> options): base(options)
        {
            
        }

        public DbSet<TransferLog> TransferLogs {get;set;}

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured)
            {
               options.UseSqlServer("Server=localhost\\SQLEXPRESS;Initial Catalog=TransferDB;Integrated Security=True;");
            }
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);            
        }
    }
}
