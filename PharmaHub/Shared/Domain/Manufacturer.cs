using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmaHub.Shared.Domain
{
    public class Manufacturer : BaseDomainModel
    {
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Country { get; set; }
        public string? Contact { get; set; }
    }
}
