CREATE TABLE [dbo].[Campaign_Supplier] (
    [Id]          INT IDENTITY (1, 1) NOT NULL,
    [Campaign_Id] INT NOT NULL,
    [Supplier_Id] INT NOT NULL,
    CONSTRAINT [PK_Campaign_Supplier] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Campaign_Supplier_Campaign] FOREIGN KEY ([Campaign_Id]) REFERENCES [dbo].[Campaign] ([Id]),
    CONSTRAINT [FK_Campaign_Supplier_Supplier] FOREIGN KEY ([Supplier_Id]) REFERENCES [dbo].[Supplier] ([Id])
);

