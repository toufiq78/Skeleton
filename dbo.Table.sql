CREATE TABLE [dbo].[StockTable]
(
	[StockId] INT NOT NULL PRIMARY KEY, 
    [Manufacturer] CHAR(10) NULL, 
    [Model] VARCHAR(10) NULL, 
    [Condition] CHAR(10) NULL, 
    [Price] INT NULL
)
