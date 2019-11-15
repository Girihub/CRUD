CREATE PROCEDURE [dbo].[GetEmployee]
	@Id INT
AS
BEGIN
	SELECT FirstName,LastName,EmpAddress,MobileNumber,ZipCode FROM EmployeeTable WHERE (id=@id)
END
GO