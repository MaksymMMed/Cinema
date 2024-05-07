using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Cinema.DAL.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Actor",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(35)", maxLength: 35, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Actor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Director",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(35)", maxLength: 35, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Director", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Genre",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genre", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Hall",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Capacity = table.Column<int>(type: "int", nullable: false),
                    RowsCapacity = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hall", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Movie",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DirectorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrailerUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AgeRestriction = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Duration = table.Column<int>(type: "int", nullable: false),
                    ReleaseDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movie", x => x.Id);
                    table.ForeignKey(
                        name: "MovieDirectorFK",
                        column: x => x.DirectorId,
                        principalTable: "Director",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ActorMovie",
                columns: table => new
                {
                    ActorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MovieId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActorMovie", x => new { x.ActorId, x.MovieId });
                    table.ForeignKey(
                        name: "ActorMovieFK",
                        column: x => x.ActorId,
                        principalTable: "Actor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "MovieActorFK",
                        column: x => x.MovieId,
                        principalTable: "Movie",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MovieGenre",
                columns: table => new
                {
                    MovieId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GenreId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieGenre", x => new { x.MovieId, x.GenreId });
                    table.ForeignKey(
                        name: "GenreMovieFK",
                        column: x => x.GenreId,
                        principalTable: "Genre",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "MovieGenreFK",
                        column: x => x.MovieId,
                        principalTable: "Movie",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MovieImageSet",
                columns: table => new
                {
                    MovieId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ImagesUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieImageSet", x => x.MovieId);
                    table.ForeignKey(
                        name: "MovieImageSetFK",
                        column: x => x.MovieId,
                        principalTable: "Movie",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Review",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MovieId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Rank = table.Column<int>(type: "int", nullable: false),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Review", x => x.Id);
                    table.ForeignKey(
                        name: "MovieReviewFK",
                        column: x => x.MovieId,
                        principalTable: "Movie",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "UserReviewFK",
                        column: x => x.CreatedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Session",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HallId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MovieId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateUtc = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Session", x => x.Id);
                    table.ForeignKey(
                        name: "MovieSessionFK",
                        column: x => x.MovieId,
                        principalTable: "Movie",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "SessionHallFK",
                        column: x => x.HallId,
                        principalTable: "Hall",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ticket",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SessionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HallId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RowIndex = table.Column<int>(type: "int", nullable: false),
                    PlaceIndex = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ticket", x => x.Id);
                    table.ForeignKey(
                        name: "TicketHallFK",
                        column: x => x.HallId,
                        principalTable: "Hall",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "TicketSessionFK",
                        column: x => x.SessionId,
                        principalTable: "Session",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "TicketUserFK",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Invoice",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TicketId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    CreateDateUtc = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Invoice", x => x.Id);
                    table.ForeignKey(
                        name: "TicketInvoiceFK",
                        column: x => x.TicketId,
                        principalTable: "Ticket",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "UserInvoiceFK",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Actor",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82261"), "Cillian Murphy" },
                    { new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82262"), "Emily Blunt" },
                    { new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82263"), "Matthew McConaughhey" },
                    { new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82264"), "Anne Hathaway" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("88d6040a-130f-43d4-8bee-1f0074962181"), 0, "04c99617-c427-4f99-bd40-5dbc52108f6e", "admin@example.com", true, false, null, "ADMIN@EXAMPLE.COM", "ADMIN", "AQAAAAIAAYagAAAAEBL+uOlsNZGbN9ibvJstGX+uW/zoklJwRNalt2c0EdcN1qIHjjSsQd99veyyYun6dQ==", null, false, null, false, "admin" },
                    { new Guid("88d6040a-130f-43d4-8bee-1f0074962182"), 0, "fdcc761f-8c63-4e40-ab00-b66bb54717e2", "user@example.com", true, false, null, "USER@EXAMPLE.COM", "USER", "AQAAAAIAAYagAAAAEB2Bp2Il1Yv0TnM+/O7cn2ALL2YXLbeghYDSejApp36HDT+MwprD3GR49o0gtE1/2Q==", null, false, null, false, "user" }
                });

            migrationBuilder.InsertData(
                table: "Director",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("ed9a79d9-fe9d-456e-a0a7-2a028cbe1001"), "Christopher Nolan" },
                    { new Guid("ed9a79d9-fe9d-456e-a0a7-2a028cbe1002"), "Quentin Tarantino" },
                    { new Guid("ed9a79d9-fe9d-456e-a0a7-2a028cbe1003"), "Steven Spielberg" }
                });

            migrationBuilder.InsertData(
                table: "Genre",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82261"), "Drama" },
                    { new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82262"), "Action" },
                    { new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82263"), "Comedy" },
                    { new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82264"), "Thriller" }
                });

            migrationBuilder.InsertData(
                table: "Hall",
                columns: new[] { "Id", "Capacity", "RowsCapacity" },
                values: new object[,]
                {
                    { new Guid("d67b95a0-b12e-4574-b9ec-634b11f8df41"), 100, "[10,10,10,10,10,10,10,10,10,10]" },
                    { new Guid("d67b95a0-b12e-4574-b9ec-634b11f8df42"), 50, "[5,5,5,5,5,5,5,5,5,5]" }
                });

            migrationBuilder.InsertData(
                table: "Movie",
                columns: new[] { "Id", "AgeRestriction", "Description", "DirectorId", "Duration", "ImageUrl", "Name", "ReleaseDate", "TrailerUrl" },
                values: new object[,]
                {
                    { new Guid("9344f562-ffdc-41c5-bb24-c41c969534c1"), "R", "Oppenheimer is a 2023 epic biographical thriller film written, directed, and produced by Christopher Nolan.It follows the life of J. Robert Oppenheimer, the American theoretical physicist who helped develop the first nuclear weapons during World War II. Based on the 2005 biography American Prometheus by Kai Bird and Martin J. Sherwin, the film chronicles Oppenheimer's studies, his direction of the Los Alamos Laboratory, and his fall from grace after his 1954 security hearing. Cillian Murphy stars as Oppenheimer, alongside Robert Downey Jr. as the United States Atomic Energy Commission member Lewis Strauss.", new Guid("ed9a79d9-fe9d-456e-a0a7-2a028cbe1001"), 180, "https://upload.wikimedia.org/wikipedia/en/thumb/4/4a/Oppenheimer_%28film%29.jpg/220px-Oppenheimer_%28film%29.jpg", "Oppenheimer", new DateTime(2023, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://www.youtube.com/watch?v=bK6ldnjE3Y0&pp=ygUTb3BwZW5oZWltZXIgdHJhaWxlcg%3D%3D" },
                    { new Guid("9344f562-ffdc-41c5-bb24-c41c969534c2"), "PG-13", "Interstellar is a 2014 epic science fiction film directed, written, and produced by Christopher Nolan and starring Matthew McConaughey, Anne Hathaway,   Jessica Chastain, Bill Irwin, Ellen Burstyn, Michael Caine, and Matt Damon. Set in a dystopian future where humanity is embroiled in a catastrophic blight and    famine, the film follows a group of astronauts who travel through a wormhole near Saturn in search of a new home for humankind.", new Guid("ed9a79d9-fe9d-456e-a0a7-2a028cbe1001"), 169, "https://upload.wikimedia.org/wikipedia/en/b/bc/Interstellar_film_poster.jpg", "Interstellar", new DateTime(2014, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://www.youtube.com/watch?v=zSWdZVtXT7E&pp=ygUUaW50ZXJzdGVsbGFyIHRyYWlsZXI%3D" }
                });

            migrationBuilder.InsertData(
                table: "ActorMovie",
                columns: new[] { "ActorId", "MovieId" },
                values: new object[,]
                {
                    { new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82261"), new Guid("9344f562-ffdc-41c5-bb24-c41c969534c1") },
                    { new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82262"), new Guid("9344f562-ffdc-41c5-bb24-c41c969534c1") },
                    { new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82263"), new Guid("9344f562-ffdc-41c5-bb24-c41c969534c2") },
                    { new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82264"), new Guid("9344f562-ffdc-41c5-bb24-c41c969534c2") }
                });

            migrationBuilder.InsertData(
                table: "MovieGenre",
                columns: new[] { "GenreId", "MovieId" },
                values: new object[,]
                {
                    { new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82261"), new Guid("9344f562-ffdc-41c5-bb24-c41c969534c1") },
                    { new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82262"), new Guid("9344f562-ffdc-41c5-bb24-c41c969534c1") },
                    { new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82263"), new Guid("9344f562-ffdc-41c5-bb24-c41c969534c2") },
                    { new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82264"), new Guid("9344f562-ffdc-41c5-bb24-c41c969534c2") }
                });

            migrationBuilder.InsertData(
                table: "MovieImageSet",
                columns: new[] { "MovieId", "ImagesUrl" },
                values: new object[,]
                {
                    { new Guid("9344f562-ffdc-41c5-bb24-c41c969534c1"), "['https://64.media.tumblr.com/03f0f59694430f001d08e9309dc52f2e/f5e1e516dcb80f72-07/s1280x1920/9263ba9178755f24391d9ef5fd6d23c8ba9ab35d.jpg','https://64.media.tumblr.com/5bb66a7e359f0a5fec8a238d73798291/f5e1e516dcb80f72-9b/s1280x1920/5ec8af306838ed682350b62189e31627e578b701.jpg']" },
                    { new Guid("9344f562-ffdc-41c5-bb24-c41c969534c2"), "['https://64.media.tumblr.com/03f0f59694430f001d08e9309dc52f2e/f5e1e516dcb80f72-07/s1280x1920/9263ba9178755f24391d9ef5fd6d23c8ba9ab35d.jpg','https://64.media.tumblr.com/5bb66a7e359f0a5fec8a238d73798291/f5e1e516dcb80f72-9b/s1280x1920/5ec8af306838ed682350b62189e31627e578b701.jpg']" }
                });

            migrationBuilder.InsertData(
                table: "Review",
                columns: new[] { "Id", "Comment", "CreatedById", "CreatedByName", "CreatedOnUtc", "MovieId", "Rank" },
                values: new object[,]
                {
                    { new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82261"), "Great movie!", new Guid("88d6040a-130f-43d4-8bee-1f0074962182"), "user", new DateTime(2024, 5, 7, 11, 42, 38, 687, DateTimeKind.Utc).AddTicks(8940), new Guid("9344f562-ffdc-41c5-bb24-c41c969534c1"), 5 },
                    { new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82262"), "Good movie!", new Guid("88d6040a-130f-43d4-8bee-1f0074962182"), "user", new DateTime(2024, 5, 7, 11, 42, 38, 687, DateTimeKind.Utc).AddTicks(9330), new Guid("9344f562-ffdc-41c5-bb24-c41c969534c2"), 4 }
                });

            migrationBuilder.InsertData(
                table: "Session",
                columns: new[] { "Id", "DateUtc", "HallId", "MovieId" },
                values: new object[,]
                {
                    { new Guid("1f8038c6-2e09-4919-8a40-d4715f176be1"), new DateTime(2024, 4, 28, 14, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d67b95a0-b12e-4574-b9ec-634b11f8df41"), new Guid("9344f562-ffdc-41c5-bb24-c41c969534c1") },
                    { new Guid("1f8038c6-2e09-4919-8a40-d4715f176be2"), new DateTime(2024, 4, 28, 18, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d67b95a0-b12e-4574-b9ec-634b11f8df41"), new Guid("9344f562-ffdc-41c5-bb24-c41c969534c2") },
                    { new Guid("1f8038c6-2e09-4919-8a40-d4715f176be3"), new DateTime(2024, 4, 28, 18, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d67b95a0-b12e-4574-b9ec-634b11f8df41"), new Guid("9344f562-ffdc-41c5-bb24-c41c969534c1") },
                    { new Guid("1f8038c6-2e09-4919-8a40-d4715f176be4"), new DateTime(2024, 4, 29, 12, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d67b95a0-b12e-4574-b9ec-634b11f8df42"), new Guid("9344f562-ffdc-41c5-bb24-c41c969534c2") }
                });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "HallId", "PlaceIndex", "RowIndex", "SessionId", "UserId" },
                values: new object[,]
                {
                    { new Guid("9ea79a4c-d3d2-4fdf-b9c4-9f4b71e6f011"), new Guid("d67b95a0-b12e-4574-b9ec-634b11f8df41"), 6, 3, new Guid("1f8038c6-2e09-4919-8a40-d4715f176be1"), new Guid("88d6040a-130f-43d4-8bee-1f0074962182") },
                    { new Guid("9ea79a4c-d3d2-4fdf-b9c4-9f4b71e6f012"), new Guid("d67b95a0-b12e-4574-b9ec-634b11f8df42"), 4, 1, new Guid("1f8038c6-2e09-4919-8a40-d4715f176be4"), new Guid("88d6040a-130f-43d4-8bee-1f0074962182") }
                });

            migrationBuilder.InsertData(
                table: "Invoice",
                columns: new[] { "Id", "Amount", "CreateDateUtc", "Status", "TicketId", "UserId" },
                values: new object[,]
                {
                    { new Guid("363c2006-3d51-46ea-af49-f40fe7605441"), 100, new DateTime(2024, 4, 28, 11, 5, 44, 0, DateTimeKind.Utc), true, new Guid("9ea79a4c-d3d2-4fdf-b9c4-9f4b71e6f011"), new Guid("88d6040a-130f-43d4-8bee-1f0074962182") },
                    { new Guid("363c2006-3d51-46ea-af49-f40fe7605442"), 100, new DateTime(2024, 4, 28, 19, 34, 21, 0, DateTimeKind.Utc), true, new Guid("9ea79a4c-d3d2-4fdf-b9c4-9f4b71e6f012"), new Guid("88d6040a-130f-43d4-8bee-1f0074962182") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ActorMovie_MovieId",
                table: "ActorMovie",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Invoice_TicketId",
                table: "Invoice",
                column: "TicketId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Invoice_UserId",
                table: "Invoice",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Movie_DirectorId",
                table: "Movie",
                column: "DirectorId");

            migrationBuilder.CreateIndex(
                name: "IX_MovieGenre_GenreId",
                table: "MovieGenre",
                column: "GenreId");

            migrationBuilder.CreateIndex(
                name: "IX_Review_CreatedById",
                table: "Review",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Review_MovieId",
                table: "Review",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_Session_HallId",
                table: "Session",
                column: "HallId");

            migrationBuilder.CreateIndex(
                name: "IX_Session_MovieId",
                table: "Session",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_HallId",
                table: "Ticket",
                column: "HallId");

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_SessionId",
                table: "Ticket",
                column: "SessionId");

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_UserId",
                table: "Ticket",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActorMovie");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Invoice");

            migrationBuilder.DropTable(
                name: "MovieGenre");

            migrationBuilder.DropTable(
                name: "MovieImageSet");

            migrationBuilder.DropTable(
                name: "Review");

            migrationBuilder.DropTable(
                name: "Actor");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Ticket");

            migrationBuilder.DropTable(
                name: "Genre");

            migrationBuilder.DropTable(
                name: "Session");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Movie");

            migrationBuilder.DropTable(
                name: "Hall");

            migrationBuilder.DropTable(
                name: "Director");
        }
    }
}
