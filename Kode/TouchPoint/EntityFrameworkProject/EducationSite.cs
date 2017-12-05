namespace EntityFrameworkProject
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EducationSite
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EducationSite()
        {
            Courses = new HashSet<Cours>();
            Rooms = new HashSet<Room>();
        }

        [Key]
        [StringLength(64)]
        public string EduSiteName { get; set; }

        [Required]
        [StringLength(16)]
        public string PhoneNr { get; set; }

        [Required]
        [StringLength(64)]
        public string Address { get; set; }

        [Required]
        [StringLength(64)]
        public string Email { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cours> Courses { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Room> Rooms { get; set; }
    }
}
