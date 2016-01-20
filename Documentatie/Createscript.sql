-----------------------------------------------------------------------------------------------
-----------------------------DROPPING EXISTING TABLES AND CONSTRAINTS--------------------------
-----------------------------------------------------------------------------------------------

drop table diersoort cascade constraints;			--1
drop table dier cascade constraints;				--2
drop table soortwaarneming cascade constraints;		--3
drop table gebied cascade constraints;				--4
drop table project cascade constraints;				--5
drop table bezoek cascade constraints;				--6
drop table waarneming cascade constraints;			--7

-----------------------------------------------------------------------------------------------
----------------------------------CREATE NEW TABLES--------------------------------------------
-----------------------------------------------------------------------------------------------

create table diersoort
(
Id							number(10)		primary key,
Naam						varchar2(100)	
);

create table dier
(
Id							number(10)		primary key,
Diersoort_Id				number(10),
Naam						varchar2(100)	not null,
Afkorting					varchar2(100),
BroedStart					date,
BroedEind					date,
AantalPunten				number(1),
constraint FK_1_Diersoort_Id foreign key (Diersoort_Id) references diersoort (id) on delete cascade
);

create table soortwaarneming
(
Id							number(10)		primary key,
Naam						varchar2(100)	not null,
Afkorting					varchar2(100)
);

create table gebied
(
Id							number(10)		primary key,
Naam						varchar2(100)	not null
);

create table project
(
Id							number(10)		primary key,
Gebied_Id					number(10)		not null,
Naam						varchar2(100),
constraint FK_5_Gebied_Id foreign key (Gebied_Id) references gebied (id) on delete cascade
);

create table bezoek
(
Id							number(10)		primary key,
Project_Id					number(10),
Datum						date,
StartTijd					date,
EindTijd					date,
constraint FK_6_Project_Id foreign key (Project_Id) references project (id) on delete cascade
);

create table waarneming
(
Id							number(10)		primary key,
Bezoek_Id					number(10),
Dier_Id						number(10),
SoortWaarneming_Id			number(10),
Tijdstip					date,
Punten						number(1),
PositieX					number(10),
PositieY					number(10),
constraint FK_7_Bezoek_Id foreign key (Bezoek_Id) references bezoek (id) on delete cascade,
constraint FK_7_Dier_Id foreign key (Dier_Id) references dier (id) on delete cascade,
constraint FK_7_Soort_Id foreign key (SoortWaarneming_Id) references soortwaarneming (id) on delete cascade
);

-----------------------------------------------------------------------------------------------
----------------------------------------INSERT TESTDATA----------------------------------------
-----------------------------------------------------------------------------------------------
