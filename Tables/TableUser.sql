CREATE TABLE [User]
(
    [Id] INT NOT NULL IDENTITY(1,1),
    [Name] NVARCHAR (80) NOT NULL,
    [Email] VARCHAR(200) NOT NULL,
    [PasswordHash] VARCHAR(225) NOT NULL,
    [Bio] TEXT NOT NULL,
    [Image] VARCHAR (2000) NOT NULL,
    [Slug] VARCHAR (80) NOT NULL, -- INDEX 

    CONSTRAINT [PK_User] PRIMARY KEY([Id]),  -- CONSTRAINT serve para nomear a primary key
    CONSTRAINT [UQ_User_Email] UNIQUE ([Email]),
    CONSTRAINT [UQ_User_Slug] UNIQUE ([Slug])

)

CREATE NONCLUSTERED INDEX [IX_User_Email] ON [User]([Email]) -- Cria um indice não agrupado. Isso ajuda a fazer pesquisas. Nesse caso seria por email e index
CREATE NONCLUSTERED INDEX [IX_User_Slug] ON [User]([Slug])  -- Indice com o nome [...]  na tabela [...] na coluna [...]