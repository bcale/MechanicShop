USE [MechanicShop]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Mauzy
-- Create date: 4/3/2024
-- Description:	Select the technicians that can work the given job
-- =============================================
CREATE FUNCTION select_technicians_byRequiredRankValue(@p_requiredRankValue FLOAT)
RETURNS TABLE 
AS
RETURN 
(
	SELECT
        t.technician_ID AS TechID,
        t.technician_Fname AS "First Name",
        t.technician_Lname AS "Last Name",
        t.technician_rank_id AS RankID,
        tr.rank_value AS "Rank Value"
	FROM technicians t
	JOIN technician_rank tr ON t.technician_rank_id = tr.technician_rank_id
	WHERE tr.rank_value >= @p_requiredRankValue
)
GO
