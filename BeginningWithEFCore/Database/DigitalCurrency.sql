CREATE DATABASE DigitalCurrency;
GO
USE DigitalCurrency;
GO

CREATE TABLE [dbo].[Wallets](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Holder] [varchar](50) NOT NULL,
	[Balance] [decimal](18, 0) NULL,
 CONSTRAINT [PK_Wallets] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Wallets] ON 
GO
INSERT [dbo].[Wallets] ([Id], [Holder], [Balance]) VALUES (1, N'Reem', CAST(8000 AS Decimal(18, 0)))
GO
INSERT [dbo].[Wallets] ([Id], [Holder], [Balance]) VALUES (2, N'Sameh', CAST(6000 AS Decimal(18, 0)))
GO
INSERT [dbo].[Wallets] ([Id], [Holder], [Balance]) VALUES (3, N'Menna', CAST(8500 AS Decimal(18, 0)))
GO
INSERT [dbo].[Wallets] ([Id], [Holder], [Balance]) VALUES (4, N'Menna', CAST(5500 AS Decimal(18, 0)))
GO
INSERT [dbo].[Wallets] ([Id], [Holder], [Balance]) VALUES (5, N'Salah', CAST(2500 AS Decimal(18, 0)))
GO
INSERT [dbo].[Wallets] ([Id], [Holder], [Balance]) VALUES (6, N'Abeer', CAST(8500 AS Decimal(18, 0)))
GO
INSERT [dbo].[Wallets] ([Id], [Holder], [Balance]) VALUES (7, N'Sara', CAST(8000 AS Decimal(18, 0)))
GO
INSERT [dbo].[Wallets] ([Id], [Holder], [Balance]) VALUES (8, N'Lina', CAST(12000 AS Decimal(18, 0)))
GO
INSERT [dbo].[Wallets] ([Id], [Holder], [Balance]) VALUES (9, N'Reem', CAST(23000 AS Decimal(18, 0)))
GO
INSERT [dbo].[Wallets] ([Id], [Holder], [Balance]) VALUES (10, N'Ayman', CAST(16000 AS Decimal(18, 0)))
GO
INSERT [dbo].[Wallets] ([Id], [Holder], [Balance]) VALUES (12, N'Jasem', CAST(1000 AS Decimal(18, 0)))
GO
INSERT [dbo].[Wallets] ([Id], [Holder], [Balance]) VALUES (13, N'Jameel', CAST(1000 AS Decimal(18, 0)))
GO
SET IDENTITY_INSERT [dbo].[Wallets] OFF
GO