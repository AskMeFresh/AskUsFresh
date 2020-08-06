CREATE TABLE [dbo].[Address]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Address1] VARCHAR(120) NOT NULL, 
    [Address2] VARCHAR(120) NULL, 
    [Address3] VARCHAR(120) NULL, 
    [City] VARCHAR(120) NOT NULL,
    [State] CHAR(2) NOT NULL,
    [Country] VARCHAR(20) NOT NULL,
    [ZipCode] VARCHAR(16) NOT NULL,
)
