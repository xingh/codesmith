﻿'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated using CodeSmith: v6.5.0, CSLA Templates: v4.0.0.0, CSLA Framework: v4.3.10.
'     Changes to this file will be lost after each regeneration.
'     To extend the functionality of this class, please modify the partial class 'OrderStatus.vb.
'
'     Template path: EditableRoot.Generated.cst
'     Template website: http://code.google.com/p/codesmith/
' </autogenerated>
'------------------------------------------------------------------------------
Option Explicit On
Option Strict On

Imports System

Imports Csla
#If SILVERLIGHT Then
Imports Csla.Serialization
#Else
Imports Csla.Data
#End If

Imports Csla.Rules

Namespace PetShop.Business
    <Serializable()> _
    Public Partial Class OrderStatus
        Inherits BusinessBase(Of OrderStatus)
    
#Region "Contructor(s)"

        public Sub New()
            ' require use of factory method 
        End Sub

#End Region    
#Region "Business Rules"

        ''' <summary>
        ''' Contains the CodeSmith generated validation rules.
        ''' </summary>
        Protected Overrides Sub AddBusinessRules()
            ' Call the base class, if this call isn't made than any declared System.ComponentModel.DataAnnotations rules will not work.
            MyBase.AddBusinessRules()

            If AddBusinessValidationRules() Then Exit Sub
    
            BusinessRules.AddRule(New Global.Csla.Rules.CommonRules.Required(_statusProperty))
            BusinessRules.AddRule(New Global.Csla.Rules.CommonRules.MaxLength(_statusProperty, 2))
        End Sub
    
#End Region

#Region "Properties"
    
        Private Shared ReadOnly _orderIdProperty As PropertyInfo(Of System.Int32) = RegisterProperty(Of System.Int32)(Function(p As OrderStatus) p.OrderId, "Order Id")
#If Not SILVERLIGHT Then
        
        <System.ComponentModel.DataObjectField(true, false)> _
        Public Property OrderId() As System.Int32
#Else
        Public Property OrderId() As System.Int32
#End If
            Get 
                Return GetProperty(_orderIdProperty)
            End Get
            Set (ByVal value As System.Int32)
                SetProperty(_orderIdProperty, value)
            End Set
        End Property

        Private Shared ReadOnly _originalOrderIdProperty As PropertyInfo(Of System.Int32) = RegisterProperty(Of System.Int32)(Function(p As OrderStatus) p.OriginalOrderId, "Original Order Id")
        ''' <summary>
        ''' Holds the original value for OrderId. This is used for non identity primary keys.
        ''' </summary>
        Friend Property OriginalOrderId() As System.Int32
            Get 
                Return GetProperty(_originalOrderIdProperty) 
            End Get
            Set (value As System.Int32)
                SetProperty(_originalOrderIdProperty, value)
            End Set
        End Property

        Private Shared ReadOnly _lineNumProperty As PropertyInfo(Of System.Int32) = RegisterProperty(Of System.Int32)(Function(p As OrderStatus) p.LineNum, "Line Num")
#If Not SILVERLIGHT Then
        
        <System.ComponentModel.DataObjectField(true, false)> _
        Public Property LineNum() As System.Int32
#Else
        Public Property LineNum() As System.Int32
#End If
            Get 
                Return GetProperty(_lineNumProperty)
            End Get
            Set (ByVal value As System.Int32)
                SetProperty(_lineNumProperty, value)
            End Set
        End Property

        Private Shared ReadOnly _originalLineNumProperty As PropertyInfo(Of System.Int32) = RegisterProperty(Of System.Int32)(Function(p As OrderStatus) p.OriginalLineNum, "Original Line Num")
        ''' <summary>
        ''' Holds the original value for LineNum. This is used for non identity primary keys.
        ''' </summary>
        Friend Property OriginalLineNum() As System.Int32
            Get 
                Return GetProperty(_originalLineNumProperty) 
            End Get
            Set (value As System.Int32)
                SetProperty(_originalLineNumProperty, value)
            End Set
        End Property

        Private Shared ReadOnly _timestampProperty As PropertyInfo(Of System.DateTime) = RegisterProperty(Of System.DateTime)(Function(p As OrderStatus) p.Timestamp, "Timestamp")
        
        Public Property Timestamp() As System.DateTime
            Get 
                Return GetProperty(_timestampProperty)
            End Get
            Set (ByVal value As System.DateTime)
                SetProperty(_timestampProperty, value)
            End Set
        End Property

        Private Shared ReadOnly _statusProperty As PropertyInfo(Of System.String) = RegisterProperty(Of System.String)(Function(p As OrderStatus) p.Status, "Status")
        
        Public Property Status() As System.String
            Get 
                Return GetProperty(_statusProperty)
            End Get
            Set (ByVal value As System.String)
                SetProperty(_statusProperty, value)
            End Set
        End Property

        'Associations.Where(Function(a) a.AssociationType = AssociationType.ManyToOne OrElse a.AssociationType = AssociationType.ManyToZeroOrOne)
        Private Shared ReadOnly _orderProperty As PropertyInfo(Of Order) = RegisterProperty(Of Order)(Function(p As OrderStatus) p.Order, Csla.RelationshipTypes.Child)
        Public ReadOnly Property Order() As Order
            Get
                Dim cancel As Boolean = False
                OnChildLoading(_orderProperty, cancel)
                
                If Not cancel Then
                    If(False) Then
                        Return Nothing
                    End If
    
                    If Not(FieldManager.FieldExists(_orderProperty))
                        Dim criteria As New PetShop.Business.OrderCriteria()
                        criteria.OrderId = OrderId

#If SILVERLIGHT Then
                        'Markbusy()
                        PetShop.Business.Order.ExistsAsync(criteria, Sub(o, e)
                            If Not (e.Error Is Nothing) Then
                                Throw e.Error
                            End If
                            
                            If (e.Object.Result) Then
                                PetShop.Business.Order.GetByOrderIdAsync(OrderId, Sub(o1, e1)
                                    If Not (e1.Error Is Nothing) Then
                                        Throw e1.Error
                                    End If

                                    Me.LoadProperty(_orderProperty, e1.Object)

                                    'MarkIdle()
                                    OnPropertyChanged(_orderProperty)
                                End Sub)
                            End If
                        End Sub)
#Else
                        If (PetShop.Business.Order.Exists(criteria)) Then
                            LoadProperty(_orderProperty, PetShop.Business.Order.GetByOrderId(OrderId))
                        End If
#End If
                    End If
                End If

                Return GetProperty(_orderProperty) 
            End Get
        End Property

#End Region
    
#Region "Synchronous Factory Methods"
#If Not SILVERLIGHT Then

        ''' <summary>
        ''' Creates a new object of type <see cref="OrderStatus"/>. 
        ''' </summary>
        ''' <returns>Returns a newly instantiated collection of type <see cref="OrderStatus"/>.</returns>    
        Public Shared Function NewOrderStatus() As OrderStatus
            Return DataPortal.Create(Of OrderStatus)()
        End Function
        ''' <summary>
        ''' Returns a <see cref="OrderStatus"/> object of the specified criteria. 
        ''' </summary>
        ''' <param name="orderId">No additional detail available.</param>
        ''' <param name="lineNum">No additional detail available.</param>
        ''' <returns>A <see cref="OrderStatus"/> object of the specified criteria.</returns>
        Public Shared Function GetByOrderIdLineNum(ByVal orderId As System.Int32, ByVal lineNum As System.Int32) As OrderStatus
            Dim criteria As New OrderStatusCriteria()
                        criteria.OrderId = orderId
            criteria.LineNum = lineNum
            
            Return DataPortal.Fetch(Of OrderStatus)(criteria)
        End Function
        ''' <summary>
        ''' Returns a <see cref="OrderStatus"/> object of the specified criteria. 
        ''' </summary>
        ''' <param name="orderId">No additional detail available.</param>
        ''' <returns>A <see cref="OrderStatus"/> object of the specified criteria.</returns>
        Public Shared Function GetByOrderId(ByVal orderId As System.Int32) As OrderStatus
            Dim criteria As New OrderStatusCriteria()
                        criteria.OrderId = orderId
            
            Return DataPortal.Fetch(Of OrderStatus)(criteria)
        End Function
    
        Public Shared Sub DeleteOrderStatus(ByVal orderId As System.Int32, ByVal lineNum As System.Int32)
            DataPortal.Delete(Of OrderStatus)(New OrderStatusCriteria(orderId, lineNum))
        End Sub

        Friend Shared Function GetOrderStatus(ByVal reader As SafeDataReader) As OrderStatus
            Return DataPortal.FetchChild(Of OrderStatus)(reader)
        End Function

#End If
#End Region

#Region "Asynchronous Factory Methods"

        Public Shared Sub NewOrderStatusAsync(ByVal handler As EventHandler(Of DataPortalResult(Of OrderStatus)))
            Dim dp As New DataPortal(Of OrderStatus)()
            AddHandler dp.CreateCompleted, handler
            dp.BeginCreate()
        End Sub
    
        Public Shared Sub GetByOrderIdLineNumAsync(ByVal orderId As System.Int32, ByVal lineNum As System.Int32, ByVal handler As EventHandler(Of DataPortalResult(Of OrderStatus)))
            Dim dp As New DataPortal(Of OrderStatus)()
            AddHandler dp.FetchCompleted, handler
        
            Dim criteria As New OrderStatusCriteria()
            criteria.OrderId = orderId
            criteria.LineNum = lineNum
    
            dp.BeginFetch(criteria)
        End Sub
    
        Public Shared Sub GetByOrderIdAsync(ByVal orderId As System.Int32, ByVal handler As EventHandler(Of DataPortalResult(Of OrderStatus)))
            Dim dp As New DataPortal(Of OrderStatus)()
            AddHandler dp.FetchCompleted, handler
        
            Dim criteria As New OrderStatusCriteria()
            criteria.OrderId = orderId
    
            dp.BeginFetch(criteria)
        End Sub
    
        Public Shared Sub DeleteOrderStatusDeleteOrderStatusAsync(ByVal orderId As System.Int32, ByVal lineNum As System.Int32, ByVal handler As EventHandler(Of DataPortalResult(Of OrderStatus)))
            Dim dp As New DataPortal(Of OrderStatus)()
            AddHandler dp.DeleteCompleted, handler
            dp.BeginDelete(New OrderStatusCriteria (orderId, lineNum))
        End Sub
    

#End Region

#Region "DataPortal partial methods"
    
#If Not SILVERLIGHT Then
        ''' <summary>
        ''' CodeSmith generated stub method that is called when creating the <see cref="OrderStatus"/> object. 
        ''' </summary>
        ''' <param name="cancel">Value returned from the method indicating whether the object creation should proceed.</param>
        Partial Private Sub OnCreating(ByRef cancel As Boolean)
        End Sub

        ''' <summary>
        ''' CodeSmith generated stub method that is called after the <see cref="OrderStatus"/> object has been created. 
        ''' </summary>
        Partial Private Sub OnCreated()
        End Sub

        ''' <summary>
        ''' CodeSmith generated stub method that is called when fetching the <see cref="OrderStatus"/> object. 
        ''' </summary>
        ''' <param name="criteria"><see cref="OrderStatusCriteria"/> object containing the criteria of the object to fetch.</param>
        ''' <param name="cancel">Value returned from the method indicating whether the object fetching should proceed.</param>
        Partial Private Sub OnFetching(ByVal criteria As OrderStatusCriteria, ByRef cancel As Boolean)
        End Sub

        ''' <summary>
        ''' CodeSmith generated stub method that is called after the <see cref="OrderStatus"/> object has been fetched. 
        ''' </summary>    
        Partial Private Sub OnFetched()
        End Sub

        ''' <summary>
        ''' CodeSmith generated stub method that is called when mapping the <see cref="OrderStatus"/> object. 
        ''' </summary>
        ''' <param name="cancel">Value returned from the method indicating whether the object mapping should proceed.</param>
        Partial Private Sub OnMapping(ByRef cancel As Boolean)
        End Sub
 
        ''' <summary>
        ''' CodeSmith generated stub method that is called when mapping the <see cref="OrderStatus"/> object. 
        ''' </summary>
        ''' <param name="reader"></param>
        ''' <param name="cancel">Value returned from the method indicating whether the object mapping should proceed.</param>
        Partial Private Sub OnMapping(ByVal reader As SafeDataReader, ByRef cancel As Boolean)
        End Sub
        ''' <summary>
        ''' CodeSmith generated stub method that is called after the <see cref="OrderStatus"/> object has been mapped. 
        ''' </summary>
        Partial Private Sub OnMapped()
        End Sub
        ''' <summary>
        ''' CodeSmith generated stub method that is called when inserting the <see cref="OrderStatus"/> object. 
        ''' </summary>
        ''' <param name="cancel">Value returned from the method indicating whether the object insertion should proceed.</param>
        Partial Private Sub OnInserting(ByRef cancel As Boolean)
        End Sub
        ''' <summary>
        ''' CodeSmith generated stub method that is called after the <see cref="OrderStatus"/> object has been inserted. 
        ''' </summary>
        Partial Private Sub OnInserted()
        End Sub
        ''' <summary>
        ''' CodeSmith generated stub method that is called when updating the <see cref="OrderStatus"/> object. 
        ''' </summary>
        ''' <param name="cancel">Value returned from the method indicating whether the object creation should proceed.</param>
        Partial Private Sub OnUpdating(ByRef cancel As Boolean)
        End Sub
        ''' <summary>
        ''' CodeSmith generated stub method that is called after the <see cref="OrderStatus"/> object has been updated. 
        ''' </summary>
        Partial Private Sub OnUpdated()
        End Sub
        ''' <summary>
        ''' CodeSmith generated stub method that is called when self deleting the <see cref="OrderStatus"/> object. 
        ''' </summary>
        ''' <param name="cancel">Value returned from the method indicating whether the object self deletion should proceed.</param>
        Partial Private Sub OnSelfDeleting(ByRef cancel As Boolean)
        End Sub
        ''' <summary>
        ''' CodeSmith generated stub method that is called after the <see cref="OrderStatus"/> object has been deleted. 
        ''' </summary>
        Partial Private Sub OnSelfDeleted()
        End Sub
        ''' <summary>
        ''' CodeSmith generated stub method that is called when deleting the <see cref="OrderStatus"/> object. 
        ''' </summary>
        ''' <param name="criteria"><see cref="OrderStatusCriteria"/> object containing the criteria of the object to delete.</param>
        ''' <param name="cancel">Value returned from the method indicating whether the object deletion should proceed.</param>
        Partial Private Sub OnDeleting(ByVal criteria As OrderStatusCriteria, ByRef cancel As Boolean)
        End Sub
        ''' <summary>
        ''' CodeSmith generated stub method that is called after the <see cref="OrderStatus"/> object with the specified criteria has been deleted. 
        ''' </summary>
        Partial Private Sub OnDeleted()
        End Sub
#End If
        Private Partial Sub OnChildLoading(ByVal childProperty As Global.Csla.Core.IPropertyInfo, ByRef cancel As Boolean)
        End Sub
    
#End Region
#Region "Exists Command"
#If Not SILVERLIGHT Then

        ''' <summary>
        ''' Determines if a record exists in the [dbo].[OrderStatus] table in the database for the specified criteria. 
        ''' </summary>
        ''' <param name="criteria">The criteria parameter is an <see cref="OrderStatus"/> object.</param>
        ''' <returns>A boolean value of true is returned if a record is found.</returns>
        Public Shared Function Exists(ByVal criteria As OrderStatusCriteria) As Boolean
            Return PetShop.Business.ExistsCommand.Execute(criteria)
        End Function

#End If

        ''' <summary>
        ''' Determines if a record exists in the [dbo].[OrderStatus] table in the database for the specified criteria. 
        ''' </summary>
        Public Shared Sub ExistsAsync(ByVal criteria As OrderStatusCriteria, ByVal handler As EventHandler(Of DataPortalResult(Of ExistsCommand)))
            PetShop.Business.ExistsCommand.ExecuteAsync(criteria, handler)
        End Sub

#End Region
    End Class
End Namespace
