using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cinema.DAL.Migrations
{
    /// <inheritdoc />
    public partial class UpdateHallsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Ticket_SessionId",
                table: "Ticket");

            migrationBuilder.RenameColumn(
                name: "RowsCapacity",
                table: "Hall",
                newName: "RowsData");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("88d6040a-130f-43d4-8bee-1f0074962181"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "84211d55-de98-4f9d-a2e2-38b4d183b1e9", "AQAAAAIAAYagAAAAEBUmMf5mRfxhNIs3oipQBzxz3g7faMqsAdt2QTbtBA07Z82qw6a1Y2bWupWE+XdBfg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("88d6040a-130f-43d4-8bee-1f0074962182"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c1bb3371-aee7-4121-8a71-cc1e78bfebaa", "AQAAAAIAAYagAAAAEM/zxVDQ2EHUOzOXpMrUXfG73O4WW49SOEdhhv9rhKYS1aTcOLvC6KoU6CXzRiC41g==" });

            migrationBuilder.UpdateData(
                table: "Hall",
                keyColumn: "Id",
                keyValue: new Guid("d67b95a0-b12e-4574-b9ec-634b11f8df41"),
                column: "RowsData",
                value: "[\n     { \"Capacity\": 6, \"PriceMultiplier\": 1 },\n     { \"Capacity\": 8, \"PriceMultiplier\": 1.2 },\n     { \"Capacity\": 10, \"PriceMultiplier\": 1.5 },\n     { \"Capacity\": 10, \"PriceMultiplier\": 1.5 },\n     { \"Capacity\": 10, \"PriceMultiplier\": 1.5 },\n     { \"Capacity\": 10, \"PriceMultiplier\": 2 },\n     { \"Capacity\": 10, \"PriceMultiplier\": 2 },\n     { \"Capacity\": 10, \"PriceMultiplier\": 1.5 },\n     { \"Capacity\": 10, \"PriceMultiplier\": 2 },\n     { \"Capacity\": 10, \"PriceMultiplier\": 2 },\n]");

            migrationBuilder.UpdateData(
                table: "Hall",
                keyColumn: "Id",
                keyValue: new Guid("d67b95a0-b12e-4574-b9ec-634b11f8df42"),
                column: "RowsData",
                value: "[\n     { \"Capacity\": 8, \"PriceMultiplier\": 1 },\n     { \"Capacity\": 5, \"PriceMultiplier\": 1.2 },\n     { \"Capacity\": 5, \"PriceMultiplier\": 1.6 },\n     { \"Capacity\": 5, \"PriceMultiplier\": 1.6 },\n     { \"Capacity\": 5, \"PriceMultiplier\": 1.6 },\n     { \"Capacity\": 5, \"PriceMultiplier\": 2 },\n     { \"Capacity\": 5, \"PriceMultiplier\": 2 },\n     { \"Capacity\": 5, \"PriceMultiplier\": 2 }\n]");

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "Id",
                keyValue: new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82261"),
                column: "CreatedOnUtc",
                value: new DateTime(2024, 5, 19, 23, 22, 50, 43, DateTimeKind.Utc).AddTicks(7270));

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "Id",
                keyValue: new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82262"),
                column: "CreatedOnUtc",
                value: new DateTime(2024, 5, 19, 23, 22, 50, 43, DateTimeKind.Utc).AddTicks(7630));

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_SessionId_RowIndex_PlaceIndex",
                table: "Ticket",
                columns: new[] { "SessionId", "RowIndex", "PlaceIndex" },
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Ticket_SessionId_RowIndex_PlaceIndex",
                table: "Ticket");

            migrationBuilder.RenameColumn(
                name: "RowsData",
                table: "Hall",
                newName: "RowsCapacity");

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
                column: "RowsCapacity",
                value: "[10,10,10,10,10,10,10,10,10,10]");

            migrationBuilder.UpdateData(
                table: "Hall",
                keyColumn: "Id",
                keyValue: new Guid("d67b95a0-b12e-4574-b9ec-634b11f8df42"),
                column: "RowsCapacity",
                value: "[5,5,5,5,5,5,5,5,5,5]");

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

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_SessionId",
                table: "Ticket",
                column: "SessionId");
        }
    }
}
