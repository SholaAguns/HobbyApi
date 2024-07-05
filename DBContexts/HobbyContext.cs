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
                Id = Guid.NewGuid(),
                Category = "Arts & Crafts",
                Description = "The practice of applying paint, pigment, color, or other medium to a solid surface (such as canvas, paper, or wall) to create expressive or realistic works of art.",
                Rating = 6
            },

            new Hobby("Gardening")
            {
                Id = Guid.NewGuid(),
                Category = "Outdoor Activities",
                Description = "The practice of growing and cultivating plants as part of horticulture, which can include flowers, vegetables, fruits, and herbs.",
                Rating = 4
            },

            new Hobby("Reading")
            {
                Id = Guid.NewGuid(),
                Category = "Education & Learning",
                Description = "The activity of comprehending written texts, which can range from novels and poetry to non-fiction books and articles, for enjoyment or knowledge.",
                Rating = 8
            },

            new Hobby("Hiking")
            {
                Id = Guid.NewGuid(),
                Category = "Outdoor Activities",
                Description = "The activity of going for long walks in the countryside or wilderness, often on trails or footpaths, for exercise and enjoyment of nature.",
                Rating = 7
            },

            new Hobby("Cooking")
            {
                Id = Guid.NewGuid(),
                Category = "Culinary Arts",
                Description = "The practice of preparing food by combining, mixing, and heating ingredients to create meals, often exploring different cuisines and techniques.",
                Rating = 5
            },

            new Hobby("Photography")
            {
                Id = Guid.NewGuid(),
                Category = "Arts & Crafts",
                Description = "The art or practice of taking and processing photographs, capturing moments, scenes, or subjects using a camera.",
                Rating = 4
            },

            new Hobby("Knitting")
            {
                Id = Guid.NewGuid(),
                Category = "Arts & Crafts",
                Description = "The craft of creating fabric by interlocking loops of yarn with needles, often to make clothing, accessories, or home decor items.",
                Rating = 5.5
            },

            new Hobby("Bird Watching")
            {
                Id = Guid.NewGuid(),
                Category = "Outdoor Activities",
                Description = "The recreational activity of observing birds in their natural habitat, identifying different species, and noting their behaviors.",
                Rating = 5.5
            },

            new Hobby("Playing Guitar")
            {
                Id = Guid.NewGuid(),
                Category = "Music & Performing Arts",
                Description = "The activity of playing the guitar, a string instrument, which can involve learning chords, melodies, and songs, and playing various styles of music.",
                Rating = 7
            },

            new Hobby("Yoga")
            {
                Id = Guid.NewGuid(),
                Category = "Health & Fitness",
                Description = "A group of physical, mental, and spiritual practices or disciplines that aim to improve flexibility, strength, and relaxation through various postures, breathing techniques, and meditation.",
                Rating = 6.5
            });


            base.OnModelCreating(modelBuilder);
        }
    }
}
