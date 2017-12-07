namespace RESTfulServiceProject
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Users
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Required]
        [StringLength(32)]
        public string Username { get; set; }

        [Required]
        [StringLength(32)]
        public string Password { get; set; }

        [Required]
        [StringLength(32)]
        public string Name { get; set; }

        [Required]
        [StringLength(16)]
        public string PhoneNr { get; set; }

        [Required]
        [StringLength(64)]
        public string Address { get; set; }

        public bool IsTutor { get; set; }

        [Required]
        [StringLength(64)]
        public string Field { get; set; }

        [Required]
        [StringLength(64)]
        public string Email { get; set; }
    }
}
