﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistence.Context;

#nullable disable

namespace Persistence.Migrations
{
    [DbContext(typeof(AtrkContext))]
    [Migration("20221110163733_SixthCreate")]
    partial class SixthCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Domen.Models.Client", b =>
                {
                    b.Property<int>("ClientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ClientId"), 1L, 1);

                    b.Property<string>("ClientRole")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ClientId");

                    b.ToTable("Client");
                });

            modelBuilder.Entity("Domen.Models.Interval", b =>
                {
                    b.Property<int>("IntervalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IntervalId"), 1L, 1);

                    b.Property<int>("IntervalNumber")
                        .HasColumnType("int");

                    b.HasKey("IntervalId");

                    b.ToTable("Interval");
                });

            modelBuilder.Entity("Domen.Models.Line", b =>
                {
                    b.Property<int>("LineId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LineId"), 1L, 1);

                    b.Property<int?>("IntervalId")
                        .HasColumnType("int");

                    b.Property<string>("LineColor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PeriodId")
                        .HasColumnType("int");

                    b.HasKey("LineId");

                    b.HasIndex("IntervalId");

                    b.HasIndex("PeriodId");

                    b.ToTable("Line");
                });

            modelBuilder.Entity("Domen.Models.Period", b =>
                {
                    b.Property<int>("PeriodId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PeriodId"), 1L, 1);

                    b.Property<DateTime>("TimeFrom")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("TimeTo")
                        .HasColumnType("datetime2");

                    b.HasKey("PeriodId");

                    b.ToTable("Period");
                });

            modelBuilder.Entity("Domen.Models.Price", b =>
                {
                    b.Property<int>("PriceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PriceId"), 1L, 1);

                    b.Property<int>("Cost")
                        .HasColumnType("int");

                    b.Property<string>("ZoneName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PriceId");

                    b.ToTable("Price");
                });

            modelBuilder.Entity("Domen.Models.Road", b =>
                {
                    b.Property<int>("RoadId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RoadId"), 1L, 1);

                    b.Property<int>("StationIdX")
                        .HasColumnType("int");

                    b.Property<int>("StationIdY")
                        .HasColumnType("int");

                    b.HasKey("RoadId");

                    b.ToTable("Road");
                });

            modelBuilder.Entity("Domen.Models.Station", b =>
                {
                    b.Property<int>("StationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StationId"), 1L, 1);

                    b.Property<string>("CoordinatesXa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CoordinatesXb")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LineId")
                        .HasColumnType("int");

                    b.Property<string>("StationName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StationId");

                    b.HasIndex("LineId");

                    b.ToTable("Station");
                });

            modelBuilder.Entity("Domen.Models.Timetable", b =>
                {
                    b.Property<int>("TimetableId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TimetableId"), 1L, 1);

                    b.Property<DateTime>("Beginning")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Ending")
                        .HasColumnType("datetime2");

                    b.Property<int>("StationId")
                        .HasColumnType("int");

                    b.Property<int?>("TransportId")
                        .HasColumnType("int");

                    b.HasKey("TimetableId");

                    b.HasIndex("StationId");

                    b.HasIndex("TransportId");

                    b.ToTable("Timetable");
                });

            modelBuilder.Entity("Domen.Models.Transport", b =>
                {
                    b.Property<int>("TransportId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TransportId"), 1L, 1);

                    b.Property<string>("CitName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Speed")
                        .HasColumnType("decimal(18,4)");

                    b.Property<int>("TransportNumber")
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TransportId");

                    b.ToTable("Transport");
                });

            modelBuilder.Entity("Domen.Models.Trip", b =>
                {
                    b.Property<int>("TripId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TripId"), 1L, 1);

                    b.Property<int>("ClientId")
                        .HasColumnType("int");

                    b.Property<int>("PriceId")
                        .HasColumnType("int");

                    b.Property<int>("RoadId")
                        .HasColumnType("int");

                    b.Property<int>("TransportId")
                        .HasColumnType("int");

                    b.HasKey("TripId");

                    b.HasIndex("ClientId");

                    b.HasIndex("PriceId");

                    b.HasIndex("RoadId");

                    b.HasIndex("TransportId");

                    b.ToTable("Trip");
                });

            modelBuilder.Entity("Domen.Models.Line", b =>
                {
                    b.HasOne("Domen.Models.Interval", "Interval")
                        .WithMany("Lines")
                        .HasForeignKey("IntervalId");

                    b.HasOne("Domen.Models.Period", "Period")
                        .WithMany("Lines")
                        .HasForeignKey("PeriodId");

                    b.Navigation("Interval");

                    b.Navigation("Period");
                });

            modelBuilder.Entity("Domen.Models.Station", b =>
                {
                    b.HasOne("Domen.Models.Line", "Line")
                        .WithMany("Stations")
                        .HasForeignKey("LineId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Line");
                });

            modelBuilder.Entity("Domen.Models.Timetable", b =>
                {
                    b.HasOne("Domen.Models.Station", "Station")
                        .WithMany("Timetables")
                        .HasForeignKey("StationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domen.Models.Transport", "Transport")
                        .WithMany("Timetables")
                        .HasForeignKey("TransportId");

                    b.Navigation("Station");

                    b.Navigation("Transport");
                });

            modelBuilder.Entity("Domen.Models.Trip", b =>
                {
                    b.HasOne("Domen.Models.Client", "Client")
                        .WithMany("Trips")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domen.Models.Price", "Price")
                        .WithMany("Tripes")
                        .HasForeignKey("PriceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domen.Models.Road", "Road")
                        .WithMany("Tripes")
                        .HasForeignKey("RoadId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domen.Models.Transport", "Transport")
                        .WithMany("Tripes")
                        .HasForeignKey("TransportId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");

                    b.Navigation("Price");

                    b.Navigation("Road");

                    b.Navigation("Transport");
                });

            modelBuilder.Entity("Domen.Models.Client", b =>
                {
                    b.Navigation("Trips");
                });

            modelBuilder.Entity("Domen.Models.Interval", b =>
                {
                    b.Navigation("Lines");
                });

            modelBuilder.Entity("Domen.Models.Line", b =>
                {
                    b.Navigation("Stations");
                });

            modelBuilder.Entity("Domen.Models.Period", b =>
                {
                    b.Navigation("Lines");
                });

            modelBuilder.Entity("Domen.Models.Price", b =>
                {
                    b.Navigation("Tripes");
                });

            modelBuilder.Entity("Domen.Models.Road", b =>
                {
                    b.Navigation("Tripes");
                });

            modelBuilder.Entity("Domen.Models.Station", b =>
                {
                    b.Navigation("Timetables");
                });

            modelBuilder.Entity("Domen.Models.Transport", b =>
                {
                    b.Navigation("Timetables");

                    b.Navigation("Tripes");
                });
#pragma warning restore 612, 618
        }
    }
}
