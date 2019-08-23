using DXC.LM.Core.ReferenceDataAPI.Endpoints.EntityModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace DXC.LM.Core.ReferenceDataAPI.Endpoints.Db
{
    public class DesignTime : IDesignTimeDbContextFactory<ReferenceDataDbContext>
    {
        private const string LocalDbConnectionString = @"Server=(local); Database=ReferenceData;Trusted_Connection=True;";

        public ReferenceDataDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<ReferenceDataDbContext>();
            builder.UseSqlServer(LocalDbConnectionString);
            return new ReferenceDataDbContext(builder.Options);
        }
    }
}
