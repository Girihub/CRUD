CREATE PROCEDURE [dbo].[CreateEmployee]
	@FirstName VARCHAR(50),@LastName VARCHAR(50),@Address VARCHAR(100),@MobileNumber INT,@ZipCode INT
AS
BEGIN
	INSERT INTO EmployeeTable(FirstName,LastName,EmpAddress,MobileNumber,ZipCode) VALUES (@FirstName,@LastName,@Address,@MobileNumber,@ZipCode)
	
END
GO