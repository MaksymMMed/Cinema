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
            mc.AddProfile(new HallsProfile());
        });

        var mapper = mapperConfig.CreateMapper();
        services.AddSingleton(mapper);
    }

    public static void AddRepositories(this IServiceCollection services)
    {
        services.AddScoped<IMoviesRepository, MoviesRepository>();
        services.AddScoped<IHallsRepository, HallsRepository>();
    }

    public static void AddServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddTransient<IMoviesService, MoviesService>();
        services.AddTransient<IHallsService, HallsService>();
    } 
}