﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using lapGen.persistance;

#nullable disable

namespace lapGen.Migrations
{
    [DbContext(typeof(DataCon))]
    [Migration("20220608170928_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.5");

            modelBuilder.Entity("lapGen.Models.Car", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("height")
                        .HasColumnType("TEXT");

                    b.Property<int>("hp_maxMax")
                        .HasColumnType("INTEGER");

                    b.Property<int>("hp_maxMin")
                        .HasColumnType("INTEGER");

                    b.Property<string>("length")
                        .HasColumnType("TEXT");

                    b.Property<string>("name")
                        .HasColumnType("TEXT");

                    b.Property<int>("number")
                        .HasColumnType("INTEGER");

                    b.Property<string>("transmission")
                        .HasColumnType("TEXT");

                    b.Property<string>("weight")
                        .HasColumnType("TEXT");

                    b.Property<string>("wheelbase")
                        .HasColumnType("TEXT");

                    b.Property<string>("width")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("Car", (string)null);
                });

            modelBuilder.Entity("lapGen.Models.Driver", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("name")
                        .HasColumnType("TEXT");

                    b.Property<int>("rank")
                        .HasColumnType("INTEGER");

                    b.HasKey("ID");

                    b.ToTable("Driver", (string)null);
                });

            modelBuilder.Entity("lapGen.Models.Lap", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("raceCarID")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("recordedDriverID")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("recordedLapTime")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("recordedRaceStartTime")
                        .HasColumnType("TEXT");

                    b.Property<int?>("recordedTrackID")
                        .HasColumnType("INTEGER");

                    b.HasKey("ID");

                    b.HasIndex("raceCarID");

                    b.HasIndex("recordedDriverID");

                    b.HasIndex("recordedTrackID");

                    b.ToTable("Lap", (string)null);
                });

            modelBuilder.Entity("lapGen.Models.Track", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("name")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("Track", (string)null);
                });

            modelBuilder.Entity("lapGen.Models.Lap", b =>
                {
                    b.HasOne("lapGen.Models.Car", "raceCar")
                        .WithMany()
                        .HasForeignKey("raceCarID");

                    b.HasOne("lapGen.Models.Driver", "recordedDriver")
                        .WithMany()
                        .HasForeignKey("recordedDriverID");

                    b.HasOne("lapGen.Models.Track", "recordedTrack")
                        .WithMany()
                        .HasForeignKey("recordedTrackID");

                    b.Navigation("raceCar");

                    b.Navigation("recordedDriver");

                    b.Navigation("recordedTrack");
                });
#pragma warning restore 612, 618
        }
    }
}