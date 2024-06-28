using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace taxi_app_api.Migrations
{
    /// <inheritdoc />
    public partial class InitialData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LicensePlate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumberOfPerson = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CarOwners",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    LicenseId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CarId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarOwners", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CarOwners_Cars_CarId",
                        column: x => x.CarId,
                        principalTable: "Cars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OwnerId = table.Column<int>(type: "int", nullable: true),
                    DestinationAdress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OriginAdress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsEnded = table.Column<bool>(type: "bit", nullable: false),
                    IsStarted = table.Column<bool>(type: "bit", nullable: false),
                    StartedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndedTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Courses_CarOwners_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "CarOwners",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "Color", "IsActive", "LicensePlate", "NumberOfPerson", "TypeName" },
                values: new object[] { 1, "Black", true, "QQQ 321", 4, "Toyota" });

            migrationBuilder.InsertData(
                table: "CarOwners",
                columns: new[] { "Id", "Address", "CarId", "DateOfBirth", "Email", "FirstName", "IsActive", "LastName", "LicenseId", "PhoneNumber" },
                values: new object[] { 1, "3930 Masson", 1, new DateTime(1994, 6, 27, 22, 27, 47, 362, DateTimeKind.Local).AddTicks(1914), "johndoe@gmail.com", "John", true, "Doe", "1234567890", "1234567890" });

            migrationBuilder.CreateIndex(
                name: "IX_CarOwners_CarId",
                table: "CarOwners",
                column: "CarId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Courses_OwnerId",
                table: "Courses",
                column: "OwnerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "CarOwners");

            migrationBuilder.DropTable(
                name: "Cars");
        }
    }
}
