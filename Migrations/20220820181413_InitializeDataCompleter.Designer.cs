﻿// <auto-generated />
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
    [Migration("20220820181413_InitializeDataCompleter")]
    partial class InitializeDataCompleter
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

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

                    b.ToTable("User");
                });
#pragma warning restore 612, 618
        }
    }
}
