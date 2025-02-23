﻿// <auto-generated />
using System;
using KansaiExplore.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace KansaiExplore.Migrations.Data
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("KansaiExplore.Data.Shared.NicheSpot", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Choordinates")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("choordinates");

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_at");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uuid")
                        .HasColumnName("created_by");

                    b.Property<string>("MediaUrl")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("media_url");

                    b.Property<string>("SpotDescription")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("spot_description");

                    b.Property<string>("SpotName")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("spot_name");

                    b.HasKey("Id");

                    b.ToTable("kansaispot");

                    b.HasData(
                        new
                        {
                            Id = new Guid("22489572-e6ee-44a5-b283-8404617d9dbf"),
                            Choordinates = "13333,1111",
                            CreatedAt = new DateTimeOffset(new DateTime(2025, 2, 23, 11, 40, 57, 777, DateTimeKind.Unspecified).AddTicks(1451), new TimeSpan(0, 9, 0, 0, 0)),
                            CreatedBy = new Guid("2845c155-9160-49f8-95d0-2c9060f24490"),
                            MediaUrl = "example.com",
                            SpotDescription = "てすとだよ",
                            SpotName = "Test"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
