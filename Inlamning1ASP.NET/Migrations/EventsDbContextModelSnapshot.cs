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

            modelBuilder.Entity("Inlamning1ASP.NET.models.Event", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AttenderId")
                        .HasColumnType("int");

                    b.Property<int?>("OrganisationId")
                        .HasColumnType("int");

                    b.Property<string>("adress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("date")
                        .HasColumnType("datetime2");

                    b.Property<string>("description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("organisation_id")
                        .HasColumnType("int");

                    b.Property<string>("place")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("spots_available")
                        .HasColumnType("int");

                    b.Property<string>("title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AttenderId");

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

            modelBuilder.Entity("Inlamning1ASP.NET.models.Event", b =>
                {
                    b.HasOne("Inlamning1ASP.NET.models.Attender", null)
                        .WithMany("Events")
                        .HasForeignKey("AttenderId");

                    b.HasOne("Inlamning1ASP.NET.models.Organisation", null)
                        .WithMany("Events")
                        .HasForeignKey("OrganisationId");
                });

            modelBuilder.Entity("Inlamning1ASP.NET.models.Attender", b =>
                {
                    b.Navigation("Events");
                });

            modelBuilder.Entity("Inlamning1ASP.NET.models.Organisation", b =>
                {
                    b.Navigation("Events");
                });
#pragma warning restore 612, 618
        }
    }
}