USE [master]
GO
/****** Object:  Database [PersonalSafetyDatabase]    Script Date: 11/24/2023 11:07:41 AM ******/
CREATE DATABASE [PersonalSafetyDatabase]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'PersonalSafetyDatabase', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\PersonalSafetyDatabase.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'PersonalSafetyDatabase_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\PersonalSafetyDatabase_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [PersonalSafetyDatabase] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [PersonalSafetyDatabase].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [PersonalSafetyDatabase] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [PersonalSafetyDatabase] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [PersonalSafetyDatabase] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [PersonalSafetyDatabase] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [PersonalSafetyDatabase] SET ARITHABORT OFF 
GO
ALTER DATABASE [PersonalSafetyDatabase] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [PersonalSafetyDatabase] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [PersonalSafetyDatabase] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [PersonalSafetyDatabase] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [PersonalSafetyDatabase] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [PersonalSafetyDatabase] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [PersonalSafetyDatabase] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [PersonalSafetyDatabase] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [PersonalSafetyDatabase] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [PersonalSafetyDatabase] SET  ENABLE_BROKER 
GO
ALTER DATABASE [PersonalSafetyDatabase] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [PersonalSafetyDatabase] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [PersonalSafetyDatabase] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [PersonalSafetyDatabase] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [PersonalSafetyDatabase] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [PersonalSafetyDatabase] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [PersonalSafetyDatabase] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [PersonalSafetyDatabase] SET RECOVERY FULL 
GO
ALTER DATABASE [PersonalSafetyDatabase] SET  MULTI_USER 
GO
ALTER DATABASE [PersonalSafetyDatabase] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [PersonalSafetyDatabase] SET DB_CHAINING OFF 
GO
ALTER DATABASE [PersonalSafetyDatabase] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [PersonalSafetyDatabase] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [PersonalSafetyDatabase] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [PersonalSafetyDatabase] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'PersonalSafetyDatabase', N'ON'
GO
ALTER DATABASE [PersonalSafetyDatabase] SET QUERY_STORE = ON
GO
ALTER DATABASE [PersonalSafetyDatabase] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [PersonalSafetyDatabase]
GO
/****** Object:  Table [dbo].[Alerts]    Script Date: 11/24/2023 11:07:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Alerts](
	[AlertID] [int] IDENTITY(1,1) NOT NULL,
	[UserID] [int] NULL,
	[AlertType] [varchar](255) NULL,
	[CreatedAt] [datetime] NULL,
	[UpdatedAt] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[AlertID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AlertsAudit]    Script Date: 11/24/2023 11:07:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AlertsAudit](
	[AlertsAuditID] [int] IDENTITY(1,1) NOT NULL,
	[Action] [varchar](10) NULL,
	[OldAlertID] [int] NULL,
	[OldUserID] [int] NULL,
	[OldAlertType] [varchar](255) NULL,
	[OldCreatedAt] [datetime] NULL,
	[OldUpdatedAt] [datetime] NULL,
	[NewAlertID] [int] NULL,
	[NewUserID] [int] NULL,
	[NewAlertType] [varchar](255) NULL,
	[NewCreatedAt] [datetime] NULL,
	[NewUpdatedAt] [datetime] NULL,
	[Timestamp] [datetime] NULL,
	[UserID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[AlertsAuditID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AppLog]    Script Date: 11/24/2023 11:07:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AppLog](
	[LogID] [int] NOT NULL,
	[Timestamp] [datetime] NULL,
	[LogLevel] [varchar](20) NULL,
	[Logger] [varchar](50) NULL,
	[ThreadID] [int] NULL,
	[UserID] [int] NULL,
	[MachineName] [varchar](50) NULL,
	[AppVersion] [varchar](20) NULL,
	[Message] [text] NULL,
	[ExceptionDetails] [text] NULL,
	[StackTrace] [text] NULL,
	[AdditionalInfo] [xml] NULL,
PRIMARY KEY CLUSTERED 
(
	[LogID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChatMessages]    Script Date: 11/24/2023 11:07:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChatMessages](
	[MessageID] [int] IDENTITY(1,1) NOT NULL,
	[UserID] [int] NULL,
	[ReceiverUserID] [int] NULL,
	[MessageText] [nvarchar](max) NULL,
	[CreatedAt] [datetime] NULL,
	[UpdatedAt] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[MessageID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChatMessagesAudit]    Script Date: 11/24/2023 11:07:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChatMessagesAudit](
	[ChatMessagesAuditID] [int] IDENTITY(1,1) NOT NULL,
	[Action] [varchar](10) NULL,
	[OldMessageID] [int] NULL,
	[OldUserID] [int] NULL,
	[OldReceiverUserID] [int] NULL,
	[OldMessageText] [nvarchar](max) NULL,
	[OldCreatedAt] [datetime] NULL,
	[OldUpdatedAt] [datetime] NULL,
	[NewMessageID] [int] NULL,
	[NewUserID] [int] NULL,
	[NewReceiverUserID] [int] NULL,
	[NewMessageText] [nvarchar](max) NULL,
	[NewCreatedAt] [datetime] NULL,
	[NewUpdatedAt] [datetime] NULL,
	[Timestamp] [datetime] NULL,
	[UserID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ChatMessagesAuditID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EmergencyContacts]    Script Date: 11/24/2023 11:07:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EmergencyContacts](
	[ContactID] [int] IDENTITY(1,1) NOT NULL,
	[UserID] [int] NULL,
	[ContactName] [varchar](255) NULL,
	[ContactPhoneNumber] [varchar](20) NULL,
	[Relationship] [varchar](255) NULL,
	[CreatedAt] [datetime] NULL,
	[UpdatedAt] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[ContactID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EmergencyContactsAudit]    Script Date: 11/24/2023 11:07:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EmergencyContactsAudit](
	[EmergencyContactsAuditID] [int] IDENTITY(1,1) NOT NULL,
	[Action] [varchar](10) NULL,
	[OldContactID] [int] NULL,
	[OldUserID] [int] NULL,
	[OldContactName] [varchar](255) NULL,
	[OldContactPhoneNumber] [varchar](20) NULL,
	[OldRelationship] [varchar](255) NULL,
	[OldCreatedAt] [datetime] NULL,
	[OldUpdatedAt] [datetime] NULL,
	[NewContactID] [int] NULL,
	[NewUserID] [int] NULL,
	[NewContactName] [varchar](255) NULL,
	[NewContactPhoneNumber] [varchar](20) NULL,
	[NewRelationship] [varchar](255) NULL,
	[NewCreatedAt] [datetime] NULL,
	[NewUpdatedAt] [datetime] NULL,
	[Timestamp] [datetime] NULL,
	[UserID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[EmergencyContactsAuditID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FeedbackRating]    Script Date: 11/24/2023 11:07:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FeedbackRating](
	[RatingID] [int] IDENTITY(1,1) NOT NULL,
	[UserID] [int] NULL,
	[Rating] [int] NULL,
	[FeedbackText] [varchar](max) NULL,
	[CreatedAt] [datetime] NULL,
	[UpdatedAt] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[RatingID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FeedbackRatingAudit]    Script Date: 11/24/2023 11:07:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FeedbackRatingAudit](
	[FeedbackRatingAuditID] [int] IDENTITY(1,1) NOT NULL,
	[Action] [varchar](10) NULL,
	[OldRatingID] [int] NULL,
	[OldUserID] [int] NULL,
	[OldRating] [int] NULL,
	[OldFeedbackText] [text] NULL,
	[OldCreatedAt] [datetime] NULL,
	[OldUpdatedAt] [datetime] NULL,
	[NewRatingID] [int] NULL,
	[NewUserID] [int] NULL,
	[NewRating] [int] NULL,
	[NewFeedbackText] [text] NULL,
	[NewCreatedAt] [datetime] NULL,
	[NewUpdatedAt] [datetime] NULL,
	[Timestamp] [datetime] NULL,
	[UserID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[FeedbackRatingAuditID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Incident]    Script Date: 11/24/2023 11:07:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Incident](
	[IncidentID] [int] IDENTITY(1,1) NOT NULL,
	[UserID] [int] NULL,
	[LocationID] [int] NULL,
	[IncidentType] [varchar](255) NULL,
	[Description] [varchar](max) NULL,
	[CreatedAt] [datetime] NULL,
	[UpdatedAt] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[IncidentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[IncidentAudit]    Script Date: 11/24/2023 11:07:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[IncidentAudit](
	[IncidentAuditID] [int] IDENTITY(1,1) NOT NULL,
	[Action] [varchar](10) NULL,
	[OldIncidentID] [int] NULL,
	[OldUserID] [int] NULL,
	[OldLocationID] [int] NULL,
	[OldIncidentType] [varchar](255) NULL,
	[OldDescription] [text] NULL,
	[OldCreatedAt] [datetime] NULL,
	[OldUpdatedAt] [datetime] NULL,
	[NewIncidentID] [int] NULL,
	[NewUserID] [int] NULL,
	[NewLocationID] [int] NULL,
	[NewIncidentType] [varchar](255) NULL,
	[NewDescription] [text] NULL,
	[NewCreatedAt] [datetime] NULL,
	[NewUpdatedAt] [datetime] NULL,
	[Timestamp] [datetime] NULL,
	[UserID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[IncidentAuditID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[IncidentHistory]    Script Date: 11/24/2023 11:07:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[IncidentHistory](
	[IncidentHistoryID] [int] IDENTITY(1,1) NOT NULL,
	[UserID] [int] NULL,
	[IncidentID] [int] NULL,
	[CreatedAt] [datetime] NULL,
	[UpdatedAt] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[IncidentHistoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[IncidentHistoryAudit]    Script Date: 11/24/2023 11:07:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[IncidentHistoryAudit](
	[IncidentHistoryAuditID] [int] IDENTITY(1,1) NOT NULL,
	[Action] [varchar](10) NULL,
	[OldIncidentHistoryID] [int] NULL,
	[OldUserID] [int] NULL,
	[OldIncidentID] [int] NULL,
	[OldCreatedAt] [datetime] NULL,
	[OldUpdatedAt] [datetime] NULL,
	[NewIncidentHistoryID] [int] NULL,
	[NewUserID] [int] NULL,
	[NewIncidentID] [int] NULL,
	[NewCreatedAt] [datetime] NULL,
	[NewUpdatedAt] [datetime] NULL,
	[Timestamp] [datetime] NULL,
	[UserID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[IncidentHistoryAuditID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LanguageSupport]    Script Date: 11/24/2023 11:07:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LanguageSupport](
	[LanguageID] [int] IDENTITY(1,1) NOT NULL,
	[LanguageName] [varchar](255) NULL,
	[CreatedAt] [datetime] NULL,
	[UpdatedAt] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[LanguageID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LanguageSupportAudit]    Script Date: 11/24/2023 11:07:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LanguageSupportAudit](
	[LanguageSupportAuditID] [int] IDENTITY(1,1) NOT NULL,
	[Action] [varchar](10) NULL,
	[OldLanguageID] [int] NULL,
	[OldLanguageName] [varchar](255) NULL,
	[OldCreatedAt] [datetime] NULL,
	[OldUpdatedAt] [datetime] NULL,
	[NewLanguageID] [int] NULL,
	[NewLanguageName] [varchar](255) NULL,
	[NewCreatedAt] [datetime] NULL,
	[NewUpdatedAt] [datetime] NULL,
	[Timestamp] [datetime] NULL,
	[UserID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[LanguageSupportAuditID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Location]    Script Date: 11/24/2023 11:07:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Location](
	[LocationID] [int] IDENTITY(1,1) NOT NULL,
	[Latitude] [decimal](10, 8) NULL,
	[Longitude] [decimal](11, 8) NULL,
	[Address] [varchar](255) NULL,
	[City] [varchar](255) NULL,
	[State] [varchar](255) NULL,
	[Country] [varchar](255) NULL,
	[HighRiskAreaFlag] [bit] NULL,
	[CreatedAt] [datetime] NULL,
	[UpdatedAt] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[LocationID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LocationAudit]    Script Date: 11/24/2023 11:07:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LocationAudit](
	[LocationAuditID] [int] IDENTITY(1,1) NOT NULL,
	[Action] [varchar](10) NULL,
	[OldLocationID] [int] NULL,
	[OldLatitude] [decimal](10, 8) NULL,
	[OldLongitude] [decimal](11, 8) NULL,
	[OldAddress] [varchar](255) NULL,
	[OldCity] [varchar](255) NULL,
	[OldState] [varchar](255) NULL,
	[OldCountry] [varchar](255) NULL,
	[OldHighRiskAreaFlag] [bit] NULL,
	[OldCreatedAt] [datetime] NULL,
	[OldUpdatedAt] [datetime] NULL,
	[NewLocationID] [int] NULL,
	[NewLatitude] [decimal](10, 8) NULL,
	[NewLongitude] [decimal](11, 8) NULL,
	[NewAddress] [varchar](255) NULL,
	[NewCity] [varchar](255) NULL,
	[NewState] [varchar](255) NULL,
	[NewCountry] [varchar](255) NULL,
	[NewHighRiskAreaFlag] [bit] NULL,
	[NewCreatedAt] [datetime] NULL,
	[NewUpdatedAt] [datetime] NULL,
	[Timestamp] [datetime] NULL,
	[UserID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[LocationAuditID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Report]    Script Date: 11/24/2023 11:07:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Report](
	[ReportID] [int] IDENTITY(1,1) NOT NULL,
	[UserID] [int] NULL,
	[LocationID] [int] NULL,
	[FeedbackText] [varchar](max) NULL,
	[CreatedAt] [datetime] NULL,
	[UpdatedAt] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[ReportID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ReportAudit]    Script Date: 11/24/2023 11:07:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ReportAudit](
	[ReportAuditID] [int] IDENTITY(1,1) NOT NULL,
	[Action] [varchar](10) NULL,
	[OldReportID] [int] NULL,
	[OldUserID] [int] NULL,
	[OldLocationID] [int] NULL,
	[OldFeedbackText] [varchar](max) NULL,
	[OldCreatedAt] [datetime] NULL,
	[OldUpdatedAt] [datetime] NULL,
	[NewReportID] [int] NULL,
	[NewUserID] [int] NULL,
	[NewLocationID] [int] NULL,
	[NewFeedbackText] [varchar](max) NULL,
	[NewCreatedAt] [datetime] NULL,
	[NewUpdatedAt] [datetime] NULL,
	[Timestamp] [datetime] NULL,
	[UserID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ReportAuditID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SafetyTips]    Script Date: 11/24/2023 11:07:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SafetyTips](
	[TipID] [int] IDENTITY(1,1) NOT NULL,
	[Title] [varchar](255) NULL,
	[Description] [nvarchar](max) NULL,
	[CreatedAt] [datetime] NULL,
	[UpdatedAt] [datetime] NULL,
	[UserID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[TipID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SafetyTipsAudit]    Script Date: 11/24/2023 11:07:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SafetyTipsAudit](
	[SafetyTipsAuditID] [int] IDENTITY(1,1) NOT NULL,
	[Action] [varchar](10) NULL,
	[OldTipID] [int] NULL,
	[OldTitle] [varchar](255) NULL,
	[OldDescription] [nvarchar](max) NULL,
	[OldCreatedAt] [datetime] NULL,
	[OldUpdatedAt] [datetime] NULL,
	[NewTipID] [int] NULL,
	[NewTitle] [varchar](255) NULL,
	[NewDescription] [nvarchar](max) NULL,
	[NewCreatedAt] [datetime] NULL,
	[NewUpdatedAt] [datetime] NULL,
	[Timestamp] [datetime] NULL,
	[UserID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[SafetyTipsAuditID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 11/24/2023 11:07:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[UserID] [int] IDENTITY(1,1) NOT NULL,
	[Username] [varchar](255) NULL,
	[Password] [varchar](255) NULL,
	[RoleID] [int] NULL,
	[CreatedAt] [datetime] NULL,
	[UpdatedAt] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserAudit]    Script Date: 11/24/2023 11:07:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserAudit](
	[UserAuditID] [int] IDENTITY(1,1) NOT NULL,
	[Action] [varchar](10) NULL,
	[OldUserID] [int] NULL,
	[OldUsername] [varchar](255) NULL,
	[OldPassword] [varchar](255) NULL,
	[OldRoleID] [int] NULL,
	[OldCreatedAt] [datetime] NULL,
	[OldUpdatedAt] [datetime] NULL,
	[NewUserID] [int] NULL,
	[NewUsername] [varchar](255) NULL,
	[NewPassword] [varchar](255) NULL,
	[NewRoleID] [int] NULL,
	[NewCreatedAt] [datetime] NULL,
	[NewUpdatedAt] [datetime] NULL,
	[Timestamp] [datetime] NULL,
	[UserID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[UserAuditID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserDetails]    Script Date: 11/24/2023 11:07:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserDetails](
	[UserDetailsID] [int] IDENTITY(1,1) NOT NULL,
	[UserID] [int] NULL,
	[Email] [varchar](255) NULL,
	[FirstName] [varchar](255) NULL,
	[LastName] [varchar](255) NULL,
	[PhoneNumber] [varchar](20) NULL,
	[Gender] [nvarchar](10) NULL,
	[DateOfBirth] [date] NULL,
	[LastLoginDate] [datetime] NULL,
	[PrivacySettings] [nvarchar](max) NULL,
	[CreatedAt] [datetime] NULL,
	[UpdatedAt] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[UserDetailsID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserDetailsAudit]    Script Date: 11/24/2023 11:07:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserDetailsAudit](
	[UserDetailsAuditID] [int] IDENTITY(1,1) NOT NULL,
	[Action] [varchar](10) NULL,
	[OldUserDetailsID] [int] NULL,
	[OldUserID] [int] NULL,
	[OldEmail] [varchar](255) NULL,
	[OldFirstName] [varchar](255) NULL,
	[OldLastName] [varchar](255) NULL,
	[OldPhoneNumber] [varchar](20) NULL,
	[OldGender] [nvarchar](10) NULL,
	[OldDateOfBirth] [date] NULL,
	[OldLastLoginDate] [datetime] NULL,
	[OldPrivacySettings] [nvarchar](max) NULL,
	[OldCreatedAt] [datetime] NULL,
	[OldUpdatedAt] [datetime] NULL,
	[NewUserDetailsID] [int] NULL,
	[NewUserID] [int] NULL,
	[NewEmail] [varchar](255) NULL,
	[NewFirstName] [varchar](255) NULL,
	[NewLastName] [varchar](255) NULL,
	[NewPhoneNumber] [varchar](20) NULL,
	[NewGender] [nvarchar](10) NULL,
	[NewDateOfBirth] [date] NULL,
	[NewLastLoginDate] [datetime] NULL,
	[NewPrivacySettings] [nvarchar](max) NULL,
	[NewCreatedAt] [datetime] NULL,
	[NewUpdatedAt] [datetime] NULL,
	[Timestamp] [datetime] NULL,
	[UserID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[UserDetailsAuditID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserRole]    Script Date: 11/24/2023 11:07:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserRole](
	[UserRoleID] [int] IDENTITY(1,1) NOT NULL,
	[RoleName] [varchar](255) NULL,
	[RoleDescription] [nvarchar](max) NULL,
	[CreatedAt] [datetime] NULL,
	[UpdatedAt] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[UserRoleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserRoleAudit]    Script Date: 11/24/2023 11:07:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserRoleAudit](
	[UserRoleAuditID] [int] IDENTITY(1,1) NOT NULL,
	[Action] [varchar](10) NULL,
	[OldUserRoleID] [int] NULL,
	[OldRoleName] [varchar](255) NULL,
	[OldRoleDescription] [nvarchar](max) NULL,
	[OldCreatedAt] [datetime] NULL,
	[OldUpdatedAt] [datetime] NULL,
	[NewUserRoleID] [int] NULL,
	[NewRoleName] [varchar](255) NULL,
	[NewRoleDescription] [nvarchar](max) NULL,
	[NewCreatedAt] [datetime] NULL,
	[NewUpdatedAt] [datetime] NULL,
	[Timestamp] [datetime] NULL,
	[UserID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[UserRoleAuditID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[AppLog] ADD  DEFAULT (getdate()) FOR [Timestamp]
GO
ALTER TABLE [dbo].[Alerts]  WITH CHECK ADD FOREIGN KEY([UserID])
REFERENCES [dbo].[User] ([UserID])
GO
ALTER TABLE [dbo].[AlertsAudit]  WITH CHECK ADD  CONSTRAINT [FK_AlertsAudit_UserID] FOREIGN KEY([UserID])
REFERENCES [dbo].[User] ([UserID])
GO
ALTER TABLE [dbo].[AlertsAudit] CHECK CONSTRAINT [FK_AlertsAudit_UserID]
GO
ALTER TABLE [dbo].[ChatMessages]  WITH CHECK ADD FOREIGN KEY([ReceiverUserID])
REFERENCES [dbo].[User] ([UserID])
GO
ALTER TABLE [dbo].[ChatMessages]  WITH CHECK ADD FOREIGN KEY([UserID])
REFERENCES [dbo].[User] ([UserID])
GO
ALTER TABLE [dbo].[ChatMessagesAudit]  WITH CHECK ADD  CONSTRAINT [FK_ChatMessagesAudit_UserID] FOREIGN KEY([UserID])
REFERENCES [dbo].[User] ([UserID])
GO
ALTER TABLE [dbo].[ChatMessagesAudit] CHECK CONSTRAINT [FK_ChatMessagesAudit_UserID]
GO
ALTER TABLE [dbo].[EmergencyContacts]  WITH CHECK ADD FOREIGN KEY([UserID])
REFERENCES [dbo].[User] ([UserID])
GO
ALTER TABLE [dbo].[EmergencyContactsAudit]  WITH CHECK ADD  CONSTRAINT [FK_EmergencyContactsAudit_UserID] FOREIGN KEY([UserID])
REFERENCES [dbo].[User] ([UserID])
GO
ALTER TABLE [dbo].[EmergencyContactsAudit] CHECK CONSTRAINT [FK_EmergencyContactsAudit_UserID]
GO
ALTER TABLE [dbo].[FeedbackRating]  WITH CHECK ADD FOREIGN KEY([UserID])
REFERENCES [dbo].[User] ([UserID])
GO
ALTER TABLE [dbo].[FeedbackRatingAudit]  WITH CHECK ADD  CONSTRAINT [FK_FeedbackRatingAudit_UserID] FOREIGN KEY([UserID])
REFERENCES [dbo].[User] ([UserID])
GO
ALTER TABLE [dbo].[FeedbackRatingAudit] CHECK CONSTRAINT [FK_FeedbackRatingAudit_UserID]
GO
ALTER TABLE [dbo].[Incident]  WITH CHECK ADD FOREIGN KEY([LocationID])
REFERENCES [dbo].[Location] ([LocationID])
GO
ALTER TABLE [dbo].[Incident]  WITH CHECK ADD FOREIGN KEY([UserID])
REFERENCES [dbo].[User] ([UserID])
GO
ALTER TABLE [dbo].[IncidentAudit]  WITH CHECK ADD  CONSTRAINT [FK_IncidentAudit_UserID] FOREIGN KEY([UserID])
REFERENCES [dbo].[User] ([UserID])
GO
ALTER TABLE [dbo].[IncidentAudit] CHECK CONSTRAINT [FK_IncidentAudit_UserID]
GO
ALTER TABLE [dbo].[IncidentHistory]  WITH CHECK ADD FOREIGN KEY([IncidentID])
REFERENCES [dbo].[Incident] ([IncidentID])
GO
ALTER TABLE [dbo].[IncidentHistory]  WITH CHECK ADD FOREIGN KEY([UserID])
REFERENCES [dbo].[User] ([UserID])
GO
ALTER TABLE [dbo].[IncidentHistoryAudit]  WITH CHECK ADD  CONSTRAINT [FK_IncidentHistoryAudit_UserID] FOREIGN KEY([UserID])
REFERENCES [dbo].[User] ([UserID])
GO
ALTER TABLE [dbo].[IncidentHistoryAudit] CHECK CONSTRAINT [FK_IncidentHistoryAudit_UserID]
GO
ALTER TABLE [dbo].[LanguageSupportAudit]  WITH CHECK ADD  CONSTRAINT [FK_LanguageSupportAudit_UserID] FOREIGN KEY([UserID])
REFERENCES [dbo].[User] ([UserID])
GO
ALTER TABLE [dbo].[LanguageSupportAudit] CHECK CONSTRAINT [FK_LanguageSupportAudit_UserID]
GO
ALTER TABLE [dbo].[LocationAudit]  WITH CHECK ADD  CONSTRAINT [FK_LocationAudit_UserID] FOREIGN KEY([UserID])
REFERENCES [dbo].[User] ([UserID])
GO
ALTER TABLE [dbo].[LocationAudit] CHECK CONSTRAINT [FK_LocationAudit_UserID]
GO
ALTER TABLE [dbo].[Report]  WITH CHECK ADD FOREIGN KEY([LocationID])
REFERENCES [dbo].[Location] ([LocationID])
GO
ALTER TABLE [dbo].[Report]  WITH CHECK ADD FOREIGN KEY([UserID])
REFERENCES [dbo].[User] ([UserID])
GO
ALTER TABLE [dbo].[ReportAudit]  WITH CHECK ADD  CONSTRAINT [FK_ReportAudit_UserID] FOREIGN KEY([UserID])
REFERENCES [dbo].[User] ([UserID])
GO
ALTER TABLE [dbo].[ReportAudit] CHECK CONSTRAINT [FK_ReportAudit_UserID]
GO
ALTER TABLE [dbo].[SafetyTips]  WITH CHECK ADD  CONSTRAINT [FK_SafetyTips_User] FOREIGN KEY([UserID])
REFERENCES [dbo].[User] ([UserID])
GO
ALTER TABLE [dbo].[SafetyTips] CHECK CONSTRAINT [FK_SafetyTips_User]
GO
ALTER TABLE [dbo].[SafetyTipsAudit]  WITH CHECK ADD  CONSTRAINT [FK_SafetyTipsAudit_UserID] FOREIGN KEY([UserID])
REFERENCES [dbo].[User] ([UserID])
GO
ALTER TABLE [dbo].[SafetyTipsAudit] CHECK CONSTRAINT [FK_SafetyTipsAudit_UserID]
GO
ALTER TABLE [dbo].[User]  WITH CHECK ADD FOREIGN KEY([RoleID])
REFERENCES [dbo].[UserRole] ([UserRoleID])
GO
ALTER TABLE [dbo].[UserAudit]  WITH CHECK ADD  CONSTRAINT [FK_UserAudit_UserID] FOREIGN KEY([UserID])
REFERENCES [dbo].[User] ([UserID])
GO
ALTER TABLE [dbo].[UserAudit] CHECK CONSTRAINT [FK_UserAudit_UserID]
GO
ALTER TABLE [dbo].[UserDetails]  WITH CHECK ADD FOREIGN KEY([UserID])
REFERENCES [dbo].[User] ([UserID])
GO
ALTER TABLE [dbo].[UserDetailsAudit]  WITH CHECK ADD  CONSTRAINT [FK_UserDetailsAudit_UserID] FOREIGN KEY([UserID])
REFERENCES [dbo].[User] ([UserID])
GO
ALTER TABLE [dbo].[UserDetailsAudit] CHECK CONSTRAINT [FK_UserDetailsAudit_UserID]
GO
ALTER TABLE [dbo].[UserRoleAudit]  WITH CHECK ADD  CONSTRAINT [FK_UserRoleAudit_UserID] FOREIGN KEY([UserID])
REFERENCES [dbo].[User] ([UserID])
GO
ALTER TABLE [dbo].[UserRoleAudit] CHECK CONSTRAINT [FK_UserRoleAudit_UserID]
GO
ALTER TABLE [dbo].[UserDetails]  WITH CHECK ADD CHECK  (([Gender]='Other' OR [Gender]='Female' OR [Gender]='Male'))
GO
USE [master]
GO
ALTER DATABASE [PersonalSafetyDatabase] SET  READ_WRITE 
GO
