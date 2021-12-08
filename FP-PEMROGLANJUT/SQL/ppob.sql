CREATE DATABASE ppob

GO

USE ppob

GO

-- Table akun
CREATE TABLE akun (usrname varchar(32) NOT NULL PRIMARY KEY, email varchar(64) NOT NULL, passwd varchar(32) NOT NULL);