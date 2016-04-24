USE master
GO

IF EXISTS (SELECT * FROM sys.databases WHERE [name] = 'dbCar')
DROP DATABASE dbCar
GO

CREATE DATABASE dbCar
GO

USE dbCar
GO

CREATE TABLE tblCar
(
c_id int PRIMARY KEY NOT NULL,
c_make varchar (25) NOT NULL,
c_model varchar (25) NOT NULL,
c_year int NULL
)