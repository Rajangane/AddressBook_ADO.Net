-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the procedure.
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE SpAddPersonDetail
(
@id int,
@FirstName varchar(255),
@LastName varchar(255),
@Address varchar(255),
@PhoneNumber varchar(255),
@zip int,
@City varchar(255),
@State varchar(255),
@Email varchar(255),
@AddressBookName varchar(255),
@Type varchar(255)
)
	-- Add the parameters for the stored procedure here

AS
BEGIN
insert into AddressBook values
(
@ID,@FirstName,@LastName,@Address,@City,@State,@zip,@PhoneNumber,@Email,@AddressBookName,@Type
)
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT ID,FirstName,LastName,Address,City,State,@zip,@PhoneNumber,Email,AddressBookName,Type from AddressBook
END
GO
