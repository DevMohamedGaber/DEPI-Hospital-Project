using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class UpdateModule : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "id",
                table: "Patients",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Nurses",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Doctors",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Admins",
                newName: "Id");

            migrationBuilder.AddColumn<int>(
                name: "AccessFailedCount",
                table: "Patients",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ConcurrencyStamp",
                table: "Patients",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Patients",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "EmailConfirmed",
                table: "Patients",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "LockoutEnabled",
                table: "Patients",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "LockoutEnd",
                table: "Patients",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedEmail",
                table: "Patients",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedUserName",
                table: "Patients",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PasswordHash",
                table: "Patients",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "PhoneNumberConfirmed",
                table: "Patients",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "SecurityStamp",
                table: "Patients",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "TwoFactorEnabled",
                table: "Patients",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "Patients",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AccessFailedCount",
                table: "Nurses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ConcurrencyStamp",
                table: "Nurses",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Nurses",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "EmailConfirmed",
                table: "Nurses",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "LockoutEnabled",
                table: "Nurses",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "LockoutEnd",
                table: "Nurses",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedEmail",
                table: "Nurses",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedUserName",
                table: "Nurses",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PasswordHash",
                table: "Nurses",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "PhoneNumberConfirmed",
                table: "Nurses",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "SecurityStamp",
                table: "Nurses",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "TwoFactorEnabled",
                table: "Nurses",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "Nurses",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AccessFailedCount",
                table: "Doctors",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ConcurrencyStamp",
                table: "Doctors",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Doctors",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "EmailConfirmed",
                table: "Doctors",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "LockoutEnabled",
                table: "Doctors",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "LockoutEnd",
                table: "Doctors",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedEmail",
                table: "Doctors",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedUserName",
                table: "Doctors",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PasswordHash",
                table: "Doctors",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "PhoneNumberConfirmed",
                table: "Doctors",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "SecurityStamp",
                table: "Doctors",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "TwoFactorEnabled",
                table: "Doctors",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "Doctors",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                table: "Appointments",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "AccessFailedCount",
                table: "Appointments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Appointments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ConcurrencyStamp",
                table: "Appointments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Appointments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "EmailConfirmed",
                table: "Appointments",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "LockoutEnabled",
                table: "Appointments",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "LockoutEnd",
                table: "Appointments",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedEmail",
                table: "Appointments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedUserName",
                table: "Appointments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PasswordHash",
                table: "Appointments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Appointments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "PhoneNumberConfirmed",
                table: "Appointments",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "SecurityStamp",
                table: "Appointments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SocialNumber",
                table: "Appointments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "TwoFactorEnabled",
                table: "Appointments",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "Appointments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "firstName",
                table: "Appointments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<byte>(
                name: "gender",
                table: "Appointments",
                type: "tinyint",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddColumn<string>(
                name: "lastName",
                table: "Appointments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "AccessFailedCount",
                table: "Admins",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ConcurrencyStamp",
                table: "Admins",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Admins",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "EmailConfirmed",
                table: "Admins",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "LockoutEnabled",
                table: "Admins",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "LockoutEnd",
                table: "Admins",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedEmail",
                table: "Admins",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedUserName",
                table: "Admins",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PasswordHash",
                table: "Admins",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "PhoneNumberConfirmed",
                table: "Admins",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "SecurityStamp",
                table: "Admins",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "TwoFactorEnabled",
                table: "Admins",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "Admins",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AccessFailedCount",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "EmailConfirmed",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "LockoutEnabled",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "LockoutEnd",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "NormalizedEmail",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "NormalizedUserName",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "PasswordHash",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "PhoneNumberConfirmed",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "SecurityStamp",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "TwoFactorEnabled",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "AccessFailedCount",
                table: "Nurses");

            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "Nurses");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Nurses");

            migrationBuilder.DropColumn(
                name: "EmailConfirmed",
                table: "Nurses");

            migrationBuilder.DropColumn(
                name: "LockoutEnabled",
                table: "Nurses");

            migrationBuilder.DropColumn(
                name: "LockoutEnd",
                table: "Nurses");

            migrationBuilder.DropColumn(
                name: "NormalizedEmail",
                table: "Nurses");

            migrationBuilder.DropColumn(
                name: "NormalizedUserName",
                table: "Nurses");

            migrationBuilder.DropColumn(
                name: "PasswordHash",
                table: "Nurses");

            migrationBuilder.DropColumn(
                name: "PhoneNumberConfirmed",
                table: "Nurses");

            migrationBuilder.DropColumn(
                name: "SecurityStamp",
                table: "Nurses");

            migrationBuilder.DropColumn(
                name: "TwoFactorEnabled",
                table: "Nurses");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "Nurses");

            migrationBuilder.DropColumn(
                name: "AccessFailedCount",
                table: "Doctors");

            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "Doctors");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Doctors");

            migrationBuilder.DropColumn(
                name: "EmailConfirmed",
                table: "Doctors");

            migrationBuilder.DropColumn(
                name: "LockoutEnabled",
                table: "Doctors");

            migrationBuilder.DropColumn(
                name: "LockoutEnd",
                table: "Doctors");

            migrationBuilder.DropColumn(
                name: "NormalizedEmail",
                table: "Doctors");

            migrationBuilder.DropColumn(
                name: "NormalizedUserName",
                table: "Doctors");

            migrationBuilder.DropColumn(
                name: "PasswordHash",
                table: "Doctors");

            migrationBuilder.DropColumn(
                name: "PhoneNumberConfirmed",
                table: "Doctors");

            migrationBuilder.DropColumn(
                name: "SecurityStamp",
                table: "Doctors");

            migrationBuilder.DropColumn(
                name: "TwoFactorEnabled",
                table: "Doctors");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "Doctors");

            migrationBuilder.DropColumn(
                name: "AccessFailedCount",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "EmailConfirmed",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "LockoutEnabled",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "LockoutEnd",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "NormalizedEmail",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "NormalizedUserName",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "PasswordHash",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "PhoneNumberConfirmed",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "SecurityStamp",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "SocialNumber",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "TwoFactorEnabled",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "firstName",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "gender",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "lastName",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "AccessFailedCount",
                table: "Admins");

            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "Admins");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Admins");

            migrationBuilder.DropColumn(
                name: "EmailConfirmed",
                table: "Admins");

            migrationBuilder.DropColumn(
                name: "LockoutEnabled",
                table: "Admins");

            migrationBuilder.DropColumn(
                name: "LockoutEnd",
                table: "Admins");

            migrationBuilder.DropColumn(
                name: "NormalizedEmail",
                table: "Admins");

            migrationBuilder.DropColumn(
                name: "NormalizedUserName",
                table: "Admins");

            migrationBuilder.DropColumn(
                name: "PasswordHash",
                table: "Admins");

            migrationBuilder.DropColumn(
                name: "PhoneNumberConfirmed",
                table: "Admins");

            migrationBuilder.DropColumn(
                name: "SecurityStamp",
                table: "Admins");

            migrationBuilder.DropColumn(
                name: "TwoFactorEnabled",
                table: "Admins");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "Admins");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Patients",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Nurses",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Doctors",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Admins",
                newName: "id");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Appointments",
                type: "int",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");
        }
    }
}
