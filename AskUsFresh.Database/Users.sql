CREATE TABLE [dbo].[Users]
(
	[Id] INT IDENTITY(1,1) NOT NULL PRIMARY KEY, 
    [FirstName] VARCHAR(50) NOT NULL, 
    [MiddleName] VARCHAR(50) NOT NULL,
    [LastName] VARCHAR(50) NOT NULL, 
    [Gender] VARCHAR(6) NOT NULL,
    [DateOfBirth] Date NOT NULL,
    [Email] VARCHAR(50) NOT NULL, 
    [Password] VARCHAR(50) NOT NULL, 
    [PhoneNumber] VARCHAR(15) NOT NULL
)
