USE [master]
GO
/****** Object:  Database [NetworxDb]    Script Date: 1/22/2023 8:03:19 PM ******/
CREATE DATABASE [NetworxDb]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'NetworxDb', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\NetworxDb.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'NetworxDb_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\NetworxDb_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [NetworxDb] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [NetworxDb].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [NetworxDb] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [NetworxDb] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [NetworxDb] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [NetworxDb] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [NetworxDb] SET ARITHABORT OFF 
GO
ALTER DATABASE [NetworxDb] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [NetworxDb] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [NetworxDb] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [NetworxDb] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [NetworxDb] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [NetworxDb] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [NetworxDb] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [NetworxDb] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [NetworxDb] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [NetworxDb] SET  DISABLE_BROKER 
GO
ALTER DATABASE [NetworxDb] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [NetworxDb] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [NetworxDb] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [NetworxDb] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [NetworxDb] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [NetworxDb] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [NetworxDb] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [NetworxDb] SET RECOVERY FULL 
GO
ALTER DATABASE [NetworxDb] SET  MULTI_USER 
GO
ALTER DATABASE [NetworxDb] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [NetworxDb] SET DB_CHAINING OFF 
GO
ALTER DATABASE [NetworxDb] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [NetworxDb] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [NetworxDb] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [NetworxDb] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'NetworxDb', N'ON'
GO
ALTER DATABASE [NetworxDb] SET QUERY_STORE = OFF
GO
USE [NetworxDb]
GO
/****** Object:  Table [dbo].[tbl_employee_m]    Script Date: 1/22/2023 8:03:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_employee_m](
	[Id] [nvarchar](256) NOT NULL,
	[EmployeeId] [int] NOT NULL,
	[FirstName] [nvarchar](50) NULL,
	[LastName] [nvarchar](50) NULL,
	[Email] [nvarchar](500) NULL,
	[EmployeeStatusId] [nvarchar](256) NULL,
	[IsAdmin] [bit] NOT NULL,
	[IsActive] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_employee_status_m]    Script Date: 1/22/2023 8:03:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_employee_status_m](
	[Id] [nvarchar](256) NOT NULL,
	[Name] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_user_login_t]    Script Date: 1/22/2023 8:03:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_user_login_t](
	[Id] [nvarchar](256) NOT NULL,
	[EmployeeId] [nvarchar](256) NOT NULL,
	[UserName] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
	[IsActive] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[tbl_employee_m] ([Id], [EmployeeId], [FirstName], [LastName], [Email], [EmployeeStatusId], [IsAdmin], [IsActive]) VALUES (N'168c4927-5cc8-4f11-bc39-7479e40b771d', 43434, N'sdsd', N'sas', N'sdsdsdsa', N'743B6CAB-760B-43B0-9C19-99B30BF35203', 0, 0)
INSERT [dbo].[tbl_employee_m] ([Id], [EmployeeId], [FirstName], [LastName], [Email], [EmployeeStatusId], [IsAdmin], [IsActive]) VALUES (N'1cdad6e0-fd2d-45af-946f-13fa9bab3b5d', 4343, N'assa', N'dada', N'dadad', N'743B6CAB-760B-43B0-9C19-99B30BF35203', 0, 1)
INSERT [dbo].[tbl_employee_m] ([Id], [EmployeeId], [FirstName], [LastName], [Email], [EmployeeStatusId], [IsAdmin], [IsActive]) VALUES (N'43CD8D6A-A82D-49FD-8336-FCB5E964A0C4', 1002, N'Florian', N'Blines', N'florian.bline@networx.com', N'134B77E9-9D39-44F4-9960-6624DDDEE33B', 1, 1)
INSERT [dbo].[tbl_employee_m] ([Id], [EmployeeId], [FirstName], [LastName], [Email], [EmployeeStatusId], [IsAdmin], [IsActive]) VALUES (N'6e3f9a5c-cf87-4dc6-aeff-2b49358ed831', 3434, N'dsds', N'ddd', N'sdsd', N'134B77E9-9D39-44F4-9960-6624DDDEE33B', 0, 0)
INSERT [dbo].[tbl_employee_m] ([Id], [EmployeeId], [FirstName], [LastName], [Email], [EmployeeStatusId], [IsAdmin], [IsActive]) VALUES (N'73bce835-85b6-4269-9a39-5621c739a73a', 33, N'sds', N'dsd', N'sdsd', N'134B77E9-9D39-44F4-9960-6624DDDEE33B', 0, 0)
INSERT [dbo].[tbl_employee_m] ([Id], [EmployeeId], [FirstName], [LastName], [Email], [EmployeeStatusId], [IsAdmin], [IsActive]) VALUES (N'7b3b5a11-c818-42c9-9eb0-4910eed978a3', 434, N'sfdf', N'dfdf', N'fdfd', N'134B77E9-9D39-44F4-9960-6624DDDEE33B', 0, 0)
INSERT [dbo].[tbl_employee_m] ([Id], [EmployeeId], [FirstName], [LastName], [Email], [EmployeeStatusId], [IsAdmin], [IsActive]) VALUES (N'8650DE26-7BF3-4DA4-81BF-7051AD19AE59', 1003, N'Robin', N'Pearson', N'robin.pearson@networx.com', N'134B77E9-9D39-44F4-9960-6624DDDEE33B', 0, 1)
INSERT [dbo].[tbl_employee_m] ([Id], [EmployeeId], [FirstName], [LastName], [Email], [EmployeeStatusId], [IsAdmin], [IsActive]) VALUES (N'8A012DEC-1172-4F7B-B336-F3835391BED4', 1004, N'Gayle', N'Morgell', N'gayle.morgell@networx.com', N'134B77E9-9D39-44F4-9960-6624DDDEE33B', 0, 0)
INSERT [dbo].[tbl_employee_m] ([Id], [EmployeeId], [FirstName], [LastName], [Email], [EmployeeStatusId], [IsAdmin], [IsActive]) VALUES (N'a30bba3d-947c-46b1-ad17-e5041227ff2a', 345, N'chdf', N'hjghj', N'hghjg', N'134B77E9-9D39-44F4-9960-6624DDDEE33B', 0, 0)
INSERT [dbo].[tbl_employee_m] ([Id], [EmployeeId], [FirstName], [LastName], [Email], [EmployeeStatusId], [IsAdmin], [IsActive]) VALUES (N'abbdd14b-2137-4d82-8614-b15f32ecfb54', 383, N'Sudhanshu', N'Jain', N'sudhanshu.jain@gmail.com', N'876D5F60-F032-4010-A4E3-6DC2FB490B6C', 0, 1)
INSERT [dbo].[tbl_employee_m] ([Id], [EmployeeId], [FirstName], [LastName], [Email], [EmployeeStatusId], [IsAdmin], [IsActive]) VALUES (N'b98016d0-4fb7-475f-b311-523b15361948', 1002, N'Gayle', N'Morgell', N'gayle.morgell@networx.com', N'134B77E9-9D39-44F4-9960-6624DDDEE33B', 0, 1)
INSERT [dbo].[tbl_employee_m] ([Id], [EmployeeId], [FirstName], [LastName], [Email], [EmployeeStatusId], [IsAdmin], [IsActive]) VALUES (N'd7e524a6-6786-4e9d-a976-50dca679b549', 0, N'432423', N'412421', N'1244124', N'134B77E9-9D39-44F4-9960-6624DDDEE33B', 0, 0)
GO
INSERT [dbo].[tbl_employee_status_m] ([Id], [Name]) VALUES (N'134B77E9-9D39-44F4-9960-6624DDDEE33B', N'Active')
INSERT [dbo].[tbl_employee_status_m] ([Id], [Name]) VALUES (N'743B6CAB-760B-43B0-9C19-99B30BF35203', N'Exit')
INSERT [dbo].[tbl_employee_status_m] ([Id], [Name]) VALUES (N'876D5F60-F032-4010-A4E3-6DC2FB490B6C', N'Recruited')
GO
INSERT [dbo].[tbl_user_login_t] ([Id], [EmployeeId], [UserName], [Password], [IsActive]) VALUES (N'28C4511B-53C7-496B-BB90-E02844DEFB4A', N'8650DE26-7BF3-4DA4-81BF-7051AD19AE59', N'Robin.Peterson', N'Welcome@1', 1)
INSERT [dbo].[tbl_user_login_t] ([Id], [EmployeeId], [UserName], [Password], [IsActive]) VALUES (N'E263F031-56A5-4423-ADB2-C65422CCED4A', N'43CD8D6A-A82D-49FD-8336-FCB5E964A0C4', N'Florian.Bline', N'Welcome@1', 1)
GO
ALTER TABLE [dbo].[tbl_employee_m] ADD  CONSTRAINT [DF_tbl_employee_m_IsAdmin]  DEFAULT ((0)) FOR [IsAdmin]
GO
ALTER TABLE [dbo].[tbl_employee_m] ADD  CONSTRAINT [DF_tbl_employee_m_IsActive]  DEFAULT ((1)) FOR [IsActive]
GO
ALTER TABLE [dbo].[tbl_user_login_t] ADD  DEFAULT ((0)) FOR [IsActive]
GO
ALTER TABLE [dbo].[tbl_employee_m]  WITH CHECK ADD FOREIGN KEY([EmployeeStatusId])
REFERENCES [dbo].[tbl_employee_status_m] ([Id])
GO
ALTER TABLE [dbo].[tbl_user_login_t]  WITH CHECK ADD FOREIGN KEY([EmployeeId])
REFERENCES [dbo].[tbl_employee_m] ([Id])
GO
/****** Object:  StoredProcedure [dbo].[usp_CheckAuthentication]    Script Date: 1/22/2023 8:03:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[usp_CheckAuthentication] 
	-- Add the parameters for the stored procedure here
	@UserName nvarchar(50),
	@Password nvarchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

CREATE TABLE #EmployeeTable (
	Id nvarchar(256), 
	IsAdmin nvarchar(50)
)
    -- Insert statements for procedure here
	INSERT INTO #EmployeeTable 
	SELECT e.Id, e.IsAdmin FROM tbl_user_login_t ut 
	INNER JOIN tbl_employee_m e ON ut.EmployeeId = e.Id
	WHERE UserName= @UserName AND Password = @Password and ut.IsActive=1

	SELECT * FROM #EmployeeTable
	DROP TABLE #EmployeeTable
END
GO
USE [master]
GO
ALTER DATABASE [NetworxDb] SET  READ_WRITE 
GO
