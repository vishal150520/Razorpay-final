using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Razorpay.Integration.Migrations
{
    /// <inheritdoc />
    public partial class Intial1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "paydatas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    order_id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    payment_id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    signature = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    status = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_paydatas", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "paydatas");
        }
    }
}
