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
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();


builder.Services.AddDbContext<DiziSinemaDbContext>(option => option.UseSqlite(builder.Configuration.GetConnectionString("SqliteConnectiom")));


builder.Services.AddIdentity<User, Role>()
    .AddEntityFrameworkStores<DiziSinemaDbContext>();

builder.Services.Configure<IdentityOptions>(options =>
{
    #region Parola Ayarlarý
    options.Password.RequiredLength = 6; 
    options.Password.RequireDigit = true; 
    options.Password.RequireNonAlphanumeric = true;
    options.Password.RequireUppercase = true; 
    options.Password.RequireLowercase = true; 
    #endregion

    #region Hesap Kilitleme Ayarlarý
    options.Lockout.MaxFailedAccessAttempts = 3;
    options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromSeconds(15);
    #endregion

    options.User.RequireUniqueEmail = true;
    options.SignIn.RequireConfirmedEmail = false;
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

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
