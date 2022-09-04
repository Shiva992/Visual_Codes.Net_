using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShivaEmployeeAPI.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Salary = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeId);
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "Email", "Name", "Salary" },
                values: new object[,]
                {
                    { 1, "Shiva@gmail.com", "Shiva", 41000 },
                    { 2, "Krishna@gmail.com", "Krishna", 78000 },
                    { 3, "Anand@gmail.com", "Anand", 98000 },
                    { 4, "Anita@gmail.com", "Anita", 89000 },
                    { 5, "Sharaddh@gmail.com", "Shraddha", 59000 },
                    { 6, "Amisha@gmail.com", "Amisha", 70000 },
                    { 7, "saurabh@gmail.com", "Saurabh", 48000 },
                    { 8, "Tila@gmail.com", "Tilak", 47900 },
                    { 9, "Paru@gmail.com", "Paru", 41007 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
