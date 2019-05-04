CREATE TABLE [dbo].[Supplier] (
    [Id]              INT            IDENTITY (1, 1) NOT NULL,
    [Supplier]        NVARCHAR (100) NOT NULL,
    [MediaChannel_Id] INT            NOT NULL,
    CONSTRAINT [PK_Supplier] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Supplier_MediaChannel] FOREIGN KEY ([MediaChannel_Id]) REFERENCES [dbo].[MediaChannel] ([Id])
);

