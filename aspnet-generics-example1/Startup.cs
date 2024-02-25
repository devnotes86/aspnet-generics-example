using Microsoft.AspNetCore.Cors.Infrastructure;
using Services;

namespace aspnet_generics_example1
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            this.Configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy("AllowAll", p => p.AllowAnyOrigin()
                                                    .AllowAnyMethod()
                                                    .AllowAnyHeader()); 
            });

        
            // Add framework services.
            services.AddRouting();

            services.AddMvc();
             
            ConfigureAdditionalServices(services);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(
            IApplicationBuilder app,
            IWebHostEnvironment env)
        {

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();
            app.UseRouting();
            app.UseWebSockets();
            app.UseCors();


             
        }

        private static void ConfigureAdditionalServices(IServiceCollection services)
        {
            services.AddTransient<IVehiclesService, VehiclesService>();
           


        }
    }
}
