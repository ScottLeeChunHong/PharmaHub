using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmaHub.Shared.Domain
{
    public class Order : BaseDomainModel
    {
        public DateTime OrderDate { get; set; }
        public string? OrderStatus { get; set; }
        public decimal TotalAmount { get; set; }
        public int CustId { get; set; }
        public virtual  Customer? Customer { get; set; }
        public int StaffID { get; set; }
        public virtual Staff? Staff { get; set; }
    }
}
