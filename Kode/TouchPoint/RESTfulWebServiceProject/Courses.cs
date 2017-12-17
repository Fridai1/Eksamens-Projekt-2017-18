namespace RESTfulWebServiceProject
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Courses
    {
        public int Id { get; set; }

        [Column(TypeName = "date")]
        public DateTime Date { get; set; }

        public int Period { get; set; }

        [StringLength(512)]
        public string PriceText { get; set; }

        public int AvailSpots { get; set; }

        [StringLength(512)]
        public string ExtraMat { get; set; }

        [Required]
        [StringLength(64)]
        public string EduSiteName { get; set; }

        public int IdRoom { get; set; }

        [Required]
        [StringLength(256)]
        public string Tutors { get; set; }

        [StringLength(512)]
        public string CourseDesc { get; set; }

        [StringLength(512)]
        public string Prereqs { get; set; }

        [StringLength(512)]
        public string Compendium { get; set; }

        public virtual EducationSites EducationSites { get; set; }

        public virtual Rooms Rooms { get; set; }
    }
}
