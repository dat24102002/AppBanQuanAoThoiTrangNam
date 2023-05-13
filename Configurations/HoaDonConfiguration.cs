﻿using App_Ban_Quan_Ao_Thoi_Trang_Nam.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace App_Ban_Quan_Ao_Thoi_Trang_Nam.Configurations
{
    public class HoaDonConfiguration : IEntityTypeConfiguration<HoaDon>
    {
        public void Configure(EntityTypeBuilder<HoaDon> builder)
        {
            builder.ToTable("HoaDon");
            builder.HasKey(x => x.ID);
            builder.Property(x => x.NgayTao).HasColumnType("datetime");
            builder.Property(x => x.NgayThanhToan).HasColumnType("datetime");
            builder.Property(x => x.TenNguoiNhan).HasColumnType("nvarchar(100)");
            builder.Property(x => x.SDT).HasColumnType("nvarchar(10)");
            builder.Property(x => x.Email).HasColumnType("nvarchar(50)");
            builder.Property(x => x.DiaChi).HasColumnType("nvarchar(100)");
            builder.Property(x => x.TienShip).HasColumnType("int");
            builder.Property(x => x.PhuongThucThanhToan).HasColumnType("nvarchar(20)");
            builder.Property(x => x.TrangThaiGiaoHang).HasColumnType("int");
            builder.HasOne(x => x.NguoiDung).WithMany(x => x.HoaDons).HasForeignKey(x => x.IDNguoiDung);
            builder.HasOne(x => x.Voucher).WithMany(x => x.HoaDons).HasForeignKey(x => x.IDVoucher);
        }
    }
}
