using FunctionalApi.Data;
using Microsoft.EntityFrameworkCore;

namespace FunctionalApi.Configurations;

public static class DbContextConfig
{
    public static WebApplicationBuilder AddDbContextConfig(this WebApplicationBuilder builder)
    {
        builder.Services.AddDbContext<ApiDbContext>(options =>
            {
                options.UseSqlServer(
                    builder
                        .Configuration
                        .GetConnectionString("DefaultConnection")
                );
            }
        );


        return builder;
    }
}
