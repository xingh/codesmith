﻿'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated using CodeSmith: v6.5.0, CSLA Templates: v4.0.0.0, CSLA Framework: v4.3.10.
'     Changes to this file will be lost after each regeneration.
'     To extend the functionality of this class, please modify the partial class 'OrderList.vb.
'
'     Template: EditableChildList.Generated.cst
'     Template website: http://code.google.com/p/codesmith/
' </autogenerated>
'------------------------------------------------------------------------------
Option Explicit On
Option Strict On

Imports System
Imports System.Collections.Generic
Imports System.Linq

Imports Csla
Imports Csla.Data

Namespace PetShop.Tests.OF.StoredProcedures
    <Serializable()> _
    <Csla.Server.ObjectFactory(FactoryNames.OrderListFactoryName)> _
    Public Partial Class OrderList 
        Inherits BusinessListBase(Of OrderList, Order)
    
#Region "Contructor(s)"

        public Sub New()
            AllowNew = true
            MarkAsChild()
        End Sub
    
#End Region

#Region "Synchronous Factory Methods" 

        ''' <summary>
        ''' Creates a new object of type <see cref="OrderList"/>. 
        ''' </summary>
        ''' <returns>Returns a newly instantiated collection of type <see cref="OrderList"/>.</returns>
        Friend Shared Function NewList() As OrderList
            Return DataPortal.CreateChild(Of OrderList)()
        End Function

        ''' <summary>
        ''' Returns a <see cref="OrderList"/> object of the specified criteria. 
        ''' </summary>
        ''' <param name="orderId">No additional detail available.</param>
        ''' <returns>A <see cref="OrderList"/> object of the specified criteria.</returns>
        Friend Shared Function GetByOrderId(ByVal orderId As System.Int32) As OrderList 
            Dim criteria As New OrderCriteria()
                        criteria.OrderId = orderId
    
            Return DataPortal.Fetch(Of OrderList)(criteria)
        End Function

        Friend Shared Function GetByCriteria(ByVal criteria As OrderCriteria) As OrderList
            Return DataPortal.Fetch(Of OrderList)(criteria)
        End Function

        Friend Shared Function GetAll() As OrderList
            Return DataPortal.Fetch(Of OrderList)(New OrderCriteria())
        End Function

#End Region
    
#Region "Asynchronous Factory Methods"

        Friend Shared Sub NewListAsync(ByVal handler As EventHandler(Of DataPortalResult(Of OrderList)))
            Dim dp As New DataPortal(Of OrderList)()
            AddHandler dp.CreateCompleted, handler
            dp.BeginCreate()
        End Sub
    
        Friend Shared Sub GetByOrderIdAsync(ByVal orderId As System.Int32, ByVal handler As EventHandler(Of DataPortalResult(Of AsyncChildLoader(Of OrderList))))
            Dim criteria As New OrderCriteria()
                        criteria.OrderId = orderId

            DataPortal.BeginFetch(Of AsyncChildLoader(Of OrderList))(criteria, handler)
        End Sub

        Friend Shared Sub GetByCriteriaAsync(ByVal criteria As OrderCriteria, ByVal handler As EventHandler(Of DataPortalResult(Of OrderList)))
            Dim dp As New DataPortal(Of OrderList)()
            AddHandler dp.FetchCompleted, handler

            ' Mark as child?
            dp.BeginFetch(criteria)
        End Sub

        Friend Shared Sub GetAllAsync(ByVal handler As EventHandler(Of DataPortalResult(Of AsyncChildLoader(Of OrderList))))
            DataPortal.BeginFetch(Of AsyncChildLoader(Of OrderList))(New OrderCriteria(), handler)
        End Sub 

#End Region
    
#Region "Method Overrides"
    
        Protected Overrides Function AddNewCore() As Order
            Dim item As Order = PetShop.Tests.OF.StoredProcedures.Order.NewOrderChild()

            Dim cancel As Boolean = False
            OnAddNewCore(item, cancel)
            If Not (cancel) Then
                ' Check to see if someone set the item to null In the OnAddNewCore.
                If(item Is Nothing) Then
                    item = PetShop.Tests.OF.StoredProcedures.Order.NewOrderChild()
                End If
                Add(item)
            End If

            Return item
        End Function
#End Region

        Protected Sub AddNewCoreAsync(ByVal handler As EventHandler(Of DataPortalResult(Of Order)))
            PetShop.Tests.OF.StoredProcedures.Order.NewOrderChildAsync(Sub(o, e)
                    If e.Error Is Nothing Then
                        Add(e.Object)
                        handler.Invoke(Me, New DataPortalResult(Of Order)(e.Object, Nothing, Nothing))
                    End If
                End Sub)
        End Sub

#Region "Property overrides"
    
            ''' <summary>
            ''' Returns true if any children are dirty
            ''' </summary>
            Public Shadows ReadOnly Property IsDirty() As Boolean
                Get
                    For Each item As Order In Me.Items
                        If item.IsDirty Then
                            Return True
                        End If
                    Next
            
                    Return False
                End Get
            End Property
    
#End Region
    
#Region "DataPortal partial methods"
    
        ''' <summary>
        ''' CodeSmith generated stub method that is called when creating the child <see cref="Order"/> object. 
        ''' </summary>
        ''' <param name="cancel">Value returned from the method indicating whether the object creation should proceed.</param>
        Partial Private Sub OnCreating(ByRef cancel As Boolean)
        End Sub

        ''' <summary>
        ''' CodeSmith generated stub method that is called after the child <see cref="Order"/> object has been created. 
        ''' </summary>
        Partial Private Sub OnCreated()
        End Sub

        ''' <summary>
        ''' CodeSmith generated stub method that is called when fetching the child <see cref="Order"/> object. 
        ''' </summary>
        ''' <param name="criteria"><see cref="OrderCriteria"/> object containing the criteria of the object to fetch.</param>
        ''' <param name="cancel">Value returned from the method indicating whether the object fetching should proceed.</param>
        Partial Private Sub OnFetching(ByVal criteria As OrderCriteria, ByRef cancel As Boolean)
        End Sub

        ''' <summary>
        ''' CodeSmith generated stub method that is called after the child <see cref="Order"/> object has been fetched. 
        ''' </summary>
        Partial Private Sub OnFetched()
        End Sub

        ''' <summary>
        ''' CodeSmith generated stub method that is called when mapping the child <see cref="Order"/> object. 
        ''' </summary>
        ''' <param name="cancel">Value returned from the method indicating whether the object mapping should proceed.</param>
        Partial Private Sub OnMapping(ByRef cancel As Boolean)
        End Sub

        ''' <summary>
        ''' CodeSmith generated stub method that is called when mapping the child <see cref="Order"/> object. 
        ''' </summary>
        ''' <param name="reader"></param>
        ''' <param name="cancel">Value returned from the method indicating whether the object mapping should proceed.</param>
        Partial Private Sub OnMapping(ByVal reader As SafeDataReader, ByRef cancel As Boolean)
        End Sub

        ''' <summary>
        ''' CodeSmith generated stub method that is called after the child <see cref="Order"/> object has been mapped. 
        ''' </summary>
        Partial Private Sub OnMapped()
        End Sub

        ''' <summary>
        ''' CodeSmith generated stub method that is called when updating the <see cref="Order"/> object. 
        ''' </summary>
        ''' <param name="cancel">Value returned from the method indicating whether the object creation should proceed.</param>
        Partial Private Sub OnUpdating(ByRef cancel As Boolean)
        End Sub

        ''' <summary>
        ''' CodeSmith generated stub method that is called after the <see cref="Order"/> object has been updated. 
        ''' </summary>
        Partial Private Sub OnUpdated()
        End Sub
        Partial Private Sub OnAddNewCore(ByRef item As Order, ByRef cancel As Boolean)
        End Sub
    
#End Region
#Region "Exists Command"

        ''' <summary>
        ''' Determines if a record exists in the Order in the database for the specified criteria. 
        ''' </summary>
        ''' <param name="criteria">The criteria parameter is a <see cref="OrderList"/> object.</param>
        ''' <returns>A boolean value of true is returned if a record is found.</returns>
        Public Shared Function Exists(ByVal criteria As OrderCriteria) As Boolean
            Return PetShop.Tests.OF.StoredProcedures.Order.Exists(criteria)
        End Function

        ''' <summary>
        ''' Determines if a record exists in the Order in the database for the specified criteria. 
        ''' </summary>
        Public Shared Sub ExistsAsync(ByVal criteria As OrderCriteria, ByVal handler As EventHandler(Of DataPortalResult(Of ExistsCommand)))
            PetShop.Tests.OF.StoredProcedures.Order.ExistsAsync(criteria, handler)
        End Sub

#End Region
 
#region "Enhancements"

        Public Function GetOrder(ByVal orderId As System.Int32) As Order
            Return Me.FirstOrDefault(Function(i As Order) i.OrderId = orderId)
        End Function
        
        Public Overloads Function Contains(ByVal orderId As System.Int32) As Boolean
            Return Me.Where(Function(i As Order) i.OrderId = orderId).Count() > 0
        End Function

        Public Overloads Function ContainsDeleted(ByVal orderId As System.Int32) As Boolean
            Return DeletedList.Where(Function(i As Order) i.OrderId = orderId).Count() > 0
        End Function

        Public Overloads Sub Remove(ByVal orderId As System.Int32)
            Dim item As Order = Me.FirstOrDefault(Function(i As Order) i.OrderId = orderId)
            If item IsNot Nothing Then
                Remove(item)
            End If
        End Sub
        
#End Region
    End Class
End Namespace