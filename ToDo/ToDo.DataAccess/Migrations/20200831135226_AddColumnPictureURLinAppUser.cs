using Microsoft.EntityFrameworkCore.Migrations;

namespace ToDo.DataAccess.Migrations
{
    public partial class AddColumnPictureURLinAppUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PictureURL",
                table: "AspNetUsers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PictureURL",
                table: "AspNetUsers");
        }
    }
}
