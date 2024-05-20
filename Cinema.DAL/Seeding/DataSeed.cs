using Cinema.DAL.Entities;
using Microsoft.AspNetCore.Identity;

namespace Cinema.DAL.Seeding
{
    public static class DataSeed
    {
        public static AspNetUser[] Users { get; set; } = [];
        public static Actor[] Actors { get; set; } = [];
        public static Director[] Directors { get; set; } = [];
        public static Genre[] Genres { get; set; } = [];
        public static MovieImageSet[] MovieImageSets { get; set; } = [];
        public static Movie[] Movies { get; set; } = [];
        public static ActorMovie[] ActorsMovies { get; set; } = [];
        public static MovieGenre[] MoviesGenres { get; set; } = [];
        public static Review[] Reviews { get; set; } = [];
        public static Hall[] Halls { get; set; } = [];
        public static Session[] Sessions { get; set; } = [];
        public static Ticket[] Tickets { get; set; } = [];
        public static Invoice[] Invoices { get; set; } = [];

        static DataSeed()
        {
            SeedUsers();
            SeedActors();
            SeedDirectors();
            SeedGenres();
            SeedMovies();
            SeedMovieImageSets();
            SeedActorsMovies();
            SeedMoviesGenres();
            SeedReviews();
            SeedHalls();
            SeedSessions();
            SeedInvoices();
            SeedTickets();
        }

        private static void SeedUsers()
        {
            var hasherUser = new PasswordHasher<AspNetUser>();
            var user1 = new AspNetUser
            {
                Id = new Guid("88D6040A-130F-43D4-8BEE-1F0074962181"),
                UserName = "admin",
                NormalizedUserName = "ADMIN",
                Email = "admin@example.com",
                NormalizedEmail = "ADMIN@EXAMPLE.COM",
                EmailConfirmed = true
            };
            user1.PasswordHash = hasherUser.HashPassword(user1, "admin");

            var user2 = new AspNetUser
            {
                Id = new Guid("88D6040A-130F-43D4-8BEE-1F0074962182"),
                UserName = "user",
                NormalizedUserName = "USER",
                Email = "user@example.com",
                NormalizedEmail = "USER@EXAMPLE.COM",
                EmailConfirmed = true
            };
            user2.PasswordHash = hasherUser.HashPassword(user2, "user");

            Users =
            [
                user1,
                user2
            ];
        }

        private static void SeedActors()
        {
            Actors =
            [
                new Actor
                {
                    Id = new Guid("BBD5C0D3-A45D-490A-B26D-D503B6A82261"),
                    Name = "Cillian Murphy"
                },
                new Actor
                {
                    Id = new Guid("BBD5C0D3-A45D-490A-B26D-D503B6A82262"),
                    Name = "Emily Blunt"
                },
                new Actor
                {
                    Id = new Guid("BBD5C0D3-A45D-490A-B26D-D503B6A82263"),
                    Name = "Matthew McConaughhey"
                },
                new Actor
                {
                    Id = new Guid("BBD5C0D3-A45D-490A-B26D-D503B6A82264"),
                    Name = "Anne Hathaway"
                }
            ];
        }
        private static void SeedDirectors()
        {
            Directors =
            [
                new Director
                {
                    Id = new Guid("ED9A79D9-FE9D-456E-A0A7-2A028CBE1001"),
                    Name = "Christopher Nolan"
                },
                new Director
                {
                    Id = new Guid("ED9A79D9-FE9D-456E-A0A7-2A028CBE1002"),
                    Name = "Quentin Tarantino"
                },
                new Director
                {
                    Id = new Guid("ED9A79D9-FE9D-456E-A0A7-2A028CBE1003"),
                    Name = "Steven Spielberg"
                }
            ];
        }
        private static void SeedGenres()
        {
            Genres =
            [
                new Genre
                {
                    Id = new Guid("BBD5C0D3-A45D-490A-B26D-D503B6A82261"),
                    Name = "Drama"
                },
                new Genre
                {
                    Id = new Guid("BBD5C0D3-A45D-490A-B26D-D503B6A82262"),
                    Name = "Action"
                },
                new Genre
                {
                    Id = new Guid("BBD5C0D3-A45D-490A-B26D-D503B6A82263"),
                    Name = "Comedy"
                },
                new Genre
                {
                    Id = new Guid("BBD5C0D3-A45D-490A-B26D-D503B6A82264"),
                    Name = "Thriller"
                }
            ];
        }
        private static void SeedMovies()
        {
            Movies =
            [
                new Movie
                {
                    Id = new Guid("9344F562-FFDC-41C5-BB24-C41C969534C1"),
                    DirectorId = Directors[0].Id,
                    Name = "Oppenheimer",
                    Description = "Oppenheimer is a 2023 epic biographical thriller film written, directed, and produced by Christopher Nolan.It follows the life of J. Robert Oppenheimer, the American theoretical physicist who helped develop the first nuclear weapons during World War II. Based on the 2005 biography American Prometheus by Kai Bird and Martin J. Sherwin, the film chronicles Oppenheimer's studies, his direction of the Los Alamos Laboratory, and his fall from grace after his 1954 security hearing. Cillian Murphy stars as Oppenheimer, alongside Robert Downey Jr. as the United States Atomic Energy Commission member Lewis Strauss.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/en/thumb/4/4a/Oppenheimer_%28film%29.jpg/220px-Oppenheimer_%28film%29.jpg",
                    TrailerUrl = "https://www.youtube.com/watch?v=bK6ldnjE3Y0&pp=ygUTb3BwZW5oZWltZXIgdHJhaWxlcg%3D%3D",
                    AgeRestriction = "R",
                    Duration = 180,
                    ReleaseDate = new DateTime(2023, 7, 11),
                },
                new Movie
                {
                    Id = new Guid("9344F562-FFDC-41C5-BB24-C41C969534C2"),
                    DirectorId = Directors[0].Id,
                    Name = "Interstellar",
                    Description = "Interstellar is a 2014 epic science fiction film directed, written, and produced by Christopher Nolan and starring Matthew McConaughey, Anne Hathaway,   Jessica Chastain, Bill Irwin, Ellen Burstyn, Michael Caine, and Matt Damon. Set in a dystopian future where humanity is embroiled in a catastrophic blight and    famine, the film follows a group of astronauts who travel through a wormhole near Saturn in search of a new home for humankind.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/en/b/bc/Interstellar_film_poster.jpg",
                    TrailerUrl = "https://www.youtube.com/watch?v=zSWdZVtXT7E&pp=ygUUaW50ZXJzdGVsbGFyIHRyYWlsZXI%3D",
                    AgeRestriction = "PG-13",
                    Duration = 169,
                    ReleaseDate = new DateTime(2014, 10, 26)
                }
            ];
        }
        private static void SeedMovieImageSets()
        {
            MovieImageSets =
            [
                new MovieImageSet
                {
                    MovieId = Movies[0].Id,
                    ImagesUrl = "['https://64.media.tumblr.com/03f0f59694430f001d08e9309dc52f2e/f5e1e516dcb80f72-07/s1280x1920/9263ba9178755f24391d9ef5fd6d23c8ba9ab35d.jpg','https://64.media.tumblr.com/5bb66a7e359f0a5fec8a238d73798291/f5e1e516dcb80f72-9b/s1280x1920/5ec8af306838ed682350b62189e31627e578b701.jpg']"
                },
                new MovieImageSet
                {
                    MovieId = Movies[1].Id,
                    ImagesUrl = "['https://64.media.tumblr.com/03f0f59694430f001d08e9309dc52f2e/f5e1e516dcb80f72-07/s1280x1920/9263ba9178755f24391d9ef5fd6d23c8ba9ab35d.jpg','https://64.media.tumblr.com/5bb66a7e359f0a5fec8a238d73798291/f5e1e516dcb80f72-9b/s1280x1920/5ec8af306838ed682350b62189e31627e578b701.jpg']"
                }
            ];
        }
        private static void SeedActorsMovies()
        {
            ActorsMovies =
            [
                new ActorMovie
                {
                    ActorId = Actors[0].Id,
                    MovieId = Movies[0].Id,
                },
                new ActorMovie
                {
                    ActorId = Actors[1].Id,
                    MovieId = Movies[0].Id,
                },
                new ActorMovie
                {
                    ActorId = Actors[2].Id,
                    MovieId = Movies[1].Id,
                },
                new ActorMovie
                {
                    ActorId = Actors[3].Id,
                    MovieId = Movies[1].Id,
                }
            ];
        }
        private static void SeedMoviesGenres()
        {
            MoviesGenres =
            [
                new MovieGenre
                {
                    MovieId = Movies[0].Id,
                    GenreId = Genres[0].Id,
                },
                new MovieGenre
                {
                    MovieId = Movies[0].Id,
                    GenreId = Genres[1].Id,
                },
                new MovieGenre
                {
                    MovieId = Movies[1].Id,
                    GenreId = Genres[2].Id,
                },
                new MovieGenre
                {
                    MovieId = Movies[1].Id,
                    GenreId = Genres[3].Id,
                }
            ];
        }
        private static void SeedReviews()
        {
            Reviews =
            [
                new Review
                {
                    Id = new Guid("BBD5C0D3-A45D-490A-B26D-D503B6A82261"),
                    MovieId = Movies[0].Id,
                    Rank = 5,
                    Comment = "Great movie!",
                    CreatedById = Users[1].Id,
                    CreatedOnUtc = DateTime.UtcNow,
                    CreatedByName = Users[1].UserName ?? "",
                },
                new Review
                {
                    Id = new Guid("BBD5C0D3-A45D-490A-B26D-D503B6A82262"),
                    MovieId = Movies[1].Id,
                    Rank = 4,
                    Comment = "Good movie!",
                    CreatedById = Users[1].Id,
                    CreatedOnUtc = DateTime.UtcNow,
                    CreatedByName = Users[1].UserName ?? "",
                }
            ];
        }
        private static void SeedHalls()
        {
            Halls =
            [
                new Hall
                {
                    Id = new Guid("D67B95A0-B12E-4574-B9EC-634B11F8DF41"),
                    Name = "Hall 1 (Big)",
                    Capacity = 100,
                    RowsData = """
                               [
                                    { "Capacity": 6, "PriceMultiplier": 1 },
                                    { "Capacity": 8, "PriceMultiplier": 1.2 },
                                    { "Capacity": 10, "PriceMultiplier": 1.5 },
                                    { "Capacity": 10, "PriceMultiplier": 1.5 },
                                    { "Capacity": 10, "PriceMultiplier": 1.5 },
                                    { "Capacity": 10, "PriceMultiplier": 2 },
                                    { "Capacity": 10, "PriceMultiplier": 2 },
                                    { "Capacity": 10, "PriceMultiplier": 1.5 },
                                    { "Capacity": 10, "PriceMultiplier": 2 },
                                    { "Capacity": 10, "PriceMultiplier": 2 },
                               ]
                               """
                },
                new Hall
                {
                    Id = new Guid("D67B95A0-B12E-4574-B9EC-634B11F8DF42"),
                    Name = "Hall 2 (Small)",
                    Capacity = 50,
                    RowsData = """
                               [
                                    { "Capacity": 8, "PriceMultiplier": 1 },
                                    { "Capacity": 5, "PriceMultiplier": 1.2 },
                                    { "Capacity": 5, "PriceMultiplier": 1.6 },
                                    { "Capacity": 5, "PriceMultiplier": 1.6 },
                                    { "Capacity": 5, "PriceMultiplier": 1.6 },
                                    { "Capacity": 5, "PriceMultiplier": 2 },
                                    { "Capacity": 5, "PriceMultiplier": 2 },
                                    { "Capacity": 5, "PriceMultiplier": 2 }
                               ]
                               """
                }
            ];
        }
        private static void SeedSessions()
        {
            Sessions =
            [
                new Session
                {
                    Id = new Guid("1F8038C6-2E09-4919-8A40-D4715F176BE1"),
                    HallId = Halls[0].Id,
                    MovieId = Movies[0].Id,
                    DateUtc = new DateTime(2024, 4, 28, 14, 0, 0),
                    BasePrice = 299.00m
                },
                new Session
                {
                    Id = new Guid("1F8038C6-2E09-4919-8A40-D4715F176BE2"),
                    HallId = Halls[0].Id,
                    MovieId = Movies[1].Id,
                    DateUtc = new DateTime(2024, 4, 28, 18, 0, 0),
                    BasePrice = 129.00m
                },
                new Session
                {
                    Id = new Guid("1F8038C6-2E09-4919-8A40-D4715F176BE3"),
                    HallId = Halls[0].Id,
                    MovieId = Movies[0].Id,
                    DateUtc = new DateTime(2024, 4, 28, 18, 0, 0),
                    BasePrice = 349.00m
                },
                new Session
                {
                    Id = new Guid("1F8038C6-2E09-4919-8A40-D4715F176BE4"),
                    HallId = Halls[1].Id,
                    MovieId = Movies[1].Id,
                    DateUtc = new DateTime(2024, 4, 29, 12, 0, 0),
                    BasePrice = 99.00m
                }
            ];
        }
        
        private static void SeedInvoices()
        {
            Invoices =
            [
                new Invoice
                {
                    Id = new Guid("363C2006-3D51-46EA-AF49-F40FE7605441"),
                    UserId = Users[1].Id,
                    Amount = 100.00m,
                    IsPaid = true,
                    CreateDateUtc = new DateTime(2024, 4, 28, 11, 5, 44, DateTimeKind.Utc),
                },
                new Invoice
                {
                    Id = new Guid("363C2006-3D51-46EA-AF49-F40FE7605442"),
                    UserId = Users[1].Id,
                    Amount = 100.00m,
                    IsPaid = true,
                    CreateDateUtc = new DateTime(2024, 4, 28, 19, 34, 21, DateTimeKind.Utc),
                }
            ];
        }
        
        private static void SeedTickets()
        {
            Tickets =
            [
                new Ticket
                {
                    Id = new Guid("9EA79A4C-D3D2-4FDF-B9C4-9F4B71E6F011"),
                    SessionId = Sessions[0].Id,
                    InvoiceId = Invoices[0].Id,
                    RowIndex = 3,
                    SeatIndex = 6
                },
                new Ticket
                {
                    Id = new Guid("9EA79A4C-D3D2-4FDF-B9C4-9F4B71E6F012"),
                    SessionId = Sessions[3].Id,
                    InvoiceId = Invoices[1].Id,
                    RowIndex = 1,
                    SeatIndex = 4
                }
            ];
        }
    }
}
