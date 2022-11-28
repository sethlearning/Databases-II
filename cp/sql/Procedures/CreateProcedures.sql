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
        INSERT INTO dbo.Roles (Name, AccessControl) VALUES (@Name, @AccessControl)
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
    @Name varchar(60),
    @UserCode int
    AS BEGIN
        INSERT INTO dbo.WorkCategories (Name, ChangeTime, ChangedBy) VALUES (@Name, GETDATE(), @UserCode)
    END
GO

CREATE PROCEDURE pUpdateWorkCategory
    @Code int,
    @Name varchar(60),
    @UserCode int
    AS BEGIN
        UPDATE dbo.WorkCategories
            SET Name = @Name, ChangeTime = GETDATE(), ChangedBy = @UserCode
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

-- Employers
CREATE PROCEDURE pAddEmployer
    @Name varchar(60),
    @Address varchar(120),
    @Phone varchar(15),
    @UserCode int
    AS BEGIN
        INSERT INTO dbo.Employers (Name, Address, Phone, ChangeTime, ChangedBy) VALUES (@Name, @Address, @Phone, GETDATE(), @UserCode)
    END
GO

CREATE PROCEDURE pUpdateEmployer
    @Code int,
    @Name varchar(60),
    @Address varchar(120),
    @Phone varchar(15),
    @UserCode int
    AS BEGIN
        UPDATE dbo.Employers
            SET Name = @Name, Address = @Address, Phone = @Phone, ChangeTime = GETDATE(), ChangedBy = @UserCode
            WHERE Code = @Code
    END
GO

CREATE PROCEDURE pDeleteEmployer
    @Code int
    AS BEGIN
        DELETE FROM dbo.Employers
            WHERE Code = @Code
    END
GO
