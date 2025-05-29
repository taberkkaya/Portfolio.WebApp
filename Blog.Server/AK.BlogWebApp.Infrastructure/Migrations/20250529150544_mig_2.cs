using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AK.BlogWebApp.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class mig_2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "LinkedinUrl",
                table: "HeaderAreas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AboutPages",
                keyColumn: "Id",
                keyValue: new Guid("58eb3902-48a5-48e7-b5a8-b43847f0f6bf"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 29, 15, 5, 44, 271, DateTimeKind.Utc).AddTicks(7313));

            migrationBuilder.UpdateData(
                table: "BlogCategories",
                keyColumn: "Id",
                keyValue: new Guid("0b6c5c91-9d48-4e9b-8b5d-fed05be56a73"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 29, 18, 5, 44, 271, DateTimeKind.Local).AddTicks(9385));

            migrationBuilder.UpdateData(
                table: "BlogCategories",
                keyColumn: "Id",
                keyValue: new Guid("58eb3902-48a5-48e7-b5a8-b43847f0f6bf"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 29, 18, 5, 44, 271, DateTimeKind.Local).AddTicks(9372));

            migrationBuilder.UpdateData(
                table: "BlogCategories",
                keyColumn: "Id",
                keyValue: new Guid("6def4f3d-93b9-4c24-97e1-143499f2955f"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 29, 18, 5, 44, 271, DateTimeKind.Local).AddTicks(9387));

            migrationBuilder.UpdateData(
                table: "BlogCategories",
                keyColumn: "Id",
                keyValue: new Guid("d7a19c6c-0d9f-4d10-9207-cfc9c8499a32"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 29, 18, 5, 44, 271, DateTimeKind.Local).AddTicks(9388));

            migrationBuilder.UpdateData(
                table: "DocumentCategories",
                keyColumn: "Id",
                keyValue: new Guid("0b6c5c91-9d48-4e9b-8b5d-fed05be56a73"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 29, 18, 5, 44, 272, DateTimeKind.Local).AddTicks(828));

            migrationBuilder.UpdateData(
                table: "DocumentCategories",
                keyColumn: "Id",
                keyValue: new Guid("58eb3902-48a5-48e7-b5a8-b43847f0f6bf"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 29, 18, 5, 44, 272, DateTimeKind.Local).AddTicks(826));

            migrationBuilder.UpdateData(
                table: "DocumentCategories",
                keyColumn: "Id",
                keyValue: new Guid("6def4f3d-93b9-4c24-97e1-143499f2955f"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 29, 18, 5, 44, 272, DateTimeKind.Local).AddTicks(830));

            migrationBuilder.UpdateData(
                table: "DocumentCategories",
                keyColumn: "Id",
                keyValue: new Guid("d7a19c6c-0d9f-4d10-9207-cfc9c8499a32"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 29, 18, 5, 44, 272, DateTimeKind.Local).AddTicks(832));

            migrationBuilder.UpdateData(
                table: "HeaderAreas",
                keyColumn: "Id",
                keyValue: new Guid("58eb3902-48a5-48e7-b5a8-b43847f0f6bf"),
                column: "LinkedinUrl",
                value: "");

            migrationBuilder.UpdateData(
                table: "HomePages",
                keyColumn: "Id",
                keyValue: new Guid("58eb3902-48a5-48e7-b5a8-b43847f0f6bf"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 29, 18, 5, 44, 272, DateTimeKind.Local).AddTicks(2026));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LinkedinUrl",
                table: "HeaderAreas");

            migrationBuilder.UpdateData(
                table: "AboutPages",
                keyColumn: "Id",
                keyValue: new Guid("58eb3902-48a5-48e7-b5a8-b43847f0f6bf"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 10, 1, 1, 31, 111, DateTimeKind.Utc).AddTicks(6981));

            migrationBuilder.UpdateData(
                table: "BlogCategories",
                keyColumn: "Id",
                keyValue: new Guid("0b6c5c91-9d48-4e9b-8b5d-fed05be56a73"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 10, 4, 1, 31, 111, DateTimeKind.Local).AddTicks(9421));

            migrationBuilder.UpdateData(
                table: "BlogCategories",
                keyColumn: "Id",
                keyValue: new Guid("58eb3902-48a5-48e7-b5a8-b43847f0f6bf"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 10, 4, 1, 31, 111, DateTimeKind.Local).AddTicks(9403));

            migrationBuilder.UpdateData(
                table: "BlogCategories",
                keyColumn: "Id",
                keyValue: new Guid("6def4f3d-93b9-4c24-97e1-143499f2955f"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 10, 4, 1, 31, 111, DateTimeKind.Local).AddTicks(9423));

            migrationBuilder.UpdateData(
                table: "BlogCategories",
                keyColumn: "Id",
                keyValue: new Guid("d7a19c6c-0d9f-4d10-9207-cfc9c8499a32"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 10, 4, 1, 31, 111, DateTimeKind.Local).AddTicks(9425));

            migrationBuilder.UpdateData(
                table: "DocumentCategories",
                keyColumn: "Id",
                keyValue: new Guid("0b6c5c91-9d48-4e9b-8b5d-fed05be56a73"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 10, 4, 1, 31, 112, DateTimeKind.Local).AddTicks(957));

            migrationBuilder.UpdateData(
                table: "DocumentCategories",
                keyColumn: "Id",
                keyValue: new Guid("58eb3902-48a5-48e7-b5a8-b43847f0f6bf"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 10, 4, 1, 31, 112, DateTimeKind.Local).AddTicks(954));

            migrationBuilder.UpdateData(
                table: "DocumentCategories",
                keyColumn: "Id",
                keyValue: new Guid("6def4f3d-93b9-4c24-97e1-143499f2955f"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 10, 4, 1, 31, 112, DateTimeKind.Local).AddTicks(962));

            migrationBuilder.UpdateData(
                table: "DocumentCategories",
                keyColumn: "Id",
                keyValue: new Guid("d7a19c6c-0d9f-4d10-9207-cfc9c8499a32"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 10, 4, 1, 31, 112, DateTimeKind.Local).AddTicks(963));

            migrationBuilder.UpdateData(
                table: "HomePages",
                keyColumn: "Id",
                keyValue: new Guid("58eb3902-48a5-48e7-b5a8-b43847f0f6bf"),
                column: "CreatedDate",
                value: new DateTime(2025, 5, 10, 4, 1, 31, 112, DateTimeKind.Local).AddTicks(2199));
        }
    }
}
