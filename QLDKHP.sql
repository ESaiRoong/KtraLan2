USE [master]
GO
/****** Object:  Database [QLDKHP]    Script Date: 6/13/2022 9:39:23 AM ******/
CREATE DATABASE [QLDKHP]
 
GO
USE [QLDKHP]
GO
/****** Object:  Table [dbo].[ChuongTrinhDT]    Script Date: 6/13/2022 9:39:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChuongTrinhDT](
	[MaCTDT] [int] IDENTITY(1,1) NOT NULL,
	[TenCTDT] [nvarchar](50) NOT NULL,
	[MoTa] [nvarchar](1000) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaCTDT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Hoc]    Script Date: 6/13/2022 9:39:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Hoc](
	[MaSV] [int] NOT NULL,
	[MaMH] [nchar](10) NOT NULL,
	[Diem] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaSV] ASC,
	[MaMH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Lop]    Script Date: 6/13/2022 9:39:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Lop](
	[MaLop] [int] IDENTITY(1,1) NOT NULL,
	[TenLop] [char](5) NOT NULL,
	[MaCTĐT] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaLop] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MonHoc]    Script Date: 6/13/2022 9:39:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MonHoc](
	[MaMH] [nchar](10) NOT NULL,
	[TenMH] [nvarchar](50) NOT NULL,
	[SoTC] [int] NOT NULL,
	[MaCTĐT] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaMH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SinhVien]    Script Date: 6/13/2022 9:39:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SinhVien](
	[MaSV] [int] IDENTITY(2100000,1) NOT NULL,
	[HoTen] [nvarchar](50) NOT NULL,
	[MaLop] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaSV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[ChuongTrinhDT] ON 

INSERT [dbo].[ChuongTrinhDT] ([MaCTDT], [TenCTDT], [MoTa]) VALUES (1, N'Chương trình đào tạo 2015', NULL)
INSERT [dbo].[ChuongTrinhDT] ([MaCTDT], [TenCTDT], [MoTa]) VALUES (2, N'Chương trình đào tạo 2017', NULL)
INSERT [dbo].[ChuongTrinhDT] ([MaCTDT], [TenCTDT], [MoTa]) VALUES (3, N'Chương trình đào tạo 2020', NULL)
SET IDENTITY_INSERT [dbo].[ChuongTrinhDT] OFF
GO
INSERT [dbo].[Hoc] ([MaSV], [MaMH], [Diem]) VALUES (1923244, N'CT2201    ', 6)
INSERT [dbo].[Hoc] ([MaSV], [MaMH], [Diem]) VALUES (1923244, N'NN1002    ', 9)
INSERT [dbo].[Hoc] ([MaSV], [MaMH], [Diem]) VALUES (1923244, N'QP2002    ', 7)
INSERT [dbo].[Hoc] ([MaSV], [MaMH], [Diem]) VALUES (1923244, N'TC1002    ', 5)
INSERT [dbo].[Hoc] ([MaSV], [MaMH], [Diem]) VALUES (1923244, N'TN1101    ', 5)
INSERT [dbo].[Hoc] ([MaSV], [MaMH], [Diem]) VALUES (1934567, N'CT2201    ', 9)
INSERT [dbo].[Hoc] ([MaSV], [MaMH], [Diem]) VALUES (1934567, N'NN1002    ', 9)
INSERT [dbo].[Hoc] ([MaSV], [MaMH], [Diem]) VALUES (1934567, N'TC1001    ', 5)
INSERT [dbo].[Hoc] ([MaSV], [MaMH], [Diem]) VALUES (1934567, N'TN1101    ', 8)
INSERT [dbo].[Hoc] ([MaSV], [MaMH], [Diem]) VALUES (1945465, N'TC1001    ', 6)
INSERT [dbo].[Hoc] ([MaSV], [MaMH], [Diem]) VALUES (1945465, N'TN1101    ', 7)
INSERT [dbo].[Hoc] ([MaSV], [MaMH], [Diem]) VALUES (2056566, N'20CT2201  ', 9)
INSERT [dbo].[Hoc] ([MaSV], [MaMH], [Diem]) VALUES (2056566, N'20NN1002  ', 6)
INSERT [dbo].[Hoc] ([MaSV], [MaMH], [Diem]) VALUES (2056567, N'20NN1002  ', 8)
INSERT [dbo].[Hoc] ([MaSV], [MaMH], [Diem]) VALUES (2167698, N'20CT2201  ', 7)
INSERT [dbo].[Hoc] ([MaSV], [MaMH], [Diem]) VALUES (2167698, N'20NN1002  ', 9)
GO
SET IDENTITY_INSERT [dbo].[Lop] ON 

INSERT [dbo].[Lop] ([MaLop], [TenLop], [MaCTĐT]) VALUES (1, N'CTK42', 1)
INSERT [dbo].[Lop] ([MaLop], [TenLop], [MaCTĐT]) VALUES (2, N'CTK43', 2)
INSERT [dbo].[Lop] ([MaLop], [TenLop], [MaCTĐT]) VALUES (3, N'CTK44', 3)
INSERT [dbo].[Lop] ([MaLop], [TenLop], [MaCTĐT]) VALUES (4, N'CTK45', 3)
SET IDENTITY_INSERT [dbo].[Lop] OFF
GO
INSERT [dbo].[MonHoc] ([MaMH], [TenMH], [SoTC], [MaCTĐT]) VALUES (N'20CT2201  ', N'Nguyên lý lập trình hướng đối tượng', 4, 3)
INSERT [dbo].[MonHoc] ([MaMH], [TenMH], [SoTC], [MaCTĐT]) VALUES (N'20NN1002  ', N'Tiếng Anh chuyên ngành CNTT', 3, 3)
INSERT [dbo].[MonHoc] ([MaMH], [TenMH], [SoTC], [MaCTĐT]) VALUES (N'20TN1101  ', N'Toán cao cấp', 3, 3)
INSERT [dbo].[MonHoc] ([MaMH], [TenMH], [SoTC], [MaCTĐT]) VALUES (N'CT2201    ', N'Nguyên lý lập trình', 4, 1)
INSERT [dbo].[MonHoc] ([MaMH], [TenMH], [SoTC], [MaCTĐT]) VALUES (N'NN1002    ', N'Tiếng Anh thương mại', 3, 2)
INSERT [dbo].[MonHoc] ([MaMH], [TenMH], [SoTC], [MaCTĐT]) VALUES (N'QP2001    ', N'Quốc phòng 1', 3, 1)
INSERT [dbo].[MonHoc] ([MaMH], [TenMH], [SoTC], [MaCTĐT]) VALUES (N'QP2002    ', N'Quốc phòng 2', 3, 1)
INSERT [dbo].[MonHoc] ([MaMH], [TenMH], [SoTC], [MaCTĐT]) VALUES (N'TC1001    ', N'Thể chất 1', 3, 2)
INSERT [dbo].[MonHoc] ([MaMH], [TenMH], [SoTC], [MaCTĐT]) VALUES (N'TC1002    ', N'Thể chất 2', 3, 3)
INSERT [dbo].[MonHoc] ([MaMH], [TenMH], [SoTC], [MaCTĐT]) VALUES (N'TN1101    ', N'Toán cao cấp', 3, 1)
INSERT [dbo].[MonHoc] ([MaMH], [TenMH], [SoTC], [MaCTĐT]) VALUES (N'VL1020    ', N'Vật lý đại cương', 3, 2)
GO
SET IDENTITY_INSERT [dbo].[SinhVien] ON 

INSERT [dbo].[SinhVien] ([MaSV], [HoTen], [MaLop]) VALUES (1923244, N'Trung', 1)
INSERT [dbo].[SinhVien] ([MaSV], [HoTen], [MaLop]) VALUES (1934567, N'Quốc', 1)
INSERT [dbo].[SinhVien] ([MaSV], [HoTen], [MaLop]) VALUES (1945465, N'Mai', 1)
INSERT [dbo].[SinhVien] ([MaSV], [HoTen], [MaLop]) VALUES (2056566, N'Thành', 2)
INSERT [dbo].[SinhVien] ([MaSV], [HoTen], [MaLop]) VALUES (2056567, N'Hòa', 2)
INSERT [dbo].[SinhVien] ([MaSV], [HoTen], [MaLop]) VALUES (2167698, N'Hạnh', 3)
INSERT [dbo].[SinhVien] ([MaSV], [HoTen], [MaLop]) VALUES (2267879, N'Vân Anh', 4)
SET IDENTITY_INSERT [dbo].[SinhVien] OFF
GO
ALTER TABLE [dbo].[Hoc]  WITH CHECK ADD FOREIGN KEY([MaMH])
REFERENCES [dbo].[MonHoc] ([MaMH])
GO
ALTER TABLE [dbo].[Hoc]  WITH CHECK ADD FOREIGN KEY([MaSV])
REFERENCES [dbo].[SinhVien] ([MaSV])
GO
ALTER TABLE [dbo].[Lop]  WITH CHECK ADD FOREIGN KEY([MaCTĐT])
REFERENCES [dbo].[ChuongTrinhDT] ([MaCTDT])
GO
ALTER TABLE [dbo].[SinhVien]  WITH CHECK ADD FOREIGN KEY([MaLop])
REFERENCES [dbo].[Lop] ([MaLop])
GO
USE [master]
GO
ALTER DATABASE [QLSinhVienThi] SET  READ_WRITE 
GO

select * from MonHoc


ALTER PROCEDURE [dbo].[MonHoc_InsertUpdateDelete]
    @MonHoc INT OUTPUT,  -- ID của danh mục (NULL cho khi thêm mới)
    @TenMH NVARCHAR(255), -- Tên danh mục
    @SoTC INT,            -- Số tín chỉ
    @MaCT INT,            -- Mã chương trình đào tạo
    @Action INT           -- Biến hành động: 0 = Thêm mới, 1 = Cập nhật, 2 = Xóa
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        IF @Action = 0 -- Thêm mới
        BEGIN
            -- Kiểm tra đầu vào
            IF @TenMH IS NULL OR LEN(@TenMH) = 0
            BEGIN
                RAISERROR('Tên môn học không thể để trống.', 16, 1);
                RETURN;
            END

            -- Thực hiện thêm mới
            INSERT INTO MonHoc (TenMH, SoTC, MaCTĐT)
            VALUES (@TenMH, @SoTC, @MaCT);
            SET @MonHoc = SCOPE_IDENTITY(); -- Trả về ID của môn học mới

        END
        ELSE IF @Action = 1 -- Cập nhật
        BEGIN
            -- Kiểm tra xem môn học có tồn tại không
            IF @MonHoc IS NULL
            BEGIN
                RAISERROR('ID môn học không được NULL khi cập nhật.', 16, 1);
                RETURN;
            END

            -- Kiểm tra đầu vào
            IF @TenMH IS NULL OR LEN(@TenMH) = 0
            BEGIN
                RAISERROR('Tên môn học không thể để trống.', 16, 1);
                RETURN;
            END

            -- Thực hiện cập nhật
            UPDATE MonHoc
            SET TenMH = @TenMH,
                SoTC = @SoTC,
                MaCTĐT = @MaCT
            WHERE MaMH = @MonHoc;

            IF @@ROWCOUNT = 0
            BEGIN
                RAISERROR('Không tìm thấy môn học với ID %d để cập nhật.', 16, 1, @MonHoc);
                RETURN;
            END

        END
        ELSE IF @Action = 2 -- Xóa
        BEGIN
            -- Kiểm tra xem môn học có tồn tại không
            IF @MonHoc IS NULL
            BEGIN
                RAISERROR('ID môn học không được NULL khi xóa.', 16, 1);
                RETURN;
            END

            -- Thực hiện xóa
            DELETE FROM MonHoc
            WHERE MaMH = @MonHoc;

            IF @@ROWCOUNT = 0
            BEGIN
                RAISERROR('Không tìm thấy môn học với ID %d để xóa.', 16, 1, @MonHoc);
                RETURN;
            END
        END
        ELSE
        BEGIN
            RAISERROR('Giá trị hành động không hợp lệ. Vui lòng sử dụng 0 (Thêm mới), 1 (Cập nhật), hoặc 2 (Xóa).', 16, 1);
        END
    END TRY
    BEGIN CATCH
        -- Xử lý lỗi nếu có
        RAISERROR('Đã xảy ra lỗi: %s', 16, 1, ERROR_MESSAGE());
    END CATCH
END;

