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
TRUNCATE TABLE TBLUSERDETAILSX

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
WHERE ID  like '%'+@SearchKey+'%' OR USERNAME  like '%'+@SearchKey+'%' OR FIRSTNAME  like '%'+@SearchKey+'%' OR MIDDLENAME like '%'+@SearchKey+'%' OR LASTNAME like '%'+@SearchKey+'%' AND USERTYPE_ID = 111

---------------------------------------------------------------------------------
---------------------------------------------------------------------------------


-- STUDENTS MAIN TABLE
CREATE TABLE TBLSTUDENTDETAILS
(
	GENID INT PRIMARY KEY IDENTITY (3000000,1),
	USERNAME VARCHAR(50),
	PASSWORD VARCHAR(MAX),
	NAME VARCHAR(200)
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
VALUES(@USERNAME,@PASSWORD,@NAME)

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
CREATE TABLE TBLEQEUIPMENTTYPE
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
	EQBARCODE VARCHAR(100) Primary Key, --TO BE DISCUSSED
	EQUIPMENT_NAME VARCHAR(200),
	EQUIPMENT_DESCRIPTION VARCHAR(100),
	EQUIPMENT_TYPE_ID INT FOREIGN KEY REFERENCES TBLEQEUIPMENTTYPE(EQUIPMENT_TYPE_ID),
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
	@EQBARCODE VARCHAR(100),
	@EQUIPMENT_NAME VARCHAR(200),
	@EQUIPMENT_DESCRIPTION VARCHAR(100),
	@EQUIPMENT_TYPE_ID INT,
	@EQUIPMENT_QUANTITY INT,
	@ISBORROWABLE INT
)
as
INSERT INTO TBLEQUIPMENTDETAILS
VALUES(@EQBARCODE,@EQUIPMENT_NAME,@EQUIPMENT_DESCRIPTION,@EQUIPMENT_TYPE_ID,@EQUIPMENT_QUANTITY,@ISBORROWABLE)

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
select equipment_id,EQUIPMENT_NAME,equipment_description,equipment_type_id,equipment_quantity from TBLEQUIPMENTDETAILS
where EQUIPMENT_ID  like '%'+@SearchKey+'%' or EQUIPMENT_NAME like '%'+@SearchKey+'%' or EQUIPMENT_DESCRIPTION  like '%'+@SearchKey+'%'

-- EDIT AN EQUIPMENT
CREATE PROC sp_EquipmentEdit
(
@EQUIPMENT_ID INT,
@EQBARCODE VARCHAR(100),
@EQUIPMENT_NAME VARCHAR(200),
@EQUIPMENT_DESCRIPTION VARCHAR(100),
@EQUIPMENT_TYPE_ID INT,
@EQUIPMENT_QUANTITY INT
)
as
UPDATE TBLEQUIPMENTDETAILS
SET EQBARCODE=@EQBARCODE, EQUIPMENT_NAME=@EQUIPMENT_NAME,EQUIPMENT_DESCRIPTION=@EQUIPMENT_DESCRIPTION, EQUIPMENT_TYPE_ID=@EQUIPMENT_TYPE_ID, EQUIPMENT_QUANTITY=@EQUIPMENT_QUANTITY
WHERE EQUIPMENT_ID=@EQUIPMENT_ID


-- Borrow Table
CREATE PROC sp_EquipmentBorrowableView
(
	@SearchKey VARCHAR(50)
)
AS
SELECT EQBARCODE AS 'Equipment Barcode', EQUIPMENT_NAME as 'Name', EQUIPMENT_DESCRIPTION as 'Description', TBLEQEUIPMENTTYPE.EQUIPMENT_TYPE_DESCRIPTION FROM TBLEQUIPMENTDETAILS
INNER JOIN TBLEQEUIPMENTTYPE ON TBLEQUIPMENTDETAILS.EQUIPMENT_TYPE_ID=TBLEQEUIPMENTTYPE.EQUIPMENT_TYPE_ID
WHERE EQBARCODE like '%'+@SearchKey+'%' OR EQUIPMENT_NAME like '%'+@SearchKey+'%' OR EQUIPMENT_DESCRIPTION like '%'+@SearchKey+'%' OR TBLEQEUIPMENTTYPE.EQUIPMENT_TYPE_DESCRIPTION like '%'+@SearchKey+'%'

---------------------------------------------------------------------------------

-- EQUIPMENT DESIGNATION
CREATE TABLE EQUIPMENT_DESIGNATION
(
	EQ_DESIGNATION_ID INT PRIMARY KEY IDENTITY(800000,1),
	ID varchar(50) FOREIGN KEY REFERENCES TBLUSERDETAILS(ID),
	EQBARCODE VARCHAR(100) FOREIGN KEY REFERENCES TBLEQUIPMENTDETAILS(EQBARCODE),
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

-- THINGS ABOUT TRANSACTIONS STARTS HERE


-------------------------------------------------------------------------------------------------

-------------------------------------------------------------------------------------------------

 -- THINGS NEED TO BE REFERENCED FIRST

 -------------------------------------------------------------------------------------------------

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

CREATE PROC sp_ViewClosedRequest
as
SELECT TBLREQUESTTABLE.REQUESTID AS 'Request ID', TBLUSERDETAILS.USERNAME as 'Username', TBLREQUESTTABLE.REQUESTHEADER as 'Request Header', TBLREQUESTTABLE.DATEREQUESTED as 'Date Requested', REQUESTSTATUS.STATUSDESCRIPTION as 'Status' from TBLREQUESTTABLE
INNER JOIN TBLUSERDETAILS ON TBLREQUESTTABLE.GENID=TBLUSERDETAILS.GENID
INNER JOIN REQUESTSTATUS ON TBLREQUESTTABLE.REQUESTSTATUSID=REQUESTSTATUS.REQUESTSTATUSID
WHERE REQUESTSTATUS.REQUESTSTATUSID=302

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
	@RequestID int
)
as
UPDATE TBLREQUESTTABLE
SET REQUESTSTATUSID=302
WHERE REQUESTID=@RequestID

-------------------------------------------------------------------------------------------------

-- Replies about request

CREATE TABLE TBLREQUESTREPLY
(
	ReplyID INT UNIQUE identity (5000000,1),
	GENID INT foreign key references tbluserdetails(GENID),
	ReplyContent NVARCHAR(MAX)
)

-------------------------------------------------------------------------------------------------

-- Replies about request

CREATE PROC sp_RequestReply
(
	@GENID INT,
	@REPLYCONTENT NVARCHAR(MAX)
)
AS
INSERT INTO TBLREQUESTREPLY
VALUES (@GENID,@REPLYCONTENT)

-------------------------------------------------------------------------------------------------

-------------------------------------------------------------------------------------------------

-- THINGS ABOUT TRANSACTIONS ENDS HERE


-------------------------------------------------------------------------------------------------

-------------------------------------------------------------------------------------------------



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
values ('1000000','nate','1234','nathaniel','angelico','tabanao','09395686461','Where Do you live?','Cave','110','1'),
('1000001','jamie','1234','jamie','hanna','dionson','09222729916','test','test','110','1')

-- STUDENTS
INSERT INTO TBLSTUDENTDETAILS
VALUES	('NTABANAO','1234','NATHANIEL ANGELICO TABANAO'),
		('JHDIONSON','1234','JAMIE HANNA DIONSON'),
		('JBGEONSON','1234','JOHN BROWN GEONSON'),
		('NTfdABANAO','1234','ALLY')

-- EQUIPMENT TYPE
INSERT INTO TBLEQEUIPMENTTYPE
VALUES	(200,'GENERAL EQUIPMENT'),
		(201,'Computer Equipment'),
		(202,'Culinary Equipment'),
		(203,'Automotive Equipment'),
		(204,'Electronic Equipent'),
		(205,'Machineries')

-- EQUIPMENT TABLE
INSERT INTO TBLEQUIPMENTDETAILS
VALUES	('2000000','Test Equipment 1','Test Description 1',200,3,1),
		('2000001','Test Equipment 2','Test Description 2',200,3,1),
		('2000002','Test Equipment 3','Test Description 3',200,3,1)

-- REQUEST STATUS
INSERT INTO REQUESTSTATUS
VALUES	('OPEN'),
		('PENDING'),
		('CLOSED')