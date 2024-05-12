using AutoMapper;
using Cinema.BLL.Interfaces;
using Cinema.BLL.MapperProfiles.Halls;
using Cinema.BLL.MapperProfiles.Movies;
using Cinema.BLL.Services.Halls;
using Cinema.BLL.Services.Movies;
using Cinema.DAL;
using Cinema.DAL.Interfaces.Halls;
using Cinema.DAL.Interfaces.Movies;
using Cinema.DAL.Repositories.Halls;
using Cinema.DAL.Repositories.Movies;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Cinema.DAL.Entities;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Cinema.BLL.MapperProfiles.Actors;
using Cinema.BLL.MapperProfiles.Genres;
using Cinema.BLL.Services.Account;
using Microsoft.OpenApi.Models;
using Cinema.BLL.MapperProfiles.Directors;
using Cinema.DAL.Interfaces.Directors;
using Cinema.DAL.Repositories.Directors;
using Cinema.BLL.Services.Directors;
using Cinema.BLL.Services.Actors;
using Cinema.DAL.Interfaces.Actors;
using Cinema.DAL.Repositories.Actors;
using Cinema.BLL.MapperProfiles.Actors;
using Cinema.DAL.Interfaces.Genres;
using Cinema.DAL.Repositories.Genres;
using Cinema.BLL.Services.Genres;
using Cinema.BLL.MapperProfiles.Genres;

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

    public static async void CreateRoles(this WebApplication application)
    {
        var serviceProvider = application.Services.CreateScope().ServiceProvider;
        var RoleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole<Guid>>>();
        var UserManager = serviceProvider.GetRequiredService<UserManager<AspNetUser>>();
        string[] roleNames = { "Admin", "SuperAdmin", "User" };
        IdentityResult roleResult;

        foreach (var roleName in roleNames)
        {
            var roleExist = await RoleManager.RoleExistsAsync(roleName);
            if (!roleExist)
            {
                roleResult = await RoleManager.CreateAsync(new IdentityRole<Guid>(roleName));
            }
        }
        
        var superAdmin = new AspNetUser
        {
            UserName = application.Configuration["AppSuperAdmin:Name"],
            Email = application.Configuration["AppSuperAdmin:Email"],
        };
        string superAdminPassword = application.Configuration["AppSuperAdmin:Password"]!;
        var _user = await UserManager.FindByEmailAsync(application.Configuration["AppSuperAdmin:Email"]!);

        if (_user == null)
        {
            var createSuperAdmin = await UserManager.CreateAsync(superAdmin, superAdminPassword);
            if (createSuperAdmin.Succeeded)
            {
                await UserManager.AddToRoleAsync(superAdmin, "SuperAdmin");
            }
        }
    }

    public static void AddTokenInSwagger(this IServiceCollection services)
    {

        services.AddSwaggerGen(setup =>
        {
            var jwtSecurityScheme = new OpenApiSecurityScheme
            {
                BearerFormat = "JWT",
                Name = "JWT Authentication",
                In = ParameterLocation.Header,
                Type = SecuritySchemeType.Http,
                Scheme = JwtBearerDefaults.AuthenticationScheme,
                Description = "Put **_ONLY_** your JWT Bearer token on textbox below!",

                Reference = new OpenApiReference
                {
                    Id = JwtBearerDefaults.AuthenticationScheme,
                    Type = ReferenceType.SecurityScheme
                }
            };

            setup.AddSecurityDefinition(jwtSecurityScheme.Reference.Id, jwtSecurityScheme);

            setup.AddSecurityRequirement(new OpenApiSecurityRequirement
            {
                {
                    jwtSecurityScheme, Array.Empty<string>() 
                }
            });

        });
    }

    public static void AddAutoMapper(this IServiceCollection services)
    {
        var mapperConfig = new MapperConfiguration(mc =>
        {
            mc.AddProfile(new MoviesProfile());
            mc.AddProfile(new HallsProfile());
            mc.AddProfile(new DirectorsProfile());
            mc.AddProfile(new GenresProfile());
            mc.AddProfile(new ActorsProfile());
        });

        var mapper = mapperConfig.CreateMapper();
        services.AddSingleton(mapper);
    }

    public static void AddRepositories(this IServiceCollection services)
    {
        services.AddScoped<IMoviesRepository, MoviesRepository>();
        services.AddScoped<IMoviesActorsRepository, MoviesActorsRepository>();
        services.AddScoped<IMoviesGenresRepository, MoviesGenresRepository>();
        services.AddScoped<IHallsRepository, HallsRepository>();
        services.AddScoped<IDirectorsRepository, DirectorsRepository>();
        services.AddScoped<IActorsRepository, ActorsRepository>();
        services.AddScoped<IGenresRepository, GenresRepository>();
    }

    public static void AddServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddTransient<IMoviesService, MoviesService>();
        services.AddTransient<IAccountService, AccountService>();
        services.AddTransient<IHallsService, HallsService>();
        services.AddTransient<IDirectorsService, DirectorsService>();
        services.AddTransient<IActorsService, ActorsService>();
        services.AddTransient<IGenresService, GenresService>();
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