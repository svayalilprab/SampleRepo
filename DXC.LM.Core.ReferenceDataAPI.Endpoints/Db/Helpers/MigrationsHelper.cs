using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace DXC.LM.Core.ReferenceDataAPI.Endpoints.Db.Helpers
{
    public static class MigrationsHelper
    {
        public static void EnsureMigrationOfContext<T>(this IApplicationBuilder app)
            where T : DbContext
        {
            using (var serviceScope = app.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<T>();
                context.Database.Migrate();
            }
        }
    }
}
