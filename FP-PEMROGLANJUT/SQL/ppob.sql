CREATE DATABASE ppob

USE ppob

-- Table akun
CREATE TABLE akun
(
usrname varchar(32) NOT NULL PRIMARY KEY,
passwd varchar(32) NOT NULL,
nama_depan varchar(32),
nama_belakang varchar(32),
email varchar(64),
no_telp int
);

INSERT INTO akun (usrname, passwd)
VALUES ('admin', 'notadmin');

SELECT * FROM akun;