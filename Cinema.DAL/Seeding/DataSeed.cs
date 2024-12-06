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
                UserName = "Walther White",
                NormalizedUserName = "WALTHER WHITE",
                Email = "WWhite@example.com",
                NormalizedEmail = "WWHITE@EXAMPLE.COM",
                EmailConfirmed = true
            };
            user2.PasswordHash = hasherUser.HashPassword(user2, "password");

            var user3 = new AspNetUser
            {
                Id = new Guid("88D6040A-130F-43D4-8BEE-1F0074962183"),
                UserName = "Jessie Pinkman",
                NormalizedUserName = "JESSIE PINKMAN",
                Email = "jpink@example.com",
                NormalizedEmail = "JPINK@EXAMPLE.COM",
                EmailConfirmed = true
            };
            user3.PasswordHash = hasherUser.HashPassword(user3, "password");

            var user4 = new AspNetUser
            {
                Id = new Guid("88D6040A-130F-43D4-8BEE-1F0074962184"),
                UserName = "user",
                NormalizedUserName = "USER",
                Email = "user@example.com",
                NormalizedEmail = "USER@EXAMPLE.COM",
                EmailConfirmed = true
            };
            user4.PasswordHash = hasherUser.HashPassword(user4, "password");

            Users =
            [
                user1,
                user2,
                user3,
                user4,
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
                },
                new Actor
                {
                    Id = new Guid("BBD5C0D3-A45D-490A-B26D-D503B6A82265"),
                    Name = "Rebecca Ferguson"
                },
                new Actor
                {
                    Id = new Guid("BBD5C0D3-A45D-490A-B26D-D503B6A82266"),
                    Name = "Johny Depp"
                },
                new Actor
                {
                    Id = new Guid("BBD5C0D3-A45D-490A-B26D-D503B6A82267"),
                    Name = "Jason Momoa"
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
                },
                new Genre
                {
                    Id = new Guid("BBD5C0D3-A45D-490A-B26D-D503B6A82265"),
                    Name = "Detective"
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
                    LargePosterImageUrl ="https://images4.alphacoders.com/132/1326785.jpeg",
                    SmallPosterImageUrl = "https://upload.wikimedia.org/wikipedia/en/thumb/4/4a/Oppenheimer_%28film%29.jpg/220px-Oppenheimer_%28film%29.jpg",
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
                    LargePosterImageUrl ="https://i.pinimg.com/originals/e9/24/0b/e9240b7c5b29b0fb4aa86304a03287e8.jpg",
                    SmallPosterImageUrl = "https://upload.wikimedia.org/wikipedia/en/b/bc/Interstellar_film_poster.jpg",
                    TrailerUrl = "https://www.youtube.com/watch?v=zSWdZVtXT7E&pp=ygUUaW50ZXJzdGVsbGFyIHRyYWlsZXI%3D",
                    AgeRestriction = "PG-13",
                    Duration = 169,
                    ReleaseDate = new DateTime(2014, 10, 26)
                },
                new Movie
                {
                    Id = new Guid("9344F562-FFDC-41C5-BB24-C41C969534C3"),
                    DirectorId = Directors[1].Id,
                    Name = "Silo",
                    Description = "140 years after a devastating civil war, Earth's population is living underground in a silo due to the effects of the war on the atmosphere. In the silo the Sherrif's wife stumbles upon some prohibited information and is sentenced to go outside and die. A few years later her husband voluntarily follows her. The information they uncovered is stored in a 140+ year old hard-drive. The hard-drive lands in the possession of an engineer. When he is murdered his girlfriend, a fellow engineer, searches for the truth.",
                    SmallPosterImageUrl = "https://upload.wikimedia.org/wikipedia/uk/thumb/d/d0/Silo_2023.jpg/250px-Silo_2023.jpg",
                    LargePosterImageUrl ="https://storage.googleapis.com/rodeofx-webpage-videos/vfx/images/000-Silo-2/_1920xAUTO_crop_center-center_none/481546/Silo-season-2-banner.webp",
                    TrailerUrl = "https://youtu.be/8ZYhuvIv1pA?si=zOpNLdrSdlAmkF0V",
                    AgeRestriction = "PG-13",
                    Duration = 120,
                    ReleaseDate = new DateTime(2019, 10, 27)
                },
                new Movie
                {
                    Id = new Guid("9344F562-FFDC-41C5-BB24-C41C969534C4"),
                    DirectorId = Directors[1].Id,
                    Name = "Dune",
                    Description = "Dune is a 2021 epic science fiction film based on the 1965 novel by Frank Herbert.",
                    SmallPosterImageUrl = "https://cdn.europosters.eu/image/1300/122815.jpg",
                    LargePosterImageUrl="https://www.hdwallpapers.in/download/poster_of_dune_2020_4k_hd_movies-HD.jpg",
                    TrailerUrl = "https://www.youtube.com/watch?v=n9xhJrPXop4",
                    AgeRestriction = "PG-13",
                    Duration = 155,
                    ReleaseDate = new DateTime(2021, 10, 22)
                },
                new Movie
                {
                    Id = new Guid("9344F562-FFDC-41C5-BB24-C41C969534C5"),
                    DirectorId = Directors[2].Id,
                    Name = "Pirates of the Caribbean: The Curse of the Black Pearl",
                    Description = "A young blacksmith teams up with an eccentric pirate to save the governor's daughter.",
                    SmallPosterImageUrl = "https://lumiere-a.akamaihd.net/v1/images/p_piratesofthecaribbean_thecurseoftheblackpearl_19642_d1ba8e66.jpeg",
                    LargePosterImageUrl = "https://wallpaperswide.com/download/keira_knightley_pirates_of_the_caribbean_at_worlds_end-wallpaper-1920x1080.jpg",
                    TrailerUrl = "https://www.youtube.com/watch?v=naQr0uTrH_s",
                    AgeRestriction = "PG-13",
                    Duration = 143,
                    ReleaseDate = new DateTime(2003, 7, 9)
                },
                new Movie{
                    Id = Guid.NewGuid(),
                    DirectorId = Directors[2].Id,
                    Name = "See",
                    Description = "In a dystopian future where humankind has lost its sight, two children with the ability to see are born.",
                    SmallPosterImageUrl = "https://www.kino-teatr.ru/movie/posters/big/8/2/137928.jpg",
                    LargePosterImageUrl = "https://pics.filmaffinity.com/See_TV_Series-838548891-large.jpg",
                    TrailerUrl = "https://www.youtube.com/watch?v=7Rg0y7NT1gU",
                    AgeRestriction = "TV-MA",
                    Duration = 143,

                    ReleaseDate = new DateTime(2019, 11, 1)
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
                    ImagesUrl = "['https://64.media.tumblr.com/03f0f59694430f001d08e9309dc52f2e/f5e1e516dcb80f72-07/s1280x1920/9263ba9178755f24391d9ef5fd6d23c8ba9ab35d.jpg'," +
                    "'https://64.media.tumblr.com/5bb66a7e359f0a5fec8a238d73798291/f5e1e516dcb80f72-9b/s1280x1920/5ec8af306838ed682350b62189e31627e578b701.jpg'," +
                    "'https://m.media-amazon.com/images/M/MV5BNjI0ZmE0NjMtMzQ5ZS00N2RiLThkYzAtYjExOTc2MjU4ZGMzXkEyXkFqcGc@._V1_.jpg']"
                },
                new MovieImageSet
                {
                    MovieId = Movies[1].Id,
                    ImagesUrl = "['https://edgroom-blogs.s3.ap-south-1.amazonaws.com/202310071805064792540_38983_u23h.jpg'," +
                    "'https://thinkinginenglish.blog/wp-content/uploads/2024/09/interstellar-new-poster-wallpaper.jpg'," +
                    "'https://media.npr.org/assets/img/2014/11/13/fl-17895r_wide-3696728b9df392e99c72d2f2e352ed91d982f03c.jpg']"
                },
                new MovieImageSet
                {
                    MovieId = Movies[2].Id,
                    ImagesUrl = "['https://www.apple.com/tv-pr/shows-and-films/s/silo/images/season-02/unit-photos/episode-01/photo-020101/Silo_Photo_020101.jpg.photo_modal_show_home_large.jpg'," +
                    "'https://miro.medium.com/v2/resize:fit:1400/0*SzLdkt_ctC5AXnUC'," +
                    "'https://cdn.mos.cms.futurecdn.net/phChq4QbVMg7JmNpDe8nMf.jpg']"
                },
                new MovieImageSet
                {
                    MovieId = Movies[3].Id,
                    ImagesUrl = "['https://media.vanityfair.com/photos/65bc53b6dbcc8f7a911121f8/master/pass/DUN2-T3-0084r.jpg'," +
                    "'https://itc.ua/wp-content/uploads/2024/03/ss_807bdb42cfd6f7dbfabdc1bbf1273609af615b38.1920x1080.jpg']"
                },
                new MovieImageSet
                {
                    MovieId = Movies[4].Id,
                    ImagesUrl = "['https://d23.com/app/uploads/2015/09/1180-x-600-091715_pirates-of-the-caribbean-fav-quotes-1180x600.jpg'," +
                    "'https://lumiere-a.akamaihd.net/v1/images/g_piratesofthecaribbean_thecurseoftheblackpearl_disneym_c994a7ff.jpeg?region=1%2C0%2C1298%2C730']"
                },
                new MovieImageSet
                {
                    MovieId = Movies[5].Id,
                    ImagesUrl = "['https://static1.cbrimages.com/wordpress/wp-content/uploads/2019/11/see-feature.jpg'," +
                    "'https://images.bauerhosting.com/legacy/media/612d/f171/f03d/2f72/b707/68e4/see-season-2-2.jpg?auto=format&w=1440&q=80']"
                },
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
                },
                new ActorMovie
                {
                    ActorId = Actors[4].Id,
                    MovieId = Movies[2].Id,
                },
                new ActorMovie
                {
                    ActorId = Actors[4].Id,
                    MovieId = Movies[3].Id,
                },
                new ActorMovie
                {
                    ActorId = Actors[5].Id,
                    MovieId = Movies[4].Id,
                },
                new ActorMovie
                {
                    ActorId = Actors[6].Id,
                    MovieId = Movies[5].Id,
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
                },
                new MovieGenre
                {
                    MovieId = Movies[2].Id,
                    GenreId = Genres[3].Id,
                },
                new MovieGenre
                {
                    MovieId = Movies[3].Id,
                    GenreId = Genres[3].Id,
                },
                new MovieGenre
                {
                    MovieId = Movies[3].Id,
                    GenreId = Genres[4].Id,
                },
                new MovieGenre
                {
                    MovieId = Movies[4].Id,
                    GenreId = Genres[3].Id,
                },
                new MovieGenre
                {
                    MovieId = Movies[5].Id,
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
                                    { "Capacity": 10, "PriceMultiplier": 2 }
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
                    CreatedById = Users[1].Id,
                    Amount = 100.00m,
                    IsPaid = true,
                    CreatedByName = "admin",
                    CreatedOnUtc = new DateTime(2024, 4, 28, 11, 5, 44, DateTimeKind.Utc),
                },
                new Invoice
                {
                    Id = new Guid("363C2006-3D51-46EA-AF49-F40FE7605442"),
                    CreatedById = Users[1].Id,
                    Amount = 100.00m,
                    IsPaid = true,
                    CreatedByName = "admin",
                    CreatedOnUtc = new DateTime(2024, 4, 28, 19, 34, 21, DateTimeKind.Utc),
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
