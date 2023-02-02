using FinancialTips.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinancialTips.Server.Configurations.Entities
{
    public class PreferenceSeedConfiguration : IEntityTypeConfiguration<Preference>
    {
        public void Configure(EntityTypeBuilder<Preference> builder)
        {
            builder.HasData(
                new Preference
                {
                    Id = 1,
                    InvestAmount = 10000,
                    RiskMinMax=30,
                    CommitmentPeriod=36,
                    AverageIncome=4750000,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Preference
                {
                    Id = 2,
                    InvestAmount = 350000,
                    RiskMinMax =50,
                    CommitmentPeriod = 6,
                    AverageIncome = 1750000,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },

                new Preference
                {
                    Id = 3,
                    InvestAmount = 670000,
                    RiskMinMax =60,
                    CommitmentPeriod = 3,
                    AverageIncome = 6750000,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },

                new Preference
                {
                    Id = 4,
                    InvestAmount = 550000,
                    RiskMinMax =40,
                    CommitmentPeriod = 7,
                    AverageIncome = 3750000,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Preference
                {
                    Id = 5,
                    InvestAmount = 675000,
                    RiskMinMax =70,
                    CommitmentPeriod = 10,
                    AverageIncome = 1100000,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                }
);


           // throw new NotImplementedException();
        }
    }
}
