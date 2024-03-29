﻿CREATE TABLE [dbo].[Users] (
    [id]        INT         IDENTITY (1, 1) NOT NULL,
    [userName]  VARCHAR (50) NOT NULL,
    [firstName] VARCHAR (50) NOT NULL,
    [lastName]  VARCHAR (50) NOT NULL,
    [permissionLevel] INT NOT NULL DEFAULT 0, 
    [dateCreated] DATETIME NOT NULL, 
    [password] VARCHAR(1000) NOT NULL, 
    PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [permissionLevel] FOREIGN KEY ([permissionLevel]) REFERENCES [dbo].[AccessLevels] ([id])
);

