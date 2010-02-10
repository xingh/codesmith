--region Drop Existing Procedures

IF OBJECT_ID(N'[dbo].[CSLA_Product_Insert]') IS NOT NULL
	DROP PROCEDURE [dbo].[CSLA_Product_Insert]

IF OBJECT_ID(N'[dbo].[CSLA_Product_Update]') IS NOT NULL
	DROP PROCEDURE [dbo].[CSLA_Product_Update]

IF OBJECT_ID(N'[dbo].[CSLA_Product_Delete]') IS NOT NULL
	DROP PROCEDURE [dbo].[CSLA_Product_Delete]

IF OBJECT_ID(N'[dbo].[CSLA_Product_Select]') IS NOT NULL
	DROP PROCEDURE [dbo].[CSLA_Product_Select]

--endregion

GO

--region [dbo].[CSLA_Product_Insert]

------------------------------------------------------------------------------------------------------------------------
-- Generated By:   Blake Niemyjski using CodeSmith: v5.2.1, CSLA Templates: v1.5.0.0, CSLA Framework: v3.8.0
-- Procedure Name: [dbo].[CSLA_Product_Insert]
------------------------------------------------------------------------------------------------------------------------

CREATE PROCEDURE [dbo].[CSLA_Product_Insert]
	@p_ProductId varchar(10),
	@p_CategoryId varchar(10),
	@p_Name varchar(80),
	@p_Descn varchar(255),
	@p_Image varchar(80)
AS

SET NOCOUNT ON

INSERT INTO [dbo].[Product] (
	[ProductId],
	[CategoryId],
	[Name],
	[Descn],
	[Image]
) VALUES (
	@p_ProductId,
	@p_CategoryId,
	@p_Name,
	@p_Descn,
	@p_Image
)

--endregion

GO

--region [dbo].[CSLA_Product_Update]

------------------------------------------------------------------------------------------------------------------------
-- Generated By:   Blake Niemyjski using CodeSmith: v5.2.1, CSLA Templates: v1.5.0.0, CSLA Framework: v3.8.0
-- Procedure Name: [dbo].[CSLA_Product_Update]
------------------------------------------------------------------------------------------------------------------------

CREATE PROCEDURE [dbo].[CSLA_Product_Update]
	@p_ProductId varchar(10),
	@p_CategoryId varchar(10),
	@p_Name varchar(80),
	@p_Descn varchar(255),
	@p_Image varchar(80)
AS

UPDATE [dbo].[Product] SET
	[CategoryId] = @p_CategoryId,
	[Name] = @p_Name,
	[Descn] = @p_Descn,
	[Image] = @p_Image
WHERE
	[ProductId] = @p_ProductId

--endregion

GO

--region [dbo].[CSLA_Product_Delete]

------------------------------------------------------------------------------------------------------------------------
-- Generated By:   Blake Niemyjski using CodeSmith: v5.2.1, CSLA Templates: v1.5.0.0, CSLA Framework: v3.8.0
-- Procedure Name: [dbo].[CSLA_Product_Delete]
------------------------------------------------------------------------------------------------------------------------

CREATE PROCEDURE [dbo].[CSLA_Product_Delete]
	@p_ProductId varchar(10)
AS

DELETE FROM
    [dbo].[Product]
WHERE
	[ProductId] = @p_ProductId

--endregion

GO

--region [dbo].[CSLA_Product_Select]

------------------------------------------------------------------------------------------------------------------------
-- Generated By:   Blake Niemyjski using CodeSmith: v5.2.1, CSLA Templates: v1.5.0.0, CSLA Framework: v3.8.0
-- Procedure Name: [dbo].[CSLA_Product_Select]
------------------------------------------------------------------------------------------------------------------------

CREATE PROCEDURE [dbo].[CSLA_Product_Select]
	@p_ProductId varchar(10) = NULL,
	@p_CategoryId varchar(10) = NULL,
	@p_Name varchar(80) = NULL,
	@p_Descn varchar(255) = NULL,
	@p_Image varchar(80) = NULL
AS

SET TRANSACTION ISOLATION LEVEL READ COMMITTED

SELECT
	[ProductId],
	[CategoryId],
	[Name],
	[Descn],
	[Image]
FROM
    [dbo].[Product]
WHERE
	([ProductId] = @p_ProductId OR @p_ProductId IS NULL)
	AND ([CategoryId] = @p_CategoryId OR @p_CategoryId IS NULL)
	AND ([Name] = @p_Name OR @p_Name IS NULL)
	AND ([Descn] = @p_Descn OR @p_Descn IS NULL)
	AND ([Image] = @p_Image OR @p_Image IS NULL)

--endregion

GO

