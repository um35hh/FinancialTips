using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialTips.Shared.Domain
{
    public class Preference : BaseDomainModel
    {
        public int InvestAmount { get; set; }
        public int RiskMinMax { get; set; }
        public int CommitmentPeriod { get; set; }
        public int AverageIncome { get; set; }
    }
}
