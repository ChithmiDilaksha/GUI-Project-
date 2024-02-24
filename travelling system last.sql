CREATE DATABASE Travelling_Agency_System;

CREATE TABLE Customers
(
    NIC VARCHAR(100) NOT NULL Primary key,
    FullName VARCHAR(100) NOT NULL,
    Email VARCHAR(200) NOT NULL,
    Passwords VARCHAR(50) NOT NULL
);

CREATE TABLE Local_Customer_Details
	(
		LcName varchar(35) not null primary key,
		NIC varchar(15) not null,
		LcAddress varchar(150) not null,
		LcPhone varchar(10) not null,
		Age int CHECK (Age >= 0),
		LcMemberShip varchar not null,
		Province varchar not null
   );

   CREATE TABLE Foreign_Custome_Details
   (
		FcName varchar(35) not null primary key,
		Passport_Number varchar(20) not null,
		Nationality varchar(10) not null,
		Visa_Details varchar(100) not null,
		Phone_Number int not null,
		Age int CHECK (Age >= 0),
		FcMembership varchar not null
   );


CREATE TABLE Hotel
(
    HotelNo INT PRIMARY KEY,
    HotelName VARCHAR(100),
    Location VARCHAR(100),
    PriceRange VARCHAR(100),
    Members INT,
    Days INT,
    RoomType VARCHAR(100),
    BedType VARCHAR(100),
    Rooms INT,
    Nic VARCHAR(20),
    LocalName VARCHAR(100),
    ForeignName VARCHAR(100),
    PassportNumber VARCHAR(100),
    LcName VARCHAR(35)Foreign key references Local_Customer_Details(LcName),
	FcName varchar(35)Foreign key references Foreign_Custome_Details(FcName)
);



CREATE TABLE Vehical 
(
    VehicalID VARCHAR(10) NOT NULL primary key,
    VFullName VARCHAR(55) NOT NULL,
    VVehicleType VARCHAR(50) NOT NULL,
    VBrand VARCHAR(50) NOT NULL,
    VPhoneNumber VARCHAR(15) NOT NULL,
    VCustomerType VARCHAR(50) NOT NULL,
    VMembers INT NOT NULL,
    VMembership VARCHAR(300),
    VDriver VARCHAR(50) NOT NULL,
    VHowManyDays INT NOT NULL,
   LocalName VARCHAR(100),
   ForeignName VARCHAR(100),
   NIC VARCHAR(50),
   PassportNumber VARCHAR(100),
   LcName VARCHAR(35)Foreign key references Local_Customer_Details(LcName),
   FcName varchar(35) foreign key references Foreign_Custome_Details(FcName)

);

CREATE TABLE Agent
(

AgentName VARCHAR(100) NOT NULL,
Gender VARCHAR(100) NOT NULL,
Members int,
NoDays int,
City VARCHAR(100) NOT NULL,
LcName VARCHAR(35)Foreign key references Local_Customer_Details(LcName),
FcName VARCHAR(35)Foreign key references Foreign_Custome_Details(FcName)


);

CREATE TABLE Food (
FoodNum VARCHAR(100) NOT NULL Primary Key,
FooodName VARCHAR(100) NOT NULL,
Phonenum int NOT NULL,
Members int,
Meals VARCHAR(100) NOT NULL,
NoDays int,
LcName VARCHAR(35)Foreign key references Local_Customer_Details(LcName),
FcName VARCHAR(35)Foreign key references Foreign_Custome_Details(FcName)
);

CREATE TABLE Tour (
Name VARCHAR(100) NOT NULL Primary Key,
Phonenum int NOT NULL,
Email VARCHAR(100) NOT NULL,
Custype VARCHAR(100) NOT NULL,
TourName VARCHAR(100) NOT NULL,
Members int,
NoDays int,
Destination VARCHAR(200) NOT NULL,
about VARCHAR(200) NOT NULL,
 Passwords VARCHAR(50) NOT NULL,
LcName VARCHAR(35)Foreign key references Local_Customer_Details(LcName),
FcName VARCHAR(35)Foreign key references Foreign_Custome_Details(FcName)
);