using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace MyCompany.MyProjectDemo.Migrations
{
    public partial class MyProjectDemoDbContextV1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PhoneNumbers_Persons_PersonId",
                table: "PhoneNumbers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PhoneNumbers",
                table: "PhoneNumbers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Persons",
                table: "Persons");

            migrationBuilder.EnsureSchema(
                name: "PB");

            migrationBuilder.RenameTable(
                name: "PhoneNumbers",
                newName: "PhoneNumber",
                newSchema: "PB");

            migrationBuilder.RenameTable(
                name: "Persons",
                newName: "Person",
                newSchema: "PB");

            migrationBuilder.RenameIndex(
                name: "IX_PhoneNumbers_PersonId",
                schema: "PB",
                table: "PhoneNumber",
                newName: "IX_PhoneNumber_PersonId");

            migrationBuilder.AlterColumn<string>(
                name: "Value",
                table: "AbpLanguageTexts",
                maxLength: 67108864,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 500);

            migrationBuilder.AddPrimaryKey(
                name: "PK_PhoneNumber",
                schema: "PB",
                table: "PhoneNumber",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Person",
                schema: "PB",
                table: "Person",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PhoneNumber_Person_PersonId",
                schema: "PB",
                table: "PhoneNumber",
                column: "PersonId",
                principalSchema: "PB",
                principalTable: "Person",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PhoneNumber_Person_PersonId",
                schema: "PB",
                table: "PhoneNumber");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PhoneNumber",
                schema: "PB",
                table: "PhoneNumber");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Person",
                schema: "PB",
                table: "Person");

            migrationBuilder.RenameTable(
                name: "PhoneNumber",
                schema: "PB",
                newName: "PhoneNumbers");

            migrationBuilder.RenameTable(
                name: "Person",
                schema: "PB",
                newName: "Persons");

            migrationBuilder.RenameIndex(
                name: "IX_PhoneNumber_PersonId",
                table: "PhoneNumbers",
                newName: "IX_PhoneNumbers_PersonId");

            migrationBuilder.AlterColumn<string>(
                name: "Value",
                table: "AbpLanguageTexts",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 67108864);

            migrationBuilder.AddPrimaryKey(
                name: "PK_PhoneNumbers",
                table: "PhoneNumbers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Persons",
                table: "Persons",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PhoneNumbers_Persons_PersonId",
                table: "PhoneNumbers",
                column: "PersonId",
                principalTable: "Persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
