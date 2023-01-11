using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CalcApi.Migrations
{
    /// <inheritdoc />
    public partial class UseUtcTimestamp : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Recieved",
                table: "RequestLogs",
                newName: "RecievedUtc");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "RecievedUtc",
                table: "RequestLogs",
                newName: "Recieved");
        }
    }
}
