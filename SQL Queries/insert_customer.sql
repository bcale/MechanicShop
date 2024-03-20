USE [MechanicShop]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Mauzy
-- Create date: 3.20.2024
-- Description:	Insert a new customer into the customer table
-- =============================================
CREATE PROCEDURE insert_customer
(
    @p_fname 	VARCHAR(50),
    @p_lname 	VARCHAR(50),
    @p_phone 	VARCHAR(10),
    @p_city 	VARCHAR(50),
    @p_street 	VARCHAR(50),
    @p_apartment_number VARCHAR(5) = NULL,
    @p_state 	VARCHAR(2),
    @p_zip 	VARCHAR(5),
    @p_email 	VARCHAR(50)
)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	INSERT INTO Customers(customer_Fname, customer_Lname, customer_phone, customer_city, customer_street, customer_apartment_number, customer_state, customer_zip, customer_email)
    VALUES (@p_fname, @p_lname, @p_phone, @p_city, @p_street, @p_apartment_number, @p_state, @p_zip, @p_email);
	
	SELECT SCOPE_IDENTITY() AS customer_id; -- Return the ID of the inserted row
END
GO