USE [FinalYearProjectDb]
GO
/****** Object:  Table [dbo].[Catgories]    Script Date: 6/16/2020 3:22:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Catgories](
	[Cat_Id] [int] IDENTITY(1,1) NOT NULL,
	[Cat_Name] [varchar](50) NULL,
	[Cat_IsActive] [tinyint] NULL,
 CONSTRAINT [PK_Catgories] PRIMARY KEY CLUSTERED 
(
	[Cat_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[RealProducts]    Script Date: 6/16/2020 3:22:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[RealProducts](
	[P_ID] [int] IDENTITY(1,1) NOT NULL,
	[P_Unit] [varchar](50) NULL,
	[P_CatID] [int] NOT NULL,
	[P_Name] [varchar](50) NULL,
	[P_Barcode] [nvarchar](100) NOT NULL,
	[P_Power] [nvarchar](50) NULL,
	[P_Price] [money] NOT NULL,
	[P_SalePrice] [money] NULL,
	[P_Qty] [int] NULL,
	[P_RackNo] [varchar](50) NULL,
	[P_Date] [date] NULL,
 CONSTRAINT [PK_RealProducts] PRIMARY KEY CLUSTERED 
(
	[P_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ReturnS]    Script Date: 6/16/2020 3:22:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ReturnS](
	[SessionID] [bigint] NULL,
	[ReturnDate] [date] NULL,
	[ReturnBy] [varchar](50) NULL,
	[ReturnProductID] [varchar](50) NULL,
	[ReturnQty] [bigint] NULL,
	[ReturnAmount] [money] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SalesTable]    Script Date: 6/16/2020 3:22:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SalesTable](
	[SessionID] [int] NULL,
	[Date] [date] NULL,
	[PCode] [int] NULL,
	[P_Name] [int] NULL,
	[P_Price] [float] NULL,
	[Qty] [int] NULL,
	[Amount] [float] NULL,
	[SubTotal] [float] NULL,
	[Dis] [float] NULL,
	[NetTotal] [float] NULL,
	[Pay] [float] NULL,
	[Blance] [float] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Supplier]    Script Date: 6/16/2020 3:22:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Supplier](
	[S_ID] [int] IDENTITY(1,1) NOT NULL,
	[S_Name] [varchar](100) NULL,
	[S_EMail] [varchar](50) NULL,
	[S_Phone] [varchar](30) NULL,
	[S_Address] [varchar](50) NULL,
	[S_Status] [tinyint] NULL,
 CONSTRAINT [PK_Supplier] PRIMARY KEY CLUSTERED 
(
	[S_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TableHeaderData]    Script Date: 6/16/2020 3:22:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TableHeaderData](
	[BillNo] [int] NOT NULL,
	[BillDate] [date] NULL,
	[SubTotal] [money] NULL,
	[DIS] [money] NULL,
	[NetTotal] [money] NULL,
	[NetPay] [money] NULL,
	[Blance] [money] NULL,
 CONSTRAINT [PK_TableHeaderData] PRIMARY KEY CLUSTERED 
(
	[BillNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TablePurchaseHeaderData]    Script Date: 6/16/2020 3:22:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TablePurchaseHeaderData](
	[PID] [int] IDENTITY(1,1) NOT NULL,
	[BillNo] [int] NULL,
	[BillDate] [date] NULL,
	[BillAmount] [money] NULL,
	[DisAmount] [money] NULL,
	[NetTotal] [money] NULL,
	[NetPay] [money] NULL,
	[Blance] [money] NULL,
	[SupplierName] [nvarchar](50) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TablePurchaseRowData]    Script Date: 6/16/2020 3:22:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TablePurchaseRowData](
	[ProductName] [varchar](100) NULL,
	[Price] [money] NULL,
	[Qty] [int] NULL,
	[Amount] [money] NULL,
	[BillNo] [int] NULL,
	[Date] [date] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TableRowData]    Script Date: 6/16/2020 3:22:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TableRowData](
	[SessionID] [int] NULL,
	[ItemCode] [varchar](50) NULL,
	[ProductName] [varchar](100) NULL,
	[Price] [money] NULL,
	[Qty] [int] NULL,
	[Amount] [money] NULL,
	[BillNo] [int] NULL,
	[Date] [date] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[UserTable]    Script Date: 6/16/2020 3:22:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[UserTable](
	[UserId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](200) NULL,
	[UserType] [varchar](50) NULL,
	[UserName] [varchar](50) NULL,
	[Password] [varchar](50) NULL,
	[Contact] [varchar](50) NULL,
	[Address] [text] NULL,
	[Gender] [varchar](50) NULL,
	[UserStatus] [tinyint] NULL CONSTRAINT [DF_UserTable_UserStatus]  DEFAULT ((1)),
 CONSTRAINT [PK_UserTable] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  View [dbo].[PurchaseInvoice]    Script Date: 6/16/2020 3:22:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create View [dbo].[PurchaseInvoice]
AS
Select
TPH.BillNo AS 'Bill No',
TPH.BillDate AS 'Date',
TPR.ProductName AS 'P Name',
TPR.Price AS 'Price',
TPR.Qty AS 'QTY',
TPR.Amount AS 'Amount',
TPH.BillAmount AS 'Sub Total',
TPH.DisAmount AS 'Dis',
TPH.NetTotal AS 'Net Total',
TPH.NetPay AS 'Net Pay',
TPH.Blance AS 'Blance'
From TablePurchaseRowData TPR
inner Join
TablePurchaseHeaderData TPH
on TPR.BillNo =TPH.BillNo
Where TPH.BillNo='2'
GO
SET IDENTITY_INSERT [dbo].[Catgories] ON 

GO
INSERT [dbo].[Catgories] ([Cat_Id], [Cat_Name], [Cat_IsActive]) VALUES (7, N'clod drinks', 0)
GO
INSERT [dbo].[Catgories] ([Cat_Id], [Cat_Name], [Cat_IsActive]) VALUES (8, N'Medicine', 1)
GO
SET IDENTITY_INSERT [dbo].[Catgories] OFF
GO
SET IDENTITY_INSERT [dbo].[RealProducts] ON 

GO
INSERT [dbo].[RealProducts] ([P_ID], [P_Unit], [P_CatID], [P_Name], [P_Barcode], [P_Power], [P_Price], [P_SalePrice], [P_Qty], [P_RackNo], [P_Date]) VALUES (1, N'Mg', 8, N'Syrp', N'123', N'3Mg', 100.0000, 80.0000, 98, N'Abc', CAST(N'2021-06-16' AS Date))
GO
INSERT [dbo].[RealProducts] ([P_ID], [P_Unit], [P_CatID], [P_Name], [P_Barcode], [P_Power], [P_Price], [P_SalePrice], [P_Qty], [P_RackNo], [P_Date]) VALUES (3, N'Mg', 8, N'Panadol', N'1234', N'3Mg', 100.0000, 80.0000, 100, N'Abc', CAST(N'2021-06-16' AS Date))
GO
INSERT [dbo].[RealProducts] ([P_ID], [P_Unit], [P_CatID], [P_Name], [P_Barcode], [P_Power], [P_Price], [P_SalePrice], [P_Qty], [P_RackNo], [P_Date]) VALUES (5, N'Mg', 8, N'Injection', N'1', N'3Mg', 100.0000, 200.0000, 97, N'Abc', CAST(N'2021-06-16' AS Date))
GO
SET IDENTITY_INSERT [dbo].[RealProducts] OFF
GO
INSERT [dbo].[ReturnS] ([SessionID], [ReturnDate], [ReturnBy], [ReturnProductID], [ReturnQty], [ReturnAmount]) VALUES (3, CAST(N'2020-06-16' AS Date), N'User', N'5', 1, 180.0000)
GO
INSERT [dbo].[ReturnS] ([SessionID], [ReturnDate], [ReturnBy], [ReturnProductID], [ReturnQty], [ReturnAmount]) VALUES (1, CAST(N'2020-06-16' AS Date), N'User', N'5', 2, 500.0000)
GO
INSERT [dbo].[ReturnS] ([SessionID], [ReturnDate], [ReturnBy], [ReturnProductID], [ReturnQty], [ReturnAmount]) VALUES (1, CAST(N'2020-06-16' AS Date), N'User', N'1', 2, 500.0000)
GO
INSERT [dbo].[ReturnS] ([SessionID], [ReturnDate], [ReturnBy], [ReturnProductID], [ReturnQty], [ReturnAmount]) VALUES (1, CAST(N'2020-06-16' AS Date), N'User', N'1', 23, 1800.0000)
GO
INSERT [dbo].[ReturnS] ([SessionID], [ReturnDate], [ReturnBy], [ReturnProductID], [ReturnQty], [ReturnAmount]) VALUES (1, CAST(N'2020-06-16' AS Date), N'User', N'5', 23, 4590.0000)
GO
INSERT [dbo].[ReturnS] ([SessionID], [ReturnDate], [ReturnBy], [ReturnProductID], [ReturnQty], [ReturnAmount]) VALUES (1, CAST(N'2020-06-16' AS Date), N'User', N'5', 23, 4577.0000)
GO
SET IDENTITY_INSERT [dbo].[Supplier] ON 

GO
INSERT [dbo].[Supplier] ([S_ID], [S_Name], [S_EMail], [S_Phone], [S_Address], [S_Status]) VALUES (9, N'C Companyes1', N'Mail', N'0301', N'jbd', 1)
GO
INSERT [dbo].[Supplier] ([S_ID], [S_Name], [S_EMail], [S_Phone], [S_Address], [S_Status]) VALUES (11, N'C Companyes12', N'Mail', N'0301', N'jbd', 1)
GO
SET IDENTITY_INSERT [dbo].[Supplier] OFF
GO
SET IDENTITY_INSERT [dbo].[TablePurchaseHeaderData] ON 

GO
INSERT [dbo].[TablePurchaseHeaderData] ([PID], [BillNo], [BillDate], [BillAmount], [DisAmount], [NetTotal], [NetPay], [Blance], [SupplierName]) VALUES (42, 1, CAST(N'2020-06-05' AS Date), 6070.0000, NULL, 6000.0000, 10000.0000, 4000.0000, N'C Companyes1')
GO
INSERT [dbo].[TablePurchaseHeaderData] ([PID], [BillNo], [BillDate], [BillAmount], [DisAmount], [NetTotal], [NetPay], [Blance], [SupplierName]) VALUES (43, 2, CAST(N'2020-06-05' AS Date), 6070.0000, NULL, 6000.0000, 10000.0000, 4000.0000, N'C Companyes1')
GO
INSERT [dbo].[TablePurchaseHeaderData] ([PID], [BillNo], [BillDate], [BillAmount], [DisAmount], [NetTotal], [NetPay], [Blance], [SupplierName]) VALUES (44, 3, CAST(N'2020-06-05' AS Date), 6070.0000, NULL, 6000.0000, 10000.0000, 4000.0000, N'C Companyes1')
GO
INSERT [dbo].[TablePurchaseHeaderData] ([PID], [BillNo], [BillDate], [BillAmount], [DisAmount], [NetTotal], [NetPay], [Blance], [SupplierName]) VALUES (46, 4, CAST(N'2020-06-05' AS Date), 2070.0000, 70.0000, 2000.0000, 2000.0000, 0.0000, N'C Companyes1')
GO
INSERT [dbo].[TablePurchaseHeaderData] ([PID], [BillNo], [BillDate], [BillAmount], [DisAmount], [NetTotal], [NetPay], [Blance], [SupplierName]) VALUES (47, 5, CAST(N'2020-06-06' AS Date), 2070.0000, 3.0000, 2067.0000, 3000.0000, 933.0000, N'C Companyes1')
GO
INSERT [dbo].[TablePurchaseHeaderData] ([PID], [BillNo], [BillDate], [BillAmount], [DisAmount], [NetTotal], [NetPay], [Blance], [SupplierName]) VALUES (49, 6, CAST(N'2020-06-06' AS Date), 2070.0000, 70.0000, 2000.0000, 2000.0000, 0.0000, N'C Companyes1')
GO
INSERT [dbo].[TablePurchaseHeaderData] ([PID], [BillNo], [BillDate], [BillAmount], [DisAmount], [NetTotal], [NetPay], [Blance], [SupplierName]) VALUES (50, 7, CAST(N'2020-06-06' AS Date), 2070.0000, 70.0000, 2000.0000, 2000.0000, 0.0000, N'C Companyes1')
GO
INSERT [dbo].[TablePurchaseHeaderData] ([PID], [BillNo], [BillDate], [BillAmount], [DisAmount], [NetTotal], [NetPay], [Blance], [SupplierName]) VALUES (52, 8, CAST(N'2020-06-06' AS Date), 14490.0000, 90.0000, 14400.0000, 14440.0000, 40.0000, N'C Companyes1')
GO
INSERT [dbo].[TablePurchaseHeaderData] ([PID], [BillNo], [BillDate], [BillAmount], [DisAmount], [NetTotal], [NetPay], [Blance], [SupplierName]) VALUES (53, 9, CAST(N'2020-06-06' AS Date), 14490.0000, 90.0000, 14400.0000, 14440.0000, 40.0000, N'C Companyes1')
GO
INSERT [dbo].[TablePurchaseHeaderData] ([PID], [BillNo], [BillDate], [BillAmount], [DisAmount], [NetTotal], [NetPay], [Blance], [SupplierName]) VALUES (54, 10, CAST(N'2020-06-06' AS Date), 2070.0000, 70.0000, 2000.0000, 2000.0000, 0.0000, N'C Companyes1')
GO
INSERT [dbo].[TablePurchaseHeaderData] ([PID], [BillNo], [BillDate], [BillAmount], [DisAmount], [NetTotal], [NetPay], [Blance], [SupplierName]) VALUES (55, 11, CAST(N'2020-06-06' AS Date), 2070.0000, 70.0000, 2000.0000, 2000.0000, 0.0000, N'C Companyes1')
GO
INSERT [dbo].[TablePurchaseHeaderData] ([PID], [BillNo], [BillDate], [BillAmount], [DisAmount], [NetTotal], [NetPay], [Blance], [SupplierName]) VALUES (56, 12, CAST(N'2020-06-09' AS Date), 230.0000, 23.0000, 184.0000, 207.0000, 0.0000, N'C Companyes1')
GO
INSERT [dbo].[TablePurchaseHeaderData] ([PID], [BillNo], [BillDate], [BillAmount], [DisAmount], [NetTotal], [NetPay], [Blance], [SupplierName]) VALUES (57, 13, CAST(N'2020-06-10' AS Date), 230.0000, 30.0000, 200.0000, 200.0000, 0.0000, N'C Companyes1')
GO
INSERT [dbo].[TablePurchaseHeaderData] ([PID], [BillNo], [BillDate], [BillAmount], [DisAmount], [NetTotal], [NetPay], [Blance], [SupplierName]) VALUES (58, 14, CAST(N'2020-06-11' AS Date), 460.0000, 60.0000, 400.0000, 400.0000, 0.0000, N'C Companyes1')
GO
INSERT [dbo].[TablePurchaseHeaderData] ([PID], [BillNo], [BillDate], [BillAmount], [DisAmount], [NetTotal], [NetPay], [Blance], [SupplierName]) VALUES (59, 15, CAST(N'2020-06-16' AS Date), 40000.0000, 20.0000, 39980.0000, 39980.0000, 0.0000, N'')
GO
SET IDENTITY_INSERT [dbo].[TablePurchaseHeaderData] OFF
GO
INSERT [dbo].[TablePurchaseRowData] ([ProductName], [Price], [Qty], [Amount], [BillNo], [Date]) VALUES (N'injection', 90.0000, 23, 2070.0000, 1, CAST(N'2020-06-05' AS Date))
GO
INSERT [dbo].[TablePurchaseRowData] ([ProductName], [Price], [Qty], [Amount], [BillNo], [Date]) VALUES (N'panadol', 200.0000, 20, 4000.0000, 1, CAST(N'2020-06-05' AS Date))
GO
INSERT [dbo].[TablePurchaseRowData] ([ProductName], [Price], [Qty], [Amount], [BillNo], [Date]) VALUES (N'injection', 90.0000, 23, 2070.0000, 2, CAST(N'2020-06-05' AS Date))
GO
INSERT [dbo].[TablePurchaseRowData] ([ProductName], [Price], [Qty], [Amount], [BillNo], [Date]) VALUES (N'panadol', 200.0000, 20, 4000.0000, 2, CAST(N'2020-06-05' AS Date))
GO
INSERT [dbo].[TablePurchaseRowData] ([ProductName], [Price], [Qty], [Amount], [BillNo], [Date]) VALUES (N'injection', 90.0000, 23, 2070.0000, 3, CAST(N'2020-06-05' AS Date))
GO
INSERT [dbo].[TablePurchaseRowData] ([ProductName], [Price], [Qty], [Amount], [BillNo], [Date]) VALUES (N'panadol', 200.0000, 20, 4000.0000, 3, CAST(N'2020-06-05' AS Date))
GO
INSERT [dbo].[TablePurchaseRowData] ([ProductName], [Price], [Qty], [Amount], [BillNo], [Date]) VALUES (N'injection', 90.0000, 23, 2070.0000, 4, CAST(N'2020-06-05' AS Date))
GO
INSERT [dbo].[TablePurchaseRowData] ([ProductName], [Price], [Qty], [Amount], [BillNo], [Date]) VALUES (N'injection', 90.0000, 23, 2070.0000, 5, CAST(N'2020-06-06' AS Date))
GO
INSERT [dbo].[TablePurchaseRowData] ([ProductName], [Price], [Qty], [Amount], [BillNo], [Date]) VALUES (N'injection', 90.0000, 23, 2070.0000, 6, CAST(N'2020-06-06' AS Date))
GO
INSERT [dbo].[TablePurchaseRowData] ([ProductName], [Price], [Qty], [Amount], [BillNo], [Date]) VALUES (N'injection', 90.0000, 23, 2070.0000, 7, CAST(N'2020-06-06' AS Date))
GO
INSERT [dbo].[TablePurchaseRowData] ([ProductName], [Price], [Qty], [Amount], [BillNo], [Date]) VALUES (N'injection', 90.0000, 23, 2070.0000, 11, CAST(N'2020-06-06' AS Date))
GO
INSERT [dbo].[TablePurchaseRowData] ([ProductName], [Price], [Qty], [Amount], [BillNo], [Date]) VALUES (N'YYY', 10.0000, 23, 230.0000, 12, CAST(N'2020-06-09' AS Date))
GO
INSERT [dbo].[TablePurchaseRowData] ([ProductName], [Price], [Qty], [Amount], [BillNo], [Date]) VALUES (N'parastmol', 10.0000, 23, 230.0000, 13, CAST(N'2020-06-10' AS Date))
GO
INSERT [dbo].[TablePurchaseRowData] ([ProductName], [Price], [Qty], [Amount], [BillNo], [Date]) VALUES (N'parastmol', 20.0000, 23, 460.0000, 14, CAST(N'2020-06-11' AS Date))
GO
INSERT [dbo].[TablePurchaseRowData] ([ProductName], [Price], [Qty], [Amount], [BillNo], [Date]) VALUES (N'Syrp', 200.0000, 100, 20000.0000, 15, CAST(N'2020-06-16' AS Date))
GO
INSERT [dbo].[TablePurchaseRowData] ([ProductName], [Price], [Qty], [Amount], [BillNo], [Date]) VALUES (N'parastmol', 20.0000, 100, 20000.0000, 15, CAST(N'2020-06-16' AS Date))
GO
INSERT [dbo].[TablePurchaseRowData] ([ProductName], [Price], [Qty], [Amount], [BillNo], [Date]) VALUES (N'injection', 90.0000, 23, 2070.0000, 8, CAST(N'2020-06-06' AS Date))
GO
INSERT [dbo].[TablePurchaseRowData] ([ProductName], [Price], [Qty], [Amount], [BillNo], [Date]) VALUES (N'injection', 90.0000, 23, 2070.0000, 8, CAST(N'2020-06-06' AS Date))
GO
INSERT [dbo].[TablePurchaseRowData] ([ProductName], [Price], [Qty], [Amount], [BillNo], [Date]) VALUES (N'injection', 90.0000, 23, 2070.0000, 8, CAST(N'2020-06-06' AS Date))
GO
INSERT [dbo].[TablePurchaseRowData] ([ProductName], [Price], [Qty], [Amount], [BillNo], [Date]) VALUES (N'injection', 90.0000, 23, 2070.0000, 8, CAST(N'2020-06-06' AS Date))
GO
INSERT [dbo].[TablePurchaseRowData] ([ProductName], [Price], [Qty], [Amount], [BillNo], [Date]) VALUES (N'injection', 90.0000, 23, 2070.0000, 8, CAST(N'2020-06-06' AS Date))
GO
INSERT [dbo].[TablePurchaseRowData] ([ProductName], [Price], [Qty], [Amount], [BillNo], [Date]) VALUES (N'injection', 90.0000, 23, 2070.0000, 8, CAST(N'2020-06-06' AS Date))
GO
INSERT [dbo].[TablePurchaseRowData] ([ProductName], [Price], [Qty], [Amount], [BillNo], [Date]) VALUES (N'injection', 90.0000, 23, 2070.0000, 8, CAST(N'2020-06-06' AS Date))
GO
INSERT [dbo].[TablePurchaseRowData] ([ProductName], [Price], [Qty], [Amount], [BillNo], [Date]) VALUES (N'injection', 90.0000, 23, 2070.0000, 9, CAST(N'2020-06-06' AS Date))
GO
INSERT [dbo].[TablePurchaseRowData] ([ProductName], [Price], [Qty], [Amount], [BillNo], [Date]) VALUES (N'injection', 90.0000, 23, 2070.0000, 9, CAST(N'2020-06-06' AS Date))
GO
INSERT [dbo].[TablePurchaseRowData] ([ProductName], [Price], [Qty], [Amount], [BillNo], [Date]) VALUES (N'injection', 90.0000, 23, 2070.0000, 9, CAST(N'2020-06-06' AS Date))
GO
INSERT [dbo].[TablePurchaseRowData] ([ProductName], [Price], [Qty], [Amount], [BillNo], [Date]) VALUES (N'injection', 90.0000, 23, 2070.0000, 9, CAST(N'2020-06-06' AS Date))
GO
INSERT [dbo].[TablePurchaseRowData] ([ProductName], [Price], [Qty], [Amount], [BillNo], [Date]) VALUES (N'injection', 90.0000, 23, 2070.0000, 9, CAST(N'2020-06-06' AS Date))
GO
INSERT [dbo].[TablePurchaseRowData] ([ProductName], [Price], [Qty], [Amount], [BillNo], [Date]) VALUES (N'injection', 90.0000, 23, 2070.0000, 9, CAST(N'2020-06-06' AS Date))
GO
INSERT [dbo].[TablePurchaseRowData] ([ProductName], [Price], [Qty], [Amount], [BillNo], [Date]) VALUES (N'injection', 90.0000, 23, 2070.0000, 9, CAST(N'2020-06-06' AS Date))
GO
INSERT [dbo].[TablePurchaseRowData] ([ProductName], [Price], [Qty], [Amount], [BillNo], [Date]) VALUES (N'injection', 90.0000, 23, 2070.0000, 10, CAST(N'2020-06-06' AS Date))
GO
SET IDENTITY_INSERT [dbo].[UserTable] ON 

GO
INSERT [dbo].[UserTable] ([UserId], [Name], [UserType], [UserName], [Password], [Contact], [Address], [Gender], [UserStatus]) VALUES (1232, N'Haseeb Ahmad', N'Admin', N'Haseeb 123', N'123123', N'000', N'nill', N'Male', 1)
GO
INSERT [dbo].[UserTable] ([UserId], [Name], [UserType], [UserName], [Password], [Contact], [Address], [Gender], [UserStatus]) VALUES (1233, N'Haseeb Ahmad Majoka', N'Admin', N'Haseeb 123', N'123123', N'000', N'nill', N'Male', 1)
GO
INSERT [dbo].[UserTable] ([UserId], [Name], [UserType], [UserName], [Password], [Contact], [Address], [Gender], [UserStatus]) VALUES (1234, N'Bushra', N'Admin', N'Haseeb 123', N'123123', N'000', N'nill', N'Male', 1)
GO
SET IDENTITY_INSERT [dbo].[UserTable] OFF
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UniqueBarcode]    Script Date: 6/16/2020 3:22:43 PM ******/
ALTER TABLE [dbo].[RealProducts] ADD  CONSTRAINT [UniqueBarcode] UNIQUE NONCLUSTERED 
(
	[P_Barcode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [UniqueId]    Script Date: 6/16/2020 3:22:43 PM ******/
ALTER TABLE [dbo].[RealProducts] ADD  CONSTRAINT [UniqueId] UNIQUE NONCLUSTERED 
(
	[P_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UniqueName]    Script Date: 6/16/2020 3:22:43 PM ******/
ALTER TABLE [dbo].[RealProducts] ADD  CONSTRAINT [UniqueName] UNIQUE NONCLUSTERED 
(
	[P_Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UniqueSupplier]    Script Date: 6/16/2020 3:22:43 PM ******/
ALTER TABLE [dbo].[Supplier] ADD  CONSTRAINT [UniqueSupplier] UNIQUE NONCLUSTERED 
(
	[S_Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [UniqueBillNo]    Script Date: 6/16/2020 3:22:43 PM ******/
ALTER TABLE [dbo].[TablePurchaseHeaderData] ADD  CONSTRAINT [UniqueBillNo] UNIQUE NONCLUSTERED 
(
	[BillNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[RealProducts]  WITH CHECK ADD  CONSTRAINT [FK__RealProdu__P_Cat__1332DBDC] FOREIGN KEY([P_CatID])
REFERENCES [dbo].[Catgories] ([Cat_Id])
GO
ALTER TABLE [dbo].[RealProducts] CHECK CONSTRAINT [FK__RealProdu__P_Cat__1332DBDC]
GO
/****** Object:  StoredProcedure [dbo].[DecreaseProductQty]    Script Date: 6/16/2020 3:22:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[DecreaseProductQty]
@P_Qty int,
@P_ID varchar(50)
AS
Begin
Update RealProducts
Set
P_Qty=P_Qty-@P_Qty
Where P_ID=@P_ID
End
GO
/****** Object:  StoredProcedure [dbo].[DeleteCatagories]    Script Date: 6/16/2020 3:22:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[DeleteCatagories]
@Cat_Id int
AS
begin
Delete From Catgories
Where Cat_Id=@Cat_Id
end
GO
/****** Object:  StoredProcedure [dbo].[DeleteProducts]    Script Date: 6/16/2020 3:22:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[DeleteProducts]
@P_ID varchar(50)
AS
Begin
Delete from RealProducts 
where P_ID=@P_ID
End
GO
/****** Object:  StoredProcedure [dbo].[DeleteSuppliers]    Script Date: 6/16/2020 3:22:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[DeleteSuppliers]
@S_ID int
AS
Begin
Delete From Supplier
Where S_ID=@S_ID
End
GO
/****** Object:  StoredProcedure [dbo].[DeleteUserS]    Script Date: 6/16/2020 3:22:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create Procedure [dbo].[DeleteUserS]
@UserId int
As
Begin
Delete From UserTable where UserId=@UserId
End
GO
/****** Object:  StoredProcedure [dbo].[GetAllPurchaseReport]    Script Date: 6/16/2020 3:22:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[GetAllPurchaseReport]
@FromBillDate date,
@ToBillDate date
AS
Begin
Select
PHD.BillNo,
PHD.BillDate,
PRD.ProductName,
PRD.Price,
PRD.Qty,
PRD.Amount,
PHD.BillAmount,
PHD.DisAmount,
PHD.NetTotal,
PHD.NetPay,
PHD.Blance,
PHD.SupplierName
 from TablePurchaseRowData PRD
 Inner Join
 TablePurchaseHeaderData PHD
 On
 PHD.BillNo=PRD.BillNo
 Where PHD.BillDate
  Between
  @FromBillDate
  And
  @ToBillDate 
End
GO
/****** Object:  StoredProcedure [dbo].[GetAllSaleReport]    Script Date: 6/16/2020 3:22:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[GetAllSaleReport]
@FromBillDate date,
@ToBillDate date
AS
Begin
Select
THD.BillDate,
THD.BillNo,
TRD.ItemCode,
TRD.ProductName,
TRD.Price,
TRD.Qty,
TRD.Amount,
THD.SubTotal,
THD.DIS,
THD.NetTotal,
THD.NetPay,
THD.Blance
 from TableRowData TRD
 Inner Join
 TableHeaderData THD
 On
 THD.BillNo=TRD.BillNo
 Where THD.BillDate
 Between
 @FromBillDate
 And
 @ToBillDate
End
GO
/****** Object:  StoredProcedure [dbo].[GetCatagories]    Script Date: 6/16/2020 3:22:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[GetCatagories]
AS
begin
Select
c.Cat_Id As 'ID',
c.Cat_Name As 'Catagory',
Case when(c.Cat_IsActive =1) then 'Yes' else 'No' end As 'Status'
 From Catgories c
Order by c.Cat_Name asc
end
GO
/****** Object:  StoredProcedure [dbo].[GetCatagoriesList]    Script Date: 6/16/2020 3:22:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[GetCatagoriesList]
AS
begin
Select
c.Cat_Id As 'ID',
c.Cat_Name As 'Catagory'
 From Catgories c
 where
 c.Cat_IsActive=1
Order by c.Cat_Name asc
end
GO
/****** Object:  StoredProcedure [dbo].[GetProducts]    Script Date: 6/16/2020 3:22:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[GetProducts]
AS
Begin
select
p.P_ID AS 'Product ID',
p.P_Unit AS 'Unit',
c.Cat_Name AS 'Catagory',
c.Cat_Id As 'Catagory ID',
p.P_Barcode As 'Barcode',
p.P_Name As 'Name',
p.P_Power AS 'Power',
p.P_Price As 'Price',
p.P_SalePrice AS 'Sale Price',
p.P_Qty AS 'Qty',
p.P_RackNo AS 'Rack',
FORMAT( p.P_Date,'dd-MMM-yyyy') AS 'Date'
from RealProducts p
inner join
Catgories c
on c.Cat_Id=p.P_CatID
End
GO
/****** Object:  StoredProcedure [dbo].[GetProductsName]    Script Date: 6/16/2020 3:22:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[GetProductsName]
As
Begin
select
 P.P_Name AS 'Name',
 P.P_ID AS 'ID'
from RealProducts P
Order by P.P_Name ASC
End
GO
/****** Object:  StoredProcedure [dbo].[GetProductsThroughBarcode]    Script Date: 6/16/2020 3:22:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[GetProductsThroughBarcode]
@P_Barcode nvarchar(100)
As
begin
select
P.P_ID As 'ID',
P.P_Name As 'Product Name',
P.P_Price As 'Price',
P.P_Qty AS 'Qty'
 from RealProducts P
 Where P.P_Barcode=@P_Barcode
End
GO
/****** Object:  StoredProcedure [dbo].[GetProductsThroughProductName]    Script Date: 6/16/2020 3:22:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[GetProductsThroughProductName]
@P_Name varchar(50)
As
begin
select
P.P_ID As 'ID',
P.P_SalePrice As 'Price',
P.P_Qty AS 'Qty'
 from RealProducts P
 Where p.P_Name=@P_Name
End
GO
/****** Object:  StoredProcedure [dbo].[GetPurchaseDetails]    Script Date: 6/16/2020 3:22:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[GetPurchaseDetails]
@FromBillDate date,
@ToBillDate date
AS
Begin
Select
BillNo As 'Invoice No',
BillDate AS 'Date',
BillAmount As 'Sub Total',
DisAmount As 'Dis',
NetTotal As 'Net Total',
SupplierName AS 'Supplier Name'
 from TablePurchaseHeaderData
 Where BillDate Between @FromBillDate And @ToBillDate
  Order By BillNo Asc
End
GO
/****** Object:  StoredProcedure [dbo].[GetSaleBillNo]    Script Date: 6/16/2020 3:22:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[GetSaleBillNo]
AS
Begin
Select MAX(SessionID) from SalesTable
End
GO
/****** Object:  StoredProcedure [dbo].[GetSaleDetails]    Script Date: 6/16/2020 3:22:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[GetSaleDetails]
@FromBillDate date,
@ToBillDate date
AS
Begin
select
SalesTable.SessionID AS 'Bill No',
SalesTable.Date AS 'Bill Date',
SalesTable.SubTotal AS 'Sub Total',
SalesTable.Dis AS 'Dis',
SalesTable.NetTotal AS 'Net Total'
 from 
 SalesTable
 Where SalesTable.Date
 Between
 @FromBillDate
 And
 @ToBillDate
End
GO
/****** Object:  StoredProcedure [dbo].[GetSaleReturnDataThroughSessionId]    Script Date: 6/16/2020 3:22:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[GetSaleReturnDataThroughSessionId]
@BillNo int
AS
Begin
Select
SalesTable.PCode AS 'Item Id',
Rp.P_Name AS 'Item Name',
SalesTable.P_Price AS 'Sale Price',
SalesTable.Qty AS 'Qty',
SalesTable.Amount AS 'Amount',
SalesTable.SubTotal AS 'Sub Total',
SalesTable.Dis AS 'Dis',
SalesTable.NetTotal AS 'Net Total',
SalesTable.Pay AS 'Net Pay',
SalesTable.Blance AS 'Blance',
SalesTable.SessionID AS 'Seession ID',
CONVERT (Varchar(60),SalesTable.Date) AS 'Date'
 from SalesTable 

  Inner Join
 RealProducts RP
 on
  RP.P_ID =SalesTable.P_Name
 Where SalesTable.SessionID=@BillNo
End
GO
/****** Object:  StoredProcedure [dbo].[GetSessionID]    Script Date: 6/16/2020 3:22:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[GetSessionID]
AS
Begin
Select Max(SessionID) AS 'Session ID' From SalesTable
End
GO
/****** Object:  StoredProcedure [dbo].[GetSuppliers]    Script Date: 6/16/2020 3:22:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[GetSuppliers]
AS
Begin
Select
S.S_ID AS 'ID',
S.S_Name AS 'Name',
S.S_EMail AS 'Email',
S.S_Phone AS 'Phone',
S.S_Address AS 'Address',
case when (S.S_Status=1) then 'Active' else 'In-Active' end AS 'Status' 
 from Supplier S
 Order By S.S_Name asc
End
GO
/****** Object:  StoredProcedure [dbo].[GetSuppliersList]    Script Date: 6/16/2020 3:22:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[GetSuppliersList]
AS
Begin
Select
S.S_ID AS 'ID',
S.S_Name As 'Name'
 from Supplier S
 where 
 S.S_Status =1
 Order By S.S_Name ASC
End

GO
/****** Object:  StoredProcedure [dbo].[GetUser]    Script Date: 6/16/2020 3:22:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[GetUser]
As
Begin
select
U.UserId As "ID",
U.Name,
U.UserType As "User Type",
U.UserName As "User Name",
U.Password,
U.Contact,
U.Address,
U.Gender,
Case When (UserStatus=1) Then 'Active' else 'In-active' End As 'Status'
 from UserTable U
 Order by U.Name asc
End
GO
/****** Object:  StoredProcedure [dbo].[IncreaseProductsQty]    Script Date: 6/16/2020 3:22:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[IncreaseProductsQty]
@P_Qty int,
@P_ID varchar(50)
AS
Begin
Update RealProducts
Set
P_Qty=P_Qty + @P_Qty
Where P_ID=@P_ID
End

GO
/****** Object:  StoredProcedure [dbo].[InsertCatagories]    Script Date: 6/16/2020 3:22:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[InsertCatagories]
@Cat_Name varchar(50),
@Cat_IsActive tinyint
AS
begin
Insert into Catgories(Cat_Name,Cat_IsActive) values(@Cat_Name,@Cat_IsActive)
end
GO
/****** Object:  StoredProcedure [dbo].[InsertIntoReturn]    Script Date: 6/16/2020 3:22:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[InsertIntoReturn]
@SessionID int,
@ReturnDate date,
@ReturnBy varchar(50),
@ReturnProductID bigint,
@ReturnQty bigint,
@ReturnAmount money
AS
Begin
Insert Into ReturnS(SessionID,ReturnDate,ReturnBy,ReturnProductID,ReturnQty,ReturnAmount)
Values(@SessionID,@ReturnDate,@ReturnBy,@ReturnProductID,@ReturnQty,@ReturnAmount)
End
GO
/****** Object:  StoredProcedure [dbo].[InsertProducts]    Script Date: 6/16/2020 3:22:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[InsertProducts]
@P_Unit varchar(50),
@P_CatID int,
@P_Name varchar(50),
@P_Barcode nvarchar(100),
@P_Power nvarchar(50),
@P_Price money,
@P_SalePrice money,
@P_Qty int,
@P_RackNo varchar(50),
@P_Date date
AS
Begin
Insert into RealProducts(P_Unit,P_CatID,P_Name,P_Barcode,P_Power,P_Price,P_SalePrice,P_Qty,P_RackNo,P_Date)
values(@P_Unit,@P_CatID,@P_Name,@P_Barcode,@P_Power,@P_Price,@P_SalePrice,@P_Qty,@P_RackNo,@P_Date)
End
GO
/****** Object:  StoredProcedure [dbo].[InsertPurchaseHeader]    Script Date: 6/16/2020 3:22:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[InsertPurchaseHeader]
@BillNo int,
@BillDate date,
@BillAmount money,
@DiscountAmount money,
@NetTotal money,
@NetPay money,
@Blance money,
@SupplierName nvarchar(50)
As
begin
Insert into TablePurchaseHeaderData(BillNo,BillDate,BillAmount,DisAmount,NetTotal,NetPay,Blance,SupplierName)
values(@BillNo,@BillDate,@BillAmount,@DiscountAmount,@NetTotal,@NetPay,@Blance,@SupplierName)
End
GO
/****** Object:  StoredProcedure [dbo].[InsertPurchaseRow]    Script Date: 6/16/2020 3:22:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[InsertPurchaseRow]
@ProductName varchar(100),
@Price money,
@Qty money,
@Amount money,
@BillNo int,
@Date date
AS
Begin
Insert Into TablePurchaseRowData(ProductName,Price,Qty,Amount,BillNo,Date)
values(@ProductName,@Price,@Qty,@Amount,@BillNo,@Date)
End
GO
/****** Object:  StoredProcedure [dbo].[InsertSaleDetail]    Script Date: 6/16/2020 3:22:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[InsertSaleDetail]
@SessionID int,
@Date date,
@PCode int,
@P_Name int,
@P_Price float,
@Qty int,
@Amount float,
@SubTotal float,
@Dis float,
@NetTotal float,
@Pay float,
@Blance float
AS
Begin
Insert Into SalesTable(SessionID,Date,PCode,P_Name,P_Price,Qty,Amount,SubTotal,Dis,NetTotal,Pay,Blance)
Values(@SessionID,@Date,@PCode,@P_Name,@P_Price,@Qty,@Amount,@SubTotal,@Dis,@NetTotal,@Pay,@Blance)
End
GO
/****** Object:  StoredProcedure [dbo].[InsertSaleHeaderData]    Script Date: 6/16/2020 3:22:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[InsertSaleHeaderData]
@BillNo int,
@BillDate date,
@SubTotal money,
@DIS money,
@NetTotal money,
@NetPay money,
@Blance money
AS
Begin
Insert Into
 TableHeaderData(BillNo,BillDate,SubTotal,DIS,NetTotal,NetPay,Blance)
 Values(@BillNo,@BillDate,@SubTotal,@DIS,@NetTotal,@NetPay,@Blance)
End
GO
/****** Object:  StoredProcedure [dbo].[InsertSaleRowData]    Script Date: 6/16/2020 3:22:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[InsertSaleRowData]
@ItemCode varchar(50),
@ProductName varchar(100),
@Price money,
@Qty int,
@Amount money,
@BillNo int,
@BillDate date
AS
Begin
Insert Into
 TableRowData(ItemCode,ProductName,Price,Qty,Amount,BillNo,Date)
 Values(@ItemCode,@ProductName,@Price,@Qty,@Amount,@BillNo,@BillDate)
End
GO
/****** Object:  StoredProcedure [dbo].[InsertSuppliers]    Script Date: 6/16/2020 3:22:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[InsertSuppliers]
@S_Name varchar(100),
@S_EMail varchar(50),
@S_Phone varchar(30),
@S_Address varchar(50),
@S_Status tinyint
AS
Begin
insert into Supplier
(S_Name,S_EMail,S_Phone,S_Address,S_Status)
values
(@S_Name,@S_EMail,@S_Phone,@S_Address,@S_Status)
End

GO
/****** Object:  StoredProcedure [dbo].[InsertTableRowData]    Script Date: 6/16/2020 3:22:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[InsertTableRowData]
@ProductName varchar(100),
@Price money,
@Qty int,
@Amount money,
@BillNo int
As
begin
Insert into TablePurchaseRowData(ProductName,Price,Qty,Amount,BillNo)
values(@ProductName,@Price,@Qty,@Amount,@BillNo)
End

GO
/****** Object:  StoredProcedure [dbo].[InsertUser]    Script Date: 6/16/2020 3:22:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[InsertUser]
@Name varchar(100),
@UserType varchar(40),
@UserName varchar(100),
@Password varchar(100),
@Contact varchar(14),
@Address text,
@Gender varchar(30),
@UserStatus tinyint

AS
Begin
Insert into UserTable(Name,UserType,UserName,Password,Contact,Address,Gender,UserStatus)values(@Name,@UserType,@UserName,@Password,@Contact,@Address,@Gender,@UserStatus)
End
GO
/****** Object:  StoredProcedure [dbo].[ItemQtyReturnThanUpdateSale]    Script Date: 6/16/2020 3:22:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[ItemQtyReturnThanUpdateSale]
@Qty int,
@Amount float,
@ItemCode int,
@BillNo int,
@SubTotal float,
@NetTotal float,
@Blance float,
@ProducttP_Name varchar(50)
AS
Begin
Begin Try
Begin Transaction 
Update SalesTable
Set
Qty=Qty-@Qty,
Amount=@Amount,
SubTotal=@SubTotal,
NetTotal=@NetTotal,
Blance=@Blance
Where SessionID=@BillNo 
And
PCode=@ItemCode
------Next Table-----
Update RealProducts
Set
P_Qty=P_Qty+@Qty
Where 
P_Name=@ProducttP_Name
And
P_ID=@ItemCode

COMMIT Transaction
End Try
Begin Catch
End Catch
End
GO
/****** Object:  StoredProcedure [dbo].[PrintPurchaseInvoice]    Script Date: 6/16/2020 3:22:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[PrintPurchaseInvoice]
@BillNo int
AS
Begin
Select
PHD.BillNo,
PHD.BillDate,
PRD.ProductName,
PRD.Price,
PRD.Qty,
PRD.Amount,
PHD.BillAmount,
PHD.DisAmount,
PHD.NetTotal,
PHD.NetPay,
PHD.Blance,
PHD.SupplierName
 from TablePurchaseRowData PRD
 Inner Join
 TablePurchaseHeaderData PHD
 On
 PHD.BillNo=PRD.BillNo
 Where PHD.BillNo=@BillNo
End
GO
/****** Object:  StoredProcedure [dbo].[PurchaseTransactionReport]    Script Date: 6/16/2020 3:22:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[PurchaseTransactionReport]
@FromBillDate date,
@ToBillDate date
AS
Begin
Select
TPH.BillDate,
TPH.BillNo,
TPH.BillAmount,
TPH.DisAmount,
TPH.NetTotal,
TPH.NetPay,
TPH.Blance,
TPH.SupplierName
 From TablePurchaseHeaderData TPH
 Where TPH.BillDate
 Between
 @FromBillDate
 And
 @ToBillDate
End
GO
/****** Object:  StoredProcedure [dbo].[ReturnItem]    Script Date: 6/16/2020 3:22:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[ReturnItem]
@SessionID int,
@PCode int,
@Qty int,
@P_Name varchar(50),
@ReturnDate date,
@ReturnBy varchar(50),
@ReturnProductID bigint,
@ReturnQty bigint,
@ReturnAmount money
AS
Begin
Begin Try
Begin Transaction 
Delete  from SalesTable
where 
SalesTable.SessionID=@SessionID
And
SalesTable.PCode=@PCode
---------RealProductTable----------
Update RealProducts
Set 
P_Qty=P_Qty+@Qty
Where
P_ID=@PCode
And
P_Name=@P_Name
----------SAleReturn------------
Insert Into ReturnS(SessionID,ReturnDate,ReturnBy,ReturnProductID,ReturnQty,ReturnAmount)
Values(@SessionID,@ReturnDate,@ReturnBy,@ReturnProductID,@ReturnQty,@ReturnAmount)
COMMIT Transaction
End Try
Begin Catch
RollBack Transaction 
Print 'Error In Transaction'
End Catch
Select ERROR_MESSAGE()as[error Message]
End
GO
/****** Object:  StoredProcedure [dbo].[SaleInvoice]    Script Date: 6/16/2020 3:22:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[SaleInvoice]
@SessionID int
AS
Begin
Select
SalesTable.SessionID,
SalesTable.Date,
SalesTable.PCode,
RealProducts.P_Name,
SalesTable.P_Price,
SalesTable.Qty,
SalesTable.Amount,
SalesTable.Dis,
SalesTable.Pay,
SalesTable.Blance
 from SalesTable
 Inner Join
 RealProducts
 On
 RealProducts.P_ID=SalesTable.P_Name
 Where SalesTable.SessionID=@SessionID
End
GO
/****** Object:  StoredProcedure [dbo].[SearchGetUser]    Script Date: 6/16/2020 3:22:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[SearchGetUser]
@SearchValue Varchar(50)
As
Begin
select
U.UserId As "ID",
U.Name,
U.UserType As "User Type",
U.UserName As "User Name",
U.Password,
U.Contact,
U.Address,
U.Gender,
Case When (UserStatus=1) Then 'Active' else 'In-active' End As 'Status'
 from UserTable U
Where U.Name Like '%'+@SearchValue+'%'
or
U.UserType Like '%'+@SearchValue+'%'
or
U.UserName Like '%'+@SearchValue+'%'
or
U.Contact Like '%'+@SearchValue+'%'
or
U.Gender Like '%'+@SearchValue+'%'
 Order by U.Name asc
 End
GO
/****** Object:  StoredProcedure [dbo].[SearchProductsThroughProductName]    Script Date: 6/16/2020 3:22:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[SearchProductsThroughProductName]
As
begin
Select 
P.P_Name
from RealProducts P
End
GO
/****** Object:  StoredProcedure [dbo].[SelectMaxBillNo]    Script Date: 6/16/2020 3:22:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[SelectMaxBillNo]
As
begin
Select MAX(BillNo) From TablePurchaseHeaderData
End
GO
/****** Object:  StoredProcedure [dbo].[SerachCatagoryDataLike]    Script Date: 6/16/2020 3:22:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[SerachCatagoryDataLike]
@SearchValue Varchar(50)
AS
begin
Select
C.Cat_Id As 'ID',
C.Cat_Name As 'Name',
case When (Cat_IsActive=1) Then 'Yes' else 'No' End AS 'Status'
 From Catgories C
 Where C.Cat_Name Like'%'+@SearchValue+'%'
 or
 C.Cat_IsActive Like '%'+@SearchValue+'%'
End
GO
/****** Object:  StoredProcedure [dbo].[SessionSaleReturn]    Script Date: 6/16/2020 3:22:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[SessionSaleReturn]
@SessionID int,
@PCode int,
@Qty int,
@P_Name varchar(50),
@ReturnDate date,
@ReturnBy varchar(50),
@ReturnProductID bigint,
@ReturnQty bigint,
@ReturnAmount money
AS
Begin
Begin Try
Begin Transaction 
Delete From SalesTable
Where 
SalesTable.SessionID=@SessionID
--------RealProduct----------
Update RealProducts
Set
P_Qty=P_Qty+@Qty
Where
P_ID=@PCode
And
P_Name=@P_Name
--------Return-----
Insert Into ReturnS(SessionID,ReturnDate,ReturnBy,ReturnProductID,ReturnQty,ReturnAmount)
Values(@SessionID,@ReturnDate,@ReturnBy,@ReturnProductID,@ReturnQty,@ReturnAmount)
COMMIT Transaction
End Try
Begin Catch
End Catch
End
GO
/****** Object:  StoredProcedure [dbo].[TestProcedure]    Script Date: 6/16/2020 3:22:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[TestProcedure]
@PCode int,
@Qty int,
@P_Name varchar(50)
AS
Begin
Update RealProducts
Set
P_Qty=P_Qty+@Qty
Where
P_ID=@PCode
And
P_Name=@P_Name
End
GO
/****** Object:  StoredProcedure [dbo].[UpdateCatagories]    Script Date: 6/16/2020 3:22:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[UpdateCatagories]
@Cat_Name varchar(50),
@Cat_IsActive tinyint,
@Cat_Id int
AS
begin
Update Catgories
Set Cat_Name=@Cat_Name,
Cat_IsActive=@Cat_IsActive
Where Cat_Id=@Cat_Id
end
GO
/****** Object:  StoredProcedure [dbo].[UpdateProducts]    Script Date: 6/16/2020 3:22:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[UpdateProducts]
@P_ID varchar(50),
@P_Unit varchar(50),
@P_CatID int,
@P_Name varchar(50),
@P_Barcode nvarchar(100),
@P_Power nvarchar(50),
@P_Price money,
@P_SalePrice money,
@P_Qty int,
@P_RackNo varchar(50),
@P_Date date
AS
Begin
update RealProducts
set
P_Unit=@P_Unit,
P_CatID=@P_CatID,
P_Name=@P_Name,
P_Barcode=@P_Barcode,
P_Power=@P_Power,
P_Price=@P_Price,
P_SalePrice =@P_SalePrice,
P_Qty =@P_Qty,
P_RackNo=@P_RackNo,
@P_Date=@P_Date
Where
P_ID=@P_ID
End
GO
/****** Object:  StoredProcedure [dbo].[UpdateSuppliers]    Script Date: 6/16/2020 3:22:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[UpdateSuppliers]
@S_Name varchar(100),
@S_EMail varchar(50),
@S_Phone varchar(30),
@S_Address varchar(50),
@S_Status tinyint,
@S_ID int
AS
Begin
update Supplier
set
S_Name=@S_Name,
S_EMail=@S_EMail,
S_Phone=@S_Phone,
S_Address=@S_Address,
S_Status=@S_Status
where
S_ID=@S_ID
End
GO
/****** Object:  StoredProcedure [dbo].[UpdateUserS]    Script Date: 6/16/2020 3:22:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[UpdateUserS]
@UserId int,
@Name varchar(200),
@UserType varchar(50),
@UserName varchar(50),
@Password varchar(50),
@Contact varchar(50),
@Address text,
@Gender varchar(50),
@UserStatus tinyint

AS
Begin
Update UserTable Set Name=@Name,UserType=@UserType,UserName=@UserName,Password=@Password,Contact=@Contact,Address=@Address,Gender=@Gender,UserStatus=@UserStatus Where UserId=@UserId
End
GO