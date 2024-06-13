using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HobbyApi.Migrations
{
    /// <inheritdoc />
    public partial class HobbyAPIDBMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Hobbies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Category = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hobbies", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Hobbies",
                columns: new[] { "Id", "Category", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Arts & Crafts", "The practice of applying paint, pigment, color, or other medium to a solid surface (such as canvas, paper, or wall) to create expressive or realistic works of art.", "Painting" },
                    { 2, "Outdoor Activities", "The practice of growing and cultivating plants as part of horticulture, which can include flowers, vegetables, fruits, and herbs.", "Gardening" },
                    { 3, "Education & Learning", "The activity of comprehending written texts, which can range from novels and poetry to non-fiction books and articles, for enjoyment or knowledge.", "Reading" },
                    { 4, "Outdoor Activities", "The activity of going for long walks in the countryside or wilderness, often on trails or footpaths, for exercise and enjoyment of nature.", "Hiking" },
                    { 5, "Culinary Arts", "The practice of preparing food by combining, mixing, and heating ingredients to create meals, often exploring different cuisines and techniques.", "Cooking" },
                    { 6, "Arts & Crafts", "The art or practice of taking and processing photographs, capturing moments, scenes, or subjects using a camera.", "Photography" },
                    { 7, "Arts & Crafts", "The craft of creating fabric by interlocking loops of yarn with needles, often to make clothing, accessories, or home decor items.", "Knitting" },
                    { 8, "Outdoor Activities", "The recreational activity of observing birds in their natural habitat, identifying different species, and noting their behaviors.", "Bird Watching" },
                    { 9, "Music & Performing Arts", "The activity of playing the guitar, a string instrument, which can involve learning chords, melodies, and songs, and playing various styles of music.", "Playing Guitar" },
                    { 10, "Health & Fitness", "A group of physical, mental, and spiritual practices or disciplines that aim to improve flexibility, strength, and relaxation through various postures, breathing techniques, and meditation.", "Yoga" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Hobbies");
        }
    }
}
