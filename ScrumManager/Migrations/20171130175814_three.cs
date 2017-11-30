using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ScrumManager.Migrations
{
    public partial class three : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Peoples_Events_EventID",
                table: "Peoples");

            migrationBuilder.DropForeignKey(
                name: "FK_Peoples_Events_EventID1",
                table: "Peoples");

            migrationBuilder.RenameColumn(
                name: "EventID1",
                table: "Peoples",
                newName: "EventId1");

            migrationBuilder.RenameColumn(
                name: "EventID",
                table: "Peoples",
                newName: "EventId");

            migrationBuilder.RenameIndex(
                name: "IX_Peoples_EventID1",
                table: "Peoples",
                newName: "IX_Peoples_EventId1");

            migrationBuilder.RenameIndex(
                name: "IX_Peoples_EventID",
                table: "Peoples",
                newName: "IX_Peoples_EventId");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Events",
                newName: "Id");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Peoples_Events_EventId",
                table: "Peoples");

            migrationBuilder.DropForeignKey(
                name: "FK_Peoples_Events_EventId1",
                table: "Peoples");

            migrationBuilder.RenameColumn(
                name: "EventId1",
                table: "Peoples",
                newName: "EventID1");

            migrationBuilder.RenameColumn(
                name: "EventId",
                table: "Peoples",
                newName: "EventID");

            migrationBuilder.RenameIndex(
                name: "IX_Peoples_EventId1",
                table: "Peoples",
                newName: "IX_Peoples_EventID1");

            migrationBuilder.RenameIndex(
                name: "IX_Peoples_EventId",
                table: "Peoples",
                newName: "IX_Peoples_EventID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Events",
                newName: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Peoples_Events_EventID",
                table: "Peoples",
                column: "EventID",
                principalTable: "Events",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Peoples_Events_EventID1",
                table: "Peoples",
                column: "EventID1",
                principalTable: "Events",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
