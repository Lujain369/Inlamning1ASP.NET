﻿// <auto-generated />
using System;
using Inlamning1ASP.NET.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Inlamning1ASP.NET.Migrations
{
    [DbContext(typeof(EventsDbContext))]
    partial class EventsDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AttenderEvent", b =>
                {
                    b.Property<int>("AttendersId")
                        .HasColumnType("int");

                    b.Property<int>("EventsId")
                        .HasColumnType("int");

                    b.HasKey("AttendersId", "EventsId");

                    b.HasIndex("EventsId");

                    b.ToTable("AttenderEvent");
                });

            modelBuilder.Entity("Inlamning1ASP.NET.models.Attender", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("phone_number")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Attender");
                });

            modelBuilder.Entity("Inlamning1ASP.NET.models.AttenderEvent", b =>
                {
                    b.Property<int>("AttenderEventId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AttenderId")
                        .HasColumnType("int");

                    b.Property<int>("EventId")
                        .HasColumnType("int");

                    b.HasKey("AttenderEventId");

                    b.HasIndex("AttenderId");

                    b.HasIndex("EventId");

                    b.ToTable("AttenderEvents");
                });

            modelBuilder.Entity("Inlamning1ASP.NET.models.Event", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("OrganisationId")
                        .HasColumnType("int");

                    b.Property<string>("adress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("date")
                        .HasColumnType("datetime2");

                    b.Property<string>("description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("place")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("spots_available")
                        .HasColumnType("int");

                    b.Property<string>("title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("OrganisationId");

                    b.ToTable("Event");
                });

            modelBuilder.Entity("Inlamning1ASP.NET.models.Organisation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("phone_number")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Organisation");
                });

            modelBuilder.Entity("AttenderEvent", b =>
                {
                    b.HasOne("Inlamning1ASP.NET.models.Attender", null)
                        .WithMany()
                        .HasForeignKey("AttendersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Inlamning1ASP.NET.models.Event", null)
                        .WithMany()
                        .HasForeignKey("EventsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Inlamning1ASP.NET.models.AttenderEvent", b =>
                {
                    b.HasOne("Inlamning1ASP.NET.models.Attender", "Attender")
                        .WithMany()
                        .HasForeignKey("AttenderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Inlamning1ASP.NET.models.Event", "Event")
                        .WithMany()
                        .HasForeignKey("EventId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Attender");

                    b.Navigation("Event");
                });

            modelBuilder.Entity("Inlamning1ASP.NET.models.Event", b =>
                {
                    b.HasOne("Inlamning1ASP.NET.models.Organisation", "Organisation")
                        .WithMany("Events")
                        .HasForeignKey("OrganisationId");

                    b.Navigation("Organisation");
                });

            modelBuilder.Entity("Inlamning1ASP.NET.models.Organisation", b =>
                {
                    b.Navigation("Events");
                });
#pragma warning restore 612, 618
        }
    }
}
