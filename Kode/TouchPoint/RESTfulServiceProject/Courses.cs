namespace RESTfulServiceProject
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Courses
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Column(TypeName = "date")]
        public DateTime Date { get; set; }

        public int Period { get; set; }

        [StringLength(512)]
        public string PriceText { get; set; }

        public int AvailSpots { get; set; }

        [StringLength(512)]
        public string SeminarDesc { get; set; }

        [StringLength(512)]
        public string ExtraMat { get; set; }

        public int? RabPoints { get; set; }

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

        public byte[] Picture { get; set; }

        [StringLength(512)]
        public string Compendium { get; set; }

        [StringLength(64)]
        public string ExtHost { get; set; }

        public bool ShowPrice { get; set; }

        public bool ShowPriceDetails { get; set; }

        public bool ShowDeposit { get; set; }

        public float? EvalExpectations { get; set; }

        public float? EvalContent { get; set; }

        public float? EvalMat { get; set; }

        public virtual EducationSites EducationSites { get; set; }

        public virtual Rooms Rooms { get; set; }
    }
}
