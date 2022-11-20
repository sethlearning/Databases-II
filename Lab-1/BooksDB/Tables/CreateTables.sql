USE BooksDB
GO

-- Authors table
IF OBJECT_ID('dbo.Authors') IS NULL
    BEGIN
        CREATE TABLE dbo.Authors
        (
            Code_author INT IDENTITY(1, 1) PRIMARY KEY,
            Name_author CHAR(60) NOT NULL,
            Birthday DATETIME2
        )

    EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Справочник авторов',
                                    @level0type=N'SCHEMA',   @level0name=N'dbo',
                                    @level1type=N'TABLE',    @level1name=N'Authors'

    EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Код автора',
                                    @level0type=N'SCHEMA',   @level0name=N'dbo',
                                    @level1type=N'TABLE',    @level1name=N'Authors',
                                    @level2type=N'COLUMN',   @level2name=N'Code_author'

    EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Фамилия, имя, отчество автора',
                                    @level0type=N'SCHEMA',   @level0name=N'dbo',
                                    @level1type=N'TABLE',    @level1name=N'Authors',
                                    @level2type=N'COLUMN',   @level2name=N'Name_author'

    EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Дата рождения',
                                    @level0type=N'SCHEMA',   @level0name=N'dbo',
                                    @level1type=N'TABLE',    @level1name=N'Authors',
                                    @level2type=N'COLUMN',   @level2name=N'Birthday'
    END
ELSE
    PRINT('Authors table already exists.')

-- Publishing_house table
IF OBJECT_ID('dbo.Publishing_house') IS NULL
    BEGIN
        CREATE TABLE dbo.Publishing_house
        (
            Code_publish INT IDENTITY(1, 1) PRIMARY KEY,
            Publish CHAR(60) NOT NULL,
            City CHAR(30)
        )
        EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Справочник издательств',
                                        @level0type=N'SCHEMA',   @level0name=N'dbo',
                                        @level1type=N'TABLE',    @level1name=N'Publishing_house'

        EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Код издательства',
                                        @level0type=N'SCHEMA',   @level0name=N'dbo',
                                        @level1type=N'TABLE',    @level1name=N'Publishing_house',
                                        @level2type=N'COLUMN',   @level2name=N'Code_publish'

        EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Издательство',
                                        @level0type=N'SCHEMA',   @level0name=N'dbo',
                                        @level1type=N'TABLE',    @level1name=N'Publishing_house',
                                        @level2type=N'COLUMN',   @level2name=N'Publish'

        EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Город',
                                        @level0type=N'SCHEMA',   @level0name=N'dbo',
                                        @level1type=N'TABLE',    @level1name=N'Publishing_house',
                                        @level2type=N'COLUMN',   @level2name=N'City'
    END
ELSE
    PRINT('Publishing_house table already exists.')

-- Deliveries table
IF OBJECT_ID('dbo.Deliveries') IS NULL
    BEGIN
        CREATE TABLE dbo.Deliveries
        (
            Code_delivery INT IDENTITY(1, 1) PRIMARY KEY,
            Name_delivery CHAR(60) NOT NULL,
            Name_company CHAR(60) NOT NULL,
            Address CHAR(120) NOT NULL,
            Phone NUMERIC,
            INN CHAR(12)
        )
        EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Справочник поставщиков',
                                        @level0type=N'SCHEMA',   @level0name=N'dbo',
                                        @level1type=N'TABLE',    @level1name=N'Deliveries'

        EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Код поставщика',
                                        @level0type=N'SCHEMA',   @level0name=N'dbo',
                                        @level1type=N'TABLE',    @level1name=N'Deliveries',
                                        @level2type=N'COLUMN',   @level2name=N'Code_delivery'

        EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Фамилия, имя, отчество ответственного лица',
                                        @level0type=N'SCHEMA',   @level0name=N'dbo',
                                        @level1type=N'TABLE',    @level1name=N'Deliveries',
                                        @level2type=N'COLUMN',   @level2name=N'Name_delivery'

        EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Название компании-поставщика',
                                        @level0type=N'SCHEMA',   @level0name=N'dbo',
                                        @level1type=N'TABLE',    @level1name=N'Deliveries',
                                        @level2type=N'COLUMN',   @level2name=N'Name_company'

        EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Юридический адрес',
                                        @level0type=N'SCHEMA',   @level0name=N'dbo',
                                        @level1type=N'TABLE',    @level1name=N'Deliveries',
                                        @level2type=N'COLUMN',   @level2name=N'Address'

        EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Телефон контактный',
                                        @level0type=N'SCHEMA',   @level0name=N'dbo',
                                        @level1type=N'TABLE',    @level1name=N'Deliveries',
                                        @level2type=N'COLUMN',   @level2name=N'Phone'

        EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'ИНН',
                                        @level0type=N'SCHEMA',   @level0name=N'dbo',
                                        @level1type=N'TABLE',    @level1name=N'Deliveries',
                                        @level2type=N'COLUMN',   @level2name=N'INN'
    END
ELSE
    PRINT('Deliveries table already exists.')

-- Books table
IF OBJECT_ID('dbo.Books') IS NULL
    BEGIN
        CREATE TABLE dbo.Books
        (
            Code_book INT IDENTITY(1, 1) PRIMARY KEY,
            Title_book CHAR(60) NOT NULL,
            Code_author INT NOT NULL FOREIGN KEY REFERENCES dbo.Authors(Code_author),
            Pages INT,
            Code_publish INT NOT NULL FOREIGN KEY REFERENCES dbo.Publishing_house(Code_publish)
        )
        EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Справочник Книг',
                                        @level0type=N'SCHEMA',   @level0name=N'dbo',
                                        @level1type=N'TABLE',    @level1name=N'Books'

        EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Код книги',
                                        @level0type=N'SCHEMA',   @level0name=N'dbo',
                                        @level1type=N'TABLE',    @level1name=N'Books',
                                        @level2type=N'COLUMN',   @level2name=N'Code_book'

        EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Название книги',
                                        @level0type=N'SCHEMA',   @level0name=N'dbo',
                                        @level1type=N'TABLE',    @level1name=N'Books',
                                        @level2type=N'COLUMN',   @level2name=N'Title_book'

        EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Код автора',
                                        @level0type=N'SCHEMA',   @level0name=N'dbo',
                                        @level1type=N'TABLE',    @level1name=N'Books',
                                        @level2type=N'COLUMN',   @level2name=N'Code_author'

        EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Количество страниц',
                                        @level0type=N'SCHEMA',   @level0name=N'dbo',
                                        @level1type=N'TABLE',    @level1name=N'Books',
                                        @level2type=N'COLUMN',   @level2name=N'Pages'

        EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Код издательства',
                                        @level0type=N'SCHEMA',   @level0name=N'dbo',
                                        @level1type=N'TABLE',    @level1name=N'Books',
                                        @level2type=N'COLUMN',   @level2name=N'Code_publish'
    END
ELSE
    PRINT('Books table already exists.')

-- Purchases table
IF OBJECT_ID('dbo.Purchases') IS NULL
    BEGIN
        CREATE TABLE dbo.Purchases
        (
            Code_book INT NOT NULL FOREIGN KEY REFERENCES dbo.Books(Code_book),
            Date_order DATETIME NOT NULL,
            Code_delivery INT NOT NULL FOREIGN KEY REFERENCES dbo.Deliveries(Code_delivery),
            Type_purchase BIT NOT NULL,
            Cost MONEY NOT NULL,
            Amount INT NOT NULL,
            Code_purchase INT IDENTITY(1, 1) PRIMARY KEY
        )
        EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Покупки',
                                        @level0type=N'SCHEMA',   @level0name=N'dbo',
                                        @level1type=N'TABLE',    @level1name=N'Purchases'

        EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Код закупаемой книги',
                                        @level0type=N'SCHEMA',   @level0name=N'dbo',
                                        @level1type=N'TABLE',    @level1name=N'Purchases',
                                        @level2type=N'COLUMN',   @level2name=N'Code_book'

        EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Дата заказа книги',
                                        @level0type=N'SCHEMA',   @level0name=N'dbo',
                                        @level1type=N'TABLE',    @level1name=N'Purchases',
                                        @level2type=N'COLUMN',   @level2name=N'Date_order'

        EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Код поставщика',
                                        @level0type=N'SCHEMA',   @level0name=N'dbo',
                                        @level1type=N'TABLE',    @level1name=N'Purchases',
                                        @level2type=N'COLUMN',   @level2name=N'Code_delivery'

        EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Тип закупки (опт/розница)',
                                        @level0type=N'SCHEMA',   @level0name=N'dbo',
                                        @level1type=N'TABLE',    @level1name=N'Purchases',
                                        @level2type=N'COLUMN',   @level2name=N'Type_purchase'

        EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Стоимость единицы товара',
                                        @level0type=N'SCHEMA',   @level0name=N'dbo',
                                        @level1type=N'TABLE',    @level1name=N'Purchases',
                                        @level2type=N'COLUMN',   @level2name=N'Cost'

        EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Количество экземпляров',
                                        @level0type=N'SCHEMA',   @level0name=N'dbo',
                                        @level1type=N'TABLE',    @level1name=N'Purchases',
                                        @level2type=N'COLUMN',   @level2name=N'Amount'

        EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Код покупки',
                                        @level0type=N'SCHEMA',   @level0name=N'dbo',
                                        @level1type=N'TABLE',    @level1name=N'Purchases',
                                        @level2type=N'COLUMN',   @level2name=N'Code_purchase'
    END
ELSE
    PRINT('Purchases table already exists.')

CREATE NONCLUSTERED INDEX Idx_Authors_Name_author
    ON dbo.Authors(Name_author ASC)

CREATE NONCLUSTERED INDEX Idx_Publishing_house_Publish
    ON dbo.Publishing_house(Publish ASC)

CREATE NONCLUSTERED INDEX Idx_Deliveries_Name_company
    ON dbo.Deliveries(Name_company ASC)

CREATE NONCLUSTERED INDEX Idx_Books_Title_book
    ON dbo.Books(Title_book ASC)

CREATE NONCLUSTERED INDEX Idx_Purchases_Date_order_Cost_Amount
    ON dbo.Purchases(Date_order ASC, Cost ASC, Amount ASC)



-- ALTER TABLE dbo.Authors FILLFACTOR = 95
    -- ALTER COLUMN Name_author CHAR(60) NOT NULL INDEX Idx1 NONCLUSTERED
    -- ALTER COLUMN Name_author ADD INDEX Idx1 ASC
    -- ADD INDEX Idx1 NONCLUSTERED Name_author ASC

