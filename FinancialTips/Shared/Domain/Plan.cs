using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialTips.Shared.Domain
{
    public class Plan : BaseDomainModel
    {
        public string PlanName { get; set; }
        public int PlanPeriod { get; set; }
        public int AverageROI { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Instrument Instrument { get; set; }
        public virtual Preference Preference { get; set; }
        public virtual List<Consultation> Consultations { get; set; }
        public int? CustomerID { get; set; }
        public int? InstrumentID { get; set; }
        public int? PreferenceID { get; set; }
        public int MyProperty { get; set; }

    }
}
