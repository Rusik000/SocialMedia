using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SocialProject.Business.Abstract;
using SocialProject.Business.Concrete;
using SocialProject.DataAccess.Abstract;
using SocialProject.DataAccess.Concrete;
using SocialProject.WebUI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialProject.WebUI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            

            services.AddScoped<IChatService, ChatManager>();
            services.AddScoped<IChatDal, EfChatDal>();

            services.AddScoped<ICommentService, CommentManager>();
            services.AddScoped<ICommentDal, EfCommentDal>();

            services.AddScoped<IGroupService, GroupManager>();
            services.AddScoped<IGroupDal, EfGroupDal>();

            services.AddScoped<INotificationService, NotificationManager>();
            services.AddScoped<INotificationDal, EfNotificationDal>();

            services.AddScoped<IPostService, PostManager>();
            services.AddScoped<IPostDal, EfPostDal>();


            services.AddScoped<IStoryService, StoryManager>();
            services.AddScoped<IStoryDal, EfStoryDal>();


            services.AddRazorPages();
            services.AddDbContext<CustomIdentityDbContext>(
                options => options
                .UseSqlServer(@"Data Source=(localdb)\ProjectModels;Initial Catalog=SocialDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"));

            services.AddIdentity<CustomIdentityUser, CustomIdentityRole>()
                .AddEntityFrameworkStores<CustomIdentityDbContext>()
                .AddDefaultTokenProviders();

            

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
            }

            app.UseStaticFiles();

            app.UseRouting();


            app.UseAuthentication();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute("Default", "{controller=Account}/{action=LogIn}/{id?}");
            });
        }
    }
}
