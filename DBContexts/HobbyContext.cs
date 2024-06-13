using HobbyApi.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace HobbyApi.DBContexts
{
    public class HobbyContext : DbContext
    {
        public HobbyContext(DbContextOptions<HobbyContext> options)
            : base(options)
        {
        }

        public DbSet<Hobby> Hobbies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Hobby>()
                 .HasData(
            new Hobby("Painting")
            {
                Id = 1,
                Category = "Arts & Crafts",
                Description = "The practice of applying paint, pigment, color, or other medium to a solid surface (such as canvas, paper, or wall) to create expressive or realistic works of art."
            },

            new Hobby("Gardening")
            {
                Id = 2,
                Category = "Outdoor Activities",
                Description = "The practice of growing and cultivating plants as part of horticulture, which can include flowers, vegetables, fruits, and herbs."
            },

            new Hobby("Reading")
            {
                Id = 3,
                Category = "Education & Learning",
                Description = "The activity of comprehending written texts, which can range from novels and poetry to non-fiction books and articles, for enjoyment or knowledge."
            },

            new Hobby("Hiking")
            {
                Id = 4,
                Category = "Outdoor Activities",
                Description = "The activity of going for long walks in the countryside or wilderness, often on trails or footpaths, for exercise and enjoyment of nature."
            },

            new Hobby("Cooking")
            {
                Id = 5,
                Category = "Culinary Arts",
                Description = "The practice of preparing food by combining, mixing, and heating ingredients to create meals, often exploring different cuisines and techniques."
            },

            new Hobby("Photography")
            {
                Id = 6,
                Category = "Arts & Crafts",
                Description = "The art or practice of taking and processing photographs, capturing moments, scenes, or subjects using a camera."
            },

            new Hobby("Knitting")
            {
                Id = 7,
                Category = "Arts & Crafts",
                Description = "The craft of creating fabric by interlocking loops of yarn with needles, often to make clothing, accessories, or home decor items."
            },

            new Hobby("Bird Watching")
            {
                Id = 8,
                Category = "Outdoor Activities",
                Description = "The recreational activity of observing birds in their natural habitat, identifying different species, and noting their behaviors."
            },

            new Hobby("Playing Guitar")
            {
                Id = 9,
                Category = "Music & Performing Arts",
                Description = "The activity of playing the guitar, a string instrument, which can involve learning chords, melodies, and songs, and playing various styles of music."
            },

            new Hobby("Yoga")
            {
                Id = 10,
                Category = "Health & Fitness",
                Description = "A group of physical, mental, and spiritual practices or disciplines that aim to improve flexibility, strength, and relaxation through various postures, breathing techniques, and meditation."
            });


            base.OnModelCreating(modelBuilder);
        }
    }
}
