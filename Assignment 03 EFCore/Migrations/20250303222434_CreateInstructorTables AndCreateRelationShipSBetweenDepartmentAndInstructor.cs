using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assignment_03_EFCore.Migrations
{
    /// <inheritdoc />
    public partial class CreateInstructorTablesAndCreateRelationShipSBetweenDepartmentAndInstructor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "InsId",
                table: "Departments",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Instructors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Bouns = table.Column<decimal>(type: "decimal(10,4)", nullable: true),
                    Salary = table.Column<decimal>(type: "decimal(10,4)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HourRate = table.Column<double>(type: "float", nullable: true),
                    DepId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instructors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Instructors_Departments_DepId",
                        column: x => x.DepId,
                        principalTable: "Departments",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Departments_InsId",
                table: "Departments",
                column: "InsId");

            migrationBuilder.CreateIndex(
                name: "IX_Instructors_DepId",
                table: "Instructors",
                column: "DepId");

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_Instructors_InsId",
                table: "Departments",
                column: "InsId",
                principalTable: "Instructors",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Departments_Instructors_InsId",
                table: "Departments");

            migrationBuilder.DropTable(
                name: "Instructors");

            migrationBuilder.DropIndex(
                name: "IX_Departments_InsId",
                table: "Departments");

            migrationBuilder.DropColumn(
                name: "InsId",
                table: "Departments");
        }
    }
}
