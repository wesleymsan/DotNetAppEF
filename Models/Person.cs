using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DotNetAppEF.Models
{
    public class Person
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [MaxLength(50)]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string Email { get; set; }
        
        [Required]
        public int Phone { get; set; }
        
        [Required]
        public int Cell { get; set; }

        [Required]
        public string Address { get; set; }
    }
}
