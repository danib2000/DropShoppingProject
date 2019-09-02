CREATE TABLE [dbo].[Users]
(
	[UserID] int NOT NULL IDENTITY(1,1),
	[UserName] varchar(50) NOT NULL,
	[Email] varchar(100) NOT NULL,
	[Balance] int NOT NULL,
  --CONSTRAINT [PK_USERS] PRIMARY KEY CLUSTERED
)
