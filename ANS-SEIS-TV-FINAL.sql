--create database
CREATE DATABASE ANS_SEIS_TV
USE ANS_SEIS_TV

--drop the database in case something happens
USE MASTER
DROP DATABASE ANS_SEIS_TV

-- THE ARRANGEMENT OF CODES BELOW ARE THE WAY HOW THEY SHOULD BE RUNNED



---------------------------------------------------------------------------------
---------------------------------------------------------------------------------

--THIS ARE OF THE SQL CODE IS FOR USERS ONLY

---------------------------------------------------------------------------------
---------------------------------------------------------------------------------

-- TABLES THAT NEED TO BE REFERENCED FIRST

-- DROP USERTYPE TABLE
DROP TABLE USERTYPE

--SHOW USERTYPE DATA FROM TABLE
SELECT * FROM USERTYPE

--for userype table
CREATE TABLE USERTYPE
(
USERTYPE_ID INT UNIQUE IDENTITY(110,1),
USERTYPE_DESCRIPTION VARCHAR(50)
)

---------------------------------------------------------------------------------
---------------------------------------------------------------------------------

-- MAIN USER TABLE

-- DROP TABLE
DROP TABLE TBLUSERDETETAILS

-- DELETE TABLE
DELETE TABLE TBLUSERDETAILS

-- SHOW TABLE DATA
SELECT * FROM TBLUSERDETAILS

-- DELETE TABLE DATA
TRUNCATE TABLE TBLUSERDETAILS

--CREATE TABLE FOR USERS
CREATE TABLE TBLUSERDETAILS
(
GENID INT UNIQUE IDENTITY (1000000,1),
ID VARCHAR(50) PRIMARY KEY,
USERNAME VARCHAR(50),
PASSWORD VARCHAR(MAX),
FIRSTNAME VARCHAR(150),
MIDDLENAME VARCHAR(50),
LASTNAME VARCHAR(100),
CONTACT_NUMBER VARCHAR(20),
SECURITY_QUESTION VARCHAR(MAX),
SECURITY_ANSWER VARCHAR(MAX),
USERTYPE_ID INT FOREIGN KEY references USERTYPE(USERTYPE_ID),
ISFIRSTLOGIN INT
)

---------------------------------------------------------------------------------

-- STORED PROCEDURES FOR TBLUSERDETAILS

-- User ID Generation
CREATE PROC sp_UserID
as
DECLARE @GENID INT
SELECT @GENID = IDENT_CURRENT('TBLUSERDETAILS')
RETURN @GENID

-- Return UserID
CREATE PROC sp_UserReturnID
(
@USERNAME VARCHAR(50),
@GENID INT
)
AS
SELECT USERTYPE_ID FROM TBLUSERDETAILS
WHERE USERNAME=@USERNAME AND @GENID=USERTYPE_ID
RETURN @GENID

--Insert a user
CREATE PROC sp_UserInsert
(
@ID VARCHAR(50),
@USERNAME VARCHAR(50),
@PASSWORD VARCHAR(MAX),
@FIRSTNAME VARCHAR(150),
@MIDDLENAME VARCHAR(50),
@LASTNAME VARCHAR(100),
@CONTACT_NUMBER VARCHAR(20),
@SECURITY_QUESTION VARCHAR(MAX),
@SECURITY_ANSWER VARCHAR(MAX),
@USERTYPE_ID INT,
@ISFIRSTLOGIN INT	
)
AS
INSERT INTO TBLUSERDETAILS
VALUES(@ID,@USERNAME,@PASSWORD,@FIRSTNAME,@MIDDLENAME,@LASTNAME,@CONTACT_NUMBER, @SECURITY_QUESTION,@SECURITY_ANSWER,@USERTYPE_ID,@ISFIRSTLOGIN)

-- First Login Edit
CREATE PROC sp_UserFirstLoginEdit
(
@GENID INT,
@ISFIRSTLOGIN INT
)
AS
UPDATE TBLUSERDETAILS
SET ISFIRSTLOGIN=@ISFIRSTLOGIN
WHERE GENID=@GENID

CREATE PROC sp_UserFirstLogin
(
@USERNAME VARCHAR(50),
@PASSWORD VARCHAR(MAX),
@SECURITY_QUESTION VARCHAR(MAX),
@SECURITY_ANSWER VARCHAR(MAX)
)
as
UPDATE TBLUSERDETAILS
SET USERNAME=@USERNAME,PASSWORD=@PASSWORD,SECURITY_QUESTION=@SECURITY_QUESTION,SECURITY_ANSWER=@SECURITY_ANSWER,ISFIRSTLOGIN=0
WHERE USERNAME=@USERNAME

CREATE PROC sp_AccountRecovery
(
	@Username varchar(50),
	@SecurityQuestion varchar(max),
	@SecurityAnswer varchar(max)
)
as
SELECT USERNAME FROM TBLUSERDETAILS
WHERE USERNAME=@Username and SECURITY_QUESTION=@SecurityQuestion and SECURITY_ANSWER=@SecurityAnswer

CREATE PROC sp_ChangePassword
(
	@Username varchar(50),
	@Password varchar(max)
)
as
update TBLUSERDETAILS
set PASSWORD=@Password
where USERNAME=@Username

--Edit User
CREATE PROC sp_UserEdit
(
@GENID INT,
@ID VARCHAR(50),
@USERNAME VARCHAR(50),
@PASSWORD VARCHAR(MAX),
@FIRSTNAME VARCHAR(150),
@MIDDLENAME VARCHAR(50),
@LASTNAME VARCHAR(100),
@CONTACT_NUMBER VARCHAR(20),
@SECURITY_QUESTION VARCHAR(MAX),
@SECURITY_ANSWER VARCHAR(MAX),
@USERTYPE_ID INT
)
AS
UPDATE TBLUSERDETAILS
SET USERNAME=@USERNAME,PASSWORD=@PASSWORD,FIRSTNAME=@FIRSTNAME,MIDDLENAME=@MIDDLENAME,LASTNAME=@LASTNAME,CONTACT_NUMBER=@CONTACT_NUMBER,SECURITY_QUESTION=@SECURITY_QUESTION,SECURITY_ANSWER=@SECURITY_ANSWER,USERTYPE_ID=@USERTYPE_ID
WHERE ID=@ID

-- Delete User
CREATE PROC sp_UserDelete
(
@ID VARCHAR(50)
)
as
DELETE FROM TBLUSERDETAILS
WHERE ID=@ID

-- Search User
CREATE PROC sp_UserSearch
(
@SearchKey VARCHAR(50)
)
AS
SELECT GENID AS 'General ID', ID as 'ID', USERNAME as 'Username', FIRSTNAME as 'First Name', MIDDLENAME as 'Middle Name', LASTNAME as 'Last Name',CONTACT_NUMBER AS 'Contact Number', USERTYPE_ID as 'User Type' FROM TBLUSERDETAILS
where GENID like '%'+@SearchKey+'%' or ID like '%'+@SearchKey+'%' or FIRSTNAME like '%'+@SearchKey+'%' or MIDDLENAME like '%'+@SearchKey+'%' or LASTNAME like '%'+@SearchKey+'%' or CONTACT_NUMBER like '%'+@SearchKey+'%'

-- View User Table
CREATE PROC sp_UserView
as
SELECT GENID AS 'General ID', ID as 'ID', USERNAME as 'Username', FIRSTNAME as 'First Name', MIDDLENAME as 'Middle Name', LASTNAME as 'Last Name',CONTACT_NUMBER AS 'Contact Number', USERTYPE_ID as 'User Type' FROM TBLUSERDETAILS

-- User Login
CREATE PROC sp_UserLogin
(
@USERNAME VARCHAR(50),
@PASSWORD VARCHAR(MAX)
)
AS
SELECT USERNAME,PASSWORD FROM TBLUSERDETAILS
WHERE USERNAME=@USERNAME AND PASSWORD=@PASSWORD
RETURN 0

-- Search User 
CREATE PROC sp_UserSearchAdmin
(
	@SearchKey varchar(50)
)
as
SELECT ID as 'ID', USERNAME as 'Username', FIRSTNAME as 'First Name', MIDDLENAME as 'Middle Name', LASTNAME as 'Last Name' FROM TBLUSERDETAILS
WHERE ID  like '%'+@SearchKey+'%' OR USERNAME  like '%'+@SearchKey+'%' OR FIRSTNAME  like '%'+@SearchKey+'%' OR MIDDLENAME like '%'+@SearchKey+'%' OR LASTNAME like '%'+@SearchKey+'%' OR USERTYPE_ID = 111


---------------------------------------------------------------------------------
---------------------------------------------------------------------------------


-- STUDENTS MAIN TABLE
CREATE TABLE TBLSTUDENTDETAILS
(
	GENID INT PRIMARY KEY IDENTITY (3000000,1),
	USERNAME VARCHAR(50),
	PASSWORD VARCHAR(MAX),
	NAME VARCHAR(200),
	USERTYPE_ID INT FOREIGN KEY references USERTYPE(USERTYPE_ID)
)

---------------------------------------------------------------------------------

-- STORED PROCEDURES FOR TBLSTUDENTDETAILS

-- STUDENT INSERT
CREATE PROC sp_StudentInsert
(
@USERNAME VARCHAR(50),
@PASSWORD VARCHAR(MAX),
@NAME VARCHAR(200)
)
as
INSERT INTO TBLSTUDENTDETAILS
VALUES(@USERNAME,@PASSWORD,@NAME,112)

-- STUDENT SEARCH
CREATE PROC sp_StudentSearch
(
@SearchKey VARCHAR(50)
)
as
SELECT GENID,USERNAME,NAME FROM TBLSTUDENTDETAILS
WHERE GENID like '%'+@SearchKey+'%' OR USERNAME like '%'+@SearchKey+'%' OR NAME like '%'+@SearchKey+'%'

-- STUDENT VIEW
CREATE PROC sp_StudentView
as
SELECT GENID,USERNAME,NAME FROM TBLSTUDENTDETAILS




---------------------------------------------------------------------------------

---------------------------------------------------------------------------------

-- REPORTING AND LOGS FOR USERS AND STUDENTS

---------------------------------------------------------------------------------

---------------------------------------------------------------------------------

-- LOGIN REPORT FOR USERS

SELECT * FROM TBLUSERLOGINREPORT

-- MAIN TABLE
CREATE TABLE TBLUSERLOGINREPORT
(
	LoginID int identity(00000000,1) PRIMARY KEY,
	ID varchar(50) FOREIGN KEY REFERENCES TBLUSERDETAILS(ID),
	password varchar(max),
	Action varchar(100),
	Timestamp datetime
)

---------------------------------------------------------------------------------

-- STORED PROCEDURES FOR TBLUSERLOGINREPORT

-- USER LOGIN INSERT
CREATE PROC sp_UserLoginReport
(
	@ID VARCHAR(50),
	@password varchar(max),
	@Action varchar(100),
	@Timestamp datetime
)
as
INSERT INTO TBLUSERLOGINREPORT
VALUES (@ID,@password,@Action,@Timestamp)

---------------------------------------------------------------------------------

---------------------------------------------------------------------------------

-- ACTION REPORT FOR USERS

SELECT * FROM TBLUSERACTIONREPORT

-- ACTION REPORT TABLE
CREATE TABLE TBLUSERACTIONREPORT
(
	ActionID int primary key identity(90000000,1),
	ID varchar(50) FOREIGN KEY REFERENCES TBLUSERDETAILS(ID),
	Action varchar (50),
	Timestamp datetime
)

---------------------------------------------------------------------------------

-- STORED PROCEDURES FOR TBLUSERLOGINREPORT

-- Action Report
create proc sp_UserActionReport
(
	@ID varchar(50),
	@Action varchar (50),
	@Timestamp datetime
)
as
insert into TBLUSERACTIONREPORT
VALUES (@id,@Action,@Timestamp)


---------------------------------------------------------------------------------

---------------------------------------------------------------------------------

-- THINGS REGARDING ABOUT USERS ENDS HERE

---------------------------------------------------------------------------------

---------------------------------------------------------------------------------




---------------------------------------------------------------------------------

---------------------------------------------------------------------------------

-- THINGS REGARDING ABOUT EQUIPMENTS STARTS HERE

---------------------------------------------------------------------------------

---------------------------------------------------------------------------------



-- NEEDED TO BE REFERENCED FIRST

---------------------------------------------------------------------------------

-- EQUIPMENT TYPE TABLE
CREATE TABLE TBLEQUIPMENTTYPE
(
 EQUIPMENT_TYPE_ID INT PRIMARY KEY,
 EQUIPMENT_TYPE_DESCRIPTION VARCHAR(100)
)

---------------------------------------------------------------------------------

-- MAIN EQUIPMENT TABLE

-- SHOW TABLE DATA
SELECT * FROM TBLEQUIPMENTDETAILS

TRUNCATE TABLE TBLEQUIPMENTDETAILS

DROP TABLE TBLEQUIPMENTDETAILS

-- TABLE STRUCTURE
CREATE TABLE TBLEQUIPMENTDETAILS
(
	EQUIPMENT_ID INT UNIQUE identity (2000000,1),
	--EQBARCODE VARCHAR(100) Primary Key, --TO BE DISCUSSED
	EQUIPMENT_NAME VARCHAR(200),
	EQUIPMENT_DESCRIPTION VARCHAR(100),
	EQUIPMENT_TYPE_ID INT FOREIGN KEY REFERENCES TBLEQUIPMENTTYPE(EQUIPMENT_TYPE_ID),
	EQUIPMENT_QUANTITY INT,
	ISBORROWABLE INT
)




---------------------------------------------------------------------------------

-- EQUIPMENT TABLE STORED PROCEDURES

--Equipment ID Generation
create procedure sp_EquipmentID
as
declare @GENID int
select  @GENID = IDENT_CURRENT('TBLEQUIPMENTDETAILS')
return @GENID

-- EQUIPMENT REGISTRATION
CREATE PROCEDURE sp_EquipmentRegister
(
	--@EQUIPMENT_ID INT UNIQUE identity (20000000,1),
	--@EQBARCODE VARCHAR(100),
	@EQUIPMENT_NAME VARCHAR(200),
	@EQUIPMENT_DESCRIPTION VARCHAR(100),
	@EQUIPMENT_TYPE_ID INT,
	@EQUIPMENT_QUANTITY INT,
	@ISBORROWABLE INT
)
as
INSERT INTO TBLEQUIPMENTDETAILS
VALUES(@EQUIPMENT_NAME,@EQUIPMENT_DESCRIPTION,@EQUIPMENT_TYPE_ID,@EQUIPMENT_QUANTITY,@ISBORROWABLE)

-- EDIT EQUIPMENT QUANTITY
CREATE PROCEDURE sp_EquipmentQuantityEdit
(
 @EQUIPMENT_ID INT,
 @EQUIPMENT_QUANTITY INT
 )
 AS
 UPDATE TBLEQUIPMENTDETAILS
 SET EQUIPMENT_QUANTITY=@EQUIPMENT_QUANTITY
 WHERE EQUIPMENT_ID=@EQUIPMENT_ID

 -- DELETE EQUIPMENT 
CREATE PROCEDURE sp_EquipmentDelete
 (
	@EQUIPMENT_ID INT
)
as
DELETE TBLEQUIPMENTDETAILS
WHERE EQUIPMENT_ID=@EQUIPMENT_ID

-- VIEW EQUIPMENT TABLE
CREATE PROC sp_EquipmentView
(
	@SearchKey varchar(50)
)
as
select distinct equipment_id as 'Equipment ID',/*EQBARCODE,*/ EQUIPMENT_NAME as 'Name',equipment_description as 'Description',TBLEQUIPMENTTYPE.EQUIPMENT_TYPE_DESCRIPTION as 'Type',equipment_quantity as 'Quantity' from TBLEQUIPMENTDETAILS
inner join TBLEQUIPMENTTYPE on TBLEQUIPMENTDETAILS.EQUIPMENT_TYPE_ID=TBLEQUIPMENTTYPE.EQUIPMENT_TYPE_ID
where EQUIPMENT_ID  like '%'+@SearchKey+'%' or EQUIPMENT_NAME like '%'+@SearchKey+'%' or EQUIPMENT_DESCRIPTION  like '%'+@SearchKey+'%' /*or EQBARCODE like '%'+@SearchKey+'%' */

--view Equipment Table with barocodo
CREATE PROC sp_EquipmentViewBarcode
(
	@SearchKey varchar(50)
)
as
select TBLEQUIPMENTDETAILS.EQUIPMENT_ID as 'Equipment ID',/*EQBARCODE,*/ EQUIPMENT_NAME as 'Name',equipment_description as 'Description',TBLEQUIPMENTTYPE.EQUIPMENT_TYPE_DESCRIPTION as 'Type',equipment_quantity as 'Quantity',TBLEQUIPMENTBARCODE.EquipmentBarcode from TBLEQUIPMENTDETAILS
inner join TBLEQUIPMENTTYPE on TBLEQUIPMENTDETAILS.EQUIPMENT_TYPE_ID=TBLEQUIPMENTTYPE.EQUIPMENT_TYPE_ID
inner join TBLEQUIPMENTBARCODE ON TBLEQUIPMENTDETAILS.EQUIPMENT_ID=TBLEQUIPMENTBARCODE.Equipment_ID
where TBLEQUIPMENTDETAILS.EQUIPMENT_ID like '%'+@SearchKey+'%' or EQUIPMENT_NAME like '%'+@SearchKey+'%' or EQUIPMENT_DESCRIPTION  like '%'+@SearchKey+'%' /*or EQBARCODE like '%'+@SearchKey+'%' */

--view Equipment Table with barocodo but using patho
CREATE PROC sp_EquipmentViewBarcodePath
(
	@SearchKey varchar(50)
)
as
select TBLEQUIPMENTDETAILS.EQUIPMENT_ID as 'Equipment ID',/*EQBARCODE,*/ EQUIPMENT_NAME as 'Name',equipment_description as 'Description',TBLEQUIPMENTTYPE.EQUIPMENT_TYPE_DESCRIPTION as 'Type',equipment_quantity as 'Quantity',TBLEQUIPMENTBARCODE.EQBarcodepath from TBLEQUIPMENTDETAILS
inner join TBLEQUIPMENTTYPE on TBLEQUIPMENTDETAILS.EQUIPMENT_TYPE_ID=TBLEQUIPMENTTYPE.EQUIPMENT_TYPE_ID
inner join TBLEQUIPMENTBARCODE ON TBLEQUIPMENTDETAILS.EQUIPMENT_ID=TBLEQUIPMENTBARCODE.Equipment_ID
where TBLEQUIPMENTDETAILS.EQUIPMENT_ID like '%'+@SearchKey+'%' or EQUIPMENT_NAME like '%'+@SearchKey+'%' or EQUIPMENT_DESCRIPTION  like '%'+@SearchKey+'%' /*or EQBARCODE like '%'+@SearchKey+'%' */


-- EDIT AN EQUIPMENT
CREATE PROC sp_EquipmentEdit
(
@EQUIPMENT_ID INT,
--@EQBARCODE VARCHAR(100),
@EQUIPMENT_NAME VARCHAR(200),
@EQUIPMENT_DESCRIPTION VARCHAR(100),
@EQUIPMENT_TYPE_ID INT,
@EQUIPMENT_QUANTITY INT
)
as
UPDATE TBLEQUIPMENTDETAILS
SET /*EQBARCODE=@EQBARCODE,*/ EQUIPMENT_NAME=@EQUIPMENT_NAME,EQUIPMENT_DESCRIPTION=@EQUIPMENT_DESCRIPTION, EQUIPMENT_TYPE_ID=@EQUIPMENT_TYPE_ID, EQUIPMENT_QUANTITY=@EQUIPMENT_QUANTITY
WHERE EQUIPMENT_ID=@EQUIPMENT_ID


--SELECT EQBARCODE AS 'Equipment Barcode', EQUIPMENT_NAME as 'Name', EQUIPMENT_DESCRIPTION as 'Description', TBLEQUIPMENTTYPE.EQUIPMENT_TYPE_DESCRIPTION FROM TBLEQUIPMENTDETAILS
--INNER JOIN TBLEQUIPMENTTYPE ON TBLEQUIPMENTDETAILS.EQUIPMENT_TYPE_ID=TBLEQUIPMENTTYPE.EQUIPMENT_TYPE_ID
--WHERE EQBARCODE like '%'+@SearchKey+'%' OR EQUIPMENT_NAME like '%'+@SearchKey+'%' OR EQUIPMENT_DESCRIPTION like '%'+@SearchKey+'%' OR TBLEQUIPMENTTYPE.EQUIPMENT_TYPE_DESCRIPTION like '%'+@SearchKey+'%'

---------------------------------------------------------------------------------

-- EQUIPMENT DESIGNATION
CREATE TABLE EQUIPMENT_DESIGNATION
(
	EQ_DESIGNATION_ID INT PRIMARY KEY IDENTITY(800000,1),
	ID varchar(50) FOREIGN KEY REFERENCES TBLUSERDETAILS(ID),
	--EQBARCODE VARCHAR(100) FOREIGN KEY REFERENCES TBLEQUIPMENTDETAILS(EQBARCODE),
	DATE_DESIGNATED DATETIME,
	DATE_RETURNED DATETIME,
	DESIGNATION_STATUS VARCHAR(50)
)


-------------------------------------------------------------------------------------------------

-------------------------------------------------------------------------------------------------

-- THINGS ABOUT EQUIPMENTS ENDS HERE


-------------------------------------------------------------------------------------------------

-------------------------------------------------------------------------------------------------




-------------------------------------------------------------------------------------------------

-------------------------------------------------------------------------------------------------

-- THINGS ABOUT FACILITIES STARTS HERE


-------------------------------------------------------------------------------------------------

-------------------------------------------------------------------------------------------------

CREATE TABLE TBLFACILITIES
(
	FacilityID INT PRIMARY KEY IDENTITY(12000000,1),
	FacilityName VARCHAR(200),
	GENID INT foreign key references tbluserdetails(GENID),
	FacilityType  VARCHAR(100),
	FacilityRoomNo VARCHAR(100)
)

CREATE PROC sp_NewFacilities
(
	@FacilityName VARCHAR(200),
	@Instructor INT,
	@FacilityType  VARCHAR(100),
	@FacilityRoomNo VARCHAR(100)
)
as
INSERT INTO TBLFACILITIES
VALUES (@FacilityName,@Instructor,@FacilityType,@FacilityRoomNo)

CREATE PROC sp_ViewAllFacilities
(
	@SearchKey VARCHAR(100)
)
AS
SELECT * FROM TBLFACILITIES
WHERE FacilityID like '%'+@SearchKey+'%' OR FacilityName like '%'+@SearchKey+'%' or GENID like '%'+@SearchKey+'%' or FacilityType like '%'+@SearchKey+'%' or FacilityRoomNo like '%'+@SearchKey+'%'






-------------------------------------------------------------------------------------------------

-------------------------------------------------------------------------------------------------

-- THINGS ABOUT FACILITIES ENDS HERE


-------------------------------------------------------------------------------------------------

-------------------------------------------------------------------------------------------------




-------------------------------------------------------------------------------------------------

-------------------------------------------------------------------------------------------------

-- THINGS ABOUT TRANSACTIONS STARTS HERE


-------------------------------------------------------------------------------------------------

-------------------------------------------------------------------------------------------------

 -- THINGS NEED TO BE REFERENCED FIRST

 -------------------------------------------------------------------------------------------------

 SELECT * FROM REQUESTSTATUS

 -- REQUEST STATUS
 CREATE TABLE REQUESTSTATUS
(
REQUESTSTATUSID INT  UNIQUE IDENTITY(300,1),
STATUSDESCRIPTION VARCHAR(15)
)

-------------------------------------------------------------------------------------------------

-- REQUEST TABLE
CREATE TABLE TBLREQUESTTABLE
(
REQUESTID INT UNIQUE identity (4000000,1),
GENID INT foreign key references tbluserdetails(GENID),
REQUESTHEADER VARCHAR(100),
REQUESTCONTENT NVARCHAR(MAX),
DATEREQUESTED DATETIME,
REQUESTSTATUSID INT FOREIGN KEY REFERENCES REQUESTSTATUS(REQUESTSTATUSID),
ISOPENED INT
)

-------------------------------------------------------------------------------------------------

SELECT * FROM TBLREQUESTTABLE

-- STORED PROCEDURES FOR REQUEST TABLE

--NEW REQUEST
CREATE PROC sp_NewRequest
(
@GENID INT,
@REQUESTHEADER VARCHAR(100),
@REQUESTCONTENT NVARCHAR(MAX),
@DATEREQUESTED DATETIME,
@REQUESTSTATUSID INT,
@ISOPENED INT
)
as
INSERT INTO TBLREQUESTTABLE
VALUES (@GENID,@REQUESTHEADER,@REQUESTCONTENT,@DATEREQUESTED,@REQUESTSTATUSID,@ISOPENED)

-- VIEW ALL REQUEST
CREATE PROC sp_ViewAllRequest
as
SELECT TBLREQUESTTABLE.REQUESTID AS 'Request ID', TBLUSERDETAILS.USERNAME as 'Username', TBLREQUESTTABLE.REQUESTHEADER as 'Request Header', TBLREQUESTTABLE.DATEREQUESTED as 'Date Requested', REQUESTSTATUS.STATUSDESCRIPTION as 'Status' from TBLREQUESTTABLE
INNER JOIN TBLUSERDETAILS ON TBLREQUESTTABLE.GENID=TBLUSERDETAILS.GENID
INNER JOIN REQUESTSTATUS ON TBLREQUESTTABLE.REQUESTSTATUSID=REQUESTSTATUS.REQUESTSTATUSID

CREATE PROC sp_ViewOpenRequest
as
SELECT TBLREQUESTTABLE.REQUESTID AS 'Request ID', TBLUSERDETAILS.USERNAME as 'Username', TBLREQUESTTABLE.REQUESTHEADER as 'Request Header', TBLREQUESTTABLE.DATEREQUESTED as 'Date Requested', REQUESTSTATUS.STATUSDESCRIPTION as 'Status' from TBLREQUESTTABLE
INNER JOIN TBLUSERDETAILS ON TBLREQUESTTABLE.GENID=TBLUSERDETAILS.GENID
INNER JOIN REQUESTSTATUS ON TBLREQUESTTABLE.REQUESTSTATUSID=REQUESTSTATUS.REQUESTSTATUSID
WHERE REQUESTSTATUS.REQUESTSTATUSID=300

CREATE PROC sp_ViewPendingRequest
as
SELECT TBLREQUESTTABLE.REQUESTID AS 'Request ID', TBLUSERDETAILS.USERNAME as 'Username', TBLREQUESTTABLE.REQUESTHEADER as 'Request Header', TBLREQUESTTABLE.DATEREQUESTED as 'Date Requested', REQUESTSTATUS.STATUSDESCRIPTION as 'Status' from TBLREQUESTTABLE
INNER JOIN TBLUSERDETAILS ON TBLREQUESTTABLE.GENID=TBLUSERDETAILS.GENID
INNER JOIN REQUESTSTATUS ON TBLREQUESTTABLE.REQUESTSTATUSID=REQUESTSTATUS.REQUESTSTATUSID
WHERE REQUESTSTATUS.REQUESTSTATUSID=301

CREATE PROC sp_ViewApprovedRequest
as
SELECT TBLREQUESTTABLE.REQUESTID AS 'Request ID', TBLUSERDETAILS.USERNAME as 'Username', TBLREQUESTTABLE.REQUESTHEADER as 'Request Header', TBLREQUESTTABLE.DATEREQUESTED as 'Date Requested', REQUESTSTATUS.STATUSDESCRIPTION as 'Status' from TBLREQUESTTABLE
INNER JOIN TBLUSERDETAILS ON TBLREQUESTTABLE.GENID=TBLUSERDETAILS.GENID
INNER JOIN REQUESTSTATUS ON TBLREQUESTTABLE.REQUESTSTATUSID=REQUESTSTATUS.REQUESTSTATUSID
WHERE REQUESTSTATUS.REQUESTSTATUSID=302

CREATE PROC sp_ViewDeniedRequest
as
SELECT TBLREQUESTTABLE.REQUESTID AS 'Request ID', TBLUSERDETAILS.USERNAME as 'Username', TBLREQUESTTABLE.REQUESTHEADER as 'Request Header', TBLREQUESTTABLE.DATEREQUESTED as 'Date Requested', REQUESTSTATUS.STATUSDESCRIPTION as 'Status' from TBLREQUESTTABLE
INNER JOIN TBLUSERDETAILS ON TBLREQUESTTABLE.GENID=TBLUSERDETAILS.GENID
INNER JOIN REQUESTSTATUS ON TBLREQUESTTABLE.REQUESTSTATUSID=REQUESTSTATUS.REQUESTSTATUSID
WHERE REQUESTSTATUS.REQUESTSTATUSID=303

CREATE PROC sp_RequestViewed
(
	@RequestID int
)
as
UPDATE TBLREQUESTTABLE
SET REQUESTSTATUSID=301
WHERE REQUESTID=@RequestID

CREATE PROC sp_RequestReplied
(
	@RequestID int,
	@RequestResponse int
)
as
UPDATE TBLREQUESTTABLE
SET REQUESTSTATUSID=@RequestResponse
WHERE REQUESTID=@RequestID

CREATE PROC sp_TeacherViewAllRequest
(
	@GENID INT
)
AS
SELECT TBLREQUESTTABLE.REQUESTID AS 'Request ID', TBLUSERDETAILS.USERNAME as 'Username', TBLREQUESTTABLE.REQUESTHEADER as 'Request Header', TBLREQUESTTABLE.DATEREQUESTED as 'Date Requested', REQUESTSTATUS.STATUSDESCRIPTION as 'Status' from TBLREQUESTTABLE
INNER JOIN TBLUSERDETAILS ON TBLREQUESTTABLE.GENID=TBLUSERDETAILS.GENID
INNER JOIN REQUESTSTATUS ON TBLREQUESTTABLE.REQUESTSTATUSID=REQUESTSTATUS.REQUESTSTATUSID
WHERE TBLUSERDETAILS.GENID=@GENID

CREATE PROC sp_TeacherViewOpenRequest
(
	@GENID INT
)
AS
SELECT TBLREQUESTTABLE.REQUESTID AS 'Request ID', TBLUSERDETAILS.USERNAME as 'Username', TBLREQUESTTABLE.REQUESTHEADER as 'Request Header', TBLREQUESTTABLE.DATEREQUESTED as 'Date Requested', REQUESTSTATUS.STATUSDESCRIPTION as 'Status' from TBLREQUESTTABLE
INNER JOIN TBLUSERDETAILS ON TBLREQUESTTABLE.GENID=TBLUSERDETAILS.GENID
INNER JOIN REQUESTSTATUS ON TBLREQUESTTABLE.REQUESTSTATUSID=REQUESTSTATUS.REQUESTSTATUSID
WHERE REQUESTSTATUS.REQUESTSTATUSID=300 and TBLUSERDETAILS.GENID=@GENID

CREATE PROC sp_TeacherViewPendingRequest
(
	@GENID INT
)
AS
SELECT TBLREQUESTTABLE.REQUESTID AS 'Request ID', TBLUSERDETAILS.USERNAME as 'Username', TBLREQUESTTABLE.REQUESTHEADER as 'Request Header', TBLREQUESTTABLE.DATEREQUESTED as 'Date Requested', REQUESTSTATUS.STATUSDESCRIPTION as 'Status' from TBLREQUESTTABLE
INNER JOIN TBLUSERDETAILS ON TBLREQUESTTABLE.GENID=TBLUSERDETAILS.GENID
INNER JOIN REQUESTSTATUS ON TBLREQUESTTABLE.REQUESTSTATUSID=REQUESTSTATUS.REQUESTSTATUSID
WHERE REQUESTSTATUS.REQUESTSTATUSID=301 and TBLUSERDETAILS.GENID=@GENID

CREATE PROC sp_TeacherApprovedClosedRequest
(
	@GENID INT
)
AS
SELECT TBLREQUESTTABLE.REQUESTID AS 'Request ID', TBLUSERDETAILS.USERNAME as 'Username', TBLREQUESTTABLE.REQUESTHEADER as 'Request Header', TBLREQUESTTABLE.DATEREQUESTED as 'Date Requested', REQUESTSTATUS.STATUSDESCRIPTION as 'Status' from TBLREQUESTTABLE
INNER JOIN TBLUSERDETAILS ON TBLREQUESTTABLE.GENID=TBLUSERDETAILS.GENID
INNER JOIN REQUESTSTATUS ON TBLREQUESTTABLE.REQUESTSTATUSID=REQUESTSTATUS.REQUESTSTATUSID
WHERE REQUESTSTATUS.REQUESTSTATUSID=302 and TBLUSERDETAILS.GENID=@GENID

CREATE PROC sp_TeacherDeniedClosedRequest
(
	@GENID INT
)
AS
SELECT TBLREQUESTTABLE.REQUESTID AS 'Request ID', TBLUSERDETAILS.USERNAME as 'Username', TBLREQUESTTABLE.REQUESTHEADER as 'Request Header', TBLREQUESTTABLE.DATEREQUESTED as 'Date Requested', REQUESTSTATUS.STATUSDESCRIPTION as 'Status' from TBLREQUESTTABLE
INNER JOIN TBLUSERDETAILS ON TBLREQUESTTABLE.GENID=TBLUSERDETAILS.GENID
INNER JOIN REQUESTSTATUS ON TBLREQUESTTABLE.REQUESTSTATUSID=REQUESTSTATUS.REQUESTSTATUSID
WHERE REQUESTSTATUS.REQUESTSTATUSID=303 and TBLUSERDETAILS.GENID=@GENID


-------------------------------------------------------------------------------------------------

-- Replies about request

CREATE TABLE TBLREQUESTREPLY
(
	ReplyID INT UNIQUE identity (5000000,1),
	REQUESTID INT FOREIGN KEY references TBLREQUESTTABLE(REQUESTID),
	GENID INT foreign key references tbluserdetails(GENID),
	ReplyContent NVARCHAR(MAX),
	DateReplied DATETIME
)

-------------------------------------------------------------------------------------------------

-- Replies about request

CREATE PROC sp_RequestReply
(
	@RequestID INT,
	@GENID INT,
	@REPLYCONTENT NVARCHAR(MAX),
	@DateReplied DATETIME
)
AS
INSERT INTO TBLREQUESTREPLY
VALUES (@RequestID,@GENID,@REPLYCONTENT,@DateReplied)

-------------------------------------------------------------------------------------------------

SELECT * FROM TBLTRANSACTION

-- Transaction Table
CREATE TABLE TBLTRANSACTION
(
	TransactionID INT UNIQUE identity (6000000,1),
	TransactionDate DATETIME,
	TransactionEvent VARCHAR(150),
	GENID INT foreign key references tbluserdetails(GENID)
)


-------------------------------------------------------------------------------------------------

-- Transaction Table Procedures
CREATE PROC sp_NewTransation
(
	@TransactionDate DATETIME,
	@TransactionEvent VARCHAR(150),
	@Admin int
)
as
INSERT INTO TBLTRANSACTION
VALUES(@TransactionDate,@TransactionEvent,@Admin)

--transaction ID
CREATE PROC sp_NewTransactionID
as
DECLARE @TRANSACTIONID int
SELECT @TRANSACTIONID = IDENT_CURRENT('TBLTRANSACTION')
RETURN @TRANSACTIONID

CREATE PROC sp_TransactionViewAll
as
SELECT TransactionID AS 'Transaction ID', TransactionDate as 'Transaction Date', TransactionEvent as 'Transaction Event', TBLUSERDETAILS.LASTNAME+', '+TBLUSERDETAILS.FIRSTNAME+' '+TBLUSERDETAILS.MIDDLENAME as 'Processed By'   FROM TBLTRANSACTION
inner join TBLUSERDETAILS ON TBLTRANSACTION.GENID=TBLUSERDETAILS.GENID


CREATE PROC sp_TransactionSearchDate
(
	@StartDate DATETIME,
	@EndDate DATETIME,
	@EventType VARCHAR(100)
)
as
SELECT TransactionID AS 'Transaction ID', TransactionDate as 'Transaction Date', TransactionEvent as 'Transaction Event', TBLUSERDETAILS.LASTNAME+', '+TBLUSERDETAILS.FIRSTNAME+' '+TBLUSERDETAILS.MIDDLENAME as 'Processed By'   FROM TBLTRANSACTION
inner join TBLUSERDETAILS ON TBLTRANSACTION.GENID=TBLUSERDETAILS.GENID
WHERE TBLTRANSACTION.TransactionEvent like '%'+@EventType+'%' AND TBLTRANSACTION.TransactionDate BETWEEN @StartDate AND @EndDate

SELECT TransactionID AS 'Transaction ID', TransactionDate as 'Transaction Date', TransactionEvent as 'Transaction Event', TBLUSERDETAILS.LASTNAME+', '+TBLUSERDETAILS.FIRSTNAME+' '+TBLUSERDETAILS.MIDDLENAME as 'Processed By'   FROM TBLTRANSACTION
inner join TBLUSERDETAILS ON TBLTRANSACTION.GENID=TBLUSERDETAILS.GENID
WHERE TBLTRANSACTION.TransactionEvent='' AND TBLTRANSACTION.TransactionDate BETWEEN '9/4/18' AND '9/5/18'

-------------------------------------------------------------------------------------------------

-- Borrow Table
CREATE TABLE TBLBORROWED
(
	BorrowID INT UNIQUE identity (7000000,1),
	TransactionID int FOREIGN KEY REFERENCES TBLTRANSACTION(TransactionID),
	GENID INT FOREIGN KEY REFERENCES TBLUSERDETAILS(GENID),
	EQUIPMENT_ID INT FOREIGN KEY REFERENCES TBLEQUIPMENTDETAILS(EQUIPMENT_ID),
	DATEBORROWED DATETIME,
	Quantity int,
	IsGoodCondition BIT,
	IsReturned BIT
)



-------------------------------------------------------------------------------------------------
-- Procedures for borrow table
CREATE PROCEDURE sp_NewBorrow
(
	@TransactionID INT,
	@WhoBorrowed INT,
	@EQUIPMENT_ID INT,
	@DATEBORROWED DATETIME,
	@Quantity int,
	@IsGoodCondition BIT,
	@IsReturned BIT
)
AS
INSERT INTO TBLBORROWED
VALUES (@TransactionID,@WhoBorrowed,@EQUIPMENT_ID,@DATEBORROWED,@Quantity,@IsGoodCondition,@IsReturned)

CREATE PROC sp_DeleteDeletedEquipment
(
	@EQUIPMENT_ID INT
)
as
delete TBLBORROWED
where EQUIPMENT_ID=@EQUIPMENT_ID


-- Borrow Table
CREATE PROC sp_EquipmentBorrowableView
(
	@SearchKey VARCHAR(50)
)
AS
SELECT DISTINCT TBLEQUIPMENTDETAILS.EQUIPMENT_ID AS 'Equipment ID' , TBLEQUIPMENTDETAILS.EQUIPMENT_NAME AS 'Name', TBLEQUIPMENTDETAILS.EQUIPMENT_DESCRIPTION AS 'Description', (TBLEQUIPMENTDETAILS.EQUIPMENT_QUANTITY-TBLBORROWQUANTITY.QUANTITY) as 'Available Quantity' FROM TBLEQUIPMENTDETAILS
INNER JOIN TBLBORROWED ON TBLEQUIPMENTDETAILS.EQUIPMENT_ID =TBLBORROWED.EQUIPMENT_ID
INNER JOIN TBLBORROWQUANTITY ON TBLEQUIPMENTDETAILS.EQUIPMENT_ID=TBLBORROWQUANTITY.EQUIPMENT_ID
INNER JOIN TBLEQUIPMENTTYPE ON TBLEQUIPMENTDETAILS.EQUIPMENT_TYPE_ID=TBLEQUIPMENTTYPE.EQUIPMENT_TYPE_ID
WHERE TBLEQUIPMENTDETAILS.EQUIPMENT_ID like '%'+@SearchKey+'%' OR EQUIPMENT_NAME like '%'+@SearchKey+'%' OR EQUIPMENT_DESCRIPTION like '%'+@SearchKey+'%' OR TBLEQUIPMENTTYPE.EQUIPMENT_TYPE_DESCRIPTION like '%'+@SearchKey+'%'



CREATE PROC sp_EquipmentReturning
(
	@TransactionID int,
	@EquipmentID int,
	@IsGoodCondition bit,
	@IsReturned bit
)
as
UPDATE TBLBORROWED
SET IsGoodCondition=@IsGoodCondition, IsReturned=@IsReturned
WHERE TransactionID=@TransactionID AND EQUIPMENT_ID=@EquipmentID

-------------------------------------------------------------------------------------------------
-- tables ABOUT TOTAL BORROWED

CREATE TABLE TBLBORROWQUANTITY
(
	BORROWID INT UNIQUE IDENTITY(0,1),
	EQUIPMENT_ID INT FOREIGN KEY REFERENCES TBLEQUIPMENTDETAILS(EQUIPMENT_ID),
	QUANTITY INT
)

-------------------------------------------------------------------------------------------------
-- STORED PROCEDURE FOR TBLBORROWQUANTITY


CREATE PROC sp_NewBorrowQuantityAdded
(
	@EQUIPMENT_ID INT,
	@QUANTITY INT
)
AS
INSERT INTO TBLBORROWQUANTITY
VALUES (@EQUIPMENT_ID,@QUANTITY)

CREATE PROC sp_BorrowAddQuantity
(
	@EQUIPMENT_ID INT,
	@QUANTITY INT
)
AS
UPDATE TBLBORROWQUANTITY
SET QUANTITY=@QUANTITY
WHERE EQUIPMENT_ID=@EQUIPMENT_ID


CREATE TABLE TBLEQUIPMENTSTATUS
(
	StatusID INT UNIQUE IDENTITY(100,1),
	EQUIPMENT_ID INT FOREIGN KEY REFERENCES TBLEQUIPMENTDETAILS(EQUIPMENT_ID),
	GoodCondition INT,	--quantity
	BadCondition INT	-- quantity
)

CREATE PROC sp_EquipmentStatusInventoryAdd
(
	@EquipmentID INT,
	@GoodCondition int -- quantity ni siya
)
as
INSERT INTO TBLEQUIPMENTSTATUS
VALUES (@EquipmentID,@GoodCondition,0)

CREATE PROC sp_EquipmentStatusEdit
(
	@EquipmentID INT,
	@GoodCondition int,
	@BadCondition int
)
as
UPDATE TBLEQUIPMENTSTATUS
SET TBLEQUIPMENTSTATUS.GoodCondition=@GoodCondition, TBLEQUIPMENTSTATUS.BadCondition=@BadCondition
WHERE TBLEQUIPMENTSTATUS.EQUIPMENT_ID=@EquipmentID

CREATE PROC sp_EquipmentStatusItemDelete
(
	@EquipmentID INT
)
as
DELETE FROM TBLEQUIPMENTSTATUS
WHERE TBLEQUIPMENTSTATUS.EQUIPMENT_ID=@EquipmentID

-------------------------------------------------------------------------------------------------

-- TABLES FOR RETURN

CREATE TABLE TBLRETURNEDEQUIPMENTS
(
	ReturnID INT UNIQUE identity (8000000,1),
	TransactionID int FOREIGN KEY REFERENCES TBLTRANSACTION(TransactionID),
	EQUIPMENT_ID INT FOREIGN KEY REFERENCES TBLEQUIPMENTDETAILS(EQUIPMENT_ID),
	Quantity int,
	DateReturned DATETIME,
	GENID INT FOREIGN KEY REFERENCES TBLUSERDETAILS(GENID),
)

CREATE PROC sp_ViewBorrowedEquipment
(
	@TransactionID int
)
as
SELECT TBLEQUIPMENTDETAILS.EQUIPMENT_ID as 'ID', TBLEQUIPMENTDETAILS.EQUIPMENT_NAME as 'Name', TBLBORROWED.Quantity, TBLBORROWED.IsGoodCondition as 'Returned?', TBLBORROWED.IsGoodCondition AS 'Good Condition?' FROM TBLBORROWED
INNER JOIN TBLEQUIPMENTDETAILS ON TBLBORROWED.EQUIPMENT_ID=TBLEQUIPMENTDETAILS.EQUIPMENT_ID
INNER JOIN TBLTRANSACTION ON TBLBORROWED.TransactionID=TBLTRANSACTION.TransactionID
WHERE TBLTRANSACTION.TransactionID=@TransactionID

CREATE PROC sp_CurrentBorrowed
(
	@TransactionID int
)
as
SELECT DISTINCT TBLEQUIPMENTBARCODE.EQBarcodepath AS 'BARCODE', TBLEQUIPMENTDETAILS.EQUIPMENT_ID as 'ID', TBLEQUIPMENTDETAILS.EQUIPMENT_NAME as 'Name', TBLBORROWED.Quantity FROM TBLBORROWED
INNER JOIN TBLEQUIPMENTDETAILS ON TBLBORROWED.EQUIPMENT_ID=TBLEQUIPMENTDETAILS.EQUIPMENT_ID
INNER JOIN TBLTRANSACTION ON TBLBORROWED.TransactionID=TBLTRANSACTION.TransactionID
INNER JOIN TBLEQUIPMENTBARCODE ON TBLBORROWED.EQUIPMENT_ID=TBLEQUIPMENTBARCODE.Equipment_ID
WHERE TBLTRANSACTION.TransactionID=@TransactionID



CREATE PROC sp_ReturnEquipments
(
	@TransactionID int,
	@EQUIPMENT_ID INT,
	@Quantity int,
	@DateReturned DATETIME,
	@GENID INT
)
as
INSERT INTO TBLRETURNEDEQUIPMENTS
VALUES (@TransactionID,@EQUIPMENT_ID,@Quantity,@DateReturned,@GENID)

-------------------------------------------------------------------------------------------------

-- TABLES FOR RESERVATION

CREATE TABLE TBLEQUIPMENTRESERVATION
(
	ReservationID INT UNIQUE identity (9000000,1),
	TransactionID int FOREIGN KEY REFERENCES TBLTRANSACTION(TransactionID),
	GENID INT FOREIGN KEY REFERENCES TBLUSERDETAILS(GENID),
	EQUIPMENT_ID INT FOREIGN KEY REFERENCES TBLEQUIPMENTDETAILS(EQUIPMENT_ID),
	DateReserved DATETIME,
	Quantity int,
	IsReturned BIT,
)

CREATE PROC sp_NewReservation
(
	@TransactionID INT,
	@WhoReserved INT,
	@EquipmentID INT,
	@DateBorrowed DATETIME,
	@Quantity int,
	@IsReturned BIT
)
AS
INSERT INTO TBLEQUIPMENTRESERVATION
VALUES (@TransactionID,@WhoReserved,@EquipmentID,@DateBorrowed,@Quantity,@IsReturned)

CREATE PROC sp_ReturnReservedEquipment
(
	@TransactionID int,
	@EquipmentID int,
	@IsReturned bit
)
as
UPDATE TBLEQUIPMENTRESERVATION
SET TBLEQUIPMENTRESERVATION.IsReturned=@IsReturned
WHERE TransactionID=@TransactionID and EQUIPMENT_ID=@EquipmentID


-------------------------------------------------------------------------------------------------

-- TABLES FOR DEPLOYMENT

CREATE TABLE TBLDEPLOYMENT
(
	DeploymentID INT PRIMARY KEY IDENTITY(13000000,1),
	TransactionID int FOREIGN KEY REFERENCES TBLTRANSACTION(TransactionID),
	FacilitiyID INT FOREIGN KEY REFERENCES TBLFACILITIES(FacilityID)
)

CREATE PROC sp_NewDeployment
(
	@TransactionID int,
	@FacilitiyID INT
)
AS
INSERT INTO TBLDEPLOYMENT
VALUES (@TransactionID, @FacilitiyID)


-------------------------------------------------------------------------------------------------

-------------------------------------------------------------------------------------------------

-- THINGS ABOUT TRANSACTIONS ENDS HERE


-------------------------------------------------------------------------------------------------

-------------------------------------------------------------------------------------------------






-------------------------------------------------------------------------------------------------

-------------------------------------------------------------------------------------------------

-- THINGS ABOUT BARCODES STARTS HERE


-------------------------------------------------------------------------------------------------

-------------------------------------------------------------------------------------------------


-- EQUIPMENT BARCODES TABLE


CREATE TABLE TBLEQUIPMENTBARCODE
(
	BarcodeID INT UNIQUE identity (10000000,1),
	Equipment_ID INT FOREIGN KEY REFERENCES TBLEQUIPMENTDETAILS(EQUIPMENT_ID),
	EquipmentBarcode varbinary(MAX),
	EQBarcodepath VARCHAR(MAX)
)

CREATE PROC sp_NewEquipmentBarcodeInsert
(
	@Equipment_ID INT,
	@EquipmentBarcode varbinary(MAX),
	@EQBarcodepath VARCHAR(MAX)
)
AS
INSERT INTO TBLEQUIPMENTBARCODE
VALUES (@Equipment_ID,@EquipmentBarcode,@EQBarcodepath)



-- BORROWING BARCODES TABLE
CREATE TABLE TBLBORRIWINGBARCODE
(
	BarcodeID INT UNIQUE identity (11000000,1),
	TransactionID int FOREIGN KEY REFERENCES TBLTRANSACTION(TransactionID),
	BorrowingBarcode VARBINARY(MAX),
	BWBarcodePath VARCHAR(MAX)
)

CREATE PROC sp_NewBorrowBarcodeInsert
(
	@TransactionID int,
	@BorrowingBarcode VARBINARY(MAX),
	@BWBarcodePath VARCHAR(MAX)
)
AS
INSERT INTO TBLBORRIWINGBARCODE
VALUES (@TransactionID,@BorrowingBarcode,@BWBarcodePath)


CREATE PROC sp_ViewTransactionBarcode
(
	@SearchBarcode int
)
as
SELECT TBLBORRIWINGBARCODE.BWBarcodePath FROM TBLBORRIWINGBARCODE
WHERE TransactionID=@SearchBarcode


-------------------------------------------------------------------------------------------------

-------------------------------------------------------------------------------------------------

-- THINGS ABOUT BARCODES STARTS HERE


-------------------------------------------------------------------------------------------------

-------------------------------------------------------------------------------------------------







-- INITIAL TABLE DATA'S


-------------------------------------------------------------------------------------------------

-------------------------------------------------------------------------------------------------

-- USERTYPE
INSERT INTO USERTYPE
VALUES	('ADMINISTRATOR'),
		('TEACHER'),
		('STUDENT')

-- TBLUSERDETAILS
insert into TBLUSERDETAILS
values ('AD-1000000','nate','1234','Nathaniel Angelico','Borres','Tabanao','09395686461','Where Do you live?','Cave','110','1'),
('AD-1000001','jamie','1234','Jamie Hanna','Short','Dionson','09222729916','test','test','110','1')

-- STUDENTS
INSERT INTO TBLSTUDENTDETAILS
VALUES	('NTABANAO','1234','NATHANIEL ANGELICO TABANAO',112),
		('JHDIONSON','1234','JAMIE HANNA DIONSON',112),
		('JBGEONSON','1234','JOHN BROWN GEONSON',112),
		('NTfdABANAO','1234','ALLY',112)

-- EQUIPMENT TYPE
INSERT INTO TBLEQUIPMENTTYPE
VALUES	(200,'General EquipmentT'),
		(201,'Computer Equipment'),
		(202,'Culinary Equipment'),
		(203,'Automotive Equipment'),
		(204,'Electronic Equipent'),
		(205,'Machineries')


-- REQUEST STATUS
INSERT INTO REQUESTSTATUS
VALUES	('NEW REQUEST'),
		('PENDING'),
		('APPROVED'),
		('DENIED')

INSERT INTO TBLFACILITIES
VALUES	('Computer Laboratory 1', 1000002, 'Computer Laboratory', '1CL1'),
		('Computer Laboratory 2', 1000003, 'Computer Laboratory', '1CL2'),
		('Computer Laboratory 3', 1000004, 'Computer Laboratory', '1CL3')

SELECT * FROM TBLEQUIPMENTDETAILS
SELECT * FROM TBLTRANSACTION
SELECT * FROM TBLBORROWED
SELECT * FROM TBLBORROWQUANTITY
SELECT * FROM TBLEQUIPMENTBARCODE
SELECT * FROM TBLBORRIWINGBARCODE
SELECT * FROM TBLUSERDETAILS
SELECT * FROM TBLEQUIPMENTSTATUS
SELECT * FROM TBLFACILITIES


DELETE FROM TBLBORROWED
WHERE BorrowID=7000000

DELETE FROM TBLBORROWQUANTITY
WHERE BORROWID=0

truncate table TBLEQUIPMENTDETAILS

SELECT SUM(EQUIPMENT_QUANTITY) FROM TBLEQUIPMENTDETAILS


select TBLFACILITIES.GENID from TBLFACILITIES
where FacilityRoomNo = '1cl1'