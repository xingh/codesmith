'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated using CodeSmith: v5.2.1, CSLA Templates: v1.5.0.0, CSLA Framework: v3.8.0.
'     Changes to this template will not be lost.
'
'     Template: ObjectFactory.DataAccess.ParameterizedSQL.cst
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

Imports PetShop.Tests.OF.ParameterizedSQL

#End Region

Public Partial Class OrderFactory
    Inherits ObjectFactory

    #Region "Create"

    ''' <summary>
    ''' Creates New Order with default values.
    ''' </summary>
    ''' <Returns>New Order.</Returns>
    <RunLocal()> _
    Public Function Create() As Order
        Dim item As Order = CType(Activator.CreateInstance(GetType(Order), True), Order)

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
    ''' Creates New Order with default values.
    ''' </summary>
    ''' <Returns>New Order.</Returns>
    <RunLocal()> _
    Private Function Create(ByVal criteria As OrderCriteria) As  Order
        Dim item As Order = CType(Activator.CreateInstance(GetType(Order), True), Order)

        Dim cancel As Boolean = False
        OnCreating(cancel)
        If (cancel) Then
            Return item
        End If

        Dim resource As Order = Fetch(criteria)

        Using BypassPropertyChecks(item)
            item.UserId = resource.UserId
            item.OrderDate = resource.OrderDate
            item.ShipAddr1 = resource.ShipAddr1
            item.ShipAddr2 = resource.ShipAddr2
            item.ShipCity = resource.ShipCity
            item.ShipState = resource.ShipState
            item.ShipZip = resource.ShipZip
            item.ShipCountry = resource.ShipCountry
            item.BillAddr1 = resource.BillAddr1
            item.BillAddr2 = resource.BillAddr2
            item.BillCity = resource.BillCity
            item.BillState = resource.BillState
            item.BillZip = resource.BillZip
            item.BillCountry = resource.BillCountry
            item.Courier = resource.Courier
            item.TotalPrice = resource.TotalPrice
            item.BillToFirstName = resource.BillToFirstName
            item.BillToLastName = resource.BillToLastName
            item.ShipToFirstName = resource.ShipToFirstName
            item.ShipToLastName = resource.ShipToLastName
            item.AuthorizationNumber = resource.AuthorizationNumber
            item.Locale = resource.Locale
        End Using

        CheckRules(item)
        MarkNew(item)

        OnCreated()

        Return item
    End Function

    #End Region

    #Region "Fetch

    ''' <summary>
    ''' Fetch Order.
    ''' </summary>
    ''' <param name="criteria">The criteria.</param>
    ''' <Returns></Returns>
    Public Function Fetch(ByVal criteria As OrderCriteria) As Order
        Dim item As Order = Nothing
        
        Dim cancel As Boolean = False
        OnFetching(criteria, cancel)
        If (cancel) Then
            Return item
        End If

        Dim commandText As String = String.Format("SELECT [OrderId], [UserId], [OrderDate], [ShipAddr1], [ShipAddr2], [ShipCity], [ShipState], [ShipZip], [ShipCountry], [BillAddr1], [BillAddr2], [BillCity], [BillState], [BillZip], [BillCountry], [Courier], [TotalPrice], [BillToFirstName], [BillToLastName], [ShipToFirstName], [ShipToLastName], [AuthorizationNumber], [Locale] FROM [dbo].[Orders] {0}", ADOHelper.BuildWhereStatement(criteria.StateBag))
        Using connection As New SqlConnection(ADOHelper.ConnectionString)
            connection.Open()
            Using command As New SqlCommand(commandText, connection)
                command.Parameters.AddRange(ADOHelper.SqlParameters(criteria.StateBag))
                Using reader As SafeDataReader = New SafeDataReader(command.ExecuteReader())
                    If reader.Read() Then
                        item = Map(reader)
                    Else
                        Throw New Exception(String.Format("The record was not found in 'Orders' using the following criteria: {0}.", criteria))
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

    Private Sub DoInsert(ByVal item As Order, ByVal stopProccessingChildren As Boolean)
        ' Don't update If the item isn't dirty.
        If Not (item.IsDirty) Then
            Return
        End If

        Dim cancel As Boolean = False
        OnInserting(cancel)
        If (cancel) Then
            Return
        End If

        Const commandText As String = "INSERT INTO [dbo].[Orders] ([UserId], [OrderDate], [ShipAddr1], [ShipAddr2], [ShipCity], [ShipState], [ShipZip], [ShipCountry], [BillAddr1], [BillAddr2], [BillCity], [BillState], [BillZip], [BillCountry], [Courier], [TotalPrice], [BillToFirstName], [BillToLastName], [ShipToFirstName], [ShipToLastName], [AuthorizationNumber], [Locale]) VALUES (@p_UserId, @p_OrderDate, @p_ShipAddr1, @p_ShipAddr2, @p_ShipCity, @p_ShipState, @p_ShipZip, @p_ShipCountry, @p_BillAddr1, @p_BillAddr2, @p_BillCity, @p_BillState, @p_BillZip, @p_BillCountry, @p_Courier, @p_TotalPrice, @p_BillToFirstName, @p_BillToLastName, @p_ShipToFirstName, @p_ShipToLastName, @p_AuthorizationNumber, @p_Locale); SELECT [OrderId] FROM [dbo].[Orders] WHERE OrderId = SCOPE_IDENTITY()"
        Using connection As New SqlConnection(ADOHelper.ConnectionString)
            connection.Open()
            Using command As New SqlCommand(commandText, connection)
                command.Parameters.AddWithValue("@p_UserId", item.UserId)
				command.Parameters.AddWithValue("@p_OrderDate", item.OrderDate)
				command.Parameters.AddWithValue("@p_ShipAddr1", item.ShipAddr1)
				command.Parameters.AddWithValue("@p_ShipAddr2", item.ShipAddr2)
				command.Parameters.AddWithValue("@p_ShipCity", item.ShipCity)
				command.Parameters.AddWithValue("@p_ShipState", item.ShipState)
				command.Parameters.AddWithValue("@p_ShipZip", item.ShipZip)
				command.Parameters.AddWithValue("@p_ShipCountry", item.ShipCountry)
				command.Parameters.AddWithValue("@p_BillAddr1", item.BillAddr1)
				command.Parameters.AddWithValue("@p_BillAddr2", item.BillAddr2)
				command.Parameters.AddWithValue("@p_BillCity", item.BillCity)
				command.Parameters.AddWithValue("@p_BillState", item.BillState)
				command.Parameters.AddWithValue("@p_BillZip", item.BillZip)
				command.Parameters.AddWithValue("@p_BillCountry", item.BillCountry)
				command.Parameters.AddWithValue("@p_Courier", item.Courier)
				command.Parameters.AddWithValue("@p_TotalPrice", item.TotalPrice)
				command.Parameters.AddWithValue("@p_BillToFirstName", item.BillToFirstName)
				command.Parameters.AddWithValue("@p_BillToLastName", item.BillToLastName)
				command.Parameters.AddWithValue("@p_ShipToFirstName", item.ShipToFirstName)
				command.Parameters.AddWithValue("@p_ShipToLastName", item.ShipToLastName)
				command.Parameters.AddWithValue("@p_AuthorizationNumber", item.AuthorizationNumber)
				command.Parameters.AddWithValue("@p_Locale", item.Locale)

                Using reader As SafeDataReader = New SafeDataReader(command.ExecuteReader())
                    If reader.Read() Then

                        item.OrderId = reader.GetInt32("OrderId")
                    End If
                End Using
            End Using
        End Using

        MarkOld(item)
        CheckRules(item)
        
        If Not (stopProccessingChildren) Then
            ' Update Child Items.
            Update_LineItem_LineItems_OrderId(item)
            Update_OrderStatus_OrderStatuses_OrderId(item)
        End If

        OnInserted()
    End Sub

    #End Region

    #Region "Update"

    <Transactional(TransactionalTypes.TransactionScope)> _
    Public Function Update(ByVal item As Order) As Order
        Return Update(item, false)
    End Function

    Public Function Update(ByVal item As Order, ByVal stopProccessingChildren as Boolean) As Order
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

    Private Sub DoUpdate(ByVal item As Order, ByVal stopProccessingChildren As Boolean)
        Dim cancel As Boolean = False
        OnUpdating(cancel)
        If (cancel) Then
            Return
        End If

        ' Don't update If the item isn't dirty.
        If (item.IsDirty) Then
            Const commandText As String = "UPDATE [dbo].[Orders]  SET [UserId] = @p_UserId, [OrderDate] = @p_OrderDate, [ShipAddr1] = @p_ShipAddr1, [ShipAddr2] = @p_ShipAddr2, [ShipCity] = @p_ShipCity, [ShipState] = @p_ShipState, [ShipZip] = @p_ShipZip, [ShipCountry] = @p_ShipCountry, [BillAddr1] = @p_BillAddr1, [BillAddr2] = @p_BillAddr2, [BillCity] = @p_BillCity, [BillState] = @p_BillState, [BillZip] = @p_BillZip, [BillCountry] = @p_BillCountry, [Courier] = @p_Courier, [TotalPrice] = @p_TotalPrice, [BillToFirstName] = @p_BillToFirstName, [BillToLastName] = @p_BillToLastName, [ShipToFirstName] = @p_ShipToFirstName, [ShipToLastName] = @p_ShipToLastName, [AuthorizationNumber] = @p_AuthorizationNumber, [Locale] = @p_Locale WHERE [OrderId] = @p_OrderId"
            Using connection As New SqlConnection(ADOHelper.ConnectionString)
                connection.Open()
                Using command As New SqlCommand(commandText, connection)
                    command.Parameters.AddWithValue("@p_OrderId", item.OrderId)
				command.Parameters.AddWithValue("@p_UserId", item.UserId)
				command.Parameters.AddWithValue("@p_OrderDate", item.OrderDate)
				command.Parameters.AddWithValue("@p_ShipAddr1", item.ShipAddr1)
				command.Parameters.AddWithValue("@p_ShipAddr2", item.ShipAddr2)
				command.Parameters.AddWithValue("@p_ShipCity", item.ShipCity)
				command.Parameters.AddWithValue("@p_ShipState", item.ShipState)
				command.Parameters.AddWithValue("@p_ShipZip", item.ShipZip)
				command.Parameters.AddWithValue("@p_ShipCountry", item.ShipCountry)
				command.Parameters.AddWithValue("@p_BillAddr1", item.BillAddr1)
				command.Parameters.AddWithValue("@p_BillAddr2", item.BillAddr2)
				command.Parameters.AddWithValue("@p_BillCity", item.BillCity)
				command.Parameters.AddWithValue("@p_BillState", item.BillState)
				command.Parameters.AddWithValue("@p_BillZip", item.BillZip)
				command.Parameters.AddWithValue("@p_BillCountry", item.BillCountry)
				command.Parameters.AddWithValue("@p_Courier", item.Courier)
				command.Parameters.AddWithValue("@p_TotalPrice", item.TotalPrice)
				command.Parameters.AddWithValue("@p_BillToFirstName", item.BillToFirstName)
				command.Parameters.AddWithValue("@p_BillToLastName", item.BillToLastName)
				command.Parameters.AddWithValue("@p_ShipToFirstName", item.ShipToFirstName)
				command.Parameters.AddWithValue("@p_ShipToLastName", item.ShipToLastName)
				command.Parameters.AddWithValue("@p_AuthorizationNumber", item.AuthorizationNumber)
				command.Parameters.AddWithValue("@p_Locale", item.Locale)

                    Using reader As SafeDataReader = New SafeDataReader(command.ExecuteReader())
                        'RecordsAffected: The number of rows changed, inserted, or deleted. -1 for select statements; 0 if no rows were affected, or the statement failed. 
                        If reader.RecordsAffected = 0 Then
                            Throw New DBConcurrencyException("The entity is out of date on the client. Please update the entity and try again. This could also be thrown if the sql statement failed to execute.")
                        End If
                    End Using
                End Using
            End Using
        End If

        MarkOld(item)
        CheckRules(item)

        If Not (stopProccessingChildren) Then
            ' Update Child Items.
            Update_LineItem_LineItems_OrderId(item)
            Update_OrderStatus_OrderStatuses_OrderId(item)
        End If

        OnUpdated()
    End Sub

    #End Region

    #Region "Delete"

    <Transactional(TransactionalTypes.TransactionScope)> _
    Public Sub Delete(ByVal criteria As OrderCriteria)
        ' Note: this call to delete is for immediate deletion and doesn't keep track of any entity state.
        DoDelete(criteria)
    End Sub

    Protected Sub DoDelete(ByVal item As Order)
        ' If we're not dirty then don't update the database.
        If Not (item.IsDirty) Then
            Return
        End If

        ' If we're New then don't call delete.
        If (item.IsNew) Then
            Return
        End If

        Dim criteria As New OrderCriteria()
criteria.OrderId = item.OrderId
        DoDelete(criteria)

        MarkNew(item)
    End Sub

    Private Sub DoDelete(ByVal criteria As OrderCriteria)
        Dim cancel As Boolean = False
        OnDeleting(criteria, cancel)
        If (cancel) Then
            Return
        End If

        Dim commandText As String = String.Format("DELETE FROM [dbo].[Orders] {0}", ADOHelper.BuildWhereStatement(criteria.StateBag))
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

    #Region "Helper Methods"

    Public Function Map(ByVal reader As SafeDataReader) As Order
        Dim item As Order = CType(Activator.CreateInstance(GetType(Order), True), Order)
        Using BypassPropertyChecks(item)
            item.OrderId = reader.GetInt32("OrderId")
            item.UserId = reader.GetString("UserId")
            item.OrderDate = reader.GetDateTime("OrderDate")
            item.ShipAddr1 = reader.GetString("ShipAddr1")
            item.ShipAddr2 = reader.GetString("ShipAddr2")
            item.ShipCity = reader.GetString("ShipCity")
            item.ShipState = reader.GetString("ShipState")
            item.ShipZip = reader.GetString("ShipZip")
            item.ShipCountry = reader.GetString("ShipCountry")
            item.BillAddr1 = reader.GetString("BillAddr1")
            item.BillAddr2 = reader.GetString("BillAddr2")
            item.BillCity = reader.GetString("BillCity")
            item.BillState = reader.GetString("BillState")
            item.BillZip = reader.GetString("BillZip")
            item.BillCountry = reader.GetString("BillCountry")
            item.Courier = reader.GetString("Courier")
            item.TotalPrice = reader.GetDecimal("TotalPrice")
            item.BillToFirstName = reader.GetString("BillToFirstName")
            item.BillToLastName = reader.GetString("BillToLastName")
            item.ShipToFirstName = reader.GetString("ShipToFirstName")
            item.ShipToLastName = reader.GetString("ShipToLastName")
            item.AuthorizationNumber = reader.GetInt32("AuthorizationNumber")
            item.Locale = reader.GetString("Locale")
        End Using

        Return item
    End Function

    'AssociatedOneToMany
    Private Shared Sub  Update_LineItem_LineItems_OrderId(ByRef item As Order)
        For Each itemToUpdate As LineItem In item.LineItems
		itemToUpdate.OrderId = item.OrderId

            Dim factory As New LineItemFactory
            factory.Update(itemToUpdate, True)
        Next
    End Sub
    'AssociatedOneToMany
    Private Shared Sub  Update_OrderStatus_OrderStatuses_OrderId(ByRef item As Order)
        For Each itemToUpdate As OrderStatus In item.OrderStatuses
		itemToUpdate.OrderId = item.OrderId

            Dim factory As New OrderStatusFactory
            factory.Update(itemToUpdate, True)
        Next
    End Sub

    #End Region

    #Region "Data access partial methods"

    Partial Private Sub OnCreating(ByRef cancel As Boolean)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnFetching(ByVal criteria As OrderCriteria, ByRef cancel As Boolean)
    End Sub
    Partial Private Sub OnFetched()
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
    Partial Private Sub OnDeleting(ByVal criteria As OrderCriteria, ByRef cancel As Boolean)
    End Sub
    Partial Private Sub OnDeleted()
    End Sub

    #End Region
End Class