USE [MechanicShop]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Caleb Barnes
-- Create date: 	4/23/2024
-- Description:	Select the lazy technicians that have done no work 
-- =============================================
CREATE FUNCTION Lazy_Technicians()
RETURNS TABLE
AS
RETURN
(
    SELECT technicians.technician_id
    FROM technicians
    LEFT JOIN service_history ON technicians.technician_id = service_history.technician_id
    WHERE service_history.technician_id IS NULL
);