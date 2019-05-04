CREATE TABLE [dbo].[Country] (
    [IsoCode] NVARCHAR (50) NOT NULL,
    [Name]    NVARCHAR (50) NOT NULL,
    CONSTRAINT [PK_Country] PRIMARY KEY CLUSTERED ([IsoCode] ASC)
);

