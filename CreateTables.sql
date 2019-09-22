Use Studio2;

drop table Booking
drop table Member
drop table StaffClass
drop table MemberType
drop table Class
drop table Staff

create table MemberType
( 
	MembershipTypeID NVARCHAR(25) NOT NULL PRIMARY KEY,
	MembershipDescription NVARCHAR(50) NOT NULL,
	MembershipLength NVARCHAR(25) NOT NULL,
	MembershipPaymentType NVARCHAR(25) NOT NULL,
	MembershipAmount DEC(6,2) NOT NULL,

	CONSTRAINT ck_MembershipLength CHECK (MembershipLength = '6 Months' OR MembershipLength = '12 Months'),
	CONSTRAINT ck_MembershipPaymentType CHECK (MembershipPaymentType = 'Pay Monthly' OR MembershipPaymentType = 'Single Payment'),
);

create table Member
(
	MemberID int identity(100,1) NOT NULL PRIMARY KEY,
	MemberForename NVARCHAR(25) NOT NULL,
	MemberSurname NVARCHAR(25) NOT NULL,
	MemberDOB DATE NOT NULL, --Member must be 16 or older
	MemberGender NVARCHAR(1) NOT NULL, --Must be 'M' or 'F' 
	MemberStreet NVARCHAR(30),
	MemberTown NVARCHAR(20),
	MemberCounty NVARCHAR(20),
	MemberPostCode NVARCHAR(8) NOT NULL, --Must be in format BT35 2RH
	MemberPhoneNo NVARCHAR(11) NOT NULL, --Must be 11 numbers
	MemberEmail NVARCHAR(25),
	MembershipTypeID NVARCHAR(25) NOT NULL,
	MemberStartDate DATE NOT NULL,
	MemberExpiryDate DATE NOT NULL,

	CONSTRAINT Fk_MembershipTypeID FOREIGN KEY (MembershipTypeID) REFERENCES MemberType (MembershipTypeID),
	CONSTRAINT Ck_MemberDOB CHECK(MemberDOB <= (GetDate() - 365*16)), 
	CONSTRAINT Ck_MemberGender CHECK (MemberGender = 'M' OR MemberGender = 'F'),
	CONSTRAINT CK_MemberPostCode CHECK(LEN(MemberPostCode) = 8 OR LEN(MemberPostCode) = 7),
	CONSTRAINT Ck_MemberPhoneNo CHECK(LEN(MemberPhoneNo) = 11),

	CONSTRAINT Ck_MemberStartDate CHECK(MemberStartDate >= CAST(GETDATE() AS DATE))
);
create table Class
( 
	ClassID NVARCHAR(7) NOT NULL PRIMARY KEY,
	ClassName NVARCHAR(25) NOT NULL,
	ClassTime TIME NOT NULL, 
	ClassDay NVARCHAR(10) NOT NULL, --must be monday to sunday
	ClassLevel NVARCHAR(25) NOT NULL, --must be beginner, itermediate or advanced

	CONSTRAINT Ck_ClassDay CHECK (ClassDay = 'Monday' OR ClassDay = 'Tuesday' OR ClassDay = 'Wednesday' OR ClassDay = 'Thursday' OR 
	ClassDay = 'Friday' OR ClassDay = 'Saturday'),
	CONSTRAINT Ck_ClassLevel CHECK (ClassLevel = 'Beginner' OR ClassLevel = 'Intermediate' OR ClassLevel = 'Advanced')
);

CREATE TABLE Staff
(
	StaffID int identity(100, 1) NOT NULL PRIMARY KEY,
	StaffForename NVARCHAR(25) NOT NULL,
	StaffSurname NVARCHAR(25) NOT NULL,
	StaffDOB DATE NOT NULL, --must be no younger than 20
	StaffGender NVARCHAR(1) NOT NULL, -- must be 'M' or 'F'
	StaffStreet NVARCHAR(25),
	StaffTown NVARCHAR(25),
	StaffCounty NVARCHAR(25),
	StaffPostCode NVARCHAR(25) NOT NULL, --must be in same format as member
	StaffPhoneNo NVARCHAR(15) NOT NULL, --must be 11 number
	StaffEmail NVARCHAR(25),

	CONSTRAINT Ck_StaffDOB CHECK(StaffDOB <= (GetDate() - 365*20)),
	CONSTRAINT Ck_StaffGender CHECK (StaffGender = 'M' OR StaffGender = 'F'),
	CONSTRAINT CK_StaffPostCode CHECK(LEN(StaffPostCode) = 8 OR LEN(StaffPostCode) = 7),
	CONSTRAINT Ck_StaffPhoneNo CHECK(LEN(StaffPhoneNo) = 11)
);

CREATE TABLE StaffClass
( 
	ClassID NVARCHAR(7) NOT NULL,
	StaffID int NOT NULL,
	StaffClassRole NVARCHAR(25), --must be eg supporting
	PRIMARY KEY(ClassID, StaffID),

	CONSTRAINT Fk_ClassID FOREIGN KEY (ClassID) REFERENCES Class (ClassID),
	CONSTRAINT Fk_StaffID FOREIGN KEY (StaffID) REFERENCES Staff (StaffID),
	CONSTRAINT ck_StaffClassRole CHECK(StaffClassRole = 'Supporting' OR StaffClassRole = 'Main')
	);

CREATE TABLE Booking
( 
	BookingID int identity(100,1) NOT NULL, 
	MemberID INT NOT NULL,
	ClassDate DATE NOT NULL, --Cannot be before todays date
	BookingDate DATE NOT NULL, --Cannot be before todays date
	ClassID NVARCHAR(7) NOT NULL,
	PRIMARY KEY(BookingID, MemberID),

	CONSTRAINT Fk_MemberID FOREIGN KEY (MemberID) REFERENCES Member (MemberID),
	CONSTRAINT Ck_ClassDate CHECK(ClassDate >= (GetDate())),
	CONSTRAINT Ck_BookingDate CHECK(BookingDate >= (GetDate())),
	CONSTRAINT Fk_BClassID FOREIGN KEY(ClassID) REFERENCES Class (ClassID),
);

INSERT INTO MemberType VALUES ('IND6M', 'Individual Membership', '6 Months', 'Pay Monthly', 192.00);
INSERT INTO Member VALUES ('Anna', 'Smith', '1992-08-23', 'F', '35 Hill Street', 'Belfast', 'Antrim', 'BT1 2LA', '07912667381', 'asmith@gmail.com', 'IND6M', GETDATE(), (GETDATE() + 183));
INSERT INTO Staff VALUES ('Mark', 'Sheerin', '1980-04-13', 'M', '13 Ashley Park', 'Dunmurry', 'Antrim', 'BT17 9EH', '07530564719', 'Mark_Sheerin@hotmail.com');
INSERT INTO Staff VALUES ('Leona', 'Woods', '1990-08-02', 'F', '27 Ramore Park', 'Belfast', 'Antrim', 'BT10 0FB', '07743529803', 'LeeWoods@gmail.com');
INSERT INTO Class VALUES ('JUDBTUE', 'Judo', '18:00:00', 'Tuesday', 'Beginner');
INSERT INTO StaffClass VALUES ('JUDBTUE', '100', 'Main');
INSERT INTO StaffClass VALUES ('JUDBTUE', '101', 'Supporting');
INSERT INTO Booking VALUES ('100', '2016-07-25', GETDATE(), 'JUDBTUE');
