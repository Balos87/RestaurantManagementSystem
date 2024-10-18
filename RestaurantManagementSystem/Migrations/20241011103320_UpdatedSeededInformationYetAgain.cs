using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RestaurantManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedSeededInformationYetAgain : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Tables",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Tables",
                columns: new[] { "TableId", "Description", "Seats", "TableNumber" },
                values: new object[,]
                {
                    { 1, "A corner table by the large bay window, offering a stunning view of the city skyline. The soft glow of candlelight enhances the cozy yet sophisticated ambiance.", 4, 1 },
                    { 2, "Intimate and secluded, this table is tucked away near a bookshelf wall adorned with vintage books. Perfect for a private dinner with soft, warm lighting.", 2, 2 },
                    { 3, "A spacious table set beneath an elegant chandelier, surrounded by velvet curtains. Ideal for group gatherings, with a luxurious feel and a commanding view of the restaurant’s centerpiece fountain.", 6, 3 },
                    { 4, "Nestled in a cozy alcove near the wine cellar, this table offers a secluded, intimate dining experience with a rich, aromatic ambiance and a view of the sommelier at work.", 4, 4 },
                    { 5, "A window-side table with a direct view of the streetlights and evening passersby. Enveloped in soft leather chairs, it's perfect for a romantic dinner with a touch of urban charm.", 2, 5 },
                    { 6, "Positioned at the heart of the restaurant, this grand table is ideal for celebrations. Surrounded by low-hanging pendant lights and lush greenery, it brings a touch of nature into the luxurious setting.", 8, 6 },
                    { 7, "Located near the crackling fireplace, this table exudes warmth and coziness. The perfect setting for a family dinner, with the added comfort of soft armchairs and ambient lighting.", 4, 7 },
                    { 8, "Situated on the elevated dining platform, offering a bird’s eye view of the entire restaurant. The dim lighting and plush seating make it ideal for larger groups seeking an exclusive experience.", 6, 8 },
                    { 9, "A small, intimate table placed near the piano, where live music fills the air. With velvet upholstery and low lighting, it’s an unforgettable experience for music lovers.", 2, 9 },
                    { 10, "This table offers a view of the chef’s open kitchen, allowing diners to watch the artistry unfold. Luxurious yet vibrant, it’s perfect for those who enjoy the theater of fine dining.", 4, 10 }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "PasswordHash",
                value: "$2a$11$WPSTi5rsoQ4bygvCSGHIze9bztgI4QCvVfc7W.V7KgKu7gFmopQB6");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "PasswordHash",
                value: "$2a$11$4BxFB2IcLGWKxgBnVfWCtOG7OfxZ1DjCrbpOk98b.SSct39Vlg6.K");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                column: "PasswordHash",
                value: "$2a$11$4BxFB2IcLGWKxgBnVfWCtOG7OfxZ1DjCrbpOk98b.SSct39Vlg6.K");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4,
                column: "PasswordHash",
                value: "$2a$11$4BxFB2IcLGWKxgBnVfWCtOG7OfxZ1DjCrbpOk98b.SSct39Vlg6.K");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 5,
                column: "PasswordHash",
                value: "$2a$11$2I7hyxNZOEYpbnS89PZDNucKd5C5HZparOjN41Dt0/6LB1G/BkMZO");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 6,
                column: "PasswordHash",
                value: "$2a$11$2I7hyxNZOEYpbnS89PZDNucKd5C5HZparOjN41Dt0/6LB1G/BkMZO");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 7,
                column: "PasswordHash",
                value: "$2a$11$2I7hyxNZOEYpbnS89PZDNucKd5C5HZparOjN41Dt0/6LB1G/BkMZO");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 8,
                column: "PasswordHash",
                value: "$2a$11$2I7hyxNZOEYpbnS89PZDNucKd5C5HZparOjN41Dt0/6LB1G/BkMZO");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 9,
                column: "PasswordHash",
                value: "$2a$11$2I7hyxNZOEYpbnS89PZDNucKd5C5HZparOjN41Dt0/6LB1G/BkMZO");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 10,
                column: "PasswordHash",
                value: "$2a$11$2I7hyxNZOEYpbnS89PZDNucKd5C5HZparOjN41Dt0/6LB1G/BkMZO");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 11,
                column: "PasswordHash",
                value: "$2a$11$2I7hyxNZOEYpbnS89PZDNucKd5C5HZparOjN41Dt0/6LB1G/BkMZO");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 12,
                column: "PasswordHash",
                value: "$2a$11$2I7hyxNZOEYpbnS89PZDNucKd5C5HZparOjN41Dt0/6LB1G/BkMZO");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 13,
                column: "PasswordHash",
                value: "$2a$11$2I7hyxNZOEYpbnS89PZDNucKd5C5HZparOjN41Dt0/6LB1G/BkMZO");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 14,
                column: "PasswordHash",
                value: "$2a$11$2I7hyxNZOEYpbnS89PZDNucKd5C5HZparOjN41Dt0/6LB1G/BkMZO");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 10);

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Tables");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "PasswordHash",
                value: "$2a$11$GkW1jF6KSrLUeKIF/sytL.2gIWJpacA9pCIykxDnFpuOgJoydTTqq");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "PasswordHash",
                value: "$2a$11$OCvMsk93wRYZFDYXwvoxjeCZm6k3LcbwfPkcT6SMn5VOAcQf3mVD.");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                column: "PasswordHash",
                value: "$2a$11$OCvMsk93wRYZFDYXwvoxjeCZm6k3LcbwfPkcT6SMn5VOAcQf3mVD.");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4,
                column: "PasswordHash",
                value: "$2a$11$OCvMsk93wRYZFDYXwvoxjeCZm6k3LcbwfPkcT6SMn5VOAcQf3mVD.");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 5,
                column: "PasswordHash",
                value: "$2a$11$YGxmmgcNbNLUWSCxKLvpH.qyH/bRlzSb7er8/GCWzwqM7JW/hkblq");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 6,
                column: "PasswordHash",
                value: "$2a$11$YGxmmgcNbNLUWSCxKLvpH.qyH/bRlzSb7er8/GCWzwqM7JW/hkblq");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 7,
                column: "PasswordHash",
                value: "$2a$11$YGxmmgcNbNLUWSCxKLvpH.qyH/bRlzSb7er8/GCWzwqM7JW/hkblq");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 8,
                column: "PasswordHash",
                value: "$2a$11$YGxmmgcNbNLUWSCxKLvpH.qyH/bRlzSb7er8/GCWzwqM7JW/hkblq");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 9,
                column: "PasswordHash",
                value: "$2a$11$YGxmmgcNbNLUWSCxKLvpH.qyH/bRlzSb7er8/GCWzwqM7JW/hkblq");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 10,
                column: "PasswordHash",
                value: "$2a$11$YGxmmgcNbNLUWSCxKLvpH.qyH/bRlzSb7er8/GCWzwqM7JW/hkblq");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 11,
                column: "PasswordHash",
                value: "$2a$11$YGxmmgcNbNLUWSCxKLvpH.qyH/bRlzSb7er8/GCWzwqM7JW/hkblq");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 12,
                column: "PasswordHash",
                value: "$2a$11$YGxmmgcNbNLUWSCxKLvpH.qyH/bRlzSb7er8/GCWzwqM7JW/hkblq");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 13,
                column: "PasswordHash",
                value: "$2a$11$YGxmmgcNbNLUWSCxKLvpH.qyH/bRlzSb7er8/GCWzwqM7JW/hkblq");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 14,
                column: "PasswordHash",
                value: "$2a$11$YGxmmgcNbNLUWSCxKLvpH.qyH/bRlzSb7er8/GCWzwqM7JW/hkblq");
        }
    }
}
