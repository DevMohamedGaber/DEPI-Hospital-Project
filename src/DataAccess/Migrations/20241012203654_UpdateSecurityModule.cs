using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class UpdateSecurityModule : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsAgree",
                table: "Patients",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsAgree",
                table: "Nurses",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsAgree",
                table: "Doctors",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsAgree",
                table: "Appointments",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsAgree",
                table: "Admins",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsAgree",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "IsAgree",
                table: "Nurses");

            migrationBuilder.DropColumn(
                name: "IsAgree",
                table: "Doctors");

            migrationBuilder.DropColumn(
                name: "IsAgree",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "IsAgree",
                table: "Admins");
        }
    }
}
