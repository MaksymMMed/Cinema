using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cinema.DAL.Migrations
{
    /// <inheritdoc />
    public partial class UpdateTicketsAndInvoicesTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "TicketInvoiceFK",
                table: "Invoice");

            migrationBuilder.DropForeignKey(
                name: "TicketHallFK",
                table: "Ticket");

            migrationBuilder.DropForeignKey(
                name: "TicketUserFK",
                table: "Ticket");

            migrationBuilder.DropIndex(
                name: "IX_Invoice_TicketId",
                table: "Invoice");

            migrationBuilder.DropColumn(
                name: "TicketId",
                table: "Invoice");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Ticket",
                newName: "InvoiceId");

            migrationBuilder.RenameIndex(
                name: "IX_Ticket_UserId",
                table: "Ticket",
                newName: "IX_Ticket_InvoiceId");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "Invoice",
                newName: "IsPaid");

            migrationBuilder.AlterColumn<Guid>(
                name: "HallId",
                table: "Ticket",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddColumn<Guid>(
                name: "AspNetUserId",
                table: "Ticket",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Amount",
                table: "Invoice",
                type: "decimal(8,2)",
                precision: 8,
                scale: 2,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

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
                table: "Invoice",
                keyColumn: "Id",
                keyValue: new Guid("363c2006-3d51-46ea-af49-f40fe7605441"),
                column: "Amount",
                value: 100.00m);

            migrationBuilder.UpdateData(
                table: "Invoice",
                keyColumn: "Id",
                keyValue: new Guid("363c2006-3d51-46ea-af49-f40fe7605442"),
                column: "Amount",
                value: 100.00m);

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

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: new Guid("9ea79a4c-d3d2-4fdf-b9c4-9f4b71e6f011"),
                columns: new[] { "AspNetUserId", "HallId", "InvoiceId" },
                values: new object[] { null, null, new Guid("363c2006-3d51-46ea-af49-f40fe7605441") });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: new Guid("9ea79a4c-d3d2-4fdf-b9c4-9f4b71e6f012"),
                columns: new[] { "AspNetUserId", "HallId", "InvoiceId" },
                values: new object[] { null, null, new Guid("363c2006-3d51-46ea-af49-f40fe7605442") });

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_AspNetUserId",
                table: "Ticket",
                column: "AspNetUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ticket_AspNetUsers_AspNetUserId",
                table: "Ticket",
                column: "AspNetUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Ticket_Hall_HallId",
                table: "Ticket",
                column: "HallId",
                principalTable: "Hall",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "InvoiceTicketsFK",
                table: "Ticket",
                column: "InvoiceId",
                principalTable: "Invoice",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ticket_AspNetUsers_AspNetUserId",
                table: "Ticket");

            migrationBuilder.DropForeignKey(
                name: "FK_Ticket_Hall_HallId",
                table: "Ticket");

            migrationBuilder.DropForeignKey(
                name: "InvoiceTicketsFK",
                table: "Ticket");

            migrationBuilder.DropIndex(
                name: "IX_Ticket_AspNetUserId",
                table: "Ticket");

            migrationBuilder.DropColumn(
                name: "AspNetUserId",
                table: "Ticket");

            migrationBuilder.RenameColumn(
                name: "InvoiceId",
                table: "Ticket",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Ticket_InvoiceId",
                table: "Ticket",
                newName: "IX_Ticket_UserId");

            migrationBuilder.RenameColumn(
                name: "IsPaid",
                table: "Invoice",
                newName: "Status");

            migrationBuilder.AlterColumn<Guid>(
                name: "HallId",
                table: "Ticket",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Amount",
                table: "Invoice",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(8,2)",
                oldPrecision: 8,
                oldScale: 2);

            migrationBuilder.AddColumn<Guid>(
                name: "TicketId",
                table: "Invoice",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("88d6040a-130f-43d4-8bee-1f0074962181"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "158e1e45-8165-4f3b-8ae4-d108e90b9d30", "AQAAAAIAAYagAAAAEDXcw9mjxzDvSlPjMOI9j55qRTzt5ZTil1Wsnn6iZ98tzXyVy2BYD99sIkfVXD+ZVA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("88d6040a-130f-43d4-8bee-1f0074962182"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "411e9b9c-d8ba-4eae-a1c3-f0c3af48bfd2", "AQAAAAIAAYagAAAAEMAuZm6wgkWMXsqun0TYHxeKX7d0IIOIsY4qJ2jacQCkHFAPu9sXZw+Cd2UtIA4oVw==" });

            migrationBuilder.UpdateData(
                table: "Invoice",
                keyColumn: "Id",
                keyValue: new Guid("363c2006-3d51-46ea-af49-f40fe7605441"),
                columns: new[] { "Amount", "TicketId" },
                values: new object[] { 100, new Guid("9ea79a4c-d3d2-4fdf-b9c4-9f4b71e6f011") });

            migrationBuilder.UpdateData(
                table: "Invoice",
                keyColumn: "Id",
                keyValue: new Guid("363c2006-3d51-46ea-af49-f40fe7605442"),
                columns: new[] { "Amount", "TicketId" },
                values: new object[] { 100, new Guid("9ea79a4c-d3d2-4fdf-b9c4-9f4b71e6f012") });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "Id",
                keyValue: new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82261"),
                column: "CreatedOnUtc",
                value: new DateTime(2024, 5, 18, 13, 39, 1, 364, DateTimeKind.Utc).AddTicks(7790));

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "Id",
                keyValue: new Guid("bbd5c0d3-a45d-490a-b26d-d503b6a82262"),
                column: "CreatedOnUtc",
                value: new DateTime(2024, 5, 18, 13, 39, 1, 364, DateTimeKind.Utc).AddTicks(8656));

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: new Guid("9ea79a4c-d3d2-4fdf-b9c4-9f4b71e6f011"),
                columns: new[] { "HallId", "UserId" },
                values: new object[] { new Guid("d67b95a0-b12e-4574-b9ec-634b11f8df41"), new Guid("88d6040a-130f-43d4-8bee-1f0074962182") });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: new Guid("9ea79a4c-d3d2-4fdf-b9c4-9f4b71e6f012"),
                columns: new[] { "HallId", "UserId" },
                values: new object[] { new Guid("d67b95a0-b12e-4574-b9ec-634b11f8df42"), new Guid("88d6040a-130f-43d4-8bee-1f0074962182") });

            migrationBuilder.CreateIndex(
                name: "IX_Invoice_TicketId",
                table: "Invoice",
                column: "TicketId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "TicketInvoiceFK",
                table: "Invoice",
                column: "TicketId",
                principalTable: "Ticket",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "TicketHallFK",
                table: "Ticket",
                column: "HallId",
                principalTable: "Hall",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "TicketUserFK",
                table: "Ticket",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
