using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cinema.DAL.Migrations
{
    /// <inheritdoc />
    public partial class addLargePosterUrlToMovie : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ActorMovie",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82267"), new Guid("38edea4a-5a0c-4428-8370-e370fc90093f") });

            migrationBuilder.DeleteData(
                table: "MovieGenre",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82264"), new Guid("38edea4a-5a0c-4428-8370-e370fc90093f") });

            migrationBuilder.DeleteData(
                table: "MovieImageSet",
                keyColumn: "MovieId",
                keyValue: new Guid("38edea4a-5a0c-4428-8370-e370fc90093f"));

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: new Guid("38edea4a-5a0c-4428-8370-e370fc90093f"));

            migrationBuilder.RenameColumn(
                name: "ImageUrl",
                table: "Movie",
                newName: "SmallPosterImageUrl");

            migrationBuilder.AddColumn<string>(
                name: "LargePosterImageUrl",
                table: "Movie",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("88d6040a-130f-43d4-8bee-1f0074962181"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "497abfa3-03d7-40e7-baf5-46aa5b89a54d", "AQAAAAIAAYagAAAAEJ1FmEvxWKgEhjZPKsHuU27QEz4VIcixEpq/1vNOYh8ACRe8ycaqS/jJwAbXHQIxHw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("88d6040a-130f-43d4-8bee-1f0074962182"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3989aca2-2a1c-4ff1-b666-b68b8060cec7", "AQAAAAIAAYagAAAAEE+NztFu9OGx53iRxnhE834fEfZ0pdkiujWunca2nyEHXXjCQuBk/fnuZ1p6Ee0KWQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("88d6040a-130f-43d4-8bee-1f0074962183"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "16d2b048-a8bd-4ed2-8996-25050ffca942", "AQAAAAIAAYagAAAAEJ96L6TnxhWYP6dkv/tcJgiRUUgoxLCBs7SikkLuCztNoivkcXnyHkobq6oxbfwWYQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("88d6040a-130f-43d4-8bee-1f0074962184"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9223ee6e-f121-4891-b576-ae7b2a68c406", "AQAAAAIAAYagAAAAEP56R8ef542GueK3xlelsCwozwRrXHtYLiSEVdVUy8Rq57EURKECUkwv1hXmafX4Ww==" });

            migrationBuilder.UpdateData(
                table: "Hall",
                keyColumn: "Id",
                keyValue: new Guid("d67b95a0-b12e-4574-b9ec-634b11f8df41"),
                column: "RowsData",
                value: "[\r\n     { \"Capacity\": 6, \"PriceMultiplier\": 1 },\r\n     { \"Capacity\": 8, \"PriceMultiplier\": 1.2 },\r\n     { \"Capacity\": 10, \"PriceMultiplier\": 1.5 },\r\n     { \"Capacity\": 10, \"PriceMultiplier\": 1.5 },\r\n     { \"Capacity\": 10, \"PriceMultiplier\": 1.5 },\r\n     { \"Capacity\": 10, \"PriceMultiplier\": 2 },\r\n     { \"Capacity\": 10, \"PriceMultiplier\": 2 },\r\n     { \"Capacity\": 10, \"PriceMultiplier\": 1.5 },\r\n     { \"Capacity\": 10, \"PriceMultiplier\": 2 },\r\n     { \"Capacity\": 10, \"PriceMultiplier\": 2 }\r\n]");

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: new Guid("9344f562-ffdc-41c5-bb24-c41c969534c1"),
                column: "LargePosterImageUrl",
                value: "https://images4.alphacoders.com/132/1326785.jpeg");

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: new Guid("9344f562-ffdc-41c5-bb24-c41c969534c2"),
                column: "LargePosterImageUrl",
                value: "https://i.pinimg.com/originals/e9/24/0b/e9240b7c5b29b0fb4aa86304a03287e8.jpg");

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: new Guid("9344f562-ffdc-41c5-bb24-c41c969534c3"),
                column: "LargePosterImageUrl",
                value: "https://images.wallpapersden.com/image/download/silo-2023-season_bmVsamqUmZqaraWkpJRmbmdlrWZlbWU.jpg");

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: new Guid("9344f562-ffdc-41c5-bb24-c41c969534c4"),
                column: "LargePosterImageUrl",
                value: "https://www.hdwallpapers.in/download/poster_of_dune_2020_4k_hd_movies-HD.jpg");

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: new Guid("9344f562-ffdc-41c5-bb24-c41c969534c5"),
                column: "LargePosterImageUrl",
                value: "https://wallpaperswide.com/download/keira_knightley_pirates_of_the_caribbean_at_worlds_end-wallpaper-1920x1080.jpg");

            migrationBuilder.InsertData(
                table: "Movie",
                columns: new[] { "Id", "AgeRestriction", "Description", "DirectorId", "Duration", "LargePosterImageUrl", "Name", "ReleaseDate", "SmallPosterImageUrl", "TrailerUrl" },
                values: new object[] { new Guid("01ba7a49-ff3b-4138-9aff-3d43df1325a9"), "TV-MA", "In a dystopian future where humankind has lost its sight, two children with the ability to see are born.", new Guid("ed9a79d9-fe9d-456e-a0a7-2a028cbe1003"), 143, "https://pics.filmaffinity.com/See_TV_Series-838548891-large.jpg", "See", new DateTime(2019, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://www.kino-teatr.ru/movie/posters/big/8/2/137928.jpg", "https://www.youtube.com/watch?v=7Rg0y7NT1gU" });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "Id",
                keyValue: new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82261"),
                column: "CreatedOnUtc",
                value: new DateTime(2024, 12, 6, 16, 3, 47, 307, DateTimeKind.Utc).AddTicks(1709));

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "Id",
                keyValue: new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82262"),
                column: "CreatedOnUtc",
                value: new DateTime(2024, 12, 6, 16, 3, 47, 307, DateTimeKind.Utc).AddTicks(2000));

            migrationBuilder.InsertData(
                table: "ActorMovie",
                columns: new[] { "ActorId", "MovieId" },
                values: new object[] { new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82267"), new Guid("01ba7a49-ff3b-4138-9aff-3d43df1325a9") });

            migrationBuilder.InsertData(
                table: "MovieGenre",
                columns: new[] { "GenreId", "MovieId" },
                values: new object[] { new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82264"), new Guid("01ba7a49-ff3b-4138-9aff-3d43df1325a9") });

            migrationBuilder.InsertData(
                table: "MovieImageSet",
                columns: new[] { "MovieId", "ImagesUrl" },
                values: new object[] { new Guid("01ba7a49-ff3b-4138-9aff-3d43df1325a9"), "['https://static1.cbrimages.com/wordpress/wp-content/uploads/2019/11/see-feature.jpg','https://images.bauerhosting.com/legacy/media/612d/f171/f03d/2f72/b707/68e4/see-season-2-2.jpg?auto=format&w=1440&q=80']" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ActorMovie",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82267"), new Guid("01ba7a49-ff3b-4138-9aff-3d43df1325a9") });

            migrationBuilder.DeleteData(
                table: "MovieGenre",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82264"), new Guid("01ba7a49-ff3b-4138-9aff-3d43df1325a9") });

            migrationBuilder.DeleteData(
                table: "MovieImageSet",
                keyColumn: "MovieId",
                keyValue: new Guid("01ba7a49-ff3b-4138-9aff-3d43df1325a9"));

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: new Guid("01ba7a49-ff3b-4138-9aff-3d43df1325a9"));

            migrationBuilder.DropColumn(
                name: "LargePosterImageUrl",
                table: "Movie");

            migrationBuilder.RenameColumn(
                name: "SmallPosterImageUrl",
                table: "Movie",
                newName: "ImageUrl");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("88d6040a-130f-43d4-8bee-1f0074962181"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "19900c34-e662-4148-927a-8af71a8f2580", "AQAAAAIAAYagAAAAEBHrqc/BOiNGK3mBhO4BBA2mQnSjQwzBkfC1EIi5ZH7BZiK77CxXT+vpzQR08AnnQg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("88d6040a-130f-43d4-8bee-1f0074962182"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "495b5497-dbb8-45fc-ae8a-bdf67cd63456", "AQAAAAIAAYagAAAAEHXk7FlQ4ogsQpwyp/kQWynpChE5oJCzgj61P26xQynvJTB3ocz7z35z6Hvy1hGH5w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("88d6040a-130f-43d4-8bee-1f0074962183"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a54e2bdc-ffc4-432c-97c8-49eeaaf3d8cb", "AQAAAAIAAYagAAAAECkNVFKO5yCpoI88MjQr/xqna+gPKIrLoW/D+tuG/keUb/lHb6dZ+4StpkUkzgyr/w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("88d6040a-130f-43d4-8bee-1f0074962184"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e6cd5179-d285-4887-bf13-0e65110cd121", "AQAAAAIAAYagAAAAEJqJ+KUfQd+G7EcEcRmbAtColcatziow1S1Gby19q+wCBO4gh0MTCiF1V3SKqw3Png==" });

            migrationBuilder.UpdateData(
                table: "Hall",
                keyColumn: "Id",
                keyValue: new Guid("d67b95a0-b12e-4574-b9ec-634b11f8df41"),
                column: "RowsData",
                value: "[\r\n     { \"Capacity\": 6, \"PriceMultiplier\": 1 },\r\n     { \"Capacity\": 8, \"PriceMultiplier\": 1.2 },\r\n     { \"Capacity\": 10, \"PriceMultiplier\": 1.5 },\r\n     { \"Capacity\": 10, \"PriceMultiplier\": 1.5 },\r\n     { \"Capacity\": 10, \"PriceMultiplier\": 1.5 },\r\n     { \"Capacity\": 10, \"PriceMultiplier\": 2 },\r\n     { \"Capacity\": 10, \"PriceMultiplier\": 2 },\r\n     { \"Capacity\": 10, \"PriceMultiplier\": 1.5 },\r\n     { \"Capacity\": 10, \"PriceMultiplier\": 2 },\r\n     { \"Capacity\": 10, \"PriceMultiplier\": 2 },\r\n]");

            migrationBuilder.InsertData(
                table: "Movie",
                columns: new[] { "Id", "AgeRestriction", "Description", "DirectorId", "Duration", "ImageUrl", "Name", "ReleaseDate", "TrailerUrl" },
                values: new object[] { new Guid("38edea4a-5a0c-4428-8370-e370fc90093f"), "TV-MA", "In a dystopian future where humankind has lost its sight, two children with the ability to see are born.", new Guid("ed9a79d9-fe9d-456e-a0a7-2a028cbe1003"), 143, "https://www.kino-teatr.ru/movie/posters/big/8/2/137928.jpg", "See", new DateTime(2019, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://www.youtube.com/watch?v=7Rg0y7NT1gU" });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "Id",
                keyValue: new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82261"),
                column: "CreatedOnUtc",
                value: new DateTime(2024, 12, 2, 20, 8, 57, 839, DateTimeKind.Utc).AddTicks(7998));

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "Id",
                keyValue: new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82262"),
                column: "CreatedOnUtc",
                value: new DateTime(2024, 12, 2, 20, 8, 57, 839, DateTimeKind.Utc).AddTicks(8359));

            migrationBuilder.InsertData(
                table: "ActorMovie",
                columns: new[] { "ActorId", "MovieId" },
                values: new object[] { new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82267"), new Guid("38edea4a-5a0c-4428-8370-e370fc90093f") });

            migrationBuilder.InsertData(
                table: "MovieGenre",
                columns: new[] { "GenreId", "MovieId" },
                values: new object[] { new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82264"), new Guid("38edea4a-5a0c-4428-8370-e370fc90093f") });

            migrationBuilder.InsertData(
                table: "MovieImageSet",
                columns: new[] { "MovieId", "ImagesUrl" },
                values: new object[] { new Guid("38edea4a-5a0c-4428-8370-e370fc90093f"), "['https://static1.cbrimages.com/wordpress/wp-content/uploads/2019/11/see-feature.jpg','https://images.bauerhosting.com/legacy/media/612d/f171/f03d/2f72/b707/68e4/see-season-2-2.jpg?auto=format&w=1440&q=80']" });
        }
    }
}
