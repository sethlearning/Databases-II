USE CPDB
GO

-- Users
CREATE PROCEDURE pAddUser
	@UserName varchar(64), 
	@PasswordHash char(64),
	@Role int,
	@Enabled bit
    AS BEGIN
	    INSERT INTO dbo.Users (UserName, PasswordHash, Role, Enabled) VALUES (@UserName, @PasswordHash, @Role, @Enabled)
    END
GO

CREATE PROCEDURE pUpdateUser
	@Code int,
    @UserName varchar(64), 
	@PasswordHash char(64),
	@Role int,
	@Enabled bit
    AS BEGIN
	    UPDATE dbo.Users
            SET UserName = @UserName, PasswordHash = @PasswordHash, Role = @Role, Enabled = @Enabled
            WHERE Code = @Code
    END
GO

CREATE PROCEDURE pDeleteUser
	@Code int
    AS BEGIN
        DELETE FROM dbo.Users
            WHERE Code = @Code
    END
GO

-- Roles
CREATE PROCEDURE pAddRole
    @Name varchar(64),
    @AccessControl int
    AS BEGIN
        INSERT INTO dbo.Roles (Name, AccessControl) VALUES (@Name, @AccessControl))
    END
GO

CREATE PROCEDURE pUpdateRole
    @Code int,
    @Name varchar(64),
    @AccessControl int
    AS BEGIN
        UPDATE dbo.Roles
            SET Name = @Name, AccessControl = @AccessControl
            WHERE Code = @Code
    END
GO

CREATE PROCEDURE pDeleteRole
    @Code int
    AS BEGIN
        DELETE FROM dbo.Roles
            WHERE Code = @Code
    END
GO

-- WorkCategories
CREATE PROCEDURE pAddWorkCategory
    @Category varchar(60),
    @UserCode int
    AS BEGIN
        INSERT INTO dbo.WorkCategories (Category, ChangedBy, ChangedBy) VALUES (@Category, GETDATE(), @UserCode)
    END
GO

CREATE PROCEDURE pUpdateWorkCategory
    @Code int,
    @Category varchar(60),
    @UserCode int
    AS BEGIN
        UPDATE dbo.WorkCategories
            SET Category = @Category, ChangeTime = GETDATE(), ChangedBy = @UserCode
            WHERE Code = @Code
    END
GO

CREATE PROCEDURE pDeleteWorkCategory
    @Code int
    AS BEGIN
        DELETE FROM dbo.WorkCategories
            WHERE Code = @Code
    END
GO