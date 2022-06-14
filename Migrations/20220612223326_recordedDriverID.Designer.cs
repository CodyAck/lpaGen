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
    [Migration("20220612223326_recordedDriverID")]
    partial class recordedDriverID
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

                    b.Property<bool>("active")
                        .HasColumnType("INTEGER");

                    b.Property<int>("currentDriver")
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

                    b.Property<int?>("CarID")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("active")
                        .HasColumnType("INTEGER");

                    b.Property<string>("name")
                        .HasColumnType("TEXT");

                    b.Property<int>("rank")
                        .HasColumnType("INTEGER");

                    b.HasKey("ID");

                    b.HasIndex("CarID");

                    b.ToTable("Driver", (string)null);
                });

            modelBuilder.Entity("lapGen.Models.Lap", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("carID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("raceID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("recordedDriverID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("recordedLapTime")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.HasIndex("carID");

                    b.HasIndex("raceID");

                    b.HasIndex("recordedDriverID");

                    b.ToTable("Lap", (string)null);
                });

            modelBuilder.Entity("lapGen.Models.Race", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("active")
                        .HasColumnType("INTEGER");

                    b.Property<string>("name")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("recordedRaceStartTime")
                        .HasColumnType("TEXT");

                    b.Property<int>("trackID")
                        .HasColumnType("INTEGER");

                    b.HasKey("ID");

                    b.HasIndex("trackID");

                    b.ToTable("Race", (string)null);
                });

            modelBuilder.Entity("lapGen.Models.Track", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("active")
                        .HasColumnType("INTEGER");

                    b.Property<string>("name")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("Track", (string)null);
                });

            modelBuilder.Entity("lapGen.Models.Driver", b =>
                {
                    b.HasOne("lapGen.Models.Car", null)
                        .WithMany("possibleDrivers")
                        .HasForeignKey("CarID");
                });

            modelBuilder.Entity("lapGen.Models.Lap", b =>
                {
                    b.HasOne("lapGen.Models.Car", "car")
                        .WithMany()
                        .HasForeignKey("carID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("lapGen.Models.Race", "race")
                        .WithMany()
                        .HasForeignKey("raceID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("lapGen.Models.Driver", "recordedDriver")
                        .WithMany()
                        .HasForeignKey("recordedDriverID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("car");

                    b.Navigation("race");

                    b.Navigation("recordedDriver");
                });

            modelBuilder.Entity("lapGen.Models.Race", b =>
                {
                    b.HasOne("lapGen.Models.Track", "track")
                        .WithMany()
                        .HasForeignKey("trackID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("track");
                });

            modelBuilder.Entity("lapGen.Models.Car", b =>
                {
                    b.Navigation("possibleDrivers");
                });
#pragma warning restore 612, 618
        }
    }
}
