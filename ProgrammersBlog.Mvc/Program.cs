using AutoMapper;
using NLog;
using NLog.Web;
using ProgrammersBlog.Entities.ComplexTypes;
using ProgrammersBlog.Entities.Concrete;
using ProgrammersBlog.Mvc.AutoMapper;
using ProgrammersBlog.Mvc.Filters;
using ProgrammersBlog.Mvc.Helpers.Abstract;
using ProgrammersBlog.Mvc.Helpers.Concrete;
using ProgrammersBlog.Services.AutoMapper.Profiles;
using ProgrammersBlog.Services.Extensions;
using ProgrammersBlog.Shared.Utilities.Extensions;
using System.Reflection;
using System.Text.Json.Serialization;

//var logger = LogManager.Setup().LoadConfigurationFromAppSettings().GetCurrentClassLogger();

//logger.Debug("init main");

//try
//{

var builder = WebApplication.CreateBuilder(args);

builder.Logging.ClearProviders();
builder.Host.UseNLog();
builder.Host.ConfigureAppConfiguration((hostingContext, config) =>
{
    config.Sources.Clear();
    var env = hostingContext.HostingEnvironment;
    config.AddJsonFile("appsettings.json", optional: true, true)
    .AddJsonFile($"appsettings.{env.EnvironmentName}.json", true, true);
    config.AddEnvironmentVariables();
    if (args != null)
    {
        config.AddCommandLine(args);
    }
});
builder.Services.Configure<AboutUsPageInfo>(builder.Configuration.GetSection("AboutUsPageInfo"));
builder.Services.Configure<WebsiteInfo>(builder.Configuration.GetSection("WebsiteInfo"));
builder.Services.Configure<SmtpSettings>(builder.Configuration.GetSection("SmtpSettings"));
builder.Services.Configure<ArticleRightSideBarWidgetOptions>(builder.Configuration.GetSection("ArticleRightSideBarWidgetOptions"));
builder.Services.ConfigureWritable<AboutUsPageInfo>(builder.Configuration.GetSection("AboutUsPageInfo"));
builder.Services.ConfigureWritable<WebsiteInfo>(builder.Configuration.GetSection("WebsiteInfo"));
builder.Services.ConfigureWritable<SmtpSettings>(builder.Configuration.GetSection("SmtpSettings"));
builder.Services.ConfigureWritable<ArticleRightSideBarWidgetOptions>(builder.Configuration.GetSection("ArticleRightSideBarWidgetOptions"));
// Add services to the container.
builder.Services.AddControllersWithViews(options =>
{
    options.ModelBindingMessageProvider.SetValueMustNotBeNullAccessor(value => "Bu alan boþ geçilmemelidir."); //cannot be null mesajýný oluþturan yapý
    options.Filters.Add<MvcExceptionFilter>();
}).AddRazorRuntimeCompilation().AddJsonOptions(opt =>
{
    opt.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
    opt.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.Preserve;
}).AddNToastNotifyToastr();



builder.Services.AddSession();
//builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());
builder.Services.AddTransient<IImageHelper, ImageHelper>();
builder.Services.AddSingleton(provider=> new MapperConfiguration(cfg=>
{
    cfg.AddProfile(new UserProfile(provider.GetService<IImageHelper>()));
    cfg.AddProfile(new CategoryProfile());
    cfg.AddProfile(new ArticleProfile());
    cfg.AddProfile(new CommentProfile());
    cfg.AddProfile(new ViewModelsProfile());
}).CreateMapper());
builder.Services.LoadMyServices(connectionString: builder.Configuration.GetConnectionString("LocalDB"));
builder.Services.ConfigureApplicationCookie(options =>
{
    options.LoginPath = new PathString("/Admin/Auth/Login");
    options.LogoutPath = new PathString("/Admin/Auth/Logout");
    options.Cookie = new CookieBuilder
    {
        Name = "ProgrammersBlog",
        HttpOnly = true,
        SameSite = SameSiteMode.Strict,
        SecurePolicy = CookieSecurePolicy.SameAsRequest // Always
    };
    options.SlidingExpiration = true;
    options.ExpireTimeSpan = System.TimeSpan.FromDays(7);
    options.AccessDeniedPath = new PathString("/Admin/Auth/AccessDenied");
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseSession();
app.UseStaticFiles();
app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.UseNToastNotify();

app.MapControllerRoute(
    name: "Admin",
    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

app.MapControllerRoute(
    name:"article",
    pattern:"{title}/{articleId}",
    defaults:new {controller="Article",action="Detail"});

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

//}
//catch (Exception ex)
//{
//    logger.Error(ex,"Program bir hata yüzünden durdu");
//    throw;
//}
//finally
//{
//    LogManager.Shutdown();
//}
