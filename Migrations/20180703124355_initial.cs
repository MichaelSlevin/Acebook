using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace TodoApi.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.CreateTable(
            //name: "TodoItems",
            //columns: table => new
            //{
            //    Id = table.Column<long>(nullable: false)
            //        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
            //    Name = table.Column<string>(nullable: true),
            //    IsComplete = table.Column<bool>(nullable: false)
            //},
            //constraints: table =>
            //{
            //    table.PrimaryKey("PK_TodoItems", x => x.Id);
            //});
            migrationBuilder.CreateTable(
            name: "Users",
            columns: table => new
            {
                Id = table.Column<long>(nullable: false)
                    .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                Username = table.Column<long>(nullable: false),
                Email = table.Column<string>(nullable: false),
                Password = table.Column<string>(nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_Id", x => x.Id);
            });
            migrationBuilder.CreateTable(
            name: "Posts",
            columns: table => new
            {
                Id = table.Column<long>(nullable: false)
                    .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                UserId = table.Column<long>(nullable: false),
                Content = table.Column<string>(nullable: false),
                CreatedOn = table.Column<System.DateTime>(nullable: true, defaultValue: System.DateTime.UtcNow)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_Posts", x => x.Id);
            });
            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Users_UserId",
                table: "Posts",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);


        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropTable(
                //name: "TodoItems");
            migrationBuilder.DropTable(
               name: "Posts");
            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
