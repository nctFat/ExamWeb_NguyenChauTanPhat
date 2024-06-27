﻿// <auto-generated />
using ExamWeb_NguyenChauTanPhat.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ExamWeb_NguyenChauTanPhat.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240627011318_InitSchema")]
    partial class InitSchema
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ExamWeb_NguyenChauTanPhat.Models.Phim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("GiaVe")
                        .HasColumnType("float");

                    b.Property<int>("ThoiLuong")
                        .HasColumnType("int");

                    b.Property<bool>("TrongNuoc")
                        .HasColumnType("bit");

                    b.Property<string>("TuaDe")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("Id");

                    b.ToTable("Phims");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            GiaVe = 12000.0,
                            ThoiLuong = 10,
                            TrongNuoc = true,
                            TuaDe = "Tro tàn rực rỡ"
                        },
                        new
                        {
                            Id = 2,
                            GiaVe = 12000.0,
                            ThoiLuong = 15,
                            TrongNuoc = false,
                            TuaDe = "MAI"
                        },
                        new
                        {
                            Id = 3,
                            GiaVe = 12000.0,
                            ThoiLuong = 10,
                            TrongNuoc = true,
                            TuaDe = "Lật mặt"
                        },
                        new
                        {
                            Id = 4,
                            GiaVe = 12000.0,
                            ThoiLuong = 15,
                            TrongNuoc = false,
                            TuaDe = "Mắt biếc"
                        },
                        new
                        {
                            Id = 5,
                            GiaVe = 12000.0,
                            ThoiLuong = 10,
                            TrongNuoc = true,
                            TuaDe = "Nhắm mắt thấy mùa hè"
                        },
                        new
                        {
                            Id = 6,
                            GiaVe = 12000.0,
                            ThoiLuong = 15,
                            TrongNuoc = true,
                            TuaDe = "Hùng long phong bá"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
