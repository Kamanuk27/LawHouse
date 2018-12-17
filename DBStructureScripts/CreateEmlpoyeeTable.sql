USE [lawhouse]
GO

/****** Object:  Table [dbo].[Employee]    Script Date: 17-12-2018 12:54:41 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Employee](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[CprNo] [varchar](50) NULL,
	[FirstName] [varchar](50) NULL,
	[LastName] [varchar](50) NULL,
	[Address] [varchar](50) NULL,
	[PostNo] [int] NULL,
	[Email] [varchar](50) NULL,
	[TlfNo] [varchar](50) NOT NULL,
	[StartDate] [date] NOT NULL,
	[Position] [varchar](50) NOT NULL,
	[PayRatePrHour] [decimal](18, 0) NOT NULL,
	[Rowversion] [timestamp] NOT NULL,
 CONSTRAINT [PK_Employee] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Employee]  WITH CHECK ADD  CONSTRAINT [FK_Employee_PostNumber] FOREIGN KEY([PostNo])
REFERENCES [dbo].[PostNumber] ([PostNo])
GO

ALTER TABLE [dbo].[Employee] CHECK CONSTRAINT [FK_Employee_PostNumber]
GO

