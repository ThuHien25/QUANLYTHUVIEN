USE [CNPM_QLThuVien]
GO

/****** Object:  Table [dbo].[CHITIETPHIEUMUON]    Script Date: 19/12/2016 7:14:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CHITIETPHIEUMUON](
	[MaPM] [varchar](20) NOT NULL,
	[MaTaiLieu] [varchar](20) NOT NULL,
	[HanTra] [int] NULL,
	[NgayTra] [datetime] NULL,
	[TienPhat] [int] NULL,
	[TienBoiThuong] [int] NULL,
 CONSTRAINT [PK_CHITIETPHIEUMUON] PRIMARY KEY CLUSTERED 
(
	[MaTaiLieu] ASC,
	[MaPM] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CHUYENNGANH]    Script Date: 19/12/2016 7:14:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CHUYENNGANH](
	[MaChuyenNganh] [varchar](20) NOT NULL,
	[TenChuyenNganh] [nvarchar](100) NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DOCGIA]    Script Date: 19/12/2016 7:14:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DOCGIA](
	[MaDocGia] [varchar](20) NOT NULL,
	[MaLoaiDG] [varchar](20) NOT NULL,
	[TenDocGia] [nvarchar](50) NOT NULL,
	[GioiTinh] [nvarchar](50) NULL,
	[NgaySinh] [date] NULL,
	[Email] [varchar](50) NULL,
	[NgayDangKy] [date] NOT NULL,
	[HanThe] [int] NOT NULL,
	[TienCoc] [int] NOT NULL,
	[SoSachDangMuon] [int] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HOADON]    Script Date: 19/12/2016 7:14:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HOADON](
	[MaHD] [varchar](20) NOT NULL,
	[MaNV] [varchar](20) NOT NULL,
	[MaNCC] [varchar](20) NOT NULL,
	[NgayLap] [date] NOT NULL,
	[TongTien] [int] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LOAIDOCGIA]    Script Date: 19/12/2016 7:14:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LOAIDOCGIA](
	[MaLoaiDG] [varchar](20) NOT NULL,
	[TenLoaiDG] [nvarchar](100) NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LOAITAILIEU]    Script Date: 19/12/2016 7:14:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LOAITAILIEU](
	[MaLoai] [varchar](20) NOT NULL,
	[TenLoai] [nvarchar](1024) NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[MANHINH]    Script Date: 19/12/2016 7:14:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MANHINH](
	[MaManHinh] [varchar](20) NOT NULL,
	[TenManHinh] [nvarchar](1024) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NGUOIDUNG]    Script Date: 19/12/2016 7:14:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NGUOIDUNG](
	[TenTaiKhoan] [varchar](20) NOT NULL,
	[MaNV] [varchar](20) NOT NULL,
	[MatKhau] [varchar](max) NOT NULL,
	[HoatDong] [bit] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NGUOIDUNG_NHOMNGUOIDUNG]    Script Date: 19/12/2016 7:14:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NGUOIDUNG_NHOMNGUOIDUNG](
	[TenTaiKhoan] [varchar](20) NOT NULL,
	[MaNhom] [varchar](20) NOT NULL,
 CONSTRAINT [PK_NGUOIDUNG_NHOMNGUOIDUNG] PRIMARY KEY CLUSTERED 
(
	[TenTaiKhoan] ASC,
	[MaNhom] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NHACUNGCAP]    Script Date: 19/12/2016 7:14:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NHACUNGCAP](
	[MaNCC] [varchar](20) NOT NULL,
	[TenNCC] [nvarchar](100) NOT NULL,
	[DiaChiNCC] [nvarchar](250) NULL,
	[SDT] [char](12) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NHANVIEN]    Script Date: 19/12/2016 7:14:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NHANVIEN](
	[MaNV] [varchar](20) NOT NULL,
	[TenNV] [nvarchar](50) NOT NULL,
	[DiaChi] [nvarchar](250) NOT NULL,
	[SDT_NV] [varchar](16) NOT NULL,
	[Email_NV] [varchar](50) NULL,
	[ChucVu] [nvarchar](50) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NHOMNGUOIDUNG]    Script Date: 19/12/2016 7:14:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NHOMNGUOIDUNG](
	[MaNhom] [varchar](20) NOT NULL,
	[TenNhom] [nvarchar](1024) NOT NULL,
	[GhiChu] [nvarchar](1024) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PHANQUYEN]    Script Date: 19/12/2016 7:14:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PHANQUYEN](
	[MaNhom] [varchar](20) NOT NULL,
	[MaManHinh] [varchar](20) NOT NULL,
	[CoQuyen] [bit] NULL,
 CONSTRAINT [PK_PHANQUYEN] PRIMARY KEY CLUSTERED 
(
	[MaNhom] ASC,
	[MaManHinh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PHIEUMUON]    Script Date: 19/12/2016 7:14:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PHIEUMUON](
	[MaPM] [varchar](20) NOT NULL,
	[MaDocGia] [varchar](20) NOT NULL,
	[MaNV] [varchar](20) NOT NULL,
	[NgayMuon] [date] NOT NULL,
	[TinhTrang] [nvarchar](20) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TAILIEU]    Script Date: 19/12/2016 7:14:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TAILIEU](
	[MaTaiLieu] [varchar](20) NOT NULL,
	[MaLoai] [varchar](20) NOT NULL,
	[MaChuyenNganh] [varchar](20) NOT NULL,
	[TenTaiLieu] [nvarchar](256) NOT NULL,
	[TacGia] [nvarchar](50) NOT NULL,
	[NamSanXuat] [int] NOT NULL,
	[DonGiaTL] [int] NULL,
	[MoTa] [nvarchar](1024) NULL,
	[SoLuongTon] [int] NULL,
	[SoLuongMuon] [int] NULL,
	[SoLuongHuHao] [int] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  View [dbo].[view_ThongKe_MUONTRA]    Script Date: 19/12/2016 7:14:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[view_ThongKe_MUONTRA]
as
	SELECT PHIEUMUON.MaPM, PHIEUMUON.MaDocGia, CHITIETPHIEUMUON.MaTaiLieu, NgayMuon, HanTra, DATEADD(DD, HanTra, NgayMuon) as NgayTraDuKien, 
			DATEDIFF(DD, DATEADD(DD, HanTra, NgayMuon), GETDATE()) as SoNgayQuaHan
	FROM PHIEUMUON JOIN CHITIETPHIEUMUON ON PHIEUMUON.MaPM = CHITIETPHIEUMUON.MaPM
	WHERE TinhTrang = N'Chưa trả' AND  DATEADD(DD, HanTra, NgayMuon) < GETDATE()

GO
/****** Object:  View [dbo].[view_ThongKeDOCGIA]    Script Date: 19/12/2016 7:14:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create view [dbo].[view_ThongKeDOCGIA]
as
	SELECT MaDocGia, TenDocGia, NgayDangKy, HanThe, DATEADD(yyyy, HanThe, NgayDangKy) as NgayHetHan
	FROM DOCGIA

GO
INSERT [dbo].[CHITIETHD] ([MaTaiLieu], [MaHD], [SoLuong], [DonGia], [ThanhTien]) VALUES (N'TL002', N'HD151216094350', 10, 95000, 950000)
INSERT [dbo].[CHITIETHD] ([MaTaiLieu], [MaHD], [SoLuong], [DonGia], [ThanhTien]) VALUES (N'TL004', N'HD191216195739', 50, 40000, 2000000)
INSERT [dbo].[CHITIETHD] ([MaTaiLieu], [MaHD], [SoLuong], [DonGia], [ThanhTien]) VALUES (N'TL01', N'HD061216114422', 2, 200000, 400000)
INSERT [dbo].[CHITIETHD] ([MaTaiLieu], [MaHD], [SoLuong], [DonGia], [ThanhTien]) VALUES (N'TL01', N'HD061216144035', 5, 200000, 1000000)
INSERT [dbo].[CHITIETHD] ([MaTaiLieu], [MaHD], [SoLuong], [DonGia], [ThanhTien]) VALUES (N'TL01', N'HD071216003203', 10, 80000, 800000)
INSERT [dbo].[CHITIETHD] ([MaTaiLieu], [MaHD], [SoLuong], [DonGia], [ThanhTien]) VALUES (N'TL02', N'HD061216114405', 10, 300000, 3000000)
INSERT [dbo].[CHITIETHD] ([MaTaiLieu], [MaHD], [SoLuong], [DonGia], [ThanhTien]) VALUES (N'TL02', N'HD061216144035', 6, 222220, 1333320)
INSERT [dbo].[CHITIETHD] ([MaTaiLieu], [MaHD], [SoLuong], [DonGia], [ThanhTien]) VALUES (N'TL02', N'HD071216002821', 3, 2000000, 6000000)
INSERT [dbo].[CHITIETHD] ([MaTaiLieu], [MaHD], [SoLuong], [DonGia], [ThanhTien]) VALUES (N'TL02', N'HD071216003203', 10, 90000, 900000)
INSERT [dbo].[CHITIETHD] ([MaTaiLieu], [MaHD], [SoLuong], [DonGia], [ThanhTien]) VALUES (N'TL03', N'HD071216003203', 10, 100000, 1000000)
INSERT [dbo].[CHITIETHD] ([MaTaiLieu], [MaHD], [SoLuong], [DonGia], [ThanhTien]) VALUES (N'TL05', N'HD191216195739', 5, 10000, 50000)
INSERT [dbo].[CHITIETHD] ([MaTaiLieu], [MaHD], [SoLuong], [DonGia], [ThanhTien]) VALUES (N'TL06', N'HD191216195739', 10, 10000, 100000)
INSERT [dbo].[CHITIETHD] ([MaTaiLieu], [MaHD], [SoLuong], [DonGia], [ThanhTien]) VALUES (N'TL07', N'HD191216195739', 20, 74000, 1480000)
INSERT [dbo].[CHITIETPHIEUMUON] ([MaPM], [MaTaiLieu], [HanTra], [NgayTra], [TienPhat], [TienBoiThuong]) VALUES (N'PM121216231933', N'TL002', 2, CAST(0x0000A6DE00000000 AS DateTime), 1500, 0)
INSERT [dbo].[CHITIETPHIEUMUON] ([MaPM], [MaTaiLieu], [HanTra], [NgayTra], [TienPhat], [TienBoiThuong]) VALUES (N'PM151216102116', N'TL002', 10, CAST(0x0000A6DD00AB5C84 AS DateTime), 0, 10000)
INSERT [dbo].[CHITIETPHIEUMUON] ([MaPM], [MaTaiLieu], [HanTra], [NgayTra], [TienPhat], [TienBoiThuong]) VALUES (N'PM151216113452', N'TL002', 10, CAST(0x0000A6DD00BF453E AS DateTime), 0, 0)
INSERT [dbo].[CHITIETPHIEUMUON] ([MaPM], [MaTaiLieu], [HanTra], [NgayTra], [TienPhat], [TienBoiThuong]) VALUES (N'PM151216113547', N'TL002', 10, CAST(0x0000A6DD00BF5FDD AS DateTime), 0, 0)
INSERT [dbo].[CHITIETPHIEUMUON] ([MaPM], [MaTaiLieu], [HanTra], [NgayTra], [TienPhat], [TienBoiThuong]) VALUES (N'PM151216113932', N'TL002', 5, NULL, NULL, NULL)
INSERT [dbo].[CHITIETPHIEUMUON] ([MaPM], [MaTaiLieu], [HanTra], [NgayTra], [TienPhat], [TienBoiThuong]) VALUES (N'PM191216190600', N'TL004', 10, NULL, NULL, NULL)
INSERT [dbo].[CHITIETPHIEUMUON] ([MaPM], [MaTaiLieu], [HanTra], [NgayTra], [TienPhat], [TienBoiThuong]) VALUES (N'PM191216190646', N'TL004', 10, NULL, NULL, NULL)
INSERT [dbo].[CHITIETPHIEUMUON] ([MaPM], [MaTaiLieu], [HanTra], [NgayTra], [TienPhat], [TienBoiThuong]) VALUES (N'PM121216231932', N'TL01', 10, NULL, NULL, NULL)
INSERT [dbo].[CHITIETPHIEUMUON] ([MaPM], [MaTaiLieu], [HanTra], [NgayTra], [TienPhat], [TienBoiThuong]) VALUES (N'PM121216231932', N'TL02', 10, NULL, NULL, NULL)
INSERT [dbo].[CHITIETPHIEUMUON] ([MaPM], [MaTaiLieu], [HanTra], [NgayTra], [TienPhat], [TienBoiThuong]) VALUES (N'PM151216113528', N'TL02', 10, CAST(0x0000A6DD00BF523E AS DateTime), 0, 0)
INSERT [dbo].[CHITIETPHIEUMUON] ([MaPM], [MaTaiLieu], [HanTra], [NgayTra], [TienPhat], [TienBoiThuong]) VALUES (N'PM121216231932', N'TL03', 10, NULL, NULL, NULL)
INSERT [dbo].[CHITIETPHIEUMUON] ([MaPM], [MaTaiLieu], [HanTra], [NgayTra], [TienPhat], [TienBoiThuong]) VALUES (N'PM121216231933', N'TL03', 2, CAST(0x0000A6DC00000000 AS DateTime), 500, 0)
INSERT [dbo].[CHITIETPHIEUMUON] ([MaPM], [MaTaiLieu], [HanTra], [NgayTra], [TienPhat], [TienBoiThuong]) VALUES (N'PM151216113932', N'TL03', 3, NULL, NULL, NULL)
INSERT [dbo].[CHITIETPHIEUMUON] ([MaPM], [MaTaiLieu], [HanTra], [NgayTra], [TienPhat], [TienBoiThuong]) VALUES (N'PM191216190510', N'TL05', 10, NULL, NULL, NULL)
INSERT [dbo].[CHITIETPHIEUMUON] ([MaPM], [MaTaiLieu], [HanTra], [NgayTra], [TienPhat], [TienBoiThuong]) VALUES (N'PM191216190510', N'TL06', 10, NULL, NULL, NULL)
INSERT [dbo].[CHITIETPHIEUMUON] ([MaPM], [MaTaiLieu], [HanTra], [NgayTra], [TienPhat], [TienBoiThuong]) VALUES (N'PM191216190510', N'TL07', 10, NULL, NULL, NULL)
INSERT [dbo].[CHITIETPHIEUMUON] ([MaPM], [MaTaiLieu], [HanTra], [NgayTra], [TienPhat], [TienBoiThuong]) VALUES (N'PM191216190600', N'TL07', 10, NULL, NULL, NULL)
INSERT [dbo].[CHITIETPHIEUMUON] ([MaPM], [MaTaiLieu], [HanTra], [NgayTra], [TienPhat], [TienBoiThuong]) VALUES (N'PM191216190646', N'TL07', 10, NULL, NULL, NULL)
INSERT [dbo].[CHUYENNGANH] ([MaChuyenNganh], [TenChuyenNganh]) VALUES (N'NSX01', N'Sách Đại Cương')
INSERT [dbo].[CHUYENNGANH] ([MaChuyenNganh], [TenChuyenNganh]) VALUES (N'CNTT', N'Công Nghệ Thông Tin')
INSERT [dbo].[CHUYENNGANH] ([MaChuyenNganh], [TenChuyenNganh]) VALUES (N'CNTP', N'Công Nghệ Thực Phẩm')
INSERT [dbo].[CHUYENNGANH] ([MaChuyenNganh], [TenChuyenNganh]) VALUES (N'CNHH', N'Công Nghệ Hóa Học')
INSERT [dbo].[CHUYENNGANH] ([MaChuyenNganh], [TenChuyenNganh]) VALUES (N'ATTP', N'An Toàn Thực Phẩm')
INSERT [dbo].[CHUYENNGANH] ([MaChuyenNganh], [TenChuyenNganh]) VALUES (N'CNSH', N'Công Nghệ Sinh Học')
INSERT [dbo].[CHUYENNGANH] ([MaChuyenNganh], [TenChuyenNganh]) VALUES (N'CNM', N'Công Nghệ May')
INSERT [dbo].[CHUYENNGANH] ([MaChuyenNganh], [TenChuyenNganh]) VALUES (N'adas', N'Điện Tử')
INSERT [dbo].[CHUYENNGANH] ([MaChuyenNganh], [TenChuyenNganh]) VALUES (N'K', N'Khác')
INSERT [dbo].[DOCGIA] ([MaDocGia], [MaLoaiDG], [TenDocGia], [GioiTinh], [NgaySinh], [Email], [NgayDangKy], [HanThe], [TienCoc], [SoSachDangMuon]) VALUES (N'2001130154', N'LDG001', N'Nguyễn Dung', N'Nữ', CAST(0xB31D0B00 AS Date), N'dunghuynh@gmail.com', CAST(0xED370B00 AS Date), 4, 100000, 3)
INSERT [dbo].[DOCGIA] ([MaDocGia], [MaLoaiDG], [TenDocGia], [GioiTinh], [NgaySinh], [Email], [NgayDangKy], [HanThe], [TienCoc], [SoSachDangMuon]) VALUES (N'2001130170', N'LDG001', N'Hồ Trần Tín', N'Nam', CAST(0x6C1C0B00 AS Date), N'hotrantin@gmai.com', CAST(0x59390B00 AS Date), 4, 100000, 4)
INSERT [dbo].[DOCGIA] ([MaDocGia], [MaLoaiDG], [TenDocGia], [GioiTinh], [NgaySinh], [Email], [NgayDangKy], [HanThe], [TienCoc], [SoSachDangMuon]) VALUES (N'2001130141', N'LDG001', N'Nguyễn Hoài Lâm', N'Nam', CAST(0xDC1C0B00 AS Date), N'hoailam0606@gmail.com', CAST(0xEB370B00 AS Date), 4, 100000, 2)
INSERT [dbo].[DOCGIA] ([MaDocGia], [MaLoaiDG], [TenDocGia], [GioiTinh], [NgaySinh], [Email], [NgayDangKy], [HanThe], [TienCoc], [SoSachDangMuon]) VALUES (N'DG004', N'LDG002', N'Bùi Công Danh', N'Nam', CAST(0xD8080B00 AS Date), N'danhbc@cntp.edu.vn', CAST(0xED370B00 AS Date), 2, 200000, 2)
INSERT [dbo].[DOCGIA] ([MaDocGia], [MaLoaiDG], [TenDocGia], [GioiTinh], [NgaySinh], [Email], [NgayDangKy], [HanThe], [TienCoc], [SoSachDangMuon]) VALUES (N'2001130174', N'LDG001', N'Phạm Thu Hiền', N'Nữ', CAST(0x5E1D0B00 AS Date), N'thuhien.pham25@gmail.com', CAST(0x87360B00 AS Date), 4, 100000, 0)
INSERT [dbo].[DOCGIA] ([MaDocGia], [MaLoaiDG], [TenDocGia], [GioiTinh], [NgaySinh], [Email], [NgayDangKy], [HanThe], [TienCoc], [SoSachDangMuon]) VALUES (N'2001130172', N'LDG001', N'Đặng Quang Đông', N'Nam', CAST(0xA91C0B00 AS Date), N'quangdong211@gmail.com', CAST(0x85360B00 AS Date), 4, 100000, 0)
INSERT [dbo].[DOCGIA] ([MaDocGia], [MaLoaiDG], [TenDocGia], [GioiTinh], [NgaySinh], [Email], [NgayDangKy], [HanThe], [TienCoc], [SoSachDangMuon]) VALUES (N'2001130176', N'LDG001', N'Huỳnh Thị Cẩm Dung', N'Nữ', CAST(0xB31D0B00 AS Date), N'dunghuynh@gmail.com', CAST(0x84360B00 AS Date), 4, 100000, 0)
INSERT [dbo].[DOCGIA] ([MaDocGia], [MaLoaiDG], [TenDocGia], [GioiTinh], [NgaySinh], [Email], [NgayDangKy], [HanThe], [TienCoc], [SoSachDangMuon]) VALUES (N'2001130184', N'LDG001', N'Nguyễn Thị Rơi', N'Nữ', CAST(0x331D0B00 AS Date), N'namlun@gmail.com', CAST(0x383C0B00 AS Date), 4, 100000, 0)
INSERT [dbo].[DOCGIA] ([MaDocGia], [MaLoaiDG], [TenDocGia], [GioiTinh], [NgaySinh], [Email], [NgayDangKy], [HanThe], [TienCoc], [SoSachDangMuon]) VALUES (N'2001130195', N'LDG001', N'Phan Thị Thanh Hằng', N'Nữ', CAST(0xE53B0B00 AS Date), N'thanhhang@gmail.com', CAST(0x373C0B00 AS Date), 4, 100000, 2)
INSERT [dbo].[HOADON] ([MaHD], [MaNV], [MaNCC], [NgayLap], [TongTien]) VALUES (N'HD061216144035', N'NV06', N'CC01', CAST(0x2F3C0B00 AS Date), 2333320)
INSERT [dbo].[HOADON] ([MaHD], [MaNV], [MaNCC], [NgayLap], [TongTien]) VALUES (N'HD061216114405', N'NV06', N'CC01', CAST(0x2F3C0B00 AS Date), 3000000)
INSERT [dbo].[HOADON] ([MaHD], [MaNV], [MaNCC], [NgayLap], [TongTien]) VALUES (N'HD061216114422', N'NV06', N'CC01', CAST(0x2F3C0B00 AS Date), 400000)
INSERT [dbo].[HOADON] ([MaHD], [MaNV], [MaNCC], [NgayLap], [TongTien]) VALUES (N'HD071216002821', N'NV06', N'CC02', CAST(0x303C0B00 AS Date), 6000000)
INSERT [dbo].[HOADON] ([MaHD], [MaNV], [MaNCC], [NgayLap], [TongTien]) VALUES (N'HD151216094350', N'NV05', N'CC01', CAST(0x383C0B00 AS Date), 950000)
INSERT [dbo].[HOADON] ([MaHD], [MaNV], [MaNCC], [NgayLap], [TongTien]) VALUES (N'HD071216003203', N'NV01', N'CC01', CAST(0x303C0B00 AS Date), 2700000)
INSERT [dbo].[HOADON] ([MaHD], [MaNV], [MaNCC], [NgayLap], [TongTien]) VALUES (N'HD191216195739', N'NV06', N'CC01', CAST(0x3C3C0B00 AS Date), 3630000)
INSERT [dbo].[LOAIDOCGIA] ([MaLoaiDG], [TenLoaiDG]) VALUES (N'LDG001', N'Sinh Viên')
INSERT [dbo].[LOAIDOCGIA] ([MaLoaiDG], [TenLoaiDG]) VALUES (N'LDG002', N'Giảng Viên')
INSERT [dbo].[LOAITAILIEU] ([MaLoai], [TenLoai]) VALUES (N'LoaiTL04', N'Truyện Tranh')
INSERT [dbo].[LOAITAILIEU] ([MaLoai], [TenLoai]) VALUES (N'LoaiTL03', N'Slide Bài Giảng')
INSERT [dbo].[LOAITAILIEU] ([MaLoai], [TenLoai]) VALUES (N'LoaiTL01', N'Giáo Trình')
INSERT [dbo].[LOAITAILIEU] ([MaLoai], [TenLoai]) VALUES (N'LoaiTL02', N'Tạp Chí')
INSERT [dbo].[LOAITAILIEU] ([MaLoai], [TenLoai]) VALUES (N'LoaiTL05', N'Tài Liệu Tham Khảo')
INSERT [dbo].[NGUOIDUNG] ([TenTaiKhoan], [MaNV], [MatKhau], [HoatDong]) VALUES (N'hien', N'NV05', N'/RVIYkB621A=', 1)
INSERT [dbo].[NGUOIDUNG] ([TenTaiKhoan], [MaNV], [MatKhau], [HoatDong]) VALUES (N'dong', N'NV06', N'/RVIYkB621A=', 1)
INSERT [dbo].[NGUOIDUNG] ([TenTaiKhoan], [MaNV], [MatKhau], [HoatDong]) VALUES (N'admin', N'NV01', N'/RVIYkB621A=', 1)
INSERT [dbo].[NGUOIDUNG] ([TenTaiKhoan], [MaNV], [MatKhau], [HoatDong]) VALUES (N'sang', N'NV02', N'/RVIYkB621A=', 1)
INSERT [dbo].[NHACUNGCAP] ([MaNCC], [TenNCC], [DiaChiNCC], [SDT]) VALUES (N'CC01', N'Nhà Sách Tân Bình', N'Quận Tân Bình', N'083456432   ')
INSERT [dbo].[NHACUNGCAP] ([MaNCC], [TenNCC], [DiaChiNCC], [SDT]) VALUES (N'CC02', N'Nhà Sách Nhân Văn', N'Quận 1', N'083456123   ')
INSERT [dbo].[NHANVIEN] ([MaNV], [TenNV], [DiaChi], [SDT_NV], [Email_NV], [ChucVu]) VALUES (N'NV01', N'Thuy Ha', N'Quan Tan Phu - TPHCM', N'0969275774', N'thuyha@gmail.com', N'Tong Giam')
INSERT [dbo].[NHANVIEN] ([MaNV], [TenNV], [DiaChi], [SDT_NV], [Email_NV], [ChucVu]) VALUES (N'NV02', N'Nguyen Van Sang', N'TPHCM', N'01682734321', N'sangnv@gmail.com', N'Thu Thu')
INSERT [dbo].[NHANVIEN] ([MaNV], [TenNV], [DiaChi], [SDT_NV], [Email_NV], [ChucVu]) VALUES (N'NV03', N'Luu Thi Luyen', N'TP HCM', N'01612312341', N'thiluyen@gmail.com', N'Thu Kho')
INSERT [dbo].[NHANVIEN] ([MaNV], [TenNV], [DiaChi], [SDT_NV], [Email_NV], [ChucVu]) VALUES (N'NV04', N'Nguyen Thien Huong', N'TP HCM', N'01234567892', N'thienhuong@gmail.com', N'Thu Thu')
INSERT [dbo].[NHANVIEN] ([MaNV], [TenNV], [DiaChi], [SDT_NV], [Email_NV], [ChucVu]) VALUES (N'NV05', N'Phạm Thu Hiền', N'Đồng Tháp', N'0969275746', N'thuhien.pham@gmail.com', N'Boss1')
INSERT [dbo].[NHANVIEN] ([MaNV], [TenNV], [DiaChi], [SDT_NV], [Email_NV], [ChucVu]) VALUES (N'NV06', N'Đặng Quang Đông', N'TP HCM', N'01633889983', N'quangdong211@gmail.com', N'Boss2')
INSERT [dbo].[PHIEUMUON] ([MaPM], [MaDocGia], [MaNV], [NgayMuon], [TinhTrang]) VALUES (N'PM151216102116', N'2001130141', N'NV05', CAST(0x383C0B00 AS Date), N'Đã trả')
INSERT [dbo].[PHIEUMUON] ([MaPM], [MaDocGia], [MaNV], [NgayMuon], [TinhTrang]) VALUES (N'PM151216113452', N'DG004', N'NV05', CAST(0x383C0B00 AS Date), N'Đã trả')
INSERT [dbo].[PHIEUMUON] ([MaPM], [MaDocGia], [MaNV], [NgayMuon], [TinhTrang]) VALUES (N'PM151216113528', N'DG004', N'NV05', CAST(0x383C0B00 AS Date), N'Đã trả')
INSERT [dbo].[PHIEUMUON] ([MaPM], [MaDocGia], [MaNV], [NgayMuon], [TinhTrang]) VALUES (N'PM151216113547', N'DG004', N'NV05', CAST(0x383C0B00 AS Date), N'Đã trả')
INSERT [dbo].[PHIEUMUON] ([MaPM], [MaDocGia], [MaNV], [NgayMuon], [TinhTrang]) VALUES (N'PM151216113932', N'DG004', N'NV05', CAST(0x383C0B00 AS Date), N'Chưa trả')
INSERT [dbo].[PHIEUMUON] ([MaPM], [MaDocGia], [MaNV], [NgayMuon], [TinhTrang]) VALUES (N'PM121216231932', N'2001130174', N'NV05', CAST(0x2E3C0B00 AS Date), N'Chưa trả')
INSERT [dbo].[PHIEUMUON] ([MaPM], [MaDocGia], [MaNV], [NgayMuon], [TinhTrang]) VALUES (N'PM121216231933', N'2001130170', N'NV06', CAST(0x353C0B00 AS Date), N'Đã trả')
INSERT [dbo].[PHIEUMUON] ([MaPM], [MaDocGia], [MaNV], [NgayMuon], [TinhTrang]) VALUES (N'PM191216190510', N'2001130154', N'NV06', CAST(0x3C3C0B00 AS Date), N'Chưa trả')
INSERT [dbo].[PHIEUMUON] ([MaPM], [MaDocGia], [MaNV], [NgayMuon], [TinhTrang]) VALUES (N'PM191216190600', N'2001130141', N'NV06', CAST(0x3C3C0B00 AS Date), N'Chưa trả')
INSERT [dbo].[PHIEUMUON] ([MaPM], [MaDocGia], [MaNV], [NgayMuon], [TinhTrang]) VALUES (N'PM191216190646', N'2001130195', N'NV06', CAST(0x3C3C0B00 AS Date), N'Chưa trả')
INSERT [dbo].[TAILIEU] ([MaTaiLieu], [MaLoai], [MaChuyenNganh], [TenTaiLieu], [TacGia], [NamSanXuat], [DonGiaTL], [MoTa], [SoLuongTon], [SoLuongMuon], [SoLuongHuHao]) VALUES (N'TL01', N'LoaiTL01', N'NSX01', N'Giáo trình toán cao cấp 1', N'Nguyễn Thế Sang', 2015, 80000, N'Mới', 23, 1, 4)
INSERT [dbo].[TAILIEU] ([MaTaiLieu], [MaLoai], [MaChuyenNganh], [TenTaiLieu], [TacGia], [NamSanXuat], [DonGiaTL], [MoTa], [SoLuongTon], [SoLuongMuon], [SoLuongHuHao]) VALUES (N'TL02', N'LoaiTL01', N'NSX01', N'Giáo trình toán cao cấp 2', N'Nguyễn Thế Sang', 2015, 90000, N'Mới', 33, 1, 2)
INSERT [dbo].[TAILIEU] ([MaTaiLieu], [MaLoai], [MaChuyenNganh], [TenTaiLieu], [TacGia], [NamSanXuat], [DonGiaTL], [MoTa], [SoLuongTon], [SoLuongMuon], [SoLuongHuHao]) VALUES (N'TL03', N'LoaiTL01', N'NSX01', N'Giáo trình toán cao cấp 3', N'Nguyễn Thế Sang', 2015, 100000, N'Mới', 34, 1, 2)
INSERT [dbo].[TAILIEU] ([MaTaiLieu], [MaLoai], [MaChuyenNganh], [TenTaiLieu], [TacGia], [NamSanXuat], [DonGiaTL], [MoTa], [SoLuongTon], [SoLuongMuon], [SoLuongHuHao]) VALUES (N'TL002', N'LoaiTL01', N'CNTT', N'Giáo Trình CSDL', N'Liên Chi', 2014, 95000, N'Sách chuyên ngành CNTT', 33, 0, 1)
INSERT [dbo].[TAILIEU] ([MaTaiLieu], [MaLoai], [MaChuyenNganh], [TenTaiLieu], [TacGia], [NamSanXuat], [DonGiaTL], [MoTa], [SoLuongTon], [SoLuongMuon], [SoLuongHuHao]) VALUES (N'TL003', N'LoaiTL01', N'CNTT', N'Giáo Trình Tin Học Đại Cương', N'Trần Đức', 2014, 80000, N'Mới', 50, 0, 1)
INSERT [dbo].[TAILIEU] ([MaTaiLieu], [MaLoai], [MaChuyenNganh], [TenTaiLieu], [TacGia], [NamSanXuat], [DonGiaTL], [MoTa], [SoLuongTon], [SoLuongMuon], [SoLuongHuHao]) VALUES (N'TL004', N'LoaiTL01', N'CNTT', N'Giáo Trình CSDL Phân Tán', N'Nguyễn Thị Liên Chi', 2015, 40000, N'Mới', 48, 2, 0)
INSERT [dbo].[TAILIEU] ([MaTaiLieu], [MaLoai], [MaChuyenNganh], [TenTaiLieu], [TacGia], [NamSanXuat], [DonGiaTL], [MoTa], [SoLuongTon], [SoLuongMuon], [SoLuongHuHao]) VALUES (N'TL05', N'LoaiTL02', N'K', N'Sinh Viên', N'Nhà xuất bản Tuổi Trẻ', 2016, 10000, N'Mới', 4, 1, 0)
INSERT [dbo].[TAILIEU] ([MaTaiLieu], [MaLoai], [MaChuyenNganh], [TenTaiLieu], [TacGia], [NamSanXuat], [DonGiaTL], [MoTa], [SoLuongTon], [SoLuongMuon], [SoLuongHuHao]) VALUES (N'TL06', N'LoaiTL04', N'K', N'Conan', N'Fuji Kuwara', 2016, 10000, N'Mới', 9, 1, 0)
INSERT [dbo].[TAILIEU] ([MaTaiLieu], [MaLoai], [MaChuyenNganh], [TenTaiLieu], [TacGia], [NamSanXuat], [DonGiaTL], [MoTa], [SoLuongTon], [SoLuongMuon], [SoLuongHuHao]) VALUES (N'TL07', N'LoaiTL05', N'CNTP', N'An Toàn Vệ Sinh Thực Phẩm', N'Huỳnh Đức Trí', 2015, 74000, N'Mới', 17, 3, 0)
SET ANSI_PADDING ON

GO
/****** Object:  Index [PK_NHASANXUAT]    Script Date: 19/12/2016 7:14:26 PM ******/
ALTER TABLE [dbo].[CHUYENNGANH] ADD  CONSTRAINT [PK_NHASANXUAT] PRIMARY KEY NONCLUSTERED 
(
	[MaChuyenNganh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [PK_DOCGIA]    Script Date: 19/12/2016 7:14:26 PM ******/
ALTER TABLE [dbo].[DOCGIA] ADD  CONSTRAINT [PK_DOCGIA] PRIMARY KEY NONCLUSTERED 
(
	[MaDocGia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [PK_HOADON]    Script Date: 19/12/2016 7:14:26 PM ******/
ALTER TABLE [dbo].[HOADON] ADD  CONSTRAINT [PK_HOADON] PRIMARY KEY NONCLUSTERED 
(
	[MaHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [PK_LOAIDOCGIA]    Script Date: 19/12/2016 7:14:26 PM ******/
ALTER TABLE [dbo].[LOAIDOCGIA] ADD  CONSTRAINT [PK_LOAIDOCGIA] PRIMARY KEY NONCLUSTERED 
(
	[MaLoaiDG] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [PK_LOAITAILIEU]    Script Date: 19/12/2016 7:14:26 PM ******/
ALTER TABLE [dbo].[LOAITAILIEU] ADD  CONSTRAINT [PK_LOAITAILIEU] PRIMARY KEY NONCLUSTERED 
(
	[MaLoai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [PK_MANHINH]    Script Date: 19/12/2016 7:14:26 PM ******/
ALTER TABLE [dbo].[MANHINH] ADD  CONSTRAINT [PK_MANHINH] PRIMARY KEY NONCLUSTERED 
(
	[MaManHinh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [PK_NGUOIDUNG]    Script Date: 19/12/2016 7:14:26 PM ******/
ALTER TABLE [dbo].[NGUOIDUNG] ADD  CONSTRAINT [PK_NGUOIDUNG] PRIMARY KEY NONCLUSTERED 
(
	[TenTaiKhoan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [PK_NHACUNGCAP]    Script Date: 19/12/2016 7:14:26 PM ******/
ALTER TABLE [dbo].[NHACUNGCAP] ADD  CONSTRAINT [PK_NHACUNGCAP] PRIMARY KEY NONCLUSTERED 
(
	[MaNCC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [PK_NHANVIEN]    Script Date: 19/12/2016 7:14:26 PM ******/
ALTER TABLE [dbo].[NHANVIEN] ADD  CONSTRAINT [PK_NHANVIEN] PRIMARY KEY NONCLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [PK_NHOMNGUOIDUNG]    Script Date: 19/12/2016 7:14:26 PM ******/
ALTER TABLE [dbo].[NHOMNGUOIDUNG] ADD  CONSTRAINT [PK_NHOMNGUOIDUNG] PRIMARY KEY NONCLUSTERED 
(
	[MaNhom] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [PK_PHIEUMUON]    Script Date: 19/12/2016 7:14:26 PM ******/
ALTER TABLE [dbo].[PHIEUMUON] ADD  CONSTRAINT [PK_PHIEUMUON] PRIMARY KEY NONCLUSTERED 
(
	[MaPM] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [PK_TAILIEU]    Script Date: 19/12/2016 7:14:26 PM ******/
ALTER TABLE [dbo].[TAILIEU] ADD  CONSTRAINT [PK_TAILIEU] PRIMARY KEY NONCLUSTERED 
(
	[MaTaiLieu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[CHITIETHD]  WITH CHECK ADD  CONSTRAINT [FK_CHITIETH_CHITIETHD_HOADON] FOREIGN KEY([MaHD])
REFERENCES [dbo].[HOADON] ([MaHD])
GO
ALTER TABLE [dbo].[CHITIETHD] CHECK CONSTRAINT [FK_CHITIETH_CHITIETHD_HOADON]
GO
ALTER TABLE [dbo].[CHITIETHD]  WITH CHECK ADD  CONSTRAINT [FK_CHITIETH_CHITIETHD_TAILIEU] FOREIGN KEY([MaTaiLieu])
REFERENCES [dbo].[TAILIEU] ([MaTaiLieu])
GO
ALTER TABLE [dbo].[CHITIETHD] CHECK CONSTRAINT [FK_CHITIETH_CHITIETHD_TAILIEU]
GO
ALTER TABLE [dbo].[CHITIETPHIEUMUON]  WITH CHECK ADD  CONSTRAINT [FK_CHITIETP_CHITIETPH_PHIEUMUO] FOREIGN KEY([MaPM])
REFERENCES [dbo].[PHIEUMUON] ([MaPM])
GO
ALTER TABLE [dbo].[CHITIETPHIEUMUON] CHECK CONSTRAINT [FK_CHITIETP_CHITIETPH_PHIEUMUO]
GO
ALTER TABLE [dbo].[CHITIETPHIEUMUON]  WITH CHECK ADD  CONSTRAINT [FK_CHITIETP_CHITIETPH_TAILIEU] FOREIGN KEY([MaTaiLieu])
REFERENCES [dbo].[TAILIEU] ([MaTaiLieu])
GO
ALTER TABLE [dbo].[CHITIETPHIEUMUON] CHECK CONSTRAINT [FK_CHITIETP_CHITIETPH_TAILIEU]
GO
ALTER TABLE [dbo].[DOCGIA]  WITH CHECK ADD  CONSTRAINT [FK_DOCGIA_BAO G?M_LOAIDOCG] FOREIGN KEY([MaLoaiDG])
REFERENCES [dbo].[LOAIDOCGIA] ([MaLoaiDG])
GO
ALTER TABLE [dbo].[DOCGIA] CHECK CONSTRAINT [FK_DOCGIA_BAO G?M_LOAIDOCG]
GO
ALTER TABLE [dbo].[HOADON]  WITH CHECK ADD  CONSTRAINT [FK_HOADON_CUNG C?P_NHACUNGC] FOREIGN KEY([MaNCC])
REFERENCES [dbo].[NHACUNGCAP] ([MaNCC])
GO
ALTER TABLE [dbo].[HOADON] CHECK CONSTRAINT [FK_HOADON_CUNG C?P_NHACUNGC]
GO
ALTER TABLE [dbo].[HOADON]  WITH CHECK ADD  CONSTRAINT [FK_HOADON_NHANVIEN] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NHANVIEN] ([MaNV])
GO
ALTER TABLE [dbo].[HOADON] CHECK CONSTRAINT [FK_HOADON_NHANVIEN]
GO
ALTER TABLE [dbo].[NGUOIDUNG]  WITH CHECK ADD  CONSTRAINT [FK_NGUOIDUN_RELATIONS_NHANVIEN] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NHANVIEN] ([MaNV])
GO
ALTER TABLE [dbo].[NGUOIDUNG] CHECK CONSTRAINT [FK_NGUOIDUN_RELATIONS_NHANVIEN]
GO
ALTER TABLE [dbo].[NGUOIDUNG_NHOMNGUOIDUNG]  WITH CHECK ADD  CONSTRAINT [FK_NGUOIDUN_NGUOIDUNG_NGUOIDUN] FOREIGN KEY([TenTaiKhoan])
REFERENCES [dbo].[NGUOIDUNG] ([TenTaiKhoan])
GO
ALTER TABLE [dbo].[NGUOIDUNG_NHOMNGUOIDUNG] CHECK CONSTRAINT [FK_NGUOIDUN_NGUOIDUNG_NGUOIDUN]
GO
ALTER TABLE [dbo].[NGUOIDUNG_NHOMNGUOIDUNG]  WITH CHECK ADD  CONSTRAINT [FK_NGUOIDUN_NGUOIDUNG_NHOMNGUO] FOREIGN KEY([MaNhom])
REFERENCES [dbo].[NHOMNGUOIDUNG] ([MaNhom])
GO
ALTER TABLE [dbo].[NGUOIDUNG_NHOMNGUOIDUNG] CHECK CONSTRAINT [FK_NGUOIDUN_NGUOIDUNG_NHOMNGUO]
GO
ALTER TABLE [dbo].[PHANQUYEN]  WITH CHECK ADD  CONSTRAINT [FK_PHANQUYE_PHANQUYEN_MANHINH] FOREIGN KEY([MaManHinh])
REFERENCES [dbo].[MANHINH] ([MaManHinh])
GO
ALTER TABLE [dbo].[PHANQUYEN] CHECK CONSTRAINT [FK_PHANQUYE_PHANQUYEN_MANHINH]
GO
ALTER TABLE [dbo].[PHANQUYEN]  WITH CHECK ADD  CONSTRAINT [FK_PHANQUYE_PHANQUYEN_NHOMNGUO] FOREIGN KEY([MaNhom])
REFERENCES [dbo].[NHOMNGUOIDUNG] ([MaNhom])
GO
ALTER TABLE [dbo].[PHANQUYEN] CHECK CONSTRAINT [FK_PHANQUYE_PHANQUYEN_NHOMNGUO]
GO
ALTER TABLE [dbo].[PHIEUMUON]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUMUO_LÀM_DOCGIA] FOREIGN KEY([MaDocGia])
REFERENCES [dbo].[DOCGIA] ([MaDocGia])
GO
ALTER TABLE [dbo].[PHIEUMUON] CHECK CONSTRAINT [FK_PHIEUMUO_LÀM_DOCGIA]
GO
ALTER TABLE [dbo].[PHIEUMUON]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUMUON_NHANVIEN] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NHANVIEN] ([MaNV])
GO
ALTER TABLE [dbo].[PHIEUMUON] CHECK CONSTRAINT [FK_PHIEUMUON_NHANVIEN]
GO
ALTER TABLE [dbo].[TAILIEU]  WITH CHECK ADD  CONSTRAINT [FK_TAILIEU_CÓ_NHASANXU] FOREIGN KEY([MaChuyenNganh])
REFERENCES [dbo].[CHUYENNGANH] ([MaChuyenNganh])
GO
ALTER TABLE [dbo].[TAILIEU] CHECK CONSTRAINT [FK_TAILIEU_CÓ_NHASANXU]
GO
ALTER TABLE [dbo].[TAILIEU]  WITH CHECK ADD  CONSTRAINT [FK_TAILIEU_NHANVIEN] FOREIGN KEY([MaLoai])
REFERENCES [dbo].[LOAITAILIEU] ([MaLoai])
GO
ALTER TABLE [dbo].[TAILIEU] CHECK CONSTRAINT [FK_TAILIEU_NHANVIEN]
GO
/****** Object:  Trigger [dbo].[DELETE_SOLUONG_NHAPHANG]    Script Date: 19/12/2016 7:14:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[DELETE_SOLUONG_NHAPHANG] ON [dbo].[CHITIETHD]
FOR DELETE
AS
	BEGIN
		UPDATE TAILIEU
		SET SoLuongTon = SoLuongTon - (SELECT SoLuong FROM deleted)
		WHERE MaTaiLieu = (SELECT MaTaiLieu FROM deleted)
	END

GO
/****** Object:  Trigger [dbo].[INSERT_DONGIATL_NHAPHANG]    Script Date: 19/12/2016 7:14:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[INSERT_DONGIATL_NHAPHANG] ON [dbo].[CHITIETHD]
FOR INSERT, UPDATE
AS
	BEGIN
		UPDATE TAILIEU
		SET DonGiaTL = (SELECT DonGia FROM inserted)
		WHERE MaTaiLieu = (SELECT MaTaiLieu FROM inserted)
	END

GO
/****** Object:  Trigger [dbo].[INSERT_SOLUONG_NHAPHANG]    Script Date: 19/12/2016 7:14:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[INSERT_SOLUONG_NHAPHANG] ON [dbo].[CHITIETHD]
FOR INSERT
AS
	BEGIN
		UPDATE TAILIEU
		SET SoLuongTon = SoLuongTon + (SELECT SoLuong FROM inserted)
		WHERE MaTaiLieu = (SELECT MaTaiLieu FROM inserted)
	END

GO
/****** Object:  Trigger [dbo].[CAPNHAP_TINHTRANG_PHIEUMUON]    Script Date: 19/12/2016 7:14:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[CAPNHAP_TINHTRANG_PHIEUMUON] ON [dbo].[CHITIETPHIEUMUON]
FOR INSERT, UPDATE
AS 
	IF EXISTS (SELECT PHIEUMUON.MaPM FROM inserted, PHIEUMUON WHERE inserted.MaPM = PHIEUMUON.MaPM and inserted.NgayTra is null)
		BEGIN
			UPDATE PHIEUMUON
			SET TinhTrang = N'Chưa trả'
			WHERE MaPM = (SELECT MaPM FROM inserted) 
		END
	ELSE
		BEGIN
			IF EXISTS (SELECT PHIEUMUON.MaPM FROM inserted, PHIEUMUON WHERE inserted.MaPM = PHIEUMUON.MaPM and inserted.NgayTra is not null)
			BEGIN
				UPDATE PHIEUMUON
				SET TinhTrang = N'Đã trả'
				WHERE MaPM = (SELECT MaPM FROM inserted) 
			END
		END

GO
/****** Object:  Trigger [dbo].[DELETE_SOLUONG_CTPHIEUMUON]    Script Date: 19/12/2016 7:14:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[DELETE_SOLUONG_CTPHIEUMUON] ON [dbo].[CHITIETPHIEUMUON]
FOR DELETE
AS
	BEGIN
		UPDATE TAILIEU 
		SET SoLuongTon = SoLuongTon + 1,
			SoLuongMuon = SoLuongMuon - 1
		WHERE MaTaiLieu = (SELECT MaTaiLieu FROM deleted)
	END

GO
/****** Object:  Trigger [dbo].[INSERT_SOLUONG_CTPHIEUMUON]    Script Date: 19/12/2016 7:14:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[INSERT_SOLUONG_CTPHIEUMUON] ON [dbo].[CHITIETPHIEUMUON]
FOR INSERT
AS
	BEGIN
		UPDATE TAILIEU 
		SET SoLuongTon = SoLuongTon - 1,
			SoLuongMuon = SoLuongMuon + 1
		WHERE MaTaiLieu = (SELECT MaTaiLieu FROM inserted)
	END

GO
/****** Object:  Trigger [dbo].[INSERT_SOSACHDANGMUON_CTPHIEUMUON]    Script Date: 19/12/2016 7:14:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[INSERT_SOSACHDANGMUON_CTPHIEUMUON] ON [dbo].[CHITIETPHIEUMUON]
FOR INSERT, UPDATE
AS
	IF EXISTS (SELECT PHIEUMUON.MaDocGia FROM inserted join PHIEUMUON on inserted.MaPM = PHIEUMUON.MaPM WHERE NgayTra is null)
		BEGIN
			UPDATE DOCGIA
			SET SoSachDangMuon = SoSachDangMuon + 1
			WHERE MaDocGia = (SELECT PHIEUMUON.MaDocGia FROM inserted join PHIEUMUON on inserted.MaPM = PHIEUMUON.MaPM WHERE NgayTra is null)
		END
	ELSE
		BEGIN
			UPDATE DOCGIA
			SET SoSachDangMuon = SoSachDangMuon - 1
			WHERE MaDocGia = (SELECT PHIEUMUON.MaDocGia FROM inserted join PHIEUMUON on inserted.MaPM = PHIEUMUON.MaPM WHERE NgayTra is not null)
		END

GO
/****** Object:  Trigger [dbo].[UPDATE_SOLUONG_CTPHIEUMUON]    Script Date: 19/12/2016 7:14:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[UPDATE_SOLUONG_CTPHIEUMUON] ON [dbo].[CHITIETPHIEUMUON]
FOR UPDATE
AS
	IF EXISTS (SELECT MaPM FROM inserted WHERE NgayTra is not null)
		BEGIN
			UPDATE TAILIEU 
			SET SoLuongTon = SoLuongTon + 1,
				SoLuongMuon = SoLuongMuon - 1
			WHERE MaTaiLieu = (SELECT MaTaiLieu FROM inserted)
		END
	IF EXISTS (SELECT MaPM FROM inserted WHERE TienBoiThuong > 0)
		BEGIN
			UPDATE TAILIEU 
			SET SoLuongHuHao = SoLuongHuHao + 1
			WHERE MaTaiLieu = (SELECT MaTaiLieu FROM inserted)
		END

GO
