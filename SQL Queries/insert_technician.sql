USE [MechanicShop]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Mauzy
-- Create date: 3.21.2024
-- Description:	Insert a new technician into the technician table
-- =============================================
CREATE PROCEDURE [dbo].[insert_technician]
(
    @p_fname 	VARCHAR(50),
    @p_lname 	VARCHAR(50),
    @p_rank 	INT
)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	INSERT INTO technicians(technician_Fname, technician_Lname, technician_rank_id)
    VALUES (@p_fname, @p_lname, @p_rank);
	
	SELECT SCOPE_IDENTITY() AS technician_id; -- Return the ID of the inserted row
END
