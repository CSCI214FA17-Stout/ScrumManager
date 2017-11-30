using Microsoft.EntityFrameworkCore;
using ScrumManager.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScrumManager.Models.DbContexts
{
    public class ScrumManagerDbContext : DbContext
    {
        public ScrumManagerDbContext(DbContextOptions options) : base(options) { }//injection

            public DbSet<People> Peoples { get; set; }
            
            public DbSet<Event> Events { get; set; }
           
            

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                
            }
        
    }
}
