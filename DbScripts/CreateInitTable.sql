USE [eshiftDb]
GO

/****** Object:  Table [dbo].[Tbl_Customer]    Script Date: 7/30/2022 3:10:51 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Tbl_Customer]') AND type in (N'U'))
DROP TABLE [dbo].[Tbl_Customer]
GO

/****** Object:  Table [dbo].[Tbl_Customer]    Script Date: 7/30/2022 3:10:51 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Tbl_Customer](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[cusName] [varchar](50) NOT NULL,
	[cusNIC] [char](10) NOT NULL,
	[cusAddress] [varchar](max) NOT NULL,
	[cusEmail] [varchar](50) NOT NULL,
	[cusStatus] [varchar](50) NOT NULL,
	[cusContact] [char](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO


