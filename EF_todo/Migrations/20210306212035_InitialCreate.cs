using Microsoft.EntityFrameworkCore.Migrations;

namespace EF_todo.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TodoItem",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(maxLength: 50, nullable: true),
                    Description = table.Column<string>(maxLength: 1000, nullable: true),
                    IsComplete = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TodoItem", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "TodoItem",
                columns: new[] { "Id", "Description", "IsComplete", "Title" },
                values: new object[] { 1, "to clean the house", true, "Cleaning" });

            migrationBuilder.InsertData(
                table: "TodoItem",
                columns: new[] { "Id", "Description", "IsComplete", "Title" },
                values: new object[] { 2, "to buy healthy food", false, "Groceries" });

            migrationBuilder.InsertData(
                table: "TodoItem",
                columns: new[] { "Id", "Description", "IsComplete", "Title" },
                values: new object[] { 3, "to do 100 push-ups", false, "Excercise" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TodoItem");
        }
    }
}
