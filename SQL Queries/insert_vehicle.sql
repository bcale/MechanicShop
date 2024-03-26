USE [MechanicShop]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Mauzy
-- Create date: 3.21.2024
-- Description:	Insert a new vehicle into the vehicles table
-- =============================================
CREATE PROCEDURE insert_vehicles
(
	@p_customer_id		INT,
    @p_vehicle_model 	VARCHAR(50),
    @p_vehicle_trim 	VARCHAR(50),
    @p_vehicle_year 	VARCHAR(4),
	@p_vehicle_license_plate VARCHAR(7),
	@p_vehicle_color	VARCHAR(50),
	@p_vehicle_vin		VARCHAR(50),
	@p_vehicle_make		VARCHAR(50)
)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	-- Check if the provided customer_id exists in the customers table
    IF NOT EXISTS (SELECT 1 FROM customers WHERE customer_id = @p_customer_id)
    BEGIN
        RAISERROR ('Invalid customer_id provided', 16, 1);
        RETURN; -- Exit the procedure
    END

   INSERT INTO vehicles(customer_id, vehicle_model, vehicle_trim, vehicle_year, vehicle_license_plate, vehicle_color, vehicle_vin, vehicle_make)
    VALUES ( @p_customer_id, @p_vehicle_model, @p_vehicle_trim, @p_vehicle_year, @p_vehicle_license_plate, @p_vehicle_color, @p_vehicle_vin, @p_vehicle_make);
	
	SELECT SCOPE_IDENTITY() AS vehicle_id; -- Return the ID of the inserted row
END