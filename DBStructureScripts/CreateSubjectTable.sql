USE [lawhouse]
GO

/****** Object:  Table [dbo].[Subject]    Script Date: 17-12-2018 13:01:27 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Subject](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[HoursEstimate] [int] NULL,
	[Price] [decimal](18, 0) NULL,
	[Rowversion] [timestamp] NOT NULL,
	[TimeEstimate] [int] NULL,
 CONSTRAINT [PK_LegalServices] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

