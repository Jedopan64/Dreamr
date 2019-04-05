using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using DreamR.Data.Entities;

namespace DreamR.Data{
 public class DataContext : IdentityDbContext<AppUser, AppRole, int> 
    {   
               
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        { }      

    }
}