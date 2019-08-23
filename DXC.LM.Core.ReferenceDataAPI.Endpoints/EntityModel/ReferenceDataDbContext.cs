using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using DXC.LM.Core.ReferenceDataAPI.Endpoints.EntityModel.SeedData;

namespace DXC.LM.Core.ReferenceDataAPI.Endpoints.EntityModel
{
    using Microsoft.EntityFrameworkCore;
    
    /// <summary>
    /// </summary>
    public class ReferenceDataDbContext : DbContext
    {
        /// <summary>
        /// </summary>
        public ReferenceDataDbContext( )
            : base( )
        { }
        
        /// <summary>
        /// </summary>
        /// <param name="dbContextOptions"></param>
        public ReferenceDataDbContext(DbContextOptions<ReferenceDataDbContext> dbContextOptions)
            : base(dbContextOptions)
        { }


        /// <summary>
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var item = modelBuilder.Entity<ReferenceDataItem>();
                item.ToTable("ReferenceDataItems");
                item.HasKey(e => e.ID);

                item.HasData(
                    new ReferenceDataItemCsvImport(@"./EntityModel/SeedData/Csv/ReferenceDataItem.csv").GetRecords()
                );

            var claimsCurrency = modelBuilder.Entity<ClaimsCurrency>();
            claimsCurrency.ToTable("ClaimsCurrencies");
            claimsCurrency.HasKey(e => e.ID);

            claimsCurrency.HasData(
                new ClaimsCurrencyCsvImport(@"./EntityModel/SeedData/Csv/ClaimsCurrencies.csv").GetRecords()
            );

            var claimsValueOfLossNK = modelBuilder.Entity<ClaimsValueOfLossNotKnown>();
            claimsValueOfLossNK.ToTable("ClaimsValueOfLossNK");
            claimsValueOfLossNK.HasKey(e => e.ID);

            claimsValueOfLossNK.HasData(
                new ClaimsValueOfLossNKImport(@"./EntityModel/SeedData/Csv/ClaimsValueOfLoss.csv").GetRecords()
            );

        }

        /// <summary>
        /// </summary>
        public DbSet<ReferenceDataItem> ReferenceDataItems { get; set; }

        /// <summary>
        /// </summary>
        public DbSet<ClaimsCurrency> ClaimsCurrencies { get; set; }

        /// <summary>
        /// </summary>
        public DbSet<ClaimsValueOfLossNotKnown> ClaimsValueOfLossNotKnown { get; set; }

    }
}
