using FinancialTips.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinancialTips.Server.Configurations.Entities
{
    public class InstrumentSeedConfiguration : IEntityTypeConfiguration<Instrument>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Instrument> builder)
        {
            builder.HasData(
                new Instrument
                {
                    Id = 1,
                    InstrumentName = "Equity",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Instrument
                {
                    Id = 2,
                    InstrumentName = "Futures",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },

                new Instrument
                {
                    Id = 3,
                    InstrumentName = "Options",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },

                new Instrument
                {
                    Id = 4,
                    InstrumentName = "Commodities",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Instrument
                {
                    Id = 5,
                    InstrumentName = "Cryptocurrency",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                }
);
            //throw new NotImplementedException();
        }
    }
}
