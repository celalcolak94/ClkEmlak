using ClkEmlak.BusinessLayer.Abstract;
using ClkEmlak.BusinessLayer.Concrete;
using ClkEmlak.DataAccessLayer.Abstract;
using ClkEmlak.DataAccessLayer.Concrete;
using ClkEmlak.DataAccessLayer.EntityFramework;
using ClkEmlak.EntityLayer.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Authorization;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ClkContext>();
builder.Services.AddIdentity<AppUser,AppRole>().AddEntityFrameworkStores<ClkContext>();
var requireAuthorizePolicy = new AuthorizationPolicyBuilder().RequireAuthenticatedUser().Build();

builder.Services.AddControllersWithViews(opt =>
{
    opt.Filters.Add(new AuthorizeFilter(requireAuthorizePolicy));
});
builder.Services.ConfigureApplicationCookie(opt =>
{
    opt.LoginPath = "/Login/Index/";
});

builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());

builder.Services.AddScoped<ICategoryService, CategoryManager>();
builder.Services.AddScoped<ICategoryDal, EfCategoryDal>();

builder.Services.AddScoped<IEstateService, EstateManager>();
builder.Services.AddScoped<IEstateDal, EfEstateDal>();

builder.Services.AddScoped<IContactService, ContactManager>();
builder.Services.AddScoped<IContactDal, EfContactDal>();

builder.Services.AddScoped<IMessageService, MessageManager>();
builder.Services.AddScoped<IMessageDal, EfMessageDal>();

builder.Services.AddScoped<ISocialMediaService, SocialMediaManager>();
builder.Services.AddScoped<ISocialMediaDal, EfSocialMediaDal>();

builder.Services.AddScoped<IImageService, ImageManager>();
builder.Services.AddScoped<IImageDal, EfImageDal>();

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
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
    name: "areas",
    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
