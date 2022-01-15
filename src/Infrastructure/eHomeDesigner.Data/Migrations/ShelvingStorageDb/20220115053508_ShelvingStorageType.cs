using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eHomeDesigner.Data.Migrations.ShelvingStorageDb
{
    public partial class ShelvingStorageType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "ShelvingStorage",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Type",
                table: "ShelvingStorage");
        }
    }
}
