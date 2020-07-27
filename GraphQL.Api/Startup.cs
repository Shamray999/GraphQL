using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQL.Api.GraphQL;
using GraphQL.Api.Repository;
using GraphQL.Server;
using GraphQL.Server.Ui.Playground;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Server.Kestrel.Core;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace GraphQL.Api
{
    public class Startup
    {
        private IConfiguration _configuration;

        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<LogRepository>();

            services.AddScoped<IDependencyResolver>(s => new FuncDependencyResolver(
                s.GetRequiredService));

            services.AddScoped<AuditLogSchema>();

            services.AddGraphQL(o => o.ExposeExceptions = true)
                .AddGraphTypes(ServiceLifetime.Scoped);

            // If dev
            services.Configure<KestrelServerOptions>(options => options.AllowSynchronousIO = true);
            services.Configure<IISServerOptions>(options => options.AllowSynchronousIO = true);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseGraphQL<AuditLogSchema>();
            app.UseGraphQLPlayground(new GraphQLPlaygroundOptions());
        }
    }
}
