using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Team3_LMS_WebApi.Migrations
{
    public partial class initEmp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employee_T",
                columns: table => new
                {
                    Emp_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Emp_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Emp_Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Emp_Mobile = table.Column<long>(type: "bigint", nullable: false),
                    Emp_Dept = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Available_Leave = table.Column<long>(type: "bigint", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    image = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee_T", x => x.Emp_Id);
                });

            migrationBuilder.CreateTable(
                name: "Manager_T",
                columns: table => new
                {
                    Mng_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    Mng_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mng_Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mng_Mobile = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Manager_T", x => x.Mng_Id);
                });

            migrationBuilder.CreateTable(
                name: "ApplyLeave_T",
                columns: table => new
                {
                    LeaveId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NoOfDays = table.Column<int>(type: "int", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LeaveType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LeaveStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LeaveReason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AppliedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Mng_Comments = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Emp_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplyLeave_T", x => x.LeaveId);
                    table.ForeignKey(
                        name: "FK_ApplyLeave_T_Employee_T_Emp_Id",
                        column: x => x.Emp_Id,
                        principalTable: "Employee_T",
                        principalColumn: "Emp_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ApplyLeave_T_Emp_Id",
                table: "ApplyLeave_T",
                column: "Emp_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ApplyLeave_T");

            migrationBuilder.DropTable(
                name: "Manager_T");

            migrationBuilder.DropTable(
                name: "Employee_T");
        }
    }
}
