USE [Webshop_DB]
GO
/****** Object:  StoredProcedure [dbo].[spAccount_Update]    Script Date: 07-03-2023 19:57:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*
CREATE TABLE Customer (
    CustomerID INT IDENTITY(1,1) PRIMARY KEY,
    Firstname VARCHAR(50) NOT NULL,
    Lastname VARCHAR(50) NOT NULL,
	Date DATETIME NOT NULL,
	Username VARCHAR(50) NOT NULL,
    Password VARCHAR(50) NOT NULL
);
*/


/*
CREATE TABLE Address (
    AddressID INT IDENTITY(1,1) PRIMARY KEY,
	Streetname VARCHAR(50) NOT NULL,
    Streetnumber int NOT NULL,
    Postalcode int NOT NULL,
	City VARCHAR (50) NOT NULL,
	Country VARCHAR (50) NOT NULL,
	CustomerID INT NOT NULL,
    FOREIGN KEY (CustomerID) REFERENCES Customer(CustomerID)
);
*/


/*
CREATE TABLE Account (
    AccountID INT IDENTITY(1,1) PRIMARY KEY,
	Accountname VARCHAR (50) NOT NULL,
	Firstname VARCHAR(50) NOT NULL,
    Lastname VARCHAR (50) NOT NULL,
	Date DATETIME NOT NULL,
	Balance DECIMAL(18,2) DEFAULT 0,
	CustomerID INT NOT NULL,
    FOREIGN KEY (CustomerID) REFERENCES Customer(CustomerID)
);
*/

/*
CREATE TABLE [Order] (
    OrderID INT IDENTITY(1,1) PRIMARY KEY,
	OrderDate DATETIME NOT NULL,
    Total DECIMAL(18,2) DEFAULT 0	
);
*/

/*
CREATE TABLE Product (
    ProductID INT IDENTITY(1,1) PRIMARY KEY,
	Productname VARCHAR(50) NOT NULL,
    Productprice int NOT NULL,	   
	OrderID INT NOT NULL,
    FOREIGN KEY (OrderID) REFERENCES [Order](OrderID)
);
*/

/*
INSERT INTO Customer (Firstname, Lastname, Date, Username, Password)
VALUES ('Leif', 'Soelvason', GETDATE(), 'Admin', 'admin')
*/



/*
CREATE PROCEDURE [dbo].[sp_ValidateCustomer]
    @Username VARCHAR(50),
    @Password VARCHAR(50)
AS
BEGIN
    SELECT *
    FROM Customer
    WHERE Username = @Username AND Password = @Password;
END;
*/

/*
CREATE PROCEDURE [dbo].[spCustomer_Add]
    @Firstname VARCHAR(50),
    @Lastname VARCHAR(50),
    @Username VARCHAR(50),
	@Password VARCHAR(50)
	
	
AS
BEGIN
    DECLARE @CustomerID INT

    INSERT INTO Customer (Firstname, Lastname, Username, Password, Date)
    VALUES (@Firstname, @Lastname, @Username, @Password, GETDATE());

END;
*/

/*
CREATE PROCEDURE [dbo].[sp_GetCustomerList]
as
begin
	SET NOCOUNT ON;

	SELECT CustomerID,Firstname,Lastname,Date
	FROM dbo.Customer;
end
*/

/*
CREATE PROCEDURE [dbo].[spCustomer_GetByLastname]
	@Lastname varchar(50)
as
begin	
	SET NOCOUNT ON;

	SELECT CustomerID,Firstname,Lastname,Date
	FROM dbo.Customer
	WHERE Lastname = @Lastname
end 
*/


/*
CREATE PROCEDURE [dbo].[spCustomer_Update]
		
	@CustomerID int,
	@Firstname varchar (50),
	@Lastname varchar (50),
	@Username varchar (50),
	@Password varchar (50)
		
	
as
begin	
	SET NOCOUNT ON;

	UPDATE dbo.Customer set
	Firstname=@Firstname,Lastname=@Lastname,Username=@Username,Password=@Password WHERE CustomerID=@CustomerID
	
end
*/

/*
CREATE PROCEDURE [dbo].[spCustomer_Delete]
	
	@CustomerID int	
		
as
begin	
	SET NOCOUNT ON;

	DELETE FROM dbo.Customer WHERE CustomerID=@CustomerID
	
end 
*/

/*
CREATE PROCEDURE [dbo].[spAccount_Add]
    @CustomerID int,
	@Accountname VARCHAR (50),
	@Firstname VARCHAR(50),
    @Lastname VARCHAR(50)
   
	
AS
BEGIN
    DECLARE @AccountID INT

    INSERT INTO Account(CustomerID, Accountname, Firstname, Lastname, Date) 
    VALUES (@CustomerID, @Accountname, @Firstname, @Lastname, GETDATE()); 

END;
*/

/*
CREATE PROCEDURE [dbo].[sp_GetAccountList]
as
begin
	SET NOCOUNT ON;

	SELECT AccountID, CustomerID, Accountname, Firstname,Lastname,Date
	FROM dbo.Account;
end
*/

/*
CREATE PROCEDURE [dbo].[spAccount_GetByLastname]
	@Lastname varchar(50)
as
begin	
	SET NOCOUNT ON;

	SELECT AccountID, CustomerID, Accountname, Firstname, Lastname, Date
	FROM dbo.Account
	WHERE Lastname = @Lastname
end 
*/

/*
CREATE PROCEDURE [dbo].[spAddress_Update]
	@AddressID int,
	@Streetname varchar (50),
	@Streetnumber int,
	@Postalcode int,
	@City varchar (50),
	@Country varchar (50),
	@CustomerID int
				
as
begin	
	SET NOCOUNT ON;

	UPDATE dbo.Address set
	Streetname = @Streetname, Streetnumber = @Streetnumber, Postalcode = @Postalcode, City = @City, Country = @Country, CustomerID = @CustomerID WHERE AddressID=@AddressID
	
end 
*/

/*
CREATE PROCEDURE [dbo].[spAddress_Delete]
	
	@AddressID int	
		
as
begin	
	SET NOCOUNT ON;

	DELETE FROM dbo.Address WHERE AddressID=@AddressID
	
end 

*/