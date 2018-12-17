USE [lawhouse]
GO

/****** Object:  Table [dbo].[PostNumber]    Script Date: 17-12-2018 12:55:06 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[PostNumber](
	[PostNo] [int] NOT NULL,
	[City] [varchar](50) NOT NULL,
	[Rowversion] [timestamp] NOT NULL,
 CONSTRAINT [PK_PostNumber_1] PRIMARY KEY CLUSTERED 
(
	[PostNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

