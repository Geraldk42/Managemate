using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Managemate.Migrations
{
    /// <inheritdoc />
    public partial class CreatedRelationshipBetweenUsersAndTasks : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Tasks",
                type: "varchar(255)",
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_CreatedBy",
                table: "Tasks",
                column: "CreatedBy");

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_Users_CreatedBy",
                table: "Tasks",
                column: "CreatedBy",
                principalTable: "Users",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_Users_CreatedBy",
                table: "Tasks");

            migrationBuilder.DropIndex(
                name: "IX_Tasks_CreatedBy",
                table: "Tasks");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Tasks");
        }
    }
}
