using Microsoft.EntityFrameworkCore.Migrations;

namespace ExamWeb_NguyenChauTanPhat.Migrations
{
    public partial class InitSchema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Phims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TuaDe = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    GiaVe = table.Column<double>(type: "float", nullable: false),
                    ThoiLuong = table.Column<int>(type: "int", nullable: false),
                    TrongNuoc = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Phims", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Phims",
                columns: new[] { "Id", "GiaVe", "ThoiLuong", "TrongNuoc", "TuaDe" },
                values: new object[,]
                {
                    { 1, 12000.0, 10, true, "Tro tàn rực rỡ" },
                    { 2, 12000.0, 15, false, "MAI" },
                    { 3, 12000.0, 10, true, "Lật mặt" },
                    { 4, 12000.0, 15, false, "Mắt biếc" },
                    { 5, 12000.0, 10, true, "Nhắm mắt thấy mùa hè" },
                    { 6, 12000.0, 15, true, "Hùng long phong bá" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Phims");
        }
    }
}
