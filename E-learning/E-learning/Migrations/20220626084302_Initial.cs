﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace E_learning.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    HoTen = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GioiTinh = table.Column<bool>(type: "bit", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HinhThuc_Thi_KiemTras",
                columns: table => new
                {
                    ID_HinhThuc = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenHinhThuc = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HinhThuc_Thi_KiemTras", x => x.ID_HinhThuc);
                });

            migrationBuilder.CreateTable(
                name: "KhoaHocs",
                columns: table => new
                {
                    ID_KhoaHoc = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenKhoaHoc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NienKhoaHoc = table.Column<string>(type: "nvarchar(9)", maxLength: 9, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhoaHocs", x => x.ID_KhoaHoc);
                });

            migrationBuilder.CreateTable(
                name: "MonHocs",
                columns: table => new
                {
                    ID_MonHoc = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenMonHoc = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    MoTa = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonHocs", x => x.ID_MonHoc);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Lops",
                columns: table => new
                {
                    ID_Lop = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenLop = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ChuDe = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    MoTa = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    NgayBatDau = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgayKetThuc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ThoiLuongHoc = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    BaoMat = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Link = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ID_GiaoVien = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ID_KhoaHoc = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lops", x => x.ID_Lop);
                    table.ForeignKey(
                        name: "FK_Lops_AspNetUsers_ID_GiaoVien",
                        column: x => x.ID_GiaoVien,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Lops_KhoaHocs_ID_KhoaHoc",
                        column: x => x.ID_KhoaHoc,
                        principalTable: "KhoaHocs",
                        principalColumn: "ID_KhoaHoc");
                });

            migrationBuilder.CreateTable(
                name: "Diem_HocSinhs",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ID_HocSinh = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ID_MonHoc = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DiemChuyenCan = table.Column<double>(type: "float", nullable: false),
                    DiemMieng = table.Column<double>(type: "float", nullable: false),
                    DiemHeSo2 = table.Column<double>(type: "float", nullable: false),
                    DiemHeSo3 = table.Column<double>(type: "float", nullable: false),
                    DiemTrungBinh = table.Column<double>(type: "float", nullable: false),
                    DanhGia = table.Column<int>(type: "int", nullable: false),
                    NgayCapNhat = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Diem_HocSinhs", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Diem_HocSinhs_AspNetUsers_ID_HocSinh",
                        column: x => x.ID_HocSinh,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Diem_HocSinhs_MonHocs_ID_MonHoc",
                        column: x => x.ID_MonHoc,
                        principalTable: "MonHocs",
                        principalColumn: "ID_MonHoc");
                });

            migrationBuilder.CreateTable(
                name: "Lop_HocSinhs",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ID_Lop = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ID_HocSinh = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    NgayThamGia = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lop_HocSinhs", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Lop_HocSinhs_AspNetUsers_ID_HocSinh",
                        column: x => x.ID_HocSinh,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Lop_HocSinhs_Lops_ID_Lop",
                        column: x => x.ID_Lop,
                        principalTable: "Lops",
                        principalColumn: "ID_Lop");
                });

            migrationBuilder.CreateTable(
                name: "Lop_MonHocs",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ID_Lop = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ID_MonHoc = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ThoiLuongHoc = table.Column<int>(type: "int", nullable: false),
                    NgayBatDau = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgayKetThuc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BaoMat = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Link = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    ID_GiaoVien = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lop_MonHocs", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Lop_MonHocs_AspNetUsers_ID_GiaoVien",
                        column: x => x.ID_GiaoVien,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Lop_MonHocs_Lops_ID_Lop",
                        column: x => x.ID_Lop,
                        principalTable: "Lops",
                        principalColumn: "ID_Lop");
                    table.ForeignKey(
                        name: "FK_Lop_MonHocs_MonHocs_ID_MonHoc",
                        column: x => x.ID_MonHoc,
                        principalTable: "MonHocs",
                        principalColumn: "ID_MonHoc");
                });

            migrationBuilder.CreateTable(
                name: "Lop_Thi_KiemTras",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ID_Lop = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NgayKiemTra = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ID_MonHoc = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ID_HinhThuc = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NoiDung = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ChuDe = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    MoTa = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ThoiLuong = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    FileTestName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lop_Thi_KiemTras", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Lop_Thi_KiemTras_HinhThuc_Thi_KiemTras_ID_HinhThuc",
                        column: x => x.ID_HinhThuc,
                        principalTable: "HinhThuc_Thi_KiemTras",
                        principalColumn: "ID_HinhThuc");
                    table.ForeignKey(
                        name: "FK_Lop_Thi_KiemTras_Lops_ID_Lop",
                        column: x => x.ID_Lop,
                        principalTable: "Lops",
                        principalColumn: "ID_Lop");
                    table.ForeignKey(
                        name: "FK_Lop_Thi_KiemTras_MonHocs_ID_MonHoc",
                        column: x => x.ID_MonHoc,
                        principalTable: "MonHocs",
                        principalColumn: "ID_MonHoc");
                });

            migrationBuilder.CreateTable(
                name: "ThoiKhoaBieus",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ID_Lop = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NgayHoc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SoTiet = table.Column<int>(type: "int", nullable: false),
                    ID_MonHoc = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThoiKhoaBieus", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ThoiKhoaBieus_Lops_ID_Lop",
                        column: x => x.ID_Lop,
                        principalTable: "Lops",
                        principalColumn: "ID_Lop");
                    table.ForeignKey(
                        name: "FK_ThoiKhoaBieus_MonHocs_ID_MonHoc",
                        column: x => x.ID_MonHoc,
                        principalTable: "MonHocs",
                        principalColumn: "ID_MonHoc");
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Diem_HocSinhs_ID_HocSinh",
                table: "Diem_HocSinhs",
                column: "ID_HocSinh");

            migrationBuilder.CreateIndex(
                name: "IX_Diem_HocSinhs_ID_MonHoc",
                table: "Diem_HocSinhs",
                column: "ID_MonHoc");

            migrationBuilder.CreateIndex(
                name: "IX_Lop_HocSinhs_ID_HocSinh",
                table: "Lop_HocSinhs",
                column: "ID_HocSinh");

            migrationBuilder.CreateIndex(
                name: "IX_Lop_HocSinhs_ID_Lop",
                table: "Lop_HocSinhs",
                column: "ID_Lop");

            migrationBuilder.CreateIndex(
                name: "IX_Lop_MonHocs_ID_GiaoVien",
                table: "Lop_MonHocs",
                column: "ID_GiaoVien");

            migrationBuilder.CreateIndex(
                name: "IX_Lop_MonHocs_ID_Lop",
                table: "Lop_MonHocs",
                column: "ID_Lop");

            migrationBuilder.CreateIndex(
                name: "IX_Lop_MonHocs_ID_MonHoc",
                table: "Lop_MonHocs",
                column: "ID_MonHoc");

            migrationBuilder.CreateIndex(
                name: "IX_Lop_Thi_KiemTras_ID_HinhThuc",
                table: "Lop_Thi_KiemTras",
                column: "ID_HinhThuc");

            migrationBuilder.CreateIndex(
                name: "IX_Lop_Thi_KiemTras_ID_Lop",
                table: "Lop_Thi_KiemTras",
                column: "ID_Lop");

            migrationBuilder.CreateIndex(
                name: "IX_Lop_Thi_KiemTras_ID_MonHoc",
                table: "Lop_Thi_KiemTras",
                column: "ID_MonHoc");

            migrationBuilder.CreateIndex(
                name: "IX_Lops_ID_GiaoVien",
                table: "Lops",
                column: "ID_GiaoVien");

            migrationBuilder.CreateIndex(
                name: "IX_Lops_ID_KhoaHoc",
                table: "Lops",
                column: "ID_KhoaHoc");

            migrationBuilder.CreateIndex(
                name: "IX_ThoiKhoaBieus_ID_Lop",
                table: "ThoiKhoaBieus",
                column: "ID_Lop");

            migrationBuilder.CreateIndex(
                name: "IX_ThoiKhoaBieus_ID_MonHoc",
                table: "ThoiKhoaBieus",
                column: "ID_MonHoc");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Diem_HocSinhs");

            migrationBuilder.DropTable(
                name: "Lop_HocSinhs");

            migrationBuilder.DropTable(
                name: "Lop_MonHocs");

            migrationBuilder.DropTable(
                name: "Lop_Thi_KiemTras");

            migrationBuilder.DropTable(
                name: "ThoiKhoaBieus");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "HinhThuc_Thi_KiemTras");

            migrationBuilder.DropTable(
                name: "Lops");

            migrationBuilder.DropTable(
                name: "MonHocs");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "KhoaHocs");
        }
    }
}