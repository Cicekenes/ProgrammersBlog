using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ProgrammersBlog.Data.Abstract;
using ProgrammersBlog.Data.Concrete;
using ProgrammersBlog.Data.Concrete.EntityFramework.Contexts;
using ProgrammersBlog.Entities.Concrete;
using ProgrammersBlog.Services.Abstract;
using ProgrammersBlog.Services.Concrete;
using System.Reflection;

namespace ProgrammersBlog.Services.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection LoadMyServices(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<ProgrammersBlogContext>(options => options.UseSqlServer(connectionString).UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking));
            services.AddIdentity<User, Role>(options =>
            {
                //User password options
                options.Password.RequireDigit = false; //şifremizde rakam bulunmalı mı?
                options.Password.RequiredLength = 5; // en az kaç karakter olmalı ?
                options.Password.RequiredUniqueChars = 0;  //Unique karakterden kaç tane bulunmalı?
                options.Password.RequireNonAlphanumeric = false; // @!$ gibi kullanılmasını sağlar. false = zorunlu olmasın.
                options.Password.RequireLowercase = false; //küçük karakter kullanımı zorunlu mu?
                options.Password.RequireUppercase = false; //büyük karakter kullanımı zorunlu mu?

                //User Username and Email options
                options.User.AllowedUserNameCharacters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+$"; //Kullanıcı adı oluştururken izin verilen karakterler
                options.User.RequireUniqueEmail = true; // Tek email adresi bulunsun.

            })
                .AddEntityFrameworkStores<ProgrammersBlogContext>();
            services.Configure<SecurityStampValidatorOptions>(options =>
            {
                options.ValidationInterval = TimeSpan.FromMinutes(15);
            });
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<ICategoryService, CategoryManager>();
            services.AddScoped<IArticleService, ArticleManager>();
            services.AddScoped<ICommentService, CommentManager>();
            services.AddSingleton<IMailService, MailManager>();
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            return services;
        }
    }
}
