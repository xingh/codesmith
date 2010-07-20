'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated by a CodeSmith Template.
'
'     DO Not MODIfY contents of this file. Changes to this
'     file will be lost if the code is regenerated.
' </autogenerated>
'------------------------------------------------------------------------------

Imports System
Imports System.ComponentModel
Imports System.Data.Linq
Imports System.Data.Linq.Mapping
Imports System.Diagnostics
Imports System.Runtime.Serialization
Imports System.ComponentModel.DataAnnotations
Imports System.Data.Services.Common

Namespace Petshop.Data
    ''' <summary>
    ''' The class representing the dbo.LineItem table.
    ''' </summary>
    <Table(Name:="dbo.LineItem")> _
    <DataContract(IsReference:=True)> _
    <ScaffoldTable(True)> _
    <MetadataType(GetType(LineItem.Metadata))> _
	<DataServiceKey("OrderId", "LineNum")> _
    public Partial Class LineItem
        Inherits LinqEntityBase
        
        #Region "Default Constructor"
        ''' <summary>
        ''' Initializes a new instance of the <see cref="LineItem"/> class.
        ''' </summary>
        <DebuggerNonUserCodeAttribute()> _
        public  Sub New()
              OnCreated()
            Initialize()
        End Sub
        
        Private Sub Initialize()
            _orders = Nothing
        End Sub
        #End Region

        #Region "Column Mapped Properties"
        
        Private _orderId As Integer

        ''' <summary>
        ''' Gets or sets the OrderId column value.
        ''' </summary>
        <Column(Name:="OrderId", Storage:="_orderId", DbType:="int NOT NULL", IsPrimaryKey:=true, CanBeNull:=false)> _
        <DataMember(Order:=1)> _
        public Property OrderId As Integer
            Get 
                return _orderId 
            End Get
            Set
                If  Not _orderId.Equals(value) Then
                    If (_orders.HasLoadedOrAssignedValue) Then
                        Throw New System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException()
                    End If
                    OnOrderIdChanging(value)
                    OnPropertyChanging("OrderId")
                    _orderId = value
                    OnPropertyChanged("OrderId")
                    OnOrderIdChanged()
                End If
            End Set
        End Property
        
        Private _lineNum As Integer

        ''' <summary>
        ''' Gets or sets the LineNum column value.
        ''' </summary>
        <Column(Name:="LineNum", Storage:="_lineNum", DbType:="int NOT NULL", IsPrimaryKey:=true, CanBeNull:=false)> _
        <DataMember(Order:=2)> _
        public Property LineNum As Integer
            Get 
                return _lineNum 
            End Get
            Set
                If  Not _lineNum.Equals(value) Then
                    OnLineNumChanging(value)
                    OnPropertyChanging("LineNum")
                    _lineNum = value
                    OnPropertyChanged("LineNum")
                    OnLineNumChanged()
                End If
            End Set
        End Property
        
        Private _itemId As String

        ''' <summary>
        ''' Gets or sets the ItemId column value.
        ''' </summary>
        <Column(Name:="ItemId", Storage:="_itemId", DbType:="varchar(10) NOT NULL", CanBeNull:=false)> _
        <DataMember(Order:=3)> _
        public Property ItemId As String
            Get 
                return _itemId 
            End Get
            Set
                If String.IsNullOrEmpty(_itemId) OrElse  Not _itemId.Equals(value) Then
                    OnItemIdChanging(value)
                    OnPropertyChanging("ItemId")
                    _itemId = value
                    OnPropertyChanged("ItemId")
                    OnItemIdChanged()
                End If
            End Set
        End Property
        
        Private _quantity As Integer

        ''' <summary>
        ''' Gets or sets the Quantity column value.
        ''' </summary>
        <Column(Name:="Quantity", Storage:="_quantity", DbType:="int NOT NULL", CanBeNull:=false)> _
        <DataMember(Order:=4)> _
        public Property Quantity As Integer
            Get 
                return _quantity 
            End Get
            Set
                If  Not _quantity.Equals(value) Then
                    OnQuantityChanging(value)
                    OnPropertyChanging("Quantity")
                    _quantity = value
                    OnPropertyChanged("Quantity")
                    OnQuantityChanged()
                End If
            End Set
        End Property
        
        Private _unitPrice As Decimal

        ''' <summary>
        ''' Gets or sets the UnitPrice column value.
        ''' </summary>
        <Column(Name:="UnitPrice", Storage:="_unitPrice", DbType:="decimal(10,2) NOT NULL", CanBeNull:=false)> _
        <DataMember(Order:=5)> _
        public Property UnitPrice As Decimal
            Get 
                return _unitPrice 
            End Get
            Set
                If  Not _unitPrice.Equals(value) Then
                    OnUnitPriceChanging(value)
                    OnPropertyChanging("UnitPrice")
                    _unitPrice = value
                    OnPropertyChanged("UnitPrice")
                    OnUnitPriceChanged()
                End If
            End Set
        End Property
        #End Region
        
        #Region "Association Mapped Properties"
        
        Private  _orders As EntityRef(Of Orders)

        ''' <summary>
        ''' Gets or sets the Orders association.
        ''' </summary>
        <Association(Name:="Orders_LineItem", Storage:="_orders", ThisKey:="OrderId", OtherKey:="OrderId", IsUnique:=true, IsForeignKey:=true, DeleteOnNull:=true)> _
        <DataMember(Order:=6, EmitDefaultValue:=False)> _
        public Property Orders As Orders
            Get
                Return _orders.Entity 
            End Get
            Set
                Dim previousValue As Orders = _orders.Entity
                If Not previousValue Is value Or _orders.HasLoadedOrAssignedValue = False Then
                    OnPropertyChanging("Orders")
                    If previousValue IsNot Nothing Then
                        _orders.Entity = Nothing
                        previousValue.LineItemList.Remove(Me)
                    End If
                    _orders.Entity = value
                    If value IsNot Nothing Then
                        value.LineItemList.Add(Me)
                        _orderId = value.OrderId
                    Else
                        _orderId = Nothing
                    End If
                    OnPropertyChanged("Orders")
                End If
            End Set
        End Property
           #End Region
        
        #Region "Extensibility Method Definitions"
        ''' <summary>Called when this instance is loaded.</summary>
        Private Partial Sub OnLoaded()
        End Sub
        ''' <summary>Called when this instance is being saved.</summary>
        Private Partial Sub OnValidate(ByVal action As ChangeAction)
        End Sub
        ''' <summary>Called when this instance is created.</summary>
        Private Partial Sub OnCreated()
        End Sub
        ''' <summary>Called when OrderId is changing.</summary>
        ''' <param name="value">The new value.</param>
        Private Partial Sub OnOrderIdChanging(ByVal value As Integer)
        End Sub
        ''' <summary>Called after OrderId has Changed.</summary>
        Private Partial Sub OnOrderIdChanged()
        End Sub
        ''' <summary>Called when LineNum is changing.</summary>
        ''' <param name="value">The new value.</param>
        Private Partial Sub OnLineNumChanging(ByVal value As Integer)
        End Sub
        ''' <summary>Called after LineNum has Changed.</summary>
        Private Partial Sub OnLineNumChanged()
        End Sub
        ''' <summary>Called when ItemId is changing.</summary>
        ''' <param name="value">The new value.</param>
        Private Partial Sub OnItemIdChanging(ByVal value As String)
        End Sub
        ''' <summary>Called after ItemId has Changed.</summary>
        Private Partial Sub OnItemIdChanged()
        End Sub
        ''' <summary>Called when Quantity is changing.</summary>
        ''' <param name="value">The new value.</param>
        Private Partial Sub OnQuantityChanging(ByVal value As Integer)
        End Sub
        ''' <summary>Called after Quantity has Changed.</summary>
        Private Partial Sub OnQuantityChanged()
        End Sub
        ''' <summary>Called when UnitPrice is changing.</summary>
        ''' <param name="value">The new value.</param>
        Private Partial Sub OnUnitPriceChanging(ByVal value As Decimal)
        End Sub
        ''' <summary>Called after UnitPrice has Changed.</summary>
        Private Partial Sub OnUnitPriceChanged()
        End Sub
        #End Region
        
        
        #Region "Serialization"
        
        
        <OnDeserializing(), _
         EditorBrowsableAttribute(EditorBrowsableState.Never)> _
        Public Sub OnDeserializing(ByVal context As StreamingContext)
            Initialize
        End Sub
        
        #End Region
    
    End Class
End Namespace
