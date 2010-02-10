'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated using CodeSmith: v5.2.1, CSLA Templates: v1.5.0.0, CSLA Framework: v3.8.0.
'     Changes to this file will be lost after each regeneration.
'     To extend the functionality of this class, please modify the partial class 'OrderStatus.vb.
'
'     Template: EditableChild.Generated.cst
'     Template website: http://code.google.com/p/codesmith/
' </autogenerated>
'------------------------------------------------------------------------------
Option Explicit On
Option Strict On

Imports System

Imports Csla
Imports Csla.Data
Imports Csla.Validation

<Serializable()> _
Public Partial Class OrderStatus 
    Inherits BusinessBase(Of OrderStatus)

    #Region "Contructor(s)"

    Private Sub New()
        ' require use of factory method
        MarkAsChild()
    End Sub

    Private Sub New(ByVal orderId As System.Int32, ByVal lineNum As System.Int32)
        Using(BypassPropertyChecks)
           LoadProperty(_orderIdProperty, orderId)
           LoadProperty(_lineNumProperty, lineNum)
        End Using

        MarkAsChild()
    End Sub

    Friend Sub New(Byval reader As SafeDataReader)
        Map(reader)

        MarkAsChild()
    End Sub

    #End Region
    #Region "Validation Rules"

    Protected Overrides Sub AddBusinessRules()

        If AddBusinessValidationRules() Then Exit Sub

        ValidationRules.AddRule(AddressOf CommonRules.StringRequired, _statusProperty)
        ValidationRules.AddRule(AddressOf CommonRules.StringMaxLength, New CommonRules.MaxLengthRuleArgs(_statusProperty, 2))
    End Sub

    #End Region

    #Region "Properties"

    
    Private Shared ReadOnly _orderIdProperty As PropertyInfo(Of System.Int32) = RegisterProperty(Of System.Int32)(Function(p As OrderStatus) p.OrderId)
		<System.ComponentModel.DataObjectField(true, false)> _
    Public Property OrderId() As System.Int32
        Get 
            Return GetProperty(_orderIdProperty)
        End Get
        Set (ByVal value As System.Int32)
            SetProperty(_orderIdProperty, value)
        End Set
    End Property
    
    
    Private Shared ReadOnly _lineNumProperty As PropertyInfo(Of System.Int32) = RegisterProperty(Of System.Int32)(Function(p As OrderStatus) p.LineNum)
		<System.ComponentModel.DataObjectField(true, false)> _
    Public Property LineNum() As System.Int32
        Get 
            Return GetProperty(_lineNumProperty)
        End Get
        Set (ByVal value As System.Int32)
            SetProperty(_lineNumProperty, value)
        End Set
    End Property
    
    
    Private Shared ReadOnly _timestampProperty As PropertyInfo(Of System.DateTime) = RegisterProperty(Of System.DateTime)(Function(p As OrderStatus) p.Timestamp)
    Public Property Timestamp() As System.DateTime
        Get 
            Return GetProperty(_timestampProperty)
        End Get
        Set (ByVal value As System.DateTime)
            SetProperty(_timestampProperty, value)
        End Set
    End Property
    
    
    Private Shared ReadOnly _statusProperty As PropertyInfo(Of System.String) = RegisterProperty(Of System.String)(Function(p As OrderStatus) p.Status)
    Public Property Status() As System.String
        Get 
            Return GetProperty(_statusProperty)
        End Get
        Set (ByVal value As System.String)
            SetProperty(_statusProperty, value)
        End Set
    End Property
    
    'ManyToOne
    Private Shared ReadOnly _orderMemberProperty As PropertyInfo(Of Order) = RegisterProperty(Of Order)(Function(p As OrderStatus) p.OrderMember, Csla.RelationshipTypes.Child)
    Public ReadOnly Property OrderMember() As Order
        Get
            If Not(FieldManager.FieldExists(_orderMemberProperty))
                Dim criteria As New PetShop.Tests.StoredProcedures.OrderCriteria()
                criteria.OrderId = OrderId
                
                If (Me.IsNew Or Not PetShop.Tests.StoredProcedures.Order.Exists(criteria)) Then
                    LoadProperty(_orderMemberProperty, PetShop.Tests.StoredProcedures.Order.NewOrder())
                Else
                    LoadProperty(_orderMemberProperty, PetShop.Tests.StoredProcedures.Order.GetByOrderId(OrderId))
                End If
            End If
            
            Return GetProperty(_orderMemberProperty) 
        End Get
    End Property
    
    #End Region

    #Region "Factory Methods"

    Friend Shared Function NewOrderStatus() As OrderStatus 
        Return DataPortal.Create(Of OrderStatus)()
    End Function

    Friend Shared Function GetByOrderIdLineNum(ByVal orderId As System.Int32, ByVal lineNum As System.Int32) As OrderStatus 
        Dim criteria As New OrderStatusCriteria()
		criteria.OrderId = orderId
		criteria.LineNum = lineNum

        Return DataPortal.FetchChild(Of OrderStatus)(criteria)
    End Function

    Friend Shared Function GetByOrderId(ByVal orderId As System.Int32) As OrderStatus 
        Dim criteria As New OrderStatusCriteria()
		criteria.OrderId = orderId

        Return DataPortal.FetchChild(Of OrderStatus)(criteria)
    End Function

    #End Region

    #Region "Exists Command"

    Public Shared Function Exists(ByVal criteria As OrderStatusCriteria) As Boolean
        Return ExistsCommand.Execute(criteria)
    End Function

    #End Region

    #Region "Protected Overriden Method(s)"
    
    ' NOTE: This is needed for Composite Keys. 
    Private ReadOnly _guidID As Guid = Guid.NewGuid()
    Protected Overrides Function GetIdValue() As Object
        Return _guidID
    End Function
    
    #End Region
End Class
