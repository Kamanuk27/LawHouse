USE [lawhouse]
GO

/****** Object:  Table [dbo].[Specialization]    Script Date: 17-12-2018 13:00:41 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Specialization](
	[Subject_ID] [int] NOT NULL,
	[Employee_ID] [int] NOT NULL,
	[Rowversion] [timestamp] NOT NULL,
	[EmplSpecID] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_EmployeeSpecialization] PRIMARY KEY CLUSTERED 
(
	[EmplSpecID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Specialization]  WITH CHECK ADD  CONSTRAINT [FK_EmployeeFields_Field] FOREIGN KEY([Subject_ID])
REFERENCES [dbo].[Subject] ([ID])
GO

ALTER TABLE [dbo].[Specialization] CHECK CONSTRAINT [FK_EmployeeFields_Field]
GO

ALTER TABLE [dbo].[Specialization]  WITH CHECK ADD  CONSTRAINT [FK_EmployeeSpecialization_Employee] FOREIGN KEY([Employee_ID])
REFERENCES [dbo].[Employee] ([ID])
GO

ALTER TABLE [dbo].[Specialization] CHECK CONSTRAINT [FK_EmployeeSpecialization_Employee]
GO

