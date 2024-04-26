USE [MechanicShop]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Mauzy
-- Create date: 4/26/2024
-- Description:	Select customer service history for each car they own, tech that worked
--		on the car, all of the car information as well as all service information
-- =============================================
CREATE FUNCTION search_serviceHistory_byCustomer(@p_customer_Fname VARCHAR(50), @p_customer_Lname VARCHAR(50))
RETURNS TABLE 
AS
RETURN 
(
	SELECT 
		c.customer_Fname,
		c.customer_Lname,
		t.technician_Fname,
		t.technician_Lname,
		v.*,
		s.*
	FROM service_history sh

	JOIN customers c ON sh.customer_id = c.customer_id
	JOIN technicians t ON sh.technician_id = t.technician_id
	JOIN vehicles v ON sh.vehicle_id = v.vehicle_id 
	JOIN services s ON sh.service_id = s.service_id
		
	WHERE customer_Fname = @p_customer_Fname AND customer_Lname = @p_customer_Lname
)
