CREATE TABLE [Students].[Students]
(
    [Id] INT IDENTITY(1,1) NOT NULL,
    [FirstName] NVARCHAR(100) NOT NULL,
    [LastName] NVARCHAR(100) NOT NULL, 
    CONSTRAINT [PK_Students] PRIMARY KEY ([Id])
)