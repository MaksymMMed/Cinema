using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Cinema.DAL.Migrations
{
    /// <inheritdoc />
    public partial class ImprooveSeeds : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ActorMovie",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82261"), new Guid("9344f562-ffdc-41c5-bb24-c41c969534c1") });

            migrationBuilder.DeleteData(
                table: "ActorMovie",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82262"), new Guid("9344f562-ffdc-41c5-bb24-c41c969534c1") });

            migrationBuilder.DeleteData(
                table: "ActorMovie",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82263"), new Guid("9344f562-ffdc-41c5-bb24-c41c969534c2") });

            migrationBuilder.DeleteData(
                table: "ActorMovie",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82264"), new Guid("9344f562-ffdc-41c5-bb24-c41c969534c2") });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("88d6040a-130f-43d4-8bee-1f0074962181"));

            migrationBuilder.DeleteData(
                table: "Invoice",
                keyColumn: "Id",
                keyValue: new Guid("363c2006-3d51-46ea-af49-f40fe7605441"));

            migrationBuilder.DeleteData(
                table: "Invoice",
                keyColumn: "Id",
                keyValue: new Guid("363c2006-3d51-46ea-af49-f40fe7605442"));

            migrationBuilder.DeleteData(
                table: "MovieGenre",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82261"), new Guid("9344f562-ffdc-41c5-bb24-c41c969534c1") });

            migrationBuilder.DeleteData(
                table: "MovieGenre",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82262"), new Guid("9344f562-ffdc-41c5-bb24-c41c969534c1") });

            migrationBuilder.DeleteData(
                table: "MovieGenre",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82263"), new Guid("9344f562-ffdc-41c5-bb24-c41c969534c2") });

            migrationBuilder.DeleteData(
                table: "MovieGenre",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82264"), new Guid("9344f562-ffdc-41c5-bb24-c41c969534c2") });

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "Id",
                keyValue: new Guid("1f8038c6-2e09-4919-8a40-d4715f176be2"));

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "Id",
                keyValue: new Guid("1f8038c6-2e09-4919-8a40-d4715f176be3"));

            migrationBuilder.DeleteData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82261"));

            migrationBuilder.DeleteData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82262"));

            migrationBuilder.DeleteData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82263"));

            migrationBuilder.DeleteData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82264"));

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: new Guid("9ea79a4c-d3d2-4fdf-b9c4-9f4b71e6f011"));

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: new Guid("9ea79a4c-d3d2-4fdf-b9c4-9f4b71e6f012"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("88d6040a-130f-43d4-8bee-1f0074962182"));

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "Id",
                keyValue: new Guid("1f8038c6-2e09-4919-8a40-d4715f176be1"));

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "Id",
                keyValue: new Guid("1f8038c6-2e09-4919-8a40-d4715f176be4"));

            migrationBuilder.InsertData(
                table: "Actor",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("aad5caaa-a45d-490a-b26d-d503b6a82261"), "Cillian Murphy" },
                    { new Guid("aad5caaa-a45d-490a-b26d-d503b6a82262"), "Emily Blunt" },
                    { new Guid("aad5caaa-a45d-490a-b26d-d503b6a82263"), "Matthew McConaughhey" },
                    { new Guid("aad5caaa-a45d-490a-b26d-d503b6a82264"), "Anne Hathaway" },
                    { new Guid("aad5caaa-a45d-490a-b26d-d503b6a82265"), "Jessica Chastain" },
                    { new Guid("aad5caaa-a45d-490a-b26d-d503b6a82266"), "Bill Irwin" },
                    { new Guid("aad5caaa-a45d-490a-b26d-d503b6a82267"), "Ellen Burstyn" },
                    { new Guid("aad5caaa-a45d-490a-b26d-d503b6a82268"), "Michael Caine" },
                    { new Guid("aad5caaa-a45d-490a-b26d-d503b6a82269"), "Matt Damon" },
                    { new Guid("aad5caaa-a45d-490a-b26d-d503b6a82270"), "Robert Downey Jr." },
                    { new Guid("aad5caaa-a45d-490a-b26d-d503b6a82271"), "Leonardo DiCaprio" },
                    { new Guid("aad5caaa-a45d-490a-b26d-d503b6a82272"), "Brad Pitt" },
                    { new Guid("aad5caaa-a45d-490a-b26d-d503b6a82273"), "Tom Hanks" },
                    { new Guid("aad5caaa-a45d-490a-b26d-d503b6a82274"), "Morgan Freeman" },
                    { new Guid("aad5caaa-a45d-490a-b26d-d503b6a82275"), "Al Pacino" },
                    { new Guid("aad5caaa-a45d-490a-b26d-d503b6a82276"), "Marlon Brando" },
                    { new Guid("aad5caaa-a45d-490a-b26d-d503b6a82277"), "Christian Bale" },
                    { new Guid("aad5caaa-a45d-490a-b26d-d503b6a82278"), "Heath Ledger" },
                    { new Guid("aad5caaa-a45d-490a-b26d-d503b6a82279"), "Margot Robbie" },
                    { new Guid("aad5caaa-a45d-490a-b26d-d503b6a82280"), "Samuel L. Jackson" },
                    { new Guid("aad5caaa-a45d-490a-b26d-d503b6a82281"), "John Travolta" },
                    { new Guid("aad5caaa-a45d-490a-b26d-d503b6a82282"), "Uma Thurman" },
                    { new Guid("aad5caaa-a45d-490a-b26d-d503b6a82283"), "Bruce Willis" },
                    { new Guid("aad5caaa-a45d-490a-b26d-d503b6a82284"), "Ving Rhames" },
                    { new Guid("aad5caaa-a45d-490a-b26d-d503b6a82285"), "Tim Roth" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("33a8b11f-3eab-4f3c-ae10-dddfa35ffb5f"), 0, "4ff3eb31-43d3-4190-982f-bbaa6a81fb24", "actionfan@example.com", true, false, null, "ACTIONFAN@EXAMPLE.COM", "ACTIONFAN", "AQAAAAIAAYagAAAAEEtB42DsLRqIR1J452aiwfDG/lQrO5G9RGLt37/nmLxcplFHRmFrJHeEa1/gU90iyQ==", null, false, null, false, "actionfan" },
                    { new Guid("6e790a16-11e5-4d40-b7ce-9f67721a7a4d"), 0, "d169bae9-bde2-4bde-a5b5-7f3fb480a56a", "janedoe@example.com", true, false, null, "JANEDOE@EXAMPLE.COM", "JANEDOE", "AQAAAAIAAYagAAAAEF9C32krEXVDl11oFWZkBJUfz2yNwCp61EFNkXCm1EN0QLcZ7FPV3/V5+VL6YZ+zmg==", null, false, null, false, "janedoe" },
                    { new Guid("78c3cdd9-8ce2-4eb4-bb95-9b5893eccf9f"), 0, "744c0827-1f11-4dfe-8139-b021a15bf557", "cinemalover@example.com", true, false, null, "CINEMALOVER@EXAMPLE.COM", "CINEMALOVER", "AQAAAAIAAYagAAAAEO41+z5g1GxwCD+uVjlk2wGL7TlP1TP2trRgJ5RPdB/HGbR9sFshy/UmLCuXRXyJzg==", null, false, null, false, "cinemalover" },
                    { new Guid("8a0c9ce1-9a97-4252-a5a5-cc1df45f9cbc"), 0, "0dfa92ae-b348-4e99-ba30-322bbf3525cc", "thrillseeker@example.com", true, false, null, "THRILLSEEKER@EXAMPLE.COM", "THRILLSEEKER", "AQAAAAIAAYagAAAAEI1kSUCazHdR9N546wv2gURRN7CKkrJdc7Mf38MQnlRfKw5lEOZShgSH4HXTG8faKw==", null, false, null, false, "thrillseeker" },
                    { new Guid("92698a9a-09bb-4687-8884-34cdb18841a3"), 0, "cc63104f-03ff-4e89-8d19-c857a3ff777b", "moviebuff@example.com", true, false, null, "MOVIEBUFF@EXAMPLE.COM", "MOVIEBUFF", "AQAAAAIAAYagAAAAECohYHOtlFIiXoIuOJbDeADdN5q/1DeUiQy46yrFpsxw5gOOPWI7ScVYgLdY/ISPCw==", null, false, null, false, "moviebuff" },
                    { new Guid("97f6d0bc-62c9-45d2-a608-c413d5be17d7"), 0, "e24daeb9-f6fb-434c-86b7-61777c73a5fe", "johndoe@example.com", true, false, null, "JOHNDOE@EXAMPLE.COM", "JOHNDOE", "AQAAAAIAAYagAAAAEE7xK7xD+01L6EHNL9KqLyfw/i+8nGu1MSiKXlDBKdU0Sw+E9nxtgEynPwsiZ5zU0Q==", null, false, null, false, "johndoe" },
                    { new Guid("a4548123-827e-428f-86e1-d98217fd9a88"), 0, "d051986d-b6c9-4393-8d50-04367acb7b9b", "comedyking@example.com", true, false, null, "COMEDYKING@EXAMPLE.COM", "COMEDYKING", "AQAAAAIAAYagAAAAEA+c+z818Pc25fyGUVC0ict0sIyOLqc/iZqrDp3sdsPEGWF30odgie+5RENvvn6Fnw==", null, false, null, false, "comedyking" },
                    { new Guid("b777385f-f200-4ef4-a1af-99892cd9d867"), 0, "b74bf796-baed-44c1-af08-cf89e22f312e", "admin@example.com", true, false, null, "ADMIN@EXAMPLE.COM", "ADMIN", "AQAAAAIAAYagAAAAEFLnSZDPcN49O86/K69JBZ/3RaHj5ym1XfAnoPc2RprsPcvpT7XI+raR8vgAGsIQNg==", null, false, null, false, "admin" },
                    { new Guid("cb1f260c-26f1-48b1-a277-a309397d1875"), 0, "10e710e2-29ca-48c7-a87a-8ba938e1b0a7", "dramatic@example.com", true, false, null, "DRAMATIC@EXAMPLE.COM", "DRAMATIC", "AQAAAAIAAYagAAAAENs7FnOV/AwYJkh5Eu9HsjXoWDO3dt691Cpn4rKRTP1xVtd03et5ITILZkfo1VsYOA==", null, false, null, false, "dramatic" }
                });

            migrationBuilder.InsertData(
                table: "Director",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("ed9a79d9-fe9d-456e-a0a7-2a028cbe1004"), "James Cameron" },
                    { new Guid("ed9a79d9-fe9d-456e-a0a7-2a028cbe1005"), "Ridley Scott" },
                    { new Guid("ed9a79d9-fe9d-456e-a0a7-2a028cbe1006"), "Peter Jackson" },
                    { new Guid("ed9a79d9-fe9d-456e-a0a7-2a028cbe1007"), "Francis Ford Coppola" },
                    { new Guid("ed9a79d9-fe9d-456e-a0a7-2a028cbe1008"), "Martin Scorsese" },
                    { new Guid("ed9a79d9-fe9d-456e-a0a7-2a028cbe1009"), "David Fincher" },
                    { new Guid("ed9a79d9-fe9d-456e-a0a7-2a028cbe1010"), "Stanley Kubrick" },
                    { new Guid("ed9a79d9-fe9d-456e-a0a7-2a028cbe1011"), "Alfred Hitchcock" },
                    { new Guid("ed9a79d9-fe9d-456e-a0a7-2a028cbe1012"), "Clint Eastwood" },
                    { new Guid("ed9a79d9-fe9d-456e-a0a7-2a028cbe1013"), "Wes Anderson" },
                    { new Guid("ed9a79d9-fe9d-456e-a0a7-2a028cbe1014"), "Coen Brothers" },
                    { new Guid("ed9a79d9-fe9d-456e-a0a7-2a028cbe1015"), "Jade Halley Bartlett" },
                    { new Guid("ed9a79d9-fe9d-456e-a0a7-2a028cbe1016"), "Tim Burton" },
                    { new Guid("ed9a79d9-fe9d-456e-a0a7-2a028cbe1017"), "David Lynch" },
                    { new Guid("ed9a79d9-fe9d-456e-a0a7-2a028cbe1018"), "Spike Lee" },
                    { new Guid("ed9a79d9-fe9d-456e-a0a7-2a028cbe1019"), "Darren Aronofsky" },
                    { new Guid("ed9a79d9-fe9d-456e-a0a7-2a028cbe1020"), "Paul Thomas Anderson" },
                    { new Guid("ed9a79d9-fe9d-456e-a0a7-2a028cbe1021"), "Terrence Malick" },
                    { new Guid("ed9a79d9-fe9d-456e-a0a7-2a028cbe1022"), "Michael Bay" },
                    { new Guid("ed9a79d9-fe9d-456e-a0a7-2a028cbe1023"), "Zack Snyder" },
                    { new Guid("ed9a79d9-fe9d-456e-a0a7-2a028cbe1024"), "Denis Villeneuve" }
                });

            migrationBuilder.InsertData(
                table: "Genre",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82265"), "Sci-Fi" },
                    { new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82266"), "Romance" },
                    { new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82267"), "Horror" },
                    { new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82268"), "Fantasy" },
                    { new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82269"), "Mystery" },
                    { new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82270"), "Adventure" },
                    { new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82271"), "Crime" },
                    { new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82272"), "Family" },
                    { new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82273"), "Animation" },
                    { new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82274"), "Biography" },
                    { new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82275"), "History" },
                    { new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82276"), "War" }
                });

            migrationBuilder.InsertData(
                table: "Hall",
                columns: new[] { "Id", "Capacity", "RowsCapacity" },
                values: new object[,]
                {
                    { new Guid("d67b95a0-b12e-4574-b9ec-634b11f8df43"), 80, "[8,8,8,8,8,8,8,8,8,8]" },
                    { new Guid("d67b95a0-b12e-4574-b9ec-634b11f8df44"), 120, "[12,12,12,12,12,12,12,12,12,12]" }
                });

            migrationBuilder.InsertData(
                table: "Movie",
                columns: new[] { "Id", "AgeRestriction", "Description", "DirectorId", "Duration", "ImageUrl", "Name", "ReleaseDate", "TrailerUrl" },
                values: new object[,]
                {
                    { new Guid("9344f562-ffdc-41c5-bb24-c41c969534c3"), "PG-13", "A thief enters dreams to steal secrets but must plant an idea instead.", new Guid("ed9a79d9-fe9d-456e-a0a7-2a028cbe1002"), 148, "https://upload.wikimedia.org/wikipedia/en/7/7f/Inception_ver3.jpg", "Inception", new DateTime(2010, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://www.youtube.com/watch?v=8hP9D6kZseM" },
                    { new Guid("9344f562-ffdc-41c5-bb24-c41c969534c4"), "R", "A banker is sentenced to life in Shawshank Prison and forms a deep friendship.", new Guid("ed9a79d9-fe9d-456e-a0a7-2a028cbe1003"), 142, "https://upload.wikimedia.org/wikipedia/en/8/81/ShawshankRedemptionMoviePoster.jpg", "The Shawshank Redemption", new DateTime(1994, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://www.youtube.com/watch?v=6hB3S9bIaco" }
                });

            migrationBuilder.InsertData(
                table: "MovieGenre",
                columns: new[] { "GenreId", "MovieId" },
                values: new object[,]
                {
                    { new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82263"), new Guid("9344f562-ffdc-41c5-bb24-c41c969534c1") },
                    { new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82261"), new Guid("9344f562-ffdc-41c5-bb24-c41c969534c2") }
                });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "Id",
                keyValue: new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82261"),
                columns: new[] { "CreatedById", "CreatedByName", "CreatedOnUtc" },
                values: new object[] { new Guid("97f6d0bc-62c9-45d2-a608-c413d5be17d7"), "johndoe", new DateTime(2024, 5, 19, 17, 49, 19, 500, DateTimeKind.Utc).AddTicks(1593) });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "Id",
                keyValue: new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82262"),
                columns: new[] { "CreatedById", "CreatedByName", "CreatedOnUtc" },
                values: new object[] { new Guid("97f6d0bc-62c9-45d2-a608-c413d5be17d7"), "johndoe", new DateTime(2024, 5, 19, 17, 49, 19, 500, DateTimeKind.Utc).AddTicks(2826) });

            migrationBuilder.InsertData(
                table: "Session",
                columns: new[] { "Id", "BasePrice", "DateUtc", "HallId", "MovieId" },
                values: new object[] { new Guid("dcee07f7-e8c6-4e95-a5b0-dc0ea0a5613f"), 265m, new DateTime(2024, 5, 28, 5, 49, 19, 501, DateTimeKind.Utc).AddTicks(6780), new Guid("d67b95a0-b12e-4574-b9ec-634b11f8df42"), new Guid("9344f562-ffdc-41c5-bb24-c41c969534c2") });

            migrationBuilder.InsertData(
                table: "ActorMovie",
                columns: new[] { "ActorId", "MovieId" },
                values: new object[,]
                {
                    { new Guid("aad5caaa-a45d-490a-b26d-d503b6a82266"), new Guid("9344f562-ffdc-41c5-bb24-c41c969534c2") },
                    { new Guid("aad5caaa-a45d-490a-b26d-d503b6a82269"), new Guid("9344f562-ffdc-41c5-bb24-c41c969534c3") },
                    { new Guid("aad5caaa-a45d-490a-b26d-d503b6a82270"), new Guid("9344f562-ffdc-41c5-bb24-c41c969534c4") },
                    { new Guid("aad5caaa-a45d-490a-b26d-d503b6a82275"), new Guid("9344f562-ffdc-41c5-bb24-c41c969534c2") },
                    { new Guid("aad5caaa-a45d-490a-b26d-d503b6a82275"), new Guid("9344f562-ffdc-41c5-bb24-c41c969534c3") },
                    { new Guid("aad5caaa-a45d-490a-b26d-d503b6a82279"), new Guid("9344f562-ffdc-41c5-bb24-c41c969534c1") },
                    { new Guid("aad5caaa-a45d-490a-b26d-d503b6a82281"), new Guid("9344f562-ffdc-41c5-bb24-c41c969534c3") }
                });

            migrationBuilder.InsertData(
                table: "Movie",
                columns: new[] { "Id", "AgeRestriction", "Description", "DirectorId", "Duration", "ImageUrl", "Name", "ReleaseDate", "TrailerUrl" },
                values: new object[,]
                {
                    { new Guid("9344f562-ffdc-41c5-bb24-c41c96953410"), "PG-13", "A young hobbit sets out to destroy a powerful ring.", new Guid("ed9a79d9-fe9d-456e-a0a7-2a028cbe1009"), 178, "https://upload.wikimedia.org/wikipedia/en/0/0c/The_Lord_of_the_Rings_The_Fellowship_of_the_Ring_%282001%29.jpg", "The Lord of the Rings: The Fellowship of the Ring", new DateTime(2001, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://www.youtube.com/watch?v=V75dMMIW2B4" },
                    { new Guid("9344f562-ffdc-41c5-bb24-c41c96953411"), "PG-13", "The presidencies of Kennedy and Johnson through the eyes of a man with low IQ.", new Guid("ed9a79d9-fe9d-456e-a0a7-2a028cbe1010"), 142, "https://upload.wikimedia.org/wikipedia/en/6/67/Forrest_Gump_poster.jpg", "Forrest Gump", new DateTime(1994, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://www.youtube.com/watch?v=bLvqoHBptjg" },
                    { new Guid("9344f562-ffdc-41c5-bb24-c41c96953412"), "R", "A former Roman General seeks vengeance against the corrupt emperor.", new Guid("ed9a79d9-fe9d-456e-a0a7-2a028cbe1011"), 155, "https://upload.wikimedia.org/wikipedia/en/8/8d/Gladiator_ver1.jpg", "Gladiator", new DateTime(2000, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://www.youtube.com/watch?v=owK1qxDselE" },
                    { new Guid("9344f562-ffdc-41c5-bb24-c41c96953413"), "R", "Following the Normandy Landings, a group of U.S. soldiers go behind enemy lines.", new Guid("ed9a79d9-fe9d-456e-a0a7-2a028cbe1012"), 169, "https://upload.wikimedia.org/wikipedia/en/a/ac/Saving_Private_Ryan_poster.jpg", "Saving Private Ryan", new DateTime(1998, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://www.youtube.com/watch?v=RYID71hYHzg" },
                    { new Guid("9344f562-ffdc-41c5-bb24-c41c96953414"), "R", "In German-occupied Poland during World War II, Oskar Schindler gradually becomes concerned for his Jewish workforce.", new Guid("ed9a79d9-fe9d-456e-a0a7-2a028cbe1013"), 195, "https://upload.wikimedia.org/wikipedia/en/3/38/Schindler%27s_List_movie.jpg", "Schindler's List", new DateTime(1993, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://www.youtube.com/watch?v=gG22XNhtnoY" },
                    { new Guid("9344f562-ffdc-41c5-bb24-c41c96953415"), "PG-13", "A seventeen-year-old aristocrat falls in love with a kind but poor artist aboard the luxurious, ill-fated R.M.S. Titanic.", new Guid("ed9a79d9-fe9d-456e-a0a7-2a028cbe1014"), 195, "https://upload.wikimedia.org/wikipedia/en/2/22/Titanic_poster.jpg", "Titanic", new DateTime(1997, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://www.youtube.com/watch?v=2e-eXJ6HgkQ" },
                    { new Guid("9344f562-ffdc-41c5-bb24-c41c96953416"), "R", "A young F.B.I. cadet must receive the help of an incarcerated and manipulative cannibal killer to catch another serial killer.", new Guid("ed9a79d9-fe9d-456e-a0a7-2a028cbe1015"), 118, "https://upload.wikimedia.org/wikipedia/en/8/86/The_Silence_of_the_Lambs_poster.jpg", "The Silence of the Lambs", new DateTime(1991, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://www.youtube.com/watch?v=RuX2MQeb8UM" },
                    { new Guid("9344f562-ffdc-41c5-bb24-c41c96953417"), "R", "The lives of guards on Death Row are affected by one of their charges", new Guid("ed9a79d9-fe9d-456e-a0a7-2a028cbe1016"), 189, "https://upload.wikimedia.org/wikipedia/en/e/e2/The_Green_Mile_%28movie_poster%29.jpg", "The Green Mile", new DateTime(1999, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://www.youtube.com/watch?v=ctRK-4Vt7dA" },
                    { new Guid("9344f562-ffdc-41c5-bb24-c41c96953418"), "R", "An undercover cop and a mole in the police attempt to identify each other while infiltrating an Irish gang in South Boston.", new Guid("ed9a79d9-fe9d-456e-a0a7-2a028cbe1017"), 151, "https://upload.wikimedia.org/wikipedia/en/5/50/Departed234.jpg", "The Departed", new DateTime(2006, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://www.youtube.com/watch?v=auYbpnEwBBg" },
                    { new Guid("9344f562-ffdc-41c5-bb24-c41c96953419"), "PG-13", "After a tragic accident, two stage magicians engage in a battle to create the ultimate illusion while sacrificing everything they have to outwit each other.", new Guid("ed9a79d9-fe9d-456e-a0a7-2a028cbe1018"), 130, "https://upload.wikimedia.org/wikipedia/en/d/d2/Prestige_poster.jpg", "The Prestige", new DateTime(2006, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://www.youtube.com/watch?v=o4gHCmTQDVI" },
                    { new Guid("9344f562-ffdc-41c5-bb24-c41c96953420"), "R", "Imaginary is a 2024 American supernatural horror film directed and produced by Jeff Wadlow and written by Wadlow and the writing team of Greg Erb and Jason Oremland.", new Guid("ed9a79d9-fe9d-456e-a0a7-2a028cbe1019"), 180, "https://upload.wikimedia.org/wikipedia/en/7/7f/Imaginary.jpg", "Imaginary", new DateTime(2024, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://www.youtube.com/watch?v=8hP9D6kZseM" },
                    { new Guid("9344f562-ffdc-41c5-bb24-c41c96953421"), "PG-13", "Godzilla x Kong: The New Empire is a 2024 American monster film directed by Adam Wingard. Produced by Legendary Pictures and distributed by Warner Bros. Pictures, it is the sequel to Godzilla vs. Kong (2021) and the fifth film in the Monsterverse franchise, also serving as the 38th film of the Godzilla franchise and 13th in the King Kong franchise. ", new Guid("ed9a79d9-fe9d-456e-a0a7-2a028cbe1020"), 180, "https://upload.wikimedia.org/wikipedia/en/7/7f/Godzilla_x_Kong_The_New_Empire.jpg", "Godzilla x Kong: The New Empire", new DateTime(2024, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://www.youtube.com/watch?v=8hP9D6kZseM" },
                    { new Guid("9344f562-ffdc-41c5-bb24-c41c96953422"), "PG-13", "The Three Musketeers: Milady is a 2024 American action-adventure film directed by Paul W.S. Anderson and written by Alex Litvak and Andrew Davies. The film is based on the 1844 novel The Three Musketeers by Alexandre Dumas. It is a reboot of the 2011 film of the same name and stars Logan Lerman, Ray Stevenson, Luke Evans, Milla Jovovich, Orlando Bloom, and Christoph Waltz.", new Guid("ed9a79d9-fe9d-456e-a0a7-2a028cbe1021"), 135, "https://upload.wikimedia.org/wikipedia/en/7/7f/The_Three_Musketeers_Milady.jpg", "The Three Musketeers: Milady", new DateTime(2023, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://www.youtube.com/watch?v=8hP9D6kZseM" },
                    { new Guid("9344f562-ffdc-41c5-bb24-c41c96953423"), "PG-13", "Rebel Moon – Part Two: The Scargiver is an upcoming American science fiction film directed by Zack Snyder and co-written by Snyder, Shay Hatten, and Kurt Johnstad. The film stars Sofia Boutella, Charlie Hunnam, Ray Fisher, Djimon Hounsou, and Doona Bae.", new Guid("ed9a79d9-fe9d-456e-a0a7-2a028cbe1022"), 122, "https://upload.wikimedia.org/wikipedia/en/7/7f/Rebel_Moon_Part_Two_The_Scargiver.jpg", "Rebel Moon – Part Two: The Scargiver", new DateTime(2024, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://www.youtube.com/watch?v=8hP9D6kZseM" },
                    { new Guid("9344f562-ffdc-41c5-bb24-c41c96953424"), "PG-13", "Dune: Part Two is an upcoming American epic science fiction film directed by Denis Villeneuve and written by Jon Spaihts, Villeneuve, and Eric Roth. It is the second of a planned two-part adaptation of the 1965 novel of the same name by Frank Herbert, and will cover the second half of the book.", new Guid("ed9a79d9-fe9d-456e-a0a7-2a028cbe1023"), 165, "https://upload.wikimedia.org/wikipedia/en/thumb/5/52/Dune_Part_Two_poster.jpeg/220px-Dune_Part_Two_poster.jpeg", "Dune: Part Two", new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://www.youtube.com/watch?v=8hP9D6kZseM" },
                    { new Guid("9344f562-ffdc-41c5-bb24-c41c969534c5"), "PG-13", "Batman faces the Joker, who wreaks havoc in Gotham City.", new Guid("ed9a79d9-fe9d-456e-a0a7-2a028cbe1004"), 152, "https://upload.wikimedia.org/wikipedia/en/8/8a/Dark_Knight.jpg", "The Dark Knight", new DateTime(2008, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://www.youtube.com/watch?v=EXeTwQWrcwY" },
                    { new Guid("9344f562-ffdc-41c5-bb24-c41c969534c6"), "R", "Interwoven stories of crime in Los Angeles.", new Guid("ed9a79d9-fe9d-456e-a0a7-2a028cbe1005"), 154, "https://upload.wikimedia.org/wikipedia/en/8/82/Pulp_Fiction_cover.jpg", "Pulp Fiction", new DateTime(1994, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://www.youtube.com/watch?v=s7EdQ4FqbhY" },
                    { new Guid("9344f562-ffdc-41c5-bb24-c41c969534c7"), "R", "An insomniac forms an underground fight club with a soap salesman.", new Guid("ed9a79d9-fe9d-456e-a0a7-2a028cbe1006"), 139, "https://upload.wikimedia.org/wikipedia/en/f/fc/Fight_Club_poster.jpg", "Fight Club", new DateTime(1999, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://www.youtube.com/watch?v=SUXWAEX2jlg" },
                    { new Guid("9344f562-ffdc-41c5-bb24-c41c969534c8"), "R", "A hacker learns the true nature of his reality and his role in the war against its controllers.", new Guid("ed9a79d9-fe9d-456e-a0a7-2a028cbe1007"), 136, "https://upload.wikimedia.org/wikipedia/en/c/c1/The_Matrix_Poster.jpg", "The Matrix", new DateTime(1999, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://www.youtube.com/watch?v=vKQi3bBA1y8" },
                    { new Guid("9344f562-ffdc-41c5-bb24-c41c969534c9"), "R", "The aging patriarch of an organized crime dynasty transfers control to his reluctant son.", new Guid("ed9a79d9-fe9d-456e-a0a7-2a028cbe1008"), 175, "https://upload.wikimedia.org/wikipedia/en/1/1c/Godfather_ver1.jpg", "The Godfather", new DateTime(1972, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://www.youtube.com/watch?v=sY1S34973zA" }
                });

            migrationBuilder.InsertData(
                table: "MovieGenre",
                columns: new[] { "GenreId", "MovieId" },
                values: new object[,]
                {
                    { new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82265"), new Guid("9344f562-ffdc-41c5-bb24-c41c969534c2") },
                    { new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82276"), new Guid("9344f562-ffdc-41c5-bb24-c41c969534c2") },
                    { new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82271"), new Guid("9344f562-ffdc-41c5-bb24-c41c969534c3") },
                    { new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82276"), new Guid("9344f562-ffdc-41c5-bb24-c41c969534c3") },
                    { new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82275"), new Guid("9344f562-ffdc-41c5-bb24-c41c969534c4") }
                });

            migrationBuilder.InsertData(
                table: "MovieImageSet",
                columns: new[] { "MovieId", "ImagesUrl" },
                values: new object[,]
                {
                    { new Guid("9344f562-ffdc-41c5-bb24-c41c969534c3"), "['https://upload.wikimedia.org/wikipedia/en/7/7f/Inception_ver3.jpg','https://upload.wikimedia.org/wikipedia/en/2/20/Inception_2010_poster.jpg']" },
                    { new Guid("9344f562-ffdc-41c5-bb24-c41c969534c4"), "['https://upload.wikimedia.org/wikipedia/en/8/81/ShawshankRedemptionMoviePoster.jpg','https://upload.wikimedia.org/wikipedia/en/4/4a/The_Shawshank_Redemption.jpg']" }
                });

            migrationBuilder.InsertData(
                table: "Session",
                columns: new[] { "Id", "BasePrice", "DateUtc", "HallId", "MovieId" },
                values: new object[,]
                {
                    { new Guid("06013bca-e006-451a-aaea-85688b14de98"), 136m, new DateTime(2024, 5, 10, 1, 49, 19, 501, DateTimeKind.Utc).AddTicks(6780), new Guid("d67b95a0-b12e-4574-b9ec-634b11f8df41"), new Guid("9344f562-ffdc-41c5-bb24-c41c969534c4") },
                    { new Guid("31de204b-3740-4b15-a2fc-4943f2b38bdd"), 260m, new DateTime(2024, 5, 18, 21, 49, 19, 501, DateTimeKind.Utc).AddTicks(6780), new Guid("d67b95a0-b12e-4574-b9ec-634b11f8df41"), new Guid("9344f562-ffdc-41c5-bb24-c41c969534c3") },
                    { new Guid("41a9ea82-acf1-4e94-acf1-4c95ca5348a4"), 245m, new DateTime(2024, 5, 26, 17, 49, 19, 501, DateTimeKind.Utc).AddTicks(6780), new Guid("d67b95a0-b12e-4574-b9ec-634b11f8df43"), new Guid("9344f562-ffdc-41c5-bb24-c41c969534c2") },
                    { new Guid("45d5285d-2493-40f3-82cb-e4d90b1f1b8e"), 298m, new DateTime(2024, 5, 19, 5, 49, 19, 501, DateTimeKind.Utc).AddTicks(6780), new Guid("d67b95a0-b12e-4574-b9ec-634b11f8df42"), new Guid("9344f562-ffdc-41c5-bb24-c41c969534c4") },
                    { new Guid("4fefce7b-637b-4cfc-b9ff-bb1e6e9f5ad7"), 222m, new DateTime(2024, 5, 15, 1, 49, 19, 501, DateTimeKind.Utc).AddTicks(6780), new Guid("d67b95a0-b12e-4574-b9ec-634b11f8df41"), new Guid("9344f562-ffdc-41c5-bb24-c41c969534c4") },
                    { new Guid("fe9766ee-75f0-4c1e-aacf-383a2881c6ad"), 224m, new DateTime(2024, 5, 20, 21, 49, 19, 501, DateTimeKind.Utc).AddTicks(6780), new Guid("d67b95a0-b12e-4574-b9ec-634b11f8df43"), new Guid("9344f562-ffdc-41c5-bb24-c41c969534c1") }
                });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "HallId", "PlaceIndex", "RowIndex", "SessionId", "UserId" },
                values: new object[] { new Guid("63c38860-61d0-48bd-bfa7-ddce5c926cea"), new Guid("d67b95a0-b12e-4574-b9ec-634b11f8df42"), 1, 2, new Guid("dcee07f7-e8c6-4e95-a5b0-dc0ea0a5613f"), new Guid("8a0c9ce1-9a97-4252-a5a5-cc1df45f9cbc") });

            migrationBuilder.InsertData(
                table: "ActorMovie",
                columns: new[] { "ActorId", "MovieId" },
                values: new object[,]
                {
                    { new Guid("aad5caaa-a45d-490a-b26d-d503b6a82262"), new Guid("9344f562-ffdc-41c5-bb24-c41c96953419") },
                    { new Guid("aad5caaa-a45d-490a-b26d-d503b6a82263"), new Guid("9344f562-ffdc-41c5-bb24-c41c96953413") },
                    { new Guid("aad5caaa-a45d-490a-b26d-d503b6a82263"), new Guid("9344f562-ffdc-41c5-bb24-c41c969534c6") },
                    { new Guid("aad5caaa-a45d-490a-b26d-d503b6a82263"), new Guid("9344f562-ffdc-41c5-bb24-c41c969534c7") },
                    { new Guid("aad5caaa-a45d-490a-b26d-d503b6a82264"), new Guid("9344f562-ffdc-41c5-bb24-c41c969534c6") },
                    { new Guid("aad5caaa-a45d-490a-b26d-d503b6a82264"), new Guid("9344f562-ffdc-41c5-bb24-c41c969534c8") },
                    { new Guid("aad5caaa-a45d-490a-b26d-d503b6a82267"), new Guid("9344f562-ffdc-41c5-bb24-c41c96953417") },
                    { new Guid("aad5caaa-a45d-490a-b26d-d503b6a82268"), new Guid("9344f562-ffdc-41c5-bb24-c41c96953416") },
                    { new Guid("aad5caaa-a45d-490a-b26d-d503b6a82269"), new Guid("9344f562-ffdc-41c5-bb24-c41c96953411") },
                    { new Guid("aad5caaa-a45d-490a-b26d-d503b6a82270"), new Guid("9344f562-ffdc-41c5-bb24-c41c96953423") },
                    { new Guid("aad5caaa-a45d-490a-b26d-d503b6a82272"), new Guid("9344f562-ffdc-41c5-bb24-c41c969534c8") },
                    { new Guid("aad5caaa-a45d-490a-b26d-d503b6a82272"), new Guid("9344f562-ffdc-41c5-bb24-c41c969534c9") },
                    { new Guid("aad5caaa-a45d-490a-b26d-d503b6a82273"), new Guid("9344f562-ffdc-41c5-bb24-c41c96953423") },
                    { new Guid("aad5caaa-a45d-490a-b26d-d503b6a82273"), new Guid("9344f562-ffdc-41c5-bb24-c41c969534c5") },
                    { new Guid("aad5caaa-a45d-490a-b26d-d503b6a82274"), new Guid("9344f562-ffdc-41c5-bb24-c41c96953410") },
                    { new Guid("aad5caaa-a45d-490a-b26d-d503b6a82274"), new Guid("9344f562-ffdc-41c5-bb24-c41c96953420") },
                    { new Guid("aad5caaa-a45d-490a-b26d-d503b6a82274"), new Guid("9344f562-ffdc-41c5-bb24-c41c96953422") },
                    { new Guid("aad5caaa-a45d-490a-b26d-d503b6a82274"), new Guid("9344f562-ffdc-41c5-bb24-c41c96953423") },
                    { new Guid("aad5caaa-a45d-490a-b26d-d503b6a82275"), new Guid("9344f562-ffdc-41c5-bb24-c41c96953419") },
                    { new Guid("aad5caaa-a45d-490a-b26d-d503b6a82275"), new Guid("9344f562-ffdc-41c5-bb24-c41c969534c9") },
                    { new Guid("aad5caaa-a45d-490a-b26d-d503b6a82276"), new Guid("9344f562-ffdc-41c5-bb24-c41c96953411") },
                    { new Guid("aad5caaa-a45d-490a-b26d-d503b6a82276"), new Guid("9344f562-ffdc-41c5-bb24-c41c96953413") },
                    { new Guid("aad5caaa-a45d-490a-b26d-d503b6a82276"), new Guid("9344f562-ffdc-41c5-bb24-c41c96953424") },
                    { new Guid("aad5caaa-a45d-490a-b26d-d503b6a82276"), new Guid("9344f562-ffdc-41c5-bb24-c41c969534c5") },
                    { new Guid("aad5caaa-a45d-490a-b26d-d503b6a82278"), new Guid("9344f562-ffdc-41c5-bb24-c41c96953417") },
                    { new Guid("aad5caaa-a45d-490a-b26d-d503b6a82278"), new Guid("9344f562-ffdc-41c5-bb24-c41c96953421") },
                    { new Guid("aad5caaa-a45d-490a-b26d-d503b6a82279"), new Guid("9344f562-ffdc-41c5-bb24-c41c96953421") },
                    { new Guid("aad5caaa-a45d-490a-b26d-d503b6a82279"), new Guid("9344f562-ffdc-41c5-bb24-c41c969534c6") },
                    { new Guid("aad5caaa-a45d-490a-b26d-d503b6a82280"), new Guid("9344f562-ffdc-41c5-bb24-c41c96953414") },
                    { new Guid("aad5caaa-a45d-490a-b26d-d503b6a82281"), new Guid("9344f562-ffdc-41c5-bb24-c41c96953410") },
                    { new Guid("aad5caaa-a45d-490a-b26d-d503b6a82281"), new Guid("9344f562-ffdc-41c5-bb24-c41c969534c9") },
                    { new Guid("aad5caaa-a45d-490a-b26d-d503b6a82282"), new Guid("9344f562-ffdc-41c5-bb24-c41c96953411") },
                    { new Guid("aad5caaa-a45d-490a-b26d-d503b6a82282"), new Guid("9344f562-ffdc-41c5-bb24-c41c96953418") },
                    { new Guid("aad5caaa-a45d-490a-b26d-d503b6a82283"), new Guid("9344f562-ffdc-41c5-bb24-c41c96953410") },
                    { new Guid("aad5caaa-a45d-490a-b26d-d503b6a82283"), new Guid("9344f562-ffdc-41c5-bb24-c41c96953412") },
                    { new Guid("aad5caaa-a45d-490a-b26d-d503b6a82283"), new Guid("9344f562-ffdc-41c5-bb24-c41c96953413") },
                    { new Guid("aad5caaa-a45d-490a-b26d-d503b6a82283"), new Guid("9344f562-ffdc-41c5-bb24-c41c96953415") },
                    { new Guid("aad5caaa-a45d-490a-b26d-d503b6a82284"), new Guid("9344f562-ffdc-41c5-bb24-c41c969534c5") }
                });

            migrationBuilder.InsertData(
                table: "Invoice",
                columns: new[] { "Id", "Amount", "CreateDateUtc", "Status", "TicketId", "UserId" },
                values: new object[] { new Guid("bec6bd3d-4d76-422c-bc9e-4bfa7d0dc076"), 265, new DateTime(2024, 5, 27, 13, 49, 19, 501, DateTimeKind.Utc).AddTicks(6780), true, new Guid("63c38860-61d0-48bd-bfa7-ddce5c926cea"), new Guid("8a0c9ce1-9a97-4252-a5a5-cc1df45f9cbc") });

            migrationBuilder.InsertData(
                table: "MovieGenre",
                columns: new[] { "GenreId", "MovieId" },
                values: new object[,]
                {
                    { new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82268"), new Guid("9344f562-ffdc-41c5-bb24-c41c96953410") },
                    { new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82274"), new Guid("9344f562-ffdc-41c5-bb24-c41c96953410") },
                    { new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82263"), new Guid("9344f562-ffdc-41c5-bb24-c41c96953411") },
                    { new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82263"), new Guid("9344f562-ffdc-41c5-bb24-c41c96953412") },
                    { new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82272"), new Guid("9344f562-ffdc-41c5-bb24-c41c96953413") },
                    { new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82262"), new Guid("9344f562-ffdc-41c5-bb24-c41c96953414") },
                    { new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82266"), new Guid("9344f562-ffdc-41c5-bb24-c41c96953414") },
                    { new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82266"), new Guid("9344f562-ffdc-41c5-bb24-c41c96953415") },
                    { new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82273"), new Guid("9344f562-ffdc-41c5-bb24-c41c96953415") },
                    { new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82276"), new Guid("9344f562-ffdc-41c5-bb24-c41c96953415") },
                    { new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82270"), new Guid("9344f562-ffdc-41c5-bb24-c41c96953416") },
                    { new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82262"), new Guid("9344f562-ffdc-41c5-bb24-c41c96953417") },
                    { new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82273"), new Guid("9344f562-ffdc-41c5-bb24-c41c96953417") },
                    { new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82274"), new Guid("9344f562-ffdc-41c5-bb24-c41c96953417") },
                    { new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82265"), new Guid("9344f562-ffdc-41c5-bb24-c41c96953418") },
                    { new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82268"), new Guid("9344f562-ffdc-41c5-bb24-c41c96953418") },
                    { new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82267"), new Guid("9344f562-ffdc-41c5-bb24-c41c96953419") },
                    { new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82271"), new Guid("9344f562-ffdc-41c5-bb24-c41c96953419") },
                    { new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82262"), new Guid("9344f562-ffdc-41c5-bb24-c41c96953420") },
                    { new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82271"), new Guid("9344f562-ffdc-41c5-bb24-c41c96953420") },
                    { new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82267"), new Guid("9344f562-ffdc-41c5-bb24-c41c96953421") },
                    { new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82268"), new Guid("9344f562-ffdc-41c5-bb24-c41c96953421") },
                    { new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82269"), new Guid("9344f562-ffdc-41c5-bb24-c41c96953421") },
                    { new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82272"), new Guid("9344f562-ffdc-41c5-bb24-c41c96953422") },
                    { new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82275"), new Guid("9344f562-ffdc-41c5-bb24-c41c96953423") },
                    { new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82276"), new Guid("9344f562-ffdc-41c5-bb24-c41c96953423") },
                    { new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82261"), new Guid("9344f562-ffdc-41c5-bb24-c41c96953424") },
                    { new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82262"), new Guid("9344f562-ffdc-41c5-bb24-c41c969534c5") },
                    { new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82263"), new Guid("9344f562-ffdc-41c5-bb24-c41c969534c6") },
                    { new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82261"), new Guid("9344f562-ffdc-41c5-bb24-c41c969534c7") },
                    { new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82268"), new Guid("9344f562-ffdc-41c5-bb24-c41c969534c7") },
                    { new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82264"), new Guid("9344f562-ffdc-41c5-bb24-c41c969534c8") },
                    { new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82272"), new Guid("9344f562-ffdc-41c5-bb24-c41c969534c8") },
                    { new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82267"), new Guid("9344f562-ffdc-41c5-bb24-c41c969534c9") },
                    { new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82269"), new Guid("9344f562-ffdc-41c5-bb24-c41c969534c9") },
                    { new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82274"), new Guid("9344f562-ffdc-41c5-bb24-c41c969534c9") }
                });

            migrationBuilder.InsertData(
                table: "MovieImageSet",
                columns: new[] { "MovieId", "ImagesUrl" },
                values: new object[,]
                {
                    { new Guid("9344f562-ffdc-41c5-bb24-c41c96953410"), "['https://substackcdn.com/image/fetch/f_auto,q_auto:good,fl_progressive:steep/https%3A%2F%2Fbucketeer-e05bbc84-baa3-437e-9518-adb32be77984.s3.amazonaws.com%2Fpublic%2Fimages%2Fa3398191-dfd5-4250-9d51-c75b826d4999_700x376.jpeg','https://filmgrab.files.wordpress.com/2014/08/2240.jpg']" },
                    { new Guid("9344f562-ffdc-41c5-bb24-c41c96953411"), "['https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTlZ8Mrnf0SGZJftfaAErcPT1avLfw9Xz4xJs1IkDMmpwqrfyGsW1ALaesy4lpv7UPc9aQ&usqp=CAU','https://cdn.aarp.net/content/dam/aarp/entertainment/movies-for-grownups/2022/03/1140-forrest-gump-bench.jpg']" },
                    { new Guid("9344f562-ffdc-41c5-bb24-c41c96953412"), "['https://static.cnews.fr/sites/default/files/gladiator_2_6618f72b7d4f2_0.jpg','https://cdn.britannica.com/93/77293-050-CF984388/Russell-Crowe-Gladiator.jpg']" },
                    { new Guid("9344f562-ffdc-41c5-bb24-c41c96953413"), "['https://pbs.twimg.com/media/Dv7wf7ZXgAA7OBF.jpg:large','https://cdn.theasc.com/Saving-Pvt-Ryan-CTS1597.jpg']" },
                    { new Guid("9344f562-ffdc-41c5-bb24-c41c96953414"), "['https://i.guim.co.uk/img/media/208d00c732eeed823ec55afe35faf252843e0c59/0_0_2520_1760/master/2520.jpg?width=700&quality=85&auto=format&fit=max&s=dee8947155aa30b56963e4d95b729d5f','https://images.sbs.com.au/dims4/default/e6c27a3/2147483647/strip/true/crop/704x396+0+0/resize/1280x720!/quality/90/?url=http%3A%2F%2Fsbs-au-brightspot.s3.amazonaws.com%2Fdrupal%2Ffilm%2Fpublic%2Fschindlers_list_704_2.jpg']" },
                    { new Guid("9344f562-ffdc-41c5-bb24-c41c96953415"), "['https://i.cbc.ca/1.6690550.1671412533!/fileImage/httpImage/image.jpg_gen/derivatives/original_780/titanic.jpg','https://cdn.britannica.com/67/238367-050-3898D4B0/Kate-Winslet-Leonard-DiCaprio-Titanic.jpg']" },
                    { new Guid("9344f562-ffdc-41c5-bb24-c41c96953416"), "['https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSvYcE9vV4w5U37CkCM0YvsJ0H1mjiOZuBAl14dDDUF8l0nACjLu7sZllEUWtkWK8IfxMc&usqp=CAU','https://m.media-amazon.com/images/M/MV5BN2ZiYzIyMWQtNDUyNy00YmExLWIwNmMtN2FhNzFiODgyYmU4XkEyXkFqcGdeQXRodW1ibmFpbC1pbml0aWFsaXplcg@@._V1_.jpg']" },
                    { new Guid("9344f562-ffdc-41c5-bb24-c41c96953417"), "['https://www.pluggedin.com/wp-content/uploads/2019/12/the-green-mile-1024x683.jpg','https://static1.srcdn.com/wordpress/wp-content/uploads/2022/03/The-Green-Mile-Michael-Clarke-Duncan-Tom-Hanks.png']" },
                    { new Guid("9344f562-ffdc-41c5-bb24-c41c96953418"), "['https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTSqVGfDxiHVJCZFluHKhEAojSr-2MfIIbHIQ&usqp=CAU']" },
                    { new Guid("9344f562-ffdc-41c5-bb24-c41c96953419"), "['https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRiddcprC5QvCaKgIgCuKYEWmBvG3HJkgZWjkK6SI3XVgrR2Fpkg8I-7d3hmzKUFKe6g-s&usqp=CAU','https://images-1.rakuten.tv/storage/snapshot/shot/013abb91-ed18-4e10-ae37-bef2550653ad-snapshot-1590664694-width936-quality15.jpeg']" },
                    { new Guid("9344f562-ffdc-41c5-bb24-c41c96953420"), "['https://i.ytimg.com/vi/7O5v9-l7kwM/sddefault.jpg','https://i.ytimg.com/vi/H2gtae-2ioQ/hq720.jpg?sqp=-oaymwEhCK4FEIIDSFryq4qpAxMIARUAAAAAGAElAADIQj0AgKJD&rs=AOn4CLCK2nXn3w_p8Sni__1o8_rVTxa9bg']" },
                    { new Guid("9344f562-ffdc-41c5-bb24-c41c96953421"), "['https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTQeZdXulRxyWVKfjGaf2LvEVVC-eeIKh4JHPOks6sY2meU8mC4Qy_9tnVQpr1l-wgIOyU&usqp=CAU','https://cdn.hobbyconsolas.com/sites/navi.axelspringer.es/public/media/image/2021/02/godzilla-vs-kong-vs-gatete-2242761.jpeg?tf=3840x']" },
                    { new Guid("9344f562-ffdc-41c5-bb24-c41c96953422"), "['https://upload.wikimedia.org/wikipedia/en/thumb/6/69/The_Three_Musketeers_-_D%27Artagnan_%282023%29_film_poster.jpg/220px-The_Three_Musketeers_-_D%27Artagnan_%282023%29_film_poster.jpg']" },
                    { new Guid("9344f562-ffdc-41c5-bb24-c41c96953423"), "['https://upload.wikimedia.org/wikipedia/en/thumb/d/dd/Rebel_Moon_%E2%80%93_Part_Two_The_Scargiver_poster.jpg/220px-Rebel_Moon_%E2%80%93_Part_Two_The_Scargiver_poster.jpg','https://upload.wikimedia.org/wikipedia/en/thumb/d/dd/Rebel_Moon_%E2%80%93_Part_Two_The_Scargiver_poster.jpg/220px-Rebel_Moon_%E2%80%93_Part_Two_The_Scargiver_poster.jpg']" },
                    { new Guid("9344f562-ffdc-41c5-bb24-c41c96953424"), "['https://upload.wikimedia.org/wikipedia/en/thumb/5/52/Dune_Part_Two_poster.jpeg/220px-Dune_Part_Two_poster.jpeg','https://upload.wikimedia.org/wikipedia/en/thumb/5/52/Dune_Part_Two_poster.jpeg/220px-Dune_Part_Two_poster.jpeg']" },
                    { new Guid("9344f562-ffdc-41c5-bb24-c41c969534c5"), "['https://upload.wikimedia.org/wikipedia/en/8/8a/Dark_Knight.jpg','https://upload.wikimedia.org/wikipedia/en/3/3a/Dark_Knight.jpg']" },
                    { new Guid("9344f562-ffdc-41c5-bb24-c41c969534c6"), "['https://upload.wikimedia.org/wikipedia/en/8/82/Pulp_Fiction_cover.jpg','https://upload.wikimedia.org/wikipedia/en/b/b9/Pulp_Fiction.jpg']" },
                    { new Guid("9344f562-ffdc-41c5-bb24-c41c969534c7"), "['https://upload.wikimedia.org/wikipedia/en/f/fc/Fight_Club_poster.jpg','https://upload.wikimedia.org/wikipedia/en/2/29/Fight_Club.jpg']" },
                    { new Guid("9344f562-ffdc-41c5-bb24-c41c969534c8"), "['https://upload.wikimedia.org/wikipedia/en/c/c1/The_Matrix_Poster.jpg','https://upload.wikimedia.org/wikipedia/en/2/2f/The_Matrix_DVD.jpg']" },
                    { new Guid("9344f562-ffdc-41c5-bb24-c41c969534c9"), "['https://upload.wikimedia.org/wikipedia/en/1/1c/Godfather_ver1.jpg','https://upload.wikimedia.org/wikipedia/en/9/91/The_Godfather_I.jpg']" }
                });

            migrationBuilder.InsertData(
                table: "Session",
                columns: new[] { "Id", "BasePrice", "DateUtc", "HallId", "MovieId" },
                values: new object[,]
                {
                    { new Guid("04cdc001-60ea-49cb-bbf3-63a9f765b365"), 214m, new DateTime(2024, 5, 20, 17, 49, 19, 501, DateTimeKind.Utc).AddTicks(6780), new Guid("d67b95a0-b12e-4574-b9ec-634b11f8df42"), new Guid("9344f562-ffdc-41c5-bb24-c41c96953410") },
                    { new Guid("0914438d-0d67-4b60-abce-c3f0d8e31a9c"), 271m, new DateTime(2024, 5, 15, 9, 49, 19, 501, DateTimeKind.Utc).AddTicks(6780), new Guid("d67b95a0-b12e-4574-b9ec-634b11f8df44"), new Guid("9344f562-ffdc-41c5-bb24-c41c969534c7") },
                    { new Guid("0b5d28b2-3fdd-456c-b897-6bd55aff51f6"), 159m, new DateTime(2024, 5, 12, 1, 49, 19, 501, DateTimeKind.Utc).AddTicks(6780), new Guid("d67b95a0-b12e-4574-b9ec-634b11f8df42"), new Guid("9344f562-ffdc-41c5-bb24-c41c969534c9") },
                    { new Guid("0bb00dbe-b0cc-4e78-b7ae-bc6d19bcc7bb"), 178m, new DateTime(2024, 5, 17, 9, 49, 19, 501, DateTimeKind.Utc).AddTicks(6780), new Guid("d67b95a0-b12e-4574-b9ec-634b11f8df43"), new Guid("9344f562-ffdc-41c5-bb24-c41c96953412") },
                    { new Guid("1546a9b1-f2be-4a2d-a12d-5376dcda66e2"), 287m, new DateTime(2024, 5, 10, 13, 49, 19, 501, DateTimeKind.Utc).AddTicks(6780), new Guid("d67b95a0-b12e-4574-b9ec-634b11f8df43"), new Guid("9344f562-ffdc-41c5-bb24-c41c96953413") },
                    { new Guid("17d9592f-c1ac-47c1-a6e8-8c7136c9913e"), 281m, new DateTime(2024, 5, 17, 13, 49, 19, 501, DateTimeKind.Utc).AddTicks(6780), new Guid("d67b95a0-b12e-4574-b9ec-634b11f8df44"), new Guid("9344f562-ffdc-41c5-bb24-c41c96953417") },
                    { new Guid("19fa6fa7-7ef1-483e-bc90-c7e8e4b792c0"), 282m, new DateTime(2024, 5, 12, 9, 49, 19, 501, DateTimeKind.Utc).AddTicks(6780), new Guid("d67b95a0-b12e-4574-b9ec-634b11f8df44"), new Guid("9344f562-ffdc-41c5-bb24-c41c96953418") },
                    { new Guid("1fcf9e98-3a1b-408e-a941-93adb76ef9cb"), 286m, new DateTime(2024, 5, 24, 13, 49, 19, 501, DateTimeKind.Utc).AddTicks(6780), new Guid("d67b95a0-b12e-4574-b9ec-634b11f8df43"), new Guid("9344f562-ffdc-41c5-bb24-c41c96953422") },
                    { new Guid("206c03b1-43ce-46bd-b26e-ce9b99d3700e"), 245m, new DateTime(2024, 5, 19, 13, 49, 19, 501, DateTimeKind.Utc).AddTicks(6780), new Guid("d67b95a0-b12e-4574-b9ec-634b11f8df44"), new Guid("9344f562-ffdc-41c5-bb24-c41c96953415") },
                    { new Guid("206dd353-ac4e-4f7b-9e20-9026fd7c835c"), 193m, new DateTime(2024, 5, 21, 1, 49, 19, 501, DateTimeKind.Utc).AddTicks(6780), new Guid("d67b95a0-b12e-4574-b9ec-634b11f8df44"), new Guid("9344f562-ffdc-41c5-bb24-c41c96953422") },
                    { new Guid("29c84102-f3aa-4791-9cc6-a769edda127d"), 111m, new DateTime(2024, 5, 16, 17, 49, 19, 501, DateTimeKind.Utc).AddTicks(6780), new Guid("d67b95a0-b12e-4574-b9ec-634b11f8df41"), new Guid("9344f562-ffdc-41c5-bb24-c41c96953412") },
                    { new Guid("2f0b9d37-2c7c-45c0-9cee-861ddfe582e3"), 209m, new DateTime(2024, 5, 13, 17, 49, 19, 501, DateTimeKind.Utc).AddTicks(6780), new Guid("d67b95a0-b12e-4574-b9ec-634b11f8df42"), new Guid("9344f562-ffdc-41c5-bb24-c41c96953423") },
                    { new Guid("31e1a290-1337-42d2-876e-3d3287588f71"), 123m, new DateTime(2024, 5, 13, 21, 49, 19, 501, DateTimeKind.Utc).AddTicks(6780), new Guid("d67b95a0-b12e-4574-b9ec-634b11f8df43"), new Guid("9344f562-ffdc-41c5-bb24-c41c96953419") },
                    { new Guid("31ed4410-4b7c-4074-a071-18550afc1350"), 289m, new DateTime(2024, 5, 15, 13, 49, 19, 501, DateTimeKind.Utc).AddTicks(6780), new Guid("d67b95a0-b12e-4574-b9ec-634b11f8df44"), new Guid("9344f562-ffdc-41c5-bb24-c41c96953420") },
                    { new Guid("3d80ce6c-bee5-4503-8f9e-17871cd0a6f0"), 218m, new DateTime(2024, 5, 17, 5, 49, 19, 501, DateTimeKind.Utc).AddTicks(6780), new Guid("d67b95a0-b12e-4574-b9ec-634b11f8df43"), new Guid("9344f562-ffdc-41c5-bb24-c41c96953420") },
                    { new Guid("4ade96ee-66e7-4441-8b97-4492d92bbae7"), 137m, new DateTime(2024, 5, 29, 21, 49, 19, 501, DateTimeKind.Utc).AddTicks(6780), new Guid("d67b95a0-b12e-4574-b9ec-634b11f8df44"), new Guid("9344f562-ffdc-41c5-bb24-c41c96953412") },
                    { new Guid("4c1908d0-9074-4bdb-a120-ee0f4d26f927"), 255m, new DateTime(2024, 5, 22, 21, 49, 19, 501, DateTimeKind.Utc).AddTicks(6780), new Guid("d67b95a0-b12e-4574-b9ec-634b11f8df43"), new Guid("9344f562-ffdc-41c5-bb24-c41c969534c9") },
                    { new Guid("4ebed073-bbd6-4c85-a58d-029f1597f45b"), 254m, new DateTime(2024, 5, 22, 13, 49, 19, 501, DateTimeKind.Utc).AddTicks(6780), new Guid("d67b95a0-b12e-4574-b9ec-634b11f8df42"), new Guid("9344f562-ffdc-41c5-bb24-c41c969534c6") },
                    { new Guid("510bad2e-33d1-44f2-ac2b-0b236e497c97"), 230m, new DateTime(2024, 5, 19, 9, 49, 19, 501, DateTimeKind.Utc).AddTicks(6780), new Guid("d67b95a0-b12e-4574-b9ec-634b11f8df43"), new Guid("9344f562-ffdc-41c5-bb24-c41c96953423") },
                    { new Guid("544d36b5-851a-4402-bce2-89cf499c285f"), 133m, new DateTime(2024, 5, 28, 9, 49, 19, 501, DateTimeKind.Utc).AddTicks(6780), new Guid("d67b95a0-b12e-4574-b9ec-634b11f8df44"), new Guid("9344f562-ffdc-41c5-bb24-c41c96953419") },
                    { new Guid("5518fe9b-e94c-411d-a3cd-5757c945a497"), 289m, new DateTime(2024, 5, 26, 1, 49, 19, 501, DateTimeKind.Utc).AddTicks(6780), new Guid("d67b95a0-b12e-4574-b9ec-634b11f8df41"), new Guid("9344f562-ffdc-41c5-bb24-c41c96953416") },
                    { new Guid("5a537e30-2fa8-4e7d-b48f-aef2c68c62e2"), 291m, new DateTime(2024, 5, 26, 21, 49, 19, 501, DateTimeKind.Utc).AddTicks(6780), new Guid("d67b95a0-b12e-4574-b9ec-634b11f8df44"), new Guid("9344f562-ffdc-41c5-bb24-c41c96953422") },
                    { new Guid("64ed18c8-d18f-43b1-a485-e1a7fd51cbd0"), 121m, new DateTime(2024, 5, 26, 5, 49, 19, 501, DateTimeKind.Utc).AddTicks(6780), new Guid("d67b95a0-b12e-4574-b9ec-634b11f8df42"), new Guid("9344f562-ffdc-41c5-bb24-c41c96953412") },
                    { new Guid("673bc310-5e54-43ab-94f5-6e5abd50cfc5"), 232m, new DateTime(2024, 5, 22, 9, 49, 19, 501, DateTimeKind.Utc).AddTicks(6780), new Guid("d67b95a0-b12e-4574-b9ec-634b11f8df41"), new Guid("9344f562-ffdc-41c5-bb24-c41c96953412") },
                    { new Guid("6b4ff334-0ebe-44dc-ac92-b460fd008ba9"), 202m, new DateTime(2024, 5, 29, 17, 49, 19, 501, DateTimeKind.Utc).AddTicks(6780), new Guid("d67b95a0-b12e-4574-b9ec-634b11f8df43"), new Guid("9344f562-ffdc-41c5-bb24-c41c96953417") },
                    { new Guid("6e248dc9-3edc-4a23-b7e9-749b81ffcc63"), 236m, new DateTime(2024, 5, 16, 21, 49, 19, 501, DateTimeKind.Utc).AddTicks(6780), new Guid("d67b95a0-b12e-4574-b9ec-634b11f8df42"), new Guid("9344f562-ffdc-41c5-bb24-c41c969534c7") },
                    { new Guid("6e3bc566-9a09-4c28-878c-705fef677c3c"), 203m, new DateTime(2024, 5, 10, 9, 49, 19, 501, DateTimeKind.Utc).AddTicks(6780), new Guid("d67b95a0-b12e-4574-b9ec-634b11f8df42"), new Guid("9344f562-ffdc-41c5-bb24-c41c96953410") },
                    { new Guid("6f076634-c3de-4bc1-8ac8-a80d62f592d8"), 106m, new DateTime(2024, 5, 13, 13, 49, 19, 501, DateTimeKind.Utc).AddTicks(6780), new Guid("d67b95a0-b12e-4574-b9ec-634b11f8df42"), new Guid("9344f562-ffdc-41c5-bb24-c41c96953412") },
                    { new Guid("70be1f3c-4496-4363-813c-2ca24ddcb0a2"), 129m, new DateTime(2024, 5, 9, 21, 49, 19, 501, DateTimeKind.Utc).AddTicks(6780), new Guid("d67b95a0-b12e-4574-b9ec-634b11f8df41"), new Guid("9344f562-ffdc-41c5-bb24-c41c96953412") },
                    { new Guid("76847ab7-3273-421f-83b9-9d6c48ea69be"), 210m, new DateTime(2024, 5, 10, 5, 49, 19, 501, DateTimeKind.Utc).AddTicks(6780), new Guid("d67b95a0-b12e-4574-b9ec-634b11f8df42"), new Guid("9344f562-ffdc-41c5-bb24-c41c96953413") },
                    { new Guid("87b725ca-975e-4b1f-8e2d-01101f5f1e27"), 286m, new DateTime(2024, 5, 24, 17, 49, 19, 501, DateTimeKind.Utc).AddTicks(6780), new Guid("d67b95a0-b12e-4574-b9ec-634b11f8df43"), new Guid("9344f562-ffdc-41c5-bb24-c41c96953410") },
                    { new Guid("97ab3b26-4b9d-4258-b368-8048995cc763"), 204m, new DateTime(2024, 5, 10, 17, 49, 19, 501, DateTimeKind.Utc).AddTicks(6780), new Guid("d67b95a0-b12e-4574-b9ec-634b11f8df44"), new Guid("9344f562-ffdc-41c5-bb24-c41c96953412") },
                    { new Guid("9c3aea43-6a1d-49ad-be56-9fb28efa2894"), 150m, new DateTime(2024, 5, 19, 1, 49, 19, 501, DateTimeKind.Utc).AddTicks(6780), new Guid("d67b95a0-b12e-4574-b9ec-634b11f8df42"), new Guid("9344f562-ffdc-41c5-bb24-c41c96953422") },
                    { new Guid("a0da2ed6-d9c3-45e9-897c-0e6c49e85fce"), 153m, new DateTime(2024, 5, 11, 21, 49, 19, 501, DateTimeKind.Utc).AddTicks(6780), new Guid("d67b95a0-b12e-4574-b9ec-634b11f8df41"), new Guid("9344f562-ffdc-41c5-bb24-c41c969534c7") },
                    { new Guid("a84ebedb-c229-4fd7-80a2-44666e1c16c6"), 226m, new DateTime(2024, 5, 17, 1, 49, 19, 501, DateTimeKind.Utc).AddTicks(6780), new Guid("d67b95a0-b12e-4574-b9ec-634b11f8df42"), new Guid("9344f562-ffdc-41c5-bb24-c41c96953417") },
                    { new Guid("b054474a-a65d-47a1-a202-fe87641ca637"), 185m, new DateTime(2024, 5, 28, 1, 49, 19, 501, DateTimeKind.Utc).AddTicks(6780), new Guid("d67b95a0-b12e-4574-b9ec-634b11f8df41"), new Guid("9344f562-ffdc-41c5-bb24-c41c96953412") },
                    { new Guid("b21099f5-a8a5-4598-8bdb-520733c9a9c9"), 289m, new DateTime(2024, 5, 12, 5, 49, 19, 501, DateTimeKind.Utc).AddTicks(6780), new Guid("d67b95a0-b12e-4574-b9ec-634b11f8df43"), new Guid("9344f562-ffdc-41c5-bb24-c41c96953422") },
                    { new Guid("b4f19a93-523a-4aec-8a55-51077e686866"), 176m, new DateTime(2024, 5, 15, 5, 49, 19, 501, DateTimeKind.Utc).AddTicks(6780), new Guid("d67b95a0-b12e-4574-b9ec-634b11f8df42"), new Guid("9344f562-ffdc-41c5-bb24-c41c96953420") },
                    { new Guid("b6d8abbb-7adf-4184-8d10-5af33c60deff"), 250m, new DateTime(2024, 5, 23, 1, 49, 19, 501, DateTimeKind.Utc).AddTicks(6780), new Guid("d67b95a0-b12e-4574-b9ec-634b11f8df44"), new Guid("9344f562-ffdc-41c5-bb24-c41c969534c8") },
                    { new Guid("b8550859-8fa8-45ba-a846-bea39c5f0048"), 216m, new DateTime(2024, 5, 26, 13, 49, 19, 501, DateTimeKind.Utc).AddTicks(6780), new Guid("d67b95a0-b12e-4574-b9ec-634b11f8df43"), new Guid("9344f562-ffdc-41c5-bb24-c41c96953424") },
                    { new Guid("b95d0494-b262-4080-8944-11ffc2981b2e"), 259m, new DateTime(2024, 5, 29, 13, 49, 19, 501, DateTimeKind.Utc).AddTicks(6780), new Guid("d67b95a0-b12e-4574-b9ec-634b11f8df41"), new Guid("9344f562-ffdc-41c5-bb24-c41c96953422") },
                    { new Guid("ba432577-99bb-43bb-80b2-6652013ac822"), 147m, new DateTime(2024, 5, 23, 5, 49, 19, 501, DateTimeKind.Utc).AddTicks(6780), new Guid("d67b95a0-b12e-4574-b9ec-634b11f8df44"), new Guid("9344f562-ffdc-41c5-bb24-c41c96953413") },
                    { new Guid("cdfd2593-38c7-4e59-acd2-263125ba1f32"), 138m, new DateTime(2024, 5, 24, 21, 49, 19, 501, DateTimeKind.Utc).AddTicks(6780), new Guid("d67b95a0-b12e-4574-b9ec-634b11f8df44"), new Guid("9344f562-ffdc-41c5-bb24-c41c96953417") },
                    { new Guid("e0163f01-f9d2-48f9-9b6f-92e6baebb5b6"), 253m, new DateTime(2024, 5, 24, 9, 49, 19, 501, DateTimeKind.Utc).AddTicks(6780), new Guid("d67b95a0-b12e-4574-b9ec-634b11f8df41"), new Guid("9344f562-ffdc-41c5-bb24-c41c96953423") },
                    { new Guid("e38f72dc-2518-442a-81d8-096c936bd263"), 162m, new DateTime(2024, 5, 22, 5, 49, 19, 501, DateTimeKind.Utc).AddTicks(6780), new Guid("d67b95a0-b12e-4574-b9ec-634b11f8df41"), new Guid("9344f562-ffdc-41c5-bb24-c41c96953416") },
                    { new Guid("e4ad544c-4d5c-4684-b085-74dc19061c81"), 248m, new DateTime(2024, 5, 18, 17, 49, 19, 501, DateTimeKind.Utc).AddTicks(6780), new Guid("d67b95a0-b12e-4574-b9ec-634b11f8df41"), new Guid("9344f562-ffdc-41c5-bb24-c41c96953414") },
                    { new Guid("e877d6b4-1e06-450a-a6d3-bc401bf4947b"), 241m, new DateTime(2024, 5, 22, 17, 49, 19, 501, DateTimeKind.Utc).AddTicks(6780), new Guid("d67b95a0-b12e-4574-b9ec-634b11f8df43"), new Guid("9344f562-ffdc-41c5-bb24-c41c969534c8") },
                    { new Guid("f5c27ef3-0485-4432-b0cb-35645a0935eb"), 115m, new DateTime(2024, 5, 26, 9, 49, 19, 501, DateTimeKind.Utc).AddTicks(6780), new Guid("d67b95a0-b12e-4574-b9ec-634b11f8df42"), new Guid("9344f562-ffdc-41c5-bb24-c41c96953423") }
                });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "HallId", "PlaceIndex", "RowIndex", "SessionId", "UserId" },
                values: new object[,]
                {
                    { new Guid("04851174-be6c-4714-bc5c-9e9501e0f1dc"), new Guid("d67b95a0-b12e-4574-b9ec-634b11f8df41"), 2, 2, new Guid("4fefce7b-637b-4cfc-b9ff-bb1e6e9f5ad7"), new Guid("cb1f260c-26f1-48b1-a277-a309397d1875") },
                    { new Guid("10048a6e-5353-422f-be13-eadfb16922f9"), new Guid("d67b95a0-b12e-4574-b9ec-634b11f8df43"), 3, 2, new Guid("41a9ea82-acf1-4e94-acf1-4c95ca5348a4"), new Guid("cb1f260c-26f1-48b1-a277-a309397d1875") },
                    { new Guid("2527bef0-a0d5-4447-b04f-107e5a4db28b"), new Guid("d67b95a0-b12e-4574-b9ec-634b11f8df41"), 1, 3, new Guid("31de204b-3740-4b15-a2fc-4943f2b38bdd"), new Guid("97f6d0bc-62c9-45d2-a608-c413d5be17d7") },
                    { new Guid("3113ddb0-f887-4e4c-b902-226244735e92"), new Guid("d67b95a0-b12e-4574-b9ec-634b11f8df41"), 1, 0, new Guid("31de204b-3740-4b15-a2fc-4943f2b38bdd"), new Guid("8a0c9ce1-9a97-4252-a5a5-cc1df45f9cbc") },
                    { new Guid("893813f5-a21e-4e12-869d-0ce9c974d42a"), new Guid("d67b95a0-b12e-4574-b9ec-634b11f8df43"), 1, 3, new Guid("41a9ea82-acf1-4e94-acf1-4c95ca5348a4"), new Guid("b777385f-f200-4ef4-a1af-99892cd9d867") },
                    { new Guid("943c64d3-57b2-41c3-a0ec-bb28541af3b4"), new Guid("d67b95a0-b12e-4574-b9ec-634b11f8df41"), 3, 2, new Guid("06013bca-e006-451a-aaea-85688b14de98"), new Guid("78c3cdd9-8ce2-4eb4-bb95-9b5893eccf9f") },
                    { new Guid("bb974467-7c21-44af-98a4-fd17b3bbfb1a"), new Guid("d67b95a0-b12e-4574-b9ec-634b11f8df43"), 3, 2, new Guid("fe9766ee-75f0-4c1e-aacf-383a2881c6ad"), new Guid("cb1f260c-26f1-48b1-a277-a309397d1875") }
                });

            migrationBuilder.InsertData(
                table: "Invoice",
                columns: new[] { "Id", "Amount", "CreateDateUtc", "Status", "TicketId", "UserId" },
                values: new object[,]
                {
                    { new Guid("029be525-a760-42f4-b557-812d77244124"), 260, new DateTime(2024, 5, 18, 10, 49, 19, 501, DateTimeKind.Utc).AddTicks(6780), true, new Guid("2527bef0-a0d5-4447-b04f-107e5a4db28b"), new Guid("97f6d0bc-62c9-45d2-a608-c413d5be17d7") },
                    { new Guid("31c393ad-220b-4107-b184-c6b3b31b1509"), 224, new DateTime(2024, 5, 19, 22, 49, 19, 501, DateTimeKind.Utc).AddTicks(6780), true, new Guid("bb974467-7c21-44af-98a4-fd17b3bbfb1a"), new Guid("cb1f260c-26f1-48b1-a277-a309397d1875") },
                    { new Guid("390ff260-0c33-4f7d-af5e-06535a9f9c43"), 245, new DateTime(2024, 5, 26, 4, 49, 19, 501, DateTimeKind.Utc).AddTicks(6780), true, new Guid("893813f5-a21e-4e12-869d-0ce9c974d42a"), new Guid("b777385f-f200-4ef4-a1af-99892cd9d867") },
                    { new Guid("4187a167-35ca-4fd2-9bbd-288e34b0842e"), 136, new DateTime(2024, 5, 9, 15, 49, 19, 501, DateTimeKind.Utc).AddTicks(6780), true, new Guid("943c64d3-57b2-41c3-a0ec-bb28541af3b4"), new Guid("78c3cdd9-8ce2-4eb4-bb95-9b5893eccf9f") },
                    { new Guid("852a6716-e08a-46ab-8c03-fb0b968fe0f5"), 245, new DateTime(2024, 5, 26, 6, 49, 19, 501, DateTimeKind.Utc).AddTicks(6780), true, new Guid("10048a6e-5353-422f-be13-eadfb16922f9"), new Guid("cb1f260c-26f1-48b1-a277-a309397d1875") },
                    { new Guid("872dbaff-414e-499d-b034-d17ccefa7f17"), 260, new DateTime(2024, 5, 18, 2, 49, 19, 501, DateTimeKind.Utc).AddTicks(6780), true, new Guid("3113ddb0-f887-4e4c-b902-226244735e92"), new Guid("8a0c9ce1-9a97-4252-a5a5-cc1df45f9cbc") },
                    { new Guid("938ef573-2119-4370-b2aa-a722719b91c8"), 222, new DateTime(2024, 5, 14, 19, 49, 19, 501, DateTimeKind.Utc).AddTicks(6780), true, new Guid("04851174-be6c-4714-bc5c-9e9501e0f1dc"), new Guid("cb1f260c-26f1-48b1-a277-a309397d1875") }
                });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "HallId", "PlaceIndex", "RowIndex", "SessionId", "UserId" },
                values: new object[,]
                {
                    { new Guid("0fd66007-ff5a-4ea1-928e-22a75738867b"), new Guid("d67b95a0-b12e-4574-b9ec-634b11f8df42"), 0, 0, new Guid("a84ebedb-c229-4fd7-80a2-44666e1c16c6"), new Guid("cb1f260c-26f1-48b1-a277-a309397d1875") },
                    { new Guid("1379cf5a-f1f9-4319-a323-2984dbb59850"), new Guid("d67b95a0-b12e-4574-b9ec-634b11f8df43"), 3, 2, new Guid("b21099f5-a8a5-4598-8bdb-520733c9a9c9"), new Guid("8a0c9ce1-9a97-4252-a5a5-cc1df45f9cbc") },
                    { new Guid("1f3eccec-19b5-4a95-9759-7078d205f5d0"), new Guid("d67b95a0-b12e-4574-b9ec-634b11f8df43"), 3, 0, new Guid("b21099f5-a8a5-4598-8bdb-520733c9a9c9"), new Guid("33a8b11f-3eab-4f3c-ae10-dddfa35ffb5f") },
                    { new Guid("218e3447-96b3-48aa-8eed-5725ae7d63c5"), new Guid("d67b95a0-b12e-4574-b9ec-634b11f8df41"), 3, 2, new Guid("29c84102-f3aa-4791-9cc6-a769edda127d"), new Guid("a4548123-827e-428f-86e1-d98217fd9a88") },
                    { new Guid("24a56210-9c63-4fb2-b3bc-7b5253ae1084"), new Guid("d67b95a0-b12e-4574-b9ec-634b11f8df41"), 0, 0, new Guid("b95d0494-b262-4080-8944-11ffc2981b2e"), new Guid("a4548123-827e-428f-86e1-d98217fd9a88") },
                    { new Guid("2821c53e-bdf4-4c49-9bb9-8d3c31c64efe"), new Guid("d67b95a0-b12e-4574-b9ec-634b11f8df41"), 3, 2, new Guid("a0da2ed6-d9c3-45e9-897c-0e6c49e85fce"), new Guid("33a8b11f-3eab-4f3c-ae10-dddfa35ffb5f") },
                    { new Guid("2bec2a92-4f1c-49e4-8536-6bc4339e9743"), new Guid("d67b95a0-b12e-4574-b9ec-634b11f8df44"), 2, 0, new Guid("5a537e30-2fa8-4e7d-b48f-aef2c68c62e2"), new Guid("8a0c9ce1-9a97-4252-a5a5-cc1df45f9cbc") },
                    { new Guid("2e7f204e-c5fc-4fb7-97f0-12cb9ca34d5f"), new Guid("d67b95a0-b12e-4574-b9ec-634b11f8df44"), 2, 3, new Guid("206c03b1-43ce-46bd-b26e-ce9b99d3700e"), new Guid("6e790a16-11e5-4d40-b7ce-9f67721a7a4d") },
                    { new Guid("3030d627-4551-4be9-9b7a-d893e2dfee38"), new Guid("d67b95a0-b12e-4574-b9ec-634b11f8df41"), 3, 3, new Guid("e4ad544c-4d5c-4684-b085-74dc19061c81"), new Guid("33a8b11f-3eab-4f3c-ae10-dddfa35ffb5f") },
                    { new Guid("3a786388-ebb8-4ee0-9dbc-f69fd3a83ad6"), new Guid("d67b95a0-b12e-4574-b9ec-634b11f8df42"), 1, 1, new Guid("6e248dc9-3edc-4a23-b7e9-749b81ffcc63"), new Guid("33a8b11f-3eab-4f3c-ae10-dddfa35ffb5f") },
                    { new Guid("5866e9f4-b487-4b10-b809-786e7cbc5d87"), new Guid("d67b95a0-b12e-4574-b9ec-634b11f8df43"), 3, 1, new Guid("e877d6b4-1e06-450a-a6d3-bc401bf4947b"), new Guid("97f6d0bc-62c9-45d2-a608-c413d5be17d7") },
                    { new Guid("749a9fb5-db4e-4381-b8fa-1d40207e8a5f"), new Guid("d67b95a0-b12e-4574-b9ec-634b11f8df42"), 0, 2, new Guid("6f076634-c3de-4bc1-8ac8-a80d62f592d8"), new Guid("78c3cdd9-8ce2-4eb4-bb95-9b5893eccf9f") },
                    { new Guid("75b68bdc-0685-4937-9cb4-0cc76df6a043"), new Guid("d67b95a0-b12e-4574-b9ec-634b11f8df44"), 0, 1, new Guid("17d9592f-c1ac-47c1-a6e8-8c7136c9913e"), new Guid("33a8b11f-3eab-4f3c-ae10-dddfa35ffb5f") },
                    { new Guid("8a4297b9-1d91-46c9-b744-fc5b31d5da10"), new Guid("d67b95a0-b12e-4574-b9ec-634b11f8df41"), 1, 3, new Guid("673bc310-5e54-43ab-94f5-6e5abd50cfc5"), new Guid("8a0c9ce1-9a97-4252-a5a5-cc1df45f9cbc") },
                    { new Guid("8b9dc532-6bb6-4277-b05e-9beac1a60c6c"), new Guid("d67b95a0-b12e-4574-b9ec-634b11f8df41"), 1, 2, new Guid("70be1f3c-4496-4363-813c-2ca24ddcb0a2"), new Guid("6e790a16-11e5-4d40-b7ce-9f67721a7a4d") },
                    { new Guid("8f9ea2ac-5f30-4473-ab5b-cb09cb624ca9"), new Guid("d67b95a0-b12e-4574-b9ec-634b11f8df43"), 0, 3, new Guid("6b4ff334-0ebe-44dc-ac92-b460fd008ba9"), new Guid("78c3cdd9-8ce2-4eb4-bb95-9b5893eccf9f") },
                    { new Guid("956ad5b2-1ce6-456f-abbf-3b271a55f0b2"), new Guid("d67b95a0-b12e-4574-b9ec-634b11f8df41"), 3, 0, new Guid("70be1f3c-4496-4363-813c-2ca24ddcb0a2"), new Guid("b777385f-f200-4ef4-a1af-99892cd9d867") },
                    { new Guid("988d4603-f9ea-4193-83cf-304ef86b628d"), new Guid("d67b95a0-b12e-4574-b9ec-634b11f8df43"), 3, 3, new Guid("4c1908d0-9074-4bdb-a120-ee0f4d26f927"), new Guid("78c3cdd9-8ce2-4eb4-bb95-9b5893eccf9f") },
                    { new Guid("a3cf07c9-45f6-4e8b-b708-26f3bba25bd5"), new Guid("d67b95a0-b12e-4574-b9ec-634b11f8df42"), 2, 1, new Guid("2f0b9d37-2c7c-45c0-9cee-861ddfe582e3"), new Guid("6e790a16-11e5-4d40-b7ce-9f67721a7a4d") },
                    { new Guid("bd796451-d5af-4e6c-a31f-118a9f2c3eb0"), new Guid("d67b95a0-b12e-4574-b9ec-634b11f8df41"), 3, 0, new Guid("673bc310-5e54-43ab-94f5-6e5abd50cfc5"), new Guid("b777385f-f200-4ef4-a1af-99892cd9d867") },
                    { new Guid("c9c541c6-cbab-40aa-91be-a9af02980cf0"), new Guid("d67b95a0-b12e-4574-b9ec-634b11f8df42"), 1, 0, new Guid("6e3bc566-9a09-4c28-878c-705fef677c3c"), new Guid("a4548123-827e-428f-86e1-d98217fd9a88") },
                    { new Guid("cd1b4bcf-d1c7-4118-a322-2c950ce10cc5"), new Guid("d67b95a0-b12e-4574-b9ec-634b11f8df41"), 2, 2, new Guid("e38f72dc-2518-442a-81d8-096c936bd263"), new Guid("78c3cdd9-8ce2-4eb4-bb95-9b5893eccf9f") },
                    { new Guid("cd6ef3ca-bb16-45f1-85db-1556d14e0084"), new Guid("d67b95a0-b12e-4574-b9ec-634b11f8df43"), 0, 1, new Guid("b21099f5-a8a5-4598-8bdb-520733c9a9c9"), new Guid("78c3cdd9-8ce2-4eb4-bb95-9b5893eccf9f") },
                    { new Guid("d8756c39-7798-4921-9027-d12e4092d904"), new Guid("d67b95a0-b12e-4574-b9ec-634b11f8df43"), 3, 3, new Guid("3d80ce6c-bee5-4503-8f9e-17871cd0a6f0"), new Guid("92698a9a-09bb-4687-8884-34cdb18841a3") },
                    { new Guid("d9f3c133-d490-474f-ba26-eb29cd30770f"), new Guid("d67b95a0-b12e-4574-b9ec-634b11f8df42"), 1, 2, new Guid("b4f19a93-523a-4aec-8a55-51077e686866"), new Guid("b777385f-f200-4ef4-a1af-99892cd9d867") },
                    { new Guid("e59d9501-5c17-4167-b410-b6967f6b929b"), new Guid("d67b95a0-b12e-4574-b9ec-634b11f8df44"), 2, 3, new Guid("206c03b1-43ce-46bd-b26e-ce9b99d3700e"), new Guid("97f6d0bc-62c9-45d2-a608-c413d5be17d7") },
                    { new Guid("e5d4e2c3-3e53-4717-82e5-4af74f9a4196"), new Guid("d67b95a0-b12e-4574-b9ec-634b11f8df41"), 2, 1, new Guid("a0da2ed6-d9c3-45e9-897c-0e6c49e85fce"), new Guid("92698a9a-09bb-4687-8884-34cdb18841a3") },
                    { new Guid("efea74df-4ef1-478f-babe-4047788a793b"), new Guid("d67b95a0-b12e-4574-b9ec-634b11f8df43"), 2, 2, new Guid("0bb00dbe-b0cc-4e78-b7ae-bc6d19bcc7bb"), new Guid("cb1f260c-26f1-48b1-a277-a309397d1875") },
                    { new Guid("f36cd610-fbde-4f07-b28e-1d90ba8438e3"), new Guid("d67b95a0-b12e-4574-b9ec-634b11f8df43"), 3, 2, new Guid("b21099f5-a8a5-4598-8bdb-520733c9a9c9"), new Guid("92698a9a-09bb-4687-8884-34cdb18841a3") }
                });

            migrationBuilder.InsertData(
                table: "Invoice",
                columns: new[] { "Id", "Amount", "CreateDateUtc", "Status", "TicketId", "UserId" },
                values: new object[,]
                {
                    { new Guid("025b27bb-2091-403f-a60b-38028fd1e7c5"), 129, new DateTime(2024, 5, 8, 23, 49, 19, 501, DateTimeKind.Utc).AddTicks(6780), true, new Guid("956ad5b2-1ce6-456f-abbf-3b271a55f0b2"), new Guid("b777385f-f200-4ef4-a1af-99892cd9d867") },
                    { new Guid("07e28d72-a56b-48e6-9751-7e2fc9751582"), 245, new DateTime(2024, 5, 18, 14, 49, 19, 501, DateTimeKind.Utc).AddTicks(6780), true, new Guid("e59d9501-5c17-4167-b410-b6967f6b929b"), new Guid("97f6d0bc-62c9-45d2-a608-c413d5be17d7") },
                    { new Guid("1518f0e6-6312-4448-a4c7-877bc5c27214"), 281, new DateTime(2024, 5, 16, 16, 49, 19, 501, DateTimeKind.Utc).AddTicks(6780), true, new Guid("75b68bdc-0685-4937-9cb4-0cc76df6a043"), new Guid("33a8b11f-3eab-4f3c-ae10-dddfa35ffb5f") },
                    { new Guid("19111be4-6884-4ade-8df1-7f3e4456fd9d"), 259, new DateTime(2024, 5, 28, 19, 49, 19, 501, DateTimeKind.Utc).AddTicks(6780), true, new Guid("24a56210-9c63-4fb2-b3bc-7b5253ae1084"), new Guid("a4548123-827e-428f-86e1-d98217fd9a88") },
                    { new Guid("1b0eeea5-14bc-4d00-a87e-a107e32b8067"), 232, new DateTime(2024, 5, 21, 15, 49, 19, 501, DateTimeKind.Utc).AddTicks(6780), true, new Guid("8a4297b9-1d91-46c9-b744-fc5b31d5da10"), new Guid("8a0c9ce1-9a97-4252-a5a5-cc1df45f9cbc") },
                    { new Guid("216392a9-84b5-4224-ba0b-e777d9727299"), 129, new DateTime(2024, 5, 9, 13, 49, 19, 501, DateTimeKind.Utc).AddTicks(6780), true, new Guid("8b9dc532-6bb6-4277-b05e-9beac1a60c6c"), new Guid("6e790a16-11e5-4d40-b7ce-9f67721a7a4d") },
                    { new Guid("3e176507-24c6-4bfa-9d6d-835f8969520a"), 241, new DateTime(2024, 5, 22, 14, 49, 19, 501, DateTimeKind.Utc).AddTicks(6780), true, new Guid("5866e9f4-b487-4b10-b809-786e7cbc5d87"), new Guid("97f6d0bc-62c9-45d2-a608-c413d5be17d7") },
                    { new Guid("3f2daf80-3fd2-4c36-a3ab-e934440d0617"), 218, new DateTime(2024, 5, 17, 1, 49, 19, 501, DateTimeKind.Utc).AddTicks(6780), true, new Guid("d8756c39-7798-4921-9027-d12e4092d904"), new Guid("92698a9a-09bb-4687-8884-34cdb18841a3") },
                    { new Guid("68de81dd-66dd-413a-a289-d7e6f56ba019"), 178, new DateTime(2024, 5, 17, 0, 49, 19, 501, DateTimeKind.Utc).AddTicks(6780), true, new Guid("efea74df-4ef1-478f-babe-4047788a793b"), new Guid("cb1f260c-26f1-48b1-a277-a309397d1875") },
                    { new Guid("6f987ddc-284e-436d-b043-7b0d468dd519"), 176, new DateTime(2024, 5, 14, 9, 49, 19, 501, DateTimeKind.Utc).AddTicks(6780), true, new Guid("d9f3c133-d490-474f-ba26-eb29cd30770f"), new Guid("b777385f-f200-4ef4-a1af-99892cd9d867") },
                    { new Guid("76791a74-bf14-4302-86fa-4a060707a3ae"), 289, new DateTime(2024, 5, 12, 1, 49, 19, 501, DateTimeKind.Utc).AddTicks(6780), true, new Guid("1f3eccec-19b5-4a95-9759-7078d205f5d0"), new Guid("33a8b11f-3eab-4f3c-ae10-dddfa35ffb5f") },
                    { new Guid("7720d629-5131-4fbc-8815-1159d03371e2"), 232, new DateTime(2024, 5, 22, 4, 49, 19, 501, DateTimeKind.Utc).AddTicks(6780), true, new Guid("bd796451-d5af-4e6c-a31f-118a9f2c3eb0"), new Guid("b777385f-f200-4ef4-a1af-99892cd9d867") },
                    { new Guid("7d9b9cc4-3bb6-48c0-a146-5fdb9ac4d794"), 289, new DateTime(2024, 5, 11, 17, 49, 19, 501, DateTimeKind.Utc).AddTicks(6780), true, new Guid("f36cd610-fbde-4f07-b28e-1d90ba8438e3"), new Guid("92698a9a-09bb-4687-8884-34cdb18841a3") },
                    { new Guid("81a8b16c-a078-4dfe-a74b-d1d4b86a3776"), 153, new DateTime(2024, 5, 11, 9, 49, 19, 501, DateTimeKind.Utc).AddTicks(6780), true, new Guid("e5d4e2c3-3e53-4717-82e5-4af74f9a4196"), new Guid("92698a9a-09bb-4687-8884-34cdb18841a3") },
                    { new Guid("8958261f-63ff-4b8e-9f08-f24d827e0fb7"), 255, new DateTime(2024, 5, 22, 16, 49, 19, 501, DateTimeKind.Utc).AddTicks(6780), true, new Guid("988d4603-f9ea-4193-83cf-304ef86b628d"), new Guid("78c3cdd9-8ce2-4eb4-bb95-9b5893eccf9f") },
                    { new Guid("9fcd1714-7db7-4490-91b2-35957757cc3b"), 153, new DateTime(2024, 5, 11, 10, 49, 19, 501, DateTimeKind.Utc).AddTicks(6780), true, new Guid("2821c53e-bdf4-4c49-9bb9-8d3c31c64efe"), new Guid("33a8b11f-3eab-4f3c-ae10-dddfa35ffb5f") },
                    { new Guid("a04173bd-56fc-497f-a810-f15a3c1235cb"), 106, new DateTime(2024, 5, 13, 7, 49, 19, 501, DateTimeKind.Utc).AddTicks(6780), true, new Guid("749a9fb5-db4e-4381-b8fa-1d40207e8a5f"), new Guid("78c3cdd9-8ce2-4eb4-bb95-9b5893eccf9f") },
                    { new Guid("a3b5a1d2-7099-4924-a65c-c02e20b137bc"), 202, new DateTime(2024, 5, 28, 22, 49, 19, 501, DateTimeKind.Utc).AddTicks(6780), true, new Guid("8f9ea2ac-5f30-4473-ab5b-cb09cb624ca9"), new Guid("78c3cdd9-8ce2-4eb4-bb95-9b5893eccf9f") },
                    { new Guid("a8c9feb4-8231-4081-b7ac-393fe76c1551"), 162, new DateTime(2024, 5, 21, 19, 49, 19, 501, DateTimeKind.Utc).AddTicks(6780), true, new Guid("cd1b4bcf-d1c7-4118-a322-2c950ce10cc5"), new Guid("78c3cdd9-8ce2-4eb4-bb95-9b5893eccf9f") },
                    { new Guid("b4182a59-deb7-40ae-b2e1-5f3f019abc57"), 209, new DateTime(2024, 5, 13, 13, 49, 19, 501, DateTimeKind.Utc).AddTicks(6780), true, new Guid("a3cf07c9-45f6-4e8b-b708-26f3bba25bd5"), new Guid("6e790a16-11e5-4d40-b7ce-9f67721a7a4d") },
                    { new Guid("b48768d7-a0e9-4711-87ea-70bc684d1126"), 111, new DateTime(2024, 5, 15, 20, 49, 19, 501, DateTimeKind.Utc).AddTicks(6780), true, new Guid("218e3447-96b3-48aa-8eed-5725ae7d63c5"), new Guid("a4548123-827e-428f-86e1-d98217fd9a88") },
                    { new Guid("b85c7dfa-49ef-4407-b420-291a3c13410e"), 203, new DateTime(2024, 5, 10, 5, 49, 19, 501, DateTimeKind.Utc).AddTicks(6780), true, new Guid("c9c541c6-cbab-40aa-91be-a9af02980cf0"), new Guid("a4548123-827e-428f-86e1-d98217fd9a88") },
                    { new Guid("b88774e7-2ad4-4299-a601-7fc30c0d68da"), 289, new DateTime(2024, 5, 11, 7, 49, 19, 501, DateTimeKind.Utc).AddTicks(6780), true, new Guid("1379cf5a-f1f9-4319-a323-2984dbb59850"), new Guid("8a0c9ce1-9a97-4252-a5a5-cc1df45f9cbc") },
                    { new Guid("bb269fef-94be-4c27-a7c0-855f6c2bc833"), 245, new DateTime(2024, 5, 18, 21, 49, 19, 501, DateTimeKind.Utc).AddTicks(6780), true, new Guid("2e7f204e-c5fc-4fb7-97f0-12cb9ca34d5f"), new Guid("6e790a16-11e5-4d40-b7ce-9f67721a7a4d") },
                    { new Guid("dc587035-cddb-433b-afe7-4f2b3a469231"), 236, new DateTime(2024, 5, 16, 15, 49, 19, 501, DateTimeKind.Utc).AddTicks(6780), true, new Guid("3a786388-ebb8-4ee0-9dbc-f69fd3a83ad6"), new Guid("33a8b11f-3eab-4f3c-ae10-dddfa35ffb5f") },
                    { new Guid("f2a0e750-3936-433d-8066-de16572c995c"), 248, new DateTime(2024, 5, 18, 4, 49, 19, 501, DateTimeKind.Utc).AddTicks(6780), true, new Guid("3030d627-4551-4be9-9b7a-d893e2dfee38"), new Guid("33a8b11f-3eab-4f3c-ae10-dddfa35ffb5f") },
                    { new Guid("f6bf894c-0be6-46cc-bc90-80d73693021d"), 289, new DateTime(2024, 5, 12, 2, 49, 19, 501, DateTimeKind.Utc).AddTicks(6780), true, new Guid("cd6ef3ca-bb16-45f1-85db-1556d14e0084"), new Guid("78c3cdd9-8ce2-4eb4-bb95-9b5893eccf9f") },
                    { new Guid("fcb49fae-c29e-4620-8481-d86ef17ffdb6"), 226, new DateTime(2024, 5, 16, 22, 49, 19, 501, DateTimeKind.Utc).AddTicks(6780), true, new Guid("0fd66007-ff5a-4ea1-928e-22a75738867b"), new Guid("cb1f260c-26f1-48b1-a277-a309397d1875") },
                    { new Guid("fd790cc5-2061-4a38-a3ba-40dc24a7968a"), 291, new DateTime(2024, 5, 26, 17, 49, 19, 501, DateTimeKind.Utc).AddTicks(6780), true, new Guid("2bec2a92-4f1c-49e4-8536-6bc4339e9743"), new Guid("8a0c9ce1-9a97-4252-a5a5-cc1df45f9cbc") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: new Guid("aad5caaa-a45d-490a-b26d-d503b6a82261"));

            migrationBuilder.DeleteData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: new Guid("aad5caaa-a45d-490a-b26d-d503b6a82265"));

            migrationBuilder.DeleteData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: new Guid("aad5caaa-a45d-490a-b26d-d503b6a82271"));

            migrationBuilder.DeleteData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: new Guid("aad5caaa-a45d-490a-b26d-d503b6a82277"));

            migrationBuilder.DeleteData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: new Guid("aad5caaa-a45d-490a-b26d-d503b6a82285"));

            migrationBuilder.DeleteData(
                table: "ActorMovie",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { new Guid("aad5caaa-a45d-490a-b26d-d503b6a82262"), new Guid("9344f562-ffdc-41c5-bb24-c41c96953419") });

            migrationBuilder.DeleteData(
                table: "ActorMovie",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { new Guid("aad5caaa-a45d-490a-b26d-d503b6a82263"), new Guid("9344f562-ffdc-41c5-bb24-c41c96953413") });

            migrationBuilder.DeleteData(
                table: "ActorMovie",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { new Guid("aad5caaa-a45d-490a-b26d-d503b6a82263"), new Guid("9344f562-ffdc-41c5-bb24-c41c969534c6") });

            migrationBuilder.DeleteData(
                table: "ActorMovie",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { new Guid("aad5caaa-a45d-490a-b26d-d503b6a82263"), new Guid("9344f562-ffdc-41c5-bb24-c41c969534c7") });

            migrationBuilder.DeleteData(
                table: "ActorMovie",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { new Guid("aad5caaa-a45d-490a-b26d-d503b6a82264"), new Guid("9344f562-ffdc-41c5-bb24-c41c969534c6") });

            migrationBuilder.DeleteData(
                table: "ActorMovie",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { new Guid("aad5caaa-a45d-490a-b26d-d503b6a82264"), new Guid("9344f562-ffdc-41c5-bb24-c41c969534c8") });

            migrationBuilder.DeleteData(
                table: "ActorMovie",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { new Guid("aad5caaa-a45d-490a-b26d-d503b6a82266"), new Guid("9344f562-ffdc-41c5-bb24-c41c969534c2") });

            migrationBuilder.DeleteData(
                table: "ActorMovie",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { new Guid("aad5caaa-a45d-490a-b26d-d503b6a82267"), new Guid("9344f562-ffdc-41c5-bb24-c41c96953417") });

            migrationBuilder.DeleteData(
                table: "ActorMovie",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { new Guid("aad5caaa-a45d-490a-b26d-d503b6a82268"), new Guid("9344f562-ffdc-41c5-bb24-c41c96953416") });

            migrationBuilder.DeleteData(
                table: "ActorMovie",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { new Guid("aad5caaa-a45d-490a-b26d-d503b6a82269"), new Guid("9344f562-ffdc-41c5-bb24-c41c96953411") });

            migrationBuilder.DeleteData(
                table: "ActorMovie",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { new Guid("aad5caaa-a45d-490a-b26d-d503b6a82269"), new Guid("9344f562-ffdc-41c5-bb24-c41c969534c3") });

            migrationBuilder.DeleteData(
                table: "ActorMovie",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { new Guid("aad5caaa-a45d-490a-b26d-d503b6a82270"), new Guid("9344f562-ffdc-41c5-bb24-c41c96953423") });

            migrationBuilder.DeleteData(
                table: "ActorMovie",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { new Guid("aad5caaa-a45d-490a-b26d-d503b6a82270"), new Guid("9344f562-ffdc-41c5-bb24-c41c969534c4") });

            migrationBuilder.DeleteData(
                table: "ActorMovie",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { new Guid("aad5caaa-a45d-490a-b26d-d503b6a82272"), new Guid("9344f562-ffdc-41c5-bb24-c41c969534c8") });

            migrationBuilder.DeleteData(
                table: "ActorMovie",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { new Guid("aad5caaa-a45d-490a-b26d-d503b6a82272"), new Guid("9344f562-ffdc-41c5-bb24-c41c969534c9") });

            migrationBuilder.DeleteData(
                table: "ActorMovie",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { new Guid("aad5caaa-a45d-490a-b26d-d503b6a82273"), new Guid("9344f562-ffdc-41c5-bb24-c41c96953423") });

            migrationBuilder.DeleteData(
                table: "ActorMovie",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { new Guid("aad5caaa-a45d-490a-b26d-d503b6a82273"), new Guid("9344f562-ffdc-41c5-bb24-c41c969534c5") });

            migrationBuilder.DeleteData(
                table: "ActorMovie",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { new Guid("aad5caaa-a45d-490a-b26d-d503b6a82274"), new Guid("9344f562-ffdc-41c5-bb24-c41c96953410") });

            migrationBuilder.DeleteData(
                table: "ActorMovie",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { new Guid("aad5caaa-a45d-490a-b26d-d503b6a82274"), new Guid("9344f562-ffdc-41c5-bb24-c41c96953420") });

            migrationBuilder.DeleteData(
                table: "ActorMovie",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { new Guid("aad5caaa-a45d-490a-b26d-d503b6a82274"), new Guid("9344f562-ffdc-41c5-bb24-c41c96953422") });

            migrationBuilder.DeleteData(
                table: "ActorMovie",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { new Guid("aad5caaa-a45d-490a-b26d-d503b6a82274"), new Guid("9344f562-ffdc-41c5-bb24-c41c96953423") });

            migrationBuilder.DeleteData(
                table: "ActorMovie",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { new Guid("aad5caaa-a45d-490a-b26d-d503b6a82275"), new Guid("9344f562-ffdc-41c5-bb24-c41c96953419") });

            migrationBuilder.DeleteData(
                table: "ActorMovie",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { new Guid("aad5caaa-a45d-490a-b26d-d503b6a82275"), new Guid("9344f562-ffdc-41c5-bb24-c41c969534c2") });

            migrationBuilder.DeleteData(
                table: "ActorMovie",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { new Guid("aad5caaa-a45d-490a-b26d-d503b6a82275"), new Guid("9344f562-ffdc-41c5-bb24-c41c969534c3") });

            migrationBuilder.DeleteData(
                table: "ActorMovie",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { new Guid("aad5caaa-a45d-490a-b26d-d503b6a82275"), new Guid("9344f562-ffdc-41c5-bb24-c41c969534c9") });

            migrationBuilder.DeleteData(
                table: "ActorMovie",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { new Guid("aad5caaa-a45d-490a-b26d-d503b6a82276"), new Guid("9344f562-ffdc-41c5-bb24-c41c96953411") });

            migrationBuilder.DeleteData(
                table: "ActorMovie",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { new Guid("aad5caaa-a45d-490a-b26d-d503b6a82276"), new Guid("9344f562-ffdc-41c5-bb24-c41c96953413") });

            migrationBuilder.DeleteData(
                table: "ActorMovie",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { new Guid("aad5caaa-a45d-490a-b26d-d503b6a82276"), new Guid("9344f562-ffdc-41c5-bb24-c41c96953424") });

            migrationBuilder.DeleteData(
                table: "ActorMovie",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { new Guid("aad5caaa-a45d-490a-b26d-d503b6a82276"), new Guid("9344f562-ffdc-41c5-bb24-c41c969534c5") });

            migrationBuilder.DeleteData(
                table: "ActorMovie",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { new Guid("aad5caaa-a45d-490a-b26d-d503b6a82278"), new Guid("9344f562-ffdc-41c5-bb24-c41c96953417") });

            migrationBuilder.DeleteData(
                table: "ActorMovie",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { new Guid("aad5caaa-a45d-490a-b26d-d503b6a82278"), new Guid("9344f562-ffdc-41c5-bb24-c41c96953421") });

            migrationBuilder.DeleteData(
                table: "ActorMovie",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { new Guid("aad5caaa-a45d-490a-b26d-d503b6a82279"), new Guid("9344f562-ffdc-41c5-bb24-c41c96953421") });

            migrationBuilder.DeleteData(
                table: "ActorMovie",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { new Guid("aad5caaa-a45d-490a-b26d-d503b6a82279"), new Guid("9344f562-ffdc-41c5-bb24-c41c969534c1") });

            migrationBuilder.DeleteData(
                table: "ActorMovie",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { new Guid("aad5caaa-a45d-490a-b26d-d503b6a82279"), new Guid("9344f562-ffdc-41c5-bb24-c41c969534c6") });

            migrationBuilder.DeleteData(
                table: "ActorMovie",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { new Guid("aad5caaa-a45d-490a-b26d-d503b6a82280"), new Guid("9344f562-ffdc-41c5-bb24-c41c96953414") });

            migrationBuilder.DeleteData(
                table: "ActorMovie",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { new Guid("aad5caaa-a45d-490a-b26d-d503b6a82281"), new Guid("9344f562-ffdc-41c5-bb24-c41c96953410") });

            migrationBuilder.DeleteData(
                table: "ActorMovie",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { new Guid("aad5caaa-a45d-490a-b26d-d503b6a82281"), new Guid("9344f562-ffdc-41c5-bb24-c41c969534c3") });

            migrationBuilder.DeleteData(
                table: "ActorMovie",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { new Guid("aad5caaa-a45d-490a-b26d-d503b6a82281"), new Guid("9344f562-ffdc-41c5-bb24-c41c969534c9") });

            migrationBuilder.DeleteData(
                table: "ActorMovie",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { new Guid("aad5caaa-a45d-490a-b26d-d503b6a82282"), new Guid("9344f562-ffdc-41c5-bb24-c41c96953411") });

            migrationBuilder.DeleteData(
                table: "ActorMovie",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { new Guid("aad5caaa-a45d-490a-b26d-d503b6a82282"), new Guid("9344f562-ffdc-41c5-bb24-c41c96953418") });

            migrationBuilder.DeleteData(
                table: "ActorMovie",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { new Guid("aad5caaa-a45d-490a-b26d-d503b6a82283"), new Guid("9344f562-ffdc-41c5-bb24-c41c96953410") });

            migrationBuilder.DeleteData(
                table: "ActorMovie",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { new Guid("aad5caaa-a45d-490a-b26d-d503b6a82283"), new Guid("9344f562-ffdc-41c5-bb24-c41c96953412") });

            migrationBuilder.DeleteData(
                table: "ActorMovie",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { new Guid("aad5caaa-a45d-490a-b26d-d503b6a82283"), new Guid("9344f562-ffdc-41c5-bb24-c41c96953413") });

            migrationBuilder.DeleteData(
                table: "ActorMovie",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { new Guid("aad5caaa-a45d-490a-b26d-d503b6a82283"), new Guid("9344f562-ffdc-41c5-bb24-c41c96953415") });

            migrationBuilder.DeleteData(
                table: "ActorMovie",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { new Guid("aad5caaa-a45d-490a-b26d-d503b6a82284"), new Guid("9344f562-ffdc-41c5-bb24-c41c969534c5") });

            migrationBuilder.DeleteData(
                table: "Director",
                keyColumn: "Id",
                keyValue: new Guid("ed9a79d9-fe9d-456e-a0a7-2a028cbe1024"));

            migrationBuilder.DeleteData(
                table: "Invoice",
                keyColumn: "Id",
                keyValue: new Guid("025b27bb-2091-403f-a60b-38028fd1e7c5"));

            migrationBuilder.DeleteData(
                table: "Invoice",
                keyColumn: "Id",
                keyValue: new Guid("029be525-a760-42f4-b557-812d77244124"));

            migrationBuilder.DeleteData(
                table: "Invoice",
                keyColumn: "Id",
                keyValue: new Guid("07e28d72-a56b-48e6-9751-7e2fc9751582"));

            migrationBuilder.DeleteData(
                table: "Invoice",
                keyColumn: "Id",
                keyValue: new Guid("1518f0e6-6312-4448-a4c7-877bc5c27214"));

            migrationBuilder.DeleteData(
                table: "Invoice",
                keyColumn: "Id",
                keyValue: new Guid("19111be4-6884-4ade-8df1-7f3e4456fd9d"));

            migrationBuilder.DeleteData(
                table: "Invoice",
                keyColumn: "Id",
                keyValue: new Guid("1b0eeea5-14bc-4d00-a87e-a107e32b8067"));

            migrationBuilder.DeleteData(
                table: "Invoice",
                keyColumn: "Id",
                keyValue: new Guid("216392a9-84b5-4224-ba0b-e777d9727299"));

            migrationBuilder.DeleteData(
                table: "Invoice",
                keyColumn: "Id",
                keyValue: new Guid("31c393ad-220b-4107-b184-c6b3b31b1509"));

            migrationBuilder.DeleteData(
                table: "Invoice",
                keyColumn: "Id",
                keyValue: new Guid("390ff260-0c33-4f7d-af5e-06535a9f9c43"));

            migrationBuilder.DeleteData(
                table: "Invoice",
                keyColumn: "Id",
                keyValue: new Guid("3e176507-24c6-4bfa-9d6d-835f8969520a"));

            migrationBuilder.DeleteData(
                table: "Invoice",
                keyColumn: "Id",
                keyValue: new Guid("3f2daf80-3fd2-4c36-a3ab-e934440d0617"));

            migrationBuilder.DeleteData(
                table: "Invoice",
                keyColumn: "Id",
                keyValue: new Guid("4187a167-35ca-4fd2-9bbd-288e34b0842e"));

            migrationBuilder.DeleteData(
                table: "Invoice",
                keyColumn: "Id",
                keyValue: new Guid("68de81dd-66dd-413a-a289-d7e6f56ba019"));

            migrationBuilder.DeleteData(
                table: "Invoice",
                keyColumn: "Id",
                keyValue: new Guid("6f987ddc-284e-436d-b043-7b0d468dd519"));

            migrationBuilder.DeleteData(
                table: "Invoice",
                keyColumn: "Id",
                keyValue: new Guid("76791a74-bf14-4302-86fa-4a060707a3ae"));

            migrationBuilder.DeleteData(
                table: "Invoice",
                keyColumn: "Id",
                keyValue: new Guid("7720d629-5131-4fbc-8815-1159d03371e2"));

            migrationBuilder.DeleteData(
                table: "Invoice",
                keyColumn: "Id",
                keyValue: new Guid("7d9b9cc4-3bb6-48c0-a146-5fdb9ac4d794"));

            migrationBuilder.DeleteData(
                table: "Invoice",
                keyColumn: "Id",
                keyValue: new Guid("81a8b16c-a078-4dfe-a74b-d1d4b86a3776"));

            migrationBuilder.DeleteData(
                table: "Invoice",
                keyColumn: "Id",
                keyValue: new Guid("852a6716-e08a-46ab-8c03-fb0b968fe0f5"));

            migrationBuilder.DeleteData(
                table: "Invoice",
                keyColumn: "Id",
                keyValue: new Guid("872dbaff-414e-499d-b034-d17ccefa7f17"));

            migrationBuilder.DeleteData(
                table: "Invoice",
                keyColumn: "Id",
                keyValue: new Guid("8958261f-63ff-4b8e-9f08-f24d827e0fb7"));

            migrationBuilder.DeleteData(
                table: "Invoice",
                keyColumn: "Id",
                keyValue: new Guid("938ef573-2119-4370-b2aa-a722719b91c8"));

            migrationBuilder.DeleteData(
                table: "Invoice",
                keyColumn: "Id",
                keyValue: new Guid("9fcd1714-7db7-4490-91b2-35957757cc3b"));

            migrationBuilder.DeleteData(
                table: "Invoice",
                keyColumn: "Id",
                keyValue: new Guid("a04173bd-56fc-497f-a810-f15a3c1235cb"));

            migrationBuilder.DeleteData(
                table: "Invoice",
                keyColumn: "Id",
                keyValue: new Guid("a3b5a1d2-7099-4924-a65c-c02e20b137bc"));

            migrationBuilder.DeleteData(
                table: "Invoice",
                keyColumn: "Id",
                keyValue: new Guid("a8c9feb4-8231-4081-b7ac-393fe76c1551"));

            migrationBuilder.DeleteData(
                table: "Invoice",
                keyColumn: "Id",
                keyValue: new Guid("b4182a59-deb7-40ae-b2e1-5f3f019abc57"));

            migrationBuilder.DeleteData(
                table: "Invoice",
                keyColumn: "Id",
                keyValue: new Guid("b48768d7-a0e9-4711-87ea-70bc684d1126"));

            migrationBuilder.DeleteData(
                table: "Invoice",
                keyColumn: "Id",
                keyValue: new Guid("b85c7dfa-49ef-4407-b420-291a3c13410e"));

            migrationBuilder.DeleteData(
                table: "Invoice",
                keyColumn: "Id",
                keyValue: new Guid("b88774e7-2ad4-4299-a601-7fc30c0d68da"));

            migrationBuilder.DeleteData(
                table: "Invoice",
                keyColumn: "Id",
                keyValue: new Guid("bb269fef-94be-4c27-a7c0-855f6c2bc833"));

            migrationBuilder.DeleteData(
                table: "Invoice",
                keyColumn: "Id",
                keyValue: new Guid("bec6bd3d-4d76-422c-bc9e-4bfa7d0dc076"));

            migrationBuilder.DeleteData(
                table: "Invoice",
                keyColumn: "Id",
                keyValue: new Guid("dc587035-cddb-433b-afe7-4f2b3a469231"));

            migrationBuilder.DeleteData(
                table: "Invoice",
                keyColumn: "Id",
                keyValue: new Guid("f2a0e750-3936-433d-8066-de16572c995c"));

            migrationBuilder.DeleteData(
                table: "Invoice",
                keyColumn: "Id",
                keyValue: new Guid("f6bf894c-0be6-46cc-bc90-80d73693021d"));

            migrationBuilder.DeleteData(
                table: "Invoice",
                keyColumn: "Id",
                keyValue: new Guid("fcb49fae-c29e-4620-8481-d86ef17ffdb6"));

            migrationBuilder.DeleteData(
                table: "Invoice",
                keyColumn: "Id",
                keyValue: new Guid("fd790cc5-2061-4a38-a3ba-40dc24a7968a"));

            migrationBuilder.DeleteData(
                table: "MovieGenre",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82268"), new Guid("9344f562-ffdc-41c5-bb24-c41c96953410") });

            migrationBuilder.DeleteData(
                table: "MovieGenre",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82274"), new Guid("9344f562-ffdc-41c5-bb24-c41c96953410") });

            migrationBuilder.DeleteData(
                table: "MovieGenre",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82263"), new Guid("9344f562-ffdc-41c5-bb24-c41c96953411") });

            migrationBuilder.DeleteData(
                table: "MovieGenre",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82263"), new Guid("9344f562-ffdc-41c5-bb24-c41c96953412") });

            migrationBuilder.DeleteData(
                table: "MovieGenre",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82272"), new Guid("9344f562-ffdc-41c5-bb24-c41c96953413") });

            migrationBuilder.DeleteData(
                table: "MovieGenre",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82262"), new Guid("9344f562-ffdc-41c5-bb24-c41c96953414") });

            migrationBuilder.DeleteData(
                table: "MovieGenre",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82266"), new Guid("9344f562-ffdc-41c5-bb24-c41c96953414") });

            migrationBuilder.DeleteData(
                table: "MovieGenre",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82266"), new Guid("9344f562-ffdc-41c5-bb24-c41c96953415") });

            migrationBuilder.DeleteData(
                table: "MovieGenre",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82273"), new Guid("9344f562-ffdc-41c5-bb24-c41c96953415") });

            migrationBuilder.DeleteData(
                table: "MovieGenre",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82276"), new Guid("9344f562-ffdc-41c5-bb24-c41c96953415") });

            migrationBuilder.DeleteData(
                table: "MovieGenre",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82270"), new Guid("9344f562-ffdc-41c5-bb24-c41c96953416") });

            migrationBuilder.DeleteData(
                table: "MovieGenre",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82262"), new Guid("9344f562-ffdc-41c5-bb24-c41c96953417") });

            migrationBuilder.DeleteData(
                table: "MovieGenre",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82273"), new Guid("9344f562-ffdc-41c5-bb24-c41c96953417") });

            migrationBuilder.DeleteData(
                table: "MovieGenre",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82274"), new Guid("9344f562-ffdc-41c5-bb24-c41c96953417") });

            migrationBuilder.DeleteData(
                table: "MovieGenre",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82265"), new Guid("9344f562-ffdc-41c5-bb24-c41c96953418") });

            migrationBuilder.DeleteData(
                table: "MovieGenre",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82268"), new Guid("9344f562-ffdc-41c5-bb24-c41c96953418") });

            migrationBuilder.DeleteData(
                table: "MovieGenre",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82267"), new Guid("9344f562-ffdc-41c5-bb24-c41c96953419") });

            migrationBuilder.DeleteData(
                table: "MovieGenre",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82271"), new Guid("9344f562-ffdc-41c5-bb24-c41c96953419") });

            migrationBuilder.DeleteData(
                table: "MovieGenre",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82262"), new Guid("9344f562-ffdc-41c5-bb24-c41c96953420") });

            migrationBuilder.DeleteData(
                table: "MovieGenre",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82271"), new Guid("9344f562-ffdc-41c5-bb24-c41c96953420") });

            migrationBuilder.DeleteData(
                table: "MovieGenre",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82267"), new Guid("9344f562-ffdc-41c5-bb24-c41c96953421") });

            migrationBuilder.DeleteData(
                table: "MovieGenre",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82268"), new Guid("9344f562-ffdc-41c5-bb24-c41c96953421") });

            migrationBuilder.DeleteData(
                table: "MovieGenre",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82269"), new Guid("9344f562-ffdc-41c5-bb24-c41c96953421") });

            migrationBuilder.DeleteData(
                table: "MovieGenre",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82272"), new Guid("9344f562-ffdc-41c5-bb24-c41c96953422") });

            migrationBuilder.DeleteData(
                table: "MovieGenre",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82275"), new Guid("9344f562-ffdc-41c5-bb24-c41c96953423") });

            migrationBuilder.DeleteData(
                table: "MovieGenre",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82276"), new Guid("9344f562-ffdc-41c5-bb24-c41c96953423") });

            migrationBuilder.DeleteData(
                table: "MovieGenre",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82261"), new Guid("9344f562-ffdc-41c5-bb24-c41c96953424") });

            migrationBuilder.DeleteData(
                table: "MovieGenre",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82263"), new Guid("9344f562-ffdc-41c5-bb24-c41c969534c1") });

            migrationBuilder.DeleteData(
                table: "MovieGenre",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82261"), new Guid("9344f562-ffdc-41c5-bb24-c41c969534c2") });

            migrationBuilder.DeleteData(
                table: "MovieGenre",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82265"), new Guid("9344f562-ffdc-41c5-bb24-c41c969534c2") });

            migrationBuilder.DeleteData(
                table: "MovieGenre",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82276"), new Guid("9344f562-ffdc-41c5-bb24-c41c969534c2") });

            migrationBuilder.DeleteData(
                table: "MovieGenre",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82271"), new Guid("9344f562-ffdc-41c5-bb24-c41c969534c3") });

            migrationBuilder.DeleteData(
                table: "MovieGenre",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82276"), new Guid("9344f562-ffdc-41c5-bb24-c41c969534c3") });

            migrationBuilder.DeleteData(
                table: "MovieGenre",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82275"), new Guid("9344f562-ffdc-41c5-bb24-c41c969534c4") });

            migrationBuilder.DeleteData(
                table: "MovieGenre",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82262"), new Guid("9344f562-ffdc-41c5-bb24-c41c969534c5") });

            migrationBuilder.DeleteData(
                table: "MovieGenre",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82263"), new Guid("9344f562-ffdc-41c5-bb24-c41c969534c6") });

            migrationBuilder.DeleteData(
                table: "MovieGenre",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82261"), new Guid("9344f562-ffdc-41c5-bb24-c41c969534c7") });

            migrationBuilder.DeleteData(
                table: "MovieGenre",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82268"), new Guid("9344f562-ffdc-41c5-bb24-c41c969534c7") });

            migrationBuilder.DeleteData(
                table: "MovieGenre",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82264"), new Guid("9344f562-ffdc-41c5-bb24-c41c969534c8") });

            migrationBuilder.DeleteData(
                table: "MovieGenre",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82272"), new Guid("9344f562-ffdc-41c5-bb24-c41c969534c8") });

            migrationBuilder.DeleteData(
                table: "MovieGenre",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82267"), new Guid("9344f562-ffdc-41c5-bb24-c41c969534c9") });

            migrationBuilder.DeleteData(
                table: "MovieGenre",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82269"), new Guid("9344f562-ffdc-41c5-bb24-c41c969534c9") });

            migrationBuilder.DeleteData(
                table: "MovieGenre",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82274"), new Guid("9344f562-ffdc-41c5-bb24-c41c969534c9") });

            migrationBuilder.DeleteData(
                table: "MovieImageSet",
                keyColumn: "MovieId",
                keyValue: new Guid("9344f562-ffdc-41c5-bb24-c41c96953410"));

            migrationBuilder.DeleteData(
                table: "MovieImageSet",
                keyColumn: "MovieId",
                keyValue: new Guid("9344f562-ffdc-41c5-bb24-c41c96953411"));

            migrationBuilder.DeleteData(
                table: "MovieImageSet",
                keyColumn: "MovieId",
                keyValue: new Guid("9344f562-ffdc-41c5-bb24-c41c96953412"));

            migrationBuilder.DeleteData(
                table: "MovieImageSet",
                keyColumn: "MovieId",
                keyValue: new Guid("9344f562-ffdc-41c5-bb24-c41c96953413"));

            migrationBuilder.DeleteData(
                table: "MovieImageSet",
                keyColumn: "MovieId",
                keyValue: new Guid("9344f562-ffdc-41c5-bb24-c41c96953414"));

            migrationBuilder.DeleteData(
                table: "MovieImageSet",
                keyColumn: "MovieId",
                keyValue: new Guid("9344f562-ffdc-41c5-bb24-c41c96953415"));

            migrationBuilder.DeleteData(
                table: "MovieImageSet",
                keyColumn: "MovieId",
                keyValue: new Guid("9344f562-ffdc-41c5-bb24-c41c96953416"));

            migrationBuilder.DeleteData(
                table: "MovieImageSet",
                keyColumn: "MovieId",
                keyValue: new Guid("9344f562-ffdc-41c5-bb24-c41c96953417"));

            migrationBuilder.DeleteData(
                table: "MovieImageSet",
                keyColumn: "MovieId",
                keyValue: new Guid("9344f562-ffdc-41c5-bb24-c41c96953418"));

            migrationBuilder.DeleteData(
                table: "MovieImageSet",
                keyColumn: "MovieId",
                keyValue: new Guid("9344f562-ffdc-41c5-bb24-c41c96953419"));

            migrationBuilder.DeleteData(
                table: "MovieImageSet",
                keyColumn: "MovieId",
                keyValue: new Guid("9344f562-ffdc-41c5-bb24-c41c96953420"));

            migrationBuilder.DeleteData(
                table: "MovieImageSet",
                keyColumn: "MovieId",
                keyValue: new Guid("9344f562-ffdc-41c5-bb24-c41c96953421"));

            migrationBuilder.DeleteData(
                table: "MovieImageSet",
                keyColumn: "MovieId",
                keyValue: new Guid("9344f562-ffdc-41c5-bb24-c41c96953422"));

            migrationBuilder.DeleteData(
                table: "MovieImageSet",
                keyColumn: "MovieId",
                keyValue: new Guid("9344f562-ffdc-41c5-bb24-c41c96953423"));

            migrationBuilder.DeleteData(
                table: "MovieImageSet",
                keyColumn: "MovieId",
                keyValue: new Guid("9344f562-ffdc-41c5-bb24-c41c96953424"));

            migrationBuilder.DeleteData(
                table: "MovieImageSet",
                keyColumn: "MovieId",
                keyValue: new Guid("9344f562-ffdc-41c5-bb24-c41c969534c3"));

            migrationBuilder.DeleteData(
                table: "MovieImageSet",
                keyColumn: "MovieId",
                keyValue: new Guid("9344f562-ffdc-41c5-bb24-c41c969534c4"));

            migrationBuilder.DeleteData(
                table: "MovieImageSet",
                keyColumn: "MovieId",
                keyValue: new Guid("9344f562-ffdc-41c5-bb24-c41c969534c5"));

            migrationBuilder.DeleteData(
                table: "MovieImageSet",
                keyColumn: "MovieId",
                keyValue: new Guid("9344f562-ffdc-41c5-bb24-c41c969534c6"));

            migrationBuilder.DeleteData(
                table: "MovieImageSet",
                keyColumn: "MovieId",
                keyValue: new Guid("9344f562-ffdc-41c5-bb24-c41c969534c7"));

            migrationBuilder.DeleteData(
                table: "MovieImageSet",
                keyColumn: "MovieId",
                keyValue: new Guid("9344f562-ffdc-41c5-bb24-c41c969534c8"));

            migrationBuilder.DeleteData(
                table: "MovieImageSet",
                keyColumn: "MovieId",
                keyValue: new Guid("9344f562-ffdc-41c5-bb24-c41c969534c9"));

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "Id",
                keyValue: new Guid("04cdc001-60ea-49cb-bbf3-63a9f765b365"));

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "Id",
                keyValue: new Guid("0914438d-0d67-4b60-abce-c3f0d8e31a9c"));

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "Id",
                keyValue: new Guid("0b5d28b2-3fdd-456c-b897-6bd55aff51f6"));

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "Id",
                keyValue: new Guid("1546a9b1-f2be-4a2d-a12d-5376dcda66e2"));

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "Id",
                keyValue: new Guid("19fa6fa7-7ef1-483e-bc90-c7e8e4b792c0"));

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "Id",
                keyValue: new Guid("1fcf9e98-3a1b-408e-a941-93adb76ef9cb"));

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "Id",
                keyValue: new Guid("206dd353-ac4e-4f7b-9e20-9026fd7c835c"));

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "Id",
                keyValue: new Guid("31e1a290-1337-42d2-876e-3d3287588f71"));

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "Id",
                keyValue: new Guid("31ed4410-4b7c-4074-a071-18550afc1350"));

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "Id",
                keyValue: new Guid("45d5285d-2493-40f3-82cb-e4d90b1f1b8e"));

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "Id",
                keyValue: new Guid("4ade96ee-66e7-4441-8b97-4492d92bbae7"));

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "Id",
                keyValue: new Guid("4ebed073-bbd6-4c85-a58d-029f1597f45b"));

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "Id",
                keyValue: new Guid("510bad2e-33d1-44f2-ac2b-0b236e497c97"));

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "Id",
                keyValue: new Guid("544d36b5-851a-4402-bce2-89cf499c285f"));

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "Id",
                keyValue: new Guid("5518fe9b-e94c-411d-a3cd-5757c945a497"));

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "Id",
                keyValue: new Guid("64ed18c8-d18f-43b1-a485-e1a7fd51cbd0"));

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "Id",
                keyValue: new Guid("76847ab7-3273-421f-83b9-9d6c48ea69be"));

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "Id",
                keyValue: new Guid("87b725ca-975e-4b1f-8e2d-01101f5f1e27"));

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "Id",
                keyValue: new Guid("97ab3b26-4b9d-4258-b368-8048995cc763"));

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "Id",
                keyValue: new Guid("9c3aea43-6a1d-49ad-be56-9fb28efa2894"));

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "Id",
                keyValue: new Guid("b054474a-a65d-47a1-a202-fe87641ca637"));

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "Id",
                keyValue: new Guid("b6d8abbb-7adf-4184-8d10-5af33c60deff"));

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "Id",
                keyValue: new Guid("b8550859-8fa8-45ba-a846-bea39c5f0048"));

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "Id",
                keyValue: new Guid("ba432577-99bb-43bb-80b2-6652013ac822"));

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "Id",
                keyValue: new Guid("cdfd2593-38c7-4e59-acd2-263125ba1f32"));

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "Id",
                keyValue: new Guid("e0163f01-f9d2-48f9-9b6f-92e6baebb5b6"));

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "Id",
                keyValue: new Guid("f5c27ef3-0485-4432-b0cb-35645a0935eb"));

            migrationBuilder.DeleteData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: new Guid("aad5caaa-a45d-490a-b26d-d503b6a82262"));

            migrationBuilder.DeleteData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: new Guid("aad5caaa-a45d-490a-b26d-d503b6a82263"));

            migrationBuilder.DeleteData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: new Guid("aad5caaa-a45d-490a-b26d-d503b6a82264"));

            migrationBuilder.DeleteData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: new Guid("aad5caaa-a45d-490a-b26d-d503b6a82266"));

            migrationBuilder.DeleteData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: new Guid("aad5caaa-a45d-490a-b26d-d503b6a82267"));

            migrationBuilder.DeleteData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: new Guid("aad5caaa-a45d-490a-b26d-d503b6a82268"));

            migrationBuilder.DeleteData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: new Guid("aad5caaa-a45d-490a-b26d-d503b6a82269"));

            migrationBuilder.DeleteData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: new Guid("aad5caaa-a45d-490a-b26d-d503b6a82270"));

            migrationBuilder.DeleteData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: new Guid("aad5caaa-a45d-490a-b26d-d503b6a82272"));

            migrationBuilder.DeleteData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: new Guid("aad5caaa-a45d-490a-b26d-d503b6a82273"));

            migrationBuilder.DeleteData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: new Guid("aad5caaa-a45d-490a-b26d-d503b6a82274"));

            migrationBuilder.DeleteData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: new Guid("aad5caaa-a45d-490a-b26d-d503b6a82275"));

            migrationBuilder.DeleteData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: new Guid("aad5caaa-a45d-490a-b26d-d503b6a82276"));

            migrationBuilder.DeleteData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: new Guid("aad5caaa-a45d-490a-b26d-d503b6a82278"));

            migrationBuilder.DeleteData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: new Guid("aad5caaa-a45d-490a-b26d-d503b6a82279"));

            migrationBuilder.DeleteData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: new Guid("aad5caaa-a45d-490a-b26d-d503b6a82280"));

            migrationBuilder.DeleteData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: new Guid("aad5caaa-a45d-490a-b26d-d503b6a82281"));

            migrationBuilder.DeleteData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: new Guid("aad5caaa-a45d-490a-b26d-d503b6a82282"));

            migrationBuilder.DeleteData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: new Guid("aad5caaa-a45d-490a-b26d-d503b6a82283"));

            migrationBuilder.DeleteData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: new Guid("aad5caaa-a45d-490a-b26d-d503b6a82284"));

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82265"));

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82266"));

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82267"));

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82268"));

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82269"));

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82270"));

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82271"));

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82272"));

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82273"));

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82274"));

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82275"));

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82276"));

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: new Guid("9344f562-ffdc-41c5-bb24-c41c96953411"));

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: new Guid("9344f562-ffdc-41c5-bb24-c41c96953413"));

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: new Guid("9344f562-ffdc-41c5-bb24-c41c96953418"));

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: new Guid("9344f562-ffdc-41c5-bb24-c41c96953419"));

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: new Guid("9344f562-ffdc-41c5-bb24-c41c96953421"));

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: new Guid("9344f562-ffdc-41c5-bb24-c41c96953424"));

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: new Guid("9344f562-ffdc-41c5-bb24-c41c969534c5"));

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: new Guid("9344f562-ffdc-41c5-bb24-c41c969534c6"));

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: new Guid("04851174-be6c-4714-bc5c-9e9501e0f1dc"));

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: new Guid("0fd66007-ff5a-4ea1-928e-22a75738867b"));

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: new Guid("10048a6e-5353-422f-be13-eadfb16922f9"));

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: new Guid("1379cf5a-f1f9-4319-a323-2984dbb59850"));

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: new Guid("1f3eccec-19b5-4a95-9759-7078d205f5d0"));

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: new Guid("218e3447-96b3-48aa-8eed-5725ae7d63c5"));

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: new Guid("24a56210-9c63-4fb2-b3bc-7b5253ae1084"));

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: new Guid("2527bef0-a0d5-4447-b04f-107e5a4db28b"));

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: new Guid("2821c53e-bdf4-4c49-9bb9-8d3c31c64efe"));

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: new Guid("2bec2a92-4f1c-49e4-8536-6bc4339e9743"));

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: new Guid("2e7f204e-c5fc-4fb7-97f0-12cb9ca34d5f"));

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: new Guid("3030d627-4551-4be9-9b7a-d893e2dfee38"));

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: new Guid("3113ddb0-f887-4e4c-b902-226244735e92"));

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: new Guid("3a786388-ebb8-4ee0-9dbc-f69fd3a83ad6"));

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: new Guid("5866e9f4-b487-4b10-b809-786e7cbc5d87"));

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: new Guid("63c38860-61d0-48bd-bfa7-ddce5c926cea"));

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: new Guid("749a9fb5-db4e-4381-b8fa-1d40207e8a5f"));

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: new Guid("75b68bdc-0685-4937-9cb4-0cc76df6a043"));

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: new Guid("893813f5-a21e-4e12-869d-0ce9c974d42a"));

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: new Guid("8a4297b9-1d91-46c9-b744-fc5b31d5da10"));

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: new Guid("8b9dc532-6bb6-4277-b05e-9beac1a60c6c"));

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: new Guid("8f9ea2ac-5f30-4473-ab5b-cb09cb624ca9"));

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: new Guid("943c64d3-57b2-41c3-a0ec-bb28541af3b4"));

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: new Guid("956ad5b2-1ce6-456f-abbf-3b271a55f0b2"));

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: new Guid("988d4603-f9ea-4193-83cf-304ef86b628d"));

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: new Guid("a3cf07c9-45f6-4e8b-b708-26f3bba25bd5"));

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: new Guid("bb974467-7c21-44af-98a4-fd17b3bbfb1a"));

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: new Guid("bd796451-d5af-4e6c-a31f-118a9f2c3eb0"));

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: new Guid("c9c541c6-cbab-40aa-91be-a9af02980cf0"));

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: new Guid("cd1b4bcf-d1c7-4118-a322-2c950ce10cc5"));

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: new Guid("cd6ef3ca-bb16-45f1-85db-1556d14e0084"));

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: new Guid("d8756c39-7798-4921-9027-d12e4092d904"));

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: new Guid("d9f3c133-d490-474f-ba26-eb29cd30770f"));

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: new Guid("e59d9501-5c17-4167-b410-b6967f6b929b"));

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: new Guid("e5d4e2c3-3e53-4717-82e5-4af74f9a4196"));

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: new Guid("efea74df-4ef1-478f-babe-4047788a793b"));

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: new Guid("f36cd610-fbde-4f07-b28e-1d90ba8438e3"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("33a8b11f-3eab-4f3c-ae10-dddfa35ffb5f"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6e790a16-11e5-4d40-b7ce-9f67721a7a4d"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("78c3cdd9-8ce2-4eb4-bb95-9b5893eccf9f"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8a0c9ce1-9a97-4252-a5a5-cc1df45f9cbc"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("92698a9a-09bb-4687-8884-34cdb18841a3"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("97f6d0bc-62c9-45d2-a608-c413d5be17d7"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a4548123-827e-428f-86e1-d98217fd9a88"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b777385f-f200-4ef4-a1af-99892cd9d867"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("cb1f260c-26f1-48b1-a277-a309397d1875"));

            migrationBuilder.DeleteData(
                table: "Director",
                keyColumn: "Id",
                keyValue: new Guid("ed9a79d9-fe9d-456e-a0a7-2a028cbe1004"));

            migrationBuilder.DeleteData(
                table: "Director",
                keyColumn: "Id",
                keyValue: new Guid("ed9a79d9-fe9d-456e-a0a7-2a028cbe1005"));

            migrationBuilder.DeleteData(
                table: "Director",
                keyColumn: "Id",
                keyValue: new Guid("ed9a79d9-fe9d-456e-a0a7-2a028cbe1010"));

            migrationBuilder.DeleteData(
                table: "Director",
                keyColumn: "Id",
                keyValue: new Guid("ed9a79d9-fe9d-456e-a0a7-2a028cbe1012"));

            migrationBuilder.DeleteData(
                table: "Director",
                keyColumn: "Id",
                keyValue: new Guid("ed9a79d9-fe9d-456e-a0a7-2a028cbe1017"));

            migrationBuilder.DeleteData(
                table: "Director",
                keyColumn: "Id",
                keyValue: new Guid("ed9a79d9-fe9d-456e-a0a7-2a028cbe1018"));

            migrationBuilder.DeleteData(
                table: "Director",
                keyColumn: "Id",
                keyValue: new Guid("ed9a79d9-fe9d-456e-a0a7-2a028cbe1020"));

            migrationBuilder.DeleteData(
                table: "Director",
                keyColumn: "Id",
                keyValue: new Guid("ed9a79d9-fe9d-456e-a0a7-2a028cbe1023"));

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "Id",
                keyValue: new Guid("06013bca-e006-451a-aaea-85688b14de98"));

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "Id",
                keyValue: new Guid("0bb00dbe-b0cc-4e78-b7ae-bc6d19bcc7bb"));

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "Id",
                keyValue: new Guid("17d9592f-c1ac-47c1-a6e8-8c7136c9913e"));

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "Id",
                keyValue: new Guid("206c03b1-43ce-46bd-b26e-ce9b99d3700e"));

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "Id",
                keyValue: new Guid("29c84102-f3aa-4791-9cc6-a769edda127d"));

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "Id",
                keyValue: new Guid("2f0b9d37-2c7c-45c0-9cee-861ddfe582e3"));

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "Id",
                keyValue: new Guid("31de204b-3740-4b15-a2fc-4943f2b38bdd"));

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "Id",
                keyValue: new Guid("3d80ce6c-bee5-4503-8f9e-17871cd0a6f0"));

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "Id",
                keyValue: new Guid("41a9ea82-acf1-4e94-acf1-4c95ca5348a4"));

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "Id",
                keyValue: new Guid("4c1908d0-9074-4bdb-a120-ee0f4d26f927"));

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "Id",
                keyValue: new Guid("4fefce7b-637b-4cfc-b9ff-bb1e6e9f5ad7"));

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "Id",
                keyValue: new Guid("5a537e30-2fa8-4e7d-b48f-aef2c68c62e2"));

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "Id",
                keyValue: new Guid("673bc310-5e54-43ab-94f5-6e5abd50cfc5"));

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "Id",
                keyValue: new Guid("6b4ff334-0ebe-44dc-ac92-b460fd008ba9"));

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "Id",
                keyValue: new Guid("6e248dc9-3edc-4a23-b7e9-749b81ffcc63"));

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "Id",
                keyValue: new Guid("6e3bc566-9a09-4c28-878c-705fef677c3c"));

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "Id",
                keyValue: new Guid("6f076634-c3de-4bc1-8ac8-a80d62f592d8"));

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "Id",
                keyValue: new Guid("70be1f3c-4496-4363-813c-2ca24ddcb0a2"));

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "Id",
                keyValue: new Guid("a0da2ed6-d9c3-45e9-897c-0e6c49e85fce"));

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "Id",
                keyValue: new Guid("a84ebedb-c229-4fd7-80a2-44666e1c16c6"));

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "Id",
                keyValue: new Guid("b21099f5-a8a5-4598-8bdb-520733c9a9c9"));

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "Id",
                keyValue: new Guid("b4f19a93-523a-4aec-8a55-51077e686866"));

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "Id",
                keyValue: new Guid("b95d0494-b262-4080-8944-11ffc2981b2e"));

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "Id",
                keyValue: new Guid("dcee07f7-e8c6-4e95-a5b0-dc0ea0a5613f"));

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "Id",
                keyValue: new Guid("e38f72dc-2518-442a-81d8-096c936bd263"));

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "Id",
                keyValue: new Guid("e4ad544c-4d5c-4684-b085-74dc19061c81"));

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "Id",
                keyValue: new Guid("e877d6b4-1e06-450a-a6d3-bc401bf4947b"));

            migrationBuilder.DeleteData(
                table: "Session",
                keyColumn: "Id",
                keyValue: new Guid("fe9766ee-75f0-4c1e-aacf-383a2881c6ad"));

            migrationBuilder.DeleteData(
                table: "Hall",
                keyColumn: "Id",
                keyValue: new Guid("d67b95a0-b12e-4574-b9ec-634b11f8df43"));

            migrationBuilder.DeleteData(
                table: "Hall",
                keyColumn: "Id",
                keyValue: new Guid("d67b95a0-b12e-4574-b9ec-634b11f8df44"));

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: new Guid("9344f562-ffdc-41c5-bb24-c41c96953410"));

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: new Guid("9344f562-ffdc-41c5-bb24-c41c96953412"));

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: new Guid("9344f562-ffdc-41c5-bb24-c41c96953414"));

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: new Guid("9344f562-ffdc-41c5-bb24-c41c96953415"));

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: new Guid("9344f562-ffdc-41c5-bb24-c41c96953416"));

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: new Guid("9344f562-ffdc-41c5-bb24-c41c96953417"));

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: new Guid("9344f562-ffdc-41c5-bb24-c41c96953420"));

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: new Guid("9344f562-ffdc-41c5-bb24-c41c96953422"));

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: new Guid("9344f562-ffdc-41c5-bb24-c41c96953423"));

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: new Guid("9344f562-ffdc-41c5-bb24-c41c969534c3"));

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: new Guid("9344f562-ffdc-41c5-bb24-c41c969534c4"));

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: new Guid("9344f562-ffdc-41c5-bb24-c41c969534c7"));

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: new Guid("9344f562-ffdc-41c5-bb24-c41c969534c8"));

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: new Guid("9344f562-ffdc-41c5-bb24-c41c969534c9"));

            migrationBuilder.DeleteData(
                table: "Director",
                keyColumn: "Id",
                keyValue: new Guid("ed9a79d9-fe9d-456e-a0a7-2a028cbe1006"));

            migrationBuilder.DeleteData(
                table: "Director",
                keyColumn: "Id",
                keyValue: new Guid("ed9a79d9-fe9d-456e-a0a7-2a028cbe1007"));

            migrationBuilder.DeleteData(
                table: "Director",
                keyColumn: "Id",
                keyValue: new Guid("ed9a79d9-fe9d-456e-a0a7-2a028cbe1008"));

            migrationBuilder.DeleteData(
                table: "Director",
                keyColumn: "Id",
                keyValue: new Guid("ed9a79d9-fe9d-456e-a0a7-2a028cbe1009"));

            migrationBuilder.DeleteData(
                table: "Director",
                keyColumn: "Id",
                keyValue: new Guid("ed9a79d9-fe9d-456e-a0a7-2a028cbe1011"));

            migrationBuilder.DeleteData(
                table: "Director",
                keyColumn: "Id",
                keyValue: new Guid("ed9a79d9-fe9d-456e-a0a7-2a028cbe1013"));

            migrationBuilder.DeleteData(
                table: "Director",
                keyColumn: "Id",
                keyValue: new Guid("ed9a79d9-fe9d-456e-a0a7-2a028cbe1014"));

            migrationBuilder.DeleteData(
                table: "Director",
                keyColumn: "Id",
                keyValue: new Guid("ed9a79d9-fe9d-456e-a0a7-2a028cbe1015"));

            migrationBuilder.DeleteData(
                table: "Director",
                keyColumn: "Id",
                keyValue: new Guid("ed9a79d9-fe9d-456e-a0a7-2a028cbe1016"));

            migrationBuilder.DeleteData(
                table: "Director",
                keyColumn: "Id",
                keyValue: new Guid("ed9a79d9-fe9d-456e-a0a7-2a028cbe1019"));

            migrationBuilder.DeleteData(
                table: "Director",
                keyColumn: "Id",
                keyValue: new Guid("ed9a79d9-fe9d-456e-a0a7-2a028cbe1021"));

            migrationBuilder.DeleteData(
                table: "Director",
                keyColumn: "Id",
                keyValue: new Guid("ed9a79d9-fe9d-456e-a0a7-2a028cbe1022"));

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
                    { new Guid("88d6040a-130f-43d4-8bee-1f0074962181"), 0, "158e1e45-8165-4f3b-8ae4-d108e90b9d30", "admin@example.com", true, false, null, "ADMIN@EXAMPLE.COM", "ADMIN", "AQAAAAIAAYagAAAAEDXcw9mjxzDvSlPjMOI9j55qRTzt5ZTil1Wsnn6iZ98tzXyVy2BYD99sIkfVXD+ZVA==", null, false, null, false, "admin" },
                    { new Guid("88d6040a-130f-43d4-8bee-1f0074962182"), 0, "411e9b9c-d8ba-4eae-a1c3-f0c3af48bfd2", "user@example.com", true, false, null, "USER@EXAMPLE.COM", "USER", "AQAAAAIAAYagAAAAEMAuZm6wgkWMXsqun0TYHxeKX7d0IIOIsY4qJ2jacQCkHFAPu9sXZw+Cd2UtIA4oVw==", null, false, null, false, "user" }
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

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "Id",
                keyValue: new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82261"),
                columns: new[] { "CreatedById", "CreatedByName", "CreatedOnUtc" },
                values: new object[] { new Guid("88d6040a-130f-43d4-8bee-1f0074962182"), "user", new DateTime(2024, 5, 18, 13, 39, 1, 364, DateTimeKind.Utc).AddTicks(7790) });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "Id",
                keyValue: new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82262"),
                columns: new[] { "CreatedById", "CreatedByName", "CreatedOnUtc" },
                values: new object[] { new Guid("88d6040a-130f-43d4-8bee-1f0074962182"), "user", new DateTime(2024, 5, 18, 13, 39, 1, 364, DateTimeKind.Utc).AddTicks(8656) });

            migrationBuilder.InsertData(
                table: "Session",
                columns: new[] { "Id", "BasePrice", "DateUtc", "HallId", "MovieId" },
                values: new object[,]
                {
                    { new Guid("1f8038c6-2e09-4919-8a40-d4715f176be1"), 299.00m, new DateTime(2024, 4, 28, 14, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d67b95a0-b12e-4574-b9ec-634b11f8df41"), new Guid("9344f562-ffdc-41c5-bb24-c41c969534c1") },
                    { new Guid("1f8038c6-2e09-4919-8a40-d4715f176be2"), 129.00m, new DateTime(2024, 4, 28, 18, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d67b95a0-b12e-4574-b9ec-634b11f8df41"), new Guid("9344f562-ffdc-41c5-bb24-c41c969534c2") },
                    { new Guid("1f8038c6-2e09-4919-8a40-d4715f176be3"), 349.00m, new DateTime(2024, 4, 28, 18, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d67b95a0-b12e-4574-b9ec-634b11f8df41"), new Guid("9344f562-ffdc-41c5-bb24-c41c969534c1") },
                    { new Guid("1f8038c6-2e09-4919-8a40-d4715f176be4"), 99.00m, new DateTime(2024, 4, 29, 12, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d67b95a0-b12e-4574-b9ec-634b11f8df42"), new Guid("9344f562-ffdc-41c5-bb24-c41c969534c2") }
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
        }
    }
}
