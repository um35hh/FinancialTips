using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinancialTips.Client.Static
{
    public static class Endpoints
    {
        private static readonly string Prefix = "api";

        public static readonly string InstrumentsEndpoint = $"{Prefix}/instruments";
        public static readonly string PreferencesEndpoint = $"{Prefix}/preferences";
        public static readonly string PlansEndpoint = $"{Prefix}/plans";
        public static readonly string ConsultationsEndpoint = $"{Prefix}/consultations";
        public static readonly string CustomersEndpoint = $"{Prefix}/customers";




    }
}
