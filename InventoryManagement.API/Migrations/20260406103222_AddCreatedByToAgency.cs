using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InventoryManagement.API.Migrations
{
    /// <inheritdoc />
    public partial class AddCreatedByToAgency : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "CreatedByUserId",
                table: "Agencies",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Agencies_CreatedByUserId",
                table: "Agencies",
                column: "CreatedByUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Agencies_Users_CreatedByUserId",
                table: "Agencies",
                column: "CreatedByUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Agencies_Users_CreatedByUserId",
                table: "Agencies");

            migrationBuilder.DropIndex(
                name: "IX_Agencies_CreatedByUserId",
                table: "Agencies");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                table: "Agencies");
        }
    }
}
