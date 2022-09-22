/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [Id]
      ,[AccountType]
      ,[AccountBalance]
  FROM [BankingDB].[dbo].[Accounts]



insert into Accounts (AccountType, AccountBalance)
values ('Checking', '0.00')
insert into Accounts (AccountType, AccountBalance)
values ('Savings', '0.00')