namespace RESTfulWebServiceProject
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Users
    {
        public int Id { get; set; }

        [Required]
        [StringLength(64)]
        public string Username { get; set; }

        [Required]
        [StringLength(64)]
        public string Password { get; set; }

        [Required]
        [StringLength(64)]
        public string Name { get; set; }

        [Required]
        [StringLength(64)]
        public string PhoneNr { get; set; }

        [Required]
        [StringLength(64)]
        public string Address { get; set; }

        public bool IsTutor { get; set; }

        [StringLength(64)]
        public string Field { get; set; }

        [Required]
        [StringLength(64)]
        public string Email { get; set; }
    }
}
