using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cinema.DAL.Migrations
{
    /// <inheritdoc />
    public partial class AddNameColumnToHallsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Hall",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("88d6040a-130f-43d4-8bee-1f0074962181"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "163d0b43-ca84-4ba8-b667-56f17e26e67e", "AQAAAAIAAYagAAAAEISStjPpl+pjuhVYSmywehxysage8HIa6DGpaHet7jSlJ6gqA00D+7Z4sZ/su+YfZQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("88d6040a-130f-43d4-8bee-1f0074962182"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9d9961ac-0f48-4c15-b348-9d026445f5c5", "AQAAAAIAAYagAAAAEMpBDSmfwQAxP90hthj8b85I5aQ/H/krsv31evm749XY/nlDpCCzDMdbmFwRYc/kLw==" });

            migrationBuilder.UpdateData(
                table: "Hall",
                keyColumn: "Id",
                keyValue: new Guid("d67b95a0-b12e-4574-b9ec-634b11f8df41"),
                column: "Name",
                value: "Hall 1 (Big)");

            migrationBuilder.UpdateData(
                table: "Hall",
                keyColumn: "Id",
                keyValue: new Guid("d67b95a0-b12e-4574-b9ec-634b11f8df42"),
                column: "Name",
                value: "Hall 2 (Small)");

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "Id",
                keyValue: new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82261"),
                column: "CreatedOnUtc",
                value: new DateTime(2024, 5, 19, 21, 28, 53, 885, DateTimeKind.Utc).AddTicks(7220));

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "Id",
                keyValue: new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82262"),
                column: "CreatedOnUtc",
                value: new DateTime(2024, 5, 19, 21, 28, 53, 885, DateTimeKind.Utc).AddTicks(7560));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Hall");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("88d6040a-130f-43d4-8bee-1f0074962181"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6563f52c-1ead-4345-9305-74d721694b8f", "AQAAAAIAAYagAAAAEG7J7VndOkKCthbs11XNZkS7giTODEJny3IeilLi3YIEa3NrAVIY88XAtav8wz8zzg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("88d6040a-130f-43d4-8bee-1f0074962182"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ec069d79-5106-4e08-b8cc-79f5345e85fe", "AQAAAAIAAYagAAAAEPLMEzlIPKtnuXJDTNirfDZroPLQVGLGF7bVzfJ6ZNxL7F/GFLpKnLEvRX+emhJapQ==" });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "Id",
                keyValue: new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82261"),
                column: "CreatedOnUtc",
                value: new DateTime(2024, 5, 19, 21, 19, 32, 539, DateTimeKind.Utc).AddTicks(3720));

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "Id",
                keyValue: new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82262"),
                column: "CreatedOnUtc",
                value: new DateTime(2024, 5, 19, 21, 19, 32, 539, DateTimeKind.Utc).AddTicks(4110));
        }
    }
}
