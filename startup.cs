using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

public class Startup
{
    public Startup(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    public IConfiguration Configuration { get; }
    private readonly string _policyName = "CorsPolicy";

    public void ConfigureServices(IServiceCollection services)
    {
        services.AddCors(opt =>
        {
            opt.AddPolicy(name: _policyName, builder =>
            {
                builder.AllowAnyOrigin()
                    .AllowAnyHeader()
                    .AllowAnyMethod();
            });
        });
    }

    public void Configure(IApplicationBuilder app) { 
   
        app.UseCors(_policyName);

    }
}