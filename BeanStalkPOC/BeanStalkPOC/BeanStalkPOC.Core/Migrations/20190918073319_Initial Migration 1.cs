using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace BeanStalkPOC.Core.Migrations
{
    public partial class InitialMigration1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "StudentID",
                table: "Students",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "GradeId",
                table: "Grades",
                newName: "Id");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationTime",
                table: "Students",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<long>(
                name: "CreatorUserId",
                table: "Students",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "DeleterUserId",
                table: "Students",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletionTime",
                table: "Students",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Students",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Students",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModificationTime",
                table: "Students",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "LastModifierUserId",
                table: "Students",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationTime",
                table: "Grades",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<long>(
                name: "CreatorUserId",
                table: "Grades",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "DeleterUserId",
                table: "Grades",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletionTime",
                table: "Grades",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Grades",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Grades",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModificationTime",
                table: "Grades",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "LastModifierUserId",
                table: "Grades",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreationTime",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "CreatorUserId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "DeleterUserId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "DeletionTime",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "LastModificationTime",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "LastModifierUserId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "CreationTime",
                table: "Grades");

            migrationBuilder.DropColumn(
                name: "CreatorUserId",
                table: "Grades");

            migrationBuilder.DropColumn(
                name: "DeleterUserId",
                table: "Grades");

            migrationBuilder.DropColumn(
                name: "DeletionTime",
                table: "Grades");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Grades");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Grades");

            migrationBuilder.DropColumn(
                name: "LastModificationTime",
                table: "Grades");

            migrationBuilder.DropColumn(
                name: "LastModifierUserId",
                table: "Grades");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Students",
                newName: "StudentID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Grades",
                newName: "GradeId");
        }
    }
}
