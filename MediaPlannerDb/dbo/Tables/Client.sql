CREATE TABLE [dbo].[Client] (
    [Id]   INT            IDENTITY (1, 1) NOT NULL,
    [name] NVARCHAR (100) NOT NULL,
    CONSTRAINT [PK_Client] PRIMARY KEY CLUSTERED ([Id] ASC)
);

