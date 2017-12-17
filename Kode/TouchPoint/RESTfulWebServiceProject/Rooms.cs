namespace RESTfulWebServiceProject
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Rooms
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Rooms()
        {
            Courses = new HashSet<Courses>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(64)]
        public string EduSiteName { get; set; }

        [Required]
        [StringLength(64)]
        public string RoomName { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Courses> Courses { get; set; }

        public virtual EducationSites EducationSites { get; set; }
    }
}
