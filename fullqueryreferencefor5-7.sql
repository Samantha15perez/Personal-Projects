USE MASTER;

IF (Select COUNT(*) from sys.databases where name = 'DateConversion') >0

 BEGIN
 DROP DATABASE DateConversion
 END

 CREATE DATABASE DateConversion;
 
 GO

 Use DateConversion;

  IF (Select COUNT(*) from INFORMATION_SCHEMA.tables t where t.TABLE_NAME = 'MembersTable') > 0 
 BEGIN
 DROP TABLE MembersTable
 END 

 CREATE TABLE MembersTable
 (
 FirstName Nvarchar(40) NOT NULL,
 LastName Nvarchar(40) NOT NULL,
 BirthDate Nvarchar(40) NOT NULL,
 City Nvarchar(40) NOT NULL,
 [State] Nvarchar(40) NOT NULL,
 JoinDate Nvarchar(40) NOT NULL,
 )

 CREATE TABLE MembersTableConverted
(FirstName VARCHAR(40),
LastName VARCHAR(50),
BirthDate DATE,
City VARCHAR(50),
[State] VARCHAR(50),
JoinDate DATE
)
 
 BULK INSERT Memberstable
FROM 'C:\Users\CyberAdmin\Desktop\MemberSort.csv'
WITH
(
FIRSTROW = 1, -- secopnd row if header row in file
FIELDTERMINATOR = ',',  --CSV field delimiter
ROWTERMINATOR = '\n',   --Use to shift the control to next row
ERRORFILE = 'C:\Users\Cyberadmin\Desktop\memberserr.csv',
TABLOCK
)

go
create function [dbo].[Date_Fixer_Upper]
(@inputDate AS Varchar(50))
RETURNS DATE
AS
BEGIN

DECLARE @Result DATE = NULL;
DECLARE @YearLength INT = 0;
DECLARE @YearValue INT = 0;


IF LEN(@inputDate) > 0
BEGIN

set @inputDate = LTRIM(RTRIM(@Inputdate))

IF LEFT(@Inputdate, 1) = '0'
BEGIN
SET @inputDate = RIGHT(@inputDate, LEN(@inputDate) - 1);
END

--set delimiters to all the same character to lessen the headache
SET @inputDate = REPLACE(@inputDate, ' ', '/');
SET @inputDate = REPLACE(@inputDate, '-', '/');
SET @inputDate = REPLACE(@inputDate, '.', '/');

WHILE CHARINDEX('//', @inputDate) != 0
BEGIN
SET @inputDate = REPLACE(@inputDate, '//', '/')
END
 --somehow reversing the date makes it easier to find the physical length of the year. it works so i'm not questioning it. 
DECLARE @reverseIn VARCHAR(255) = REVERSE(@inputDate); 
SET @yearLength = CHARINDEX('/', @reverseIn) - 1;

SET @YearValue = convert(int, reverse(left(@reverseIn, 2)));

--if the year is two digits long (instead of the standard four) this fixes it. 
--this basically asks if the length of the supplied year is more than zero, but less than four. 
--if it's equal to four, it gets left alone. 

IF @yearlength < 4 and @YearLength > 0
BEGIN

--if the digits for the year is less than the last two digits of the current year, its switched around to the last century. 
--'cause we don't want anyone born in 2019 do we?

IF @yearValue < 10
BEGIN
SET @inputDate = CONCAT(LEFT(@inputDate, LEN(@inputDate) - (@yearLength)), '200', @yearValue);
END
ELSE IF @yearValue >=  YEAR(GETDATE()) % 100
BEGIN
SET @inputDate = CONCAT(LEFT(@inputDate, LEN(@inputDate) - (@yearLength)), '19', @yearValue); 
END
ELSE    
BEGIN
SET @inputDate = CONCAT(LEFT(@inputDate, LEN(@inputDate) - (@yearLength)), '20', @yearValue);
END
END

--now we just need to remove the extra zeroes
--this takes any unneeded zero and 'removes' it, by just replacing it with the same value minus the zero. 
SET @inputDate = REPLACE(@inputDate, '/0', '/');

--@f retrieves the first number in the date string , while @s retrieves the second number.
DECLARE @f VARCHAR(5) = SUBSTRING(@inputDate, 1, CHARINDEX('/', @inputDate, 0) - 1)
DECLARE @s VARCHAR(5) = SUBSTRING(@inputDate, CHARINDEX('/', @inputDate, 0) + 1, 
(CHARINDEX('/', @inputDate, CHARINDEX('/', @inputDate, CHARINDEX('/', @inputDate, 0) + 1)) - CHARINDEX('/', @inputDate, 0)  - 1))
--Checks if both values retrieved are numeric
IF ISNUMERIC(@s) = 1 AND ISNUMERIC(@f) = 1
BEGIN
--If the format is like this: DD/MM/YYYY and is solely numeric...
IF @f > 12 AND @s <= 12
BEGIN
--...the DD and the MM are switched around.
SET @inputDate = STUFF(@inputDate, 1, 2, @s)
SET @inputDate = STUFF(@inputDate, CHARINDEX('/', @inputDate, 0) + 1, LEN(@s), @f)
END
END
--At this point, the date should be in a suitable format, and it is then converted to a date data type, and put into the result variable.
SET @result = CONVERT(DATE, @inputDate, 101);

END
 
 RETURN @result;

END

GO

INSERT INTO MembersTableConverted

Select FirstName, LastName, dbo.[Date_Fixer_Upper](Birthdate), City, [State], dbo.[Date_Fixer_Upper](Joindate)
FROM MembersTable

select * from MembersTableConverted







--ok its pseudocode time

--look through the files and find the symbols used as delimiters

--replace all delimiters with "/"

--use stringsplit to verify whether or not the first part of the date (before the delimiter) is 4 characters, if so, thats the year.

--once the date types have been verified, use stringsplit to convert from XX/XX/XX to X/Y/Z

--use variables to switch the date into the proper order, ie: 31/04/18 >> X/Y/Z >> Y/X/Z >> 04/31/18

--then verify if the first part of the date is greater than or less than 12. this is a good way (though not perfect) to verify
--whether or not the date is MM/DD or DD/MM

--if any of the variables are 4 characters, automatically move it to last

--figure out how to put in the full year ie: 4/31/18 >> 4/31/2018

