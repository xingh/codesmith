﻿'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated using CodeSmith: v5.2.1, CSLA Templates: v2.0.0.1440, CSLA Framework: v3.8.2.
'     Changes to this file will be lost after each regeneration.
'     To extend the functionality of this class, please modify the partial class 'Item.vb.
'
'     Template: SwitchableObject.DataAccess.ParameterizedSQL.cst
'     Template website: http://code.google.com/p/codesmith/
' </autogenerated>
'------------------------------------------------------------------------------
Option Explicit On
Option Strict On

Imports System
Imports System.Data
Imports System.Data.SqlClient

Imports Csla
Imports Csla.Data

Public Partial Class Item

    #Region "Root Data Access"

    <RunLocal()> _
    Protected Overrides Sub DataPortal_Create()
        Dim cancel As Boolean = False
        OnCreating(cancel)
        If (cancel) Then
            Return
        End If

        ProductId = "BN"
        ValidationRules.CheckRules()

        OnCreated()
    End Sub

    <Transactional(TransactionalTypes.TransactionScope)> _
    Private Shadows Sub DataPortal_Fetch(ByVal criteria As ItemCriteria )
        Dim cancel As Boolean = False
        OnFetching(criteria, cancel)
        If (cancel) Then
            Return
        End If

        Dim commandText As String = String.Format("SELECT [ItemId], [ProductId], [ListPrice], [UnitCost], [Supplier], [Status], [Name], [Image] FROM [dbo].[Item] {0}", ADOHelper.BuildWhereStatement(criteria.StateBag))
        Using connection As New SqlConnection(ADOHelper.ConnectionString)
            connection.Open()
            Using command As New SqlCommand(commandText, connection)
                command.Parameters.AddRange(ADOHelper.SqlParameters(criteria.StateBag))
                Using reader As SafeDataReader = New SafeDataReader(command.ExecuteReader())
                    If reader.Read() Then
                        Map(reader)
                    Else
                        Throw New Exception(String.Format("The record was not found in 'Item' using the following criteria: {0}.", criteria))
                    End If
                End Using
            End Using
        End Using

        OnFetched()
    End Sub

    <Transactional(TransactionalTypes.TransactionScope)> _
    Protected Overrides Sub DataPortal_Insert()
        Dim cancel As Boolean = False
        OnInserting(cancel)
        If (cancel) Then
            Return
        End If

        Const commandText As String = "INSERT INTO [dbo].[Item] ([ItemId], [ProductId], [ListPrice], [UnitCost], [Supplier], [Status], [Name], [Image]) VALUES (@p_ItemId, @p_ProductId, @p_ListPrice, @p_UnitCost, @p_Supplier, @p_Status, @p_Name, @p_Image)"
        Using connection As New SqlConnection(ADOHelper.ConnectionString)
            connection.Open()
            Using command As New SqlCommand(commandText, connection)
                command.Parameters.AddWithValue("@p_ItemId", Me.ItemId)
				command.Parameters.AddWithValue("@p_ProductId", Me.ProductId)
				command.Parameters.AddWithValue("@p_ListPrice", IIf(Me.ListPrice.HasValue, Me.ListPrice.Value, DBNull.Value))
				command.Parameters.AddWithValue("@p_UnitCost", IIf(Me.UnitCost.HasValue, Me.UnitCost.Value, DBNull.Value))
				command.Parameters.AddWithValue("@p_Supplier", IIf(Me.Supplier.HasValue, Me.Supplier.Value, DBNull.Value))
				command.Parameters.AddWithValue("@p_Status", Me.Status)
				command.Parameters.AddWithValue("@p_Name", Me.Name)
				command.Parameters.AddWithValue("@p_Image", Me.Image)

                'result: The number of rows changed, inserted, or deleted. -1 for select statements; 0 if no rows were affected, or the statement failed. 
                Dim result As Integer = command.ExecuteNonQuery()
                If (result = 0) Then
                    throw new DBConcurrencyException("The entity is out of date on the client. Please update the entity and try again. This could also be thrown if the sql statement failed to execute.")
                End If
            End Using

            _originalItemId = Me.ItemId


            FieldManager.UpdateChildren(Me, connection)
        End Using

        OnInserted()
    End Sub

    <Transactional(TransactionalTypes.TransactionScope)> _
    Protected Overrides Sub DataPortal_Update()
        Dim cancel As Boolean = False
        OnUpdating(cancel)
        If (cancel) Then
            Return
        End If

        If Not OriginalItemId = ItemId Then
            ' Insert new child.
            Dim item As New Item()
            item.ItemId = ItemId
			item.ProductId = ProductId
			item.ListPrice = ListPrice.Value
			item.UnitCost = UnitCost.Value
			item.Supplier = Supplier.Value
			item.Status = Status
			item.Name = Name
			item.Image = Image
            item = item.Save()

            ' Mark child lists as dirty. This code may need to be updated to one-to-one relationships.

            ' Create a new connection.
            Using connection As New SqlConnection(ADOHelper.ConnectionString)
                connection.Open()
                FieldManager.UpdateChildren(Me, connection)
            End Using

            ' Delete the old.
            Dim criteria As New ItemCriteria()
            criteria.ItemId = OriginalItemId
            DataPortal_Delete(criteria)

            ' Mark the original as the new one.
            OriginalItemId = ItemId
            OnUpdated()

            Return
        End If

        Const commandText As String = "UPDATE [dbo].[Item]  SET [ItemId] = @p_ItemId, [ProductId] = @p_ProductId, [ListPrice] = @p_ListPrice, [UnitCost] = @p_UnitCost, [Supplier] = @p_Supplier, [Status] = @p_Status, [Name] = @p_Name, [Image] = @p_Image WHERE [ItemId] = @p_OriginalItemId"
        Using connection As New SqlConnection(ADOHelper.ConnectionString)
            connection.Open()
            Using command As New SqlCommand(commandText, connection)
                command.Parameters.AddWithValue("@p_OriginalItemId", Me.OriginalItemId)
				command.Parameters.AddWithValue("@p_ItemId", Me.ItemId)
				command.Parameters.AddWithValue("@p_ProductId", Me.ProductId)
				command.Parameters.AddWithValue("@p_ListPrice", IIf(Me.ListPrice.HasValue, Me.ListPrice.Value, DBNull.Value))
				command.Parameters.AddWithValue("@p_UnitCost", IIf(Me.UnitCost.HasValue, Me.UnitCost.Value, DBNull.Value))
				command.Parameters.AddWithValue("@p_Supplier", IIf(Me.Supplier.HasValue, Me.Supplier.Value, DBNull.Value))
				command.Parameters.AddWithValue("@p_Status", Me.Status)
				command.Parameters.AddWithValue("@p_Name", Me.Name)
				command.Parameters.AddWithValue("@p_Image", Me.Image)

            'result: The number of rows changed, inserted, or deleted. -1 for select statements; 0 if no rows were affected, or the statement failed. 
            Dim result As Integer = command.ExecuteNonQuery()
            If (result = 0) Then
                throw new DBConcurrencyException("The entity is out of date on the client. Please update the entity and try again. This could also be thrown if the sql statement failed to execute.")
            End If
            End Using
            _originalItemId = Me.ItemId


            FieldManager.UpdateChildren(Me, connection)
        End Using

        OnUpdated()
    End Sub

    <Transactional(TransactionalTypes.TransactionScope)> _
    Protected Overrides Sub DataPortal_DeleteSelf()
        Dim cancel As Boolean = False
        OnSelfDeleting(cancel)
        If (cancel) Then
            Return
        End If
    
        DataPortal_Delete(New ItemCriteria (_itemId))
    
        OnSelfDeleted()
    End Sub

    <Transactional(TransactionalTypes.TransactionScope)> _
    Protected Shadows Sub DataPortal_Delete(ByVal criteria As ItemCriteria )
        Dim cancel As Boolean = False
        OnDeleting(criteria, cancel)
        If (cancel) Then
            Return
        End If

        Dim commandText As String = String.Format("DELETE FROM [dbo].[Item] {0}", ADOHelper.BuildWhereStatement(criteria.StateBag))
        Using connection As New SqlConnection(ADOHelper.ConnectionString)
            connection.Open()
            Using command As New SqlCommand(commandText, connection)
                command.Parameters.AddRange(ADOHelper.SqlParameters(criteria.StateBag))

                'result: The number of rows changed, inserted, or deleted. -1 for select statements; 0 if no rows were affected, or the statement failed. 
                Dim result As Integer = command.ExecuteNonQuery()
                If (result = 0) Then
                    throw new DBConcurrencyException("The entity is out of date on the client. Please update the entity and try again. This could also be thrown if the sql statement failed to execute.")
                End If
            End Using
        End Using

        OnDeleted()
    End Sub

    #End Region

    #Region "Child Data Access"

    <RunLocal()> _
    Protected Overrides Sub Child_Create()
        Dim cancel As Boolean = False
        OnChildCreating(cancel)
        If (cancel) Then
            Return
        End If

        ProductId = "BN"
        ValidationRules.CheckRules()

        OnChildCreated()
    End Sub

    Private Sub Child_Fetch(ByVal criteria As ItemCriteria )
        Dim cancel As Boolean = False
        OnChildFetching(criteria, cancel)
        If (cancel) Then
            Return
        End If

        Dim commandText As String = String.Format("SELECT [ItemId], [ProductId], [ListPrice], [UnitCost], [Supplier], [Status], [Name], [Image] FROM [dbo].[Item] {0}", ADOHelper.BuildWhereStatement(criteria.StateBag))
        Using connection As New SqlConnection(ADOHelper.ConnectionString)
            connection.Open()
            Using command As New SqlCommand(commandText, connection)
                command.Parameters.AddRange(ADOHelper.SqlParameters(criteria.StateBag))
                Using reader As SafeDataReader = New SafeDataReader(command.ExecuteReader())
                    If reader.Read() Then
                        Map(reader)
                    Else
                        Throw New Exception(String.Format("The record was not found in 'Item' using the following criteria: {0}.", criteria))
                    End If
                End Using
            End Using
        End Using

        OnChildFetched()

        MarkAsChild()
    End Sub

    Private Sub Child_Insert(ByVal product As Product, ByVal supplier As Supplier, ByVal connection As SqlConnection)
        Dim cancel As Boolean = False
        OnChildInserting(cancel)
        If (cancel) Then
            Return
        End If

        If connection.State <> ConnectionState.Open Then connection.Open()
        Const commandText As String = "INSERT INTO [dbo].[Item] ([ItemId], [ProductId], [ListPrice], [UnitCost], [Supplier], [Status], [Name], [Image]) VALUES (@p_ItemId, @p_ProductId, @p_ListPrice, @p_UnitCost, @p_Supplier, @p_Status, @p_Name, @p_Image)"
        Using command As New SqlCommand(commandText, connection)
            command.Parameters.AddWithValue("@p_ItemId", Me.ItemId)
				command.Parameters.AddWithValue("@p_ProductId", product.ProductId)
				command.Parameters.AddWithValue("@p_ListPrice", IIf(Me.ListPrice.HasValue, Me.ListPrice.Value, DBNull.Value))
				command.Parameters.AddWithValue("@p_UnitCost", IIf(Me.UnitCost.HasValue, Me.UnitCost.Value, DBNull.Value))
				command.Parameters.AddWithValue("@p_Supplier", supplier.SuppId)
				command.Parameters.AddWithValue("@p_Status", Me.Status)
				command.Parameters.AddWithValue("@p_Name", Me.Name)
				command.Parameters.AddWithValue("@p_Image", Me.Image)

            'result: The number of rows changed, inserted, or deleted. -1 for select statements; 0 if no rows were affected, or the statement failed. 
            Dim result As Integer = command.ExecuteNonQuery()
            If (result = 0) Then
                throw new DBConcurrencyException("The entity is out of date on the client. Please update the entity and try again. This could also be thrown if the sql statement failed to execute.")
            End If

            _originalItemId = Me.ItemId
        End Using

        OnChildInserted()
    End Sub

    Private Sub Child_Update(ByVal product As Product, ByVal supplier As Supplier, ByVal connection As SqlConnection)
        Dim cancel As Boolean = False
        OnChildUpdating(cancel)
        If (cancel) Then
            Return
        End If

        If connection.State <> ConnectionState.Open Then connection.Open()
        Const commandText As String = "UPDATE [dbo].[Item]  SET [ItemId] = @p_ItemId, [ProductId] = @p_ProductId, [ListPrice] = @p_ListPrice, [UnitCost] = @p_UnitCost, [Supplier] = @p_Supplier, [Status] = @p_Status, [Name] = @p_Name, [Image] = @p_Image WHERE [ItemId] = @p_OriginalItemId"
        Using command As New SqlCommand(commandText, connection)
            command.Parameters.AddWithValue("@p_OriginalItemId", Me.OriginalItemId)
				command.Parameters.AddWithValue("@p_ItemId", Me.ItemId)
				command.Parameters.AddWithValue("@p_ProductId", product.ProductId)
				command.Parameters.AddWithValue("@p_ListPrice", IIf(Me.ListPrice.HasValue, Me.ListPrice.Value, DBNull.Value))
				command.Parameters.AddWithValue("@p_UnitCost", IIf(Me.UnitCost.HasValue, Me.UnitCost.Value, DBNull.Value))
				command.Parameters.AddWithValue("@p_Supplier", supplier.SuppId)
				command.Parameters.AddWithValue("@p_Status", Me.Status)
				command.Parameters.AddWithValue("@p_Name", Me.Name)
				command.Parameters.AddWithValue("@p_Image", Me.Image)

            'result: The number of rows changed, inserted, or deleted. -1 for select statements; 0 if no rows were affected, or the statement failed. 
            Dim result As Integer = command.ExecuteNonQuery()
            If (result = 0) Then
                throw new DBConcurrencyException("The entity is out of date on the client. Please update the entity and try again. This could also be thrown if the sql statement failed to execute.")
            End If

            _originalItemId = Me.ItemId
        End Using

        OnChildUpdated()
    End Sub

    Private Sub Child_DeleteSelf()
        Dim cancel As Boolean = False
        OnChildSelfDeleting(cancel)
        If (cancel) Then
            Return
        End If
    
        DataPortal_Delete(New ItemCriteria (_itemId))
    
        OnChildSelfDeleted()
    End Sub

    #End Region

    Private Sub Map(ByVal reader As SafeDataReader)
        Dim cancel As Boolean = False
        OnMapping(cancel)
        If (cancel) Then
            Return
        End If

        Using(BypassPropertyChecks)
            _itemId = reader.GetString("ItemId")
             _originalItemId = reader.GetString("ItemId")
            _productId = reader.GetString("ProductId")
            _listPrice = If(reader.IsDBNull("ListPrice"), Nothing, reader.GetDecimal("ListPrice"))
            _unitCost = If(reader.IsDBNull("UnitCost"), Nothing, reader.GetDecimal("UnitCost"))
            _supplier = If(reader.IsDBNull("Supplier"), Nothing, reader.GetInt32("Supplier"))
            _status = reader.GetString("Status")
            _name = reader.GetString("Name")
            _image = reader.GetString("Image")
        End Using

        OnMapped()

        MarkOld()
    End Sub
    
    #Region "Data access partial methods"

    Partial Private Sub OnCreating(ByRef cancel As Boolean)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnFetching(ByVal criteria As ItemCriteria, ByRef cancel As Boolean)
    End Sub
    Partial Private Sub OnFetched()
    End Sub
    Partial Private Sub OnMapping(ByRef cancel As Boolean)
    End Sub
    Partial Private Sub OnMapped()
    End Sub
    Partial Private Sub OnInserting(ByRef cancel As Boolean)
    End Sub
    Partial Private Sub OnInserted()
    End Sub
    Partial Private Sub OnUpdating(ByRef cancel As Boolean)
    End Sub
    Partial Private Sub OnUpdated()
    End Sub
    Partial Private Sub OnSelfDeleting(ByRef cancel As Boolean)
    End Sub
    Partial Private Sub OnSelfDeleted()
    End Sub
    Partial Private Sub OnDeleting(ByVal criteria As ItemCriteria, ByRef cancel As Boolean)
    End Sub
    Partial Private Sub OnDeleted()
    End Sub

    #End Region

    #Region "Child data access partial methods"

    Partial Private Sub OnChildCreating(ByRef cancel As Boolean)
    End Sub
    Partial Private Sub OnChildCreated()
    End Sub
    Partial Private Sub OnChildFetching(ByVal criteria As ItemCriteria , ByRef cancel As Boolean)
    End Sub
    Partial Private Sub OnChildFetched()
    End Sub
    Partial Private Sub OnChildInserting(ByRef cancel As Boolean)
    End Sub
    Partial Private Sub OnChildInserted()
    End Sub
    Partial Private Sub OnChildUpdating(ByRef cancel As Boolean)
    End Sub
    Partial Private Sub OnChildUpdated()
    End Sub
    Partial Private Sub OnChildSelfDeleting(ByRef cancel As Boolean)
    End Sub
    Partial Private Sub OnChildSelfDeleted()
    End Sub

    #End Region
End Class