using MeetUp.DAL;
using Microsoft.EntityFrameworkCore;

namespace MeetUp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<MeetUpContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("Default")));
            var app = builder.Build();

            app.MapControllerRoute(name: "areas",pattern: "{area:exists}/{controller=Categories}/{action=Index}/{id?}");
            app.MapControllerRoute(name: "default",pattern: "{controller=Home}/{action=Index}/{id?}");
            app.UseStaticFiles();

            app.Run();
        }
    }
}
