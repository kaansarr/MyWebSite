using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyWebSite.DAL.Migrations
{
    /// <inheritdoc />
    public partial class Iletisim : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Iletisim",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Soyad = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Konu = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    Mesaj = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Iletisim", x => x.ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Iletisim");
        }
    }
}
