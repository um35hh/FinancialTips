using FinancialTips.Server.Data;
using FinancialTips.Server.IRepository;
using FinancialTips.Server.Models;
using FinancialTips.Shared.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinancialTips.Server.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        private IGenericRepository<Instrument> _instruments;
        private IGenericRepository<Preference> _preferences;
        private IGenericRepository<Consultation> _consultations;
        private IGenericRepository<Customer> _customers;
        private IGenericRepository<Plan> _plans;

        private UserManager<ApplicationUser> _userManager;

        public UnitOfWork(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public IGenericRepository<Preference> Preferences
            => _preferences ??= new GenericRepository<Preference>(_context);
        public IGenericRepository<Instrument> Instruments
            => _instruments ??= new GenericRepository<Instrument>(_context);
        
        public IGenericRepository<Plan> Plans
            => _plans ??= new GenericRepository<Plan>(_context);
        public IGenericRepository<Consultation> Consultations
            => _consultations ??= new GenericRepository<Consultation>(_context);
        public IGenericRepository<Customer> Customers
            => _customers ??= new GenericRepository<Customer>(_context);

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }

        public async Task Save(HttpContext httpContext)
        {
            //To be implemented
            string user = "System";

            var entries = _context.ChangeTracker.Entries()
                .Where(q => q.State == EntityState.Modified ||
                    q.State == EntityState.Added);

            foreach (var entry in entries)
            {
                ((BaseDomainModel)entry.Entity).DateUpdated = DateTime.Now;
                ((BaseDomainModel)entry.Entity).UpdatedBy = user;
                if (entry.State == EntityState.Added)
                {
                    ((BaseDomainModel)entry.Entity).DateCreated = DateTime.Now;
                    ((BaseDomainModel)entry.Entity).CreatedBy = user;
                }
            }

            await _context.SaveChangesAsync();
        }
    }
}
