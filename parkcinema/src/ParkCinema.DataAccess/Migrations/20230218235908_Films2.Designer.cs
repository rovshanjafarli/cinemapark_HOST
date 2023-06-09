﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ParkCinema.DataAccess.Contexts;

#nullable disable

namespace ParkCinema.DataAccess.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230218235908_Films2")]
    partial class Films2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ParkCinema.Core.Entities.Film", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Actors")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("AgeLimit")
                        .HasColumnType("int");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("DurationMinute")
                        .HasColumnType("int");

                    b.Property<bool>("IsNew")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Poster")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PosterPathOrContainerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Trailer")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Films");
                });

            modelBuilder.Entity("ParkCinema.Core.Entities.Film_Format", b =>
                {
                    b.Property<int>("Film_Id")
                        .HasColumnType("int");

                    b.Property<int>("Format_Id")
                        .HasColumnType("int");

                    b.HasKey("Film_Id", "Format_Id");

                    b.HasIndex("Format_Id");

                    b.ToTable("Film_Formats");
                });

            modelBuilder.Entity("ParkCinema.Core.Entities.Film_Genre", b =>
                {
                    b.Property<int>("Film_Id")
                        .HasColumnType("int");

                    b.Property<int>("Genre_Id")
                        .HasColumnType("int");

                    b.HasKey("Film_Id", "Genre_Id");

                    b.HasIndex("Genre_Id");

                    b.ToTable("Film_Genres");
                });

            modelBuilder.Entity("ParkCinema.Core.Entities.Film_Language", b =>
                {
                    b.Property<int>("Film_Id")
                        .HasColumnType("int");

                    b.Property<int>("Language_Id")
                        .HasColumnType("int");

                    b.HasKey("Film_Id", "Language_Id");

                    b.HasIndex("Language_Id");

                    b.ToTable("Film_Languages");
                });

            modelBuilder.Entity("ParkCinema.Core.Entities.Film_Subtitle", b =>
                {
                    b.Property<int>("Film_Id")
                        .HasColumnType("int");

                    b.Property<int>("Subtitle_Id")
                        .HasColumnType("int");

                    b.HasKey("Film_Id", "Subtitle_Id");

                    b.HasIndex("Subtitle_Id");

                    b.ToTable("Film_Subtitles");
                });

            modelBuilder.Entity("ParkCinema.Core.Entities.Format", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Formats");
                });

            modelBuilder.Entity("ParkCinema.Core.Entities.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Genres");
                });

            modelBuilder.Entity("ParkCinema.Core.Entities.Language", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Languages");
                });

            modelBuilder.Entity("ParkCinema.Core.Entities.Subtitle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Subtitles");
                });

            modelBuilder.Entity("ParkCinema.Core.Entities.Film_Format", b =>
                {
                    b.HasOne("ParkCinema.Core.Entities.Film", "Film")
                        .WithMany("Film_Formats")
                        .HasForeignKey("Film_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ParkCinema.Core.Entities.Format", "Format")
                        .WithMany("Film_Formats")
                        .HasForeignKey("Format_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Film");

                    b.Navigation("Format");
                });

            modelBuilder.Entity("ParkCinema.Core.Entities.Film_Genre", b =>
                {
                    b.HasOne("ParkCinema.Core.Entities.Film", "Film")
                        .WithMany("Film_Genres")
                        .HasForeignKey("Film_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ParkCinema.Core.Entities.Genre", "Genre")
                        .WithMany("Film_Genres")
                        .HasForeignKey("Genre_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Film");

                    b.Navigation("Genre");
                });

            modelBuilder.Entity("ParkCinema.Core.Entities.Film_Language", b =>
                {
                    b.HasOne("ParkCinema.Core.Entities.Film", "Film")
                        .WithMany("Film_Languages")
                        .HasForeignKey("Film_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ParkCinema.Core.Entities.Language", "Language")
                        .WithMany("Film_Languages")
                        .HasForeignKey("Language_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Film");

                    b.Navigation("Language");
                });

            modelBuilder.Entity("ParkCinema.Core.Entities.Film_Subtitle", b =>
                {
                    b.HasOne("ParkCinema.Core.Entities.Film", "Film")
                        .WithMany("Film_Subtitles")
                        .HasForeignKey("Film_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ParkCinema.Core.Entities.Subtitle", "Subtitle")
                        .WithMany("Film_Subtitles")
                        .HasForeignKey("Subtitle_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Film");

                    b.Navigation("Subtitle");
                });

            modelBuilder.Entity("ParkCinema.Core.Entities.Film", b =>
                {
                    b.Navigation("Film_Formats");

                    b.Navigation("Film_Genres");

                    b.Navigation("Film_Languages");

                    b.Navigation("Film_Subtitles");
                });

            modelBuilder.Entity("ParkCinema.Core.Entities.Format", b =>
                {
                    b.Navigation("Film_Formats");
                });

            modelBuilder.Entity("ParkCinema.Core.Entities.Genre", b =>
                {
                    b.Navigation("Film_Genres");
                });

            modelBuilder.Entity("ParkCinema.Core.Entities.Language", b =>
                {
                    b.Navigation("Film_Languages");
                });

            modelBuilder.Entity("ParkCinema.Core.Entities.Subtitle", b =>
                {
                    b.Navigation("Film_Subtitles");
                });
#pragma warning restore 612, 618
        }
    }
}
