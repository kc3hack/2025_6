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

                    b.Property<double>("Latitude")
                        .HasColumnType("double precision")
                        .HasColumnName("latitude");

                    b.Property<double>("Longitude")
                        .HasColumnType("double precision")
                        .HasColumnName("longitude");

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

                    b.Property<string>("Valuation")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("valuation");

                    b.HasKey("Id");

                    b.ToTable("kansaispot");

                    b.HasData(
                        new
                        {
                            Id = new Guid("28b42569-ca64-47f0-a866-0d0ee4af8b1b"),
                            Choordinates = "13333,1111",
                            CreatedAt = new DateTimeOffset(new DateTime(2025, 2, 23, 15, 9, 17, 861, DateTimeKind.Unspecified).AddTicks(9358), new TimeSpan(0, 9, 0, 0, 0)),
                            CreatedBy = new Guid("b0ce9f2f-a206-43ee-849d-2013add0fd58"),
                            Latitude = 16384.0,
                            Longitude = 65536.0,
                            MediaUrl = "example.com",
                            SpotDescription = "てすとだよ",
                            SpotName = "Test",
                            Valuation = "Test"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
