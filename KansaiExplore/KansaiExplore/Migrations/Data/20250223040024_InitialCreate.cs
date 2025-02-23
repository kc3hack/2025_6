using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KansaiExplore.Migrations.Data
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "kansaispot",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    spot_name = table.Column<string>(type: "text", nullable: false),
                    spot_description = table.Column<string>(type: "text", nullable: false),
                    created_by = table.Column<Guid>(type: "uuid", nullable: false),
                    choordinates = table.Column<string>(type: "text", nullable: false),
                    media_url = table.Column<string>(type: "text", nullable: false),
                    created_at = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    latitude = table.Column<decimal>(type: "numeric", nullable: false),
                    longitude = table.Column<decimal>(type: "numeric", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_kansaispot", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "kansaispot",
                columns: new[] { "Id", "choordinates", "created_at", "created_by", "latitude", "longitude", "media_url", "spot_description", "spot_name" },
                values: new object[] { new Guid("cf24d8e7-48cf-42a8-9828-0ed5eea8ab03"), "13333,1111", new DateTimeOffset(new DateTime(2025, 2, 23, 13, 0, 24, 391, DateTimeKind.Unspecified).AddTicks(3534), new TimeSpan(0, 9, 0, 0, 0)), new Guid("f93f84f8-c150-437f-b62a-c015ca92a41c"), 0m, 0m, "example.com", "てすとだよ", "Test" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "kansaispot");
        }
    }
}
