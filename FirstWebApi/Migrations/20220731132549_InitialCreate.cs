using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace FirstWebApi.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tester",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FirstName = table.Column<string>(type: "text", nullable: true),
                    LastName = table.Column<string>(type: "text", nullable: true),
                    JoinedHub = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CodeReviewer = table.Column<bool>(type: "boolean", nullable: false),
                    TeamName = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tester", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Todo",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Task = table.Column<string>(type: "text", nullable: true),
                    Notes = table.Column<string>(type: "text", nullable: true),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DueDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    DateCompleted = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    TeamName = table.Column<int>(type: "integer", nullable: true),
                    Status = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Todo", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Tester",
                columns: new[] { "Id", "CodeReviewer", "FirstName", "JoinedHub", "LastName", "TeamName" },
                values: new object[,]
                {
                    { 1L, true, "Antonio", new DateTime(2021, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Banderas", 0 },
                    { 2L, false, "Virginia", new DateTime(2019, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "South", 2 },
                    { 3L, true, "Jean", new DateTime(2021, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mcklaine", 4 },
                    { 4L, false, "Angel", new DateTime(2022, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Heart", 0 },
                    { 5L, true, "Chris", new DateTime(2018, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sky", 3 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tester");

            migrationBuilder.DropTable(
                name: "Todo");
        }
    }
}
