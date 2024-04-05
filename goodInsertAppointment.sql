USE [MechanicShop]
GO
/****** Object:  StoredProcedure [dbo].[insert_appointment]    Script Date: 4/4/2024 4:34:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Cameron W.
-- Create date: 4/4/2024
-- Description:	insert an appointment into servie_history
-- =============================================
ALTER PROCEDURE [dbo].[insert_appointment]
	-- Add the parameters for the stored procedure here
(
	@p_serviceDate  NVARCHAR(50),
	@p_serviceTime INT,
	@p_customerFName  NVARCHAR(50),
	@p_customerLName  NVARCHAR(50),
	@p_customerCar  NVARCHAR(50),
	@p_selectedService NVARCHAR(50),
	@p_TechnicianFName NVARCHAR(50),
	@p_TechnicianLName NVARCHAR(50))
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	DECLARE @custID Int;DECLARE @servID Int;
	DECLARE @vehID Int;DECLARE @techID Int;

	Select @custID = customer_id from customers where customer_FName = @p_customerFName and customer_LName = @p_customerLName
	Select @vehID = vehicle_id from vehicles where vehicle_license_plate = @p_customerCar
	Select @servID = service_id from services where service_name = @p_selectedService

	Select @techID = technician_id from technicians where technician_Fname = @p_TechnicianFName and technician_Lname = @p_TechnicianLName


	INSERT INTO service_history(customer_id,vehicle_id,service_id,technician_id,service_record_date,service_record_time,service_record_status)
    VALUES (@custID, @vehID, @servID, @techID, @p_serviceDate, @p_serviceTime, 0);
END
