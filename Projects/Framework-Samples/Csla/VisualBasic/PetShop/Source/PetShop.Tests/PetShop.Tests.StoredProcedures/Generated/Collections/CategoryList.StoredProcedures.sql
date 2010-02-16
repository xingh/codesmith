--region Drop Existing Procedures

IF OBJECT_ID(N'[dbo].[CSLA_Category_Insert]') IS NOT NULL
	DROP PROCEDURE [dbo].[CSLA_Category_Insert]

IF OBJECT_ID(N'[dbo].[CSLA_Category_Update]') IS NOT NULL
	DROP PROCEDURE [dbo].[CSLA_Category_Update]

IF OBJECT_ID(N'[dbo].[CSLA_Category_Delete]') IS NOT NULL
	DROP PROCEDURE [dbo].[CSLA_Category_Delete]

IF OBJECT_ID(N'[dbo].[CSLA_Category_Select]') IS NOT NULL
	DROP PROCEDURE [dbo].[CSLA_Category_Select]

--endregion

GO

--region [dbo].[CSLA_Category_Insert]

------------------------------------------------------------------------------------------------------------------------
-- Generated By:   Blake Niemyjski using CodeSmith: v5.2.1, CSLA Templates: v1.5.0.0, CSLA Framework: v3.8.0
-- Procedure Name: [dbo].[CSLA_Category_Insert]
------------------------------------------------------------------------------------------------------------------------

CREATE PROCEDURE [dbo].[CSLA_Category_Insert]
	@p_CategoryId varchar(10),
	@p_Name varchar(80),
	@p_Descn varchar(255)
AS

INSERT INTO [dbo].[Category] (
	[CategoryId],
	[Name],
	[Descn]
) VALUES (
	@p_CategoryId,
	@p_Name,
	@p_Descn
)

--endregion

GO

--region [dbo].[CSLA_Category_Update]

------------------------------------------------------------------------------------------------------------------------
-- Generated By:   Blake Niemyjski using CodeSmith: v5.2.1, CSLA Templates: v1.5.0.0, CSLA Framework: v3.8.0
-- Procedure Name: [dbo].[CSLA_Category_Update]
------------------------------------------------------------------------------------------------------------------------

CREATE PROCEDURE [dbo].[CSLA_Category_Update]
	@p_CategoryId varchar(10),
	@p_Name varchar(80),
	@p_Descn varchar(255)
AS

UPDATE [dbo].[Category] SET
	[Name] = @p_Name,
	[Descn] = @p_Descn
WHERE
	[CategoryId] = @p_CategoryId

--endregion

GO

--region [dbo].[CSLA_Category_Delete]

------------------------------------------------------------------------------------------------------------------------
-- Generated By:   Blake Niemyjski using CodeSmith: v5.2.1, CSLA Templates: v1.5.0.0, CSLA Framework: v3.8.0
-- Procedure Name: [dbo].[CSLA_Category_Delete]
------------------------------------------------------------------------------------------------------------------------

CREATE PROCEDURE [dbo].[CSLA_Category_Delete]
	@p_CategoryId varchar(10)
AS

DELETE FROM
    [dbo].[Category]
WHERE
	[CategoryId] = @p_CategoryId

--endregion

GO

--region [dbo].[CSLA_Category_Select]

------------------------------------------------------------------------------------------------------------------------
-- Generated By:   Blake Niemyjski using CodeSmith: v5.2.1, CSLA Templates: v1.5.0.0, CSLA Framework: v3.8.0
-- Procedure Name: [dbo].[CSLA_Category_Select]
------------------------------------------------------------------------------------------------------------------------

CREATE PROCEDURE [dbo].[CSLA_Category_Select]
	@p_CategoryId varchar(10) = NULL,
	@p_Name varchar(80) = NULL,
@p_NameHasValue BIT = 0,
	@p_Descn varchar(255) = NULL,
@p_DescnHasValue BIT = 0
AS

SET TRANSACTION ISOLATION LEVEL READ COMMITTED

SELECT
	[CategoryId],
	[Name],
	[Descn]
FROM
    [dbo].[Category]
WHERE
	([CategoryId] = @p_CategoryId OR @p_CategoryId IS NULL)
	AND ([Name] = @p_Name OR (@p_Name IS NULL AND @p_NameHasValue = 0))
	AND ([Descn] = @p_Descn OR (@p_Descn IS NULL AND @p_DescnHasValue = 0))

--endregion

GO

