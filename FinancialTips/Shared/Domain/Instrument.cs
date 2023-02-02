using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialTips.Shared.Domain
{
    public class Instrument : BaseDomainModel
    {
        public string InstrumentName { get; set; }
        public string InstrumentDescription { get; set; }
    }
}
