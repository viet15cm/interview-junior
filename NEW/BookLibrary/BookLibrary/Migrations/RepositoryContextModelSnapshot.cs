﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Repository;

#nullable disable

namespace BookLibrary.Migrations
{
    [DbContext(typeof(RepositoryContext))]
    partial class RepositoryContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Entities.Models.Book", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("BookId");

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Genre")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Price")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Publish_Date")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.HasKey("Id");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            Id = "B1",
                            Author = "Kutner, Joe",
                            Description = "Deploying with JRuby is the missing link between enjoying JRuby and using it in the real world to build high-performance, scalable applications.",
                            Genre = "Computer",
                            Price = "33.00",
                            PublishDate = "2012-08-15",
                            Title = "Deploying with JRuby"
                        },
                        new
                        {
                            Id = "B2",
                            Author = "Ralls, Kim",
                            Description = "A former architect battles corporate zombies, an evil sorceress, and her own childhood to become queen of the world.",
                            Genre = "Fantasy",
                            Price = "5.95",
                            PublishDate = "2000-12-16",
                            Title = "Midnight Rain"
                        },
                        new
                        {
                            Id = "B3",
                            Author = "Corets, Eva",
                            Description = "After the collapse of a nanotechnology society in England, the young survivors lay the foundation for a new society.",
                            Genre = "Fantasy",
                            Price = "5.95",
                            PublishDate = "2000-11-17",
                            Title = "Maeve Ascendant"
                        },
                        new
                        {
                            Id = "B4",
                            Author = "Corets, Eva",
                            Description = "In post-apocalypse England, the mysterious agent known only as Oberon helps to create a new life for the inhabitants of London. Sequel to Maeve Ascendant.",
                            Genre = "Fantasy",
                            Price = "5.95",
                            PublishDate = "2001-03-10",
                            Title = "Oberon's Legacy"
                        },
                        new
                        {
                            Id = "B5",
                            Author = "Tolkien, JRR",
                            Description = "If you care for journeys there and back, out of the comfortable Western world, over the edge of the Wild, and home again, and can take an interest in a humble hero blessed with a little wisdom and a little courage and considerable good luck, here is a record of such a journey and such a traveler.",
                            Genre = "Fantasy",
                            Price = "11.95",
                            PublishDate = "1985-09-10",
                            Title = "The Hobbit"
                        },
                        new
                        {
                            Id = "B6",
                            Author = "Randall, Cynthia",
                            Description = "When Carla meets Paul at an ornithology conference, tempers fly as feathers get ruffled.",
                            Genre = "Romance",
                            Price = "4.95",
                            PublishDate = "2000-09-02",
                            Title = "Lover Birds"
                        },
                        new
                        {
                            Id = "B7",
                            Author = "Thurman, Paula",
                            Description = "A deep sea diver finds true love twenty thousand leagues beneath the sea.",
                            Genre = "Romance",
                            Price = "4.95",
                            PublishDate = "2000-11-02",
                            Title = "Splish Splash"
                        },
                        new
                        {
                            Id = "B8",
                            Author = "Knorr, Stefan",
                            Description = "An anthology of horror stories about roaches, centipedes, scorpions  and other insects.",
                            Genre = "Horror",
                            Price = "4.95",
                            PublishDate = "2000-12-06",
                            Title = "Creepy Crawlies"
                        },
                        new
                        {
                            Id = "B9",
                            Author = "Kress, Peter",
                            Description = "After an inadvertant trip through a Heisenberg Uncertainty Device, James Salway discovers the problems of being quantum.",
                            Genre = "Science Fiction",
                            Price = "6.95",
                            PublishDate = "2000-11-02",
                            Title = "Paradox Lost"
                        },
                        new
                        {
                            Id = "B10",
                            Author = "O'Brien, Tim",
                            Description = "Microsoft's .NET initiative is explored in detail in this deep programmer's reference.",
                            Genre = "Computer",
                            Price = "36.95",
                            PublishDate = "2000-12-09",
                            Title = "Microsoft .NET: The Programming Bible"
                        },
                        new
                        {
                            Id = "B11",
                            Author = "Sydik, Jeremy J",
                            Description = "Accessibility has a reputation of being dull, dry, and unfriendly toward graphic design. But there is a better way: well-styled semantic markup that lets you provide the best possible results for all of your users. This book will help you provide images, video, Flash and PDF in an accessible way that looks great to your sighted users, but is still accessible to all users.",
                            Genre = "Computer",
                            Price = "34.95",
                            PublishDate = "2007-12-01",
                            Title = "Design Accessible Web Sites"
                        },
                        new
                        {
                            Id = "B12",
                            Author = "Russell, Alex",
                            Description = "The last couple of years have seen big changes in server-side web programming. Now it’s the client’s turn; Dojo is the toolkit to make it happen and Mastering Dojo shows you how.",
                            Genre = "Computer",
                            Price = "38.95",
                            PublishDate = "2008-06-01",
                            Title = "Mastering Dojo"
                        },
                        new
                        {
                            Id = "B13",
                            Author = "Copeland, David Bryant",
                            Description = "Speak directly to your system. With its simple commands, flags, and parameters, a well-formed command-line application is the quickest way to automate a backup, a build, or a deployment and simplify your life.",
                            Genre = "Computer",
                            Price = "20.00",
                            PublishDate = "2012-03-01",
                            Title = "Build Awesome Command-Line Applications in Ruby"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
