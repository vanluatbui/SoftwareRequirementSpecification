using System;
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
                    Status = table.Column<bool>(type: "bit", nullable: false),
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
                    TenKhoaHoc = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
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
                    BaoMat = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Link = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    GiaoVienId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    KhoaHocID_KhoaHoc = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lops", x => x.ID_Lop);
                    table.ForeignKey(
                        name: "FK_Lops_AspNetUsers_GiaoVienId",
                        column: x => x.GiaoVienId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Lops_KhoaHocs_KhoaHocID_KhoaHoc",
                        column: x => x.KhoaHocID_KhoaHoc,
                        principalTable: "KhoaHocs",
                        principalColumn: "ID_KhoaHoc",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Diem_HocSinhs",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HocSinhId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MonHocID_MonHoc = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                        name: "FK_Diem_HocSinhs_AspNetUsers_HocSinhId",
                        column: x => x.HocSinhId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Diem_HocSinhs_MonHocs_MonHocID_MonHoc",
                        column: x => x.MonHocID_MonHoc,
                        principalTable: "MonHocs",
                        principalColumn: "ID_MonHoc",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Lop_HocSinhs",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LopID_Lop = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HocSinhId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    NgayThamGia = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lop_HocSinhs", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Lop_HocSinhs_AspNetUsers_HocSinhId",
                        column: x => x.HocSinhId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Lop_HocSinhs_Lops_LopID_Lop",
                        column: x => x.LopID_Lop,
                        principalTable: "Lops",
                        principalColumn: "ID_Lop",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Lop_MonHocs",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LopID_Lop = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MonHocID_MonHoc = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ThoiLuongHoc = table.Column<int>(type: "int", nullable: false),
                    NgayBatDau = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgayKetThuc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BaoMat = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Link = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    GiaoVienId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lop_MonHocs", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Lop_MonHocs_AspNetUsers_GiaoVienId",
                        column: x => x.GiaoVienId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Lop_MonHocs_Lops_LopID_Lop",
                        column: x => x.LopID_Lop,
                        principalTable: "Lops",
                        principalColumn: "ID_Lop",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Lop_MonHocs_MonHocs_MonHocID_MonHoc",
                        column: x => x.MonHocID_MonHoc,
                        principalTable: "MonHocs",
                        principalColumn: "ID_MonHoc",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Lop_Thi_KiemTras",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LopID_Lop = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NgayKiemTra = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MonHocID_MonHoc = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HinhThucID_HinhThuc = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NoiDung = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ChuDe = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    MoTa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ThoiLuong = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    FileTestName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lop_Thi_KiemTras", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Lop_Thi_KiemTras_HinhThuc_Thi_KiemTras_HinhThucID_HinhThuc",
                        column: x => x.HinhThucID_HinhThuc,
                        principalTable: "HinhThuc_Thi_KiemTras",
                        principalColumn: "ID_HinhThuc",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Lop_Thi_KiemTras_Lops_LopID_Lop",
                        column: x => x.LopID_Lop,
                        principalTable: "Lops",
                        principalColumn: "ID_Lop",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Lop_Thi_KiemTras_MonHocs_MonHocID_MonHoc",
                        column: x => x.MonHocID_MonHoc,
                        principalTable: "MonHocs",
                        principalColumn: "ID_MonHoc",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ThoiKhoaBieus",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LopID_Lop = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ThoiGianHoc = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    SoTiet = table.Column<int>(type: "int", nullable: false),
                    MonHocID_MonHoc = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThoiKhoaBieus", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ThoiKhoaBieus_Lops_LopID_Lop",
                        column: x => x.LopID_Lop,
                        principalTable: "Lops",
                        principalColumn: "ID_Lop",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ThoiKhoaBieus_MonHocs_MonHocID_MonHoc",
                        column: x => x.MonHocID_MonHoc,
                        principalTable: "MonHocs",
                        principalColumn: "ID_MonHoc",
                        onDelete: ReferentialAction.Cascade);
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
                name: "IX_Diem_HocSinhs_HocSinhId",
                table: "Diem_HocSinhs",
                column: "HocSinhId");

            migrationBuilder.CreateIndex(
                name: "IX_Diem_HocSinhs_MonHocID_MonHoc",
                table: "Diem_HocSinhs",
                column: "MonHocID_MonHoc");

            migrationBuilder.CreateIndex(
                name: "IX_Lop_HocSinhs_HocSinhId",
                table: "Lop_HocSinhs",
                column: "HocSinhId");

            migrationBuilder.CreateIndex(
                name: "IX_Lop_HocSinhs_LopID_Lop",
                table: "Lop_HocSinhs",
                column: "LopID_Lop");

            migrationBuilder.CreateIndex(
                name: "IX_Lop_MonHocs_GiaoVienId",
                table: "Lop_MonHocs",
                column: "GiaoVienId");

            migrationBuilder.CreateIndex(
                name: "IX_Lop_MonHocs_LopID_Lop",
                table: "Lop_MonHocs",
                column: "LopID_Lop");

            migrationBuilder.CreateIndex(
                name: "IX_Lop_MonHocs_MonHocID_MonHoc",
                table: "Lop_MonHocs",
                column: "MonHocID_MonHoc");

            migrationBuilder.CreateIndex(
                name: "IX_Lop_Thi_KiemTras_HinhThucID_HinhThuc",
                table: "Lop_Thi_KiemTras",
                column: "HinhThucID_HinhThuc");

            migrationBuilder.CreateIndex(
                name: "IX_Lop_Thi_KiemTras_LopID_Lop",
                table: "Lop_Thi_KiemTras",
                column: "LopID_Lop");

            migrationBuilder.CreateIndex(
                name: "IX_Lop_Thi_KiemTras_MonHocID_MonHoc",
                table: "Lop_Thi_KiemTras",
                column: "MonHocID_MonHoc");

            migrationBuilder.CreateIndex(
                name: "IX_Lops_GiaoVienId",
                table: "Lops",
                column: "GiaoVienId");

            migrationBuilder.CreateIndex(
                name: "IX_Lops_KhoaHocID_KhoaHoc",
                table: "Lops",
                column: "KhoaHocID_KhoaHoc");

            migrationBuilder.CreateIndex(
                name: "IX_ThoiKhoaBieus_LopID_Lop",
                table: "ThoiKhoaBieus",
                column: "LopID_Lop");

            migrationBuilder.CreateIndex(
                name: "IX_ThoiKhoaBieus_MonHocID_MonHoc",
                table: "ThoiKhoaBieus",
                column: "MonHocID_MonHoc");
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
