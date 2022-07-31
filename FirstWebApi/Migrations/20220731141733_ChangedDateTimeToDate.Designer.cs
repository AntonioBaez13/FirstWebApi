﻿// <auto-generated />
using System;
using FirstWebApi.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace FirstWebApi.Migrations
{
    [DbContext(typeof(TesterHubContext))]
    [Migration("20220731141733_ChangedDateTimeToDate")]
    partial class ChangedDateTimeToDate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("FirstWebApi.Models.Tester", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<bool>("CodeReviewer")
                        .HasColumnType("boolean");

                    b.Property<string>("FirstName")
                        .HasColumnType("text");

                    b.Property<DateTime>("JoinedHub")
                        .HasColumnType("date");

                    b.Property<string>("LastName")
                        .HasColumnType("text");

                    b.Property<int?>("TeamName")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Tester");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            CodeReviewer = true,
                            FirstName = "Antonio",
                            JoinedHub = new DateTime(2021, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastName = "Banderas",
                            TeamName = 0
                        },
                        new
                        {
                            Id = 2L,
                            CodeReviewer = false,
                            FirstName = "Virginia",
                            JoinedHub = new DateTime(2019, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastName = "South",
                            TeamName = 2
                        },
                        new
                        {
                            Id = 3L,
                            CodeReviewer = true,
                            FirstName = "Jean",
                            JoinedHub = new DateTime(2021, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastName = "Mcklaine",
                            TeamName = 4
                        },
                        new
                        {
                            Id = 4L,
                            CodeReviewer = false,
                            FirstName = "Angel",
                            JoinedHub = new DateTime(2022, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastName = "Heart",
                            TeamName = 0
                        },
                        new
                        {
                            Id = 5L,
                            CodeReviewer = true,
                            FirstName = "Chris",
                            JoinedHub = new DateTime(2018, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastName = "Sky",
                            TeamName = 3
                        });
                });

            modelBuilder.Entity("FirstWebApi.Models.Todo", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("Created")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("DateCompleted")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("DueDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Notes")
                        .HasColumnType("text");

                    b.Property<int?>("Status")
                        .HasColumnType("integer");

                    b.Property<string>("Task")
                        .HasColumnType("text");

                    b.Property<int?>("TeamName")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Todo");
                });
#pragma warning restore 612, 618
        }
    }
}
