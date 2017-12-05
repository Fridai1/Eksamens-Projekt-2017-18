namespace EntityFrameworkProject {
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class TouchpointDBContext : DbContext {
        public TouchpointDBContext()
            : base("name=TouchpointDBContext") {
            base.Configuration.LazyLoadingEnabled = false;
            base.Configuration.ProxyCreationEnabled = false;
        }

        public virtual DbSet<Cours> Courses { get; set; }
        public virtual DbSet<EducationSite> EducationSites { get; set; }
        public virtual DbSet<Room> Rooms { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder) {
            modelBuilder.Entity<Cours>()
                .Property(e => e.PriceText)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Cours>()
                .Property(e => e.SeminarDesc)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Cours>()
                .Property(e => e.ExtraMat)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Cours>()
                .Property(e => e.EduSiteName)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Cours>()
                .Property(e => e.Tutors)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Cours>()
                .Property(e => e.CourseDesc)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Cours>()
                .Property(e => e.Prereqs)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Cours>()
                .Property(e => e.Compendium)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Cours>()
                .Property(e => e.ExtHost)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<EducationSite>()
                .Property(e => e.EduSiteName)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<EducationSite>()
                .Property(e => e.PhoneNr)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<EducationSite>()
                .Property(e => e.Address)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<EducationSite>()
                .Property(e => e.Email)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<EducationSite>()
                .HasMany(e => e.Courses)
                .WithRequired(e => e.EducationSite)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EducationSite>()
                .HasMany(e => e.Rooms)
                .WithRequired(e => e.EducationSite)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Room>()
                .Property(e => e.EduSiteName)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Room>()
                .Property(e => e.RoomName)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Room>()
                .HasMany(e => e.Courses)
                .WithRequired(e => e.Room)
                .HasForeignKey(e => e.IdRoom)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Username)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Password)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Name)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.PhoneNr)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Address)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Field)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Email)
                .IsFixedLength()
                .IsUnicode(false);
        }
    }
}
