using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmaHub.Shared.Domain
{
    public class Delivery : BaseDomainModel
    {
        public DateTime DeliveryDate { get; set; }
        public string? DeliveryStatus { get; set; }
        public string? DeliveryAddress { get; set; }
        public int OrderID { get; set; }
        public virtual Order? Order { get; set; }
    }
}
