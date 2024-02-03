using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmaHub.Shared.Domain
{
    public class Staff : BaseDomainModel
    {
        public string? StaffName { get; set; }
        public string? StaffEmail { get; set; }
        public string? StaffPosition { get; set; }
        public string? StaffContact { get; set; }
    }
}
