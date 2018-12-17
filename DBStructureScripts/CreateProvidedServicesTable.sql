USE [lawhouse]
GO

/****** Object:  Table [dbo].[ProvidedService]    Script Date: 17-12-2018 12:55:41 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ProvidedService](
	[Employee_ID] [int] NOT NULL,
	[Case_ID] [int] NOT NULL,
	[Date] [date] NOT NULL,
	[Hours] [int] NULL,
	[Km] [int] NULL,
	[Comment] [varchar](max) NULL,
	[Rowversion] [timestamp] NOT NULL,
	[ID] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_ProvidedService] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [dbo].[ProvidedService]  WITH CHECK ADD  CONSTRAINT [FK_ProvidedService_Case] FOREIGN KEY([Case_ID])
REFERENCES [dbo].[Case] ([ID])
GO

ALTER TABLE [dbo].[ProvidedService] CHECK CONSTRAINT [FK_ProvidedService_Case]
GO

ALTER TABLE [dbo].[ProvidedService]  WITH CHECK ADD  CONSTRAINT [FK_ProvidedService_Employee] FOREIGN KEY([Employee_ID])
REFERENCES [dbo].[Employee] ([ID])
GO

ALTER TABLE [dbo].[ProvidedService] CHECK CONSTRAINT [FK_ProvidedService_Employee]
GO

