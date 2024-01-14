using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmaHub.Shared.Domain
{
    public class PaymentMethod : BaseDomainModel
    {
        public string? MethodName { get; set; }
    }
}