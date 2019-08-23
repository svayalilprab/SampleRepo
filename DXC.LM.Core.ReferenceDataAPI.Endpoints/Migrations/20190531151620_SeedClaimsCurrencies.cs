using Microsoft.EntityFrameworkCore.Migrations;

namespace DXC.LM.Core.ReferenceDataAPI.Endpoints.Migrations
{
    public partial class SeedClaimsCurrencies : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ClaimsCurrencies",
                columns: new[] { "ID", "Code", "Currency" },
                values: new object[,]
                {
                    { 1, "USD", "US Dollar" },
                    { 2, "SGD", "Singapore Dollar" },
                    { 3, "AUD", "Australian Dollar" },
                    { 4, "GBP", "Pound Sterling" },
                    { 5, "EUR", "Euro" },
                    { 6, "HKD", "Hong Kong Dollar" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ClaimsCurrencies",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ClaimsCurrencies",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ClaimsCurrencies",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ClaimsCurrencies",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ClaimsCurrencies",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ClaimsCurrencies",
                keyColumn: "ID",
                keyValue: 6);
        }
    }
}
