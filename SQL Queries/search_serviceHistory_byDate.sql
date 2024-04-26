USE [MechanicShop]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Mauzy
-- Create date: 4/26/2024
-- Description:	Select Service History data with the given date
-- =============================================
CREATE FUNCTION search_serviceHistory_byDate(@p_date VARCHAR(50))
RETURNS TABLE 
AS
RETURN 
(
	SELECT 
	c.customer_Fname,
	c.customer_Lname,
	t.technician_Fname,
	t.technician_Lname,
	s.service_name,
	v.vehicle_make,
	v.vehicle_model,
	v.vehicle_license_plate,
	s.service_cost,
	sh.service_record_date,
	sh.service_record_time,
	sh.service_record_status
	FROM service_history sh

	JOIN customers c ON sh.customer_id = c.customer_id
	JOIN technicians t ON sh.technician_id = t.technician_id
	JOIN vehicles v ON sh.vehicle_id = v.vehicle_id 
	JOIN services s ON sh.service_id = s.service_id
		
	WHERE service_record_date = @p_date
)