﻿// <auto-generated />
using System;
using Hotel.App.Data.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Hotel.App.Data.Migrations
{
    [DbContext(typeof(HotelDbContext))]
    partial class HotelDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Hotel.App.Data.Entity.Guest", b =>
                {
                    b.Property<int>("GuestId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GuestId"), 1L, 1);

                    b.Property<string>("Adress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Emile")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GuestFirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GuestLastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pasbort")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GuestId");

                    b.ToTable("Guests");
                });

            modelBuilder.Entity("Hotel.App.Data.Entity.OtherType", b =>
                {
                    b.Property<int>("OtherTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OtherTypeId"), 1L, 1);

                    b.Property<string>("OtherTypeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("OtherTypeId");

                    b.ToTable("OtherType");
                });

            modelBuilder.Entity("Hotel.App.Data.Entity.Payment", b =>
                {
                    b.Property<int>("PaymentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PaymentId"), 1L, 1);

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("ResvationId")
                        .HasColumnType("int");

                    b.HasKey("PaymentId");

                    b.HasIndex("ResvationId");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("Hotel.App.Data.Entity.Resvation", b =>
                {
                    b.Property<int>("ResvationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ResvationId"), 1L, 1);

                    b.Property<int>("Adult")
                        .HasColumnType("int");

                    b.Property<DateTime>("CheckIn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CheckOut")
                        .HasColumnType("datetime2");

                    b.Property<int>("Child")
                        .HasColumnType("int");

                    b.Property<int>("GuestId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ResvationDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("RoomId")
                        .HasColumnType("int");

                    b.HasKey("ResvationId");

                    b.HasIndex("GuestId");

                    b.HasIndex("RoomId");

                    b.ToTable("Resvations");
                });

            modelBuilder.Entity("Hotel.App.Data.Entity.Room", b =>
                {
                    b.Property<int>("RoomId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RoomId"), 1L, 1);

                    b.Property<int>("OtherTypeId")
                        .HasColumnType("int");

                    b.Property<int>("RoomStutasId")
                        .HasColumnType("int");

                    b.Property<int>("RoomTypeId")
                        .HasColumnType("int");

                    b.HasKey("RoomId");

                    b.HasIndex("OtherTypeId");

                    b.HasIndex("RoomStutasId");

                    b.HasIndex("RoomTypeId");

                    b.ToTable("Rooms");
                });

            modelBuilder.Entity("Hotel.App.Data.Entity.RoomStutas", b =>
                {
                    b.Property<int>("RoomStutasId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RoomStutasId"), 1L, 1);

                    b.Property<string>("RoomStutasName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RoomStutasId");

                    b.ToTable("RoomStutas");
                });

            modelBuilder.Entity("Hotel.App.Data.Entity.RoomType", b =>
                {
                    b.Property<int>("RoomTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RoomTypeId"), 1L, 1);

                    b.Property<string>("RoomTypeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RoomTypeId");

                    b.ToTable("RoomTypes");
                });

            modelBuilder.Entity("Hotel.App.Data.Entity.Payment", b =>
                {
                    b.HasOne("Hotel.App.Data.Entity.Resvation", "Resvation")
                        .WithMany()
                        .HasForeignKey("ResvationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Resvation");
                });

            modelBuilder.Entity("Hotel.App.Data.Entity.Resvation", b =>
                {
                    b.HasOne("Hotel.App.Data.Entity.Guest", "Guest")
                        .WithMany()
                        .HasForeignKey("GuestId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Hotel.App.Data.Entity.Room", "Room")
                        .WithMany()
                        .HasForeignKey("RoomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Guest");

                    b.Navigation("Room");
                });

            modelBuilder.Entity("Hotel.App.Data.Entity.Room", b =>
                {
                    b.HasOne("Hotel.App.Data.Entity.OtherType", "OtherType")
                        .WithMany()
                        .HasForeignKey("OtherTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Hotel.App.Data.Entity.RoomStutas", "RoomStutas")
                        .WithMany()
                        .HasForeignKey("RoomStutasId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Hotel.App.Data.Entity.RoomType", "RoomType")
                        .WithMany()
                        .HasForeignKey("RoomTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("OtherType");

                    b.Navigation("RoomStutas");

                    b.Navigation("RoomType");
                });
#pragma warning restore 612, 618
        }
    }
}
