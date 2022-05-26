using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace demo1.Migrations
{
    public partial class FixCustomerSchema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Customers",
                table: "Customers");

            migrationBuilder.RenameTable(
                name: "Customers",
                newName: "customers");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "customers",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "UpdatedDate",
                table: "customers",
                newName: "updated_date");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "customers",
                newName: "last_name");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "customers",
                newName: "first_name");

            migrationBuilder.RenameColumn(
                name: "DateOfBirth",
                table: "customers",
                newName: "date_of_birth");

            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "customers",
                newName: "created_date");

            migrationBuilder.AddPrimaryKey(
                name: "PK_customers",
                table: "customers",
                column: "id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_customers",
                table: "customers");

            migrationBuilder.RenameTable(
                name: "customers",
                newName: "Customers");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Customers",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "updated_date",
                table: "Customers",
                newName: "UpdatedDate");

            migrationBuilder.RenameColumn(
                name: "last_name",
                table: "Customers",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "first_name",
                table: "Customers",
                newName: "FirstName");

            migrationBuilder.RenameColumn(
                name: "date_of_birth",
                table: "Customers",
                newName: "DateOfBirth");

            migrationBuilder.RenameColumn(
                name: "created_date",
                table: "Customers",
                newName: "CreatedDate");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Customers",
                table: "Customers",
                column: "Id");
        }
    }
}
