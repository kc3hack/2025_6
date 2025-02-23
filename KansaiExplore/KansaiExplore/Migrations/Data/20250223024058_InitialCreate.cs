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
                    created_at = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_kansaispot", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "kansaispot",
                columns: new[] { "Id", "choordinates", "created_at", "created_by", "media_url", "spot_description", "spot_name" },
                values: new object[] { new Guid("22489572-e6ee-44a5-b283-8404617d9dbf"), "13333,1111", new DateTimeOffset(new DateTime(2025, 2, 23, 11, 40, 57, 777, DateTimeKind.Unspecified).AddTicks(1451), new TimeSpan(0, 9, 0, 0, 0)), new Guid("2845c155-9160-49f8-95d0-2c9060f24490"), "example.com", "てすとだよ", "Test" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "kansaispot");
        }
    }
}
