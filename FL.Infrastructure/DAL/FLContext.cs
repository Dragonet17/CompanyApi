using System;
using System.Collections.Generic;
using System.Text;
using FL.Core.Domain;
using Microsoft.EntityFrameworkCore;

namespace FL.Infrastructure.DAL
{
   public class FLContext:DbContext
    {
        public  DbSet<Employee> Employees { get; set; }

        public FLContext(DbContextOptions<FLContext> options):base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>()
                .HasKey(e => e.Id);
        }
    }
}
