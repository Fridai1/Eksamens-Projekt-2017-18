namespace RESTfulWebServiceProject {
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class TouchPointDBContext : DbContext {
        public TouchPointDBContext()
            : base("name=TouchPointDBContext") {
            base.Configuration.LazyLoadingEnabled = false;
            base.Configuration.ProxyCreationEnabled = false;
        }

        public virtual DbSet<Courses> Courses { get; set; }
        public virtual DbSet<EducationSites> EducationSites { get; set; }
        public virtual DbSet<Rooms> Rooms { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder) {
            modelBuilder.Entity<EducationSites>()
                .HasMany(e => e.Courses)
                .WithRequired(e => e.EducationSites)
                .HasForeignKey(e => e.EduSiteName)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EducationSites>()
                .HasMany(e => e.Rooms)
                .WithRequired(e => e.EducationSites)
                .HasForeignKey(e => e.EduSiteName)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Rooms>()
                .HasMany(e => e.Courses)
                .WithRequired(e => e.Rooms)
                .HasForeignKey(e => e.IdRoom)
                .WillCascadeOnDelete(false);
        }
    }
}
