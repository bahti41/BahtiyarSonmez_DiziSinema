using DiziSinema.Business.Absract;
using DiziSinema.Business.Concrete;
using DiziSinema.Data.Abstract;
using DiziSinema.Data.Concrete.Context;
using DiziSinema.Data.Concrete.Repositories;
using Microsoft.EntityFrameworkCore;
using DiziSinema.Shared.Helpers.Abstract;
using DiziSinema.Shared.Helpers.Concrete;
using DiziSinema.Entity.Concrete.Identity;
using Microsoft.AspNetCore.Identity;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();


builder.Services.AddDbContext<DiziSinemaDbContext>(option => option.UseSqlite(builder.Configuration.GetConnectionString("SqliteConnectiom")));


builder.Services.AddIdentity<User, Role>()
    .AddEntityFrameworkStores<DiziSinemaDbContext>()
    .AddDefaultTokenProviders();

builder.Services.Configure<IdentityOptions>(option =>
{
    #region Parola Ýþlemleri
    option.Password.RequiredLength = 6;
    option.Password.RequireDigit = true;
    option.Password.RequireNonAlphanumeric = true;
    option.Password.RequireUppercase = true;
    option.Password.RequireLowercase = true;
    #endregion

    #region Hesap Kitleme
    option.Lockout.MaxFailedAccessAttempts = 3;
    option.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromSeconds(15);
    #endregion

    option.User.RequireUniqueEmail = true;
});

builder.Services.ConfigureApplicationCookie(options =>
{
    options.LoginPath = "/Account/Login";
    options.LogoutPath = "/";
    options.AccessDeniedPath = "/Account/AccessDenied";
    options.ExpireTimeSpan = TimeSpan.FromDays(20);
    options.SlidingExpiration = true;
    options.Cookie = new CookieBuilder
    {
        Name = "DiziSinema.Security.Cookie",
        HttpOnly = true,
        SameSite = SameSiteMode.Strict
    };
});








builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

builder.Services.AddScoped<IGenreRepository, GenreRepoitory>();
builder.Services.AddScoped<IMovieRepository, MovieRepository>();
builder.Services.AddScoped<ISerialTvRepository, SerialTvRepository>();

builder.Services.AddScoped<IGenreService, GenreManager>();
builder.Services.AddScoped<IMovieService, MovieManager>();
builder.Services.AddScoped<ISerialTvSevice, SerialTvManager>();

builder.Services.AddScoped<IImageHelper, ImageHelper>();



builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseAuthorization();

app.MapControllers();

app.Run();
