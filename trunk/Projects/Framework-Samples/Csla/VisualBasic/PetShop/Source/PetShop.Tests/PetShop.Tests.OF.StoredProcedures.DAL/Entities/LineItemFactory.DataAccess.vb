﻿'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated using CodeSmith: v5.2.2, CSLA Templates: v3.0.0.0, CSLA Framework: v3.8.4.
'     Changes to this file will be lost after each regeneration.
'     To extend the functionality of this class, please modify the partial class 'LineItem.cs'.
'
'     Template: ObjectFactory.DataAccess.StoredProcedures.cst
'     Template website: http://code.google.com/p/codesmith/
' </autogenerated>
'------------------------------------------------------------------------------
Option Explicit On
Option Strict On

#Region "Imports declarations"

Imports System
Imports System.Data
Imports System.Data.SqlClient

Imports Csla
Imports Csla.Data
Imports Csla.Server

Imports PetShop.Tests.OF.StoredProcedures

#End Region

Namespace PetShop.Tests.OF.StoredProcedures.DAL
    Public Partial Class LineItemFactory
        Inherits ObjectFactory
    
#Region "Create"
    
        ''' <summary>
        ''' Creates New LineItem with default values.
        ''' </summary>
        ''' <Returns>New LineItem.</Returns>
        <RunLocal()> _
        Public Function Create() As LineItem
            Dim item As LineItem = CType(Activator.CreateInstance(GetType(LineItem), True), LineItem)
    
            Dim cancel As Boolean = False
            OnCreating(cancel)
            If (cancel) Then
                Return item
            End If
    
            Using BypassPropertyChecks(item)
                ' Default values.
    
    
                CheckRules(item)
                MarkNew(item)
            End Using
    
            OnCreated()
    
            Return item
        End Function
    
        ''' <summary>
        ''' Creates New LineItem with default values.
        ''' </summary>
        ''' <Returns>New LineItem.</Returns>
        <RunLocal()> _
        Private Function Create(ByVal criteria As LineItemCriteria) As  LineItem
            Dim item As LineItem = CType(Activator.CreateInstance(GetType(LineItem), True), LineItem)
    
            Dim cancel As Boolean = False
            OnCreating(cancel)
            If (cancel) Then
                Return item
            End If
    
            Dim resource As LineItem = Fetch(criteria)
    
            Using BypassPropertyChecks(item)
                item.ItemId = resource.ItemId
                item.Quantity = resource.Quantity
                item.UnitPrice = resource.UnitPrice
            End Using
    
            CheckRules(item)
            MarkNew(item)
    
            OnCreated()
    
            Return item
        End Function
    
#End Region
    
#Region "Fetch"
    
        ''' <summary>
        ''' Fetch LineItem.
        ''' </summary>
        ''' <param name="criteria">The criteria.</param>
        ''' <Returns></Returns>
        Public Function Fetch(ByVal criteria As LineItemCriteria) As LineItem
            Dim item As LineItem = Nothing
            
            Dim cancel As Boolean = False
            OnFetching(criteria, cancel)
            If (cancel) Then
                Return item
            End If
    
            Using connection As New SqlConnection(ADOHelper.ConnectionString)
                connection.Open()
                Using command As New SqlCommand("[dbo].[CSLA_LineItem_Select]", connection)
                    command.CommandType = CommandType.StoredProcedure
                    command.Parameters.AddRange(ADOHelper.SqlParameters(criteria.StateBag))
                    
                    Using reader As SafeDataReader = New SafeDataReader(command.ExecuteReader())
                        If reader.Read() Then
                            item = Map(reader)
                        Else
                            Throw New Exception(String.Format("The record was not found in 'LineItem' using the following criteria: {0}.", criteria))
                        End If
                    End Using
                End Using
            End Using
    
            MarkOld(item)
    
            OnFetched()
    
            Return item
        End Function
    
#End Region
    
#Region "Insert"
    
        Private Sub DoInsert(ByRef item As LineItem, ByVal stopProccessingChildren As Boolean)
            ' Don't update If the item isn't dirty.
            If Not (item.IsDirty) Then
                Return
            End If
    
            Dim cancel As Boolean = False
            OnInserting(cancel)
            If (cancel) Then
                Return
            End If
    
            Using connection As New SqlConnection(ADOHelper.ConnectionString)
                connection.Open()
                Using command As New SqlCommand("[dbo].[CSLA_LineItem_Insert]", connection)
                    command.CommandType = CommandType.StoredProcedure
                    command.Parameters.AddWithValue("@p_OrderId", item.OrderId)
				command.Parameters.AddWithValue("@p_LineNum", item.LineNum)
				command.Parameters.AddWithValue("@p_ItemId", item.ItemId)
				command.Parameters.AddWithValue("@p_Quantity", item.Quantity)
				command.Parameters.AddWithValue("@p_UnitPrice", item.UnitPrice)
    
                    command.ExecuteNonQuery()
    
                End Using
            End Using
    
            item.OriginalOrderId = item.OrderId
            item.OriginalLineNum = item.LineNum
    
            MarkOld(item)
            CheckRules(item)
            
            If Not (stopProccessingChildren) Then
                ' Update Child Items.
                Update_Order_OrderMember_OrderId(item)
            End If
    
            OnInserted()
        End Sub
    
#End Region
    
#Region "Update"
    
        <Transactional(TransactionalTypes.TransactionScope)> _
        Public Function Update(ByVal item As LineItem) As LineItem
            Return Update(item, false)
        End Function
    
        Public Function Update(ByVal item As LineItem, ByVal stopProccessingChildren as Boolean) As LineItem
            If(item.IsDeleted) Then
                DoDelete(item)
                MarkNew(item)
            Else If(item.IsNew) Then
                DoInsert(item, stopProccessingChildren)
            Else
            DoUpdate(item, stopProccessingChildren)
            End If
    
            Return item
        End Function
    
        Private Sub DoUpdate(ByRef item As LineItem, ByVal stopProccessingChildren As Boolean)
            Dim cancel As Boolean = False
            OnUpdating(cancel)
            If (cancel) Then
                Return
            End If
    
            ' Don't update If the item isn't dirty.
            If (item.IsDirty) Then
    
                If Not item.OriginalOrderId = item.OrderId Or Not item.OriginalLineNum = item.LineNum Then
                    ' Insert new child.
                    Dim temp As LineItem = CType(Activator.CreateInstance(GetType(LineItem), True), LineItem)
                    temp.OrderId = item.OrderId
			temp.LineNum = item.LineNum
			temp.ItemId = item.ItemId
			temp.Quantity = item.Quantity
			temp.UnitPrice = item.UnitPrice
                    temp = temp.Save()
    
                    ' Mark child lists as dirty. This code may need to be updated to one-to-one relationships.
    
                    ' Update Child Items.
                    Update_Order_OrderMember_OrderId(item)
        
                    ' Delete the old.
                    Dim criteria As New LineItemCriteria()
                    criteria.OrderId = item.OriginalOrderId
			criteria.LineNum = item.OriginalLineNum
                    Delete(criteria)
        
                    ' Mark the original as the new one.
                    item.OriginalOrderId = item.OrderId
                    item.OriginalLineNum = item.LineNum
                    MarkOld(item)
                    CheckRules(item)
    
                    OnUpdated()
    
                    Return
                End If
    
                Using connection As New SqlConnection(ADOHelper.ConnectionString)
                    connection.Open()
                    Using command As New SqlCommand("[dbo].[CSLA_LineItem_Update]", connection)
                        command.CommandType = CommandType.StoredProcedure
                        command.Parameters.AddWithValue("@p_OriginalOrderId", item.OriginalOrderId)
				command.Parameters.AddWithValue("@p_OrderId", item.OrderId)
				command.Parameters.AddWithValue("@p_OriginalLineNum", item.OriginalLineNum)
				command.Parameters.AddWithValue("@p_LineNum", item.LineNum)
				command.Parameters.AddWithValue("@p_ItemId", item.ItemId)
				command.Parameters.AddWithValue("@p_Quantity", item.Quantity)
				command.Parameters.AddWithValue("@p_UnitPrice", item.UnitPrice)
    
                        'result: The number of rows changed, inserted, or deleted. -1 for select statements; 0 if no rows were affected, or the statement failed. 
                        Dim result As Integer = command.ExecuteNonQuery()
                        If (result = 0) Then
                            throw new DBConcurrencyException("The entity is out of date on the client. Please update the entity and try again. This could also be thrown if the sql statement failed to execute.")
                        End If
                        
                    End Using
                End Using
            End If
    
            item.OriginalOrderId = item.OrderId
            item.OriginalLineNum = item.LineNum
    
            MarkOld(item)
            CheckRules(item)
    
            If Not (stopProccessingChildren) Then
                ' Update Child Items.
                Update_Order_OrderMember_OrderId(item)
            End If
    
            OnUpdated()
        End Sub
    
#End Region
    
#Region "Delete"
    
        <Transactional(TransactionalTypes.TransactionScope)> _
        Public Sub Delete(ByVal criteria As LineItemCriteria)
            ' Note: this call to delete is for immediate deletion and doesn't keep track of any entity state.
            DoDelete(criteria)
        End Sub
    
        Protected Sub DoDelete(ByRef item As LineItem)
            ' If we're not dirty then don't update the database.
            If Not (item.IsDirty) Then
                Return
            End If
    
            ' If we're New then don't call delete.
            If (item.IsNew) Then
                Return
            End If
    
            Dim criteria As New LineItemCriteria()
    criteria.OrderId = item.OrderId
			criteria.LineNum = item.LineNum
            DoDelete(criteria)
    
            MarkNew(item)
        End Sub
    
        Private Sub DoDelete(ByVal criteria As LineItemCriteria)
            Dim cancel As Boolean = False
            OnDeleting(criteria, cancel)
            If (cancel) Then
                Return
            End If
    
            Using connection As New SqlConnection(ADOHelper.ConnectionString)
                connection.Open()
                Using command As New SqlCommand("[dbo].[CSLA_LineItem_Delete]", connection)
                    command.CommandType = CommandType.StoredProcedure
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
    
#Region "Helper Methods"
    
        Public Function Map(ByVal reader As SafeDataReader) As LineItem
            Dim item As LineItem = CType(Activator.CreateInstance(GetType(LineItem), True), LineItem)
            Using BypassPropertyChecks(item)
                item.OrderId = reader.GetInt32("OrderId")
                item.OriginalOrderId = reader.GetInt32("OrderId")
                item.LineNum = reader.GetInt32("LineNum")
                item.OriginalLineNum = reader.GetInt32("LineNum")
                item.ItemId = reader.GetString("ItemId")
                item.Quantity = reader.GetInt32("Quantity")
                item.UnitPrice = reader.GetDecimal("UnitPrice")
            End Using
    
            MarkOld(item)
            Return item
        End Function
    
        'AssociatedManyToOne
        Private Shared Sub Update_Order_OrderMember_OrderId(ByRef item As LineItem)
    		item.OrderMember.OrderId = item.OrderId
    
            Dim factory As New OrderFactory
            factory.Update(item.OrderMember, True)
        End Sub
    
#End Region
    
#Region "DataPortal partial methods"
    
        Partial Private Sub OnCreating(ByRef cancel As Boolean)
        End Sub
        Partial Private Sub OnCreated()
        End Sub
        Partial Private Sub OnFetching(ByVal criteria As LineItemCriteria, ByRef cancel As Boolean)
        End Sub
        Partial Private Sub OnFetched()
        End Sub
        Partial Private Sub OnMapping(ByVal reader As SafeDataReader, ByRef cancel As Boolean)
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
        Partial Private Sub OnDeleting(ByVal criteria As LineItemCriteria, ByRef cancel As Boolean)
        End Sub
        Partial Private Sub OnDeleted()
        End Sub
    
#End Region
    End Class
End Namespace