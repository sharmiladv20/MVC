CREATE TABLE [dbo].[User]
(
	[UserId] INT Identity (1,1) Not Null ,
	[FirstName] NVARCHAR(50) NULL,
	[LastName] NVARCHAR (50) NULL,
	[DateOfBirth] Date , 
    [Gender] CHAR(1) NULL, 
    CONSTRAINT [PK_User] PRIMARY KEY ([UserId]) 

)
select * from [User]