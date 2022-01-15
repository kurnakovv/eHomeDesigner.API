using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eHomeDesigner.Data.Migrations
{
    public partial class EntityTypes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DeviceType",
                table: "Devices",
                newName: "Type");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Type",
                table: "Devices",
                newName: "DeviceType");
        }
    }
}
