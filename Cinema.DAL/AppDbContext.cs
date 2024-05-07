using Cinema.DAL.Configurations;
using Cinema.DAL.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Cinema.DAL
{
    public class AppDbContext : IdentityDbContext<AspNetUser, IdentityRole<Guid>, Guid>
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Actor> Actor { get; set; }
        public DbSet<ActorMovie> ActorMovie { get; set; }
        public DbSet<Director> Director{ get; set; }
        public DbSet<Genre> Genre { get; set; }
        public DbSet<Hall> Hall { get; set; }
        public DbSet<Invoice> Invoice { get; set; }
        public DbSet<Movie> Movie { get; set; }
        public DbSet<MovieGenre> MovieGenre { get; set; }
        public DbSet<MovieImageSet> MovieImageSet { get; set; }
        public DbSet<Review> Review { get; set; }
        public DbSet<Session> Session { get; set; }
        public DbSet<Ticket> Ticket { get; set; }
        public DbSet<AspNetUser> AspNetUsers { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new ActorsConfiguration());
            builder.ApplyConfiguration(new ActorsMoviesConfiguration());
            builder.ApplyConfiguration(new DirectorsConfiguration());
            builder.ApplyConfiguration(new GenresConfiguration());
            builder.ApplyConfiguration(new HallsConfiguration());
            builder.ApplyConfiguration(new InvoicesConfiguration());
            builder.ApplyConfiguration(new MoviesConfiguration());
            builder.ApplyConfiguration(new MoviesGenresConfiguration());
            builder.ApplyConfiguration(new MoviesImageSetsConfiguration());
            builder.ApplyConfiguration(new ReviewsConfiguration());
            builder.ApplyConfiguration(new SessionsConfiguration());
            builder.ApplyConfiguration(new TicketsConfiguration());
            builder.ApplyConfiguration(new UsersConfiguration());
        }
    }
}
