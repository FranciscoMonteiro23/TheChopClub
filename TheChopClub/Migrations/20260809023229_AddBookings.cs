using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TheChopClub.Migrations
{
    /// <inheritdoc />
    public partial class AddBookings : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Barbershops",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 9, 2, 32, 28, 316, DateTimeKind.Utc).AddTicks(9512));

            migrationBuilder.UpdateData(
                table: "Barbershops",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 9, 2, 32, 28, 316, DateTimeKind.Utc).AddTicks(9512));

            migrationBuilder.UpdateData(
                table: "Barbershops",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 5, 9, 2, 32, 28, 316, DateTimeKind.Utc).AddTicks(9512));

            migrationBuilder.UpdateData(
                table: "Barbershops",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 6, 9, 2, 32, 28, 316, DateTimeKind.Utc).AddTicks(9512));

            migrationBuilder.UpdateData(
                table: "Barbershops",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2026, 7, 9, 2, 32, 28, 316, DateTimeKind.Utc).AddTicks(9512));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 8, 8, 16, 32, 28, 316, DateTimeKind.Utc).AddTicks(9512));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 8, 8, 18, 32, 28, 316, DateTimeKind.Utc).AddTicks(9512));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 8, 8, 21, 32, 28, 316, DateTimeKind.Utc).AddTicks(9512));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 8, 8, 11, 32, 28, 316, DateTimeKind.Utc).AddTicks(9512));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2026, 8, 8, 14, 32, 28, 316, DateTimeKind.Utc).AddTicks(9512));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2026, 8, 8, 20, 32, 28, 316, DateTimeKind.Utc).AddTicks(9512));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2026, 8, 8, 22, 32, 28, 316, DateTimeKind.Utc).AddTicks(9512));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2026, 8, 8, 23, 32, 28, 316, DateTimeKind.Utc).AddTicks(9512));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2026, 8, 8, 6, 32, 28, 316, DateTimeKind.Utc).AddTicks(9512));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2026, 8, 8, 8, 32, 28, 316, DateTimeKind.Utc).AddTicks(9512));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2026, 8, 9, 0, 32, 28, 316, DateTimeKind.Utc).AddTicks(9512));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2026, 8, 9, 1, 32, 28, 316, DateTimeKind.Utc).AddTicks(9512));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 8, 8, 2, 32, 28, 316, DateTimeKind.Utc).AddTicks(9512));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 8, 6, 2, 32, 28, 316, DateTimeKind.Utc).AddTicks(9512));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 8, 4, 2, 32, 28, 316, DateTimeKind.Utc).AddTicks(9512));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 8, 7, 2, 32, 28, 316, DateTimeKind.Utc).AddTicks(9512));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2026, 8, 5, 2, 32, 28, 316, DateTimeKind.Utc).AddTicks(9512));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2026, 8, 8, 2, 32, 28, 316, DateTimeKind.Utc).AddTicks(9512));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2026, 8, 3, 2, 32, 28, 316, DateTimeKind.Utc).AddTicks(9512));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2026, 8, 8, 14, 32, 28, 316, DateTimeKind.Utc).AddTicks(9512));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2026, 8, 2, 2, 32, 28, 316, DateTimeKind.Utc).AddTicks(9512));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2026, 8, 7, 2, 32, 28, 316, DateTimeKind.Utc).AddTicks(9512));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2026, 8, 1, 2, 32, 28, 316, DateTimeKind.Utc).AddTicks(9512));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2026, 8, 6, 2, 32, 28, 316, DateTimeKind.Utc).AddTicks(9512));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2026, 8, 8, 20, 32, 28, 316, DateTimeKind.Utc).AddTicks(9512));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2026, 8, 8, 8, 32, 28, 316, DateTimeKind.Utc).AddTicks(9512));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2026, 8, 5, 2, 32, 28, 316, DateTimeKind.Utc).AddTicks(9512));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 6, 9, 2, 32, 28, 316, DateTimeKind.Utc).AddTicks(9512));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 6, 9, 2, 32, 28, 316, DateTimeKind.Utc).AddTicks(9512));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 7, 9, 2, 32, 28, 316, DateTimeKind.Utc).AddTicks(9512));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 7, 9, 2, 32, 28, 316, DateTimeKind.Utc).AddTicks(9512));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2026, 6, 25, 2, 32, 28, 316, DateTimeKind.Utc).AddTicks(9512));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 7, 30, 2, 32, 28, 316, DateTimeKind.Utc).AddTicks(9512));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 7, 25, 2, 32, 28, 316, DateTimeKind.Utc).AddTicks(9512));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 7, 20, 2, 32, 28, 316, DateTimeKind.Utc).AddTicks(9512));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 7, 28, 2, 32, 28, 316, DateTimeKind.Utc).AddTicks(9512));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2026, 7, 22, 2, 32, 28, 316, DateTimeKind.Utc).AddTicks(9512));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2026, 8, 1, 2, 32, 28, 316, DateTimeKind.Utc).AddTicks(9512));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2026, 7, 26, 2, 32, 28, 316, DateTimeKind.Utc).AddTicks(9512));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2026, 8, 3, 2, 32, 28, 316, DateTimeKind.Utc).AddTicks(9512));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2026, 7, 24, 2, 32, 28, 316, DateTimeKind.Utc).AddTicks(9512));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2026, 8, 4, 2, 32, 28, 316, DateTimeKind.Utc).AddTicks(9512));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2026, 7, 29, 2, 32, 28, 316, DateTimeKind.Utc).AddTicks(9512));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2026, 2, 9, 2, 32, 28, 316, DateTimeKind.Utc).AddTicks(9512), "$2a$11$N.KlbhLVtQ0ULT22Dw9pjOHcJb3hFQQIRdW.rA254538HUzYoVks2" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2026, 3, 9, 2, 32, 28, 316, DateTimeKind.Utc).AddTicks(9512), "$2a$11$s.gCpqF4nN1.XXK.9eIEqOferET0SLVcYvBcGT2yip7RXG3E6R9H." });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2026, 4, 9, 2, 32, 28, 316, DateTimeKind.Utc).AddTicks(9512), "$2a$11$OE4ncSNG4xEZ3Ry4/65xTOQSg8vdKnxzGTFr0hC..ygciSOZC7gve" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2026, 5, 9, 2, 32, 28, 316, DateTimeKind.Utc).AddTicks(9512), "$2a$11$kKWWgPB777j6fpJLLBUV1OErn6GHr5qGV464xd/06jDWYoaIZNuH2" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2026, 6, 9, 2, 32, 28, 316, DateTimeKind.Utc).AddTicks(9512), "$2a$11$7oK.M96ptP.G6Sp4/vGSc.4YDk6fd1zQBoBEQrOTP2lZUw8gE.1ea" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2026, 7, 9, 2, 32, 28, 316, DateTimeKind.Utc).AddTicks(9512), "$2a$11$EvKAMiE/VnKOUGri7bUEmOOVK8ZOjpY.Tk1b1LSlQ0vSUXWeGeKc6" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2026, 6, 9, 2, 32, 28, 316, DateTimeKind.Utc).AddTicks(9512), "$2a$11$a/jrDM6IGsZR3cnJlr1uP.y1m6FsTeB5S7pslgTt16gNFGrd2svaW" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2026, 7, 9, 2, 32, 28, 316, DateTimeKind.Utc).AddTicks(9512), "$2a$11$cMlDv2WuwlVCriC2UBV0L.kI8IvLhTmo/4Ph4KWM1l6fRItIBQpl6" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Barbershops",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 9, 2, 24, 44, 85, DateTimeKind.Utc).AddTicks(6633));

            migrationBuilder.UpdateData(
                table: "Barbershops",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 9, 2, 24, 44, 85, DateTimeKind.Utc).AddTicks(6633));

            migrationBuilder.UpdateData(
                table: "Barbershops",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 5, 9, 2, 24, 44, 85, DateTimeKind.Utc).AddTicks(6633));

            migrationBuilder.UpdateData(
                table: "Barbershops",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 6, 9, 2, 24, 44, 85, DateTimeKind.Utc).AddTicks(6633));

            migrationBuilder.UpdateData(
                table: "Barbershops",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2026, 7, 9, 2, 24, 44, 85, DateTimeKind.Utc).AddTicks(6633));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 8, 8, 16, 24, 44, 85, DateTimeKind.Utc).AddTicks(6633));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 8, 8, 18, 24, 44, 85, DateTimeKind.Utc).AddTicks(6633));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 8, 8, 21, 24, 44, 85, DateTimeKind.Utc).AddTicks(6633));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 8, 8, 11, 24, 44, 85, DateTimeKind.Utc).AddTicks(6633));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2026, 8, 8, 14, 24, 44, 85, DateTimeKind.Utc).AddTicks(6633));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2026, 8, 8, 20, 24, 44, 85, DateTimeKind.Utc).AddTicks(6633));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2026, 8, 8, 22, 24, 44, 85, DateTimeKind.Utc).AddTicks(6633));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2026, 8, 8, 23, 24, 44, 85, DateTimeKind.Utc).AddTicks(6633));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2026, 8, 8, 6, 24, 44, 85, DateTimeKind.Utc).AddTicks(6633));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2026, 8, 8, 8, 24, 44, 85, DateTimeKind.Utc).AddTicks(6633));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2026, 8, 9, 0, 24, 44, 85, DateTimeKind.Utc).AddTicks(6633));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2026, 8, 9, 1, 24, 44, 85, DateTimeKind.Utc).AddTicks(6633));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 8, 8, 2, 24, 44, 85, DateTimeKind.Utc).AddTicks(6633));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 8, 6, 2, 24, 44, 85, DateTimeKind.Utc).AddTicks(6633));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 8, 4, 2, 24, 44, 85, DateTimeKind.Utc).AddTicks(6633));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 8, 7, 2, 24, 44, 85, DateTimeKind.Utc).AddTicks(6633));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2026, 8, 5, 2, 24, 44, 85, DateTimeKind.Utc).AddTicks(6633));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2026, 8, 8, 2, 24, 44, 85, DateTimeKind.Utc).AddTicks(6633));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2026, 8, 3, 2, 24, 44, 85, DateTimeKind.Utc).AddTicks(6633));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2026, 8, 8, 14, 24, 44, 85, DateTimeKind.Utc).AddTicks(6633));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2026, 8, 2, 2, 24, 44, 85, DateTimeKind.Utc).AddTicks(6633));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2026, 8, 7, 2, 24, 44, 85, DateTimeKind.Utc).AddTicks(6633));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2026, 8, 1, 2, 24, 44, 85, DateTimeKind.Utc).AddTicks(6633));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2026, 8, 6, 2, 24, 44, 85, DateTimeKind.Utc).AddTicks(6633));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2026, 8, 8, 20, 24, 44, 85, DateTimeKind.Utc).AddTicks(6633));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2026, 8, 8, 8, 24, 44, 85, DateTimeKind.Utc).AddTicks(6633));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2026, 8, 5, 2, 24, 44, 85, DateTimeKind.Utc).AddTicks(6633));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 6, 9, 2, 24, 44, 85, DateTimeKind.Utc).AddTicks(6633));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 6, 9, 2, 24, 44, 85, DateTimeKind.Utc).AddTicks(6633));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 7, 9, 2, 24, 44, 85, DateTimeKind.Utc).AddTicks(6633));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 7, 9, 2, 24, 44, 85, DateTimeKind.Utc).AddTicks(6633));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2026, 6, 25, 2, 24, 44, 85, DateTimeKind.Utc).AddTicks(6633));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 7, 30, 2, 24, 44, 85, DateTimeKind.Utc).AddTicks(6633));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 7, 25, 2, 24, 44, 85, DateTimeKind.Utc).AddTicks(6633));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 7, 20, 2, 24, 44, 85, DateTimeKind.Utc).AddTicks(6633));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 7, 28, 2, 24, 44, 85, DateTimeKind.Utc).AddTicks(6633));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2026, 7, 22, 2, 24, 44, 85, DateTimeKind.Utc).AddTicks(6633));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2026, 8, 1, 2, 24, 44, 85, DateTimeKind.Utc).AddTicks(6633));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2026, 7, 26, 2, 24, 44, 85, DateTimeKind.Utc).AddTicks(6633));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2026, 8, 3, 2, 24, 44, 85, DateTimeKind.Utc).AddTicks(6633));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2026, 7, 24, 2, 24, 44, 85, DateTimeKind.Utc).AddTicks(6633));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2026, 8, 4, 2, 24, 44, 85, DateTimeKind.Utc).AddTicks(6633));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2026, 7, 29, 2, 24, 44, 85, DateTimeKind.Utc).AddTicks(6633));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2026, 2, 9, 2, 24, 44, 85, DateTimeKind.Utc).AddTicks(6633), "$2a$11$2YYe.Z7OjKOmwq21vGi78uP8J/gG3wmPZG0roYaEz5GC3A93ybmAS" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2026, 3, 9, 2, 24, 44, 85, DateTimeKind.Utc).AddTicks(6633), "$2a$11$sAb41ZJiJJ6kPgZu02y5auBgSKHg/hKKWyAeIrEw5tVaqQRSc7Olu" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2026, 4, 9, 2, 24, 44, 85, DateTimeKind.Utc).AddTicks(6633), "$2a$11$gP1GyT.EdhtlLPfT1ah/i..Hvx19YfqhZcwxdp1K8gJicOqgt9OZ2" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2026, 5, 9, 2, 24, 44, 85, DateTimeKind.Utc).AddTicks(6633), "$2a$11$O8/icr2KqHpZreuGw6MOxecXoSl5VI2aaeOsoFfzE.mtPxz67TM/a" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2026, 6, 9, 2, 24, 44, 85, DateTimeKind.Utc).AddTicks(6633), "$2a$11$DU60Sx5QmDmqKqUkMm5eve6QE4sSnrhT15AGA.aonXF5sN.DaDFVS" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2026, 7, 9, 2, 24, 44, 85, DateTimeKind.Utc).AddTicks(6633), "$2a$11$TIAV/S9ThCf33BbATqcTR.e4KFWgLoE5S3ZXCxECoED/ohi.MFvW2" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2026, 6, 9, 2, 24, 44, 85, DateTimeKind.Utc).AddTicks(6633), "$2a$11$ZZDnlCFu7n.Ee5ePsSQ7SOxwGnLG7YcXxjKhngvkO2jfl8V15PK2y" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2026, 7, 9, 2, 24, 44, 85, DateTimeKind.Utc).AddTicks(6633), "$2a$11$bZeSUrG6TMzkacFIWs8s.OJwiL3e0iOi.fdGo4oz/6bBxhEt79kBa" });
        }
    }
}
