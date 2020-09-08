CREATE TABLE [dbo].[Address]
(
	[Id] INT IDENTITY(1,1) NOT NULL PRIMARY KEY, 
    [UserId] INT NOT NULL,
    [Address1] VARCHAR(120) NOT NULL, 
    [Address2] VARCHAR(120) NULL, 
    [Address3] VARCHAR(120) NULL, 
    [City] VARCHAR(120) NOT NULL,
    [State] CHAR(10) NOT NULL,
    [Country] VARCHAR(20) NOT NULL,
    [ZipCode] VARCHAR(16) NOT NULL,
)
