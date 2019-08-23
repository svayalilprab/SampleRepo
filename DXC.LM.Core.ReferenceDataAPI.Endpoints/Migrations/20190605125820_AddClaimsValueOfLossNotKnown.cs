using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DXC.LM.Core.ReferenceDataAPI.Endpoints.Migrations
{
    public partial class AddClaimsValueOfLossNotKnown : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ClaimsValueOfLossNK",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Key = table.Column<string>(maxLength: 1, nullable: false),
                    Value = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClaimsValueOfLossNK", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "ClaimsValueOfLossNK",
                columns: new[] { "ID", "Key", "Value" },
                values: new object[,]
                {
                    { 1, "C", "Closed" },
                    { 2, "F", "Only Fees" },
                    { 3, "L", "Part of Block Claim" },
                    { 4, "N", "Nil Value Claim" },
                    { 5, "P", "Precautionary" },
                    { 6, "R", "Recovery Expected" },
                    { 7, "S", "Subrogation" },
                    { 8, "T", "To be Advised" },
                    { 9, "V", "Salvage expected" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClaimsValueOfLossNK");
        }
    }
}
