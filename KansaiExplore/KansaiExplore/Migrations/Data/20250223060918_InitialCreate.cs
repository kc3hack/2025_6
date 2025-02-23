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
                    longitude = table.Column<double>(type: "double precision", nullable: false),
                    valuation = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_kansaispot", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "kansaispot",
                columns: new[] { "Id", "choordinates", "created_at", "created_by", "latitude", "longitude", "media_url", "spot_description", "spot_name", "valuation" },
                values: new object[] { new Guid("28b42569-ca64-47f0-a866-0d0ee4af8b1b"), "13333,1111", new DateTimeOffset(new DateTime(2025, 2, 23, 15, 9, 17, 861, DateTimeKind.Unspecified).AddTicks(9358), new TimeSpan(0, 9, 0, 0, 0)), new Guid("b0ce9f2f-a206-43ee-849d-2013add0fd58"), 16384.0, 65536.0, "example.com", "てすとだよ", "Test", "Test" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "kansaispot");
        }
    }
}
