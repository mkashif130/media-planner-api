CREATE TABLE [dbo].[Ad] (
    [Id]              INT           IDENTITY (1, 1) NOT NULL,
    [Ad_Title]        NVARCHAR (50) NOT NULL,
    [MediaChannel_Id] INT           NOT NULL,
    [Supplier_Id]     INT           NOT NULL,
    [Budget]          MONEY         NOT NULL,
    [From_Date]       DATETIME      NOT NULL,
    [To_Date]         DATETIME      NOT NULL,
    [Campaign_Id]     INT           NOT NULL,
    CONSTRAINT [PK_Ad] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Ad_Ad] FOREIGN KEY ([Id]) REFERENCES [dbo].[Ad] ([Id]),
    CONSTRAINT [FK_Ad_Campaign] FOREIGN KEY ([Campaign_Id]) REFERENCES [dbo].[Campaign] ([Id]),
    CONSTRAINT [FK_Ad_MediaChannel] FOREIGN KEY ([MediaChannel_Id]) REFERENCES [dbo].[MediaChannel] ([Id]),
    CONSTRAINT [FK_Ad_Supplier] FOREIGN KEY ([Supplier_Id]) REFERENCES [dbo].[Supplier] ([Id])
);

