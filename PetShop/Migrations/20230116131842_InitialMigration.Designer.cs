﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PetShop.Data.Concrete.Ef;

namespace PetShop.Migrations
{
    [DbContext(typeof(PetContext))]
    [Migration("20230116131842_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AnimalGenre", b =>
                {
                    b.Property<int>("AnimalsAnimalId")
                        .HasColumnType("int");

                    b.Property<int>("GenresGenreId")
                        .HasColumnType("int");

                    b.HasKey("AnimalsAnimalId", "GenresGenreId");

                    b.HasIndex("GenresGenreId");

                    b.ToTable("AnimalGenre");
                });

            modelBuilder.Entity("PagePageImage", b =>
                {
                    b.Property<int>("ImagesPageImageId")
                        .HasColumnType("int");

                    b.Property<int>("PagesPageId")
                        .HasColumnType("int");

                    b.HasKey("ImagesPageImageId", "PagesPageId");

                    b.HasIndex("PagesPageId");

                    b.ToTable("PagePageImage");
                });

            modelBuilder.Entity("PetShop.Entity.Animal", b =>
                {
                    b.Property<int>("AnimalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("AnimalName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhotoUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TinyPhotoUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("hasIssue")
                        .HasColumnType("bit");

                    b.HasKey("AnimalId");

                    b.ToTable("Animals");
                });

            modelBuilder.Entity("PetShop.Entity.Genre", b =>
                {
                    b.Property<int>("GenreId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("GenreName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GenreId");

                    b.ToTable("Genres");
                });

            modelBuilder.Entity("PetShop.Entity.Page", b =>
                {
                    b.Property<int>("PageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PageName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PageId");

                    b.ToTable("Pages");
                });

            modelBuilder.Entity("PetShop.Entity.PageImage", b =>
                {
                    b.Property<int>("PageImageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Url")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PageImageId");

                    b.ToTable("PageImage");
                });

            modelBuilder.Entity("AnimalGenre", b =>
                {
                    b.HasOne("PetShop.Entity.Animal", null)
                        .WithMany()
                        .HasForeignKey("AnimalsAnimalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PetShop.Entity.Genre", null)
                        .WithMany()
                        .HasForeignKey("GenresGenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PagePageImage", b =>
                {
                    b.HasOne("PetShop.Entity.PageImage", null)
                        .WithMany()
                        .HasForeignKey("ImagesPageImageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PetShop.Entity.Page", null)
                        .WithMany()
                        .HasForeignKey("PagesPageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
