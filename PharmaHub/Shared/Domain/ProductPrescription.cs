using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmaHub.Shared.Domain
{
    public class ProductPrescription : BaseDomainModel
    {
        public int ProductID { get; set; }
        public virtual Product? Product { get; set; }
        public int PrescID { get; set; }
        public virtual Prescription? Prescription { get; set; }
    }
}