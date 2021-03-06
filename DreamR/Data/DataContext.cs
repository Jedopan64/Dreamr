using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using DreamR.Data.Entities;


namespace DreamR.Data{
    /// <summary>
    /// Entity Framework database context class.
    /// Provides communication with database.
    /// </summary>
    public class DataContext : IdentityDbContext<AppUser, AppRole, int>
    {         
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        { }    

        public DbSet<Category> Category{get;set;}
        public DbSet<Goal> Goal{get;set;}
        public DbSet<UsersGoal> UsersGoal{get;set;}
        
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            
        
        }  

    }
}