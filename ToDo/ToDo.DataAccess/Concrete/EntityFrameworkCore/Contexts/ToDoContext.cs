using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using ToDo.DataAccess.Concrete.EntityFrameworkCore.Mapping;
using ToDo.Entities.Concrete;

namespace ToDo.DataAccess.Concrete.EntityFrameworkCore.Contexts
{
    public class ToDoContext : DbContext
    {
            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=(localdb)\\MSSQLLocalDB; database=ToDoProject ; integrated security=true; "); //user id=sa; password=********;
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           modelBuilder.ApplyConfiguration(new UserMap());
           modelBuilder.ApplyConfiguration(new BusinessMap());
        }

        public DbSet<User> Users { get; set; }  
        public DbSet<Business> Businesses { get; set; }

    }
        
}
