﻿// <auto-generated />
using System;
using App_Ban_Quan_Ao_Thoi_Trang_Nam.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace App_Ban_Quan_Ao_Thoi_Trang_Nam.Migrations
{
    [DbContext(typeof(AssignmentDBContext))]
    partial class AssignmentDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("App_Ban_Quan_Ao_Thoi_Trang_Nam.Models.BienThe", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Anh")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GiaBan")
                        .HasColumnType("int");

                    b.Property<Guid>("IDSanPham")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("NgayTao")
                        .HasColumnType("Datetime");

                    b.Property<int>("SoLuong")
                        .HasColumnType("int");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("IDSanPham");

                    b.ToTable("BienThe", (string)null);
                });

            modelBuilder.Entity("App_Ban_Quan_Ao_Thoi_Trang_Nam.Models.ChiTietBienThe", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IDBienThe")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IDGiaTri")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IDThuocTinhSanPham")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("IDBienThe");

                    b.HasIndex("IDGiaTri");

                    b.HasIndex("IDThuocTinhSanPham");

                    b.ToTable("ChiTietBienThe", (string)null);
                });

            modelBuilder.Entity("App_Ban_Quan_Ao_Thoi_Trang_Nam.Models.ChiTietGioHang", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IDBienThe")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IDNguoiDung")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("SoLuong")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("IDBienThe");

                    b.HasIndex("IDNguoiDung");

                    b.ToTable("ChiTietGioHang", (string)null);
                });

            modelBuilder.Entity("App_Ban_Quan_Ao_Thoi_Trang_Nam.Models.ChiTietHoaDon", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("DonGia")
                        .HasColumnType("int");

                    b.Property<Guid>("IDBienThe")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IDHoaDon")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("SoLuong")
                        .HasColumnType("int");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("IDBienThe");

                    b.HasIndex("IDHoaDon");

                    b.ToTable("ChiTietHoaDon", (string)null);
                });

            modelBuilder.Entity("App_Ban_Quan_Ao_Thoi_Trang_Nam.Models.ChiTietKhuyenMai", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IDBienThe")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IDKhuyenMai")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("IDBienThe");

                    b.HasIndex("IDKhuyenMai");

                    b.ToTable("ChiTietKhuyenMai", (string)null);
                });

            modelBuilder.Entity("App_Ban_Quan_Ao_Thoi_Trang_Nam.Models.GiaTri", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdThuocTinh")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Ten")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ID");

                    b.HasIndex("IdThuocTinh");

                    b.ToTable("GiaTri", (string)null);
                });

            modelBuilder.Entity("App_Ban_Quan_Ao_Thoi_Trang_Nam.Models.GioHang", b =>
                {
                    b.Property<Guid>("IDNguoiDung")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("NgayTao")
                        .HasColumnType("datetime");

                    b.HasKey("IDNguoiDung");

                    b.ToTable("GioHang", (string)null);
                });

            modelBuilder.Entity("App_Ban_Quan_Ao_Thoi_Trang_Nam.Models.HoaDon", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DiaChi")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(50)");

                    b.Property<Guid>("IDNguoiDung")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IDVoucher")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("NgayTao")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("NgayThanhToan")
                        .HasColumnType("datetime");

                    b.Property<string>("PhuongThucThanhToan")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("SDT")
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("TenNguoiNhan")
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("TienShip")
                        .HasColumnType("int");

                    b.Property<int>("TrangThaiGiaoHang")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("IDNguoiDung");

                    b.HasIndex("IDVoucher");

                    b.ToTable("HoaDon", (string)null);
                });

            modelBuilder.Entity("App_Ban_Quan_Ao_Thoi_Trang_Nam.Models.KhuyenMai", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("GiaTri")
                        .HasColumnType("int");

                    b.Property<string>("MoTa")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("NgayApDung")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("NgayKetThuc")
                        .HasColumnType("datetime");

                    b.Property<string>("Ten")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("KhuyenMai", (string)null);
                });

            modelBuilder.Entity("App_Ban_Quan_Ao_Thoi_Trang_Nam.Models.LichSuTichDiem", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Diem")
                        .HasColumnType("int");

                    b.Property<Guid>("IDHoaDon")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IDNguoiDung")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IDQuyDoiDiem")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("IDHoaDon");

                    b.HasIndex("IDNguoiDung");

                    b.HasIndex("IDQuyDoiDiem");

                    b.ToTable("LichSuTichDiem", (string)null);
                });

            modelBuilder.Entity("App_Ban_Quan_Ao_Thoi_Trang_Nam.Models.LoaiSP", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IDLoaiSPCha")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Ten")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("IDLoaiSPCha");

                    b.ToTable("LoaiSP", (string)null);
                });

            modelBuilder.Entity("App_Ban_Quan_Ao_Thoi_Trang_Nam.Models.NguoiDung", b =>
                {
                    b.Property<Guid>("IDNguoiDung")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DiaChi")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("DiemTich")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<int>("GioiTinh")
                        .HasColumnType("int");

                    b.Property<string>("Ho")
                        .IsRequired()
                        .HasColumnType("nvarchar(15)");

                    b.Property<Guid>("IDVaiTro")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("NgaySinh")
                        .HasColumnType("datetime");

                    b.Property<string>("SDT")
                        .IsRequired()
                        .HasColumnType("varchar(10)");

                    b.Property<string>("Ten")
                        .IsRequired()
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("TenDem")
                        .IsRequired()
                        .HasColumnType("nvarchar(15)");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("IDNguoiDung");

                    b.HasIndex("IDVaiTro");

                    b.ToTable("NguoiDung", (string)null);
                });

            modelBuilder.Entity("App_Ban_Quan_Ao_Thoi_Trang_Nam.Models.QuyDoiDiem", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("SoDiem")
                        .HasColumnType("int");

                    b.Property<int>("TiLeTichDiem")
                        .HasColumnType("int");

                    b.Property<int>("TiLeTieuDiem")
                        .HasColumnType("int");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("QuyDoiDiem", (string)null);
                });

            modelBuilder.Entity("App_Ban_Quan_Ao_Thoi_Trang_Nam.Models.SanPham", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IDLoaiSP")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("MoTa")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Ten")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("IDLoaiSP");

                    b.ToTable("SanPham", (string)null);
                });

            modelBuilder.Entity("App_Ban_Quan_Ao_Thoi_Trang_Nam.Models.ThuocTinh", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("NgayTao")
                        .HasColumnType("Datetime");

                    b.Property<string>("Ten")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("ThuocTinh", (string)null);
                });

            modelBuilder.Entity("App_Ban_Quan_Ao_Thoi_Trang_Nam.Models.ThuocTinhSanPham", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IDSanPham")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IDThuocTinh")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ID");

                    b.HasIndex("IDSanPham");

                    b.HasIndex("IDThuocTinh");

                    b.ToTable("ThuocTinhSanPham", (string)null);
                });

            modelBuilder.Entity("App_Ban_Quan_Ao_Thoi_Trang_Nam.Models.VaiTro", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Ten")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("VaiTro", (string)null);
                });

            modelBuilder.Entity("App_Ban_Quan_Ao_Thoi_Trang_Nam.Models.Voucher", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("GiaTri")
                        .HasColumnType("int");

                    b.Property<int>("HinhThucGiamGia")
                        .HasColumnType("int");

                    b.Property<string>("MoTa")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("NgayApDung")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("NgayKetThuc")
                        .HasColumnType("datetime");

                    b.Property<int>("SoLuong")
                        .HasColumnType("int");

                    b.Property<int>("SoTienCan")
                        .HasColumnType("int");

                    b.Property<string>("Ten")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Voucher", (string)null);
                });

            modelBuilder.Entity("App_Ban_Quan_Ao_Thoi_Trang_Nam.Models.BienThe", b =>
                {
                    b.HasOne("App_Ban_Quan_Ao_Thoi_Trang_Nam.Models.SanPham", "SanPham")
                        .WithMany("BienThes")
                        .HasForeignKey("IDSanPham")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SanPham");
                });

            modelBuilder.Entity("App_Ban_Quan_Ao_Thoi_Trang_Nam.Models.ChiTietBienThe", b =>
                {
                    b.HasOne("App_Ban_Quan_Ao_Thoi_Trang_Nam.Models.BienThe", "BienThe")
                        .WithMany("ChiTietBienThes")
                        .HasForeignKey("IDBienThe")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("App_Ban_Quan_Ao_Thoi_Trang_Nam.Models.GiaTri", "GiaTri")
                        .WithMany("ChiTietBienThes")
                        .HasForeignKey("IDGiaTri")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("App_Ban_Quan_Ao_Thoi_Trang_Nam.Models.ThuocTinhSanPham", "ThuocTinhSanPham")
                        .WithMany("ChiTietBienThes")
                        .HasForeignKey("IDThuocTinhSanPham");

                    b.Navigation("BienThe");

                    b.Navigation("GiaTri");

                    b.Navigation("ThuocTinhSanPham");
                });

            modelBuilder.Entity("App_Ban_Quan_Ao_Thoi_Trang_Nam.Models.ChiTietGioHang", b =>
                {
                    b.HasOne("App_Ban_Quan_Ao_Thoi_Trang_Nam.Models.BienThe", "BienThe")
                        .WithMany("ChiTietGioHangs")
                        .HasForeignKey("IDBienThe")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("App_Ban_Quan_Ao_Thoi_Trang_Nam.Models.GioHang", "GioHang")
                        .WithMany("ChiTietGioHangs")
                        .HasForeignKey("IDNguoiDung")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BienThe");

                    b.Navigation("GioHang");
                });

            modelBuilder.Entity("App_Ban_Quan_Ao_Thoi_Trang_Nam.Models.ChiTietHoaDon", b =>
                {
                    b.HasOne("App_Ban_Quan_Ao_Thoi_Trang_Nam.Models.BienThe", "BienThe")
                        .WithMany("ChiTietHoaDons")
                        .HasForeignKey("IDBienThe")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("App_Ban_Quan_Ao_Thoi_Trang_Nam.Models.HoaDon", "HoaDon")
                        .WithMany("ChiTietHoaDons")
                        .HasForeignKey("IDHoaDon")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BienThe");

                    b.Navigation("HoaDon");
                });

            modelBuilder.Entity("App_Ban_Quan_Ao_Thoi_Trang_Nam.Models.ChiTietKhuyenMai", b =>
                {
                    b.HasOne("App_Ban_Quan_Ao_Thoi_Trang_Nam.Models.BienThe", "BienThe")
                        .WithMany("ChiTietKhuyenMais")
                        .HasForeignKey("IDBienThe")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("App_Ban_Quan_Ao_Thoi_Trang_Nam.Models.KhuyenMai", "KhuyenMai")
                        .WithMany("ChiTietKhuyenMais")
                        .HasForeignKey("IDKhuyenMai")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BienThe");

                    b.Navigation("KhuyenMai");
                });

            modelBuilder.Entity("App_Ban_Quan_Ao_Thoi_Trang_Nam.Models.GiaTri", b =>
                {
                    b.HasOne("App_Ban_Quan_Ao_Thoi_Trang_Nam.Models.ThuocTinh", "ThuocTinh")
                        .WithMany("GiaTris")
                        .HasForeignKey("IdThuocTinh")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ThuocTinh");
                });

            modelBuilder.Entity("App_Ban_Quan_Ao_Thoi_Trang_Nam.Models.GioHang", b =>
                {
                    b.HasOne("App_Ban_Quan_Ao_Thoi_Trang_Nam.Models.NguoiDung", "NguoiDung")
                        .WithOne("GioHang")
                        .HasForeignKey("App_Ban_Quan_Ao_Thoi_Trang_Nam.Models.GioHang", "IDNguoiDung")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("NguoiDung");
                });

            modelBuilder.Entity("App_Ban_Quan_Ao_Thoi_Trang_Nam.Models.HoaDon", b =>
                {
                    b.HasOne("App_Ban_Quan_Ao_Thoi_Trang_Nam.Models.NguoiDung", "NguoiDung")
                        .WithMany("HoaDons")
                        .HasForeignKey("IDNguoiDung")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("App_Ban_Quan_Ao_Thoi_Trang_Nam.Models.Voucher", "Voucher")
                        .WithMany("HoaDons")
                        .HasForeignKey("IDVoucher")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("NguoiDung");

                    b.Navigation("Voucher");
                });

            modelBuilder.Entity("App_Ban_Quan_Ao_Thoi_Trang_Nam.Models.LichSuTichDiem", b =>
                {
                    b.HasOne("App_Ban_Quan_Ao_Thoi_Trang_Nam.Models.HoaDon", "HoaDon")
                        .WithMany("LichSuTichDiems")
                        .HasForeignKey("IDHoaDon")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("App_Ban_Quan_Ao_Thoi_Trang_Nam.Models.NguoiDung", "NguoiDung")
                        .WithMany("LichSuTichDiems")
                        .HasForeignKey("IDNguoiDung");

                    b.HasOne("App_Ban_Quan_Ao_Thoi_Trang_Nam.Models.QuyDoiDiem", "QuyDoiDiem")
                        .WithMany("LichSuTichDiems")
                        .HasForeignKey("IDQuyDoiDiem")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("HoaDon");

                    b.Navigation("NguoiDung");

                    b.Navigation("QuyDoiDiem");
                });

            modelBuilder.Entity("App_Ban_Quan_Ao_Thoi_Trang_Nam.Models.LoaiSP", b =>
                {
                    b.HasOne("App_Ban_Quan_Ao_Thoi_Trang_Nam.Models.LoaiSP", "LoaiSPCha")
                        .WithMany()
                        .HasForeignKey("IDLoaiSPCha");

                    b.Navigation("LoaiSPCha");
                });

            modelBuilder.Entity("App_Ban_Quan_Ao_Thoi_Trang_Nam.Models.NguoiDung", b =>
                {
                    b.HasOne("App_Ban_Quan_Ao_Thoi_Trang_Nam.Models.VaiTro", "VaiTro")
                        .WithMany("NguoiDungs")
                        .HasForeignKey("IDVaiTro")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("VaiTro");
                });

            modelBuilder.Entity("App_Ban_Quan_Ao_Thoi_Trang_Nam.Models.SanPham", b =>
                {
                    b.HasOne("App_Ban_Quan_Ao_Thoi_Trang_Nam.Models.LoaiSP", "LoaiSP")
                        .WithMany("SanPhams")
                        .HasForeignKey("IDLoaiSP")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("LoaiSP");
                });

            modelBuilder.Entity("App_Ban_Quan_Ao_Thoi_Trang_Nam.Models.ThuocTinhSanPham", b =>
                {
                    b.HasOne("App_Ban_Quan_Ao_Thoi_Trang_Nam.Models.SanPham", "SanPham")
                        .WithMany("ThuocTinhSanPhams")
                        .HasForeignKey("IDSanPham")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("App_Ban_Quan_Ao_Thoi_Trang_Nam.Models.ThuocTinh", "ThuocTinh")
                        .WithMany("ThuocTinhSanPhams")
                        .HasForeignKey("IDThuocTinh")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SanPham");

                    b.Navigation("ThuocTinh");
                });

            modelBuilder.Entity("App_Ban_Quan_Ao_Thoi_Trang_Nam.Models.BienThe", b =>
                {
                    b.Navigation("ChiTietBienThes");

                    b.Navigation("ChiTietGioHangs");

                    b.Navigation("ChiTietHoaDons");

                    b.Navigation("ChiTietKhuyenMais");
                });

            modelBuilder.Entity("App_Ban_Quan_Ao_Thoi_Trang_Nam.Models.GiaTri", b =>
                {
                    b.Navigation("ChiTietBienThes");
                });

            modelBuilder.Entity("App_Ban_Quan_Ao_Thoi_Trang_Nam.Models.GioHang", b =>
                {
                    b.Navigation("ChiTietGioHangs");
                });

            modelBuilder.Entity("App_Ban_Quan_Ao_Thoi_Trang_Nam.Models.HoaDon", b =>
                {
                    b.Navigation("ChiTietHoaDons");

                    b.Navigation("LichSuTichDiems");
                });

            modelBuilder.Entity("App_Ban_Quan_Ao_Thoi_Trang_Nam.Models.KhuyenMai", b =>
                {
                    b.Navigation("ChiTietKhuyenMais");
                });

            modelBuilder.Entity("App_Ban_Quan_Ao_Thoi_Trang_Nam.Models.LoaiSP", b =>
                {
                    b.Navigation("SanPhams");
                });

            modelBuilder.Entity("App_Ban_Quan_Ao_Thoi_Trang_Nam.Models.NguoiDung", b =>
                {
                    b.Navigation("GioHang");

                    b.Navigation("HoaDons");

                    b.Navigation("LichSuTichDiems");
                });

            modelBuilder.Entity("App_Ban_Quan_Ao_Thoi_Trang_Nam.Models.QuyDoiDiem", b =>
                {
                    b.Navigation("LichSuTichDiems");
                });

            modelBuilder.Entity("App_Ban_Quan_Ao_Thoi_Trang_Nam.Models.SanPham", b =>
                {
                    b.Navigation("BienThes");

                    b.Navigation("ThuocTinhSanPhams");
                });

            modelBuilder.Entity("App_Ban_Quan_Ao_Thoi_Trang_Nam.Models.ThuocTinh", b =>
                {
                    b.Navigation("GiaTris");

                    b.Navigation("ThuocTinhSanPhams");
                });

            modelBuilder.Entity("App_Ban_Quan_Ao_Thoi_Trang_Nam.Models.ThuocTinhSanPham", b =>
                {
                    b.Navigation("ChiTietBienThes");
                });

            modelBuilder.Entity("App_Ban_Quan_Ao_Thoi_Trang_Nam.Models.VaiTro", b =>
                {
                    b.Navigation("NguoiDungs");
                });

            modelBuilder.Entity("App_Ban_Quan_Ao_Thoi_Trang_Nam.Models.Voucher", b =>
                {
                    b.Navigation("HoaDons");
                });
#pragma warning restore 612, 618
        }
    }
}
