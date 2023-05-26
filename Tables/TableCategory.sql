CREATE TABLE [Category]
(
    [Id] INT NOT NULL IDENTITY(1,1),
    [Name] NVARCHAR (180) NOT NULL,
    [Slug] NVARCHAR (180) NOT NULL

    CONSTRAINT [PK_Category] PRIMARY KEY ([Id]),
    CONSTRAINT [UQ_Category_Slug] UNIQUE ([Slug]) 
)

CREATE NONCLUSTERED INDEX [IX_Category_Slug] ON [Category]([Slug])