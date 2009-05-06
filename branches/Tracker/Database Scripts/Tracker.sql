/****** Object:  Table [dbo].[Status]    Script Date: 05/06/2009 16:40:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Status](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Description] [nvarchar](150) NULL,
	[Order] [int] NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[ModifiedDate] [datetime] NOT NULL,
	[RowVersion] [timestamp] NOT NULL,
 CONSTRAINT [PK_Status] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Role]    Script Date: 05/06/2009 16:40:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Role](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Description] [nvarchar](150) NULL,
	[CreatedDate] [datetime] NOT NULL,
	[ModifiedDate] [datetime] NOT NULL,
	[RowVersion] [timestamp] NOT NULL,
 CONSTRAINT [PK_Role] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Priority]    Script Date: 05/06/2009 16:40:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Priority](
	[Id] [int] NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Order] [int] NOT NULL,
	[Description] [nvarchar](200) NULL,
	[CreatedDate] [datetime] NOT NULL,
	[ModifiedDate] [datetime] NOT NULL,
	[RowVersion] [timestamp] NOT NULL,
 CONSTRAINT [PK_Priority] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 05/06/2009 16:40:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[User](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[EmailAddress] [nvarchar](250) NOT NULL,
	[FirstName] [nvarchar](200) NULL,
	[LastName] [nvarchar](200) NULL,
	[Avatar] [varbinary](max) NULL,
	[CreatedDate] [datetime] NOT NULL,
	[ModifiedDate] [datetime] NOT NULL,
	[RowVersion] [timestamp] NOT NULL,
	[PasswordHash] [char](86) NOT NULL,
	[PasswordSalt] [char](5) NOT NULL,
	[Comment] [text] NULL,
	[IsApproved] [bit] NOT NULL,
	[LastLoginDate] [datetime] NULL,
	[LastActivityDate] [datetime] NOT NULL,
	[LastPasswordChangeDate] [datetime] NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO

SET IDENTITY_INSERT [dbo].[User] ON
INSERT [dbo].[User] ([Id], [EmailAddress], [FirstName], [LastName], [Avatar], [CreatedDate], [ModifiedDate], [PasswordHash], [PasswordSalt], [Comment], [IsApproved], [LastLoginDate], [LastActivityDate], [LastPasswordChangeDate]) VALUES (1, N'william.adama@battlestar.com', N'William', N'Adama', NULL, CAST(0x00009C010124E143 AS DateTime), CAST(0x00009C010124E143 AS DateTime), N'1+v5rvSXnyX7tvwTKfM+aq+s0hDmNXsduGZfq8sQv1ggPnGlQdDdBdbUP0bUmbMbiU40PvRQWKRAy5QUd1xrAA', N'?#nkY', NULL, 1, NULL, CAST(0x00009C010124E143 AS DateTime), NULL)
INSERT [dbo].[User] ([Id], [EmailAddress], [FirstName], [LastName], [Avatar], [CreatedDate], [ModifiedDate], [PasswordHash], [PasswordSalt], [Comment], [IsApproved], [LastLoginDate], [LastActivityDate], [LastPasswordChangeDate]) VALUES (2, N'laura.roslin@battlestar.com', N'Laura', N'Roslin', NULL, CAST(0x00009C0101250FD3 AS DateTime), CAST(0x00009C0101250FD3 AS DateTime), N'Sx/jwRHFW/CQpO0E6G8d+jo344AmAKfX+C48a0iAZyMrb4sE8VoDuyZorbhbLZAX9f4UZk67O7eCjk854OrYSg', N'Ph)6;', NULL, 1, NULL, CAST(0x00009C0101250FD3 AS DateTime), NULL)
INSERT [dbo].[User] ([Id], [EmailAddress], [FirstName], [LastName], [Avatar], [CreatedDate], [ModifiedDate], [PasswordHash], [PasswordSalt], [Comment], [IsApproved], [LastLoginDate], [LastActivityDate], [LastPasswordChangeDate]) VALUES (3, N'kara.thrace@battlestar.com', N'Kara', N'Thrace', NULL, CAST(0x00009C0101254251 AS DateTime), CAST(0x00009C0101254251 AS DateTime), N'5KhtS4ax7G1aGkq97w02ooVZMmJp8bcySEKMSxruXu/Z/wRKoNAxMlkjRVY1yLavrC3GRYQZjy5b6JW8cR5EWg', N'!]@2/', NULL, 1, NULL, CAST(0x00009C0101254251 AS DateTime), NULL)
INSERT [dbo].[User] ([Id], [EmailAddress], [FirstName], [LastName], [Avatar], [CreatedDate], [ModifiedDate], [PasswordHash], [PasswordSalt], [Comment], [IsApproved], [LastLoginDate], [LastActivityDate], [LastPasswordChangeDate]) VALUES (4, N'lee.adama@battlestar.com', N'Lee', N'Adama', NULL, CAST(0x00009C0101255886 AS DateTime), CAST(0x00009C0101255886 AS DateTime), N'IrK8OhI2n4Ev3YA4y5kP7vy+n2CffX2MgcONbAh6/kZpNZYBYoYyrMhqdYztehL0NAIdvcInQ6zOjMplq+zWQA', N'e@_a{', NULL, 1, NULL, CAST(0x00009C0101255886 AS DateTime), NULL)
INSERT [dbo].[User] ([Id], [EmailAddress], [FirstName], [LastName], [Avatar], [CreatedDate], [ModifiedDate], [PasswordHash], [PasswordSalt], [Comment], [IsApproved], [LastLoginDate], [LastActivityDate], [LastPasswordChangeDate]) VALUES (5, N'gaius.baltar@battlestar.com', N'Gaius', N'Baltar', NULL, CAST(0x00009C010125748A AS DateTime), CAST(0x00009C010125748A AS DateTime), N'7tfajMaEerDNVgi6Oi6UJ6JxsUXZ0u4zQeUrZQxnaXJQ2f2vd9AzBR4sVOaH7LZtCjQopMzlQ38QqNEnpK0B/g', N'_qpA2', NULL, 1, NULL, CAST(0x00009C010125748A AS DateTime), NULL)
INSERT [dbo].[User] ([Id], [EmailAddress], [FirstName], [LastName], [Avatar], [CreatedDate], [ModifiedDate], [PasswordHash], [PasswordSalt], [Comment], [IsApproved], [LastLoginDate], [LastActivityDate], [LastPasswordChangeDate]) VALUES (6, N'saul.tigh@battlestar.com', N'Saul', N'Tigh', NULL, CAST(0x00009C010125BA8F AS DateTime), CAST(0x00009C010125BA8F AS DateTime), N'wzkR89zRXe7hND1jqAP9xgupYJBvEZcjsfUe3TaU45kxRajjjS9u0fOTLK+uglzk67EGochJdeoikWs7hxMNRA', N'h]-zG', NULL, 1, NULL, CAST(0x00009C010125BA8F AS DateTime), NULL)
SET IDENTITY_INSERT [dbo].[User] OFF

/****** Object:  Table [dbo].[UserRole]    Script Date: 05/06/2009 16:40:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserRole](
	[UserId] [int] NOT NULL,
	[RoleId] [int] NOT NULL,
 CONSTRAINT [PK_UserRole] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[RoleId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Task]    Script Date: 05/06/2009 16:40:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Task](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[StatusId] [int] NOT NULL,
	[PriorityId] [int] NOT NULL,
	[CreatedId] [int] NOT NULL,
	[Summary] [nvarchar](255) NOT NULL,
	[Details] [nvarchar](2000) NULL,
	[StartDate] [datetime] NULL,
	[DueDate] [datetime] NULL,
	[CompleteDate] [datetime] NULL,
	[AssignedId] [int] NULL,
	[CreatedDate] [datetime] NOT NULL,
	[ModifiedDate] [datetime] NOT NULL,
	[RowVersion] [timestamp] NOT NULL,
	[LastModifiedBy] [nvarchar](50) NULL,
 CONSTRAINT [PK_Task] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TaskExtended]    Script Date: 05/06/2009 16:40:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaskExtended](
	[TaskId] [int] NOT NULL,
	[Browser] [nvarchar](200) NULL,
	[OS] [nvarchar](150) NULL,
	[CreatedDate] [datetime] NOT NULL,
	[ModifiedDate] [datetime] NOT NULL,
	[RowVersion] [timestamp] NOT NULL,
 CONSTRAINT [PK_TaskExtended] PRIMARY KEY CLUSTERED 
(
	[TaskId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[GetUsersWithRoles]    Script Date: 05/06/2009 16:40:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetUsersWithRoles]
AS
BEGIN
	SET NOCOUNT ON;

	Select * From [User]
	Select * From UserRole
END
GO
/****** Object:  Table [dbo].[Audit]    Script Date: 05/06/2009 16:40:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Audit](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Date] [datetime] NOT NULL,
	[UserId] [int] NULL,
	[TaskId] [int] NULL,
	[Content] [varchar](max) NOT NULL,
	[Username] [nvarchar](50) NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[RowVersion] [timestamp] NOT NULL,
 CONSTRAINT [PK_Audit] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Default [DF_Audit_CreatedDate]    Script Date: 05/06/2009 16:40:02 ******/
ALTER TABLE [dbo].[Audit] ADD  CONSTRAINT [DF_Audit_CreatedDate]  DEFAULT (getdate()) FOR [CreatedDate]
GO
/****** Object:  Default [DF__Priority__Create__0AD2A005]    Script Date: 05/06/2009 16:40:02 ******/
ALTER TABLE [dbo].[Priority] ADD  CONSTRAINT [DF__Priority__Create__0AD2A005]  DEFAULT (getdate()) FOR [CreatedDate]
GO
/****** Object:  Default [DF__Priority__Modifi__0BC6C43E]    Script Date: 05/06/2009 16:40:02 ******/
ALTER TABLE [dbo].[Priority] ADD  CONSTRAINT [DF__Priority__Modifi__0BC6C43E]  DEFAULT (getdate()) FOR [ModifiedDate]
GO
/****** Object:  Default [DF__Role__CreatedDat__0CBAE877]    Script Date: 05/06/2009 16:40:02 ******/
ALTER TABLE [dbo].[Role] ADD  DEFAULT (getdate()) FOR [CreatedDate]
GO
/****** Object:  Default [DF__Role__ModifiedDa__0DAF0CB0]    Script Date: 05/06/2009 16:40:02 ******/
ALTER TABLE [dbo].[Role] ADD  DEFAULT (getdate()) FOR [ModifiedDate]
GO
/****** Object:  Default [DF__Status__CreatedD__0EA330E9]    Script Date: 05/06/2009 16:40:02 ******/
ALTER TABLE [dbo].[Status] ADD  DEFAULT (getdate()) FOR [CreatedDate]
GO
/****** Object:  Default [DF__Status__Modified__0F975522]    Script Date: 05/06/2009 16:40:02 ******/
ALTER TABLE [dbo].[Status] ADD  DEFAULT (getdate()) FOR [ModifiedDate]
GO
/****** Object:  Default [DF__Task__CreatedDat__145C0A3F]    Script Date: 05/06/2009 16:40:02 ******/
ALTER TABLE [dbo].[Task] ADD  DEFAULT (getdate()) FOR [CreatedDate]
GO
/****** Object:  Default [DF__Task__ModifiedDa__15502E78]    Script Date: 05/06/2009 16:40:02 ******/
ALTER TABLE [dbo].[Task] ADD  DEFAULT (getdate()) FOR [ModifiedDate]
GO
/****** Object:  Default [DF__TaskExten__Creat__173876EA]    Script Date: 05/06/2009 16:40:02 ******/
ALTER TABLE [dbo].[TaskExtended] ADD  DEFAULT (getdate()) FOR [CreatedDate]
GO
/****** Object:  Default [DF__TaskExten__Modif__182C9B23]    Script Date: 05/06/2009 16:40:02 ******/
ALTER TABLE [dbo].[TaskExtended] ADD  DEFAULT (getdate()) FOR [ModifiedDate]
GO
/****** Object:  Default [DF__User__CreatedDat__1920BF5C]    Script Date: 05/06/2009 16:40:02 ******/
ALTER TABLE [dbo].[User] ADD  CONSTRAINT [DF__User__CreatedDat__1920BF5C]  DEFAULT (getdate()) FOR [CreatedDate]
GO
/****** Object:  Default [DF__User__ModifiedDa__1A14E395]    Script Date: 05/06/2009 16:40:02 ******/
ALTER TABLE [dbo].[User] ADD  CONSTRAINT [DF__User__ModifiedDa__1A14E395]  DEFAULT (getdate()) FOR [ModifiedDate]
GO
/****** Object:  Default [DF__User__PasswordHa__3A81B327]    Script Date: 05/06/2009 16:40:02 ******/
ALTER TABLE [dbo].[User] ADD  CONSTRAINT [DF__User__PasswordHa__3A81B327]  DEFAULT ('') FOR [PasswordHash]
GO
/****** Object:  Default [DF__User__PasswordSa__3B75D760]    Script Date: 05/06/2009 16:40:02 ******/
ALTER TABLE [dbo].[User] ADD  CONSTRAINT [DF__User__PasswordSa__3B75D760]  DEFAULT ('') FOR [PasswordSalt]
GO
/****** Object:  Default [DF__User__IsApproved__3C69FB99]    Script Date: 05/06/2009 16:40:02 ******/
ALTER TABLE [dbo].[User] ADD  CONSTRAINT [DF__User__IsApproved__3C69FB99]  DEFAULT ((1)) FOR [IsApproved]
GO
/****** Object:  Default [DF__User__LastLoginD__3D5E1FD2]    Script Date: 05/06/2009 16:40:02 ******/
ALTER TABLE [dbo].[User] ADD  CONSTRAINT [DF__User__LastLoginD__3D5E1FD2]  DEFAULT (getdate()) FOR [LastLoginDate]
GO
/****** Object:  Default [DF__User__LastActivi__3E52440B]    Script Date: 05/06/2009 16:40:02 ******/
ALTER TABLE [dbo].[User] ADD  CONSTRAINT [DF__User__LastActivi__3E52440B]  DEFAULT (getdate()) FOR [LastActivityDate]
GO
/****** Object:  ForeignKey [FK_Audit_Task]    Script Date: 05/06/2009 16:40:02 ******/
ALTER TABLE [dbo].[Audit]  WITH CHECK ADD  CONSTRAINT [FK_Audit_Task] FOREIGN KEY([TaskId])
REFERENCES [dbo].[Task] ([Id])
GO
ALTER TABLE [dbo].[Audit] CHECK CONSTRAINT [FK_Audit_Task]
GO
/****** Object:  ForeignKey [FK_Audit_User]    Script Date: 05/06/2009 16:40:02 ******/
ALTER TABLE [dbo].[Audit]  WITH CHECK ADD  CONSTRAINT [FK_Audit_User] FOREIGN KEY([UserId])
REFERENCES [dbo].[User] ([Id])
GO
ALTER TABLE [dbo].[Audit] CHECK CONSTRAINT [FK_Audit_User]
GO
/****** Object:  ForeignKey [FK_Task_Priority]    Script Date: 05/06/2009 16:40:02 ******/
ALTER TABLE [dbo].[Task]  WITH NOCHECK ADD  CONSTRAINT [FK_Task_Priority] FOREIGN KEY([PriorityId])
REFERENCES [dbo].[Priority] ([Id])
GO
ALTER TABLE [dbo].[Task] CHECK CONSTRAINT [FK_Task_Priority]
GO
/****** Object:  ForeignKey [FK_Task_Status]    Script Date: 05/06/2009 16:40:02 ******/
ALTER TABLE [dbo].[Task]  WITH NOCHECK ADD  CONSTRAINT [FK_Task_Status] FOREIGN KEY([StatusId])
REFERENCES [dbo].[Status] ([Id])
GO
ALTER TABLE [dbo].[Task] CHECK CONSTRAINT [FK_Task_Status]
GO
/****** Object:  ForeignKey [FK_Task_User_Assigned]    Script Date: 05/06/2009 16:40:02 ******/
ALTER TABLE [dbo].[Task]  WITH NOCHECK ADD  CONSTRAINT [FK_Task_User_Assigned] FOREIGN KEY([AssignedId])
REFERENCES [dbo].[User] ([Id])
GO
ALTER TABLE [dbo].[Task] CHECK CONSTRAINT [FK_Task_User_Assigned]
GO
/****** Object:  ForeignKey [FK_Task_User_Created]    Script Date: 05/06/2009 16:40:02 ******/
ALTER TABLE [dbo].[Task]  WITH NOCHECK ADD  CONSTRAINT [FK_Task_User_Created] FOREIGN KEY([CreatedId])
REFERENCES [dbo].[User] ([Id])
GO
ALTER TABLE [dbo].[Task] CHECK CONSTRAINT [FK_Task_User_Created]
GO
/****** Object:  ForeignKey [FK_TaskExtended_Task]    Script Date: 05/06/2009 16:40:02 ******/
ALTER TABLE [dbo].[TaskExtended]  WITH CHECK ADD  CONSTRAINT [FK_TaskExtended_Task] FOREIGN KEY([TaskId])
REFERENCES [dbo].[Task] ([Id])
GO
ALTER TABLE [dbo].[TaskExtended] CHECK CONSTRAINT [FK_TaskExtended_Task]
GO
/****** Object:  ForeignKey [FK_UserRole_Role]    Script Date: 05/06/2009 16:40:02 ******/
ALTER TABLE [dbo].[UserRole]  WITH NOCHECK ADD  CONSTRAINT [FK_UserRole_Role] FOREIGN KEY([RoleId])
REFERENCES [dbo].[Role] ([Id])
GO
ALTER TABLE [dbo].[UserRole] CHECK CONSTRAINT [FK_UserRole_Role]
GO
/****** Object:  ForeignKey [FK_UserRole_User]    Script Date: 05/06/2009 16:40:02 ******/
ALTER TABLE [dbo].[UserRole]  WITH NOCHECK ADD  CONSTRAINT [FK_UserRole_User] FOREIGN KEY([UserId])
REFERENCES [dbo].[User] ([Id])
GO
ALTER TABLE [dbo].[UserRole] CHECK CONSTRAINT [FK_UserRole_User]
GO
