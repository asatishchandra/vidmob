using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace VidMob.Models
{
    public class Person
    {
        public int Id { get; set; }
        public IEnumerable<Project> Projects { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public Enum Role { get; set; }
    }

    public enum Roles
    {
        Client = 1,
        ProjectAdmin = 2,
        Creator = 3
    }
}
