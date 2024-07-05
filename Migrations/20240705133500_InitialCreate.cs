using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HobbyApi.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Hobbies",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Category = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    Rating = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hobbies", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Hobbies",
                columns: new[] { "Id", "Category", "Description", "Name", "Rating" },
                values: new object[,]
                {
                    { new Guid("1ae7d626-8417-4f30-a890-143ef6f83206"), "Arts & Crafts", "The practice of applying paint, pigment, color, or other medium to a solid surface (such as canvas, paper, or wall) to create expressive or realistic works of art.", "Painting", 6.0 },
                    { new Guid("1e91991c-ecd5-4301-be92-66f2456de7f4"), "Arts & Crafts", "The craft of creating fabric by interlocking loops of yarn with needles, often to make clothing, accessories, or home decor items.", "Knitting", 5.5 },
                    { new Guid("939cc0b9-e8a7-405d-9ad6-2e1a28de08aa"), "Outdoor Activities", "The recreational activity of observing birds in their natural habitat, identifying different species, and noting their behaviors.", "Bird Watching", 5.5 },
                    { new Guid("95d35ae0-3aa7-45e0-adb6-6b2565fa0f45"), "Outdoor Activities", "The activity of going for long walks in the countryside or wilderness, often on trails or footpaths, for exercise and enjoyment of nature.", "Hiking", 7.0 },
                    { new Guid("b47d0da6-afec-4a7d-8460-273f709a4e56"), "Culinary Arts", "The practice of preparing food by combining, mixing, and heating ingredients to create meals, often exploring different cuisines and techniques.", "Cooking", 5.0 },
                    { new Guid("b87c8669-a5fb-4ff0-a648-0237b821f721"), "Outdoor Activities", "The practice of growing and cultivating plants as part of horticulture, which can include flowers, vegetables, fruits, and herbs.", "Gardening", 4.0 },
                    { new Guid("be64bd4b-00f2-4b52-8276-2d1dfc946d73"), "Arts & Crafts", "The art or practice of taking and processing photographs, capturing moments, scenes, or subjects using a camera.", "Photography", 4.0 },
                    { new Guid("c89ced0c-e090-41f8-956b-c7f9bf53e4c3"), "Music & Performing Arts", "The activity of playing the guitar, a string instrument, which can involve learning chords, melodies, and songs, and playing various styles of music.", "Playing Guitar", 7.0 },
                    { new Guid("dbc9244a-962f-4c94-8e5a-757537f9a238"), "Health & Fitness", "A group of physical, mental, and spiritual practices or disciplines that aim to improve flexibility, strength, and relaxation through various postures, breathing techniques, and meditation.", "Yoga", 6.5 },
                    { new Guid("e60adfa0-3cf2-4ce3-8459-44d8704746f1"), "Education & Learning", "The activity of comprehending written texts, which can range from novels and poetry to non-fiction books and articles, for enjoyment or knowledge.", "Reading", 8.0 }
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
