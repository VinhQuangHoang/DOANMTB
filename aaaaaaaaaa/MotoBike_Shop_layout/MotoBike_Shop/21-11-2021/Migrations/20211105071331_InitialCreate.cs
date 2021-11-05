using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace _21_11_2021.Migrations
{
    public partial class InitialCreate : Migration
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
                    HoTen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GioiTinh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Hang = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                name: "danhMucs",
                columns: table => new
                {
                    MaDanhMuc = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenDanhMuc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TrangThai = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_danhMucs", x => x.MaDanhMuc);
                });

            migrationBuilder.CreateTable(
                name: "donHangs",
                columns: table => new
                {
                    IdDonHang = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaDonHang = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenDon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_donHangs", x => x.IdDonHang);
                });

            migrationBuilder.CreateTable(
                name: "footshows",
                columns: table => new
                {
                    IdFootShow = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Hinh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TrangThai = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_footshows", x => x.IdFootShow);
                });

            migrationBuilder.CreateTable(
                name: "khachHangs",
                columns: table => new
                {
                    MaKhachHang = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HoTen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SDT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TaiKhoan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MatKhau = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GioiTinh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TrangThai = table.Column<bool>(type: "bit", nullable: false),
                    Hang = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_khachHangs", x => x.MaKhachHang);
                });

            migrationBuilder.CreateTable(
                name: "khuyenMais",
                columns: table => new
                {
                    MaKhuyenMai = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenKhuyenMai = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GiamGia = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TrangThai = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_khuyenMais", x => x.MaKhuyenMai);
                });

            migrationBuilder.CreateTable(
                name: "slideshows",
                columns: table => new
                {
                    IdSlideShow = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Hinh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TrangThai = table.Column<bool>(type: "bit", nullable: false),
                    NoiBat = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_slideshows", x => x.IdSlideShow);
                });

            migrationBuilder.CreateTable(
                name: "tinTucs",
                columns: table => new
                {
                    MaTinTuc = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenTinTuc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MoTa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Hinh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChiTiet = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NoiBat = table.Column<int>(type: "int", nullable: false),
                    TrangThai = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tinTucs", x => x.MaTinTuc);
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
                name: "loaiSanPhams",
                columns: table => new
                {
                    MaLoaiSanPham = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenLoaiSanPham = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaDanhMuc = table.Column<int>(type: "int", nullable: false),
                    TrangThai = table.Column<bool>(type: "bit", nullable: false),
                    DanhMucMaDanhMuc = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_loaiSanPhams", x => x.MaLoaiSanPham);
                    table.ForeignKey(
                        name: "FK_loaiSanPhams_danhMucs_DanhMucMaDanhMuc",
                        column: x => x.DanhMucMaDanhMuc,
                        principalTable: "danhMucs",
                        principalColumn: "MaDanhMuc",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "hoaDons",
                columns: table => new
                {
                    MaHoaDon = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenHoaDon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaKhachHang = table.Column<int>(type: "int", nullable: false),
                    NgayDatHang = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KhachHangMaKhachHang = table.Column<int>(type: "int", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hoaDons", x => x.MaHoaDon);
                    table.ForeignKey(
                        name: "FK_hoaDons_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_hoaDons_khachHangs_KhachHangMaKhachHang",
                        column: x => x.KhachHangMaKhachHang,
                        principalTable: "khachHangs",
                        principalColumn: "MaKhachHang",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "sanPhams",
                columns: table => new
                {
                    MaSanPham = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HinhAnh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TenSanPham = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gia = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    GiaKhuyenMai = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    GiaDaKhuyenMai = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ChiTiet = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaKhuyenMai = table.Column<int>(type: "int", nullable: false),
                    MaLoaiSanPham = table.Column<int>(type: "int", nullable: false),
                    HangMuc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TrangThai = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sanPhams", x => x.MaSanPham);
                    table.ForeignKey(
                        name: "FK_sanPhams_khuyenMais_MaKhuyenMai",
                        column: x => x.MaKhuyenMai,
                        principalTable: "khuyenMais",
                        principalColumn: "MaKhuyenMai",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_sanPhams_loaiSanPhams_MaLoaiSanPham",
                        column: x => x.MaLoaiSanPham,
                        principalTable: "loaiSanPhams",
                        principalColumn: "MaLoaiSanPham",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "chiTietHoaDons",
                columns: table => new
                {
                    MaChiTietHoaDon = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaHoaDon = table.Column<int>(type: "int", nullable: false),
                    MaSanPham = table.Column<int>(type: "int", nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    Gia = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ChietKhau = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ThanhTien = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IdDonHang = table.Column<int>(type: "int", nullable: false),
                    MaSPMaSanPham = table.Column<int>(type: "int", nullable: true),
                    IdDonHang1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_chiTietHoaDons", x => x.MaChiTietHoaDon);
                    table.ForeignKey(
                        name: "FK_chiTietHoaDons_donHangs_IdDonHang1",
                        column: x => x.IdDonHang1,
                        principalTable: "donHangs",
                        principalColumn: "IdDonHang",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_chiTietHoaDons_hoaDons_IdDonHang",
                        column: x => x.IdDonHang,
                        principalTable: "hoaDons",
                        principalColumn: "MaHoaDon",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_chiTietHoaDons_sanPhams_MaSPMaSanPham",
                        column: x => x.MaSPMaSanPham,
                        principalTable: "sanPhams",
                        principalColumn: "MaSanPham",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "danhGias",
                columns: table => new
                {
                    MaSanPham = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SoSao = table.Column<int>(type: "int", nullable: false),
                    ChiTiet = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdDonHang = table.Column<int>(type: "int", nullable: false),
                    TrangThai = table.Column<bool>(type: "bit", nullable: false),
                    MaSPMaSanPham = table.Column<int>(type: "int", nullable: true),
                    IdDHIdDonHang = table.Column<int>(type: "int", nullable: true),
                    KhachHangMaKhachHang = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_danhGias", x => x.MaSanPham);
                    table.ForeignKey(
                        name: "FK_danhGias_donHangs_IdDHIdDonHang",
                        column: x => x.IdDHIdDonHang,
                        principalTable: "donHangs",
                        principalColumn: "IdDonHang",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_danhGias_khachHangs_KhachHangMaKhachHang",
                        column: x => x.KhachHangMaKhachHang,
                        principalTable: "khachHangs",
                        principalColumn: "MaKhachHang",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_danhGias_sanPhams_MaSPMaSanPham",
                        column: x => x.MaSPMaSanPham,
                        principalTable: "sanPhams",
                        principalColumn: "MaSanPham",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ec5ec221-f858-430b-b453-f751968450e4", "023e4ea6-4e4a-4be5-8744-06f19290f513", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "35b4c26b-f6aa-4e4d-a579-24cdf7a776cf", "bb2816a1-a1f1-4330-ad84-c120069b312e", "Visitor", "VISITOR" });

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
                name: "IX_chiTietHoaDons_IdDonHang",
                table: "chiTietHoaDons",
                column: "IdDonHang");

            migrationBuilder.CreateIndex(
                name: "IX_chiTietHoaDons_IdDonHang1",
                table: "chiTietHoaDons",
                column: "IdDonHang1");

            migrationBuilder.CreateIndex(
                name: "IX_chiTietHoaDons_MaSPMaSanPham",
                table: "chiTietHoaDons",
                column: "MaSPMaSanPham");

            migrationBuilder.CreateIndex(
                name: "IX_danhGias_IdDHIdDonHang",
                table: "danhGias",
                column: "IdDHIdDonHang");

            migrationBuilder.CreateIndex(
                name: "IX_danhGias_KhachHangMaKhachHang",
                table: "danhGias",
                column: "KhachHangMaKhachHang");

            migrationBuilder.CreateIndex(
                name: "IX_danhGias_MaSPMaSanPham",
                table: "danhGias",
                column: "MaSPMaSanPham");

            migrationBuilder.CreateIndex(
                name: "IX_hoaDons_KhachHangMaKhachHang",
                table: "hoaDons",
                column: "KhachHangMaKhachHang");

            migrationBuilder.CreateIndex(
                name: "IX_hoaDons_UserId",
                table: "hoaDons",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_loaiSanPhams_DanhMucMaDanhMuc",
                table: "loaiSanPhams",
                column: "DanhMucMaDanhMuc");

            migrationBuilder.CreateIndex(
                name: "IX_sanPhams_MaKhuyenMai",
                table: "sanPhams",
                column: "MaKhuyenMai");

            migrationBuilder.CreateIndex(
                name: "IX_sanPhams_MaLoaiSanPham",
                table: "sanPhams",
                column: "MaLoaiSanPham");
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
                name: "chiTietHoaDons");

            migrationBuilder.DropTable(
                name: "danhGias");

            migrationBuilder.DropTable(
                name: "footshows");

            migrationBuilder.DropTable(
                name: "slideshows");

            migrationBuilder.DropTable(
                name: "tinTucs");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "hoaDons");

            migrationBuilder.DropTable(
                name: "donHangs");

            migrationBuilder.DropTable(
                name: "sanPhams");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "khachHangs");

            migrationBuilder.DropTable(
                name: "khuyenMais");

            migrationBuilder.DropTable(
                name: "loaiSanPhams");

            migrationBuilder.DropTable(
                name: "danhMucs");
        }
    }
}
