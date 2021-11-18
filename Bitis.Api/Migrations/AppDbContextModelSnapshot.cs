﻿// <auto-generated />
using Bitis.Api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Bitis.Api.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("bitis.mode.Category", b =>
                {
                    b.Property<int>("IdDanhMuc")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TenDanhMuc")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdDanhMuc");

                    b.ToTable("Categorys");

                    b.HasData(
                        new
                        {
                            IdDanhMuc = 1,
                            TenDanhMuc = "Giày Nam"
                        },
                        new
                        {
                            IdDanhMuc = 2,
                            TenDanhMuc = "Giày nữ"
                        },
                        new
                        {
                            IdDanhMuc = 3,
                            TenDanhMuc = "Giày thể thao"
                        },
                        new
                        {
                            IdDanhMuc = 4,
                            TenDanhMuc = "Giày Tây"
                        },
                        new
                        {
                            IdDanhMuc = 5,
                            TenDanhMuc = "Túi xách"
                        },
                        new
                        {
                            IdDanhMuc = 6,
                            TenDanhMuc = "Phụ Kiện"
                        });
                });

            modelBuilder.Entity("bitis.mode.Product", b =>
                {
                    b.Property<int>("IdSp")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ChiTietSP")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Gia")
                        .HasColumnType("int");

                    b.Property<string>("HinhSp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdDanhMuc")
                        .HasColumnType("int");

                    b.Property<string>("MaSp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MoTaSp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SoLuong")
                        .HasColumnType("int");

                    b.Property<string>("TenSp")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdSp");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            IdSp = 1,
                            ChiTietSP = "là 1 thương hiêu nổi tieeng",
                            Gia = 100000,
                            HinhSp = "asset/img/sp1.jpg",
                            IdDanhMuc = 1,
                            MaSp = "aaasss",
                            MoTaSp = "adshjklahbjjkd",
                            SoLuong = 100,
                            TenSp = "giày nam"
                        },
                        new
                        {
                            IdSp = 2,
                            ChiTietSP = "là 1 thương hiêu nổi tieeng",
                            Gia = 120000,
                            HinhSp = "asset/img/sp2.jpg",
                            IdDanhMuc = 2,
                            MaSp = "a",
                            MoTaSp = "a",
                            SoLuong = 100,
                            TenSp = "giày nam đế cao"
                        },
                        new
                        {
                            IdSp = 3,
                            ChiTietSP = "là 1 thương hiêu nổi tieeng",
                            Gia = 200000,
                            HinhSp = "asset/img/sp3.jpg",
                            IdDanhMuc = 1,
                            MaSp = "sss",
                            MoTaSp = "adsđa",
                            SoLuong = 200,
                            TenSp = "giày nu "
                        },
                        new
                        {
                            IdSp = 4,
                            ChiTietSP = "là 1 thương hiêu nổi tieeng",
                            Gia = 2030000,
                            HinhSp = "asset/img/sp4.jpg",
                            IdDanhMuc = 3,
                            MaSp = "sssccccs",
                            MoTaSp = "adsdfđfgfdfggfghnghjhghjjyhjjhđa",
                            SoLuong = 200,
                            TenSp = "giày nu ssssdsfs"
                        },
                        new
                        {
                            IdSp = 5,
                            ChiTietSP = "là 1 thương hiêu nổi tieeng",
                            Gia = 200000,
                            HinhSp = "asset/img/sp5.jpg",
                            IdDanhMuc = 4,
                            MaSp = "p",
                            MoTaSp = "adsđa",
                            SoLuong = 200,
                            TenSp = "phụ kiện "
                        },
                        new
                        {
                            IdSp = 6,
                            ChiTietSP = "là 1 thương hiêu nổi tieeng",
                            Gia = 200000,
                            HinhSp = "asset/img/sp6.jpg",
                            IdDanhMuc = 1,
                            MaSp = "faaffafaf",
                            MoTaSp = "adsđa",
                            SoLuong = 200,
                            TenSp = "túi sahs "
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
