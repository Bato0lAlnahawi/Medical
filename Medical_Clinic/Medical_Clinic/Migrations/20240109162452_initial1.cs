using Microsoft.EntityFrameworkCore.Migrations;

namespace Medical_Clinic.Migrations
{
    public partial class initial1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "dispense",
                table: "Prescriptions",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "dispense",
                table: "Prescriptions");
        }
    }
}
