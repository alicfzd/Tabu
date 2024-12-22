using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Tabu.Migrations
{
    /// <inheritdoc />
    public partial class JustMig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Word",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LanguageCode = table.Column<string>(type: "nvarchar(2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Word", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Word_Languages_LanguageCode",
                        column: x => x.LanguageCode,
                        principalTable: "Languages",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BannedWord",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WordId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BannedWord", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BannedWord_Word_WordId",
                        column: x => x.WordId,
                        principalTable: "Word",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "Code", "Icon", "Name" },
                values: new object[,]
                {
                    { "az", "https://cdn-icons-png.flaticon.com/512/330/330544.png", "Azərbaycan" },
                    { "en", "https://cdn3.iconfinder.com/data/icons/flag-world/512/flags-06-512.png", "English" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Languages_Name",
                table: "Languages",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BannedWord_WordId",
                table: "BannedWord",
                column: "WordId");

            migrationBuilder.CreateIndex(
                name: "IX_Word_LanguageCode",
                table: "Word",
                column: "LanguageCode");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BannedWord");

            migrationBuilder.DropTable(
                name: "Word");

            migrationBuilder.DropIndex(
                name: "IX_Languages_Name",
                table: "Languages");

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Code",
                keyValue: "az");

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Code",
                keyValue: "en");
        }
    }
}
