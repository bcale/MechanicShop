USE [MechanicShop]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Mauzy
-- Create date: 3/26/2024
-- Description:	Select Customer data with the given first and last name
-- =============================================
CREATE FUNCTION search_customer_byName
(	
	-- Add the parameters for the function here
	@p_customer_Fname	VARCHAR(50),
	@p_customer_Lname	VARCHAR(50)
)
RETURNS TABLE 
AS
RETURN 
(
	SELECT * FROM customers 
	WHERE customer_Fname = @p_customer_Fname AND customer_Lname = @p_customer_Lname
)
GO
