using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication1.Migrations
{
    public partial class updatingTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ProductId",
                table: "Products",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "InvoiceId",
                table: "Invoices",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "DetailId",
                table: "Details",
                newName: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Products",
                newName: "ProductId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Invoices",
                newName: "InvoiceId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Details",
                newName: "DetailId");
        }
    }
}
