using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ScrumManager.Migrations
{
    public partial class quad : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Peoples_Events_EventId",
                table: "Peoples");

            migrationBuilder.DropForeignKey(
                name: "FK_Peoples_Events_EventId1",
                table: "Peoples");

            migrationBuilder.DropIndex(
                name: "IX_Peoples_EventId",
                table: "Peoples");

            migrationBuilder.DropIndex(
                name: "IX_Peoples_EventId1",
                table: "Peoples");

            migrationBuilder.DropColumn(
                name: "EventId",
                table: "Peoples");

            migrationBuilder.DropColumn(
                name: "EventId1",
                table: "Peoples");

            migrationBuilder.AddColumn<string>(
                name: "RoleName",
                table: "Events",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RoleName",
                table: "Events");

            migrationBuilder.AddColumn<int>(
                name: "EventId",
                table: "Peoples",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EventId1",
                table: "Peoples",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Peoples_EventId",
                table: "Peoples",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_Peoples_EventId1",
                table: "Peoples",
                column: "EventId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Peoples_Events_EventId",
                table: "Peoples",
                column: "EventId",
                principalTable: "Events",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Peoples_Events_EventId1",
                table: "Peoples",
                column: "EventId1",
                principalTable: "Events",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
