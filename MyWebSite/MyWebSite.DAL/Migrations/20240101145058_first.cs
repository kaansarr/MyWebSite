using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyWebSite.DAL.Migrations
{
    /// <inheritdoc />
    public partial class first : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admin",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false),
                    Surname = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false),
                    Username = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false),
                    Password = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admin", x => x.ID);
                });

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

            migrationBuilder.CreateTable(
                name: "Hakkimda",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Baslik = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Aciklama = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hakkimda", x => x.ID);
                });

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

            migrationBuilder.CreateTable(
                name: "Projelerim",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: true),
                    Picture = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: true),
                    Link = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: true),
                    Link2 = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projelerim", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Yeteneklerim",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Baslik = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yeteneklerim", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "Admin",
                columns: new[] { "ID", "Name", "Password", "Surname", "Username" },
                values: new object[] { 1, "Kaan", "5a30387b10e5dbe5571db7af5a87410e", "Sar", "kaan" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admin");

            migrationBuilder.DropTable(
                name: "Egitimlerim");

            migrationBuilder.DropTable(
                name: "Hakkimda");

            migrationBuilder.DropTable(
                name: "Iletisim");

            migrationBuilder.DropTable(
                name: "Projelerim");

            migrationBuilder.DropTable(
                name: "Yeteneklerim");
        }
    }
}
