USE [MechanicShop]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Caleb
-- Create date: 3.27.2024
-- Description:	Insert a new service into the services table
-- =============================================
CREATE PROCEDURE [dbo].[insert_service]
(
    @p_serviceName 	VARCHAR(50),
    @p_serviceDescription 	VARCHAR(100),
    @p_serviceCost 	FLOAT
)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	INSERT INTO services(service_name, service_description, service_cost)
    VALUES (@p_serviceName, @p_serviceDescription, @p_serviceCost);
	
	SELECT SCOPE_IDENTITY() AS service_id; -- Return the ID of the inserted row
END
