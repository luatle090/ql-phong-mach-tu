USE [QLPhongMachTu]
GO
/****** Object:  Table [dbo].[BenhNhan]    Script Date: 02/06/2020 8:56:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE Config(
	QuiDinh nvarchar(10) not null,
	DoiTuong nvarchar(100),
	GiaTri int,
);

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
/****** Object:  Table [dbo].[CachDung]    Script Date: 02/06/2020 8:56:10 PM ******/
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
/****** Object:  Table [dbo].[ChiTietPhieuKhamBenh]    Script Date: 02/06/2020 8:56:10 PM ******/
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
/****** Object:  Table [dbo].[DonViTinh]    Script Date: 02/06/2020 8:56:10 PM ******/
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
/****** Object:  Table [dbo].[DSKhamBenh]    Script Date: 02/06/2020 8:56:10 PM ******/
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
 CONSTRAINT [PK_DSKhamBenh] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HoaDonThanhToan]    Script Date: 02/06/2020 8:56:10 PM ******/
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
/****** Object:  Table [dbo].[LoaiBenh]    Script Date: 02/06/2020 8:56:10 PM ******/
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
/****** Object:  Table [dbo].[NhanVien]    Script Date: 02/06/2020 8:56:10 PM ******/
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
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PhieuKhamBenh]    Script Date: 02/06/2020 8:56:10 PM ******/
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
/****** Object:  Table [dbo].[Thuoc]    Script Date: 02/06/2020 8:56:10 PM ******/
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
SET IDENTITY_INSERT [dbo].[CachDung] ON 

INSERT [dbo].[CachDung] ([ID], [TenCachDung], [MoTa]) VALUES (6, N'Cách dùng 1', N'')
INSERT [dbo].[CachDung] ([ID], [TenCachDung], [MoTa]) VALUES (7, N'Cách dùng 2', N'')
INSERT [dbo].[CachDung] ([ID], [TenCachDung], [MoTa]) VALUES (8, N'Cách dùng 3', N'')
INSERT [dbo].[CachDung] ([ID], [TenCachDung], [MoTa]) VALUES (9, N'Cách dùng 4', N'')
SET IDENTITY_INSERT [dbo].[CachDung] OFF
SET IDENTITY_INSERT [dbo].[DonViTinh] ON 

INSERT [dbo].[DonViTinh] ([ID], [TenDonViTinh]) VALUES (1, N'gói')
INSERT [dbo].[DonViTinh] ([ID], [TenDonViTinh]) VALUES (3, N'vien')
INSERT [dbo].[DonViTinh] ([ID], [TenDonViTinh]) VALUES (4, N'g')
SET IDENTITY_INSERT [dbo].[DonViTinh] OFF
SET IDENTITY_INSERT [dbo].[LoaiBenh] ON 

INSERT [dbo].[LoaiBenh] ([ID], [LoaiBenh]) VALUES (1, N'Đâu đầu   ')
INSERT [dbo].[LoaiBenh] ([ID], [LoaiBenh]) VALUES (3, N'Đâu bụng  ')
INSERT [dbo].[LoaiBenh] ([ID], [LoaiBenh]) VALUES (4, N'Đâu lưng  ')
INSERT [dbo].[LoaiBenh] ([ID], [LoaiBenh]) VALUES (9, N'Gãy tay')
INSERT [dbo].[LoaiBenh] ([ID], [LoaiBenh]) VALUES (10, N'Sổ mủi')
SET IDENTITY_INSERT [dbo].[LoaiBenh] OFF
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
