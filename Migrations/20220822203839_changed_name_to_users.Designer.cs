﻿// <auto-generated />
using System;
using Janus_API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Janus_API.Migrations
{
    [DbContext(typeof(Janus_APIContext))]
    [Migration("20220822203839_changed_name_to_users")]
    partial class changed_name_to_users
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Janus_API.Models.Asset", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AssetTypeId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Exchange")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Symbol")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AssetTypeId");

                    b.HasIndex("UserId");

                    b.ToTable("Assets");
                });

            modelBuilder.Entity("Janus_API.Models.AssetType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .HasColumnType("VARCHAR(150)");

                    b.Property<string>("Name")
                        .HasColumnType("VARCHAR(50)");

                    b.HasKey("Id");

                    b.ToTable("AssetTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Stock",
                            Name = "Stock"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Crypto Currency",
                            Name = "Crypto"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Stock Options",
                            Name = "Options"
                        },
                        new
                        {
                            Id = 4,
                            Description = "US Dollars",
                            Name = "Cash"
                        },
                        new
                        {
                            Id = 5,
                            Description = "Non-fungible tokens",
                            Name = "NFT"
                        });
                });

            modelBuilder.Entity("Janus_API.Models.Transaction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("AssetId")
                        .HasColumnType("int");

                    b.Property<decimal>("Fee1")
                        .HasPrecision(38, 8)
                        .HasColumnType("decimal(38,8)");

                    b.Property<decimal>("Fee2")
                        .HasPrecision(38, 8)
                        .HasColumnType("decimal(38,8)");

                    b.Property<decimal>("Quantity")
                        .HasPrecision(38, 8)
                        .HasColumnType("decimal(38,8)");

                    b.Property<decimal>("Total")
                        .HasPrecision(38, 8)
                        .HasColumnType("decimal(38,8)");

                    b.Property<int>("TransactionTypeId")
                        .HasColumnType("int");

                    b.Property<decimal>("UnitPrice")
                        .HasPrecision(38, 8)
                        .HasColumnType("decimal(38,8)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AssetId");

                    b.HasIndex("TransactionTypeId");

                    b.HasIndex("UserId");

                    b.ToTable("Transactions");
                });

            modelBuilder.Entity("Janus_API.Models.TransactionType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .HasColumnType("VARCHAR(150)");

                    b.Property<string>("Name")
                        .HasColumnType("VARCHAR(50)");

                    b.HasKey("Id");

                    b.ToTable("TransactionTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Purchase Asset",
                            Name = "Buy"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Sell Asset",
                            Name = "Sell"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Deposit",
                            Name = "Deposit"
                        },
                        new
                        {
                            Id = 4,
                            Description = "Withdraw",
                            Name = "Withdraw"
                        });
                });

            modelBuilder.Entity("Janus_API.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .HasColumnType("VARCHAR(200)");

                    b.Property<string>("FirstName")
                        .HasColumnType("VARCHAR(100)");

                    b.Property<string>("LastName")
                        .HasColumnType("VARCHAR(100)");

                    b.Property<string>("Phone1")
                        .HasColumnType("VARCHAR(50)");

                    b.Property<string>("Phone2")
                        .HasColumnType("VARCHAR(50)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Janus_API.Models.Asset", b =>
                {
                    b.HasOne("Janus_API.Models.AssetType", "AssetType")
                        .WithMany("Assets")
                        .HasForeignKey("AssetTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Janus_API.Models.User", "User")
                        .WithMany("Assets")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AssetType");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Janus_API.Models.Transaction", b =>
                {
                    b.HasOne("Janus_API.Models.Asset", "Asset")
                        .WithMany("Transactions")
                        .HasForeignKey("AssetId");

                    b.HasOne("Janus_API.Models.TransactionType", "TransactionType")
                        .WithMany("Transactions")
                        .HasForeignKey("TransactionTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Janus_API.Models.User", "User")
                        .WithMany("Transactions")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Asset");

                    b.Navigation("TransactionType");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Janus_API.Models.Asset", b =>
                {
                    b.Navigation("Transactions");
                });

            modelBuilder.Entity("Janus_API.Models.AssetType", b =>
                {
                    b.Navigation("Assets");
                });

            modelBuilder.Entity("Janus_API.Models.TransactionType", b =>
                {
                    b.Navigation("Transactions");
                });

            modelBuilder.Entity("Janus_API.Models.User", b =>
                {
                    b.Navigation("Assets");

                    b.Navigation("Transactions");
                });
#pragma warning restore 612, 618
        }
    }
}