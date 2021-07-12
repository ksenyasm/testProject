﻿using Microsoft.EntityFrameworkCore;
using testProject.Models;

namespace testProject.DAL
{
    public class DataContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DataContext()
        {
            //Database.EnsureDeleted();
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=test;Username=postgres;Password=sa");
        }
    }

}
