--create database
CREATE DATABASE ANS_SEIS_TV
USE ANS_SEIS_TV

--drop the database in case something happens
USE MASTER
DROP DATABASE ANS_SEIS_TV
---------------------------------------------------------------------------------

---------------------------------------------------------------------------------
---------------------------------------------------------------------------------

--THIS ARE OF THE SQL CODE IS FOR USERS ONLY

---------------------------------------------------------------------------------
---------------------------------------------------------------------------------


--MAIN USER TABLES

---------------------------------------------------------------------------------

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


-- Sample Data for TBLUSERDETAILS
insert into TBLUSERDETAILS
values ('1000000','nate','1234','nathaniel','angelico','tabanao','09395686461','Where Do you live?','Cave','110','1'),
('1000001','jamie','1234','jamie','hanna','dionson','09222729916','test','test','110','1')

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

--CREATE PROCEDURE sp_UserFirstLogin
--(
--@GENID INT,
--@USERNAME VARCHAR(50),
--@PASSWORD VARCHAR(MAX),
--@SECURITY_QUESTION VARCHAR(MAX),
--@SECURITY_ANSWER VARCHAR(MAX)
--)
--AS
--UPDATE TBLUSERDETAILS
--SET USERNAME=@USERNAME, PASSWORD=@PASSWORD,SECURITY_QUESTION=@SECURITY_QUESTION,SECURITY_ANSWER=@SECURITY_ANSWER
--WHERE GENID=@GENID

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

---------------------------------------------------------------------------------

---------------------------------------------------------------------------------

-- THINGS REGARDING ABOUT USERS STARTS HERE

---------------------------------------------------------------------------------

---------------------------------------------------------------------------------

--STUDENTS MAIN TABLE
SELECT * FROM STUDENTS

DROP TABLE STUDENTS


CREATE TABLE STUDENTS
(
	GENID INT UNIQUE IDENTITY (3000000,1),
	USERNAME VARCHAR(50) PRIMARY KEY,
	PASSWORD VARCHAR(MAX),
	NAME VARCHAR(200)
)

CREATE PROC sp_StudentInsert
(
@USERNAME VARCHAR(50),
@PASSWORD VARCHAR(MAX),
@NAME VARCHAR(200)
)
as
INSERT INTO STUDENTS
VALUES(@USERNAME,@PASSWORD,@NAME)

INSERT INTO STUDENTS
VALUES ('NTABANAO','1234','NATHANIEL ANGELICO TABANAO'),
		('JHDIONSON','1234','JAMIE HANNA DIONSON'),
		('JBGEONSON','1234','JOHN BROWN GEONSON'),
		('NTfdABANAO','1234','ALLY')


CREATE PROC sp_StudentSearch
(
@SearchKey VARCHAR(50)
)
as
SELECT GENID,USERNAME,NAME FROM STUDENTS
WHERE GENID like '%'+@SearchKey+'%' OR USERNAME like '%'+@SearchKey+'%' OR NAME like '%'+@SearchKey+'%'

CREATE PROC sp_StudentView
as
SELECT GENID,USERNAME,NAME FROM STUDENTS

---------------------------------------------------------------------------------

---------------------------------------------------------------------------------

-- THINGS REGARDING ABOUT STUDENTS ENDS HERE

---------------------------------------------------------------------------------

---------------------------------------------------------------------------------


DROP TABLE USERTYPE

SELECT * FROM USERTYPE

--for userype table
CREATE TABLE USERTYPE
(
USERTYPE_ID INT UNIQUE IDENTITY(110,1),
USERTYPE_DESCRIPTION VARCHAR(50)
)


--insert stuff
INSERT INTO USERTYPE
VALUES	('ADMINISTRATOR'),
	('TEACHER'),
	('STUDENT')

---------------------------------------------------------------------------------


--USER LOGS & REPORTING TABLES

---------------------------------------------------------------------------------

SELECT * FROM TBLUSERLOGINREPORT

CREATE TABLE TBLUSERLOGINREPORT
(
	LoginID int identity(00000000,1) PRIMARY KEY,
	GENID INT foreign key references tbluserdetails(GENID),
	password varchar(max),
	Action varchar(100),
	Timestamp datetime
)

CREATE PROC sp_UserLoginReport
(
	@GENID INT,
	@password varchar(max),
	@Action varchar(100),
	@Timestamp datetime
)
as
INSERT INTO TBLUSERLOGINREPORT
VALUES (@GENID,@password,@Action,@Timestamp)




---------------------------------------------------------------------------------
---------------------------------------------------------------------------------

--CREATE TABLE TBLUSERLOGINREPORT
--(
--	LoginID int identity(00000000,1) PRIMARY KEY,
--	GENID INT foreign key references tbluserdetails(GENID),
--	username varchar(50),
--	password varchar(max),
--	Action varchar(100),
--	Timestamp datetime,
--	USERTYPE_ID INT FOREIGN KEY references USERTYPE(USERTYPE_ID)
--)

----Login Attempt
--CREATE PROC sp_UserLoginReport
--(
--	@ID int,
--	@username varchar(50),
--	@password varchar(max),
--	@Action varchar(100),
--	@Timestamp datetime,
--	@USERTYPE_ID INT
--)
--as
--INSERT INTO TBLUSERLOGINREPORT
--VALUES(@ID,@username,@password,@action,@timestamp,@USERTYPE_ID)


--create proc sp_UserLoginReportView
--(
--	@SearchKey varchar(50)
--)
--as
--select * from TBLUSERLOGINREPORT
--where LoginID like '%'+@SearchKey+'%' or  username like '%'+@SearchKey+'%' or password like '%'+@SearchKey+'%' or action like '%'+@SearchKey+'%' or USERTYPE_ID like '%'+@SearchKey+'%'



---------------------------------------------------------------------------------

drop table TBLUSERACTIONREPORT

CREATE TABLE TBLUSERACTIONREPORT
(
	ActionID int primary key identity(90000000,1),
	GENID INT foreign key references tbluserdetails(GENID),
	Action varchar (50),
	Timestamp datetime
)


create proc sp_UserActionReport
(
	@ID int,
	@Action varchar (50),
	@Timestamp datetime
)
as
insert into TBLUSERACTIONREPORT
VALUES (@id,@Action,@Timestamp)

create proc sp_UserActionReportView
as
SELECT * FROM TBLUSERACTIONREPORT



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





--MAIN EQUIPMENT TABLES

---------------------------------------------------------------------------------



CREATE TABLE TBLEQEUIPMENTTYPE
(
 EQUIPMENT_TYPE_ID INT PRIMARY KEY,
 EQUIPMENT_TYPE_DESCRIPTION VARCHAR(100)
)

INSERT INTO TBLEQEUIPMENTTYPE
VALUES(200,'GENERAL EQUIPMENT'),
		(201,'Computer Equipment'),
(202,'Culinary Equipment'),
(203,'Automotive Equipment'),
(204,'Electronic Equipent'),
(205,'Machineries')

---------------------------------------------------------------------------------


CREATE TABLE EQUIPMENT_DESIGNATION
(
	EQ_DESIGNATION_ID INT PRIMARY KEY IDENTITY(800000,1),
	GENID INT foreign key references tbluserdetails(GENID),
	EQUIPMENT_ID INT FOREIGN KEY REFERENCES TBLEQUIPMENTDETAILS(EQUIPMENT_ID),
	DATE_DESIGNATED DATETIME,
	DATE_RETURNED DATETIME,
	DESIGNATION_STATUS VARCHAR(50)
)



---------------------------------------------------------------------------------


SELECT * FROM TBLEQUIPMENTDETAILS

TRUNCATE TABLE TBLEQUIPMENTDETAILS

DROP TABLE TBLEQUIPMENTDETAILS

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


INSERT INTO TBLEQUIPMENTDETAILS
VALUES ('2000000','Test Equipment 1','Test Description 1',200,3,1),
('2000001','Test Equipment 2','Test Description 2',200,3,1),
('2000002','Test Equipment 3','Test Description 3',200,3,1)


--User ID Generation
create procedure sp_EquipmentID
as
declare @GENID int
select  @GENID = IDENT_CURRENT('TBLEQUIPMENTDETAILS')
return @GENID


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

CREATE PROCEDURE sp_EquipmentQuantityEdit
(
 @EQUIPMENT_ID INT,
 @EQUIPMENT_QUANTITY INT
 )
 AS
 UPDATE TBLEQUIPMENTDETAILS
 SET EQUIPMENT_QUANTITY=@EQUIPMENT_QUANTITY
 WHERE EQUIPMENT_ID=@EQUIPMENT_ID
 

 CREATE PROCEDURE sp_EquipmentDelete
 (
	@EQUIPMENT_ID INT
)
as
DELETE TBLEQUIPMENTDETAILS
WHERE EQUIPMENT_ID=@EQUIPMENT_ID

CREATE PROC sp_EquipmentView
(
	@SearchKey varchar(50)
)
as
select equipment_id,EQUIPMENT_NAME,equipment_description,equipment_type_id,equipment_quantity from TBLEQUIPMENTDETAILS
where EQUIPMENT_ID  like '%'+@SearchKey+'%' or EQUIPMENT_NAME like '%'+@SearchKey+'%' or EQUIPMENT_DESCRIPTION  like '%'+@SearchKey+'%'
	
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

-------------------------------------------------------------------------------------------------

-------------------------------------------------------------------------------------------------
	
--	--scraped pa ni

--SELECT * FROM TBLEQUIPMENTDETAILS

--DROP TABLE TBLEQUIPMENTDETAILS

--CREATE TABLE TBLEQUIPMENTDETAILS
--(
--	EQUIPMENT_ID INT UNIQUE identity (2000000,1),
--	EQBARCODE VARCHAR(100) Primary Key,
--	EQUIPMENT_NAME VARCHAR(200),
--	EQUIPMENT_TYPE_ID INT FOREIGN KEY REFERENCES TBLEQEUIPMENTTYPE(EQUIPMENT_TYPE_ID),
--	EQUIPMENT_STATUS VARCHAR(50),
--	IS_DESIGNATED VARCHAR(5)
--)

---- Equipment Insert


--create procedure sp_EquipmentID
--as
--declare @GENID int
--select  @GENID = IDENT_CURRENT('TBLEQUIPMENTDETAILS')
--return @GENID


--CREATE PROC sp_EquipmentInsert
--(
--	@EQBARCODE VARCHAR(100),
--	@EQUIPMENT_NAME VARCHAR(200),
--	@EQUIPMENT_TYPE_ID INT,
--	@EQUIPMENT_STATUS VARCHAR(50),
--	@IS_DESIGNATED VARCHAR(5)
--)
--as
--INSERT INTO TBLEQUIPMENTDETAILS
--VALUES (@EQBARCODE, @EQUIPMENT_NAME, @EQUIPMENT_TYPE_ID, @EQUIPMENT_STATUS, @IS_DESIGNATED)


----Equipment Update
--CREATE PROC sp_EquipmentUpdate
--(
--	@EQUIPMENT_ID INT,
--	@EQUIPMENT_NAME VARCHAR(200),
--	@EQUIPMENT_TYPE_ID INT,
--	@EQUIPMENT_STATUS VARCHAR(50),
--	@IS_DESIGNATED VARCHAR(5)
--)
--AS
--UPDATE TBLEQUIPMENTDETAILS
--SET EQUIPMENT_NAME=@EQUIPMENT_NAME,EQUIPMENT_TYPE_ID=@EQUIPMENT_TYPE_ID,EQUIPMENT_STATUS=@EQUIPMENT_STATUS,IS_DESIGNATED=@IS_DESIGNATED
--WHERE EQUIPMENT_ID=@EQUIPMENT_ID

----Equipment Delete
--CREATE PROC sp_EquipmentDelete
--(
--@EQBARCODE varchar(100)
--)
--AS
--delete TBLEQUIPMENTDETAILS
--WHERE EQBARCODE=@EQBARCODE

---- EQUIPMENT SEARCH
--CREATE PROC sp_EquipmentSearch
--(
--@SearchKey varchar(100)
--)
--as
--select EQBARCODE, EQUIPMENT_NAME, EQUIPMENT_TYPE_ID, EQUIPMENT_STATUS from TBLEQUIPMENTDETAILS
--WHERE EQBARCODE like '%'+@SearchKey+'%' OR EQUIPMENT_NAME like '%'+@SearchKey+'%' OR EQUIPMENT_TYPE_ID like '%'+@SearchKey+'%'

---- EQUIPMENT VIEW
--CREATE PROC sp_EquipmentView
--as
--select EQBARCODE, EQUIPMENT_NAME, EQUIPMENT_TYPE_ID, EQUIPMENT_STATUS from TBLEQUIPMENTDETAILS
-------------------------------------------------------------------------------------------------


-------------------------------------------------------------------------------------------------

--EQUIPMENT LOGS TABLES	

-------------------------------------------------------------------------------------------------

-------------------------------------------------------------------------------------------------

-- THINGS ABOUT EQUIPMENTS ENDS HERE


-------------------------------------------------------------------------------------------------

-------------------------------------------------------------------------------------------------


-------------------------------------------------------------------------------------------------

-------------------------------------------------------------------------------------------------

-- THINGS ABOUT TRANSACTIONS START HERE


-------------------------------------------------------------------------------------------------

-------------------------------------------------------------------------------------------------


-- REQUEST TABLE

CREATE TABLE TBLREQUESTTABLE
(
REQUESTID  INT UNIQUE identity (4000000,1),
GENID INT foreign key references tbluserdetails(GENID),
REQUESTHEADER VARCHAR(100),
REQUESTCONTENT NVARCHAR(MAX),
DATEREQUESTED DATETIME,
REQUESTSTATUSID INT FOREIGN KEY REFERENCES REQUESTSTATUS(REQUESTSTATUSID),
ISOPENED INT
)

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



-------------------------------------------------------------------------------------------------

-------------------------------------------------------------------------------------------------


--REQUEST STATUS

CREATE TABLE REQUESTSTATUS
(
REQUESTSTATUSID INT  UNIQUE IDENTITY(300,1),
STATUSDESCRIPTION VARCHAR(15)
)

INSERT INTO REQUESTSTATUS
VALUES	('OPEN'),
		('PENDING'),
		('CLOSED')





-------------------------------------------------------------------------------------------------

-------------------------------------------------------------------------------------------------

-- THINGS ABOUT TRANSACTIONS END HERE


-------------------------------------------------------------------------------------------------

-------------------------------------------------------------------------------------------------





-------------------------------------------------------------------------------------------------

-------------------------------------------------------------------------------------------------

-- Scraped Code Goes Here

-------------------------------------------------------------------------------------------------

-------------------------------------------------------------------------------------------------


-- Scraped User Code



--DROP TABLE TBLUSERDETAILS

--SELECT * FROM TBLUSERDETAILS

--truncate table tbluserdetails

--delete tbluserdetails

----for tables of user
--CREATE TABLE TBLUSERDETAILS
--(
--	GENID INT UNIQUE IDENTITY(1000000,1),
--	ID VARCHAR(50) PRIMARY KEY,
--	USERNAME VARCHAR(50),
--	PASSWORD VARCHAR(MAX),
--	FIRSTNAME VARCHAR(150),
--	MIDDLENAME VARCHAR(50),
--	LASTNAME VARCHAR(100),
--	ADDRESS VARCHAR(MAX),
--	BIRTHDATE DATE,
--	EMAILADDRESS VARCHAR(150),
--	SECURITY_QUESTION VARCHAR(MAX),
--	SECURITY_ANSWER VARCHAR(MAX),
--	USERTYPE_ID INT FOREIGN KEY references USERTYPE(USERTYPE_ID),
--	ISFIRSTLOGIN INT
--)

----SAMPLE INTRO
--insert into TBLUSERDETAILS
--values ('1000000','nathan','1234','nathaniel','angelico','tabanao','test','7-23-98','test','test','test','110','1'),
--('1000001','test','1234','nathaniel','angelico','tabanao','test','7-23-98','test','test','test','110','1'),
--('1000002','nathan','1234','nathaniel','angelico','tabanao','test','7-23-98','test','test','test','110','1')

----User ID Generation
--create procedure sp_UserID
--as
--declare @GENID int
--select  @GENID = IDENT_CURRENT('TBLUSERDETAILS')
--return @GENID

----Return UserID
--create proc sp_UserReturnID
--(
--	@username varchar(50),
--	@userID int
--)
--as
--select USERTYPE_ID from TBLUSERDETAILS
--where USERNAME=@username and @userID=USERTYPE_ID
--return @userid

----return

---- Insert User
--CREATE PROCEDURE sp_UserInsert
--(
--	@GENID INT,
--	@ID VARCHAR(50),
--	@USERNAME VARCHAR(50),
--	@PASSWORD VARCHAR(MAX),
--	@FIRSTNAME VARCHAR(150),
--	@MIDDLENAME VARCHAR(50),
--	@LASTNAME VARCHAR(100),
--	@ADDRESS VARCHAR(MAX),
--	@BIRTHDATE DATE,
--	@EMAILADDRESS VARCHAR(150),
--	@SECURITY_QUESTION VARCHAR(MAX),
--	@SECURITY_ANSWER VARCHAR(MAX),
--	@USERTYPE_ID INT,
--	@ISFIRSTLOGIN INT
--)
--AS
--INSERT INTO TBLUSERDETAILS
--VALUES(@ID,@USERNAME,@PASSWORD,@FIRSTNAME,@MIDDLENAME,@LASTNAME,@ADDRESS,@BIRTHDATE,@EMAILADDRESS,@SECURITY_QUESTION,@SECURITY_ANSWER,@USERTYPE_ID,@ISFIRSTLOGIN)


----first login edit
--CREATE PROC sp_UserFirstLoginEdit
--(
--@GENID int,
--@ISFIRSTLOGIN INT
--)
--as
--update TBLUSERDETAILS
--set ISFIRSTLOGIN=@ISFIRSTLOGIN
--where GENID=@GENID

---- Edit User

--CREATE PROCEDURE sp_UserEdit
--(
--	@ID VARCHAR(50),
--	@USERNAME VARCHAR(50),
--	@PASSWORD VARCHAR(MAX),
--	@FIRSTNAME VARCHAR(150),
--	@MIDDLENAME VARCHAR(50),
--	@LASTNAME VARCHAR(100),
--	@ADDRESS VARCHAR(MAX),
--	@BIRTHDATE DATE,
--	@EMAILADDRESS VARCHAR(150),
--	@SECURITY_QUESTION VARCHAR(MAX),
--	@SECURITY_ANSWER VARCHAR(MAX)
--)
--AS
--UPDATE TBLUSERDETAILS
--SET USERNAME = @USERNAME,PASSWORD =@PASSWORD,FIRSTNAME = @FIRSTNAME,MIDDLENAME =@MIDDLENAME,LASTNAME =@LASTNAME,ADDRESS = @ADDRESS,BIRTHDATE =@BIRTHDATE,EMAILADDRESS = @EMAILADDRESS,SECURITY_QUESTION =@SECURITY_QUESTION,SECURITY_ANSWER =@SECURITY_ANSWER
--WHERE ID=@ID
	
---- Delete User
--CREATE PROCEDURE sp_UserDelete
--(
-- @ID varchar(50)
--)
--as 
--DELETE FROM TBLUSERDETAILS
--WHERE TBLUSERDETAILS.ID=@ID


---- Search User
--CREATE PROC sp_UserSearch
--(
--	@SearchKey VARCHAR(50)
--)
--AS
--SELECT genid as "General ID", id as "ID",username as "Username",firstname as "First Name",middlename as "Middle Name",lastname as "Last Name",address as "Address",birthdate as "Birthdate",emailaddress as "Email Address",usertype_ID as "Usertype ID" FROM TBLUSERDETAILS
--where genid like '%'+@SearchKey+'%' or id like '%'+@SearchKey+'%' or firstname like '%'+@SearchKey+'%' or middlename like '%'+@SearchKey+'%' or lastname like '%'+@SearchKey+'%'


---- User Login
--CREATE PROCEDURE sp_UserLogin
--(
--	@USERNAME VARCHAR(50),
--	@PASSWORD VARCHAR(MAX)
--)
--as
--SELECT TBLUSERDETAILS.USERNAME, TBLUSERDETAILS.PASSWORD FROM TBLUSERDETAILS
--WHERE TBLUSERDETAILS.USERNAME=@USERNAME AND TBLUSERDETAILS.PASSWORD=@PASSWORD
--RETURN 0


---- User Table View
--CREATE PROC sp_UserView
--as
--SELECT genid as "General ID", id as "ID",username as "Username",firstname as "First Name",middlename as "Middle Name",lastname as "Last Name",address as "Address",birthdate as "Birthdate",emailaddress as "Email Address",usertype_ID as "Usertype ID" FROM TBLUSERDETAILS
