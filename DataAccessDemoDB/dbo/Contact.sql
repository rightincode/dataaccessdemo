CREATE TABLE [dbo].[Contact]
(
	[Id] INT NOT NULL IDENTITY, 
    [FirstName] NVARCHAR(400) NOT NULL, 
    [LastName] NVARCHAR(400) NOT NULL, 
    [Email] NVARCHAR(400) NOT NULL, 
    [Phone] NVARCHAR(400) NOT NULL, 
    CONSTRAINT [PK_Contact] PRIMARY KEY ([Id]) 
)
