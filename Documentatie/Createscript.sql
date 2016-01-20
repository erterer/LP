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
Diersoort_Id				number(10)		not null,
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
--------------------------------------------SEQUENCES------------------------------------------
-----------------------------------------------------------------------------------------------

DROP SEQUENCE SEQ_WAARNEMING_ID;
DROP SEQUENCE SEQ_DIERSOORT_ID; 
DROP SEQUENCE SEQ_DIER_ID; 
DROP SEQUENCE SEQ_SOORTWAARNEMING_ID; 
DROP SEQUENCE SEQ_BEZOEK_ID; 
DROP SEQUENCE SEQ_PROJECT_ID; 
DROP SEQUENCE SEQ_GEBIED_ID;

CREATE SEQUENCE SEQ_WAARNEMING_ID START WITH 1 INCREMENT BY 1 NOMAXVALUE;
CREATE SEQUENCE SEQ_DIERSOORT_ID START WITH 1 INCREMENT BY 1 NOMAXVALUE;
CREATE SEQUENCE SEQ_DIER_ID START WITH 1 INCREMENT BY 1 NOMAXVALUE;
CREATE SEQUENCE SEQ_SOORTWAARNEMING_ID START WITH 1 INCREMENT BY 1 NOMAXVALUE;
CREATE SEQUENCE SEQ_BEZOEK_ID START WITH 1 INCREMENT BY 1 NOMAXVALUE;
CREATE SEQUENCE SEQ_PROJECT_ID START WITH 1 INCREMENT BY 1 NOMAXVALUE;
CREATE SEQUENCE SEQ_GEBIED_ID START WITH 1 INCREMENT BY 1 NOMAXVALUE;

CREATE OR REPLACE TRIGGER t_Waarneming
BEFORE INSERT ON waarneming
for each row
begin
select SEQ_WAARNEMING_ID.nextval into :new.ID from dual;
end;
/

CREATE OR REPLACE TRIGGER t_Diersoort
BEFORE INSERT ON diersoort
for each row
begin
select SEQ_DIERSOORT_ID.nextval into :new.ID from dual;
end;
/

CREATE OR REPLACE TRIGGER t_Dier
BEFORE INSERT ON dier
for each row
begin
select SEQ_DIER_ID.nextval into :new.ID from dual;
end;
/

CREATE OR REPLACE TRIGGER t_SoortWaarneming
BEFORE INSERT ON soortwaarneming
for each row
begin
select SEQ_SOORTWAARNEMING_ID.nextval into :new.ID from dual;
end;
/

CREATE OR REPLACE TRIGGER t_Bezoek
BEFORE INSERT ON bezoek
for each row
begin
select SEQ_BEZOEK_ID.nextval into :new.ID from dual;
end;
/

CREATE OR REPLACE TRIGGER t_Project
BEFORE INSERT ON project
for each row
begin
select SEQ_PROJECT_ID.nextval into :new.ID from dual;
end;
/

CREATE OR REPLACE TRIGGER t_Gebied
BEFORE INSERT ON gebied
for each row
begin
select SEQ_GEBIED_ID.nextval into :new.ID from dual;
end;
/

-----------------------------------------------------------------------------------------------
----------------------------------------INSERT TESTDATA----------------------------------------
-----------------------------------------------------------------------------------------------

--Diersoort
INSERT INTO DIERSOORT(Naam)
VALUES ('Vogel');
INSERT INTO DIERSOORT(Naam)
VALUES ('Vlinder');
INSERT INTO DIERSOORT(Naam)
VALUES ('Insect');

--Dier
INSERT INTO DIER(Diersoort_Id, Naam, Afkorting, BroedStart, BroedEind, AantalPunten)
VALUES (1, 'Appelvink', 'AV', TO_DATE('15-3','DD-MM'),TO_DATE('20-6','DD-MM'),'3');
INSERT INTO DIER(Diersoort_Id, Naam, Afkorting, BroedStart, BroedEind, AantalPunten)
VALUES (1, 'Blauwe Reiger','BLR', TO_DATE('15-4','DD-MM'),TO_DATE('10-5','DD-MM'),'5');
INSERT INTO DIER(Diersoort_Id, Naam, Afkorting, BroedStart, BroedEind, AantalPunten)
VALUES (1, 'Boomklever', 'BKL', TO_DATE('15-2','DD-MM'),TO_DATE('31-5','DD-MM'),'5');
INSERT INTO DIER(Diersoort_Id, Naam, Afkorting, BroedStart, BroedEind, AantalPunten)
VALUES (1, 'Bosrietzanger','B',TO_DATE('15-5','DD-MM') ,TO_DATE('20-7','DD-MM'),'5');
INSERT INTO DIER(Diersoort_Id, Naam, Afkorting, BroedStart, BroedEind, AantalPunten)
VALUES (1, 'Braamsluiper','BS',TO_DATE('1-5','DD-MM'),TO_DATE('30-6','DD-MM'),'5');
INSERT INTO DIER(Diersoort_Id, Naam, Afkorting, BroedStart, BroedEind, AantalPunten)
VALUES (1, 'Buizerd','Bui',TO_DATE('1-3','DD-MM'),TO_DATE('10-7','DD-MM'),'4');
INSERT INTO DIER(Diersoort_Id, Naam, Afkorting, BroedStart, BroedEind, AantalPunten)
VALUES (1, 'Fitis','F',TO_DATE('20-4','DD-MM'),TO_DATE('10-7','DD-MM'),'5');
INSERT INTO DIER(Diersoort_Id, Naam, Afkorting, BroedStart, BroedEind, AantalPunten)
VALUES (1, 'Geelgors','GG',TO_DATE('1-4','DD-MM'),TO_DATE('20-7','DD-MM'),'5');
INSERT INTO DIER(Diersoort_Id, Naam, Afkorting, BroedStart, BroedEind, AantalPunten)
VALUES (1, 'Grutto','Gr',TO_DATE('10-4','DD-MM'),TO_DATE('10-5','DD-MM'),'5');
INSERT INTO DIER(Diersoort_Id, Naam, Afkorting, BroedStart, BroedEind, AantalPunten)
VALUES (1, 'Houtsnip','HS',TO_DATE('15-3','DD-MM'),TO_DATE('20-7','DD-MM'),'2');
INSERT INTO DIER(Diersoort_Id, Naam, Afkorting, BroedStart, BroedEind, AantalPunten)
VALUES (1, 'IJsvogel','IJs',TO_DATE('1-4','DD-MM'),TO_DATE('15-5','DD-MM'),'3');
INSERT INTO DIER(Diersoort_Id, Naam, Afkorting, BroedStart, BroedEind, AantalPunten)
VALUES (1, 'Koekoek','Koe',TO_DATE('15-5','DD-MM'),TO_DATE('30-6','DD-MM'),'5');
INSERT INTO DIER(Diersoort_Id, Naam, Afkorting, BroedStart, BroedEind, AantalPunten)
VALUES (1, 'Koolmees','K',TO_DATE('15-3','DD-MM'),TO_DATE('30-6','DD-MM'),'5');
INSERT INTO DIER(Diersoort_Id, Naam, Afkorting, BroedStart, BroedEind, AantalPunten)
VALUES (1, 'Merel','M',TO_DATE('1-3','DD-MM'),TO_DATE('15-7','DD-MM'),'5');
INSERT INTO DIER(Diersoort_Id, Naam, Afkorting, BroedStart, BroedEind, AantalPunten)
VALUES (1, 'Pimpelmees','P',TO_DATE('15-3','DD-MM'),TO_DATE('30-6','DD-MM'),'5');
INSERT INTO DIER(Diersoort_Id, Naam, Afkorting, BroedStart, BroedEind, AantalPunten)
VALUES (1, 'Roodborst','R',TO_DATE('1-5','DD-MM'),TO_DATE('30-6','DD-MM'),'5');
INSERT INTO DIER(Diersoort_Id, Naam, Afkorting, BroedStart, BroedEind, AantalPunten)
VALUES (1, 'Tjiftjaf','Tj',TO_DATE('15-4','DD-MM'),TO_DATE('20-7','DD-MM'),'6');
INSERT INTO DIER(Diersoort_Id, Naam, Afkorting, BroedStart, BroedEind, AantalPunten)
VALUES (1, 'Torenvalk','TV',TO_DATE('1-3','DD-MM'),TO_DATE('10-7','DD-MM'),'5');
INSERT INTO DIER(Diersoort_Id, Naam, Afkorting, BroedStart, BroedEind, AantalPunten)
VALUES (1, 'Tuinfluiter','T',TO_DATE('1-5','DD-MM'),TO_DATE('20-7','DD-MM'),'5');
INSERT INTO DIER(Diersoort_Id, Naam, Afkorting, BroedStart, BroedEind, AantalPunten)
VALUES (1, 'Vink','V',TO_DATE('20-4','DD-MM'),TO_DATE('20-7','DD-MM'),'5');
INSERT INTO DIER(Diersoort_Id, Naam, Afkorting, BroedStart, BroedEind, AantalPunten)
VALUES (1, 'Winterkoning','W',TO_DATE('1-3','DD-MM'),TO_DATE('15-6','DD-MM'),'6');
INSERT INTO DIER(Diersoort_Id, Naam, Afkorting, BroedStart, BroedEind, AantalPunten)
VALUES (1, 'Zwartkop','ZK',TO_DATE('20-4','DD-MM'),TO_DATE('20-7','DD-MM'),'5');

--SoortWaarneming
INSERT INTO SOORTWAARNEMING(Naam, Afkorting)
VALUES ('Vogel aanwezig', 'VA');
INSERT INTO SOORTWAARNEMING(Naam, Afkorting)
VALUES ('Territorium indicerend', 'TI');
INSERT INTO SOORTWAARNEMING(Naam, Afkorting)
VALUES ('Nest indicerend', 'NI');

--Gebied
INSERT INTO GEBIED(Naam)
VALUES ('Veluwe');
INSERT INTO GEBIED(Naam)
VALUES ('Strabrechtse Heide');

--Project
INSERT INTO PROJECT(Gebied_Id, Naam)
VALUES (1, 'Sven Nottelman');


commit;