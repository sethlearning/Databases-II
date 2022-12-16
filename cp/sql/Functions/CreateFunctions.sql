USE CPDB
GO

CREATE FUNCTION dbo.fGetFullName
    (
        @LastName varchar(60),
        @FirstName varchar(60),
        @MiddleName varchar(60)
    )
    RETURNS varchar(70)
    AS BEGIN
        DECLARE @result AS varchar(70)
        SET @result = (CONCAT(@LastName, ' ', LEFT(@FirstName, 1), '.'))
        IF @MiddleName IS NOT NULL SET @result = CONCAT(@result, ' ', LEFT(@MiddleName, 1), '.')
        RETURN @result
    END
GO
