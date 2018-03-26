CREATE TABLE [dbo].[Person]
(
    [Identifier]           INT             IDENTITY (1, 1) NOT NULL,
    [IdentifierPersonType] INT             NOT NULL,
	[FirstName]            NVARCHAR (250)  NULL,
    [LastName]             NVARCHAR (250)  NOT NULL,
    [Birthdate]            DATE            NULL,
    [EMail]                NVARCHAR (250)  NULL,
	CONSTRAINT [PK_Person] PRIMARY KEY CLUSTERED ([Identifier] ASC),
	CONSTRAINT [FK_Person_PersonType] FOREIGN KEY ([IdentifierPersonType]) REFERENCES [dbo].[PersonType] ([Identifier])
)