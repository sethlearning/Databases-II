USE CPDB
GO

CREATE PROCEDURE pAddUser
	@UserName varchar(64), 
	@PasswordHash char(64),
	@Role int,
	@Enabled bit
AS
    BEGIN
	    INSERT INTO dbo.Users (UserName, PasswordHash, Role, Enabled) VALUES (@UserName, @PasswordHash, @Role, @Enabled)
    END
GO

CREATE PROCEDURE pUpdateUser
	@Code int,
    @UserName varchar(64), 
	@PasswordHash char(64),
	@Role int,
	@Enabled bit
AS
    BEGIN
	    UPDATE dbo.Users
            SET UserName = @UserName, PasswordHash = @PasswordHash, Role = @Role, Enabled = @Enabled
            WHERE Code = @Code
    END
GO

CREATE PROCEDURE pDeleteUser
	@Code int
AS
    BEGIN
        DELETE FROM dbo.Users
            WHERE Code = @Code
    END
GO
