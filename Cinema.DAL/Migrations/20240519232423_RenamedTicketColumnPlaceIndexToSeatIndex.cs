using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cinema.DAL.Migrations
{
    /// <inheritdoc />
    public partial class RenamedTicketColumnPlaceIndexToSeatIndex : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PlaceIndex",
                table: "Ticket",
                newName: "SeatIndex");

            migrationBuilder.RenameIndex(
                name: "IX_Ticket_SessionId_RowIndex_PlaceIndex",
                table: "Ticket",
                newName: "IX_Ticket_SessionId_RowIndex_SeatIndex");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("88d6040a-130f-43d4-8bee-1f0074962181"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "45d8747e-9ed0-4dcf-b3b5-905373bfec43", "AQAAAAIAAYagAAAAEOXOikuRNwLuJbg5ArgpRY+VuCoucbeFHs8hgqV+RP8hcwtKJtV1xIbO66yL3dCvPQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("88d6040a-130f-43d4-8bee-1f0074962182"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6ab117c7-d1c8-4684-a63d-2b8048d5af5d", "AQAAAAIAAYagAAAAEAzcHDIXjB62UkPx3cikxteIcE86I6XLtnRK3lTWVssETL6COuF6DbzHh03GOl5WBw==" });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "Id",
                keyValue: new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82261"),
                column: "CreatedOnUtc",
                value: new DateTime(2024, 5, 19, 23, 24, 23, 266, DateTimeKind.Utc).AddTicks(2630));

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "Id",
                keyValue: new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82262"),
                column: "CreatedOnUtc",
                value: new DateTime(2024, 5, 19, 23, 24, 23, 266, DateTimeKind.Utc).AddTicks(3020));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SeatIndex",
                table: "Ticket",
                newName: "PlaceIndex");

            migrationBuilder.RenameIndex(
                name: "IX_Ticket_SessionId_RowIndex_SeatIndex",
                table: "Ticket",
                newName: "IX_Ticket_SessionId_RowIndex_PlaceIndex");

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
        }
    }
}
