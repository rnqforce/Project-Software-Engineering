﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TenantsAssociation.DataAccess;

namespace TenantsAssociation.DataAccess.Migrations
{
    [DbContext(typeof(TenantsAssociationDbContext))]
    [Migration("20200415081453_migration15")]
    partial class migration15
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TenantsAssociation.ApplicationLogic.DataModel.Administrator", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Administrators");
                });

            modelBuilder.Entity("TenantsAssociation.ApplicationLogic.DataModel.Apartment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("ApartmentNumber")
                        .HasColumnType("int");

                    b.Property<Guid?>("BuildingId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("BuildingId");

                    b.HasIndex("UserId");

                    b.ToTable("Apartments");
                });

            modelBuilder.Entity("TenantsAssociation.ApplicationLogic.DataModel.Building", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("AdministratorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("BuildingNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Street")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StreetNumber")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AdministratorId");

                    b.ToTable("Building");
                });

            modelBuilder.Entity("TenantsAssociation.ApplicationLogic.DataModel.Invoice", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ApartmentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<float>("Bill")
                        .HasColumnType("real");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("Date");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DueDate")
                        .HasColumnType("Date");

                    b.Property<int>("InvoiceNumber")
                        .HasColumnType("int");

                    b.Property<DateTime>("PayDate")
                        .HasColumnType("Date");

                    b.HasKey("Id");

                    b.HasIndex("ApartmentId");

                    b.ToTable("Invoices");
                });

            modelBuilder.Entity("TenantsAssociation.ApplicationLogic.DataModel.Poll", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("BuildingId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Question")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("BuildingId");

                    b.ToTable("Polls");
                });

            modelBuilder.Entity("TenantsAssociation.ApplicationLogic.DataModel.PollResults", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Answer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("PollId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("PollId");

                    b.ToTable("PollResults");
                });

            modelBuilder.Entity("TenantsAssociation.ApplicationLogic.DataModel.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("TenantsAssociation.ApplicationLogic.DataModel.Apartment", b =>
                {
                    b.HasOne("TenantsAssociation.ApplicationLogic.DataModel.Building", "Building")
                        .WithMany()
                        .HasForeignKey("BuildingId");

                    b.HasOne("TenantsAssociation.ApplicationLogic.DataModel.User", null)
                        .WithMany("Apartments")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TenantsAssociation.ApplicationLogic.DataModel.Building", b =>
                {
                    b.HasOne("TenantsAssociation.ApplicationLogic.DataModel.Administrator", null)
                        .WithMany("Buildings")
                        .HasForeignKey("AdministratorId");
                });

            modelBuilder.Entity("TenantsAssociation.ApplicationLogic.DataModel.Invoice", b =>
                {
                    b.HasOne("TenantsAssociation.ApplicationLogic.DataModel.Apartment", null)
                        .WithMany("Invoices")
                        .HasForeignKey("ApartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TenantsAssociation.ApplicationLogic.DataModel.Poll", b =>
                {
                    b.HasOne("TenantsAssociation.ApplicationLogic.DataModel.Building", null)
                        .WithMany("Polls")
                        .HasForeignKey("BuildingId");
                });

            modelBuilder.Entity("TenantsAssociation.ApplicationLogic.DataModel.PollResults", b =>
                {
                    b.HasOne("TenantsAssociation.ApplicationLogic.DataModel.Poll", "Poll")
                        .WithMany()
                        .HasForeignKey("PollId");
                });
#pragma warning restore 612, 618
        }
    }
}
