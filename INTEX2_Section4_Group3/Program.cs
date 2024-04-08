using INTEX2_Section4_Group3.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using INTEX2_Section4_Group3.Areas.Identity.Data;
using INTEX2_Section4_Group3.Models;

namespace INTEX2_Section4_Group3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
            var identityConnectionString = builder.Configuration.GetConnectionString("IdentityConnection");

            builder.Services.AddDbContext<LegoInfoContext>(options =>
                options.UseSqlite(connectionString));

            // This line configures the INTEX2_Section4_Group3IdentityDbContext to use the IdentityConnection
            builder.Services.AddDbContext<INTEX2_Section4_Group3IdentityDbContext>(options =>
                options.UseSqlite(identityConnectionString)); // Assuming you are using SQL Server for the Identity

            builder.Services.AddDatabaseDeveloperPageExceptionFilter();

            builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                   .AddEntityFrameworkStores<INTEX2_Section4_Group3IdentityDbContext>();

            builder.Services.AddControllersWithViews();

            var services = builder.Services;
            var configuration = builder.Configuration;

            services.AddAuthentication().AddGoogle(googleOptions =>
            {
                googleOptions.ClientId = configuration["Authentication__Google__ClientId"];
                googleOptions.ClientSecret = configuration["Authentication__Google__ClientSecret"];
            });

            var app = builder.Build();

            // Configure the HTTP request pipeline.s
            if (app.Environment.IsDevelopment())
            {
                app.UseMigrationsEndPoint();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
            app.MapRazorPages();

            app.Run();
        }
    }
}
