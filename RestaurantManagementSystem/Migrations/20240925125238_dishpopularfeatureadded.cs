using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestaurantManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class dishpopularfeatureadded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Popular",
                table: "Dishes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "PasswordHash",
                value: "$2a$11$pkpCixm5U5X00JF1YRkJlOkhmMkXe4o0oqTwtmXWt7t0KZTMw2Cam");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "PasswordHash",
                value: "$2a$11$nVDHrs7Kgd6qLW.s0FmcQ.9UVXOEDWF7u0sxYTW.JsBl3CCpvGT6C");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                column: "PasswordHash",
                value: "$2a$11$W7pi8rvQlhPMM5RiwdPk5usb8ZZwK9TWJrNrIBV6XeLfDBDQ2eTUK");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Popular",
                table: "Dishes");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "PasswordHash",
                value: "$2a$11$sV2AkgbNdfJWeNbwz1Pd5uWl3j74Qq/9dObSRBkUHuHmNGbdt.4Q.");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "PasswordHash",
                value: "$2a$11$UHjhOQXZwdpJD69VowOh8.tXpRUe2mUoO9h6onhvbK5FoAC6G2fa6");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                column: "PasswordHash",
                value: "$2a$11$nlaXxHG3pzo/HWZC7k9LAOR97Ja/6g9xRYDqKFyijAcr.UTwB/GPy");
        }
    }
}
