USE [master]
GO
/****** Object:  Database [Cyber_Secure_Db]    Script Date: 28-07-2025 16:42:46 ******/
CREATE DATABASE [Cyber_Secure_Db]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Cyber_Secure_Db', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\Cyber_Secure_Db.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Cyber_Secure_Db_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\Cyber_Secure_Db_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [Cyber_Secure_Db] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Cyber_Secure_Db].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Cyber_Secure_Db] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Cyber_Secure_Db] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Cyber_Secure_Db] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Cyber_Secure_Db] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Cyber_Secure_Db] SET ARITHABORT OFF 
GO
ALTER DATABASE [Cyber_Secure_Db] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Cyber_Secure_Db] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Cyber_Secure_Db] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Cyber_Secure_Db] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Cyber_Secure_Db] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Cyber_Secure_Db] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Cyber_Secure_Db] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Cyber_Secure_Db] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Cyber_Secure_Db] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Cyber_Secure_Db] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Cyber_Secure_Db] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Cyber_Secure_Db] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Cyber_Secure_Db] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Cyber_Secure_Db] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Cyber_Secure_Db] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Cyber_Secure_Db] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Cyber_Secure_Db] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Cyber_Secure_Db] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Cyber_Secure_Db] SET  MULTI_USER 
GO
ALTER DATABASE [Cyber_Secure_Db] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Cyber_Secure_Db] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Cyber_Secure_Db] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Cyber_Secure_Db] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Cyber_Secure_Db] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Cyber_Secure_Db] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Cyber_Secure_Db] SET QUERY_STORE = ON
GO
ALTER DATABASE [Cyber_Secure_Db] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [Cyber_Secure_Db]
GO
/****** Object:  Table [dbo].[Accounts]    Script Date: 28-07-2025 16:42:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Accounts](
	[AccountId] [int] IDENTITY(1,1) NOT NULL,
	[AccountName] [varchar](30) NULL,
	[ClientID] [int] NULL,
	[subscriptiondate] [date] NULL,
	[LastModifiedDate] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[AccountId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CyberSecurityIncidents]    Script Date: 28-07-2025 16:42:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CyberSecurityIncidents](
	[IncidentID] [int] IDENTITY(1,1) NOT NULL,
	[IncidentType] [varchar](20) NULL,
	[IncidentDesc] [varchar](100) NULL,
	[IncidentDate] [date] NULL,
	[Status] [char](1) NULL,
	[AccountID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[IncidentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[vw_Incidents]    Script Date: 28-07-2025 16:42:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create view [dbo].[vw_Incidents]
as
select incidentID, IncidentType,IncidentDesc,Incidentdate,Status,a.AccountName from CyberSecurityIncidents csi
inner join accounts a on a.AccountId = csi.accountid
GO
/****** Object:  Table [dbo].[Services]    Script Date: 28-07-2025 16:42:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Services](
	[ServiceID] [int] IDENTITY(1,1) NOT NULL,
	[ServiceName] [varchar](20) NULL,
	[ServiceDesc] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[ServiceID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Subscription]    Script Date: 28-07-2025 16:42:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Subscription](
	[SubscriptionID] [int] IDENTITY(1,1) NOT NULL,
	[ServiceID] [int] NULL,
	[AccountID] [int] NULL,
	[SubscriptionDate] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[SubscriptionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Billing]    Script Date: 28-07-2025 16:42:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Billing](
	[BillingID] [int] IDENTITY(1,1) NOT NULL,
	[Status] [char](1) NULL,
	[SubscriptionID] [int] NULL,
	[BillingDate] [date] NULL,
	[Amount] [decimal](6, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[BillingID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[vw_billing]    Script Date: 28-07-2025 16:42:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create view [dbo].[vw_billing]
as
select b.BillingID, a.accountName as "Account", s.ServiceName as 'Service', b.BillingDate, b.Amount, b.Status from billing b
inner join subscription sub on sub.SubscriptionID = b.SubscriptionID
inner join accounts a on a.AccountId = sub.AccountID
inner join Services s on s.ServiceID = sub.ServiceID
GO
/****** Object:  View [dbo].[vw_BillingSubName]    Script Date: 28-07-2025 16:42:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create view [dbo].[vw_BillingSubName]
as
select sub.subscriptionid, a.accountName + ' - ' + s.serviceName as 'SubscriptionName' from subscription sub
inner join accounts a on sub.accountid = a.AccountId
inner join Services s on s.ServiceID = sub.ServiceID
GO
/****** Object:  Table [dbo].[Clients]    Script Date: 28-07-2025 16:42:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clients](
	[ClientID] [int] IDENTITY(1,1) NOT NULL,
	[ClientName] [varchar](50) NULL,
	[ContactEmail] [varchar](100) NULL,
	[ContactPhone] [varchar](20) NULL,
	[HomeAddress] [varchar](150) NULL,
PRIMARY KEY CLUSTERED 
(
	[ClientID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[vw_accounts]    Script Date: 28-07-2025 16:42:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create view [dbo].[vw_accounts]
as
select a.accountid as "Account ID", a.AccountName as "Account Name", c.ClientName as "Client Name", a.subscriptiondate as "Account Creation Date", a.LastModifiedDate as "Last Modified Date" from  Accounts a
inner join clients c on c.clientID = a.clientid
GO
/****** Object:  View [dbo].[ve_clients]    Script Date: 28-07-2025 16:42:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[ve_clients]
as 
select Clientid as 'ID', ClientName 'Name', ContactEmail as 'Email', ContactPhone 'Phone', HomeAddress 'Address' from clients
GO
/****** Object:  View [dbo].[vw_clients]    Script Date: 28-07-2025 16:42:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[vw_clients]
as 
select Clientid as 'ID', ClientName 'Name', ContactEmail as 'Email', ContactPhone 'Phone', HomeAddress 'Address' from clients
GO
/****** Object:  View [dbo].[vw_ClientAccounts]    Script Date: 28-07-2025 16:42:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Creating view showing Clients and their Associated Accounts
-- This view helps users easily see accounts associated with the clients
-- This is usefull in windows form application when needed to show the clients and their associated accounts
Create view [dbo].[vw_ClientAccounts]
as
Select c.clientName 'Clients', a.accountname 'Accounts' from Accounts a 
inner join Clients c on c.ClientID = a.ClientID
GO
/****** Object:  View [dbo].[vw_accountServices]    Script Date: 28-07-2025 16:42:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--Creating view Showing accounts and their subuscribed services
-- This view helps users easily see the eservices that each account has subscribed to and their descriptions
-- This view is used in windows form application to show the account and services they have subscibed to
Create view [dbo].[vw_accountServices]
as
Select a.accountName 'Account' , s.serviceName 'Service', s.serviceDesc 'Description' from subscription sub
inner join Services s on sub.ServiceID = s.ServiceID
inner join Accounts a on sub.AccountID = a.AccountId
GO
/****** Object:  View [dbo].[vw_billingInfoForSubscription]    Script Date: 28-07-2025 16:42:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


--Creating a view showing billing info for all subscriptions
-- This view helps uses to easily see all the billing info including account name, service details, billing date , amount and status
-- This is useful in windows form application to show billing invoices and show billing history
Create view [dbo].[vw_billingInfoForSubscription]
as
select a.accountName 'Account', s.ServiceName 'Service' , s.serviceDesc 'Description', b.billingdate "Bill Date", b.amount 'Amount', b.status 'Status' from billing b
inner join Subscription sub on b.SubscriptionID = sub.SubscriptionID
inner join Accounts a on sub.AccountID = a.AccountId
inner join Services s on s.ServiceID = sub.ServiceID
GO
/****** Object:  View [dbo].[vw_incidentForAccounts]    Script Date: 28-07-2025 16:42:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--Creating a view displaying all cybersecurity incedents associated with an account
-- This view is useful for showing all the incidents info liked to accounts
-- this can be used in windows forms application to show the incident history and how cybersecure delivers value to their clients
Create view [dbo].[vw_incidentForAccounts]
as
Select a.accountname 'Account',	i.incidentType 'Type', i.incidentdesc 'Description', i.incidentDate 'Date', i.status 'Status' from CyberSecurityIncidents i
inner join Accounts a on a.AccountId = i.AccountID
GO
/****** Object:  View [dbo].[vw_Subscription]    Script Date: 28-07-2025 16:42:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create view [dbo].[vw_Subscription]
as
select sub.SubscriptionID, a.AccountName, s.ServiceName, sub.SubscriptionDate from subscription sub 
inner join accounts a on a.AccountId = sub.AccountID
inner join Services s on s.ServiceID = sub.ServiceID
GO
SET IDENTITY_INSERT [dbo].[Accounts] ON 
GO
INSERT [dbo].[Accounts] ([AccountId], [AccountName], [ClientID], [subscriptiondate], [LastModifiedDate]) VALUES (1, N'Google Main Account', 5, CAST(N'2025-03-10' AS Date), CAST(N'2025-04-18' AS Date))
GO
INSERT [dbo].[Accounts] ([AccountId], [AccountName], [ClientID], [subscriptiondate], [LastModifiedDate]) VALUES (2, N'Micro Soft Main Account', 4, CAST(N'2025-03-10' AS Date), CAST(N'2025-04-18' AS Date))
GO
INSERT [dbo].[Accounts] ([AccountId], [AccountName], [ClientID], [subscriptiondate], [LastModifiedDate]) VALUES (3, N'Serious Company Account update', 3, CAST(N'2025-04-10' AS Date), CAST(N'2025-04-18' AS Date))
GO
INSERT [dbo].[Accounts] ([AccountId], [AccountName], [ClientID], [subscriptiondate], [LastModifiedDate]) VALUES (4, N'Macro Hard Main Account', 2, CAST(N'2025-03-12' AS Date), CAST(N'2025-04-18' AS Date))
GO
INSERT [dbo].[Accounts] ([AccountId], [AccountName], [ClientID], [subscriptiondate], [LastModifiedDate]) VALUES (5, N'Tech Corp Main Account', 1, CAST(N'2025-03-05' AS Date), CAST(N'2025-04-18' AS Date))
GO
INSERT [dbo].[Accounts] ([AccountId], [AccountName], [ClientID], [subscriptiondate], [LastModifiedDate]) VALUES (6, N'google alt acc update', 5, CAST(N'2025-03-31' AS Date), CAST(N'2025-04-18' AS Date))
GO
INSERT [dbo].[Accounts] ([AccountId], [AccountName], [ClientID], [subscriptiondate], [LastModifiedDate]) VALUES (8, N'Security Account 1', 3, CAST(N'2025-05-27' AS Date), CAST(N'2025-05-28' AS Date))
GO
INSERT [dbo].[Accounts] ([AccountId], [AccountName], [ClientID], [subscriptiondate], [LastModifiedDate]) VALUES (10, N'Lesley Main Account', 15, CAST(N'2025-06-03' AS Date), CAST(N'2025-06-04' AS Date))
GO
SET IDENTITY_INSERT [dbo].[Accounts] OFF
GO
SET IDENTITY_INSERT [dbo].[Billing] ON 
GO
INSERT [dbo].[Billing] ([BillingID], [Status], [SubscriptionID], [BillingDate], [Amount]) VALUES (1, N'P', 1, CAST(N'2025-03-10' AS Date), CAST(500.00 AS Decimal(6, 2)))
GO
INSERT [dbo].[Billing] ([BillingID], [Status], [SubscriptionID], [BillingDate], [Amount]) VALUES (2, N'P', 4, CAST(N'2025-03-14' AS Date), CAST(499.00 AS Decimal(6, 2)))
GO
INSERT [dbo].[Billing] ([BillingID], [Status], [SubscriptionID], [BillingDate], [Amount]) VALUES (3, N'P', 6, CAST(N'2025-03-15' AS Date), CAST(899.99 AS Decimal(6, 2)))
GO
INSERT [dbo].[Billing] ([BillingID], [Status], [SubscriptionID], [BillingDate], [Amount]) VALUES (4, N'P', 2, CAST(N'2025-03-16' AS Date), CAST(400.00 AS Decimal(6, 2)))
GO
INSERT [dbo].[Billing] ([BillingID], [Status], [SubscriptionID], [BillingDate], [Amount]) VALUES (5, N'P', 3, CAST(N'2025-03-17' AS Date), CAST(899.99 AS Decimal(6, 2)))
GO
INSERT [dbo].[Billing] ([BillingID], [Status], [SubscriptionID], [BillingDate], [Amount]) VALUES (6, N'U', 5, CAST(N'2026-04-01' AS Date), CAST(999.99 AS Decimal(6, 2)))
GO
INSERT [dbo].[Billing] ([BillingID], [Status], [SubscriptionID], [BillingDate], [Amount]) VALUES (9, N'U', 1, CAST(N'2025-06-02' AS Date), CAST(56.00 AS Decimal(6, 2)))
GO
SET IDENTITY_INSERT [dbo].[Billing] OFF
GO
SET IDENTITY_INSERT [dbo].[Clients] ON 
GO
INSERT [dbo].[Clients] ([ClientID], [ClientName], [ContactEmail], [ContactPhone], [HomeAddress]) VALUES (1, N'Tech Corp', N'contact@techcorp.com', N'+126895551234', N'123 Tech Lane')
GO
INSERT [dbo].[Clients] ([ClientID], [ClientName], [ContactEmail], [ContactPhone], [HomeAddress]) VALUES (2, N'Macro Hard', N'contact@macrohard.com', N'+644201256969', N'102 innovation Drive')
GO
INSERT [dbo].[Clients] ([ClientID], [ClientName], [ContactEmail], [ContactPhone], [HomeAddress]) VALUES (3, N'Serious Company', N'seriouscompany@gmail.com', N'1234567890', N'355 serious drive')
GO
INSERT [dbo].[Clients] ([ClientID], [ClientName], [ContactEmail], [ContactPhone], [HomeAddress]) VALUES (4, N'Micro Soft', N'contact@microsoft.com', N'9876543210', N'Redmond,Washington,US')
GO
INSERT [dbo].[Clients] ([ClientID], [ClientName], [ContactEmail], [ContactPhone], [HomeAddress]) VALUES (5, N'Google', N'contact@google.com', N'4567891230', N'Mountain View, California, US')
GO
INSERT [dbo].[Clients] ([ClientID], [ClientName], [ContactEmail], [ContactPhone], [HomeAddress]) VALUES (6, N'Musashi', N'contact@musashi.ac.nz', N'+640221112222', N'123 Test Drive')
GO
INSERT [dbo].[Clients] ([ClientID], [ClientName], [ContactEmail], [ContactPhone], [HomeAddress]) VALUES (15, N'Lesley', N'Lesley@gmail.com', N'+197238069123', N'102 Comriees road')
GO
SET IDENTITY_INSERT [dbo].[Clients] OFF
GO
SET IDENTITY_INSERT [dbo].[CyberSecurityIncidents] ON 
GO
INSERT [dbo].[CyberSecurityIncidents] ([IncidentID], [IncidentType], [IncidentDesc], [IncidentDate], [Status], [AccountID]) VALUES (1, N'DDOS Attack', N'Mitigated DDos Attack', CAST(N'2024-03-30' AS Date), N'R', 5)
GO
INSERT [dbo].[CyberSecurityIncidents] ([IncidentID], [IncidentType], [IncidentDesc], [IncidentDate], [Status], [AccountID]) VALUES (2, N'RansomWare', N'Successfully handled the ransomware attack', CAST(N'2024-03-30' AS Date), N'R', 4)
GO
INSERT [dbo].[CyberSecurityIncidents] ([IncidentID], [IncidentType], [IncidentDesc], [IncidentDate], [Status], [AccountID]) VALUES (3, N'Worm Attack', N'Found the worm and mitigated the attack', CAST(N'2024-03-30' AS Date), N'R', 3)
GO
INSERT [dbo].[CyberSecurityIncidents] ([IncidentID], [IncidentType], [IncidentDesc], [IncidentDate], [Status], [AccountID]) VALUES (4, N'Malware', N'Mitigated the Malware attack', CAST(N'2024-03-30' AS Date), N'R', 2)
GO
INSERT [dbo].[CyberSecurityIncidents] ([IncidentID], [IncidentType], [IncidentDesc], [IncidentDate], [Status], [AccountID]) VALUES (5, N'Phishing', N'Mitigated the Phishing attack', CAST(N'2024-03-30' AS Date), N'R', 3)
GO
INSERT [dbo].[CyberSecurityIncidents] ([IncidentID], [IncidentType], [IncidentDesc], [IncidentDate], [Status], [AccountID]) VALUES (6, N'Bugs', N'Found Bugs While assessing the Security Level', CAST(N'2024-04-01' AS Date), N'P', 4)
GO
INSERT [dbo].[CyberSecurityIncidents] ([IncidentID], [IncidentType], [IncidentDesc], [IncidentDate], [Status], [AccountID]) VALUES (11, N'DDOS Attack', N'DDos Attack on account', CAST(N'2025-06-03' AS Date), N'R', 10)
GO
SET IDENTITY_INSERT [dbo].[CyberSecurityIncidents] OFF
GO
SET IDENTITY_INSERT [dbo].[Services] ON 
GO
INSERT [dbo].[Services] ([ServiceID], [ServiceName], [ServiceDesc]) VALUES (1, N'CLOUDSTOR', N'Secure Cloud Storage')
GO
INSERT [dbo].[Services] ([ServiceID], [ServiceName], [ServiceDesc]) VALUES (2, N'VIRTSEC', N'Virtual Machine Security')
GO
INSERT [dbo].[Services] ([ServiceID], [ServiceName], [ServiceDesc]) VALUES (3, N'MONITORING', N'Security Monitoring')
GO
INSERT [dbo].[Services] ([ServiceID], [ServiceName], [ServiceDesc]) VALUES (4, N'SECURITY ASSESS', N'Security Level Assessment')
GO
INSERT [dbo].[Services] ([ServiceID], [ServiceName], [ServiceDesc]) VALUES (5, N'DEFPENup', N'Defensive penetration Training updated')
GO
INSERT [dbo].[Services] ([ServiceID], [ServiceName], [ServiceDesc]) VALUES (6, N'DDOSpro', N'Protects from DDOS attacks')
GO
SET IDENTITY_INSERT [dbo].[Services] OFF
GO
SET IDENTITY_INSERT [dbo].[Subscription] ON 
GO
INSERT [dbo].[Subscription] ([SubscriptionID], [ServiceID], [AccountID], [SubscriptionDate]) VALUES (1, 1, 1, CAST(N'2025-03-10' AS Date))
GO
INSERT [dbo].[Subscription] ([SubscriptionID], [ServiceID], [AccountID], [SubscriptionDate]) VALUES (2, 5, 2, CAST(N'2025-03-16' AS Date))
GO
INSERT [dbo].[Subscription] ([SubscriptionID], [ServiceID], [AccountID], [SubscriptionDate]) VALUES (3, 3, 3, CAST(N'2025-03-17' AS Date))
GO
INSERT [dbo].[Subscription] ([SubscriptionID], [ServiceID], [AccountID], [SubscriptionDate]) VALUES (4, 2, 4, CAST(N'2025-03-14' AS Date))
GO
INSERT [dbo].[Subscription] ([SubscriptionID], [ServiceID], [AccountID], [SubscriptionDate]) VALUES (5, 4, 5, CAST(N'2025-04-01' AS Date))
GO
INSERT [dbo].[Subscription] ([SubscriptionID], [ServiceID], [AccountID], [SubscriptionDate]) VALUES (6, 2, 5, CAST(N'2025-03-22' AS Date))
GO
INSERT [dbo].[Subscription] ([SubscriptionID], [ServiceID], [AccountID], [SubscriptionDate]) VALUES (11, 2, 6, CAST(N'2025-05-27' AS Date))
GO
INSERT [dbo].[Subscription] ([SubscriptionID], [ServiceID], [AccountID], [SubscriptionDate]) VALUES (12, 1, 6, CAST(N'2025-05-27' AS Date))
GO
INSERT [dbo].[Subscription] ([SubscriptionID], [ServiceID], [AccountID], [SubscriptionDate]) VALUES (15, 1, 3, CAST(N'2025-05-27' AS Date))
GO
INSERT [dbo].[Subscription] ([SubscriptionID], [ServiceID], [AccountID], [SubscriptionDate]) VALUES (17, 2, 8, CAST(N'2025-05-28' AS Date))
GO
INSERT [dbo].[Subscription] ([SubscriptionID], [ServiceID], [AccountID], [SubscriptionDate]) VALUES (20, 1, 10, CAST(N'2025-06-03' AS Date))
GO
SET IDENTITY_INSERT [dbo].[Subscription] OFF
GO
ALTER TABLE [dbo].[Accounts] ADD  DEFAULT (getdate()) FOR [LastModifiedDate]
GO
ALTER TABLE [dbo].[Accounts]  WITH CHECK ADD FOREIGN KEY([ClientID])
REFERENCES [dbo].[Clients] ([ClientID])
GO
ALTER TABLE [dbo].[Billing]  WITH CHECK ADD FOREIGN KEY([SubscriptionID])
REFERENCES [dbo].[Subscription] ([SubscriptionID])
GO
ALTER TABLE [dbo].[CyberSecurityIncidents]  WITH CHECK ADD FOREIGN KEY([AccountID])
REFERENCES [dbo].[Accounts] ([AccountId])
GO
ALTER TABLE [dbo].[Subscription]  WITH CHECK ADD FOREIGN KEY([AccountID])
REFERENCES [dbo].[Accounts] ([AccountId])
GO
ALTER TABLE [dbo].[Subscription]  WITH CHECK ADD FOREIGN KEY([ServiceID])
REFERENCES [dbo].[Services] ([ServiceID])
GO
ALTER TABLE [dbo].[Billing]  WITH CHECK ADD CHECK  (([Status]='U' OR [Status]='P'))
GO
ALTER TABLE [dbo].[CyberSecurityIncidents]  WITH CHECK ADD CHECK  (([Status]='P' OR [Status]='R'))
GO
/****** Object:  StoredProcedure [dbo].[usp_deleteAccount]    Script Date: 28-07-2025 16:42:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PRocedure [dbo].[usp_deleteAccount]
	@AccountID INt
as
	begin
	Set NoCount on;
		begin transaction
			begin try

			delete from Accounts where AccountId = @AccountID
			
			If @@ROWCOUNT = 0
			begin
				rollback Transaction;
				Throw 50001, 'There is no Account with the given id', 2;
			end
			
			commit Transaction
			end try

			Begin catch
			if @@TRANCOUNT > 1
			rollback transaction;
			throw;
			end catch
		end
GO
/****** Object:  StoredProcedure [dbo].[usp_deleteBilling]    Script Date: 28-07-2025 16:42:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PRocedure [dbo].[usp_deleteBilling]
	@BillingID INt
as
	begin
	Set NoCount on;
		begin transaction
			begin try

			delete from billing where BillingID = @BillingID
			
			If @@ROWCOUNT = 0
			begin
				rollback Transaction;
				Throw 50001, 'There is no Bill with the given id', 2;
			end
			
			commit Transaction
			end try

			Begin catch
			if @@TRANCOUNT > 1
			rollback transaction;
			throw;
			end catch
		end
GO
/****** Object:  StoredProcedure [dbo].[usp_deleteClient]    Script Date: 28-07-2025 16:42:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[usp_deleteClient]
	@clientID INt
as
	Begin
	Set NOCOUNT ON;
		Begin Transaction
			Begin Try

			delete from clients where ClientID = @clientID

			If @@ROWCOUNT = 0
			begin
				rollback Transaction;
				Throw 50010, 'There was no client found with the given ID', 1
			end

			commit Transaction
			
			end try
			begin catch

			If @@TRANCOUNT >1 
			rollback transaction;
			Throw;
			end Catch
		end
GO
/****** Object:  StoredProcedure [dbo].[usp_deleteincident]    Script Date: 28-07-2025 16:42:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- exec usp_updateAccount 9, 'Should give an error', 3, '2025-04-15' 
/*exec usp_updateAccount 3, 'Serious Company Account updated', 3 , '2025-04-10'
select * from accounts */

--Creating a stored procedure to delete a cybersecurity incident by incident id
-- This procedure includes transaction handling and error checking using try/catch and @@rowcount
-- this can be used in the windows form application to delete incidents using incident id
Create Procedure [dbo].[usp_deleteincident]
	@incidentID int -- parameter to store the incident id of the incident to be deleted 
as
	Begin
	-- to begin the transaction
		Begin Transaction
		-- to begin the try block
			Begin Try
				-- delete statement that deletes the incident associated the given incident id
				delete from CyberSecurityIncidents where IncidentID = @incidentID
				-- if the rows affected are zero means no incident associated with the given incident id was found so we rollback the transaction and throw an error
				IF @@ROWCOUNT = 0
				begin
					rollback Transaction;
					Throw 50010, 'No Incident to delete', 2;
				End
				--If incident was found prints a success message
				Else
				Begin
					Print 'Incident Deleted Successfully'
				End
				-- commit the transactions
				commit Transaction
			End Try
			Begin Catch
				-- IF MORE THAN ONE TRANSACTION ROLLBACKS THE TRANSACTION and throws an error
				If @@TRANCOUNT > 1
					rollback Transaction;
				Throw;
			End Catch
		ENd
GO
/****** Object:  StoredProcedure [dbo].[usp_deleteServices]    Script Date: 28-07-2025 16:42:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[usp_deleteServices]
	@serviceID INt
as
	Begin
	Set NOCOUNT ON;
		Begin Transaction
			Begin Try

			delete from Services where ServiceID = @serviceID

			If @@ROWCOUNT = 0
			begin
				rollback Transaction;
				Throw 50010, 'There was no Service with the given ID', 1
			end

			commit Transaction
			
			end try
			begin catch

			If @@TRANCOUNT >1 
			rollback transaction;
			Throw;
			end Catch
		end
GO
/****** Object:  StoredProcedure [dbo].[usp_deleteSubscription]    Script Date: 28-07-2025 16:42:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[usp_deleteSubscription]
	@subscriptionID int
as
	Begin
	/*Set NOCOUNT ON;*/
		Begin Transaction
			Begin Try

			delete from subscription where SubscriptionID = @subscriptionID

			if @@ROWCOUNT = 0
			Begin
				rollback Transaction;
				Throw 50010, 'No Such entry Found', 1;
			end

			commit Transaction;
			end try

			Begin Catch
				if @@TRANCOUNT > 1
					rollback Transaction;
				Throw;
			end catch
		end
GO
/****** Object:  StoredProcedure [dbo].[usp_getData]    Script Date: 28-07-2025 16:42:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[usp_getData]
	@accountID Int
as
	Begin
		 select sub.Subscriptionid as 'ID', a.accountName, s.ServiceName, sub.SubscriptionDate from subscription sub
		 inner join accounts a on a.accountID = sub.AccountID
		 inner join services s on s.serviceID = sub.serviceID
		 where sub.AccountID = @accountID
	End
GO
/****** Object:  StoredProcedure [dbo].[usp_insertAccount]    Script Date: 28-07-2025 16:42:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- usp_insertAccounts
Create Procedure [dbo].[usp_insertAccount]
	@AccountName Nvarchar(30),
	@ClientID Int,
	@SubscriptionDate date
as
Begin
	Insert into accounts(AccountName, ClientID, subscriptiondate, LastModifiedDate) Values(@AccountName, @ClientID, @SubscriptionDate, GETDATE())
End
GO
/****** Object:  StoredProcedure [dbo].[usp_insertBilling]    Script Date: 28-07-2025 16:42:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--usp_insertBilling
Create Procedure [dbo].[usp_insertBilling]
	@Status Char(1),
	@subscriptionID INt,
	@billingDate Date,
	@amount decimal(6,2)
as
	Begin
		INsert into billing(status, SubscriptionID, BillingDate, Amount) Values(@Status, @subscriptionID, @billingDate, @amount)
	End
GO
/****** Object:  StoredProcedure [dbo].[usp_insertClient]    Script Date: 28-07-2025 16:42:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[usp_insertClient]
	@clientName Nvarchar(50), --parameter to store client name
	@ContactEmail NVarchar(100), -- parameter to store contact email
	@ContactPhone NVarchar(20), -- parameter to store contact phone number
	@HomeAddress NVarchar(150) -- paramter to store home address
As
Begin
	--insert statement that inserts the parameters passed by the user to the client table 
	Insert into Clients
	Values(@clientName,@ContactEmail,@ContactPhone,@HomeAddress)
End
GO
/****** Object:  StoredProcedure [dbo].[usp_insertIncident]    Script Date: 28-07-2025 16:42:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- usp_insertIncidents
Create Procedure [dbo].[usp_insertIncident]
	@incidentType Nvarchar(20),
	@incidentDesc nvarchar(100),
	@incidentdate date,
	@status char(1),
	@Accountid Int
as
Begin
	Insert into CyberSecurityIncidents(IncidentType, IncidentDesc, IncidentDate, Status, AccountID) Values(@incidentType, @incidentDesc, @incidentdate, @status, @Accountid)
End
GO
/****** Object:  StoredProcedure [dbo].[usp_insertServices]    Script Date: 28-07-2025 16:42:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[usp_insertServices]
	@servicename Nvarchar(20),
	@ServicesDes Nvarchar(50)
as 
	Begin
		Insert into Services(ServiceName, ServiceDesc) Values(@servicename, @ServicesDes)
	End
GO
/****** Object:  StoredProcedure [dbo].[usp_insertSubscription]    Script Date: 28-07-2025 16:42:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[usp_insertSubscription]
	@accountid Int,
	@serviceid Int,
	@date date
as 
Begin
	insert into Subscription(AccountID, ServiceID, SubscriptionDate) values(@accountid, @serviceid, @date)
End
GO
/****** Object:  StoredProcedure [dbo].[usp_updateAccount]    Script Date: 28-07-2025 16:42:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/* Exec usp_insertClient 'Wintec', 'contact@wintec.ac.nz', '022-666-7777', '123 Tristram Street'
select * from clients */

--Creating a Stored procedure to update an account
-- This procedure handles transaction handlind and error checkinng using try catch and @@rowcount
-- this can be used by the windows forms app to allow updates to existing accounts
-- this also automatically modifies lastmodifieddate
Create Procedure [dbo].[usp_updateAccount]
	@AccountID INT, --parameter to store account id
	@AccountName Nvarchar(30), -- parameter to store account name (updated account name)
	@clientID INT,-- parameter to store client id (updated client id)
	@SubscriptionDate Date -- parameter to store subscription date (updated subscription date)
As
Begin
	-- to begin a transaction
	Begin Transaction
		-- beginning the try block
		Begin TRY

			-- Update statement to updsate the accountname, clientid, subscriptiondate of a account via account id
			Update Accounts
			set AccountName = @AccountName,	ClientID = @clientID, SubscriptionDate = @SubscriptionDate, lastmodifiedDate = getDate() where AccountId = @AccountID
			
			-- @@rowcount check the number of rows affected through the previous command, if it is zero it throws an error and rollback the transaction
			If @@ROWCOUNT = 0
			begin
				rollBack Transaction;
				Throw 50010, 'No Account Found With the given ID', 1;
			end
			-- if there are rows affected by the update statement prints a confirmation
			else
			begin
				print 'Data Updated Successfully'
			end
			
			-- if there are rows affected it commits the transaction
			commit Transaction
		End Try
		-- beginning the catch block
		Begin Catch
			-- @@trancount gives the number of ongoing transactions if more than one rollback sthe transaction and throw an error
			if @@TRANCOUNT > 1
				rollback Transaction;
				Throw;
		End Catch
	End
GO
/****** Object:  StoredProcedure [dbo].[usp_updateBilling]    Script Date: 28-07-2025 16:42:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PRocedure [dbo].[usp_updateBilling]
	@BillingID INt,
	@SubscriptionID INT,
	@BillingDate Date,
	@Amount decimal(6,2),
	@Status char(1)
as
	begin
	Set NoCount on;
		begin transaction
			begin try

			update Billing set SubscriptionID = @SubscriptionID, BillingDate = @BillingDate, Amount = @Amount, Status = @Status where BillingID = @BillingID

			If @@ROWCOUNT = 0
			begin
				rollback Transaction;
				Throw 50001, 'There is no Bill with the given id', 2;
			end
			
			commit Transaction
			end try

			Begin catch
			if @@TRANCOUNT > 1
			rollback transaction;
			throw;
			end catch
		end
GO
/****** Object:  StoredProcedure [dbo].[usp_updateClients]    Script Date: 28-07-2025 16:42:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PRocedure [dbo].[usp_updateClients]
	@ClientID INt,
	@ClientName Nvarchar(50),
	@ContactEmail Nvarchar(100),
	@contactPhone Nvarchar(20),
	@HomeAddress Nvarchar(150)
as
	begin
	Set NoCount on;
		begin transaction
			begin try

			update clients set ClientName = @ClientName, ContactEmail = @contactemail, ContactPhone = @contactPhone, HomeAddress = @HomeAddress where ClientID = @ClientID

			If @@ROWCOUNT = 0
			begin
				rollback Transaction;
				Throw 50001, 'There is no client with the given id', 2;
			end
			
			commit Transaction
			end try

			Begin catch
			if @@TRANCOUNT > 1
			rollback transaction;
			throw;
			end catch
		end
GO
/****** Object:  StoredProcedure [dbo].[usp_updateIncidents]    Script Date: 28-07-2025 16:42:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PRocedure [dbo].[usp_updateIncidents]
	@incidentID INt,
	@IncidentType Nvarchar(20),
	@IncidentDesc Nvarchar(100),
	@incidentDate Date,
	@Status char(1),
	@accountID Int
as
	begin
	Set NoCount on;
		begin transaction
			begin try

			update CyberSecurityIncidents set IncidentType = @incidentType, IncidentDesc = @IncidentDesc, IncidentDate = @incidentDate, Status = @Status, AccountID = @accountID where IncidentID = @incidentID

			If @@ROWCOUNT = 0
			begin
				rollback Transaction;
				Throw 50001, 'There is no incident with the given id', 2;
			end
			
			commit Transaction
			end try

			Begin catch
			if @@TRANCOUNT > 1
			rollback transaction;
			throw;
			end catch
		end
GO
/****** Object:  StoredProcedure [dbo].[usp_updateServices]    Script Date: 28-07-2025 16:42:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PRocedure [dbo].[usp_updateServices]
	@serviceID int,
	@servicename Nvarchar(20),
	@serviceDesc Nvarchar(50)
as
	begin
	Set NoCount on;
		begin transaction
			begin try

			update Services set ServiceName = @servicename, ServiceDesc = @serviceDesc where ServiceID = @serviceID

			If @@ROWCOUNT = 0
			begin
				rollback Transaction;
				Throw 50001, 'There is no service with the given id', 2;
			end
			
			commit Transaction
			end try

			Begin catch
			if @@TRANCOUNT > 1
			rollback transaction;
			throw;
			end catch
		end
GO
/****** Object:  StoredProcedure [dbo].[usp_updateSubscription]    Script Date: 28-07-2025 16:42:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[usp_updateSubscription]
	@subscriptionid int,
	@accountID int,
	@serviceID int,
	@date date
as
	Begin
		Set NOCOUNT on;
		Begin Transaction
			Begin Try

			update Subscription set AccountID = @accountID, ServiceID = @serviceID, SubscriptionDate = @date where SubscriptionID = @subscriptionid

			if @@ROWCOUNT < 1
			begin
				rollback transaction;
				Throw 50001, 'No Entry was found for the specified ID', 2;
			end

			commit transaction
			
			end try
			begin catch
				if @@TRANCOUNT > 1
				rollback transaction;
				throw
			end catch
	end
GO
/****** Object:  Trigger [dbo].[trg_preventAccountIncidentdelete]    Script Date: 28-07-2025 16:42:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[trg_preventAccountIncidentdelete]
ON [dbo].[Accounts]
INSTEAD OF DELETE
AS
BEGIN
    -- Check if any of the accounts being deleted are linked to an incident
    IF EXISTS (
        SELECT 1 
        FROM deleted d 
        INNER JOIN CyberSecurityIncidents csi ON csi.AccountID = d.AccountID
    )
    BEGIN
        ROLLBACK TRANSACTION;
        THROW 50010, 'This account is linked to an active Incident', 1;
    END;

    -- Check if any of the accounts being deleted have an active subscription
    IF EXISTS (
        SELECT 1 
        FROM deleted d 
        INNER JOIN Subscription s ON s.AccountID = d.AccountID
    )
    BEGIN
        ROLLBACK TRANSACTION;
        THROW 50011, 'This account is actively subscribed to a service', 1;
    END;

    -- If no related incidents or subscriptions exist, proceed with deletion
    DELETE FROM Accounts 
    WHERE AccountID IN (SELECT AccountID FROM deleted);
END;
GO
ALTER TABLE [dbo].[Accounts] ENABLE TRIGGER [trg_preventAccountIncidentdelete]
GO
/****** Object:  Trigger [dbo].[trg_updateaccount]    Script Date: 28-07-2025 16:42:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- exec usp_deleteincident 10
/*
	exec usp_deleteincident 6
	select * from cybersecurityincidents
*/

--Triggers
-- Creating a trigger on table accounts after an update statement is run
-- This trigger automatically updates the lastmodified date in the account table whenever an account is updated
-- this is usefull for windows forms app beacuse whenever someone would update any account info this will automatically update the lastmodified date
Create Trigger [dbo].[trg_updateaccount]
on [dbo].[Accounts]
after update
as
	Begin
		-- update statement to set the lastmodifieddate as the current date on the account id common between the inserted table and the accounts table
		update a
		set lastmodifieddate = getDate()
		from Accounts a
		inner join inserted i on a.accountid = i.accountid
	End
GO
ALTER TABLE [dbo].[Accounts] ENABLE TRIGGER [trg_updateaccount]
GO
/****** Object:  Trigger [dbo].[trg_preventUnpaidBillDelete]    Script Date: 28-07-2025 16:42:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[trg_preventUnpaidBillDelete]
ON [dbo].[Billing]
INSTEAD OF DELETE
AS
BEGIN
    -- Check if any bill being deleted has status 'U' (Unpaid)
    IF EXISTS (
        SELECT 1
        FROM deleted
        WHERE Status = 'U'
    )
    BEGIN
        ROLLBACK TRANSACTION;
        THROW 50011, 'Cannot delete unpaid bills', 1;
    END
    ELSE
    BEGIN
        -- Proceed with deletion for other bills
        DELETE FROM Billing
        WHERE BillingID IN (SELECT BillingID FROM deleted);
    END
END;
GO
ALTER TABLE [dbo].[Billing] ENABLE TRIGGER [trg_preventUnpaidBillDelete]
GO
/****** Object:  Trigger [dbo].[trg_preventdelete]    Script Date: 28-07-2025 16:42:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/* update accounts set accountname = 'google alt acc update' where accountid = 6
select * from accounts */

--Creating a trigger on table clients that runs instead of the delete
-- This trigger prevents users from deleting clients that have one or more active accounts
-- This can be usefull in the windows forms app by preventing someone from making a mistake
Create Trigger [dbo].[trg_preventdelete]
on [dbo].[Clients]
Instead of  delete
as
	begin
		-- if there exists an entry where the client id supposed to be deleted matches the client id on any of the accounts we rollback the transaction and throw an error
		if exists (select 1 from deleted d inner join accounts a on a.clientid = d.clientid)
		begin
			rollback Transaction;
			Throw 50010, 'Clients has one or more active accounts', 1;
		End
		-- else we delete the client id that was supposed to be deleted
		Else
			delete from clients where clientid in (select clientid from deleted)
	end
GO
ALTER TABLE [dbo].[Clients] ENABLE TRIGGER [trg_preventdelete]
GO
/****** Object:  Trigger [dbo].[trg_preventduplicate]    Script Date: 28-07-2025 16:42:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[trg_preventduplicate]
ON [dbo].[Clients]
INSTEAD OF INSERT
AS
BEGIN
    IF EXISTS (
        SELECT 1
        FROM inserted i
        INNER JOIN clients c ON i.ClientName = c.ClientName
    )
    BEGIN
		ROLLBACK TRANSACTION;
        THROW 50010, 'There is already a client with that name.', 1;
        RETURN;
    END

    -- Insert if no duplicate name found
    INSERT INTO clients  (ClientName, ContactEmail,ContactPhone, HomeAddress)
    SELECT ClientName, ContactEmail, ContactPhone,HomeAddress
    FROM inserted;
END;
GO
ALTER TABLE [dbo].[Clients] ENABLE TRIGGER [trg_preventduplicate]
GO
/****** Object:  Trigger [dbo].[trg_preventUnresolvedIncidentDelete]    Script Date: 28-07-2025 16:42:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[trg_preventUnresolvedIncidentDelete]
ON [dbo].[CyberSecurityIncidents]
INSTEAD OF DELETE
AS
BEGIN
    -- Check if any incident being deleted has status indicating unresolved
    IF EXISTS (
        SELECT 1
        FROM deleted
        WHERE Status = 'P'  -- Adjust statuses as per your data model
    )
    BEGIN
        ROLLBACK TRANSACTION;
        THROW 50012, 'Cannot delete unresolved incidents', 1;
    END
    ELSE
    BEGIN
        -- Proceed with deletion of resolved incidents
        DELETE FROM CyberSecurityIncidents
        WHERE IncidentID IN (SELECT IncidentID FROM deleted);
    END
END;
GO
ALTER TABLE [dbo].[CyberSecurityIncidents] ENABLE TRIGGER [trg_preventUnresolvedIncidentDelete]
GO
/****** Object:  Trigger [dbo].[trg_preventServicedelete]    Script Date: 28-07-2025 16:42:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Trigger [dbo].[trg_preventServicedelete]
on [dbo].[Services]
Instead of  delete
as
	begin
		-- if there exists an entry where the client id supposed to be deleted matches the client id on any of the accounts we rollback the transaction and throw an error
		if exists (select 1 from deleted d inner join Subscription s on s.ServiceID = d.ServiceID)
		begin
			rollback Transaction;
			Throw 50010, 'This service is actively subscribed to by an active account', 1;
		End
		-- else we delete the client id that was supposed to be deleted
		Else
			delete from Services where serviceid in (select serviceId from deleted)
	end
GO
ALTER TABLE [dbo].[Services] ENABLE TRIGGER [trg_preventServicedelete]
GO
/****** Object:  Trigger [dbo].[trg_preventDuplicateSubscription]    Script Date: 28-07-2025 16:42:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[trg_preventDuplicateSubscription]
ON [dbo].[Subscription]
INSTEAD OF INSERT
AS
BEGIN
    -- Check if any new rows already exist in Subscription
    IF EXISTS (
        SELECT 1
        FROM inserted i
        JOIN Subscription s
          ON s.AccountID = i.AccountID
         AND s.ServiceID = i.ServiceID
    )
    BEGIN
        ROLLBACK TRANSACTION;
        THROW 50010, 'Duplicate subscription for the same Account and Service is not allowed. Perhaps try updating subscription', 1;
    END

    -- If no duplicates, proceed with insert
    INSERT INTO Subscription (AccountID, ServiceID, SubscriptionDate)
    SELECT AccountID, ServiceID, SubscriptionDate
    FROM inserted;
END
GO
ALTER TABLE [dbo].[Subscription] ENABLE TRIGGER [trg_preventDuplicateSubscription]
GO
/****** Object:  Trigger [dbo].[trg_preventSubscriptiondelete]    Script Date: 28-07-2025 16:42:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Trigger [dbo].[trg_preventSubscriptiondelete]
on [dbo].[Subscription]
Instead of  delete
as
	begin
		-- if there exists an entry where the client id supposed to be deleted matches the client id on any of the accounts we rollback the transaction and throw an error
		if exists (select 1 from deleted d inner join billing b on b.SubscriptionID = d.SubscriptionID)
		begin
			rollback Transaction;
			Throw 50010, 'This subscriptions is involved in an active billing record', 1;
		End
		-- else we delete the client id that was supposed to be deleted
		Else
			delete from Subscription where subscriptionid in (select subscriptionId from deleted)
	end
GO
ALTER TABLE [dbo].[Subscription] ENABLE TRIGGER [trg_preventSubscriptiondelete]
GO
USE [master]
GO
ALTER DATABASE [Cyber_Secure_Db] SET  READ_WRITE 
GO
