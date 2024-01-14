using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmaHub.Shared.Domain
{
    public class Payment : BaseDomainModel
    {
        public decimal PaymentAmount { get; set; }
        public DateTime PaymentDate { get; set; }
        public List<PaymentMethod>? PaymentMethod { get; set; }
    }
}
