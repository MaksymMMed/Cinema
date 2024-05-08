using AutoMapper;
using Cinema.BLL.Interfaces;
using Cinema.BLL.MapperProfiles.Movies;
using Cinema.BLL.Services.Movies;
using Cinema.DAL;
using Cinema.DAL.Interfaces.Movies;
using Cinema.DAL.Repositories.Movies;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Cinema.DAL.Entities;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Cinema.BLL.Services.Account;

namespace Cinema.API.Extensions;

public static class ServiceCollectionExtensions
{
    public static void AddDbContext(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<AppDbContext>(
            optionsAction: (serviceProvider, options) => 
                options.UseSqlServer(configuration.GetConnectionString("MainBase")),
            contextLifetime: ServiceLifetime.Transient,
            optionsLifetime: ServiceLifetime.Scoped);
    }

    public static void AddAutoMapper(this IServiceCollection services)
    {
        // services.AddAutoMapper(typeof(MoviesProfile));
        var mapperConfig = new MapperConfiguration(mc =>
        {
            mc.AddProfile(new MoviesProfile());
        });

        var mapper = mapperConfig.CreateMapper();
        services.AddSingleton(mapper);
    }

    public static void AddRepositories(this IServiceCollection services)
    {
        services.AddScoped<IMoviesRepository, MoviesRepository>();
    }

    public static void AddServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddTransient<IMoviesService, MoviesService>();
        services.AddTransient<IAccountService, AccountService>();
    } 

    public static void AddIdentity(this IServiceCollection services)
    {
        services.AddIdentity<AspNetUser, IdentityRole<Guid>>()
        .AddEntityFrameworkStores<AppDbContext>()
        .AddDefaultTokenProviders();
    }
    public static void AddJwtAuthentication(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddAuthentication(options =>
        {
            options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
            options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
        })
        .AddJwtBearer(options =>
        {
            options.SaveToken = true;
            options.RequireHttpsMetadata = false;
            options.TokenValidationParameters = new TokenValidationParameters()
            {
                ValidateIssuer = true,
                ValidateAudience = true,
                ValidAudience = configuration["Jwt:Audience"],
                ValidIssuer = configuration["Jwt:Issuer"],
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["Jwt:Key"]!))
            };
        });
    }
}