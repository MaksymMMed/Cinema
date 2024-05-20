using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cinema.DAL.Migrations
{
    /// <inheritdoc />
    public partial class AddBasePrice : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "BasePrice",
                table: "Session",
                type: "decimal(8,2)",
                precision: 8,
                scale: 2,
                nullable: false,
                defaultValue: 99.00m);

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "Id",
                keyValue: new Guid("1f8038c6-2e09-4919-8a40-d4715f176be1"),
                column: "BasePrice",
                value: 299.00m);

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "Id",
                keyValue: new Guid("1f8038c6-2e09-4919-8a40-d4715f176be2"),
                column: "BasePrice",
                value: 129.00m);

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "Id",
                keyValue: new Guid("1f8038c6-2e09-4919-8a40-d4715f176be3"),
                column: "BasePrice",
                value: 349.00m);

            migrationBuilder.UpdateData(
                table: "Session",
                keyColumn: "Id",
                keyValue: new Guid("1f8038c6-2e09-4919-8a40-d4715f176be4"),
                column: "BasePrice",
                value: 99.00m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BasePrice",
                table: "Session");
        }
    }
}
