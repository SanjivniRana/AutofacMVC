using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace w6.Models
{
    public class UserContext : DbContext
    {

        public DbSet<User> Users { get; set; }
        public DbSet<Sta> Stas { get; set; }
        public DbSet<Ct> Cts { get; set; }
        //   public DbSet<State> States { get; set; }
        //   public DbSet<NameStateCity> Names { get; set; }
        //  public DbSet<Course> Courses { get; set; }
        public UserContext() : base("Aman")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("week6");

            modelBuilder.Entity<User>()
                 .HasKey(c => c.Id);

          

            base.OnModelCreating(modelBuilder);
        }

       
    }
}