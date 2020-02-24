USE [QLPhongMachTu]
GO
/****** Object:  StoredProcedure [dbo].[sp_UpdateThuoc]    Script Date: 24/02/2020 7:17:03 CH ******/
DROP PROCEDURE [dbo].[sp_UpdateThuoc]
GO
/****** Object:  StoredProcedure [dbo].[sp_UpdatePhieuKhamBenh]    Script Date: 24/02/2020 7:17:03 CH ******/
DROP PROCEDURE [dbo].[sp_UpdatePhieuKhamBenh]
GO
/****** Object:  StoredProcedure [dbo].[SP_UpdateNhanVien_Pass]    Script Date: 24/02/2020 7:17:03 CH ******/
DROP PROCEDURE [dbo].[SP_UpdateNhanVien_Pass]
GO
/****** Object:  StoredProcedure [dbo].[SP_UpdateNhanVien]    Script Date: 24/02/2020 7:17:03 CH ******/
DROP PROCEDURE [dbo].[SP_UpdateNhanVien]
GO
/****** Object:  StoredProcedure [dbo].[sp_UpdateLoaiBenh]    Script Date: 24/02/2020 7:17:03 CH ******/
DROP PROCEDURE [dbo].[sp_UpdateLoaiBenh]
GO
/****** Object:  StoredProcedure [dbo].[sp_UpdateDSKhamBenh]    Script Date: 24/02/2020 7:17:03 CH ******/
DROP PROCEDURE [dbo].[sp_UpdateDSKhamBenh]
GO
/****** Object:  StoredProcedure [dbo].[sp_UpdateDonViTinh]    Script Date: 24/02/2020 7:17:03 CH ******/
DROP PROCEDURE [dbo].[sp_UpdateDonViTinh]
GO
/****** Object:  StoredProcedure [dbo].[SP_UpdateCTThuocKham]    Script Date: 24/02/2020 7:17:03 CH ******/
DROP PROCEDURE [dbo].[SP_UpdateCTThuocKham]
GO
/****** Object:  StoredProcedure [dbo].[SP_UpdateConfig]    Script Date: 24/02/2020 7:17:03 CH ******/
DROP PROCEDURE [dbo].[SP_UpdateConfig]
GO
/****** Object:  StoredProcedure [dbo].[sp_UpdateChiTietPhieuKhamBenhNhan]    Script Date: 24/02/2020 7:17:03 CH ******/
DROP PROCEDURE [dbo].[sp_UpdateChiTietPhieuKhamBenhNhan]
GO
/****** Object:  StoredProcedure [dbo].[sp_UpdateCachDung]    Script Date: 24/02/2020 7:17:03 CH ******/
DROP PROCEDURE [dbo].[sp_UpdateCachDung]
GO
/****** Object:  StoredProcedure [dbo].[SP_UpdateBenhNhan]    Script Date: 24/02/2020 7:17:03 CH ******/
DROP PROCEDURE [dbo].[SP_UpdateBenhNhan]
GO
/****** Object:  StoredProcedure [dbo].[SP_TinhTienThuoc_IDPhieu]    Script Date: 24/02/2020 7:17:03 CH ******/
DROP PROCEDURE [dbo].[SP_TinhTienThuoc_IDPhieu]
GO
/****** Object:  StoredProcedure [dbo].[sp_ReadTinhTienHoaDon]    Script Date: 24/02/2020 7:17:03 CH ******/
DROP PROCEDURE [dbo].[sp_ReadTinhTienHoaDon]
GO
/****** Object:  StoredProcedure [dbo].[SP_ReadThuoc]    Script Date: 24/02/2020 7:17:03 CH ******/
DROP PROCEDURE [dbo].[SP_ReadThuoc]
GO
/****** Object:  StoredProcedure [dbo].[SP_ReadThanhToan]    Script Date: 24/02/2020 7:17:03 CH ******/
DROP PROCEDURE [dbo].[SP_ReadThanhToan]
GO
/****** Object:  StoredProcedure [dbo].[SP_ReadSoLuongKhamBenh_Ngay]    Script Date: 24/02/2020 7:17:03 CH ******/
DROP PROCEDURE [dbo].[SP_ReadSoLuongKhamBenh_Ngay]
GO
/****** Object:  StoredProcedure [dbo].[sp_ReadPhieuKhamBenh]    Script Date: 24/02/2020 7:17:03 CH ******/
DROP PROCEDURE [dbo].[sp_ReadPhieuKhamBenh]
GO
/****** Object:  StoredProcedure [dbo].[SP_ReadNhanVien]    Script Date: 24/02/2020 7:17:03 CH ******/
DROP PROCEDURE [dbo].[SP_ReadNhanVien]
GO
/****** Object:  StoredProcedure [dbo].[SP_ReadLogin]    Script Date: 24/02/2020 7:17:03 CH ******/
DROP PROCEDURE [dbo].[SP_ReadLogin]
GO
/****** Object:  StoredProcedure [dbo].[SP_ReadLoaiBenh]    Script Date: 24/02/2020 7:17:03 CH ******/
DROP PROCEDURE [dbo].[SP_ReadLoaiBenh]
GO
/****** Object:  StoredProcedure [dbo].[sp_ReadLayDSBenhNhanTheoNgay]    Script Date: 24/02/2020 7:17:03 CH ******/
DROP PROCEDURE [dbo].[sp_ReadLayDSBenhNhanTheoNgay]
GO
/****** Object:  StoredProcedure [dbo].[sp_ReadLayDSBenhNhanCanXuatTheoNgay]    Script Date: 24/02/2020 7:17:03 CH ******/
DROP PROCEDURE [dbo].[sp_ReadLayDSBenhNhanCanXuatTheoNgay]
GO
/****** Object:  StoredProcedure [dbo].[SP_ReadDSKhamBenh]    Script Date: 24/02/2020 7:17:03 CH ******/
DROP PROCEDURE [dbo].[SP_ReadDSKhamBenh]
GO
/****** Object:  StoredProcedure [dbo].[sp_ReadDSHoaDon]    Script Date: 24/02/2020 7:17:03 CH ******/
DROP PROCEDURE [dbo].[sp_ReadDSHoaDon]
GO
/****** Object:  StoredProcedure [dbo].[SP_ReadDonViTinhh]    Script Date: 24/02/2020 7:17:03 CH ******/
DROP PROCEDURE [dbo].[SP_ReadDonViTinhh]
GO
/****** Object:  StoredProcedure [dbo].[SP_ReadDonViTinh]    Script Date: 24/02/2020 7:17:03 CH ******/
DROP PROCEDURE [dbo].[SP_ReadDonViTinh]
GO
/****** Object:  StoredProcedure [dbo].[SP_ReadCTThuocKham_IDPhieu]    Script Date: 24/02/2020 7:17:03 CH ******/
DROP PROCEDURE [dbo].[SP_ReadCTThuocKham_IDPhieu]
GO
/****** Object:  StoredProcedure [dbo].[sp_ReadChiTietPhieuKhamBenh]    Script Date: 24/02/2020 7:17:03 CH ******/
DROP PROCEDURE [dbo].[sp_ReadChiTietPhieuKhamBenh]
GO
/****** Object:  StoredProcedure [dbo].[SP_ReadCachDung]    Script Date: 24/02/2020 7:17:03 CH ******/
DROP PROCEDURE [dbo].[SP_ReadCachDung]
GO
/****** Object:  StoredProcedure [dbo].[SP_ReadBenhNhan_ByMa]    Script Date: 24/02/2020 7:17:03 CH ******/
DROP PROCEDURE [dbo].[SP_ReadBenhNhan_ByMa]
GO
/****** Object:  StoredProcedure [dbo].[SP_ReadBenhNhan]    Script Date: 24/02/2020 7:17:03 CH ******/
DROP PROCEDURE [dbo].[SP_ReadBenhNhan]
GO
/****** Object:  StoredProcedure [dbo].[sp_ReadBCSuDungThuoc]    Script Date: 24/02/2020 7:17:03 CH ******/
DROP PROCEDURE [dbo].[sp_ReadBCSuDungThuoc]
GO
/****** Object:  StoredProcedure [dbo].[sp_ReadBCDoanhThuTheoNgay]    Script Date: 24/02/2020 7:17:03 CH ******/
DROP PROCEDURE [dbo].[sp_ReadBCDoanhThuTheoNgay]
GO
/****** Object:  StoredProcedure [dbo].[SP_ReadBaoCao_SuDungThuoc_Month]    Script Date: 24/02/2020 7:17:03 CH ******/
DROP PROCEDURE [dbo].[SP_ReadBaoCao_SuDungThuoc_Month]
GO
/****** Object:  StoredProcedure [dbo].[SP_ReadBaoCao_DoanhThu_Month]    Script Date: 24/02/2020 7:17:03 CH ******/
DROP PROCEDURE [dbo].[SP_ReadBaoCao_DoanhThu_Month]
GO
/****** Object:  StoredProcedure [dbo].[SP_InsertThuoc]    Script Date: 24/02/2020 7:17:03 CH ******/
DROP PROCEDURE [dbo].[SP_InsertThuoc]
GO
/****** Object:  StoredProcedure [dbo].[SP_InsertThanhToan]    Script Date: 24/02/2020 7:17:03 CH ******/
DROP PROCEDURE [dbo].[SP_InsertThanhToan]
GO
/****** Object:  StoredProcedure [dbo].[SP_InsertPhieuKhamBenh]    Script Date: 24/02/2020 7:17:03 CH ******/
DROP PROCEDURE [dbo].[SP_InsertPhieuKhamBenh]
GO
/****** Object:  StoredProcedure [dbo].[SP_InsertNhanVien]    Script Date: 24/02/2020 7:17:03 CH ******/
DROP PROCEDURE [dbo].[SP_InsertNhanVien]
GO
/****** Object:  StoredProcedure [dbo].[SP_InsertLoaiBenh]    Script Date: 24/02/2020 7:17:03 CH ******/
DROP PROCEDURE [dbo].[SP_InsertLoaiBenh]
GO
/****** Object:  StoredProcedure [dbo].[sp_InserThuoc]    Script Date: 24/02/2020 7:17:03 CH ******/
DROP PROCEDURE [dbo].[sp_InserThuoc]
GO
/****** Object:  StoredProcedure [dbo].[SP_InsertDSKhamBenh]    Script Date: 24/02/2020 7:17:03 CH ******/
DROP PROCEDURE [dbo].[SP_InsertDSKhamBenh]
GO
/****** Object:  StoredProcedure [dbo].[SP_InsertDonViTinh]    Script Date: 24/02/2020 7:17:03 CH ******/
DROP PROCEDURE [dbo].[SP_InsertDonViTinh]
GO
/****** Object:  StoredProcedure [dbo].[SP_InsertCTThuocKham]    Script Date: 24/02/2020 7:17:03 CH ******/
DROP PROCEDURE [dbo].[SP_InsertCTThuocKham]
GO
/****** Object:  StoredProcedure [dbo].[SP_InsertCachDung]    Script Date: 24/02/2020 7:17:03 CH ******/
DROP PROCEDURE [dbo].[SP_InsertCachDung]
GO
/****** Object:  StoredProcedure [dbo].[SP_InsertBenhNhan]    Script Date: 24/02/2020 7:17:03 CH ******/
DROP PROCEDURE [dbo].[SP_InsertBenhNhan]
GO
/****** Object:  StoredProcedure [dbo].[sp_InserPhieuKhamBenhNhan]    Script Date: 24/02/2020 7:17:03 CH ******/
DROP PROCEDURE [dbo].[sp_InserPhieuKhamBenhNhan]
GO
/****** Object:  StoredProcedure [dbo].[sp_InserLoaiBenh]    Script Date: 24/02/2020 7:17:03 CH ******/
DROP PROCEDURE [dbo].[sp_InserLoaiBenh]
GO
/****** Object:  StoredProcedure [dbo].[sp_InserHoaDon]    Script Date: 24/02/2020 7:17:03 CH ******/
DROP PROCEDURE [dbo].[sp_InserHoaDon]
GO
/****** Object:  StoredProcedure [dbo].[sp_InserDSKhamBenh]    Script Date: 24/02/2020 7:17:03 CH ******/
DROP PROCEDURE [dbo].[sp_InserDSKhamBenh]
GO
/****** Object:  StoredProcedure [dbo].[sp_InserDonViTinh]    Script Date: 24/02/2020 7:17:03 CH ******/
DROP PROCEDURE [dbo].[sp_InserDonViTinh]
GO
/****** Object:  StoredProcedure [dbo].[sp_InserChiTietPhieuKhamBenhNhan]    Script Date: 24/02/2020 7:17:03 CH ******/
DROP PROCEDURE [dbo].[sp_InserChiTietPhieuKhamBenhNhan]
GO
/****** Object:  StoredProcedure [dbo].[sp_InserCachDung]    Script Date: 24/02/2020 7:17:03 CH ******/
DROP PROCEDURE [dbo].[sp_InserCachDung]
GO
/****** Object:  StoredProcedure [dbo].[sp_DeleteThuoc]    Script Date: 24/02/2020 7:17:03 CH ******/
DROP PROCEDURE [dbo].[sp_DeleteThuoc]
GO
/****** Object:  StoredProcedure [dbo].[sp_DeletePhieuKhamBenh]    Script Date: 24/02/2020 7:17:03 CH ******/
DROP PROCEDURE [dbo].[sp_DeletePhieuKhamBenh]
GO
/****** Object:  StoredProcedure [dbo].[SP_DeleteNhanVien]    Script Date: 24/02/2020 7:17:03 CH ******/
DROP PROCEDURE [dbo].[SP_DeleteNhanVien]
GO
/****** Object:  StoredProcedure [dbo].[sp_DeleteLoaiBenh]    Script Date: 24/02/2020 7:17:03 CH ******/
DROP PROCEDURE [dbo].[sp_DeleteLoaiBenh]
GO
/****** Object:  StoredProcedure [dbo].[sp_DeleteHoaDon]    Script Date: 24/02/2020 7:17:03 CH ******/
DROP PROCEDURE [dbo].[sp_DeleteHoaDon]
GO
/****** Object:  StoredProcedure [dbo].[sp_DeleteDSKhamBenh]    Script Date: 24/02/2020 7:17:03 CH ******/
DROP PROCEDURE [dbo].[sp_DeleteDSKhamBenh]
GO
/****** Object:  StoredProcedure [dbo].[sp_DeleteDonViTinh]    Script Date: 24/02/2020 7:17:03 CH ******/
DROP PROCEDURE [dbo].[sp_DeleteDonViTinh]
GO
/****** Object:  StoredProcedure [dbo].[SP_DeleteCTThuocKham]    Script Date: 24/02/2020 7:17:03 CH ******/
DROP PROCEDURE [dbo].[SP_DeleteCTThuocKham]
GO
/****** Object:  StoredProcedure [dbo].[sp_DeleteChiTietPhieuKhamBenhTheoIDPhieu]    Script Date: 24/02/2020 7:17:03 CH ******/
DROP PROCEDURE [dbo].[sp_DeleteChiTietPhieuKhamBenhTheoIDPhieu]
GO
/****** Object:  StoredProcedure [dbo].[sp_DeleteChiTietPhieuKhamBenh]    Script Date: 24/02/2020 7:17:03 CH ******/
DROP PROCEDURE [dbo].[sp_DeleteChiTietPhieuKhamBenh]
GO
/****** Object:  StoredProcedure [dbo].[sp_DeleteCachDung]    Script Date: 24/02/2020 7:17:03 CH ******/
DROP PROCEDURE [dbo].[sp_DeleteCachDung]
GO
/****** Object:  StoredProcedure [dbo].[SP_DeleteBenhNhan]    Script Date: 24/02/2020 7:17:03 CH ******/
DROP PROCEDURE [dbo].[SP_DeleteBenhNhan]
GO
/****** Object:  StoredProcedure [dbo].[LoadDSDaXuat()]    Script Date: 24/02/2020 7:17:03 CH ******/
DROP PROCEDURE [dbo].[LoadDSDaXuat()]
GO
ALTER TABLE [dbo].[PhieuKhamBenh] DROP CONSTRAINT [fk_PhieuKhamBenh_NhanVien]
GO
ALTER TABLE [dbo].[PhieuKhamBenh] DROP CONSTRAINT [FK_PhieuKhamBenh_LoaiBenh]
GO
ALTER TABLE [dbo].[PhieuKhamBenh] DROP CONSTRAINT [FK_PhieuKhamBenh_DSKhamBenh]
GO
ALTER TABLE [dbo].[HoaDonThanhToan] DROP CONSTRAINT [fk_HoaDonThanhToan_PhieuKhamBenh]
GO
ALTER TABLE [dbo].[HoaDonThanhToan] DROP CONSTRAINT [fk_HoaDonThanhToan_NhanVien]
GO
ALTER TABLE [dbo].[DSKhamBenh] DROP CONSTRAINT [fk_DSKhamBenh_NhanVien]
GO
ALTER TABLE [dbo].[DSKhamBenh] DROP CONSTRAINT [fk_DSKhamBenh_BenhNhan]
GO
ALTER TABLE [dbo].[ChiTietPhieuKhamBenh] DROP CONSTRAINT [FK_ChiTietPhieuKhamBenh_Thuoc]
GO
ALTER TABLE [dbo].[ChiTietPhieuKhamBenh] DROP CONSTRAINT [FK_ChiTietPhieuKhamBenh_PhieuKhamBenh]
GO
ALTER TABLE [dbo].[ChiTietPhieuKhamBenh] DROP CONSTRAINT [FK_ChiTietPhieuKhamBenh_DonViTinh]
GO
ALTER TABLE [dbo].[ChiTietPhieuKhamBenh] DROP CONSTRAINT [FK_ChiTietPhieuKhamBenh_CachDung]
GO
/****** Object:  Table [dbo].[Thuoc]    Script Date: 24/02/2020 7:17:03 CH ******/
DROP TABLE [dbo].[Thuoc]
GO
/****** Object:  Table [dbo].[PhieuKhamBenh]    Script Date: 24/02/2020 7:17:03 CH ******/
DROP TABLE [dbo].[PhieuKhamBenh]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 24/02/2020 7:17:03 CH ******/
DROP TABLE [dbo].[NhanVien]
GO
/****** Object:  Table [dbo].[LoaiBenh]    Script Date: 24/02/2020 7:17:03 CH ******/
DROP TABLE [dbo].[LoaiBenh]
GO
/****** Object:  Table [dbo].[HoaDonThanhToan]    Script Date: 24/02/2020 7:17:03 CH ******/
DROP TABLE [dbo].[HoaDonThanhToan]
GO
/****** Object:  Table [dbo].[DSKhamBenh]    Script Date: 24/02/2020 7:17:03 CH ******/
DROP TABLE [dbo].[DSKhamBenh]
GO
/****** Object:  Table [dbo].[DonViTinh]    Script Date: 24/02/2020 7:17:03 CH ******/
DROP TABLE [dbo].[DonViTinh]
GO
/****** Object:  Table [dbo].[Config]    Script Date: 24/02/2020 7:17:03 CH ******/
DROP TABLE [dbo].[Config]
GO
/****** Object:  Table [dbo].[ChiTietPhieuKhamBenh]    Script Date: 24/02/2020 7:17:03 CH ******/
DROP TABLE [dbo].[ChiTietPhieuKhamBenh]
GO
/****** Object:  Table [dbo].[CachDung]    Script Date: 24/02/2020 7:17:03 CH ******/
DROP TABLE [dbo].[CachDung]
GO
/****** Object:  Table [dbo].[BenhNhan]    Script Date: 24/02/2020 7:17:03 CH ******/
DROP TABLE [dbo].[BenhNhan]
GO
/****** Object:  Table [dbo].[BenhNhan]    Script Date: 24/02/2020 7:17:03 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BenhNhan](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Ma] [nvarchar](10) NOT NULL,
	[HoTen] [nvarchar](100) NULL,
	[GioiTinh] [int] NULL,
	[NgaySinh] [datetime] NULL,
	[DiaChi] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CachDung]    Script Date: 24/02/2020 7:17:04 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CachDung](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TenCachDung] [nvarchar](100) NOT NULL,
	[MoTa] [nvarchar](200) NULL,
 CONSTRAINT [PK_CachDung] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ChiTietPhieuKhamBenh]    Script Date: 24/02/2020 7:17:04 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietPhieuKhamBenh](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[IDPhieu] [int] NULL,
	[IDThuoc] [int] NULL,
	[IDDonViThuoc] [int] NULL,
	[SoLuong] [float] NULL,
	[IDCachDung] [int] NULL,
 CONSTRAINT [PK_ChiTietPhieuKhamBenh] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Config]    Script Date: 24/02/2020 7:17:04 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Config](
	[QuiDinh] [nvarchar](10) NOT NULL,
	[DoiTuong] [nvarchar](100) NULL,
	[GiaTri] [int] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DonViTinh]    Script Date: 24/02/2020 7:17:04 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DonViTinh](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TenDonViTinh] [nvarchar](50) NULL,
 CONSTRAINT [PK_DonViTinh] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DSKhamBenh]    Script Date: 24/02/2020 7:17:04 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DSKhamBenh](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[NgayKham] [datetime] NULL,
	[HoTen] [nvarchar](50) NULL,
	[GioiTinh] [bit] NULL,
	[NamSinh] [int] NULL,
	[DiaChi] [nvarchar](200) NULL,
	[IDBenhNhan] [int] NULL,
	[IDNhanVien] [int] NULL,
	[NgaySinh] [datetime] NULL,
 CONSTRAINT [PK_DSKhamBenh] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HoaDonThanhToan]    Script Date: 24/02/2020 7:17:04 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDonThanhToan](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[IDPhieu] [int] NULL,
	[TienKham] [money] NULL,
	[TienThuoc] [money] NULL,
	[HoTen] [nvarchar](50) NULL,
	[NgayKham] [datetime] NULL,
	[IDNhanVien] [int] NULL,
 CONSTRAINT [PK_HoaDonThanhToan] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LoaiBenh]    Script Date: 24/02/2020 7:17:04 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiBenh](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[LoaiBenh] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_LoaiBenh] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 24/02/2020 7:17:04 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Ma] [nvarchar](10) NOT NULL,
	[HoTen] [nvarchar](100) NULL,
	[GioiTinh] [int] NULL,
	[NgaySinh] [datetime] NULL,
	[DiaChi] [nvarchar](100) NULL,
	[ChucVu] [int] NULL,
	[Username] [nvarchar](50) NULL,
	[Pass] [nvarchar](50) NULL,
	[ChucVuText] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PhieuKhamBenh]    Script Date: 24/02/2020 7:17:04 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuKhamBenh](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[IDBenhNhan] [int] NULL,
	[NgayKham] [datetime] NULL,
	[TrieuChung] [nvarchar](200) NULL,
	[IDDoanBenh] [int] NULL,
	[IDNhanVien] [int] NULL,
 CONSTRAINT [PK_PhieuKhamBenh] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Thuoc]    Script Date: 24/02/2020 7:17:04 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Thuoc](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TenThuoc] [nvarchar](200) NULL,
	[GIa] [money] NULL,
 CONSTRAINT [PK_Thuoc] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[BenhNhan] ON 

INSERT [dbo].[BenhNhan] ([ID], [Ma], [HoTen], [GioiTinh], [NgaySinh], [DiaChi]) VALUES (1, N'BN01', N'Benh nhan 1', 1, CAST(N'2000-02-18 00:00:00.000' AS DateTime), N'Q1, HCM ')
INSERT [dbo].[BenhNhan] ([ID], [Ma], [HoTen], [GioiTinh], [NgaySinh], [DiaChi]) VALUES (3, N'BN02', N'Benh nhan 2', 1, CAST(N'2000-02-18 00:00:00.000' AS DateTime), N'Q1, HCM ')
INSERT [dbo].[BenhNhan] ([ID], [Ma], [HoTen], [GioiTinh], [NgaySinh], [DiaChi]) VALUES (5, N'003', N'Lee Van 3', 0, CAST(N'1993-01-20 00:00:00.000' AS DateTime), N'')
INSERT [dbo].[BenhNhan] ([ID], [Ma], [HoTen], [GioiTinh], [NgaySinh], [DiaChi]) VALUES (6, N'004', N'Lee Văn 3', 1, CAST(N'2000-02-18 00:00:00.000' AS DateTime), N'')
INSERT [dbo].[BenhNhan] ([ID], [Ma], [HoTen], [GioiTinh], [NgaySinh], [DiaChi]) VALUES (8, N'005', N'Benh nhan 2', 1, CAST(N'2000-02-18 00:00:00.000' AS DateTime), N'Q1, HCM')
INSERT [dbo].[BenhNhan] ([ID], [Ma], [HoTen], [GioiTinh], [NgaySinh], [DiaChi]) VALUES (9, N'006', N'Lee Van 4', 1, CAST(N'1993-01-20 00:00:00.000' AS DateTime), N'')
SET IDENTITY_INSERT [dbo].[BenhNhan] OFF
SET IDENTITY_INSERT [dbo].[CachDung] ON 

INSERT [dbo].[CachDung] ([ID], [TenCachDung], [MoTa]) VALUES (11, N'Cách dùng 1', N'mo ta')
INSERT [dbo].[CachDung] ([ID], [TenCachDung], [MoTa]) VALUES (12, N'Cách dùng 2', N'')
INSERT [dbo].[CachDung] ([ID], [TenCachDung], [MoTa]) VALUES (13, N'Cách dùng', N'')
INSERT [dbo].[CachDung] ([ID], [TenCachDung], [MoTa]) VALUES (15, N'Cách dùng 4', N'')
SET IDENTITY_INSERT [dbo].[CachDung] OFF
SET IDENTITY_INSERT [dbo].[ChiTietPhieuKhamBenh] ON 

INSERT [dbo].[ChiTietPhieuKhamBenh] ([ID], [IDPhieu], [IDThuoc], [IDDonViThuoc], [SoLuong], [IDCachDung]) VALUES (1033, 33, 3, 4, 1, 15)
INSERT [dbo].[ChiTietPhieuKhamBenh] ([ID], [IDPhieu], [IDThuoc], [IDDonViThuoc], [SoLuong], [IDCachDung]) VALUES (1034, 33, 27, 4, 1, 15)
INSERT [dbo].[ChiTietPhieuKhamBenh] ([ID], [IDPhieu], [IDThuoc], [IDDonViThuoc], [SoLuong], [IDCachDung]) VALUES (1035, 33, 20, 4, 1, 15)
INSERT [dbo].[ChiTietPhieuKhamBenh] ([ID], [IDPhieu], [IDThuoc], [IDDonViThuoc], [SoLuong], [IDCachDung]) VALUES (1036, 33, 20, 4, 4, 15)
INSERT [dbo].[ChiTietPhieuKhamBenh] ([ID], [IDPhieu], [IDThuoc], [IDDonViThuoc], [SoLuong], [IDCachDung]) VALUES (1037, 33, 31, 4, 4, 15)
INSERT [dbo].[ChiTietPhieuKhamBenh] ([ID], [IDPhieu], [IDThuoc], [IDDonViThuoc], [SoLuong], [IDCachDung]) VALUES (1038, 35, 21, 4, 1, 13)
INSERT [dbo].[ChiTietPhieuKhamBenh] ([ID], [IDPhieu], [IDThuoc], [IDDonViThuoc], [SoLuong], [IDCachDung]) VALUES (1039, 35, 3, 4, 1, 13)
INSERT [dbo].[ChiTietPhieuKhamBenh] ([ID], [IDPhieu], [IDThuoc], [IDDonViThuoc], [SoLuong], [IDCachDung]) VALUES (1040, 35, 27, 4, 1, 13)
SET IDENTITY_INSERT [dbo].[ChiTietPhieuKhamBenh] OFF
INSERT [dbo].[Config] ([QuiDinh], [DoiTuong], [GiaTri]) VALUES (N'QD1.1', N'Số lượng khám trong ngày', 40)
INSERT [dbo].[Config] ([QuiDinh], [DoiTuong], [GiaTri]) VALUES (N'QD2.1', N'Số loại bệnh', 5)
INSERT [dbo].[Config] ([QuiDinh], [DoiTuong], [GiaTri]) VALUES (N'QD2.2', N'Số thuốc', 30)
INSERT [dbo].[Config] ([QuiDinh], [DoiTuong], [GiaTri]) VALUES (N'QD2.3', N'Số đơn vị tính', 2)
INSERT [dbo].[Config] ([QuiDinh], [DoiTuong], [GiaTri]) VALUES (N'QD2.4', N'Số cách dùng', 4)
INSERT [dbo].[Config] ([QuiDinh], [DoiTuong], [GiaTri]) VALUES (N'QD4.1', N'Tiền khám', 30000)
INSERT [dbo].[Config] ([QuiDinh], [DoiTuong], [GiaTri]) VALUES (N'QD4.2', N'Tiền thuốc', -1)
SET IDENTITY_INSERT [dbo].[DonViTinh] ON 

INSERT [dbo].[DonViTinh] ([ID], [TenDonViTinh]) VALUES (1, N'gói')
INSERT [dbo].[DonViTinh] ([ID], [TenDonViTinh]) VALUES (3, N'viên')
INSERT [dbo].[DonViTinh] ([ID], [TenDonViTinh]) VALUES (4, N'g')
INSERT [dbo].[DonViTinh] ([ID], [TenDonViTinh]) VALUES (5, N'mg')
SET IDENTITY_INSERT [dbo].[DonViTinh] OFF
SET IDENTITY_INSERT [dbo].[DSKhamBenh] ON 

INSERT [dbo].[DSKhamBenh] ([ID], [NgayKham], [HoTen], [GioiTinh], [NamSinh], [DiaChi], [IDBenhNhan], [IDNhanVien], [NgaySinh]) VALUES (6, CAST(N'2020-02-20 00:00:00.000' AS DateTime), N'Lê Văn A', 0, NULL, N'Q1, HCM', 1, 1, CAST(N'2000-01-01 00:00:00.000' AS DateTime))
INSERT [dbo].[DSKhamBenh] ([ID], [NgayKham], [HoTen], [GioiTinh], [NamSinh], [DiaChi], [IDBenhNhan], [IDNhanVien], [NgaySinh]) VALUES (8, CAST(N'2020-02-21 00:00:00.000' AS DateTime), N'Benh nhan 2', 0, NULL, N'Q1, HCM', 3, 1, CAST(N'2000-02-18 00:00:00.000' AS DateTime))
INSERT [dbo].[DSKhamBenh] ([ID], [NgayKham], [HoTen], [GioiTinh], [NamSinh], [DiaChi], [IDBenhNhan], [IDNhanVien], [NgaySinh]) VALUES (10, CAST(N'2020-02-20 00:00:00.000' AS DateTime), N'Lee Van 3', 0, NULL, N'', 5, 1, CAST(N'2020-02-20 00:00:00.000' AS DateTime))
INSERT [dbo].[DSKhamBenh] ([ID], [NgayKham], [HoTen], [GioiTinh], [NamSinh], [DiaChi], [IDBenhNhan], [IDNhanVien], [NgaySinh]) VALUES (11, CAST(N'2020-02-21 00:00:00.000' AS DateTime), N'Benh nhan 5', 1, NULL, N'Q1, HCM', 8, 1, CAST(N'2000-02-18 00:00:00.000' AS DateTime))
INSERT [dbo].[DSKhamBenh] ([ID], [NgayKham], [HoTen], [GioiTinh], [NamSinh], [DiaChi], [IDBenhNhan], [IDNhanVien], [NgaySinh]) VALUES (12, CAST(N'2020-02-20 00:00:00.000' AS DateTime), N'Lê Văn A', 1, NULL, N'Q1, HCM', 1, 1, CAST(N'2000-01-01 00:00:00.000' AS DateTime))
INSERT [dbo].[DSKhamBenh] ([ID], [NgayKham], [HoTen], [GioiTinh], [NamSinh], [DiaChi], [IDBenhNhan], [IDNhanVien], [NgaySinh]) VALUES (13, CAST(N'2020-02-20 00:00:00.000' AS DateTime), N'Lê Văn A', 1, NULL, N'Q1, HCM', 1, 1, CAST(N'2000-01-01 00:00:00.000' AS DateTime))
INSERT [dbo].[DSKhamBenh] ([ID], [NgayKham], [HoTen], [GioiTinh], [NamSinh], [DiaChi], [IDBenhNhan], [IDNhanVien], [NgaySinh]) VALUES (14, CAST(N'2020-02-20 00:00:00.000' AS DateTime), N'Lê Văn A', 1, NULL, N'Q1, HCM', 1, 1, CAST(N'2000-01-01 00:00:00.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[DSKhamBenh] OFF
SET IDENTITY_INSERT [dbo].[HoaDonThanhToan] ON 

INSERT [dbo].[HoaDonThanhToan] ([ID], [IDPhieu], [TienKham], [TienThuoc], [HoTen], [NgayKham], [IDNhanVien]) VALUES (12, 33, 30000.0000, 42500.0000, N'Benh nhan 2', CAST(N'2020-02-22 00:00:00.000' AS DateTime), 1)
INSERT [dbo].[HoaDonThanhToan] ([ID], [IDPhieu], [TienKham], [TienThuoc], [HoTen], [NgayKham], [IDNhanVien]) VALUES (13, 34, 30000.0000, 0.0000, N'Benh nhan 2', CAST(N'2020-02-22 00:00:00.000' AS DateTime), 1)
INSERT [dbo].[HoaDonThanhToan] ([ID], [IDPhieu], [TienKham], [TienThuoc], [HoTen], [NgayKham], [IDNhanVien]) VALUES (14, 35, 30000.0000, 23500.0000, N'Benh nhan 2', CAST(N'2020-02-22 00:00:00.000' AS DateTime), 1)
SET IDENTITY_INSERT [dbo].[HoaDonThanhToan] OFF
SET IDENTITY_INSERT [dbo].[LoaiBenh] ON 

INSERT [dbo].[LoaiBenh] ([ID], [LoaiBenh]) VALUES (1, N'Đâu đầu   ')
INSERT [dbo].[LoaiBenh] ([ID], [LoaiBenh]) VALUES (3, N'Đâu bụng quá')
INSERT [dbo].[LoaiBenh] ([ID], [LoaiBenh]) VALUES (4, N'Đâu lưng  ')
INSERT [dbo].[LoaiBenh] ([ID], [LoaiBenh]) VALUES (9, N'Gãy tay')
INSERT [dbo].[LoaiBenh] ([ID], [LoaiBenh]) VALUES (10, N'Sổ mủi')
INSERT [dbo].[LoaiBenh] ([ID], [LoaiBenh]) VALUES (12, N'Đâu bụng')
SET IDENTITY_INSERT [dbo].[LoaiBenh] OFF
SET IDENTITY_INSERT [dbo].[NhanVien] ON 

INSERT [dbo].[NhanVien] ([ID], [Ma], [HoTen], [GioiTinh], [NgaySinh], [DiaChi], [ChucVu], [Username], [Pass], [ChucVuText]) VALUES (1, N'ADMIN', N'ADMIN', 0, CAST(N'1996-02-18 00:00:00.000' AS DateTime), N'HCM', 1, N'admin', N'123', N'Admin')
INSERT [dbo].[NhanVien] ([ID], [Ma], [HoTen], [GioiTinh], [NgaySinh], [DiaChi], [ChucVu], [Username], [Pass], [ChucVuText]) VALUES (2, N'NV02', N'Bac si 023', 0, CAST(N'1996-07-14 00:00:00.000' AS DateTime), N'HCM', 3, N'nv02', N'123', N'Bác sĩ')
INSERT [dbo].[NhanVien] ([ID], [Ma], [HoTen], [GioiTinh], [NgaySinh], [DiaChi], [ChucVu], [Username], [Pass], [ChucVuText]) VALUES (7, N'NV04', N'NV04', 0, CAST(N'1996-02-18 00:00:00.000' AS DateTime), N'HCM', 4, N'nv04', N'123', N'Lễ tân')
INSERT [dbo].[NhanVien] ([ID], [Ma], [HoTen], [GioiTinh], [NgaySinh], [DiaChi], [ChucVu], [Username], [Pass], [ChucVuText]) VALUES (8, N'NV05', N'NV05', 0, CAST(N'1996-02-18 00:00:00.000' AS DateTime), N'HCM', 4, N'NV05', N'321', N'Lễ tân')
INSERT [dbo].[NhanVien] ([ID], [Ma], [HoTen], [GioiTinh], [NgaySinh], [DiaChi], [ChucVu], [Username], [Pass], [ChucVuText]) VALUES (9, N'ADMIN02', N'123', 1, CAST(N'2020-02-22 00:00:00.000' AS DateTime), N'', 1, N'admin02', N'123', N'Admin')
SET IDENTITY_INSERT [dbo].[NhanVien] OFF
SET IDENTITY_INSERT [dbo].[PhieuKhamBenh] ON 

INSERT [dbo].[PhieuKhamBenh] ([ID], [IDBenhNhan], [NgayKham], [TrieuChung], [IDDoanBenh], [IDNhanVien]) VALUES (33, 8, CAST(N'2020-02-21 00:00:00.000' AS DateTime), N'', 12, 1)
INSERT [dbo].[PhieuKhamBenh] ([ID], [IDBenhNhan], [NgayKham], [TrieuChung], [IDDoanBenh], [IDNhanVien]) VALUES (34, 8, CAST(N'2020-02-21 00:00:00.000' AS DateTime), N'', 12, 1)
INSERT [dbo].[PhieuKhamBenh] ([ID], [IDBenhNhan], [NgayKham], [TrieuChung], [IDDoanBenh], [IDNhanVien]) VALUES (35, 8, CAST(N'2020-02-21 00:00:00.000' AS DateTime), N'', 12, 1)
SET IDENTITY_INSERT [dbo].[PhieuKhamBenh] OFF
SET IDENTITY_INSERT [dbo].[Thuoc] ON 

INSERT [dbo].[Thuoc] ([ID], [TenThuoc], [GIa]) VALUES (1, N'Thuoc 1', 10000.0000)
INSERT [dbo].[Thuoc] ([ID], [TenThuoc], [GIa]) VALUES (3, N'Thuoc 2', 15000.0000)
INSERT [dbo].[Thuoc] ([ID], [TenThuoc], [GIa]) VALUES (4, N'Thuoc 3', 6000.0000)
INSERT [dbo].[Thuoc] ([ID], [TenThuoc], [GIa]) VALUES (5, N'Axitamin', 10000.0000)
INSERT [dbo].[Thuoc] ([ID], [TenThuoc], [GIa]) VALUES (6, N'Paracetamon', 1000.0000)
INSERT [dbo].[Thuoc] ([ID], [TenThuoc], [GIa]) VALUES (7, N'Axumin', 1500.0000)
INSERT [dbo].[Thuoc] ([ID], [TenThuoc], [GIa]) VALUES (8, N'Guamin', 6000.0000)
INSERT [dbo].[Thuoc] ([ID], [TenThuoc], [GIa]) VALUES (9, N'Blaximin', 3000.0000)
INSERT [dbo].[Thuoc] ([ID], [TenThuoc], [GIa]) VALUES (10, N'Guxilin', 6000.0000)
INSERT [dbo].[Thuoc] ([ID], [TenThuoc], [GIa]) VALUES (11, N'AxitamiPheanin', 2500.0000)
INSERT [dbo].[Thuoc] ([ID], [TenThuoc], [GIa]) VALUES (12, N'Glaxtoxit', 10000.0000)
INSERT [dbo].[Thuoc] ([ID], [TenThuoc], [GIa]) VALUES (13, N'Axitbalactix', 10000.0000)
INSERT [dbo].[Thuoc] ([ID], [TenThuoc], [GIa]) VALUES (14, N'Thuoc 13', 10000.0000)
INSERT [dbo].[Thuoc] ([ID], [TenThuoc], [GIa]) VALUES (15, N'Thuoc 14', 10000.0000)
INSERT [dbo].[Thuoc] ([ID], [TenThuoc], [GIa]) VALUES (16, N'Xitomin', 2500.0000)
INSERT [dbo].[Thuoc] ([ID], [TenThuoc], [GIa]) VALUES (17, N'Xoladin', 3000.0000)
INSERT [dbo].[Thuoc] ([ID], [TenThuoc], [GIa]) VALUES (18, N'mendoxin', 10000.0000)
INSERT [dbo].[Thuoc] ([ID], [TenThuoc], [GIa]) VALUES (19, N'xitokirin', 6500.0000)
INSERT [dbo].[Thuoc] ([ID], [TenThuoc], [GIa]) VALUES (20, N'Marin', 10000.0000)
INSERT [dbo].[Thuoc] ([ID], [TenThuoc], [GIa]) VALUES (21, N'Alonin', 2500.0000)
INSERT [dbo].[Thuoc] ([ID], [TenThuoc], [GIa]) VALUES (22, N'Taxumin', 1500.0000)
INSERT [dbo].[Thuoc] ([ID], [TenThuoc], [GIa]) VALUES (23, N'Taxuminaxit', 1700.0000)
INSERT [dbo].[Thuoc] ([ID], [TenThuoc], [GIa]) VALUES (24, N'Aloninoxalic', 2500.0000)
INSERT [dbo].[Thuoc] ([ID], [TenThuoc], [GIa]) VALUES (25, N'Xoladin - amit', 5000.0000)
INSERT [dbo].[Thuoc] ([ID], [TenThuoc], [GIa]) VALUES (26, N'Thuoc 25', 1000.0000)
INSERT [dbo].[Thuoc] ([ID], [TenThuoc], [GIa]) VALUES (27, N'Blaximin - axit', 6000.0000)
INSERT [dbo].[Thuoc] ([ID], [TenThuoc], [GIa]) VALUES (28, N'Alonin - axumin', 5500.0000)
INSERT [dbo].[Thuoc] ([ID], [TenThuoc], [GIa]) VALUES (29, N'Glaxtoxit - oxalit', 10000.0000)
INSERT [dbo].[Thuoc] ([ID], [TenThuoc], [GIa]) VALUES (30, N'Marin - oxit ', 10000.0000)
INSERT [dbo].[Thuoc] ([ID], [TenThuoc], [GIa]) VALUES (31, N'Taxumin - axit', 1500.0000)
SET IDENTITY_INSERT [dbo].[Thuoc] OFF
ALTER TABLE [dbo].[ChiTietPhieuKhamBenh]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietPhieuKhamBenh_CachDung] FOREIGN KEY([IDCachDung])
REFERENCES [dbo].[CachDung] ([ID])
GO
ALTER TABLE [dbo].[ChiTietPhieuKhamBenh] CHECK CONSTRAINT [FK_ChiTietPhieuKhamBenh_CachDung]
GO
ALTER TABLE [dbo].[ChiTietPhieuKhamBenh]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietPhieuKhamBenh_DonViTinh] FOREIGN KEY([IDDonViThuoc])
REFERENCES [dbo].[DonViTinh] ([ID])
GO
ALTER TABLE [dbo].[ChiTietPhieuKhamBenh] CHECK CONSTRAINT [FK_ChiTietPhieuKhamBenh_DonViTinh]
GO
ALTER TABLE [dbo].[ChiTietPhieuKhamBenh]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietPhieuKhamBenh_PhieuKhamBenh] FOREIGN KEY([IDPhieu])
REFERENCES [dbo].[PhieuKhamBenh] ([ID])
GO
ALTER TABLE [dbo].[ChiTietPhieuKhamBenh] CHECK CONSTRAINT [FK_ChiTietPhieuKhamBenh_PhieuKhamBenh]
GO
ALTER TABLE [dbo].[ChiTietPhieuKhamBenh]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietPhieuKhamBenh_Thuoc] FOREIGN KEY([IDThuoc])
REFERENCES [dbo].[Thuoc] ([ID])
GO
ALTER TABLE [dbo].[ChiTietPhieuKhamBenh] CHECK CONSTRAINT [FK_ChiTietPhieuKhamBenh_Thuoc]
GO
ALTER TABLE [dbo].[DSKhamBenh]  WITH CHECK ADD  CONSTRAINT [fk_DSKhamBenh_BenhNhan] FOREIGN KEY([IDBenhNhan])
REFERENCES [dbo].[BenhNhan] ([ID])
GO
ALTER TABLE [dbo].[DSKhamBenh] CHECK CONSTRAINT [fk_DSKhamBenh_BenhNhan]
GO
ALTER TABLE [dbo].[DSKhamBenh]  WITH CHECK ADD  CONSTRAINT [fk_DSKhamBenh_NhanVien] FOREIGN KEY([IDNhanVien])
REFERENCES [dbo].[NhanVien] ([ID])
GO
ALTER TABLE [dbo].[DSKhamBenh] CHECK CONSTRAINT [fk_DSKhamBenh_NhanVien]
GO
ALTER TABLE [dbo].[HoaDonThanhToan]  WITH CHECK ADD  CONSTRAINT [fk_HoaDonThanhToan_NhanVien] FOREIGN KEY([IDNhanVien])
REFERENCES [dbo].[NhanVien] ([ID])
GO
ALTER TABLE [dbo].[HoaDonThanhToan] CHECK CONSTRAINT [fk_HoaDonThanhToan_NhanVien]
GO
ALTER TABLE [dbo].[HoaDonThanhToan]  WITH CHECK ADD  CONSTRAINT [fk_HoaDonThanhToan_PhieuKhamBenh] FOREIGN KEY([IDPhieu])
REFERENCES [dbo].[PhieuKhamBenh] ([ID])
GO
ALTER TABLE [dbo].[HoaDonThanhToan] CHECK CONSTRAINT [fk_HoaDonThanhToan_PhieuKhamBenh]
GO
ALTER TABLE [dbo].[PhieuKhamBenh]  WITH CHECK ADD  CONSTRAINT [FK_PhieuKhamBenh_DSKhamBenh] FOREIGN KEY([IDBenhNhan])
REFERENCES [dbo].[DSKhamBenh] ([ID])
GO
ALTER TABLE [dbo].[PhieuKhamBenh] CHECK CONSTRAINT [FK_PhieuKhamBenh_DSKhamBenh]
GO
ALTER TABLE [dbo].[PhieuKhamBenh]  WITH CHECK ADD  CONSTRAINT [FK_PhieuKhamBenh_LoaiBenh] FOREIGN KEY([IDDoanBenh])
REFERENCES [dbo].[LoaiBenh] ([ID])
GO
ALTER TABLE [dbo].[PhieuKhamBenh] CHECK CONSTRAINT [FK_PhieuKhamBenh_LoaiBenh]
GO
ALTER TABLE [dbo].[PhieuKhamBenh]  WITH CHECK ADD  CONSTRAINT [fk_PhieuKhamBenh_NhanVien] FOREIGN KEY([IDNhanVien])
REFERENCES [dbo].[NhanVien] ([ID])
GO
ALTER TABLE [dbo].[PhieuKhamBenh] CHECK CONSTRAINT [fk_PhieuKhamBenh_NhanVien]
GO
/****** Object:  StoredProcedure [dbo].[LoadDSDaXuat()]    Script Date: 24/02/2020 7:17:04 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
--exec sp_ReadLayDSBenhNhanCanXuatTheoNgay '2017-12-03'

Create PROC [dbo].[LoadDSDaXuat()]
AS
BEGIN
	select ID, HoTen, NgayKham, TienKham, TienThuoc from HoaDonThanhToan
END

GO
/****** Object:  StoredProcedure [dbo].[SP_DeleteBenhNhan]    Script Date: 24/02/2020 7:17:04 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROC [dbo].[SP_DeleteBenhNhan]
@id int

as
Declare @resurlt int
Begin tran
	begin try
		Delete from BenhNhan where ID = @id 
		set @resurlt= 1
commit tran
	end try
begin catch
set @resurlt=-1
rollback tran
end catch

return @resurlt
GO
/****** Object:  StoredProcedure [dbo].[sp_DeleteCachDung]    Script Date: 24/02/2020 7:17:04 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[sp_DeleteCachDung]
@id int

as
Declare @resurlt int
Begin tran
	begin try
		Delete from CachDung where ID = @id 
		set @resurlt= 1
commit tran
	end try
begin catch
set @resurlt=-1
rollback tran
end catch

return @resurlt
GO
/****** Object:  StoredProcedure [dbo].[sp_DeleteChiTietPhieuKhamBenh]    Script Date: 24/02/2020 7:17:04 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
Create PROC [dbo].[sp_DeleteChiTietPhieuKhamBenh]
@ID int,
@resurlt int output
as
Begin tran
	begin try
	set @resurlt= 0
		Delete from ChiTietPhieuKhamBenh where ID = @ID 
		set @resurlt= 1
commit tran
	end try
begin catch
set @resurlt=-1
rollback tran
end catch

return @resurlt
GO
/****** Object:  StoredProcedure [dbo].[sp_DeleteChiTietPhieuKhamBenhTheoIDPhieu]    Script Date: 24/02/2020 7:17:04 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
Create PROC [dbo].[sp_DeleteChiTietPhieuKhamBenhTheoIDPhieu]
@IDPhieu int,
@resurlt int output
as
Begin tran
	begin try
	set @resurlt= 0
		Delete from ChiTietPhieuKhamBenh where IDPhieu = @IDPhieu 
		set @resurlt= 1
commit tran
	end try
begin catch
set @resurlt=-1
rollback tran
end catch

return @resurlt
GO
/****** Object:  StoredProcedure [dbo].[SP_DeleteCTThuocKham]    Script Date: 24/02/2020 7:17:04 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROC [dbo].[SP_DeleteCTThuocKham]

@id bigint

as
declare @resurlt int

Begin tran
	begin try
	set @resurlt= 0
		
		delete from ChiTietPhieuKhamBenh  where ID = @id
		
		set @resurlt= 1

commit tran
	end try
begin catch
set @resurlt=-1
rollback tran
end catch

return @resurlt
GO
/****** Object:  StoredProcedure [dbo].[sp_DeleteDonViTinh]    Script Date: 24/02/2020 7:17:04 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[sp_DeleteDonViTinh]
@id int

as
Declare @resurlt int
Begin tran
	begin try
		Delete from DonViTinh where ID = @id 
		set @resurlt= 1
commit tran
	end try
begin catch
set @resurlt=-1
rollback tran
end catch

return @resurlt
GO
/****** Object:  StoredProcedure [dbo].[sp_DeleteDSKhamBenh]    Script Date: 24/02/2020 7:17:04 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[sp_DeleteDSKhamBenh]
@id int

as
Declare @resurlt int
Begin tran
	begin try
		Delete from DSKhamBenh where ID = @id 
		set @resurlt= 1
commit tran
	end try
begin catch
set @resurlt=-1
rollback tran
end catch

return @resurlt
GO
/****** Object:  StoredProcedure [dbo].[sp_DeleteHoaDon]    Script Date: 24/02/2020 7:17:04 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
Create PROC [dbo].[sp_DeleteHoaDon]
@ID int,
@resurlt int output
as
Begin tran
	begin try
		Delete from HoaDonThanhToan where ID = @ID 
		set @resurlt= 1
commit tran
	end try
begin catch
set @resurlt=-1
rollback tran
end catch

return @resurlt
GO
/****** Object:  StoredProcedure [dbo].[sp_DeleteLoaiBenh]    Script Date: 24/02/2020 7:17:04 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[sp_DeleteLoaiBenh]
@id int

as
Declare @resurlt int
Begin tran
	begin try
		Delete from LoaiBenh where ID = @id 
		set @resurlt= 1
commit tran
	end try
begin catch
set @resurlt=-1
rollback tran
end catch

return @resurlt
GO
/****** Object:  StoredProcedure [dbo].[SP_DeleteNhanVien]    Script Date: 24/02/2020 7:17:04 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[SP_DeleteNhanVien]
@id int

as
Declare @resurlt int
Begin tran
	begin try
		Delete from NhanVien where ID = @id 
		set @resurlt= 1
commit tran
	end try
begin catch
set @resurlt=-1
rollback tran
end catch

return @resurlt
GO
/****** Object:  StoredProcedure [dbo].[sp_DeletePhieuKhamBenh]    Script Date: 24/02/2020 7:17:04 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[sp_DeletePhieuKhamBenh]
@id int

as
Declare @resurlt int
Begin tran
	begin try
		
		if Exists(select ID from HoaDonThanhToan where IDPhieu = @id)
		begin
			set @resurlt = -2
		end
		else
		begin
			Delete from ChiTietPhieuKhamBenh where IDPhieu = @id 
			Delete from PhieuKhamBenh where ID = @id 
			set @resurlt= 1
		end

		
commit tran
	end try
begin catch
set @resurlt=-1
rollback tran
end catch

return @resurlt
GO
/****** Object:  StoredProcedure [dbo].[sp_DeleteThuoc]    Script Date: 24/02/2020 7:17:04 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[sp_DeleteThuoc]
@id int

as
Declare @resurlt int
Begin tran
	begin try
		Delete from Thuoc where ID = @id 
		set @resurlt= 1
commit tran
	end try
begin catch
set @resurlt=-1
rollback tran
end catch

return @resurlt
GO
/****** Object:  StoredProcedure [dbo].[sp_InserCachDung]    Script Date: 24/02/2020 7:17:04 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
Create PROC [dbo].[sp_InserCachDung]
@Ten nvarchar(50),
@MoTa nvarchar(200),
@resurlt int output
as
Begin tran
	begin try
		insert into CachDung(TenCachDung, MoTa)values(@Ten, @MoTa)
		set @resurlt=(select @@Identity)
commit tran
	end try
begin catch
set @resurlt=-1
rollback tran
end catch

return @resurlt
GO
/****** Object:  StoredProcedure [dbo].[sp_InserChiTietPhieuKhamBenhNhan]    Script Date: 24/02/2020 7:17:04 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
Create PROC [dbo].[sp_InserChiTietPhieuKhamBenhNhan]
@IDPhieu int,
@IDThuoc int,
@IDDonViTinh int,
@SoLuong float,
@IDCachDung int,
@resurlt int output
as
Begin tran
	begin try
		insert into ChiTietPhieuKhamBenh(IDPhieu, IDThuoc, IDDonViThuoc, SoLuong, IDCachDung)
		values(@IDPhieu, @IDThuoc, @IDDonViTinh, @SoLuong, @IDCachDung)
		set @resurlt=(select @@Identity)
commit tran
	end try
begin catch
set @resurlt=-1
rollback tran
end catch

return @resurlt
GO
/****** Object:  StoredProcedure [dbo].[sp_InserDonViTinh]    Script Date: 24/02/2020 7:17:04 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROC [dbo].[sp_InserDonViTinh]
@Ten nvarchar(50),
@resurlt int output
as
Begin tran
	begin try
	set @resurlt= 0
		insert into DonViTinh(TenDonViTinh)values(@Ten)
		set @resurlt=(select @@Identity)
commit tran
	end try
begin catch
set @resurlt=-1
rollback tran
end catch

return @resurlt
GO
/****** Object:  StoredProcedure [dbo].[sp_InserDSKhamBenh]    Script Date: 24/02/2020 7:17:04 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
Create PROC [dbo].[sp_InserDSKhamBenh]
@Ngay datetime,
@HoTen nvarchar(50),
@GioiTinh bit,
@NamSinh int,
@DiaChi nvarchar(200),
@resurlt int output
as
Begin tran
	begin try
		insert into DSKhamBenh(NgayKham, HoTen, GioiTinh, NamSinh, DiaChi)
		values(@Ngay, @HoTen, @GioiTinh, @NamSinh, @DiaChi)
		set @resurlt=(select @@Identity)
commit tran
	end try
begin catch
set @resurlt=-1
rollback tran
end catch

return @resurlt
GO
/****** Object:  StoredProcedure [dbo].[sp_InserHoaDon]    Script Date: 24/02/2020 7:17:04 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
Create PROC [dbo].[sp_InserHoaDon]
@IDPhieu int,
@HoTen nvarchar(50),
@NgayKham datetime,
@TienKham money,
@TienThuoc money,
@resurlt int output
as
Begin tran
	begin try
		insert into HoaDonThanhToan(IDPhieu, HoTen, NgayKham, TienKham, TienThuoc)
		values(@IDPhieu, @HoTen, @NgayKham, @TienKham, @TienThuoc)
		set @resurlt=(select @@Identity)
commit tran
	end try
begin catch
set @resurlt=-1
rollback tran
end catch

return @resurlt
GO
/****** Object:  StoredProcedure [dbo].[sp_InserLoaiBenh]    Script Date: 24/02/2020 7:17:04 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROC [dbo].[sp_InserLoaiBenh]
@Ten nvarchar(50),
@resurlt int output
as
Begin tran
	begin try
	set @resurlt= 0
		insert into LoaiBenh(LoaiBenh)values(@Ten)
		set @resurlt=(select @@Identity)
commit tran
	end try
begin catch
set @resurlt=-1
rollback tran
end catch

return @resurlt
GO
/****** Object:  StoredProcedure [dbo].[sp_InserPhieuKhamBenhNhan]    Script Date: 24/02/2020 7:17:04 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROC [dbo].[sp_InserPhieuKhamBenhNhan]
@IDHoTen int,
@Ngay datetime,
@TrieuChung nvarchar(200),
@IDLoaiBenh int,
@resurlt int output
as
Begin tran
	begin try
		insert into PhieuKhamBenh(IDBenhNhan, NgayKham, TrieuChung, IDDoanBenh)
		values(@IDHoTen, @Ngay, @TrieuChung, @IDLoaiBenh)
		set @resurlt=(select @@IDENTITY)
		
commit tran
	end try
begin catch
set @resurlt=-1
rollback tran
end catch

return @resurlt
GO
/****** Object:  StoredProcedure [dbo].[SP_InsertBenhNhan]    Script Date: 24/02/2020 7:17:04 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROC [dbo].[SP_InsertBenhNhan]
@ma nvarchar(20),
@hoTen nvarchar(100),
@gioiTinh int,
@ngaySinh datetime,
@diaChi nvarchar(250)

as
declare @resurlt int

Begin tran
	begin try
	set @resurlt= 0
		
		if Exists(select ID From BenhNhan where Ma = @ma)
		begin
			set @resurlt= -2
		end
		else
		begin

		insert into BenhNhan(Ma, HoTen, GioiTinh, NgaySinh, DiaChi)
		values(@ma, @hoTen, @gioiTinh, @ngaySinh, @diaChi)

		set @resurlt=(select @@Identity)

		end
commit tran
	end try
begin catch
set @resurlt=-1
rollback tran
end catch

return @resurlt
GO
/****** Object:  StoredProcedure [dbo].[SP_InsertCachDung]    Script Date: 24/02/2020 7:17:04 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROC [dbo].[SP_InsertCachDung]
@ten nvarchar(100),
@moTa nvarchar(100)

as
declare @resurlt int

Begin tran
	begin try
	set @resurlt= 0
		
		insert into CachDung(TenCachDung, MoTa)
		values(@ten, @moTa)

		set @resurlt=(select @@Identity)

commit tran
	end try
begin catch
set @resurlt=-1
rollback tran
end catch

return @resurlt
GO
/****** Object:  StoredProcedure [dbo].[SP_InsertCTThuocKham]    Script Date: 24/02/2020 7:17:04 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROC [dbo].[SP_InsertCTThuocKham]
@idPhieu bigint,
@idThuoc int,
@soLuong float,
@idDVT int,
@idCachDung int

as
declare @resurlt int

Begin tran
	begin try
	set @resurlt= 0
		
		insert into ChiTietPhieuKhamBenh(IDPhieu, IDThuoc, SoLuong, IDDonViThuoc, IDCachDung)
		values(@idPhieu, @idThuoc, @soLuong, @idDVT, @idCachDung)

		set @resurlt=(select @@Identity)

commit tran
	end try
begin catch
set @resurlt=-1
rollback tran
end catch

return @resurlt
GO
/****** Object:  StoredProcedure [dbo].[SP_InsertDonViTinh]    Script Date: 24/02/2020 7:17:04 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROC [dbo].[SP_InsertDonViTinh]
@ten nvarchar(100)

as
declare @resurlt int

Begin tran
	begin try
	set @resurlt= 0
		
		insert into DonViTinh(TenDonViTinh)
		values(@ten)

		set @resurlt=(select @@Identity)

commit tran
	end try
begin catch
set @resurlt=-1
rollback tran
end catch

return @resurlt
GO
/****** Object:  StoredProcedure [dbo].[SP_InsertDSKhamBenh]    Script Date: 24/02/2020 7:17:04 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROC [dbo].[SP_InsertDSKhamBenh]
@ngayKham datetime,
@hoTen nvarchar(50),
@gioiTinh int,
@diaChi nvarchar(250),
@ngaySinh datetime,
@idBenhNhan int,
@idNhanVien int
as
declare @resurlt int

Begin tran
	begin try
	set @resurlt= 0
		
		insert into DSKhamBenh(NgayKham, HoTen, GioiTinh, DiaChi, NgaySinh, IDBenhNhan, IDNhanVien)
		values(@ngayKham, @hoTen, @gioiTinh, @diaChi, @ngaySinh, @idBenhNhan, @idNhanVien)

		set @resurlt=(select @@Identity)

commit tran
	end try
begin catch
set @resurlt=-1
rollback tran
end catch

return @resurlt
GO
/****** Object:  StoredProcedure [dbo].[sp_InserThuoc]    Script Date: 24/02/2020 7:17:04 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROC [dbo].[sp_InserThuoc]
@Ten nvarchar(50),
@Gia money,
@resurlt int output
as
Begin tran
	begin try
	set @resurlt= 0
		insert into Thuoc(TenThuoc, GIa)values(@Ten, @Gia)
		set @resurlt=(select @@Identity)
commit tran
	end try
begin catch
set @resurlt=-1
rollback tran
end catch

return @resurlt
GO
/****** Object:  StoredProcedure [dbo].[SP_InsertLoaiBenh]    Script Date: 24/02/2020 7:17:04 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROC [dbo].[SP_InsertLoaiBenh]
@ten nvarchar(100)

as
declare @resurlt int

Begin tran
	begin try
	set @resurlt= 0
		
		insert into LoaiBenh(LoaiBenh)
		values(@ten)

		set @resurlt=(select @@Identity)

commit tran
	end try
begin catch
set @resurlt=-1
rollback tran
end catch

return @resurlt
GO
/****** Object:  StoredProcedure [dbo].[SP_InsertNhanVien]    Script Date: 24/02/2020 7:17:04 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[SP_InsertNhanVien]
@ma nvarchar(20),
@hoTen nvarchar(100),
@gioiTinh int,
@ngaySinh datetime,
@diaChi nvarchar(250),
@chucVu int,
@username nvarchar(50),
@pass nvarchar(50),
@chuVuText nvarchar(50)

as
declare @resurlt int

Begin tran
	begin try
	set @resurlt= 0
		
		if Exists(select ID From NhanVien where Ma = @ma or Username = @username)
		begin
			set @resurlt= -2
		end
		else
		begin

		insert into NhanVien(Ma, HoTen, GioiTinh, NgaySinh, DiaChi, ChucVu, Username, Pass, ChucVuText)
		values(@ma, @hoTen, @gioiTinh, @ngaySinh, @diaChi, @chucVu, @username, @pass, @chuVuText)

		set @resurlt=(select @@Identity)

		end
commit tran
	end try
begin catch
set @resurlt=-1
rollback tran
end catch

return @resurlt
GO
/****** Object:  StoredProcedure [dbo].[SP_InsertPhieuKhamBenh]    Script Date: 24/02/2020 7:17:04 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROC [dbo].[SP_InsertPhieuKhamBenh]
@idDSKham bigint,
@ngayKham datetime,
@trieuChung nvarchar(250),
@idDoanBenh int,
@idNhanVien int
as
declare @resurlt int

Begin tran
	begin try
	set @resurlt= 0
		
		insert into PhieuKhamBenh(IDBenhNhan, NgayKham, TrieuChung, IDDoanBenh, IDNhanVien)
		values(@idDSKham, @ngayKham, @trieuChung, @idDoanBenh, @idNhanVien)

		set @resurlt=(select @@Identity)

commit tran
	end try
begin catch
set @resurlt=-1
rollback tran
end catch

return @resurlt
GO
/****** Object:  StoredProcedure [dbo].[SP_InsertThanhToan]    Script Date: 24/02/2020 7:17:04 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create PROC [dbo].[SP_InsertThanhToan]
@idPhieu bigint,
@tienKham money,
@tienThuoc money,
@hoTen nvarchar(50),
@ngayThanhToan datetime,
@idNhanVien int
as
declare @resurlt int

Begin tran
	begin try
	set @resurlt= 0
		
		if Exists(select ID from HoaDonThanhToan where IDPhieu =  @idPhieu)
		begin
			set @resurlt= -2
		end
		else
		begin
			insert into HoaDonThanhToan(IDPhieu, TienKham, TienThuoc, HoTen, NgayKham, IDNhanVien)
			values(@idPhieu, @tienKham, @tienThuoc, @hoTen, @ngayThanhToan, @idNhanVien)

			set @resurlt=(select @@Identity)
		end

		

commit tran
	end try
begin catch
set @resurlt=-1
rollback tran
end catch

return @resurlt
GO
/****** Object:  StoredProcedure [dbo].[SP_InsertThuoc]    Script Date: 24/02/2020 7:17:04 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROC [dbo].[SP_InsertThuoc]
@tenThuoc nvarchar(100),
@gia money

as
declare @resurlt int

Begin tran
	begin try
	set @resurlt= 0
		
		insert into Thuoc(TenThuoc, GIa)
		values(@tenThuoc, @gia)

		set @resurlt=(select @@Identity)

commit tran
	end try
begin catch
set @resurlt=-1
rollback tran
end catch

return @resurlt
GO
/****** Object:  StoredProcedure [dbo].[SP_ReadBaoCao_DoanhThu_Month]    Script Date: 24/02/2020 7:17:04 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROC [dbo].[SP_ReadBaoCao_DoanhThu_Month]
@month datetime
AS
BEGIN

declare @thang int
declare @nam int
set @thang = MONTH(@month)
set @nam = YEAR(@month)

	select  ROW_NUMBER() OVER (ORDER BY NgayKham) AS STT
		,NgayKham, COUNT(HoTen) as SoBenhNhan, sum(TienKham + TienThuoc) as DoanhThu, 0 as TyLe
	from HoaDonThanhToan
	where (MONTH(NgayKham) = @thang and  YEAR(NgayKham) = @nam)
	group by NgayKham

END

GO
/****** Object:  StoredProcedure [dbo].[SP_ReadBaoCao_SuDungThuoc_Month]    Script Date: 24/02/2020 7:17:04 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROC [dbo].[SP_ReadBaoCao_SuDungThuoc_Month]
@month datetime
AS
BEGIN

declare @thang int
declare @nam int
set @thang = MONTH(@month)
set @nam = YEAR(@month)

	select ROW_NUMBER() OVER (ORDER BY t.TenThuoc) AS STT,
		 t.TenThuoc, dvt.TenDonViTinh, ct.SoLuong, cd.TenCachDung
	from ChiTietPhieuKhamBenh as ct
	inner join PhieuKhamBenh as p on ct.IDPhieu = p.ID
	inner join Thuoc as t on ct.IDThuoc = t.ID
	inner join DonViTinh as dvt on ct.IDDonViThuoc = dvt.ID
	inner join CachDung as cd on ct.IDCachDung = cd.ID

END

GO
/****** Object:  StoredProcedure [dbo].[sp_ReadBCDoanhThuTheoNgay]    Script Date: 24/02/2020 7:17:04 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
--exec sp_ReadBCDoanhThuTheoNgay '12', '2017'
CREATE PROC [dbo].[sp_ReadBCDoanhThuTheoNgay]
@Thang int,
@Nam int
AS
BEGIN
	select (CONVERT(DATE , NgayKham)) as NgayKham, count(HoTen) as SoBenhNhan, Format(sum(TienKham + TienThuoc), '#') as DoanhThu
	from HoaDonThanhToan
	where MONTH(NgayKham) = @Thang and Year(NgayKham) = @Nam
	group by NgayKham
END

GO
/****** Object:  StoredProcedure [dbo].[sp_ReadBCSuDungThuoc]    Script Date: 24/02/2020 7:17:04 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
--exec sp_ReadBCSuDungThuoc '12', '2017'
CREATE PROC [dbo].[sp_ReadBCSuDungThuoc]
@Thang int,
@Nam int
AS
BEGIN
	select t.TenThuoc, dvt.TenDonViTinh, SUM(ct.SoLuong) as SoLuong
	from PhieuKhamBenh as p
		inner join ChiTietPhieuKhamBenh as ct on p.ID = ct.IDPhieu
		inner join DonViTinh as dvt on ct.IDDonViThuoc = dvt.ID
		inner join Thuoc as t on ct.IDThuoc = t.ID
	where MONTH(p.NgayKham) = @Thang and Year(p.NgayKham) = @Nam
	group by t.TenThuoc, dvt.TenDonViTinh
END

GO
/****** Object:  StoredProcedure [dbo].[SP_ReadBenhNhan]    Script Date: 24/02/2020 7:17:04 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROC [dbo].[SP_ReadBenhNhan]
AS
BEGIN

	select ID, Ma,HoTen, GioiTinh as Nam,
						 (Case when GioiTinh = 1 then 0 else 1 end) as Nu, NgaySinh, DiaChi
	 from BenhNhan
	 order by Ma, HoTen

	
END

GO
/****** Object:  StoredProcedure [dbo].[SP_ReadBenhNhan_ByMa]    Script Date: 24/02/2020 7:17:04 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROC [dbo].[SP_ReadBenhNhan_ByMa]
@ma nvarchar(50)
AS
BEGIN

	select ID, Ma,HoTen, GioiTinh as Nam,
						 (Case when GioiTinh = 1 then 0 else 1 end) as Nu, NgaySinh, DiaChi
	 from BenhNhan
	 where Ma = @ma
	
END

GO
/****** Object:  StoredProcedure [dbo].[SP_ReadCachDung]    Script Date: 24/02/2020 7:17:04 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROC [dbo].[SP_ReadCachDung]
AS
BEGIN

	select ID, TenCachDung, MoTa from CachDung
	order by TenCachDung

	
END

GO
/****** Object:  StoredProcedure [dbo].[sp_ReadChiTietPhieuKhamBenh]    Script Date: 24/02/2020 7:17:04 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROC [dbo].[sp_ReadChiTietPhieuKhamBenh]
@idphieu int
AS
BEGIN
	select ct.ID, ct.IDThuoc, ct.IDDonViThuoc, ct.IDCachDung, t.TenThuoc, dvt.TenDonViTinh, ct.SoLuong, cd.TenCachDung
	from ChiTietPhieuKhamBenh as ct
		inner join Thuoc as t on ct.IDThuoc = t.ID
		inner join DonViTinh as dvt on ct.IDDonViThuoc = dvt.ID
		inner join CachDung as cd on ct.IDCachDung = cd.ID
		where IDPhieu = @idphieu
END

GO
/****** Object:  StoredProcedure [dbo].[SP_ReadCTThuocKham_IDPhieu]    Script Date: 24/02/2020 7:17:04 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROC [dbo].[SP_ReadCTThuocKham_IDPhieu]
@idPhieu bigint
AS
BEGIN

	select ct.ID, t.TenThuoc, ct.SoLuong, dvt.TenDonViTinh, cd.TenCachDung,
			ct.IDThuoc, ct.IDDonViThuoc, ct.IDCachDung
	from ChiTietPhieuKhamBenh as ct
	inner join Thuoc as t on ct.IDThuoc = t.ID
	inner join DonViTinh as dvt on ct.IDDonViThuoc = dvt.ID
	inner join CachDung as cd on ct.IDCachDung = cd.ID
	where ct.IDPhieu = @idPhieu


END

GO
/****** Object:  StoredProcedure [dbo].[SP_ReadDonViTinh]    Script Date: 24/02/2020 7:17:04 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROC [dbo].[SP_ReadDonViTinh]
AS
BEGIN

	select ID, TenDonViTinh from DonViTinh
	order by TenDonViTinh
	
END
	
GO
/****** Object:  StoredProcedure [dbo].[SP_ReadDonViTinhh]    Script Date: 24/02/2020 7:17:04 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROC [dbo].[SP_ReadDonViTinhh]
AS
BEGIN

	select ID, TenDonViTinh from DonViTinh
	order by TenDonViTinh
	
END
	
GO
/****** Object:  StoredProcedure [dbo].[sp_ReadDSHoaDon]    Script Date: 24/02/2020 7:17:04 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
--exec sp_ReadLayDSBenhNhanCanXuatTheoNgay '2017-12-03'

CREATE PROC [dbo].[sp_ReadDSHoaDon]
AS
BEGIN
	select ID, HoTen,(CONVERT(DATE , NgayKham)) as NgayKham, Format(TienKham, '#') as TienKham, Format(TienThuoc, '#') as TienThuoc from HoaDonThanhToan
END

GO
/****** Object:  StoredProcedure [dbo].[SP_ReadDSKhamBenh]    Script Date: 24/02/2020 7:17:04 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROC [dbo].[SP_ReadDSKhamBenh]
@ngayKham datetime,
@isAll bit
AS
BEGIN

if (@isAll = 1)
begin
	select ds.ID, ds.NgayKham, bn.Ma, ds.HoTen
		,ds.GioiTinh as Nam, (Case when ds.GioiTinh = 1 then 0 else 1 end) as Nu
		, ds.NgaySinh, ds.DiaChi
		, ds.IDBenhNhan, ds.IDNhanVien
	 from DSKhamBenh as ds
	 inner join BenhNhan as bn on ds.IDBenhNhan = bn.ID
	 order by ds.NgayKham
end
else
begin
	select ds.ID, ds.NgayKham, bn.Ma, ds.HoTen
		,ds.GioiTinh as Nam, (Case when ds.GioiTinh = 1 then 0 else 1 end) as Nu
		, ds.NgaySinh, ds.DiaChi
		, ds.IDBenhNhan, ds.IDNhanVien
	 from DSKhamBenh as ds
	 inner join BenhNhan as bn on ds.IDBenhNhan = bn.ID
	 where NgayKham = @ngayKham
	 order by ds.NgayKham
end
	
	
END

GO
/****** Object:  StoredProcedure [dbo].[sp_ReadLayDSBenhNhanCanXuatTheoNgay]    Script Date: 24/02/2020 7:17:04 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
--exec sp_ReadLayDSBenhNhanCanXuatTheoNgay '2017-12-03'

CREATE PROC [dbo].[sp_ReadLayDSBenhNhanCanXuatTheoNgay]
@NgayKham datetime
AS
BEGIN
	select p.ID as IDPhieu, ds.HoTen
	from PhieuKhamBenh as p
		inner join DSKhamBenh as ds on p.IDBenhNhan = ds.ID
		
	where CONVERT(DATE , p.NgayKham) =  CONVERT(DATE , @NgayKham) and (select count(*) from HoaDonThanhToan as hd where hd.IDPhieu = p.ID) < 1
END

GO
/****** Object:  StoredProcedure [dbo].[sp_ReadLayDSBenhNhanTheoNgay]    Script Date: 24/02/2020 7:17:04 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
Create PROC [dbo].[sp_ReadLayDSBenhNhanTheoNgay]
@NgayKham datetime
AS
BEGIN
	select p.ID as IDPhieu, ds.HoTen
	from PhieuKhamBenh as p
		inner join DSKhamBenh as ds on p.IDBenhNhan = ds.ID
	where p.NgayKham = @NgayKham	
END

GO
/****** Object:  StoredProcedure [dbo].[SP_ReadLoaiBenh]    Script Date: 24/02/2020 7:17:04 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROC [dbo].[SP_ReadLoaiBenh]
AS
BEGIN

	select ID, LoaiBenh from LoaiBenh
	order by LoaiBenh

	
END

GO
/****** Object:  StoredProcedure [dbo].[SP_ReadLogin]    Script Date: 24/02/2020 7:17:04 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROC [dbo].[SP_ReadLogin]
@username nvarchar(50),
@pass nvarchar(50)
AS
BEGIN

	select top 1 id, HoTen, Ma, ChucVu, ChucVuText
	from NhanVien
	where Username = @username and pass = @pass;
END


GO
/****** Object:  StoredProcedure [dbo].[SP_ReadNhanVien]    Script Date: 24/02/2020 7:17:04 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_ReadNhanVien]
AS
BEGIN
	select ID, Ma,HoTen, GioiTinh as Nam,
						 (Case when GioiTinh = 1 then 0 else 1 end) as Nu
		, NgaySinh, DiaChi, ChucVuText as ChucVu, Username, ChucVu as IDChucVu
	from NhanVien
	order by Ma, HoTen
END

GO
/****** Object:  StoredProcedure [dbo].[sp_ReadPhieuKhamBenh]    Script Date: 24/02/2020 7:17:04 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[sp_ReadPhieuKhamBenh]
@ngayKham datetime,
@isAll bit
AS
BEGIN

if (@isAll = 1)
begin

	select p.ID, p.NgayKham, bn.Ma, ds.HoTen 
		,ds.GioiTinh as Nam, (Case when ds.GioiTinh = 1 then 0 else 1 end) as Nu
		, ds.NgaySinh, p.TrieuChung, b.LoaiBenh, nv.HoTen as NhanVien
		, p.IDNhanVien, p.IDDoanBenh
	from PhieuKhamBenh as p
	inner join DSKhamBenh as ds on ds.ID = p.IDBenhNhan
	inner join BenhNhan as bn on ds.IDBenhNhan = bn.ID
	inner join LoaiBenh as b on p.IDDoanBenh = b.ID
	inner join NhanVien as nv on p.IDNhanVien = nv.ID
	order by p.NgayKham
end
else
begin
	select p.ID, p.NgayKham, bn.Ma, ds.HoTen 
		,ds.GioiTinh as Nam, (Case when ds.GioiTinh = 1 then 0 else 1 end) as Nu
		, ds.NgaySinh, p.TrieuChung, b.LoaiBenh, nv.HoTen as NhanVien
		, p.IDNhanVien, p.IDDoanBenh
	from PhieuKhamBenh as p
	inner join DSKhamBenh as ds on ds.ID = p.IDBenhNhan
	inner join BenhNhan as bn on ds.IDBenhNhan = bn.ID
	inner join LoaiBenh as b on p.IDDoanBenh = b.ID
	inner join NhanVien as nv on p.IDNhanVien = nv.ID
	where p.NgayKham = @ngayKham
	order by p.NgayKham

end
	
	
END

GO
/****** Object:  StoredProcedure [dbo].[SP_ReadSoLuongKhamBenh_Ngay]    Script Date: 24/02/2020 7:17:04 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROC [dbo].[SP_ReadSoLuongKhamBenh_Ngay]
@ngayKham datetime
AS
BEGIN

	select COUNT(ID) as Value from DSKhamBenh where NgayKham = @ngayKham
	
END

GO
/****** Object:  StoredProcedure [dbo].[SP_ReadThanhToan]    Script Date: 24/02/2020 7:17:04 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROC [dbo].[SP_ReadThanhToan]
@ngayThanhToan datetime,
@isAll bit
AS
BEGIN

if (@isAll = 1)
begin

	select tt.NgayKham as NgayThanhToan , tt.HoTen, p.NgayKham, tt.TienKham, tt.TienThuoc
	from HoaDonThanhToan as tt
	inner join PhieuKhamBenh as p on tt.IDPhieu = p.ID
	order by tt.NgayKham
end
else
begin
	select tt.NgayKham as NgayThanhToan , tt.HoTen, p.NgayKham, tt.TienKham, tt.TienThuoc
	from HoaDonThanhToan as tt
	inner join PhieuKhamBenh as p on tt.IDPhieu = p.ID
	where tt.NgayKham = @ngayThanhToan
	order by tt.NgayKham

end
	
	
END

GO
/****** Object:  StoredProcedure [dbo].[SP_ReadThuoc]    Script Date: 24/02/2020 7:17:04 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROC [dbo].[SP_ReadThuoc]
AS
BEGIN

	select ID, TenThuoc, GIa as Gia from Thuoc
	order by TenThuoc

	
END

GO
/****** Object:  StoredProcedure [dbo].[sp_ReadTinhTienHoaDon]    Script Date: 24/02/2020 7:17:04 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
Create PROC [dbo].[sp_ReadTinhTienHoaDon]
@idphieu int
AS
BEGIN
	select sum(ct.SoLuong * t.GIa) as TienThuoc
	from ChiTietPhieuKhamBenh as ct
		inner join Thuoc as t on ct.IDThuoc = t.ID
		where IDPhieu = @idphieu
END

GO
/****** Object:  StoredProcedure [dbo].[SP_TinhTienThuoc_IDPhieu]    Script Date: 24/02/2020 7:17:04 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROC [dbo].[SP_TinhTienThuoc_IDPhieu]
@idPhieu bigint
AS
BEGIN

	
select ISNULL(sum( t.GIa), 0) as TienThuoc
from ChiTietPhieuKhamBenh as ct
inner join Thuoc as t on ct.IDThuoc = t.ID
where ct.IDPhieu = @idPhieu


END

GO
/****** Object:  StoredProcedure [dbo].[SP_UpdateBenhNhan]    Script Date: 24/02/2020 7:17:04 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROC [dbo].[SP_UpdateBenhNhan]
@ma nvarchar(20),
@hoTen nvarchar(100),
@gioiTinh int,
@ngaySinh datetime,
@diaChi nvarchar(250),
@id int
as
Declare @resurlt int
Begin tran
	begin try
	set @resurlt= 0
		
		if Exists(select ID From BenhNhan where Ma = @ma and ID <> @id)
		begin
			set @resurlt= -2
		end
		else
		begin

		update BenhNhan set Ma = @ma , HoTen = @hoTen, GioiTinh = @gioiTinh, NgaySinh = @ngaySinh, DiaChi = @diaChi
		where ID = @id
		
		set @resurlt=@id

		end
commit tran
	end try
begin catch
set @resurlt=-1
rollback tran
end catch

return @resurlt
GO
/****** Object:  StoredProcedure [dbo].[sp_UpdateCachDung]    Script Date: 24/02/2020 7:17:04 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[sp_UpdateCachDung]
@ten nvarchar(100),
@moTa nvarchar(100),
@id int
as
declare @resurlt int

Begin tran
	begin try
	set @resurlt= 0
		
		update CachDung set TenCachDung = @ten, MoTa = @moTa
		where ID = @id



		set @resurlt=@id

commit tran
	end try
begin catch
set @resurlt=-1
rollback tran
end catch

return @resurlt
GO
/****** Object:  StoredProcedure [dbo].[sp_UpdateChiTietPhieuKhamBenhNhan]    Script Date: 24/02/2020 7:17:04 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
Create  PROC [dbo].[sp_UpdateChiTietPhieuKhamBenhNhan]
@ID int,
@IDThuoc int,
@IDDonViTinh int,
@SoLuong float,
@IDCachDung int,
@resurlt int output
as
Begin tran
	begin try
		
		Update ChiTietPhieuKhamBenh set IDThuoc = @IDThuoc, IDDonViThuoc = @IDDonViTinh, SoLuong = @SoLuong,
		 IDCachDung = @IDCachDung
		where ID = @ID
		set @resurlt= 1
commit tran
	end try
begin catch
set @resurlt=-1
rollback tran
end catch

return @resurlt
GO
/****** Object:  StoredProcedure [dbo].[SP_UpdateConfig]    Script Date: 24/02/2020 7:17:04 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROC [dbo].[SP_UpdateConfig]
@quiDinh nvarchar(100),
@giaTri int
as
declare @resurlt int

Begin tran
	begin try
	set @resurlt= 0
		
		update Config set GiaTri = @giaTri
		where QuiDinh = @quiDinh

		set @resurlt=1

commit tran
	end try
begin catch
set @resurlt=-1
rollback tran
end catch

return @resurlt
GO
/****** Object:  StoredProcedure [dbo].[SP_UpdateCTThuocKham]    Script Date: 24/02/2020 7:17:04 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create PROC [dbo].[SP_UpdateCTThuocKham]
@idPhieu bigint,
@idThuoc int,
@soLuong float,
@idDVT int,
@idCachDung int,
@id bigint

as
declare @resurlt int

Begin tran
	begin try
	set @resurlt= 0
		
		update ChiTietPhieuKhamBenh
		set IDThuoc = @idThuoc, SoLuong =  @soLuong, IDDonViThuoc =  @idDVT, IDCachDung = @idCachDung
		where ID = @id
		set @resurlt= @id

commit tran
	end try
begin catch
set @resurlt=-1
rollback tran
end catch

return @resurlt
GO
/****** Object:  StoredProcedure [dbo].[sp_UpdateDonViTinh]    Script Date: 24/02/2020 7:17:04 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[sp_UpdateDonViTinh]
@ten nvarchar(100),
@id int
as
Declare @resurlt int
Begin tran
	begin try
	set @resurlt= 0
		
		update DonViTinh set TenDonViTinh = @ten
		where ID = @id
		
		set @resurlt=@id
commit tran
	end try
begin catch
set @resurlt=-1
rollback tran
end catch

return @resurlt
GO
/****** Object:  StoredProcedure [dbo].[sp_UpdateDSKhamBenh]    Script Date: 24/02/2020 7:17:04 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[sp_UpdateDSKhamBenh]
@id int,
@hoTen nvarchar(50),
@gioiTinh int,
@diaChi nvarchar(250),
@ngaySinh datetime,
--@idBenhNhan int,
@idNhanVien int
as
declare @resurlt int

Begin tran
	begin try
	set @resurlt= 0
		
		update DSKhamBenh
		set HoTen = @hoTen, GioiTinh = @gioiTinh, DiaChi = @diaChi, NgaySinh = @ngaySinh, IDNhanVien = @idNhanVien
		where ID = @id

		set @resurlt= @id

commit tran
	end try
begin catch
set @resurlt=-1
rollback tran
end catch

return @resurlt
GO
/****** Object:  StoredProcedure [dbo].[sp_UpdateLoaiBenh]    Script Date: 24/02/2020 7:17:04 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[sp_UpdateLoaiBenh]
@ten nvarchar(100),
@id int
as
Declare @resurlt int
Begin tran
	begin try
	set @resurlt= 0
		
		update LoaiBenh set LoaiBenh = @ten
		where ID = @id
		
		set @resurlt=@id
commit tran
	end try
begin catch
set @resurlt=-1
rollback tran
end catch

return @resurlt
GO
/****** Object:  StoredProcedure [dbo].[SP_UpdateNhanVien]    Script Date: 24/02/2020 7:17:04 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[SP_UpdateNhanVien]
@ma nvarchar(20),
@hoTen nvarchar(100),
@gioiTinh int,
@ngaySinh datetime,
@diaChi nvarchar(250),
@chucVu int,
--@username nvarchar(50),
--@pass nvarchar(50),
@id int,
@chuVuText nvarchar(50)
as
Declare @resurlt int
Begin tran
	begin try
	set @resurlt= 0
		
		if Exists(select ID From NhanVien where Ma = @ma and ID <> @id)
		begin
			set @resurlt= -2
		end
		else
		begin

		update NhanVien set Ma = @ma , HoTen = @hoTen, GioiTinh = @gioiTinh, NgaySinh = @ngaySinh, DiaChi = @diaChi
			, ChucVu = @chucVu, ChucVuText = @chuVuText
		where ID = @id
		
		set @resurlt=@id

		end
commit tran
	end try
begin catch
set @resurlt=-1
rollback tran
end catch

return @resurlt
GO
/****** Object:  StoredProcedure [dbo].[SP_UpdateNhanVien_Pass]    Script Date: 24/02/2020 7:17:04 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[SP_UpdateNhanVien_Pass]

@username nvarchar(50),
@pass nvarchar(50),
@id int
as
Declare @resurlt int
Begin tran
	begin try
	set @resurlt= 0
		
		if not Exists(select ID From NhanVien where Username = @username and ID = @id)
		begin
			set @resurlt= -1
		end
		else
		begin

		update NhanVien set Pass = @pass
		where ID = @id
		
		set @resurlt=@id

		end
commit tran
	end try
begin catch
set @resurlt=-1
rollback tran
end catch

return @resurlt
GO
/****** Object:  StoredProcedure [dbo].[sp_UpdatePhieuKhamBenh]    Script Date: 24/02/2020 7:17:04 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[sp_UpdatePhieuKhamBenh]
@idDSKham bigint,
@ngayKham datetime,
@trieuChung nvarchar(250),
@idDoanBenh int,
@idNhanVien int,
@id bigint
as
declare @resurlt int

Begin tran
	begin try
	set @resurlt= 0
		
		update PhieuKhamBenh
		set TrieuChung = @trieuChung, IDDoanBenh = @idDoanBenh, IDNhanVien= @idNhanVien
		where ID = @id

		set @resurlt= @id

commit tran
	end try
begin catch
set @resurlt=-1
rollback tran
end catch

return @resurlt
GO
/****** Object:  StoredProcedure [dbo].[sp_UpdateThuoc]    Script Date: 24/02/2020 7:17:04 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[sp_UpdateThuoc]
@tenThuoc nvarchar(100),
@gia money,
@id int
as
Declare @resurlt int
Begin tran
	begin try
	set @resurlt= 0
		
		update Thuoc set TenThuoc = @tenThuoc, GIa = @gia
		where ID = @id
		
		set @resurlt=@id
commit tran
	end try
begin catch
set @resurlt=-1
rollback tran
end catch

return @resurlt
GO
