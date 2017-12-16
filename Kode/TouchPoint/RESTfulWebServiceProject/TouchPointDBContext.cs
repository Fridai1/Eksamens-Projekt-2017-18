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
            modelBuilder.Entity<Courses>()
                .Property(e => e.PriceText)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Courses>()
                .Property(e => e.SeminarDesc)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Courses>()
                .Property(e => e.ExtraMat)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Courses>()
                .Property(e => e.EduSiteName)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Courses>()
                .Property(e => e.Tutors)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Courses>()
                .Property(e => e.CourseDesc)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Courses>()
                .Property(e => e.Prereqs)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Courses>()
                .Property(e => e.Compendium)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Courses>()
                .Property(e => e.ExtHost)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<EducationSites>()
                .Property(e => e.EduSiteName)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<EducationSites>()
                .Property(e => e.PhoneNr)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<EducationSites>()
                .Property(e => e.Address)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<EducationSites>()
                .Property(e => e.Email)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<EducationSites>()
                .HasMany(e => e.Courses)
                .WithRequired(e => e.EducationSites)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EducationSites>()
                .HasMany(e => e.Rooms)
                .WithRequired(e => e.EducationSites)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Rooms>()
                .Property(e => e.EduSiteName)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Rooms>()
                .Property(e => e.RoomName)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Rooms>()
                .HasMany(e => e.Courses)
                .WithRequired(e => e.Rooms)
                .HasForeignKey(e => e.IdRoom)
                .WillCascadeOnDelete(false);
        }
    }
}
