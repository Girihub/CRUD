﻿CREATE PROCEDURE [dbo].[DeleteEmployee]
@Id INT
AS
BEGIN
	DELETE FROM EmployeeTable WHERE Id=@Id
END
GO