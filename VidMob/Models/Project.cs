using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VidMob.Models
{
    public class Project
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public Person CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public Person ModifiedBy { get; set; }
        public DateTime? ModifiedAt { get; set; }
    }
}
