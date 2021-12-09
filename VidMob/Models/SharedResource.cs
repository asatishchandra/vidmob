using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VidMob.Models
{
    public class SharedResource
    {
        public Resource Resource { get; set; }
        public IEnumerable<Person> Persons { get; set; }
    }
}
