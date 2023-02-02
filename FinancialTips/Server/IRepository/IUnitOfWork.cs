using FinancialTips.Shared.Domain;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinancialTips.Server.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        Task Save(HttpContext httpContext);
        IGenericRepository<Instrument> Instruments { get; }
        IGenericRepository<Preference> Preferences { get; }
        IGenericRepository<Plan> Plans { get; }
        IGenericRepository<Consultation> Consultations { get; }
        IGenericRepository<Customer> Customers { get; }
    }
}
