using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmaHub.Shared.Domain
{
    public class Prescription : BaseDomainModel
    {
        public DateTime PrescIssueDate { get; set; }
        public DateTime PrescExpiryDate { get; set;}
        public int CustID { get; set; }
        public virtual Customer? Customer { get; set; }
        public int StaffID { get; set; }
        public virtual Staff? Staff { get; set; }
    }
}
