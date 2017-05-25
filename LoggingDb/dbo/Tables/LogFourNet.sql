CREATE TABLE [dbo].[LogFourNet] (
    [ID]        BIGINT         IDENTITY (1, 1) NOT NULL,
    [DateStamp] DATETIME       NOT NULL,
    [Thread]    VARCHAR (255)  NOT NULL,
    [ErrLevel]  VARCHAR (20)   NOT NULL,
    [Logger]    VARCHAR (255)  NOT NULL,
    [Message]   VARCHAR (4000) NOT NULL,
    [AppName]   VARCHAR (50)   NULL,
    [Exception] VARCHAR (8000) NULL,
    CONSTRAINT [PK_LogFourNet] PRIMARY KEY CLUSTERED ([ID] ASC)
);

