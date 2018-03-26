CREATE TABLE [dbo].[PersonType]
(
    [Identifier] INT             IDENTITY (1, 1) NOT NULL,
	[Name]       NVARCHAR (250)  NOT NULL,
	CONSTRAINT [PK_PersonType] PRIMARY KEY CLUSTERED ([Identifier] ASC)
)