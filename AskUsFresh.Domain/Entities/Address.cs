using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AskUsFresh.Domain.Entities
{
    public class Address
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int UserId { get; set; }

        [Required]
        [MaxLength(120)]
        public string Address1 { get; set; }

        [Required]
        [MaxLength(120)]
        public string Address2 { get; set; }

        [Required]
        [MaxLength(120)]
        public string Address3 { get; set; }

        [Required]
        [MaxLength(120)]
        public string City { get; set; }

        [Required]
        [MaxLength(10)]
        public string State { get; set; }

        [Required]
        [MaxLength(16)]
        public string ZipCode { get; set; }

        [Required]
        [MaxLength(20)]
        public string Country { get; set; }
    }
}
