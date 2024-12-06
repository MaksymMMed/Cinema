using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Cinema.DAL.Migrations
{
    /// <inheritdoc />
    public partial class moreseeds : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Actor",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82265"), "Rebecca Ferguson" },
                    { new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82266"), "Johny Depp" },
                    { new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82267"), "Jason Momoa" }
                });

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
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "UserName" },
                values: new object[] { "495b5497-dbb8-45fc-ae8a-bdf67cd63456", "WWhite@example.com", "WWHITE@EXAMPLE.COM", "WALTHER WHITE", "AQAAAAIAAYagAAAAEHXk7FlQ4ogsQpwyp/kQWynpChE5oJCzgj61P26xQynvJTB3ocz7z35z6Hvy1hGH5w==", "Walther White" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("88d6040a-130f-43d4-8bee-1f0074962183"), 0, "a54e2bdc-ffc4-432c-97c8-49eeaaf3d8cb", "jpink@example.com", true, false, null, "JPINK@EXAMPLE.COM", "JESSIE PINKMAN", "AQAAAAIAAYagAAAAECkNVFKO5yCpoI88MjQr/xqna+gPKIrLoW/D+tuG/keUb/lHb6dZ+4StpkUkzgyr/w==", null, false, null, false, "Jessie Pinkman" },
                    { new Guid("88d6040a-130f-43d4-8bee-1f0074962184"), 0, "e6cd5179-d285-4887-bf13-0e65110cd121", "user@example.com", true, false, null, "USER@EXAMPLE.COM", "USER", "AQAAAAIAAYagAAAAEJqJ+KUfQd+G7EcEcRmbAtColcatziow1S1Gby19q+wCBO4gh0MTCiF1V3SKqw3Png==", null, false, null, false, "user" }
                });

            migrationBuilder.InsertData(
                table: "Genre",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82265"), "Detective" });

            migrationBuilder.InsertData(
                table: "Movie",
                columns: new[] { "Id", "AgeRestriction", "Description", "DirectorId", "Duration", "ImageUrl", "Name", "ReleaseDate", "TrailerUrl" },
                values: new object[,]
                {
                    { new Guid("38edea4a-5a0c-4428-8370-e370fc90093f"), "TV-MA", "In a dystopian future where humankind has lost its sight, two children with the ability to see are born.", new Guid("ed9a79d9-fe9d-456e-a0a7-2a028cbe1003"), 143, "https://www.kino-teatr.ru/movie/posters/big/8/2/137928.jpg", "See", new DateTime(2019, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://www.youtube.com/watch?v=7Rg0y7NT1gU" },
                    { new Guid("9344f562-ffdc-41c5-bb24-c41c969534c3"), "PG-13", "140 years after a devastating civil war, Earth's population is living underground in a silo due to the effects of the war on the atmosphere. In the silo the Sherrif's wife stumbles upon some prohibited information and is sentenced to go outside and die. A few years later her husband voluntarily follows her. The information they uncovered is stored in a 140+ year old hard-drive. The hard-drive lands in the possession of an engineer. When he is murdered his girlfriend, a fellow engineer, searches for the truth.", new Guid("ed9a79d9-fe9d-456e-a0a7-2a028cbe1002"), 120, "https://upload.wikimedia.org/wikipedia/uk/thumb/d/d0/Silo_2023.jpg/250px-Silo_2023.jpg", "Silo", new DateTime(2019, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://youtu.be/8ZYhuvIv1pA?si=zOpNLdrSdlAmkF0V" },
                    { new Guid("9344f562-ffdc-41c5-bb24-c41c969534c4"), "PG-13", "Dune is a 2021 epic science fiction film based on the 1965 novel by Frank Herbert.", new Guid("ed9a79d9-fe9d-456e-a0a7-2a028cbe1002"), 155, "https://cdn.europosters.eu/image/1300/122815.jpg", "Dune", new DateTime(2021, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://www.youtube.com/watch?v=n9xhJrPXop4" },
                    { new Guid("9344f562-ffdc-41c5-bb24-c41c969534c5"), "PG-13", "A young blacksmith teams up with an eccentric pirate to save the governor's daughter.", new Guid("ed9a79d9-fe9d-456e-a0a7-2a028cbe1003"), 143, "https://lumiere-a.akamaihd.net/v1/images/p_piratesofthecaribbean_thecurseoftheblackpearl_19642_d1ba8e66.jpeg", "Pirates of the Caribbean: The Curse of the Black Pearl", new DateTime(2003, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://www.youtube.com/watch?v=naQr0uTrH_s" }
                });

            migrationBuilder.UpdateData(
                table: "MovieImageSet",
                keyColumn: "MovieId",
                keyValue: new Guid("9344f562-ffdc-41c5-bb24-c41c969534c1"),
                column: "ImagesUrl",
                value: "['https://64.media.tumblr.com/03f0f59694430f001d08e9309dc52f2e/f5e1e516dcb80f72-07/s1280x1920/9263ba9178755f24391d9ef5fd6d23c8ba9ab35d.jpg','https://64.media.tumblr.com/5bb66a7e359f0a5fec8a238d73798291/f5e1e516dcb80f72-9b/s1280x1920/5ec8af306838ed682350b62189e31627e578b701.jpg','https://m.media-amazon.com/images/M/MV5BNjI0ZmE0NjMtMzQ5ZS00N2RiLThkYzAtYjExOTc2MjU4ZGMzXkEyXkFqcGc@._V1_.jpg']");

            migrationBuilder.UpdateData(
                table: "MovieImageSet",
                keyColumn: "MovieId",
                keyValue: new Guid("9344f562-ffdc-41c5-bb24-c41c969534c2"),
                column: "ImagesUrl",
                value: "['https://edgroom-blogs.s3.ap-south-1.amazonaws.com/202310071805064792540_38983_u23h.jpg','https://thinkinginenglish.blog/wp-content/uploads/2024/09/interstellar-new-poster-wallpaper.jpg','https://media.npr.org/assets/img/2014/11/13/fl-17895r_wide-3696728b9df392e99c72d2f2e352ed91d982f03c.jpg']");

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "Id",
                keyValue: new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82261"),
                columns: new[] { "CreatedByName", "CreatedOnUtc" },
                values: new object[] { "Walther White", new DateTime(2024, 12, 2, 20, 8, 57, 839, DateTimeKind.Utc).AddTicks(7998) });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "Id",
                keyValue: new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82262"),
                columns: new[] { "CreatedByName", "CreatedOnUtc" },
                values: new object[] { "Walther White", new DateTime(2024, 12, 2, 20, 8, 57, 839, DateTimeKind.Utc).AddTicks(8359) });

            migrationBuilder.InsertData(
                table: "ActorMovie",
                columns: new[] { "ActorId", "MovieId" },
                values: new object[,]
                {
                    { new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82265"), new Guid("9344f562-ffdc-41c5-bb24-c41c969534c3") },
                    { new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82265"), new Guid("9344f562-ffdc-41c5-bb24-c41c969534c4") },
                    { new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82266"), new Guid("9344f562-ffdc-41c5-bb24-c41c969534c5") },
                    { new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82267"), new Guid("38edea4a-5a0c-4428-8370-e370fc90093f") }
                });

            migrationBuilder.InsertData(
                table: "MovieGenre",
                columns: new[] { "GenreId", "MovieId" },
                values: new object[,]
                {
                    { new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82264"), new Guid("38edea4a-5a0c-4428-8370-e370fc90093f") },
                    { new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82264"), new Guid("9344f562-ffdc-41c5-bb24-c41c969534c3") },
                    { new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82264"), new Guid("9344f562-ffdc-41c5-bb24-c41c969534c4") },
                    { new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82265"), new Guid("9344f562-ffdc-41c5-bb24-c41c969534c4") },
                    { new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82264"), new Guid("9344f562-ffdc-41c5-bb24-c41c969534c5") }
                });

            migrationBuilder.InsertData(
                table: "MovieImageSet",
                columns: new[] { "MovieId", "ImagesUrl" },
                values: new object[,]
                {
                    { new Guid("38edea4a-5a0c-4428-8370-e370fc90093f"), "['https://static1.cbrimages.com/wordpress/wp-content/uploads/2019/11/see-feature.jpg','https://images.bauerhosting.com/legacy/media/612d/f171/f03d/2f72/b707/68e4/see-season-2-2.jpg?auto=format&w=1440&q=80']" },
                    { new Guid("9344f562-ffdc-41c5-bb24-c41c969534c3"), "['https://www.apple.com/tv-pr/shows-and-films/s/silo/images/season-02/unit-photos/episode-01/photo-020101/Silo_Photo_020101.jpg.photo_modal_show_home_large.jpg','https://miro.medium.com/v2/resize:fit:1400/0*SzLdkt_ctC5AXnUC','https://cdn.mos.cms.futurecdn.net/phChq4QbVMg7JmNpDe8nMf.jpg']" },
                    { new Guid("9344f562-ffdc-41c5-bb24-c41c969534c4"), "['https://media.vanityfair.com/photos/65bc53b6dbcc8f7a911121f8/master/pass/DUN2-T3-0084r.jpg','https://itc.ua/wp-content/uploads/2024/03/ss_807bdb42cfd6f7dbfabdc1bbf1273609af615b38.1920x1080.jpg']" },
                    { new Guid("9344f562-ffdc-41c5-bb24-c41c969534c5"), "['https://d23.com/app/uploads/2015/09/1180-x-600-091715_pirates-of-the-caribbean-fav-quotes-1180x600.jpg','https://lumiere-a.akamaihd.net/v1/images/g_piratesofthecaribbean_thecurseoftheblackpearl_disneym_c994a7ff.jpeg?region=1%2C0%2C1298%2C730']" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ActorMovie",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82265"), new Guid("9344f562-ffdc-41c5-bb24-c41c969534c3") });

            migrationBuilder.DeleteData(
                table: "ActorMovie",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82265"), new Guid("9344f562-ffdc-41c5-bb24-c41c969534c4") });

            migrationBuilder.DeleteData(
                table: "ActorMovie",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82266"), new Guid("9344f562-ffdc-41c5-bb24-c41c969534c5") });

            migrationBuilder.DeleteData(
                table: "ActorMovie",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82267"), new Guid("38edea4a-5a0c-4428-8370-e370fc90093f") });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("88d6040a-130f-43d4-8bee-1f0074962183"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("88d6040a-130f-43d4-8bee-1f0074962184"));

            migrationBuilder.DeleteData(
                table: "MovieGenre",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82264"), new Guid("38edea4a-5a0c-4428-8370-e370fc90093f") });

            migrationBuilder.DeleteData(
                table: "MovieGenre",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82264"), new Guid("9344f562-ffdc-41c5-bb24-c41c969534c3") });

            migrationBuilder.DeleteData(
                table: "MovieGenre",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82264"), new Guid("9344f562-ffdc-41c5-bb24-c41c969534c4") });

            migrationBuilder.DeleteData(
                table: "MovieGenre",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82265"), new Guid("9344f562-ffdc-41c5-bb24-c41c969534c4") });

            migrationBuilder.DeleteData(
                table: "MovieGenre",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82264"), new Guid("9344f562-ffdc-41c5-bb24-c41c969534c5") });

            migrationBuilder.DeleteData(
                table: "MovieImageSet",
                keyColumn: "MovieId",
                keyValue: new Guid("38edea4a-5a0c-4428-8370-e370fc90093f"));

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
                table: "Actor",
                keyColumn: "Id",
                keyValue: new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82265"));

            migrationBuilder.DeleteData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82266"));

            migrationBuilder.DeleteData(
                table: "Actor",
                keyColumn: "Id",
                keyValue: new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82267"));

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82265"));

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: new Guid("38edea4a-5a0c-4428-8370-e370fc90093f"));

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
                keyValue: new Guid("9344f562-ffdc-41c5-bb24-c41c969534c5"));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("88d6040a-130f-43d4-8bee-1f0074962181"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "db4526f2-c794-4655-acb6-554b85b4398d", "AQAAAAIAAYagAAAAEJ8GgflUueKNJ5sRlSUFdKyTQ0Slm8/4jkeEZtsgKD2NMv+Wv/MgOZkK+hrTazKyKg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("88d6040a-130f-43d4-8bee-1f0074962182"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "UserName" },
                values: new object[] { "7e2b0846-98ea-4cff-8f26-ef55f16b7c7e", "user@example.com", "USER@EXAMPLE.COM", "USER", "AQAAAAIAAYagAAAAENS3oyrQSpbPtoBkYTVTbBBT312s2IfeHXG/WjSjPrpDxYSJov5k9FWqVdba1GtV1Q==", "user" });

            migrationBuilder.UpdateData(
                table: "MovieImageSet",
                keyColumn: "MovieId",
                keyValue: new Guid("9344f562-ffdc-41c5-bb24-c41c969534c1"),
                column: "ImagesUrl",
                value: "['https://64.media.tumblr.com/03f0f59694430f001d08e9309dc52f2e/f5e1e516dcb80f72-07/s1280x1920/9263ba9178755f24391d9ef5fd6d23c8ba9ab35d.jpg','https://64.media.tumblr.com/5bb66a7e359f0a5fec8a238d73798291/f5e1e516dcb80f72-9b/s1280x1920/5ec8af306838ed682350b62189e31627e578b701.jpg']");

            migrationBuilder.UpdateData(
                table: "MovieImageSet",
                keyColumn: "MovieId",
                keyValue: new Guid("9344f562-ffdc-41c5-bb24-c41c969534c2"),
                column: "ImagesUrl",
                value: "['https://64.media.tumblr.com/03f0f59694430f001d08e9309dc52f2e/f5e1e516dcb80f72-07/s1280x1920/9263ba9178755f24391d9ef5fd6d23c8ba9ab35d.jpg','https://64.media.tumblr.com/5bb66a7e359f0a5fec8a238d73798291/f5e1e516dcb80f72-9b/s1280x1920/5ec8af306838ed682350b62189e31627e578b701.jpg']");

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "Id",
                keyValue: new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82261"),
                columns: new[] { "CreatedByName", "CreatedOnUtc" },
                values: new object[] { "user", new DateTime(2024, 5, 20, 22, 21, 57, 105, DateTimeKind.Utc).AddTicks(2023) });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "Id",
                keyValue: new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82262"),
                columns: new[] { "CreatedByName", "CreatedOnUtc" },
                values: new object[] { "user", new DateTime(2024, 5, 20, 22, 21, 57, 105, DateTimeKind.Utc).AddTicks(2327) });
        }
    }
}
