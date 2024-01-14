using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmaHub.Shared.Domain
{
    public class Product : BaseDomainModel
    {
        public string? ProductName { get; set; }
        public string? ProductDescription { get; set; }
        public decimal ProductPrice { get; set;}
        public int ProductQuantity { get; set; }
        public DateTime ProductExpiry { get; set; }
        public int CategoryID { get; set; }
        public virtual ICollection<Category>? Categories { get; set; }
        public int ManuID { get; set; }
        public virtual Manufacturer? Manufacturer { get; set; }
    }
}