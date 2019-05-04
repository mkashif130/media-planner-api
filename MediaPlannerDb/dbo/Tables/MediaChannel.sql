CREATE TABLE [dbo].[MediaChannel] (
    [Id]      INT           IDENTITY (1, 1) NOT NULL,
    [Channel] NVARCHAR (50) NOT NULL,
    CONSTRAINT [PK_MediaChannel] PRIMARY KEY CLUSTERED ([Id] ASC)
);

