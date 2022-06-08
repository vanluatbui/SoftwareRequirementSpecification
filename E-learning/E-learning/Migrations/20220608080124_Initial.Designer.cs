﻿// <auto-generated />
using System;
using E_learning;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace E_learning.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220608080124_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("E_learning.Models.AspNetUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("E_learning.Models.Diem_HocSinh", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("DanhGia")
                        .HasColumnType("int");

                    b.Property<double>("DiemChuyenCan")
                        .HasColumnType("float");

                    b.Property<double>("DiemHeSo2")
                        .HasColumnType("float");

                    b.Property<double>("DiemHeSo3")
                        .HasColumnType("float");

                    b.Property<double>("DiemMieng")
                        .HasColumnType("float");

                    b.Property<double>("DiemTrungBinh")
                        .HasColumnType("float");

                    b.Property<string>("HocSinhId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<Guid>("MonHocID_MonHoc")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("NgayCapNhat")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.HasIndex("HocSinhId");

                    b.HasIndex("MonHocID_MonHoc");

                    b.ToTable("Diem_HocSinhs");
                });

            modelBuilder.Entity("E_learning.Models.HinhThuc_Thi_KiemTra", b =>
                {
                    b.Property<Guid>("ID_HinhThuc")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("TenHinhThuc")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ID_HinhThuc");

                    b.ToTable("HinhThuc_Thi_KiemTras");
                });

            modelBuilder.Entity("E_learning.Models.KhoaHoc", b =>
                {
                    b.Property<Guid>("ID_KhoaHoc")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("NienKhoaHoc")
                        .IsRequired()
                        .HasMaxLength(9)
                        .HasColumnType("nvarchar(9)");

                    b.Property<string>("TenKhoaHoc")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ID_KhoaHoc");

                    b.ToTable("KhoaHocs");
                });

            modelBuilder.Entity("E_learning.Models.Lop", b =>
                {
                    b.Property<Guid>("ID_Lop")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("BaoMat")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ChuDe")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("GiaoVienId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<Guid>("KhoaHocID_KhoaHoc")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Link")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("MoTa")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("NgayBatDau")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("NgayKetThuc")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("TenLop")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("ThoiLuongHoc")
                        .HasColumnType("int");

                    b.HasKey("ID_Lop");

                    b.HasIndex("GiaoVienId");

                    b.HasIndex("KhoaHocID_KhoaHoc");

                    b.ToTable("Lops");
                });

            modelBuilder.Entity("E_learning.Models.Lop_HocSinh", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("HocSinhId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<Guid>("LopID_Lop")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("NgayThamGia")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.HasIndex("HocSinhId");

                    b.HasIndex("LopID_Lop");

                    b.ToTable("Lop_HocSinhs");
                });

            modelBuilder.Entity("E_learning.Models.Lop_MonHoc", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("BaoMat")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("GiaoVienId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Link")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<Guid>("LopID_Lop")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("MonHocID_MonHoc")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("NgayBatDau")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("NgayKetThuc")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<int>("ThoiLuongHoc")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("GiaoVienId");

                    b.HasIndex("LopID_Lop");

                    b.HasIndex("MonHocID_MonHoc");

                    b.ToTable("Lop_MonHocs");
                });

            modelBuilder.Entity("E_learning.Models.Lop_Thi_KiemTra", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ChuDe")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("FileTestName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<Guid>("HinhThucID_HinhThuc")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("LopID_Lop")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("MoTa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("MonHocID_MonHoc")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("NgayKiemTra")
                        .HasColumnType("datetime2");

                    b.Property<string>("NoiDung")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<int>("ThoiLuong")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("HinhThucID_HinhThuc");

                    b.HasIndex("LopID_Lop");

                    b.HasIndex("MonHocID_MonHoc");

                    b.ToTable("Lop_Thi_KiemTras");
                });

            modelBuilder.Entity("E_learning.Models.MonHoc", b =>
                {
                    b.Property<Guid>("ID_MonHoc")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("MoTa")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("TenMonHoc")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ID_MonHoc");

                    b.ToTable("MonHocs");
                });

            modelBuilder.Entity("E_learning.Models.ThoiKhoaBieu", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("LopID_Lop")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("MonHocID_MonHoc")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("SoTiet")
                        .HasColumnType("int");

                    b.Property<string>("ThoiGianHoc")
                        .IsRequired()
                        .HasMaxLength(12)
                        .HasColumnType("nvarchar(12)");

                    b.HasKey("ID");

                    b.HasIndex("LopID_Lop");

                    b.HasIndex("MonHocID_MonHoc");

                    b.ToTable("ThoiKhoaBieus");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("E_learning.Models.Diem_HocSinh", b =>
                {
                    b.HasOne("E_learning.Models.AspNetUser", "HocSinh")
                        .WithMany()
                        .HasForeignKey("HocSinhId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("E_learning.Models.MonHoc", "MonHoc")
                        .WithMany()
                        .HasForeignKey("MonHocID_MonHoc")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("HocSinh");

                    b.Navigation("MonHoc");
                });

            modelBuilder.Entity("E_learning.Models.Lop", b =>
                {
                    b.HasOne("E_learning.Models.AspNetUser", "GiaoVien")
                        .WithMany()
                        .HasForeignKey("GiaoVienId");

                    b.HasOne("E_learning.Models.KhoaHoc", "KhoaHoc")
                        .WithMany()
                        .HasForeignKey("KhoaHocID_KhoaHoc")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("GiaoVien");

                    b.Navigation("KhoaHoc");
                });

            modelBuilder.Entity("E_learning.Models.Lop_HocSinh", b =>
                {
                    b.HasOne("E_learning.Models.AspNetUser", "HocSinh")
                        .WithMany()
                        .HasForeignKey("HocSinhId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("E_learning.Models.Lop", "Lop")
                        .WithMany()
                        .HasForeignKey("LopID_Lop")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("HocSinh");

                    b.Navigation("Lop");
                });

            modelBuilder.Entity("E_learning.Models.Lop_MonHoc", b =>
                {
                    b.HasOne("E_learning.Models.AspNetUser", "GiaoVien")
                        .WithMany()
                        .HasForeignKey("GiaoVienId");

                    b.HasOne("E_learning.Models.Lop", "Lop")
                        .WithMany()
                        .HasForeignKey("LopID_Lop")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("E_learning.Models.MonHoc", "MonHoc")
                        .WithMany()
                        .HasForeignKey("MonHocID_MonHoc")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("GiaoVien");

                    b.Navigation("Lop");

                    b.Navigation("MonHoc");
                });

            modelBuilder.Entity("E_learning.Models.Lop_Thi_KiemTra", b =>
                {
                    b.HasOne("E_learning.Models.HinhThuc_Thi_KiemTra", "HinhThuc")
                        .WithMany()
                        .HasForeignKey("HinhThucID_HinhThuc")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("E_learning.Models.Lop", "Lop")
                        .WithMany()
                        .HasForeignKey("LopID_Lop")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("E_learning.Models.MonHoc", "MonHoc")
                        .WithMany()
                        .HasForeignKey("MonHocID_MonHoc")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("HinhThuc");

                    b.Navigation("Lop");

                    b.Navigation("MonHoc");
                });

            modelBuilder.Entity("E_learning.Models.ThoiKhoaBieu", b =>
                {
                    b.HasOne("E_learning.Models.Lop", "Lop")
                        .WithMany()
                        .HasForeignKey("LopID_Lop")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("E_learning.Models.MonHoc", "MonHoc")
                        .WithMany()
                        .HasForeignKey("MonHocID_MonHoc")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Lop");

                    b.Navigation("MonHoc");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("E_learning.Models.AspNetUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("E_learning.Models.AspNetUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("E_learning.Models.AspNetUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("E_learning.Models.AspNetUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
