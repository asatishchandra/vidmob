using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VidMob.Models
{
    public class Statistics
    {
        public Project Project;
        public IEnumerable<Person> Persons { get; set; }
        public IEnumerable<Resource> Resources { get; set; }
        public int TotalProjectSize { get; set; }
        public Dictionary<Person, FileCountStorageByPerson> FileCountStorageByPerson { get; set; }
    }

    public class FileCountStorageByPerson
    {
        public int FileCount { get; set; }
        public int TotalStorage { get; set; }
    }
}
