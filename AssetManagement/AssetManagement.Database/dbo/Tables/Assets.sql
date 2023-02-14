CREATE TABLE [dbo].[Assets] (
    [id]           INT         IDENTITY (1, 1) NOT NULL,
    [name]         VARCHAR (50) NOT NULL,
    [iconId]         INT         NOT NULL,
    [userRelation] INT         NULL,
    PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [icon] FOREIGN KEY ([iconId]) REFERENCES [dbo].[Icons] ([id]),
    CONSTRAINT [userRelation] FOREIGN KEY ([userRelation]) REFERENCES [dbo].[Users] ([id])
);

