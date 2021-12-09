using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace VidMob.Models
{
    public class Resource
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Comment { get; set; }
        public string Url { get; set; }
        public bool IsFolder { get; set; }
        [Required]
        public Project Project { get; set; }
        public Resource Parent { get; set; }
        [Required]
        public Person Owner { get; set; }
        public bool ClientAccess { get; set; }
        public IEnumerable<Resource> Children { get; set; }
        public IFormFile Asset { get; set; }
        public long ResourceSize { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }
    }
}