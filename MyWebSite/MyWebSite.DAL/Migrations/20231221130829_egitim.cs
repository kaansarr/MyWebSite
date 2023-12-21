using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyWebSite.DAL.Migrations
{
    /// <inheritdoc />
    public partial class egitim : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Egitimlerim",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Okul = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Fakulte = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Bolum = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Tarih = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Egitimlerim", x => x.ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Egitimlerim");
        }
    }
}
