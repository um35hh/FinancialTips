using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialTips.Shared.Domain
{
    public class Customer : BaseDomainModel
    {
        public string CustName { get; set; }
        public int CustAge { get; set; }
        public string CustGender { get; set; }
        public int CustContact { get; set; }
        public virtual List<Consultation> Consultations { get; set; }
    }
}
