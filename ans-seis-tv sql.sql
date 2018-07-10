--create database
CREATE DATABASE ANS_SEIS_TV
USE ANS_SEIS_TV

--drop the database in case something happens
USE MASTER
DROP DATABASE ANS_SEIS_TV
-------------------------------------------------

DROP TABLE TBLUSERDETAILS

SELECT * FROM TBLUSERDETAILS

truncate table tbluserdetails

delete tbluserdetails

--for tables of user
CREATE TABLE TBLUSERDETAILS
(
	GENID INT UNIQUE IDENTITY(10000000,1),
	ID VARCHAR(50) PRIMARY KEY,
	USERNAME VARCHAR(50),
	PASSWORD VARCHAR(MAX),
	FIRSTNAME VARCHAR(150),
	MIDDLENAME VARCHAR(50),
	LASTNAME VARCHAR(100),
	ADDRESS VARCHAR(MAX),
	BIRTHDATE DATE,
	EMAILADDRESS VARCHAR(150),
	SECURITY_QUESTION VARCHAR(MAX),
	SECURITY_ANSWER VARCHAR(MAX),
	USERTYPE_ID INT FOREIGN KEY references USERTYPE(USERTYPE_ID)
)

--SAMPLE INTRO
insert into TBLUSERDETAILS
values ('10000001','nathan','1234','nathaniel','angelico','tabanao','test','7-23-98','test','test','test','110')

--User ID Generation
create procedure sp_UserID
as
declare @GENID int
select  @GENID = IDENT_CURRENT('TBLUSERDETAILS')
return @GENID

--Return UserID
create proc sp_UserReturnID
(
	@username varchar(50),
	@userID int
)
as
select USERTYPE_ID from TBLUSERDETAILS
where USERNAME=@username
return @userid

-- Insert User
CREATE PROCEDURE sp_UserInsert
(
	@GENID INT,
	@ID VARCHAR(50),
	@USERNAME VARCHAR(50),
	@PASSWORD VARCHAR(MAX),
	@FIRSTNAME VARCHAR(150),
	@MIDDLENAME VARCHAR(50),
	@LASTNAME VARCHAR(100),
	@ADDRESS VARCHAR(MAX),
	@BIRTHDATE DATE,
	@EMAILADDRESS VARCHAR(150),
	@SECURITY_QUESTION VARCHAR(MAX),
	@SECURITY_ANSWER VARCHAR(MAX),
	@USERTYPE_ID INT
)
AS
INSERT INTO TBLUSERDETAILS
VALUES(@ID,@USERNAME,@PASSWORD,@FIRSTNAME,@MIDDLENAME,@LASTNAME,@ADDRESS,@BIRTHDATE,@EMAILADDRESS,@SECURITY_QUESTION,@SECURITY_ANSWER,@USERTYPE_ID)

-- Edit User

CREATE PROCEDURE sp_UserEdit
(
	@ID VARCHAR(50),
	@USERNAME VARCHAR(50),
	@PASSWORD VARCHAR(MAX),
	@FIRSTNAME VARCHAR(150),
	@MIDDLENAME VARCHAR(50),
	@LASTNAME VARCHAR(100),
	@ADDRESS VARCHAR(MAX),
	@BIRTHDATE DATE,
	@EMAILADDRESS VARCHAR(150),
	@SECURITY_QUESTION VARCHAR(MAX),
	@SECURITY_ANSWER VARCHAR(MAX)
)
AS
UPDATE TBLUSERDETAILS
SET USERNAME = @USERNAME,PASSWORD =@PASSWORD,FIRSTNAME = @FIRSTNAME,MIDDLENAME =@MIDDLENAME,LASTNAME =@LASTNAME,ADDRESS = @ADDRESS,BIRTHDATE =@BIRTHDATE,EMAILADDRESS = @EMAILADDRESS,SECURITY_QUESTION =@SECURITY_QUESTION,SECURITY_ANSWER =@SECURITY_ANSWER
WHERE ID=@ID
	
-- Delete User
CREATE PROCEDURE sp_UserDelete
(
 @ID varchar(50)
)
as 
DELETE FROM TBLUSERDETAILS
WHERE TBLUSERDETAILS.ID=@ID


-- Search User
CREATE PROC sp_UserSearch
(
	@SearchKey VARCHAR(50)
)
AS
SELECT genid as "General ID", id as "ID",username as "Username",firstname as "First Name",middlename as "Middle Name",lastname as "Last Name",address as "Address",birthdate as "Birthdate",emailaddress as "Email Address",usertype_ID as "Usertype ID" FROM TBLUSERDETAILS
where genid like '%'+@SearchKey+'%' or id like '%'+@SearchKey+'%' or firstname like '%'+@SearchKey+'%' or middlename like '%'+@SearchKey+'%' or lastname like '%'+@SearchKey+'%'


-- User Login
CREATE PROCEDURE sp_UserLogin
(
	@USERNAME VARCHAR(50),
	@PASSWORD VARCHAR(MAX)
)
as
SELECT TBLUSERDETAILS.USERNAME, TBLUSERDETAILS.PASSWORD FROM TBLUSERDETAILS
WHERE TBLUSERDETAILS.USERNAME=@USERNAME AND TBLUSERDETAILS.PASSWORD=@PASSWORD
RETURN 0


-- User Table View
CREATE PROC sp_UserView
as
SELECT genid as "General ID", id as "ID",username as "Username",firstname as "First Name",middlename as "Middle Name",lastname as "Last Name",address as "Address",birthdate as "Birthdate",emailaddress as "Email Address",usertype_ID as "Usertype ID" FROM TBLUSERDETAILS

------------------------------------------------------------------------------------------

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
VALUES	('ADMINISTRATOR');
	('TEACHER');
	('STUDENT');


------------------------------------------------------------------------------------------

SELECT * from TBLUSERLOGINREPORT

CREATE TABLE TBLUSERLOGINREPORT
(
	LoginID int identity(00000000,1) PRIMARY KEY,
	GENID INT foreign key references tbluserdetails(GENID),
	username varchar(50),
	password varchar(max),
	Action varchar(100),
	Timestamp datetime,
	USERTYPE_ID INT FOREIGN KEY references USERTYPE(USERTYPE_ID)
)

--Login Attempt
CREATE PROC sp_UserLoginReport
(
	@ID int,
	@username varchar(50),
	@password varchar(max),
	@Action varchar(100),
	@Timestamp datetime,
	@USERTYPE_ID INT
)
as
INSERT INTO TBLUSERLOGINREPORT
VALUES(@ID,@username,@password,@action,@timestamp,@USERTYPE_ID)


create proc sp_UserLoginReportView
(
	@SearchKey varchar(50)
)
as
select * from TBLUSERLOGINREPORT
where LoginID like '%'+@SearchKey+'%' or  username like '%'+@SearchKey+'%' or password like '%'+@SearchKey+'%' or action like '%'+@SearchKey+'%' or USERTYPE_ID like '%'+@SearchKey+'%'



-------------------------------------------------------------------------------------------

SELECT * FROM TBLEQUIPMENTDETAILS

DROP TABLE TBLEQUIPMENTDETAILS

CREATE TABLE TBLEQUIPMENTDETAILS
(
	EQUIPMENT_ID INT UNIQUE identity (20000000,1),
	EQBARCODE VARCHAR(100) Primary Key,
	EQUIPMENT_NAME VARCHAR(200),
	EQUIPMENT_TYPE_ID INT FOREIGN KEY REFERENCES TBLEQEUIPMENTTYPE(EQUIPMENT_TYPE_ID),
	EQUIPMENT_STATUS VARCHAR(50),
	IS_DESIGNATED VARCHAR(5)
)

-- Equipment Insert

CREATE PROC sp_EquipmentInsert
(
	@EQBARCODE VARCHAR(100),
	@EQUIPMENT_NAME VARCHAR(200),
	@EQUIPMENT_TYPE_ID INT,
	@EQUIPMENT_STATUS VARCHAR(50),
	@IS_DESIGNATED VARCHAR(5)
)
as
INSERT INTO TBLEQUIPMENTDETAILS
VALUES (@EQBARCODE, @EQUIPMENT_NAME, @EQUIPMENT_TYPE_ID, @EQUIPMENT_STATUS, @IS_DESIGNATED)


--Equipment Update
CREATE PROC sp_EquipmentUpdate
(
	@EQUIPMENT_ID INT,
	@EQUIPMENT_NAME VARCHAR(200),
	@EQUIPMENT_TYPE_ID INT,
	@EQUIPMENT_STATUS VARCHAR(50),
	@IS_DESIGNATED VARCHAR(5)
)
AS
UPDATE TBLEQUIPMENTDETAILS
SET EQUIPMENT_NAME=@EQUIPMENT_NAME,EQUIPMENT_TYPE_ID=@EQUIPMENT_TYPE_ID,EQUIPMENT_STATUS=@EQUIPMENT_STATUS,IS_DESIGNATED=@IS_DESIGNATED
WHERE EQUIPMENT_ID=@EQUIPMENT_ID

--Equipment Delete
CREATE PROC sp_EquipmentDelete
(
@EQBARCODE varchar(100)
)
AS
delete TBLEQUIPMENTDETAILS
WHERE EQBARCODE=@EQBARCODE

-- EQUIPMENT SEARCH
CREATE PROC sp_EquipmentSearch
(
@SearchKey varchar(100)
)
as
select EQBARCODE, EQUIPMENT_NAME, EQUIPMENT_TYPE_ID, EQUIPMENT_STATUS from TBLEQUIPMENTDETAILS
WHERE EQBARCODE like '%'+@SearchKey+'%' OR EQUIPMENT_NAME like '%'+@SearchKey+'%' OR EQUIPMENT_TYPE_ID like '%'+@SearchKey+'%'

-- EQUIPMENT VIEW
CREATE PROC sp_EquipmentView
as
select EQBARCODE, EQUIPMENT_NAME, EQUIPMENT_TYPE_ID, EQUIPMENT_STATUS from TBLEQUIPMENTDETAILS
----------------------------------------------------------------------------------------------------------------------


CREATE TABLE TBLEQEUIPMENTTYPE
(
 EQUIPMENT_TYPE_ID INT PRIMARY KEY,
 EQUIPMENT_TYPE_DESCRIPTION VARCHAR(100)
)

--------------------------------------------------------------------------------------------------------

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

drop table TBLUSERACTIONREPORT

CREATE TABLE TBLUSERACTIONREPORT
(
	ActionID int primary key identity(90000000,1),
	GENID INT foreign key references tbluserdetails(GENID),
	username varchar(50),
	Action varchar (50),
	Timestamp datetime
)


create proc sp_UserActionReport
(
	@ID int,
	@Username varchar(50),
	@Action varchar (50),
	@Timestamp datetime
)
as
insert into TBLUSERACTIONREPORT
VALUES (@id,@username,@Action,@Timestamp)

create proc sp_UserActionReportView
as
SELECT * FROM TBLUSERACTIONREPORT