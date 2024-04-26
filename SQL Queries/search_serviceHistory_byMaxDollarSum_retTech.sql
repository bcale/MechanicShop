USE [MechanicShop]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Mauzy
-- Create date: 4/26/2024
-- Description:	Search the service history and find the technician who did the most amount of work 
--		in terms of dollar amount within a given timeframe 
-- =============================================
CREATE FUNCTION search_serviceHistory_byMaxDollarSum_retTech
(
	@p_start_date			date,
	@p_end_date			date
)
RETURNS TABLE 
AS
RETURN 
(
	SELECT 
		t.technician_id,
		t.technician_Fname,
		t.technician_Lname,
		SUM(s.service_cost) AS total_cost
	FROM service_history sh

	JOIN technicians t ON sh.technician_id = t.technician_id
	JOIN services s ON sh.service_id = s.service_id
		
	WHERE service_record_date BETWEEN @p_start_date AND @p_end_date
	GROUP BY t.technician_id, t.technician_Fname, t.technician_Lname
)