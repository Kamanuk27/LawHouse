USE [lawhouse]
GO

/****** Object:  Trigger [dbo].[CloseCaseTrigger]    Script Date: 28-11-2018 06:14:49 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TRIGGER [dbo].[CloseCaseTrigger]
   ON [dbo].[Case]
   AFTER UPDATE 
  AS 
   DECLARE @id int
   DECLARE @date date
   Declare @total decimal

   SELECT @id = ID FROM [Case]
   select @date = EndDate FROM [Case]
   select @total = TotalPrice FROM [Case]
      IF (@date IS NOT NULL AND @total is not null)
	   BEGIN
	  INSERT INTO dbo.ClosedCase (Case_ID, CaseName, StartDate, EndDate, NegotiatedPrice, 
	              TotalPrice, Service_ID, RespEmp_ID, Client_ID) 
	  SELECT ID, CaseName, StartDate, EndDate, NegotiatedPrice, TotalPrice, 
	              Service_ID, RespEmp_ID, Client_ID
	  FROM [dbo].[Case] WHERE ID = @id

      DELETE From [dbo].[ProvidedService] WHERE Case_ID = @id
	  DELETE FROM [dbo].[Case] WHERE ID = @id
   END
GO

ALTER TABLE [dbo].[Case] ENABLE TRIGGER [CloseCaseTrigger]
GO


