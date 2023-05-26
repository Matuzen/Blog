CREATE TABLE [Tag]
(
    [Id] INT NOT NULL IDENTITY(1,1),
    [Name] NVARCHAR(80) NOT NULL,
    [Slug] NVARCHAR(80) NOT NULL,

    CONSTRAINT [PK_Tag] PRIMARY KEY ([Id]),
    CONSTRAINT [UQ_Tag_SLug] UNIQUE ([Slug])
)

CREATE NONCLUSTERED INDEX [IX_Tag_Slug] ON [TAG] ([Slug])
