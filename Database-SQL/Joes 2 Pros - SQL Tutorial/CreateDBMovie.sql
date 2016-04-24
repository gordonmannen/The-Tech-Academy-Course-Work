--------------Save Script as
--------------C:\....\CreateDBMovie.sql

USE master
GO

IF EXISTS (SELECT * FROM sys.databases WHERE [name] = 'dbMovie')
DROP DATABASE dbMovie
GO

CREATE DATABASE dbMovie
GO

USE dbMovie
GO

CREATE TABLE tblMovie
(
m_id int PRIMARY KEY,
m_title varchar (30) NOT NULL,
m_runtime int NULL,
m_Rating varchar (10) NULL
)

INSERT INTO tblMovie
VALUES (1, 'A-List Explorers', 96, 'PG-13'),
(2, 'Bonker Bonzo', 75, 'PG-13'),
(3, 'Chumps to Champs', 75, 'PG-13'),
(4, 'Dare the World to Try', 110, 'R'),
(5, 'Eeee-Ghads', 88, 'G')