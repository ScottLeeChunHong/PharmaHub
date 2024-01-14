using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmaHub.Shared.Domain
{
    public class Staff : BaseDomainModel
    {
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Position { get; set; }
        public string? Contact { get; set; }
    }
}
