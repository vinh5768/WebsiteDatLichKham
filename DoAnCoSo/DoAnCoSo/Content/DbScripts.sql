﻿CREATE TABLE [dbo].[BACSI](
	[MABS] [int] IDENTITY(1,1) NOT NULL,
	[HOTEN] [nvarchar](50) NULL,
	[NAMSINH] [smalldatetime] NULL,
	[DIACHI] [nvarchar](200) NULL,
	[SDT] [varchar](20) NULL,
	[MAKHOA] [int] NULL,
	[MAPHIEU] [int] NULL,
 CONSTRAINT [PK_BACSI] PRIMARY KEY CLUSTERED 
(
	[MABS] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[KHOA]    Script Date: 14/04/2018 7:17:39 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KHOA](
	[MAKHOA] [int] IDENTITY(1,1) NOT NULL,
	[TENKHOA] [nvarchar](50) NULL,
 CONSTRAINT [PK_KHOA] PRIMARY KEY CLUSTERED 
(
	[MAKHOA] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PHIEU]    Script Date: 14/04/2018 7:17:39 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHIEU](
	[MAPHIEU] [int] IDENTITY(1,1) NOT NULL,
	[MABS] [int] NULL,
	[SOPHIEUCONLAI] [int] NULL,
 CONSTRAINT [PK_PHIEU] PRIMARY KEY CLUSTERED 
(
	[MAPHIEU] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PHIEUHEN]    Script Date: 14/04/2018 7:17:39 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PHIEUHEN](
	[MAPHIEUHEN] [int] IDENTITY(1,1) NOT NULL,
	[HOTEN] [nvarchar](50) NULL,
	[NAMSINH] [datetime] NULL,
	[DIACHI] [nvarchar](200) NULL,
	[NGHENGHIEP] [nvarchar](50) NULL,
	[SDT] [varchar](20) NULL,
	[NGAYHEN] [datetime] NULL,
	[MABS] [int] NULL,
 CONSTRAINT [PK_PHIEUHEN] PRIMARY KEY CLUSTERED 
(
	[MAPHIEUHEN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[BACSI]  WITH CHECK ADD  CONSTRAINT [FK_BACSI_KHOA] FOREIGN KEY([MAKHOA])
REFERENCES [dbo].[KHOA] ([MAKHOA])
GO
ALTER TABLE [dbo].[BACSI] CHECK CONSTRAINT [FK_BACSI_KHOA]
GO
ALTER TABLE [dbo].[BACSI]  WITH CHECK ADD  CONSTRAINT [FK_BACSI_PHIEU] FOREIGN KEY([MAPHIEU])
REFERENCES [dbo].[PHIEU] ([MAPHIEU])
GO
ALTER TABLE [dbo].[BACSI] CHECK CONSTRAINT [FK_BACSI_PHIEU]
GO
ALTER TABLE [dbo].[PHIEUHEN]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUHEN_BACSI] FOREIGN KEY([MABS])
REFERENCES [dbo].[BACSI] ([MABS])
GO
ALTER TABLE [dbo].[PHIEUHEN] CHECK CONSTRAINT [FK_PHIEUHEN_BACSI]
GO
