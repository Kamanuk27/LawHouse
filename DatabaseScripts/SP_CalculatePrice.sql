USE [lawhouse]
GO

/****** Object:  StoredProcedure [dbo].[CalculatePrice]    Script Date: 28-11-2018 05:13:10 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[CalculatePrice]
(
 @id AS int,
 @price  AS decimal out
)

AS
BEGIN
-- check if there is a negotiated price
SELECT @price = NegotiatedPrice FROM [dbo].[Case] WHERE ID = @id
IF @price IS NOT NULL AND @price > 0
    BEGIN
        RETURN @price
    END

-- calculate price
ELSE 
    BEGIN
	DECLARE  
	@hours AS int,
    @hPrice AS decimal,
    @km AS int,
    @kmPrice AS decimal

SELECT @hours = SUM ([Hours]) FROM 	 [dbo].[ProvidedService] WHERE Case_ID = @id
SELECT  @hPrice = Rate FROM [dbo].[UnitRate] WHERE [Name] = 'Advokattime'

SELECT @km = SUM ([Km]) FROM [dbo].[ProvidedService] WHERE Case_ID = @id
SELECT  @kmPrice = Rate FROM [dbo].[UnitRate] WHERE [Name] = 'km'

SELECT @price = (@hours * @hPrice + @km * @kmPrice)
    RETURN @price
	END
END
GO


