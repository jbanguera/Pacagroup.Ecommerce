CREATE TABLE dbo.Users(
    UserId  int not null,
    FirstName nvarchar(50) not null,
    LastName nvarchar(50) not null,
    UserName nvarchar(50) not null,
    Password nvarchar(50) not null,
    constraint PK_Users Primary Key(UserId)
);
GO

insert into dbo.Users values (1, 'Jhon Jairo', 'Marquinez Banguera', 'jjmarquinez', '1234');
GO

create procedure dbo.UsersGetByUserAndPassword
(
    @UserName nvarchar(50),
    @Password nvarchar(50)
)
AS
BEGIN
    select UserId, FirstName, LastName, UserName, Null as Password
    from Users
    where UserName=@UserName and Password=@Password
END
GO
