using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assignment_03_EFCore.Migrations
{
    /// <inheritdoc />
    public partial class CreateCourseInstructorTableAndRelationShipsBetweenCourseAndCourseInstructorAndInstructorTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentCourse_Courses_Course_Id",
                table: "StudentCourse");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentCourse_Students_Stud_Id",
                table: "StudentCourse");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StudentCourse",
                table: "StudentCourse");

            migrationBuilder.RenameTable(
                name: "StudentCourse",
                newName: "StudentCourses");

            migrationBuilder.RenameIndex(
                name: "IX_StudentCourse_Course_Id",
                table: "StudentCourses",
                newName: "IX_StudentCourses_Course_Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StudentCourses",
                table: "StudentCourses",
                columns: new[] { "Stud_Id", "Course_Id" });

            migrationBuilder.CreateTable(
                name: "CourseInstructors",
                columns: table => new
                {
                    Inst_Id = table.Column<int>(type: "int", nullable: false),
                    Course_Id = table.Column<int>(type: "int", nullable: false),
                    Evaluate = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseInstructors", x => new { x.Inst_Id, x.Course_Id });
                    table.ForeignKey(
                        name: "FK_CourseInstructors_Courses_Course_Id",
                        column: x => x.Course_Id,
                        principalTable: "Courses",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CourseInstructors_Instructors_Inst_Id",
                        column: x => x.Inst_Id,
                        principalTable: "Instructors",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_CourseInstructors_Course_Id",
                table: "CourseInstructors",
                column: "Course_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_StudentCourses_Courses_Course_Id",
                table: "StudentCourses",
                column: "Course_Id",
                principalTable: "Courses",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_StudentCourses_Students_Stud_Id",
                table: "StudentCourses",
                column: "Stud_Id",
                principalTable: "Students",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentCourses_Courses_Course_Id",
                table: "StudentCourses");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentCourses_Students_Stud_Id",
                table: "StudentCourses");

            migrationBuilder.DropTable(
                name: "CourseInstructors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StudentCourses",
                table: "StudentCourses");

            migrationBuilder.RenameTable(
                name: "StudentCourses",
                newName: "StudentCourse");

            migrationBuilder.RenameIndex(
                name: "IX_StudentCourses_Course_Id",
                table: "StudentCourse",
                newName: "IX_StudentCourse_Course_Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StudentCourse",
                table: "StudentCourse",
                columns: new[] { "Stud_Id", "Course_Id" });

            migrationBuilder.AddForeignKey(
                name: "FK_StudentCourse_Courses_Course_Id",
                table: "StudentCourse",
                column: "Course_Id",
                principalTable: "Courses",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_StudentCourse_Students_Stud_Id",
                table: "StudentCourse",
                column: "Stud_Id",
                principalTable: "Students",
                principalColumn: "Id");
        }
    }
}
