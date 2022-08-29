using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShivaStudents.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    DepartmentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.DepartmentID);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Salary = table.Column<int>(type: "int", nullable: false),
                    DepartmentID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeId);
                    table.ForeignKey(
                        name: "FK_Employees_Departments_DepartmentID",
                        column: x => x.DepartmentID,
                        principalTable: "Departments",
                        principalColumn: "DepartmentID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "DepartmentID", "DepartmentName" },
                values: new object[] { 1, "IT Department" });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "DepartmentID", "DepartmentName" },
                values: new object[] { 2, "Account Department" });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "DepartmentID", "DepartmentName" },
                values: new object[] { 3, "Marketing Department" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "DepartmentID", "Email", "Name", "Salary" },
                values: new object[,]
                {
                    { 1, 1, "Shiva@gmail.com", "Shiva", 41000 },
                    { 2, 1, "Krishna@gmail.com", "Krishna", 78000 },
                    { 3, 1, "Anand@gmail.com", "Anand", 98000 },
                    { 4, 2, "Anita@gmail.com", "Anita", 89000 },
                    { 5, 2, "Sharaddh@gmail.com", "Shraddha", 59000 },
                    { 6, 2, "Amisha@gmail.com", "Amisha", 70000 },
                    { 7, 3, "saurabh@gmail.com", "Saurabh", 48000 },
                    { 8, 3, "Tila@gmail.com", "Tilak", 47900 },
                    { 9, 3, "Paru@gmail.com", "Paru", 41007 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_DepartmentID",
                table: "Employees",
                column: "DepartmentID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Departments");
        }
    }
}
