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