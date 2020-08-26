using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ToDo.Business.Concrete;
using ToDo.Business.Interfaces;
using ToDo.DataAccess.Concrete.EntityFrameworkCore.Contexts;
using ToDo.DataAccess.Concrete.EntityFrameworkCore.Repositories;
using ToDo.DataAccess.Interfaces;
using ToDo.Entities.Concrete;

namespace ToDo.WebUI
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            // TODO: Create a Middleware for these configurations.

            services.AddControllersWithViews();
            services.AddScoped<ITaskService, TaskManager>();
            services.AddScoped<IReportService, ReportManager>();
            services.AddScoped<IPriorityService, PriorityManager>();

            services.AddScoped<ITaskDal, EfTaskRepository>();
            services.AddScoped<IReportDal, EfReportRepository>();
            services.AddScoped<IPriorityDal, EfPriorityRepository>();

            services.AddDbContext<ToDoContext>();
            services.AddIdentity<AppUser, AppRole>().AddEntityFrameworkStores<ToDoContext>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();
            app.UseStaticFiles();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapDefaultControllerRoute();
            });
        }
    }
}
