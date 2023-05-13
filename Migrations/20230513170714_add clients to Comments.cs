using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FitnessCenter.Migrations
{
    /// <inheritdoc />
    public partial class addclientstoComments : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "ClientsId",
                table: "Comments",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Comments_ClientsId",
                table: "Comments",
                column: "ClientsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Clients_ClientsId",
                table: "Comments",
                column: "ClientsId",
                principalTable: "Clients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Clients_ClientsId",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Comments_ClientsId",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "ClientsId",
                table: "Comments");
        }
    }
}
