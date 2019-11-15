CREATE TABLE [dbo].[Employee]
(
	[Id] INT NOT NULL IDENTITY(1,1) PRIMARY KEY, 
    [FirstName] VARCHAR(50) NOT NULL, 
    [LastName] VARCHAR(50) NOT NULL, 
    [Address] VARCHAR(50) NOT NULL, 
    [MobileNumber] VARCHAR(50) NULL, 
    [ZipCode] VARCHAR(50) NULL
)
