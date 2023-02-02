using System;

namespace FinancialTips.Shared.Domain
{
    public class Consultation : BaseDomainModel
    {
        public DateTime ConsultDate { get; set; }
        public string ConsultReport { get; set; }
        public int PlanId { get; set; }
        public virtual Plan Plan  { get; set; }
        public int CustomerID { get; set; }
        public virtual Customer Customer { get; set; }


    }
}