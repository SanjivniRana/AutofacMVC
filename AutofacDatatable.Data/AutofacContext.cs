using AutofacDatatable.Core.Interfaces;
using AutofacDatatable.Core.Model;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;


namespace AutofacDatatable.Data
{
    public class AutofacContext : DbContext, IDbContext
    {
        public AutofacContext(string connString)
            : base("connString")
        {
            Database.SetInitializer<AutofacContext>(new DBInitializer());
        }
        public AutofacContext()
        {

        }

        public new IDbSet<TEntity> Set<TEntity>() where TEntity : class
        {
            return base.Set<TEntity>();

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            
            modelBuilder.Entity<User>();
            modelBuilder.Entity<Role>();
            modelBuilder.Entity<Team>();
            modelBuilder.Entity<Log>();
            modelBuilder.HasDefaultSchema("week6");
            base.OnModelCreating(modelBuilder);
        }

        public System.Data.Entity.DbSet<AutofacDatatable.Core.Model.User> Users { get; set; }

        public System.Data.Entity.DbSet<AutofacDatatable.Core.Model.Role> Roles { get; set; }

        public System.Data.Entity.DbSet<AutofacDatatable.Core.Model.Team> Teams { get; set; }
    }
}