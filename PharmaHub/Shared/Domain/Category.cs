using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmaHub.Shared.Domain
{
    public class Category : BaseDomainModel
    {
        public string? CatName { get; set; }
        public string? CatDescription { get; set; }
    }
}
