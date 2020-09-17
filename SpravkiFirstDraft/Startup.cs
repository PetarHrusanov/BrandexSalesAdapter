namespace SpravkiFirstDraft
{

    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Hosting;
    using SpravkiFirstDraft.Data;
    using SpravkiFirstDraft.Services;
    using SpravkiFirstDraft.Services.Cities;
    using SpravkiFirstDraft.Services.Companies;
    using SpravkiFirstDraft.Services.Distributor;
    using SpravkiFirstDraft.Services.Pharmacies;
    using SpravkiFirstDraft.Services.PharmacyChains;
    using SpravkiFirstDraft.Services.Products;
    using SpravkiFirstDraft.Services.Regions;
    using SpravkiFirstDraft.Services.Sales;

    public class Startup
    {
        private readonly IConfiguration configuration;

        public Startup(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<SpravkiDbContext>(
               options => options.UseSqlServer(this.configuration.GetConnectionString("DefaultConnection")));

            services
                .AddTransient<ISalesService, SalesService>()
                .AddTransient<IProductsService, ProductsService>()
                .AddTransient<IPharmaciesService, PharmaciesService>()
                .AddTransient<IDistributorService, DistributorService>()
                .AddTransient<ICitiesService, CitiesService>()
                .AddTransient<ICompaniesService, CompaniesService>()
                .AddTransient<IPharmacyChainsService, PharmacyChainsService>()
                .AddTransient<IRegionsService, RegionsService>()
                .AddTransient<INumbersChecker, NumbersChecker>();

            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            using (var serviceScope = app.ApplicationServices.CreateScope())
            {
                var dbContext = serviceScope.ServiceProvider.GetRequiredService<SpravkiDbContext>();

                if (env.IsDevelopment())
                {
                    dbContext.Database.Migrate();
                }

                //new ApplicationDbContextSeeder().SeedAsync(dbContext, serviceScope.ServiceProvider).GetAwaiter().GetResult();

                 else
                {
                    app.UseExceptionHandler("/Home/Error");
                    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                    app.UseHsts();
                }
            }
           
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
