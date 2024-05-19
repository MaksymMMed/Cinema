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
            SeedTickets();
            SeedInvoices();
        }

        private static AspNetUser MakeUser(string userName, string email, string password)
        {
            var hasherUser = new PasswordHasher<AspNetUser>();
            var user = new AspNetUser
            {
                Id = Guid.NewGuid(),
                UserName = userName,
                NormalizedUserName = userName.ToUpper(),
                Email = email,
                NormalizedEmail = email.ToUpper(),
                EmailConfirmed = true
            };
            user.PasswordHash = hasherUser.HashPassword(user, password);
            return user;
        }

        private static void SeedUsers()
        { 
            Users =
            [
                MakeUser("admin", "admin@example.com", "admin"),
                MakeUser("johndoe", "johndoe@example.com", "Password_123"),
                MakeUser("janedoe", "janedoe@example.com", "Password_123"),
                MakeUser("moviebuff", "moviebuff@example.com", "Password_123"),
                MakeUser("cinemalover", "cinemalover@example.com", "Password_123"),
                MakeUser("actionfan", "actionfan@example.com", "Password_123"),
                MakeUser("dramatic", "dramatic@example.com", "Password_123"),
                MakeUser("comedyking", "comedyking@example.com", "Password_123"),
                MakeUser("thrillseeker", "thrillseeker@example.com", "Password_123"),
            ];
        }

        private static void SeedActors()
        {
            Actors =
            [
                new Actor
                {
                    Id = new Guid("AAD5CAAA-A45D-490A-B26D-D503B6A82261"),
                    Name = "Cillian Murphy"
                },
                new Actor
                {
                    Id = new Guid("AAD5CAAA-A45D-490A-B26D-D503B6A82262"),
                    Name = "Emily Blunt"
                },
                new Actor
                {
                    Id = new Guid("AAD5CAAA-A45D-490A-B26D-D503B6A82263"),
                    Name = "Matthew McConaughhey"
                },
                new Actor
                {
                    Id = new Guid("AAD5CAAA-A45D-490A-B26D-D503B6A82264"),
                    Name = "Anne Hathaway"
                },
                new Actor
                {
                    Id = new Guid("AAD5CAAA-A45D-490A-B26D-D503B6A82265"),
                    Name = "Jessica Chastain"
                },
                new Actor
                {
                    Id = new Guid("AAD5CAAA-A45D-490A-B26D-D503B6A82266"),
                    Name = "Bill Irwin"
                },
                new Actor
                {
                    Id = new Guid("AAD5CAAA-A45D-490A-B26D-D503B6A82267"),
                    Name = "Ellen Burstyn"
                },
                new Actor
                {
                    Id = new Guid("AAD5CAAA-A45D-490A-B26D-D503B6A82268"),
                    Name = "Michael Caine"
                },
                new Actor
                {
                    Id = new Guid("AAD5CAAA-A45D-490A-B26D-D503B6A82269"),
                    Name = "Matt Damon"
                },
                new Actor
                {
                    Id = new Guid("AAD5CAAA-A45D-490A-B26D-D503B6A82270"),
                    Name = "Robert Downey Jr."
                },
                new Actor
                {
                    Id = new Guid("AAD5CAAA-A45D-490A-B26D-D503B6A82271"),
                    Name = "Leonardo DiCaprio"
                },
                new Actor
                {
                    Id = new Guid("AAD5CAAA-A45D-490A-B26D-D503B6A82272"),
                    Name = "Brad Pitt"
                },
                new Actor
                {
                    Id = new Guid("AAD5CAAA-A45D-490A-B26D-D503B6A82273"),
                    Name = "Tom Hanks"
                },
                new Actor
                {
                    Id = new Guid("AAD5CAAA-A45D-490A-B26D-D503B6A82274"),
                    Name = "Morgan Freeman"
                },
                new Actor
                {
                    Id = new Guid("AAD5CAAA-A45D-490A-B26D-D503B6A82275"),
                    Name = "Al Pacino"
                },
                new Actor
                {
                    Id = new Guid("AAD5CAAA-A45D-490A-B26D-D503B6A82276"),
                    Name = "Marlon Brando"
                },
                new Actor
                {
                    Id = new Guid("AAD5CAAA-A45D-490A-B26D-D503B6A82277"),
                    Name = "Christian Bale"
                },
                new Actor
                {
                    Id = new Guid("AAD5CAAA-A45D-490A-B26D-D503B6A82278"),
                    Name = "Heath Ledger"
                },
                new Actor
                {
                    Id = new Guid("AAD5CAAA-A45D-490A-B26D-D503B6A82279"),
                    Name = "Margot Robbie"
                },
                new Actor
                {
                    Id = new Guid("AAD5CAAA-A45D-490A-B26D-D503B6A82280"),
                    Name = "Samuel L. Jackson"
                },
                new Actor
                {
                    Id = new Guid("AAD5CAAA-A45D-490A-B26D-D503B6A82281"),
                    Name = "John Travolta"
                },
                new Actor
                {
                    Id = new Guid("AAD5CAAA-A45D-490A-B26D-D503B6A82282"),
                    Name = "Uma Thurman"
                },
                new Actor
                {
                    Id = new Guid("AAD5CAAA-A45D-490A-B26D-D503B6A82283"),
                    Name = "Bruce Willis"
                },
                new Actor
                {
                    Id = new Guid("AAD5CAAA-A45D-490A-B26D-D503B6A82284"),
                    Name = "Ving Rhames"
                },
                new Actor
                {
                    Id = new Guid("AAD5CAAA-A45D-490A-B26D-D503B6A82285"),
                    Name = "Tim Roth"
                },
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
                },
                new Director
                {
                    Id = new Guid("ED9A79D9-FE9D-456E-A0A7-2A028CBE1004"),
                    Name = "James Cameron"
                },
                new Director
                {
                    Id = new Guid("ED9A79D9-FE9D-456E-A0A7-2A028CBE1005"),
                    Name = "Ridley Scott"
                },
                new Director
                {
                    Id = new Guid("ED9A79D9-FE9D-456E-A0A7-2A028CBE1006"),
                    Name = "Peter Jackson"
                },
                new Director
                {
                    Id = new Guid("ED9A79D9-FE9D-456E-A0A7-2A028CBE1007"),
                    Name = "Francis Ford Coppola"
                },
                new Director
                {
                    Id = new Guid("ED9A79D9-FE9D-456E-A0A7-2A028CBE1008"),
                    Name = "Martin Scorsese"
                },
                new Director
                {
                    Id = new Guid("ED9A79D9-FE9D-456E-A0A7-2A028CBE1009"),
                    Name = "David Fincher"
                },
                new Director
                {
                    Id = new Guid("ED9A79D9-FE9D-456E-A0A7-2A028CBE1010"),
                    Name = "Stanley Kubrick"
                },
                new Director
                {
                    Id = new Guid("ED9A79D9-FE9D-456E-A0A7-2A028CBE1011"),
                    Name = "Alfred Hitchcock"
                },
                new Director
                {
                    Id = new Guid("ED9A79D9-FE9D-456E-A0A7-2A028CBE1012"),
                    Name = "Clint Eastwood"
                },
                new Director
                {
                    Id = new Guid("ED9A79D9-FE9D-456E-A0A7-2A028CBE1013"),
                    Name = "Wes Anderson"
                },
                new Director
                {
                    Id = new Guid("ED9A79D9-FE9D-456E-A0A7-2A028CBE1014"),
                    Name = "Coen Brothers"
                },
                new Director
                {
                    Id = new Guid("ED9A79D9-FE9D-456E-A0A7-2A028CBE1015"),
                    Name = "Jade Halley Bartlett"
                },
                new Director
                {
                    Id = new Guid("ED9A79D9-FE9D-456E-A0A7-2A028CBE1016"),
                    Name = "Tim Burton"
                },
                new Director
                {
                    Id = new Guid("ED9A79D9-FE9D-456E-A0A7-2A028CBE1017"),
                    Name = "David Lynch"
                },
                new Director
                {
                    Id = new Guid("ED9A79D9-FE9D-456E-A0A7-2A028CBE1018"),
                    Name = "Spike Lee"
                },
                new Director
                {
                    Id = new Guid("ED9A79D9-FE9D-456E-A0A7-2A028CBE1019"),
                    Name = "Darren Aronofsky"
                },
                new Director
                {
                    Id = new Guid("ED9A79D9-FE9D-456E-A0A7-2A028CBE1020"),
                    Name = "Paul Thomas Anderson"
                },
                new Director
                {
                    Id = new Guid("ED9A79D9-FE9D-456E-A0A7-2A028CBE1021"),
                    Name = "Terrence Malick"
                },
                new Director
                {
                    Id = new Guid("ED9A79D9-FE9D-456E-A0A7-2A028CBE1022"),
                    Name = "Michael Bay"
                },
                new Director
                {
                    Id = new Guid("ED9A79D9-FE9D-456E-A0A7-2A028CBE1023"),
                    Name = "Zack Snyder"
                },
                new Director
                {
                    Id = new Guid("ED9A79D9-FE9D-456E-A0A7-2A028CBE1024"),
                    Name = "Denis Villeneuve"
                },
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
                    Name = "Sci-Fi"
                },
                new Genre
                {
                    Id = new Guid("BBD5C0D3-A45D-490A-B26D-D503B6A82266"),
                    Name = "Romance"
                },
                new Genre
                {
                    Id = new Guid("BBD5C0D3-A45D-490A-B26D-D503B6A82267"),
                    Name = "Horror"
                },
                new Genre
                {
                    Id = new Guid("BBD5C0D3-A45D-490A-B26D-D503B6A82268"),
                    Name = "Fantasy"
                },
                new Genre
                {
                    Id = new Guid("BBD5C0D3-A45D-490A-B26D-D503B6A82269"),
                    Name = "Mystery"
                },
                new Genre
                {
                    Id = new Guid("BBD5C0D3-A45D-490A-B26D-D503B6A82270"),
                    Name = "Adventure"
                },
                new Genre
                {
                    Id = new Guid("BBD5C0D3-A45D-490A-B26D-D503B6A82271"),
                    Name = "Crime"
                },
                new Genre
                {
                    Id = new Guid("BBD5C0D3-A45D-490A-B26D-D503B6A82272"),
                    Name = "Family"
                },
                new Genre
                {
                    Id = new Guid("BBD5C0D3-A45D-490A-B26D-D503B6A82273"),
                    Name = "Animation"
                },
                new Genre
                {
                    Id = new Guid("BBD5C0D3-A45D-490A-B26D-D503B6A82274"),
                    Name = "Biography"
                },
                new Genre
                {
                    Id = new Guid("BBD5C0D3-A45D-490A-B26D-D503B6A82275"),
                    Name = "History"
                },
                new Genre
                {
                    Id = new Guid("BBD5C0D3-A45D-490A-B26D-D503B6A82276"),
                    Name = "War"
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
                },
                new Movie
                {
                    Id = new Guid("9344F562-FFDC-41C5-BB24-C41C969534C3"),
                    DirectorId = Directors[1].Id,
                    Name = "Inception",
                    Description = "A thief enters dreams to steal secrets but must plant an idea instead.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/en/7/7f/Inception_ver3.jpg",
                    TrailerUrl = "https://www.youtube.com/watch?v=8hP9D6kZseM",
                    AgeRestriction = "PG-13",
                    Duration = 148,
                    ReleaseDate = new DateTime(2010, 7, 16)
                },
                new Movie
                {
                    Id = new Guid("9344F562-FFDC-41C5-BB24-C41C969534C4"),
                    DirectorId = Directors[2].Id,
                    Name = "The Shawshank Redemption",
                    Description = "A banker is sentenced to life in Shawshank Prison and forms a deep friendship.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/en/8/81/ShawshankRedemptionMoviePoster.jpg",
                    TrailerUrl = "https://www.youtube.com/watch?v=6hB3S9bIaco",
                    AgeRestriction = "R",
                    Duration = 142,
                    ReleaseDate = new DateTime(1994, 9, 23)
                },
                new Movie
                {
                    Id = new Guid("9344F562-FFDC-41C5-BB24-C41C969534C5"),
                    DirectorId = Directors[3].Id,
                    Name = "The Dark Knight",
                    Description = "Batman faces the Joker, who wreaks havoc in Gotham City.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/en/8/8a/Dark_Knight.jpg",
                    TrailerUrl = "https://www.youtube.com/watch?v=EXeTwQWrcwY",
                    AgeRestriction = "PG-13",
                    Duration = 152,
                    ReleaseDate = new DateTime(2008, 7, 18)
                },
                new Movie
                {
                    Id = new Guid("9344F562-FFDC-41C5-BB24-C41C969534C6"),
                    DirectorId = Directors[4].Id,
                    Name = "Pulp Fiction",
                    Description = "Interwoven stories of crime in Los Angeles.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/en/8/82/Pulp_Fiction_cover.jpg",
                    TrailerUrl = "https://www.youtube.com/watch?v=s7EdQ4FqbhY",
                    AgeRestriction = "R",
                    Duration = 154,
                    ReleaseDate = new DateTime(1994, 10, 14)
                },
                new Movie
                {
                    Id = new Guid("9344F562-FFDC-41C5-BB24-C41C969534C7"),
                    DirectorId = Directors[5].Id,
                    Name = "Fight Club",
                    Description = "An insomniac forms an underground fight club with a soap salesman.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/en/f/fc/Fight_Club_poster.jpg",
                    TrailerUrl = "https://www.youtube.com/watch?v=SUXWAEX2jlg",
                    AgeRestriction = "R",
                    Duration = 139,
                    ReleaseDate = new DateTime(1999, 10, 15)
                },
                new Movie
                {
                    Id = new Guid("9344F562-FFDC-41C5-BB24-C41C969534C8"),
                    DirectorId = Directors[6].Id,
                    Name = "The Matrix",
                    Description = "A hacker learns the true nature of his reality and his role in the war against its controllers.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/en/c/c1/The_Matrix_Poster.jpg",
                    TrailerUrl = "https://www.youtube.com/watch?v=vKQi3bBA1y8",
                    AgeRestriction = "R",
                    Duration = 136,
                    ReleaseDate = new DateTime(1999, 3, 31)
                },
                new Movie
                {
                    Id = new Guid("9344F562-FFDC-41C5-BB24-C41C969534C9"),
                    DirectorId = Directors[7].Id,
                    Name = "The Godfather",
                    Description = "The aging patriarch of an organized crime dynasty transfers control to his reluctant son.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/en/1/1c/Godfather_ver1.jpg",
                    TrailerUrl = "https://www.youtube.com/watch?v=sY1S34973zA",
                    AgeRestriction = "R",
                    Duration = 175,
                    ReleaseDate = new DateTime(1972, 3, 24)
                },
                new Movie
                {
                    Id = new Guid("9344F562-FFDC-41C5-BB24-C41C96953410"),
                    DirectorId = Directors[8].Id,
                    Name = "The Lord of the Rings: The Fellowship of the Ring",
                    Description = "A young hobbit sets out to destroy a powerful ring.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/en/0/0c/The_Lord_of_the_Rings_The_Fellowship_of_the_Ring_%282001%29.jpg",
                    TrailerUrl = "https://www.youtube.com/watch?v=V75dMMIW2B4",
                    AgeRestriction = "PG-13",
                    Duration = 178,
                    ReleaseDate = new DateTime(2001, 12, 19)
                },
                new Movie
                {
                    Id = new Guid("9344F562-FFDC-41C5-BB24-C41C96953411"),
                    DirectorId = Directors[9].Id,
                    Name = "Forrest Gump",
                    Description = "The presidencies of Kennedy and Johnson through the eyes of a man with low IQ.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/en/6/67/Forrest_Gump_poster.jpg",
                    TrailerUrl = "https://www.youtube.com/watch?v=bLvqoHBptjg",
                    AgeRestriction = "PG-13",
                    Duration = 142,
                    ReleaseDate = new DateTime(1994, 7, 6)
                },
                new Movie
                {
                    Id = new Guid("9344F562-FFDC-41C5-BB24-C41C96953412"),
                    DirectorId = Directors[10].Id,
                    Name = "Gladiator",
                    Description = "A former Roman General seeks vengeance against the corrupt emperor.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/en/8/8d/Gladiator_ver1.jpg",
                    TrailerUrl = "https://www.youtube.com/watch?v=owK1qxDselE",
                    AgeRestriction = "R",
                    Duration = 155,
                    ReleaseDate = new DateTime(2000, 5, 5)
                },
                new Movie
                {
                    Id = new Guid("9344F562-FFDC-41C5-BB24-C41C96953413"),
                    DirectorId = Directors[11].Id,
                    Name = "Saving Private Ryan",
                    Description = "Following the Normandy Landings, a group of U.S. soldiers go behind enemy lines.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/en/a/ac/Saving_Private_Ryan_poster.jpg",
                    TrailerUrl = "https://www.youtube.com/watch?v=RYID71hYHzg",
                    AgeRestriction = "R",
                    Duration = 169,
                    ReleaseDate = new DateTime(1998, 7, 24)
                },
                new Movie
                {
                    Id = new Guid("9344F562-FFDC-41C5-BB24-C41C96953414"),
                    DirectorId = Directors[12].Id,
                    Name = "Schindler's List",
                    Description = "In German-occupied Poland during World War II, Oskar Schindler gradually becomes concerned for his Jewish workforce.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/en/3/38/Schindler%27s_List_movie.jpg",
                    TrailerUrl = "https://www.youtube.com/watch?v=gG22XNhtnoY",
                    AgeRestriction = "R",
                    Duration = 195,
                    ReleaseDate = new DateTime(1993, 12, 15)
                },
                new Movie
                {
                    Id = new Guid("9344F562-FFDC-41C5-BB24-C41C96953415"),
                    DirectorId = Directors[13].Id,
                    Name = "Titanic",
                    Description = "A seventeen-year-old aristocrat falls in love with a kind but poor artist aboard the luxurious, ill-fated R.M.S. Titanic.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/en/2/22/Titanic_poster.jpg",
                    TrailerUrl = "https://www.youtube.com/watch?v=2e-eXJ6HgkQ",
                    AgeRestriction = "PG-13",
                    Duration = 195,
                    ReleaseDate = new DateTime(1997, 12, 19)
                },
                new Movie
                {
                    Id = new Guid("9344F562-FFDC-41C5-BB24-C41C96953416"),
                    DirectorId = Directors[14].Id,
                    Name = "The Silence of the Lambs",
                    Description = "A young F.B.I. cadet must receive the help of an incarcerated and manipulative cannibal killer to catch another serial killer.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/en/8/86/The_Silence_of_the_Lambs_poster.jpg",
                    TrailerUrl = "https://www.youtube.com/watch?v=RuX2MQeb8UM",
                    AgeRestriction = "R",
                    Duration = 118,
                    ReleaseDate = new DateTime(1991, 2, 14)
                },
                new Movie
                {
                    Id = new Guid("9344F562-FFDC-41C5-BB24-C41C96953417"),
                    DirectorId = Directors[15].Id,
                    Name = "The Green Mile",
                    Description = "The lives of guards on Death Row are affected by one of their charges",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/en/e/e2/The_Green_Mile_%28movie_poster%29.jpg",
                    TrailerUrl = "https://www.youtube.com/watch?v=ctRK-4Vt7dA",
                    AgeRestriction = "R",
                    Duration = 189,
                    ReleaseDate = new DateTime(1999, 12, 10)
                    },
                new Movie
                {
                    Id = new Guid("9344F562-FFDC-41C5-BB24-C41C96953418"),
                    DirectorId = Directors[16].Id,
                    Name = "The Departed",
                    Description = "An undercover cop and a mole in the police attempt to identify each other while infiltrating an Irish gang in South Boston.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/en/5/50/Departed234.jpg",
                    TrailerUrl = "https://www.youtube.com/watch?v=auYbpnEwBBg",
                    AgeRestriction = "R",
                    Duration = 151,
                    ReleaseDate = new DateTime(2006, 10, 6)
                },
                new Movie
                {
                    Id = new Guid("9344F562-FFDC-41C5-BB24-C41C96953419"),
                    DirectorId = Directors[17].Id,
                    Name = "The Prestige",
                    Description = "After a tragic accident, two stage magicians engage in a battle to create the ultimate illusion while sacrificing everything they have to outwit each other.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/en/d/d2/Prestige_poster.jpg",
                    TrailerUrl = "https://www.youtube.com/watch?v=o4gHCmTQDVI",
                    AgeRestriction = "PG-13",
                    Duration = 130,
                    ReleaseDate = new DateTime(2006, 10, 20)
                },
                new Movie
                {
                    Id = new Guid("9344F562-FFDC-41C5-BB24-C41C96953420"),
                    DirectorId = Directors[18].Id,
                    Name = "Imaginary",
                    Description = "Imaginary is a 2024 American supernatural horror film directed and produced by Jeff Wadlow and written by Wadlow and the writing team of Greg Erb and Jason Oremland.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/en/7/7f/Imaginary.jpg",
                    TrailerUrl = "https://www.youtube.com/watch?v=8hP9D6kZseM",
                    AgeRestriction = "R",
                    Duration = 180,
                    ReleaseDate = new DateTime(2024, 7, 11)
                },
                new Movie
                {
                    Id = new Guid("9344F562-FFDC-41C5-BB24-C41C96953421"),
                    DirectorId = Directors[19].Id,
                    Name = "Godzilla x Kong: The New Empire",
                    Description = "Godzilla x Kong: The New Empire is a 2024 American monster film directed by Adam Wingard. Produced by Legendary Pictures and distributed by Warner Bros. Pictures, it is the sequel to Godzilla vs. Kong (2021) and the fifth film in the Monsterverse franchise, also serving as the 38th film of the Godzilla franchise and 13th in the King Kong franchise. ",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/en/7/7f/Godzilla_x_Kong_The_New_Empire.jpg",
                    TrailerUrl = "https://www.youtube.com/watch?v=8hP9D6kZseM",
                    AgeRestriction = "PG-13",
                    Duration = 180,
                    ReleaseDate = new DateTime(2024, 7, 11)
                },
                new Movie
                {
                    Id = new Guid("9344F562-FFDC-41C5-BB24-C41C96953422"),
                    DirectorId = Directors[20].Id,
                    Name = "The Three Musketeers: Milady",
                    Description = "The Three Musketeers: Milady is a 2024 American action-adventure film directed by Paul W.S. Anderson and written by Alex Litvak and Andrew Davies. The film is based on the 1844 novel The Three Musketeers by Alexandre Dumas. It is a reboot of the 2011 film of the same name and stars Logan Lerman, Ray Stevenson, Luke Evans, Milla Jovovich, Orlando Bloom, and Christoph Waltz.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/en/7/7f/The_Three_Musketeers_Milady.jpg",
                    TrailerUrl = "https://www.youtube.com/watch?v=8hP9D6kZseM",
                    AgeRestriction = "PG-13",
                    Duration = 135,
                    ReleaseDate = new DateTime(2023, 4, 13)
                },
                new Movie
                {
                    Id = new Guid("9344F562-FFDC-41C5-BB24-C41C96953423"),
                    DirectorId = Directors[21].Id,
                    Name = "Rebel Moon – Part Two: The Scargiver",
                    Description = "Rebel Moon – Part Two: The Scargiver is an upcoming American science fiction film directed by Zack Snyder and co-written by Snyder, Shay Hatten, and Kurt Johnstad. The film stars Sofia Boutella, Charlie Hunnam, Ray Fisher, Djimon Hounsou, and Doona Bae.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/en/7/7f/Rebel_Moon_Part_Two_The_Scargiver.jpg",
                    TrailerUrl = "https://www.youtube.com/watch?v=8hP9D6kZseM",
                    AgeRestriction = "PG-13",
                    Duration = 122,
                    ReleaseDate = new DateTime(2024, 4, 12)
                },
                new Movie
                {
                    Id = new Guid("9344F562-FFDC-41C5-BB24-C41C96953424"),
                    DirectorId = Directors[22].Id,
                    Name = "Dune: Part Two",
                    Description = "Dune: Part Two is an upcoming American epic science fiction film directed by Denis Villeneuve and written by Jon Spaihts, Villeneuve, and Eric Roth. It is the second of a planned two-part adaptation of the 1965 novel of the same name by Frank Herbert, and will cover the second half of the book.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/en/thumb/5/52/Dune_Part_Two_poster.jpeg/220px-Dune_Part_Two_poster.jpeg",
                    TrailerUrl = "https://www.youtube.com/watch?v=8hP9D6kZseM",
                    AgeRestriction = "PG-13",
                    Duration = 165,
                    ReleaseDate = new DateTime(2024, 3, 1)
                },
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
                },
                new MovieImageSet
                {
                    MovieId = Movies[2].Id,
                    ImagesUrl = "['https://upload.wikimedia.org/wikipedia/en/7/7f/Inception_ver3.jpg','https://upload.wikimedia.org/wikipedia/en/2/20/Inception_2010_poster.jpg']"
                },
                new MovieImageSet
                {
                    MovieId = Movies[3].Id,
                    ImagesUrl = "['https://upload.wikimedia.org/wikipedia/en/8/81/ShawshankRedemptionMoviePoster.jpg','https://upload.wikimedia.org/wikipedia/en/4/4a/The_Shawshank_Redemption.jpg']"
                },
                new MovieImageSet
                {
                    MovieId = Movies[4].Id,
                    ImagesUrl = "['https://upload.wikimedia.org/wikipedia/en/8/8a/Dark_Knight.jpg','https://upload.wikimedia.org/wikipedia/en/3/3a/Dark_Knight.jpg']"
                },
                new MovieImageSet
                {
                    MovieId = Movies[5].Id,
                    ImagesUrl = "['https://upload.wikimedia.org/wikipedia/en/8/82/Pulp_Fiction_cover.jpg','https://upload.wikimedia.org/wikipedia/en/b/b9/Pulp_Fiction.jpg']"
                },
                new MovieImageSet
                {
                    MovieId = Movies[6].Id,
                    ImagesUrl = "['https://upload.wikimedia.org/wikipedia/en/f/fc/Fight_Club_poster.jpg','https://upload.wikimedia.org/wikipedia/en/2/29/Fight_Club.jpg']"
                },
                new MovieImageSet
                {
                    MovieId = Movies[7].Id,
                    ImagesUrl = "['https://upload.wikimedia.org/wikipedia/en/c/c1/The_Matrix_Poster.jpg','https://upload.wikimedia.org/wikipedia/en/2/2f/The_Matrix_DVD.jpg']"
                },
                new MovieImageSet
                {
                    MovieId = Movies[8].Id,
                    ImagesUrl = "['https://upload.wikimedia.org/wikipedia/en/1/1c/Godfather_ver1.jpg','https://upload.wikimedia.org/wikipedia/en/9/91/The_Godfather_I.jpg']"
                },
                new MovieImageSet
                {
                    MovieId = Movies[9].Id,
                    ImagesUrl = "['https://substackcdn.com/image/fetch/f_auto,q_auto:good,fl_progressive:steep/https%3A%2F%2Fbucketeer-e05bbc84-baa3-437e-9518-adb32be77984.s3.amazonaws.com%2Fpublic%2Fimages%2Fa3398191-dfd5-4250-9d51-c75b826d4999_700x376.jpeg','https://filmgrab.files.wordpress.com/2014/08/2240.jpg']"
                },
                new MovieImageSet
                {
                    MovieId = Movies[10].Id,
                    ImagesUrl = "['https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTlZ8Mrnf0SGZJftfaAErcPT1avLfw9Xz4xJs1IkDMmpwqrfyGsW1ALaesy4lpv7UPc9aQ&usqp=CAU','https://cdn.aarp.net/content/dam/aarp/entertainment/movies-for-grownups/2022/03/1140-forrest-gump-bench.jpg']"
                },
                new MovieImageSet
                {
                    MovieId = Movies[11].Id,
                    ImagesUrl = "['https://static.cnews.fr/sites/default/files/gladiator_2_6618f72b7d4f2_0.jpg','https://cdn.britannica.com/93/77293-050-CF984388/Russell-Crowe-Gladiator.jpg']"
                },
                new MovieImageSet
                {
                    MovieId = Movies[12].Id,
                    ImagesUrl = "['https://pbs.twimg.com/media/Dv7wf7ZXgAA7OBF.jpg:large','https://cdn.theasc.com/Saving-Pvt-Ryan-CTS1597.jpg']"
                },
                new MovieImageSet
                {
                    MovieId = Movies[13].Id,
                    ImagesUrl = "['https://i.guim.co.uk/img/media/208d00c732eeed823ec55afe35faf252843e0c59/0_0_2520_1760/master/2520.jpg?width=700&quality=85&auto=format&fit=max&s=dee8947155aa30b56963e4d95b729d5f','https://images.sbs.com.au/dims4/default/e6c27a3/2147483647/strip/true/crop/704x396+0+0/resize/1280x720!/quality/90/?url=http%3A%2F%2Fsbs-au-brightspot.s3.amazonaws.com%2Fdrupal%2Ffilm%2Fpublic%2Fschindlers_list_704_2.jpg']"
                },
                new MovieImageSet
                {
                    MovieId = Movies[14].Id,
                    ImagesUrl = "['https://i.cbc.ca/1.6690550.1671412533!/fileImage/httpImage/image.jpg_gen/derivatives/original_780/titanic.jpg','https://cdn.britannica.com/67/238367-050-3898D4B0/Kate-Winslet-Leonard-DiCaprio-Titanic.jpg']"
                },
                new MovieImageSet
                {
                    MovieId = Movies[15].Id,
                    ImagesUrl = "['https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSvYcE9vV4w5U37CkCM0YvsJ0H1mjiOZuBAl14dDDUF8l0nACjLu7sZllEUWtkWK8IfxMc&usqp=CAU','https://m.media-amazon.com/images/M/MV5BN2ZiYzIyMWQtNDUyNy00YmExLWIwNmMtN2FhNzFiODgyYmU4XkEyXkFqcGdeQXRodW1ibmFpbC1pbml0aWFsaXplcg@@._V1_.jpg']"
                },
                new MovieImageSet
                {
                    MovieId = Movies[16].Id,
                    ImagesUrl = "['https://www.pluggedin.com/wp-content/uploads/2019/12/the-green-mile-1024x683.jpg','https://static1.srcdn.com/wordpress/wp-content/uploads/2022/03/The-Green-Mile-Michael-Clarke-Duncan-Tom-Hanks.png']"
                },
                new MovieImageSet
                {
                    MovieId = Movies[17].Id,
                    ImagesUrl = "['https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTSqVGfDxiHVJCZFluHKhEAojSr-2MfIIbHIQ&usqp=CAU']"
                },
                new MovieImageSet
                {
                    MovieId = Movies[18].Id,
                    ImagesUrl = "['https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRiddcprC5QvCaKgIgCuKYEWmBvG3HJkgZWjkK6SI3XVgrR2Fpkg8I-7d3hmzKUFKe6g-s&usqp=CAU','https://images-1.rakuten.tv/storage/snapshot/shot/013abb91-ed18-4e10-ae37-bef2550653ad-snapshot-1590664694-width936-quality15.jpeg']"
                },
                new MovieImageSet
                {
                    MovieId = Movies[19].Id,
                    ImagesUrl = "['https://i.ytimg.com/vi/7O5v9-l7kwM/sddefault.jpg','https://i.ytimg.com/vi/H2gtae-2ioQ/hq720.jpg?sqp=-oaymwEhCK4FEIIDSFryq4qpAxMIARUAAAAAGAElAADIQj0AgKJD&rs=AOn4CLCK2nXn3w_p8Sni__1o8_rVTxa9bg']"
                },
                new MovieImageSet
                {
                    MovieId = Movies[20].Id,
                    ImagesUrl = "['https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTQeZdXulRxyWVKfjGaf2LvEVVC-eeIKh4JHPOks6sY2meU8mC4Qy_9tnVQpr1l-wgIOyU&usqp=CAU','https://cdn.hobbyconsolas.com/sites/navi.axelspringer.es/public/media/image/2021/02/godzilla-vs-kong-vs-gatete-2242761.jpeg?tf=3840x']"
                },
                new MovieImageSet
                {
                    MovieId = Movies[21].Id,
                    ImagesUrl = "['https://upload.wikimedia.org/wikipedia/en/thumb/6/69/The_Three_Musketeers_-_D%27Artagnan_%282023%29_film_poster.jpg/220px-The_Three_Musketeers_-_D%27Artagnan_%282023%29_film_poster.jpg']"
                },
                new MovieImageSet
                {
                    MovieId = Movies[22].Id,
                    ImagesUrl = "['https://upload.wikimedia.org/wikipedia/en/thumb/d/dd/Rebel_Moon_%E2%80%93_Part_Two_The_Scargiver_poster.jpg/220px-Rebel_Moon_%E2%80%93_Part_Two_The_Scargiver_poster.jpg','https://upload.wikimedia.org/wikipedia/en/thumb/d/dd/Rebel_Moon_%E2%80%93_Part_Two_The_Scargiver_poster.jpg/220px-Rebel_Moon_%E2%80%93_Part_Two_The_Scargiver_poster.jpg']"
                },
                new MovieImageSet
                {
                    MovieId = Movies[23].Id,
                    ImagesUrl = "['https://upload.wikimedia.org/wikipedia/en/thumb/5/52/Dune_Part_Two_poster.jpeg/220px-Dune_Part_Two_poster.jpeg','https://upload.wikimedia.org/wikipedia/en/thumb/5/52/Dune_Part_Two_poster.jpeg/220px-Dune_Part_Two_poster.jpeg']"
                }
            ];
        }
        private static void SeedActorsMovies()
        {
            // random actors for movies, 1-3 actors per movie
            var random = new Random();
            var _actorsMovies = new List<ActorMovie>();
            foreach (var movie in Movies)
            {
                var actors = Actors.OrderBy(x => random.Next()).Take(random.Next(1, 4)).ToList();
                foreach (var actor in actors)
                {
                    _actorsMovies.Add(new ActorMovie
                    {
                        ActorId = actor.Id,
                        MovieId = movie.Id
                    });
                }
            }
            ActorsMovies = _actorsMovies.ToArray();
        }
        private static void SeedMoviesGenres()
        {
            // random genres for movies, 1-3 genre per movie
            var random = new Random();
            var _movieGenres = new List<MovieGenre>();
            foreach (var movie in Movies)
            {
                var genres = Genres.OrderBy(x => random.Next()).Take(random.Next(1, 4)).ToList();
                foreach (var genre in genres)
                {
                    _movieGenres.Add(new MovieGenre
                    {
                        MovieId = movie.Id,
                        GenreId = genre.Id
                    });
                }
            }
            MoviesGenres = _movieGenres.ToArray();
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
                    Capacity = 100,
                    RowsCapacity = "[10,10,10,10,10,10,10,10,10,10]"
                },
                new Hall
                {
                    Id = new Guid("D67B95A0-B12E-4574-B9EC-634B11F8DF42"),
                    Capacity = 50,
                    RowsCapacity = "[5,5,5,5,5,5,5,5,5,5]"
                },
                new Hall
                {
                    Id = new Guid("D67B95A0-B12E-4574-B9EC-634B11F8DF43"),
                    Capacity = 80,
                    RowsCapacity = "[8,8,8,8,8,8,8,8,8,8]"
                },
                new Hall
                {
                    Id = new Guid("D67B95A0-B12E-4574-B9EC-634B11F8DF44"),
                    Capacity = 120,
                    RowsCapacity = "[12,12,12,12,12,12,12,12,12,12]"
                },
            ];
        }
        private static void SeedSessions()
        {
            // generate sesssion for movies in halls, some sessions are in the past (10 days before now),
            // some in the future (10 days from now), 1-2 sessions per day for each hall
            var random = new Random();
            var _sessions = new List<Session>();
            var startDate = DateTime.UtcNow.AddDays(-10);
            var endDate = DateTime.UtcNow.AddDays(10);
            var currentDate = startDate;
            while (currentDate < endDate)
            {
                foreach (var hall in Halls)
                {
                    if (random.Next(1, 10) == 1) continue;

                    var movies = Movies.OrderBy(x => random.Next()).Take(random.Next(1, 3)).ToList();
                    foreach (var movie in movies)
                    {
                        currentDate = currentDate.AddHours(4);
                        _sessions.Add(new Session
                        {
                            Id = Guid.NewGuid(),
                            HallId = hall.Id,
                            MovieId = movie.Id,
                            DateUtc = currentDate,
                            BasePrice = random.Next(100, 300)
                        });
                    }
                }
                currentDate = currentDate.AddDays(1);
            }
            Sessions = _sessions.ToArray();
        }
        private static void SeedTickets()
        {
            // generate tickets for users
            var random = new Random();
            var _tickets = new List<Ticket>();
            foreach (var user in Users)
            {
                var sessions = Sessions.OrderBy(x => random.Next()).Take(random.Next(3, 7)).ToList();
                foreach (var session in sessions)
                {
                    _tickets.Add(new Ticket
                    {
                        Id = Guid.NewGuid(),
                        SessionId = session.Id,
                        HallId = session.HallId,
                        UserId = user.Id,
                        RowIndex = random.Next(0, 4),
                        PlaceIndex = random.Next(0, 4)
                    });
                }
            }
            Tickets = _tickets.ToArray();
        }
        private static void SeedInvoices()
        {
            // make invoices for each ticket
            var random = new Random();
            var _invoices = new List<Invoice>();
            foreach (var ticket in Tickets)
            {
                var _session = Sessions.FirstOrDefault(s => s.Id == ticket.SessionId);
                _invoices.Add(new Invoice
                {
                    Id = Guid.NewGuid(),
                    TicketId = ticket.Id,
                    UserId = ticket.UserId,
                    Amount = (int)_session!.BasePrice, // NOTE: cast to int, change Amount to decimal in Invoice
                    Status = true,
                    CreateDateUtc = _session.DateUtc.AddDays(-1).AddHours(random.Next(1, 23))
                });
            }
            Invoices = _invoices.ToArray();
        }
    }
}
