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
                    latitude = table.Column<double>(type: "double precision", nullable: false),
                    longitude = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_kansaispot", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "kansaispot",
                columns: new[] { "Id", "choordinates", "created_at", "created_by", "latitude", "longitude", "media_url", "spot_description", "spot_name" },
                values: new object[] { new Guid("70b41be5-9914-4bc8-871a-c9724121e5bc"), "13333,1111", new DateTimeOffset(new DateTime(2025, 2, 23, 13, 32, 32, 719, DateTimeKind.Unspecified).AddTicks(4849), new TimeSpan(0, 9, 0, 0, 0)), new Guid("bcff8153-539f-46c8-83a1-f0094c126c96"), 0.0, 0.0, "example.com", "てすとだよ", "Test" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "kansaispot");
        }
    }
}
