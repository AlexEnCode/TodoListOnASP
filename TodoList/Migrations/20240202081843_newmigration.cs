using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TodoList.Migrations
{
    public partial class newmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MyTasks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TaskState = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MyTasks", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "MyTasks",
                columns: new[] { "Id", "Description", "TaskState", "Title" },
                values: new object[] { 1, "Du balai", 2, "Menage" });

            migrationBuilder.InsertData(
                table: "MyTasks",
                columns: new[] { "Id", "Description", "TaskState", "Title" },
                values: new object[] { 2, "faut que ça mousse", 2, "Vaisselle" });

            migrationBuilder.InsertData(
                table: "MyTasks",
                columns: new[] { "Id", "Description", "TaskState", "Title" },
                values: new object[] { 3, "faire une ToDo List", 2, "devoir" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MyTasks");
        }
    }
}
