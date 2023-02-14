CREATE TABLE [dbo].[AssetDetails] (
    [id]               INT         IDENTITY (1, 1) NOT NULL,
    [assetAssociation] INT         NOT NULL,
    [columnName]       VARCHAR (50) NOT NULL,
    [value]            VARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [assetAssociation] FOREIGN KEY ([assetAssociation]) REFERENCES [dbo].[Assets] ([id])
);

