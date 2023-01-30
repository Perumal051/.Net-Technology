create database inventoryManagementSystem;
use  inventoryManagementSystem;

create table ProductMaster
(
ProductId int primary key identity(1,1),
ProductName varchar(50),
AvailableQty bigint
);

create table Users
(
UserId int primary key identity(1,1),
UserName varchar(50),
Password varchar(25),
FullName varchar(255),
IsActive bit,
Category varchar(50)
);

create table [Transaction](
TransactionId int primary key identity(1,1),
TransactionDate date,
ProductId int,
TransactionType varchar(50),
Qty int,
UpdatedBy int
);
