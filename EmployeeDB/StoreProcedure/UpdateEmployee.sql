CREATE PROCEDURE [dbo].[UpdateEmployee]
	@Id int,@FirstName VARCHAR(50),@LastName VARCHAR(50),@Address VARCHAR(100),@MobileNumber INT,@ZipCode INT
AS
BEGIN
	UPDATE EmployeeTable SET FirstName=@FirstName,	LastName=@LastName,EmpAddress=@Address,MobileNumber=@MobileNumber,ZipCode=@ZipCode Where Id=@Id
    
END
GO