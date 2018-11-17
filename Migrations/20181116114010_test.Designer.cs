﻿// <auto-generated />
using System;
using CYouEcommerce.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CYouEcommerce.Migrations
{
    [DbContext(typeof(R13DbContext))]
    [Migration("20181116114010_test")]
    partial class test
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.3-rtm-32065")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CYouEcommerce.Core.EFTables.Account", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<bool>("admin");

                    b.Property<bool>("master_account");

                    b.HasKey("Id");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("CYouEcommerce.Core.EFTables.Hardware.Case", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Brand");

                    b.Property<string>("Details");

                    b.Property<string>("HardwareType")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("Model");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<float>("Price");

                    b.Property<string>("Series");

                    b.HasKey("Id");

                    b.ToTable("Cases");
                });

            modelBuilder.Entity("CYouEcommerce.Core.EFTables.Hardware.Coolingfan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Brand");

                    b.Property<string>("Details");

                    b.Property<string>("HardwareType")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("Model");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<float>("Price");

                    b.Property<string>("Series");

                    b.HasKey("Id");

                    b.ToTable("CoolingFans");
                });

            modelBuilder.Entity("CYouEcommerce.Core.EFTables.Hardware.CPU", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Brand");

                    b.Property<string>("Details");

                    b.Property<string>("HardwareType")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("Model");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<float>("Price");

                    b.Property<string>("Series");

                    b.HasKey("Id");

                    b.ToTable("CPUs");
                });

            modelBuilder.Entity("CYouEcommerce.Core.EFTables.Hardware.GPU", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Brand");

                    b.Property<string>("Details");

                    b.Property<string>("HardwareType")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("Model");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<float>("Price");

                    b.Property<string>("Series");

                    b.HasKey("Id");

                    b.ToTable("GPUs");
                });

            modelBuilder.Entity("CYouEcommerce.Core.EFTables.Hardware.Motherboard", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Brand");

                    b.Property<string>("Details");

                    b.Property<string>("HardwareType")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("Model");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<float>("Price");

                    b.Property<string>("Series");

                    b.HasKey("Id");

                    b.ToTable("Motherboards");
                });

            modelBuilder.Entity("CYouEcommerce.Core.EFTables.Hardware.Powersupply", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Brand");

                    b.Property<string>("Details");

                    b.Property<string>("HardwareType")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("Model");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<float>("Price");

                    b.Property<string>("Series");

                    b.HasKey("Id");

                    b.ToTable("PowerSupplys");
                });

            modelBuilder.Entity("CYouEcommerce.Core.EFTables.Hardware.RAM", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Brand");

                    b.Property<string>("Details");

                    b.Property<string>("HardwareType")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("Model");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<float>("Price");

                    b.Property<string>("Series");

                    b.HasKey("Id");

                    b.ToTable("RAMs");
                });

            modelBuilder.Entity("CYouEcommerce.Core.EFTables.Hardware.Storage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Brand");

                    b.Property<string>("Details");

                    b.Property<string>("HardwareType")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("Model");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<float>("Price");

                    b.Property<string>("Series");

                    b.HasKey("Id");

                    b.ToTable("Storages");
                });

            modelBuilder.Entity("CYouEcommerce.Core.EFTables.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AccountInfoOrderId");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("CPU")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("Case")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("Cooling_Fan")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("GPU")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("Motherboard")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("OrderDate");

                    b.Property<int>("Order_Number");

                    b.Property<string>("Power_Supply")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("RAM")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("State")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("Storage")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<float>("Total_Price");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("ZipCode")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("AccountInfoOrderId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("CYouEcommerce.Core.EFTables.Photo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FileName")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<int?>("SaleItemId");

                    b.Property<int>("itemId");

                    b.HasKey("Id");

                    b.HasIndex("SaleItemId");

                    b.ToTable("Photos");
                });

            modelBuilder.Entity("CYouEcommerce.Core.EFTables.SaleItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AccountSaleItemId");

                    b.Property<string>("CPU")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("Case")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("Cooling_Fan")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("GPU")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("Motherboard")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("Power_Supply")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("RAM")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("SellerName")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("Storage")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<float>("Total_Price");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.HasIndex("AccountSaleItemId");

                    b.ToTable("SaleItems");
                });

            modelBuilder.Entity("CYouEcommerce.Core.EFTables.Order", b =>
                {
                    b.HasOne("CYouEcommerce.Core.EFTables.Account", "AccountInfoOrder")
                        .WithMany("Orders")
                        .HasForeignKey("AccountInfoOrderId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CYouEcommerce.Core.EFTables.Photo", b =>
                {
                    b.HasOne("CYouEcommerce.Core.EFTables.SaleItem")
                        .WithMany("Photos")
                        .HasForeignKey("SaleItemId");
                });

            modelBuilder.Entity("CYouEcommerce.Core.EFTables.SaleItem", b =>
                {
                    b.HasOne("CYouEcommerce.Core.EFTables.Account", "AccountSaleItem")
                        .WithMany("ItemForSales")
                        .HasForeignKey("AccountSaleItemId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}