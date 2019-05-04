CREATE TABLE [dbo].[Campaign] (
    [Id]               INT           IDENTITY (1, 1) NOT NULL,
    [Client_Id]        INT           NOT NULL,
    [Country]          NVARCHAR (50) NOT NULL,
    [Budget]           MONEY         NOT NULL,
    [From_Date]        DATETIME      NOT NULL,
    [To_Date]          DATETIME      NOT NULL,
    [Remaining_Budget] MONEY         NULL,
    CONSTRAINT [PK_Campaign] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Campaign_Client] FOREIGN KEY ([Client_Id]) REFERENCES [dbo].[Client] ([Id]),
    CONSTRAINT [FK_Campaign_Country] FOREIGN KEY ([Country]) REFERENCES [dbo].[Country] ([IsoCode])
);

