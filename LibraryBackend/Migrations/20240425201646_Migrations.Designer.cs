﻿// <auto-generated />
using System;
using LibraryBackend.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LibraryBackend.Migrations
{
    [DbContext(typeof(LibraryBackendContext))]
    [Migration("20240425201646_Migrations")]
    partial class Migrations
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Proxies:ChangeTracking", false)
                .HasAnnotation("Proxies:CheckEquality", false)
                .HasAnnotation("Proxies:LazyLoading", true);

            modelBuilder.Entity("LibraryBackend.Classes.Book", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Author")
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("Publisher")
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("YearOfPublication")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Book");
                });

            modelBuilder.Entity("LibraryBackend.Classes.Loan", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("BookId")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("BorrowingDate")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("ReturnDeadLine")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Loan");
                });

            modelBuilder.Entity("LibraryBackend.Classes.Reading", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Address")
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Reading");
                });
#pragma warning restore 612, 618
        }
    }
}
