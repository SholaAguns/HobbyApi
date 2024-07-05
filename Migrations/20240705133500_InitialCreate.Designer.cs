﻿// <auto-generated />
using System;
using HobbyApi.DBContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HobbyApi.Migrations
{
    [DbContext(typeof(HobbyContext))]
    [Migration("20240705133500_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.6");

            modelBuilder.Entity("HobbyApi.Models.Hobby", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("Rating")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.ToTable("Hobbies");

                    b.HasData(
                        new
                        {
                            Id = new Guid("1ae7d626-8417-4f30-a890-143ef6f83206"),
                            Category = "Arts & Crafts",
                            Description = "The practice of applying paint, pigment, color, or other medium to a solid surface (such as canvas, paper, or wall) to create expressive or realistic works of art.",
                            Name = "Painting",
                            Rating = 6.0
                        },
                        new
                        {
                            Id = new Guid("b87c8669-a5fb-4ff0-a648-0237b821f721"),
                            Category = "Outdoor Activities",
                            Description = "The practice of growing and cultivating plants as part of horticulture, which can include flowers, vegetables, fruits, and herbs.",
                            Name = "Gardening",
                            Rating = 4.0
                        },
                        new
                        {
                            Id = new Guid("e60adfa0-3cf2-4ce3-8459-44d8704746f1"),
                            Category = "Education & Learning",
                            Description = "The activity of comprehending written texts, which can range from novels and poetry to non-fiction books and articles, for enjoyment or knowledge.",
                            Name = "Reading",
                            Rating = 8.0
                        },
                        new
                        {
                            Id = new Guid("95d35ae0-3aa7-45e0-adb6-6b2565fa0f45"),
                            Category = "Outdoor Activities",
                            Description = "The activity of going for long walks in the countryside or wilderness, often on trails or footpaths, for exercise and enjoyment of nature.",
                            Name = "Hiking",
                            Rating = 7.0
                        },
                        new
                        {
                            Id = new Guid("b47d0da6-afec-4a7d-8460-273f709a4e56"),
                            Category = "Culinary Arts",
                            Description = "The practice of preparing food by combining, mixing, and heating ingredients to create meals, often exploring different cuisines and techniques.",
                            Name = "Cooking",
                            Rating = 5.0
                        },
                        new
                        {
                            Id = new Guid("be64bd4b-00f2-4b52-8276-2d1dfc946d73"),
                            Category = "Arts & Crafts",
                            Description = "The art or practice of taking and processing photographs, capturing moments, scenes, or subjects using a camera.",
                            Name = "Photography",
                            Rating = 4.0
                        },
                        new
                        {
                            Id = new Guid("1e91991c-ecd5-4301-be92-66f2456de7f4"),
                            Category = "Arts & Crafts",
                            Description = "The craft of creating fabric by interlocking loops of yarn with needles, often to make clothing, accessories, or home decor items.",
                            Name = "Knitting",
                            Rating = 5.5
                        },
                        new
                        {
                            Id = new Guid("939cc0b9-e8a7-405d-9ad6-2e1a28de08aa"),
                            Category = "Outdoor Activities",
                            Description = "The recreational activity of observing birds in their natural habitat, identifying different species, and noting their behaviors.",
                            Name = "Bird Watching",
                            Rating = 5.5
                        },
                        new
                        {
                            Id = new Guid("c89ced0c-e090-41f8-956b-c7f9bf53e4c3"),
                            Category = "Music & Performing Arts",
                            Description = "The activity of playing the guitar, a string instrument, which can involve learning chords, melodies, and songs, and playing various styles of music.",
                            Name = "Playing Guitar",
                            Rating = 7.0
                        },
                        new
                        {
                            Id = new Guid("dbc9244a-962f-4c94-8e5a-757537f9a238"),
                            Category = "Health & Fitness",
                            Description = "A group of physical, mental, and spiritual practices or disciplines that aim to improve flexibility, strength, and relaxation through various postures, breathing techniques, and meditation.",
                            Name = "Yoga",
                            Rating = 6.5
                        });
                });
#pragma warning restore 612, 618
        }
    }
}