using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DatabaseHandler.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Department",
                columns: table => new
                {
                    DeptId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DeptName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Department", x => x.DeptId);
                });

            migrationBuilder.CreateTable(
                name: "Level",
                columns: table => new
                {
                    lvl = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Level", x => x.lvl);
                });

            migrationBuilder.CreateTable(
                name: "Term",
                columns: table => new
                {
                    trm = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Term", x => x.trm);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UUId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Numberofconnections = table.Column<int>(name: "Number_of_connections", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UUId);
                });

            migrationBuilder.CreateTable(
                name: "Officials",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IndividualUUId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Officials", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Officials_Users_IndividualUUId",
                        column: x => x.IndividualUUId,
                        principalTable: "Users",
                        principalColumn: "UUId");
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeptId = table.Column<int>(type: "int", nullable: true),
                    lvl = table.Column<int>(type: "int", nullable: true),
                    trm = table.Column<int>(type: "int", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IndividualUUId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Students_Department_DeptId",
                        column: x => x.DeptId,
                        principalTable: "Department",
                        principalColumn: "DeptId");
                    table.ForeignKey(
                        name: "FK_Students_Level_lvl",
                        column: x => x.lvl,
                        principalTable: "Level",
                        principalColumn: "lvl");
                    table.ForeignKey(
                        name: "FK_Students_Term_trm",
                        column: x => x.trm,
                        principalTable: "Term",
                        principalColumn: "trm");
                    table.ForeignKey(
                        name: "FK_Students_Users_IndividualUUId",
                        column: x => x.IndividualUUId,
                        principalTable: "Users",
                        principalColumn: "UUId");
                });

            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeptId = table.Column<int>(type: "int", nullable: true),
                    Designation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IndividualUUId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Teachers_Department_DeptId",
                        column: x => x.DeptId,
                        principalTable: "Department",
                        principalColumn: "DeptId");
                    table.ForeignKey(
                        name: "FK_Teachers_Users_IndividualUUId",
                        column: x => x.IndividualUUId,
                        principalTable: "Users",
                        principalColumn: "UUId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Officials_IndividualUUId",
                table: "Officials",
                column: "IndividualUUId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_DeptId",
                table: "Students",
                column: "DeptId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_IndividualUUId",
                table: "Students",
                column: "IndividualUUId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_lvl",
                table: "Students",
                column: "lvl");

            migrationBuilder.CreateIndex(
                name: "IX_Students_trm",
                table: "Students",
                column: "trm");

            migrationBuilder.CreateIndex(
                name: "IX_Teachers_DeptId",
                table: "Teachers",
                column: "DeptId");

            migrationBuilder.CreateIndex(
                name: "IX_Teachers_IndividualUUId",
                table: "Teachers",
                column: "IndividualUUId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Officials");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Teachers");

            migrationBuilder.DropTable(
                name: "Level");

            migrationBuilder.DropTable(
                name: "Term");

            migrationBuilder.DropTable(
                name: "Department");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
