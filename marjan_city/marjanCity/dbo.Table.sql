CREATE TABLE [dbo].[Table]
(
	[registration] VARCHAR(50) NOT NULL PRIMARY KEY, 
    [plot ] VARCHAR(50) NOT NULL, 
    [name] VARCHAR(50) NOT NULL, 
    [fname] VARCHAR(50) NOT NULL, 
    [address] VARCHAR(200) NOT NULL, 
    [phone] VARCHAR(50) NOT NULL, 
    [cnic] VARCHAR(50) NOT NULL, 
    [block] VARCHAR(200) NOT NULL, 
    [commission] INT NULL, 
    [downpayment] INT NULL, 
    [installment] INT NULL
)
