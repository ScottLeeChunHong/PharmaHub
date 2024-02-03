using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmaHub.Shared.Domain
{
    public class Manufacturer : BaseDomainModel
    {
        public string? ManuName { get; set; }
        public string? ManuEmail { get; set; }
        public string? ManuCountry { get; set; }
        public string? ManuContact { get; set; }
    }
}
