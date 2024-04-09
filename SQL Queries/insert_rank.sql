USE [MechanicShop]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Mauzy
-- Create date: 4.9.2024
-- Description:	Insert a new technician rank into the technician_rank table
-- =============================================
CREATE PROCEDURE [dbo].[insert_rank]
(
    @p_Description 	VARCHAR(10),
    @p_Value 	float
)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	INSERT INTO technician_rank(technician_rank, rank_value)
    VALUES (@p_Description, @p_Value);
	
	SELECT SCOPE_IDENTITY() AS technician_rank_id; -- Return the ID of the inserted row
END