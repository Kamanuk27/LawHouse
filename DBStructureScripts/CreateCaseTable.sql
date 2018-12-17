USE [lawhouse]
GO

/****** Object:  Table [dbo].[Case]    Script Date: 17-12-2018 12:04:52 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Case](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[CaseName] [varchar](50) NOT NULL,
	[StartDate] [date] NOT NULL,
	[EndDate] [date] NULL,
	[NegotiatedPrice] [decimal](18, 0) NULL,
	[TotalPrice] [decimal](18, 0) NULL,
	[Subject_ID] [int] NOT NULL,
	[RespEmp_ID] [int] NOT NULL,
	[Client_ID] [int] NOT NULL,
	[Rowversion] [timestamp] NOT NULL,
 CONSTRAINT [PK_Case] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Case]  WITH CHECK ADD  CONSTRAINT [FK_Case_Client] FOREIGN KEY([Client_ID])
REFERENCES [dbo].[Client] ([ID])
GO

ALTER TABLE [dbo].[Case] CHECK CONSTRAINT [FK_Case_Client]
GO

ALTER TABLE [dbo].[Case]  WITH CHECK ADD  CONSTRAINT [FK_Case_Employee] FOREIGN KEY([RespEmp_ID])
REFERENCES [dbo].[Employee] ([ID])
GO

ALTER TABLE [dbo].[Case] CHECK CONSTRAINT [FK_Case_Employee]
GO

ALTER TABLE [dbo].[Case]  WITH CHECK ADD  CONSTRAINT [FK_Case_Subject] FOREIGN KEY([Subject_ID])
REFERENCES [dbo].[Subject] ([ID])
GO

ALTER TABLE [dbo].[Case] CHECK CONSTRAINT [FK_Case_Subject]
GO

