﻿'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated using CodeSmith: v6.5.0, CSLA Templates: v4.0.0.0, CSLA Framework: v4.3.10.
'     Changes to this file will be lost after each regeneration.
'     To extend the functionality of this class, please modify the partial class 'Cart.vb.
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
Imports System.Data.SqlClient

Imports Csla.Rules

Namespace PetShop.Tests.OF.StoredProcedures
    <Serializable()> _
    <Csla.Server.ObjectFactory(FactoryNames.CartFactoryName)> _
    Public Partial Class Cart
        Inherits BusinessBase(Of Cart)
    
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
    
            BusinessRules.AddRule(New Global.Csla.Rules.CommonRules.Required(_itemIdProperty))
            BusinessRules.AddRule(New Global.Csla.Rules.CommonRules.MaxLength(_itemIdProperty, 10))
            BusinessRules.AddRule(New Global.Csla.Rules.CommonRules.Required(_nameProperty))
            BusinessRules.AddRule(New Global.Csla.Rules.CommonRules.MaxLength(_nameProperty, 80))
            BusinessRules.AddRule(New Global.Csla.Rules.CommonRules.Required(_typeProperty))
            BusinessRules.AddRule(New Global.Csla.Rules.CommonRules.MaxLength(_typeProperty, 80))
            BusinessRules.AddRule(New Global.Csla.Rules.CommonRules.Required(_categoryIdProperty))
            BusinessRules.AddRule(New Global.Csla.Rules.CommonRules.MaxLength(_categoryIdProperty, 10))
            BusinessRules.AddRule(New Global.Csla.Rules.CommonRules.Required(_productIdProperty))
            BusinessRules.AddRule(New Global.Csla.Rules.CommonRules.MaxLength(_productIdProperty, 10))
        End Sub
    
#End Region

#Region "Properties"
    
        Private Shared ReadOnly _cartIdProperty As PropertyInfo(Of System.Int32) = RegisterProperty(Of System.Int32)(Function(p As Cart) p.CartId, "Cart Id")
        
        <System.ComponentModel.DataObjectField(true, true)> _
        Public Property CartId() As System.Int32
            Get 
                Return GetProperty(_cartIdProperty)
            End Get
            Friend Set (ByVal value As System.Int32)
                SetProperty(_cartIdProperty, value)
            End Set
        End Property

        Private Shared ReadOnly _uniqueIDProperty As PropertyInfo(Of System.Int32) = RegisterProperty(Of System.Int32)(Function(p As Cart) p.UniqueID, "Unique I D")
        
        Public Property UniqueID() As System.Int32
            Get 
                Return GetProperty(_uniqueIDProperty)
            End Get
            Set (ByVal value As System.Int32)
                SetProperty(_uniqueIDProperty, value)
            End Set
        End Property

        Private Shared ReadOnly _itemIdProperty As PropertyInfo(Of System.String) = RegisterProperty(Of System.String)(Function(p As Cart) p.ItemId, "Item Id")
        
        Public Property ItemId() As System.String
            Get 
                Return GetProperty(_itemIdProperty)
            End Get
            Set (ByVal value As System.String)
                SetProperty(_itemIdProperty, value)
            End Set
        End Property

        Private Shared ReadOnly _nameProperty As PropertyInfo(Of System.String) = RegisterProperty(Of System.String)(Function(p As Cart) p.Name, "Name")
        
        Public Property Name() As System.String
            Get 
                Return GetProperty(_nameProperty)
            End Get
            Set (ByVal value As System.String)
                SetProperty(_nameProperty, value)
            End Set
        End Property

        Private Shared ReadOnly _typeProperty As PropertyInfo(Of System.String) = RegisterProperty(Of System.String)(Function(p As Cart) p.Type, "Type")
        
        Public Property Type() As System.String
            Get 
                Return GetProperty(_typeProperty)
            End Get
            Set (ByVal value As System.String)
                SetProperty(_typeProperty, value)
            End Set
        End Property

        Private Shared ReadOnly _priceProperty As PropertyInfo(Of System.Decimal) = RegisterProperty(Of System.Decimal)(Function(p As Cart) p.Price, "Price")
        
        Public Property Price() As System.Decimal
            Get 
                Return GetProperty(_priceProperty)
            End Get
            Set (ByVal value As System.Decimal)
                SetProperty(_priceProperty, value)
            End Set
        End Property

        Private Shared ReadOnly _categoryIdProperty As PropertyInfo(Of System.String) = RegisterProperty(Of System.String)(Function(p As Cart) p.CategoryId, "Category Id")
        
        Public Property CategoryId() As System.String
            Get 
                Return GetProperty(_categoryIdProperty)
            End Get
            Set (ByVal value As System.String)
                SetProperty(_categoryIdProperty, value)
            End Set
        End Property

        Private Shared ReadOnly _productIdProperty As PropertyInfo(Of System.String) = RegisterProperty(Of System.String)(Function(p As Cart) p.ProductId, "Product Id")
        
        Public Property ProductId() As System.String
            Get 
                Return GetProperty(_productIdProperty)
            End Get
            Set (ByVal value As System.String)
                SetProperty(_productIdProperty, value)
            End Set
        End Property

        Private Shared ReadOnly _isShoppingCartProperty As PropertyInfo(Of System.Boolean) = RegisterProperty(Of System.Boolean)(Function(p As Cart) p.IsShoppingCart, "Is Shopping Cart")
        
        Public Property IsShoppingCart() As System.Boolean
            Get 
                Return GetProperty(_isShoppingCartProperty)
            End Get
            Set (ByVal value As System.Boolean)
                SetProperty(_isShoppingCartProperty, value)
            End Set
        End Property

        Private Shared ReadOnly _quantityProperty As PropertyInfo(Of System.Int32) = RegisterProperty(Of System.Int32)(Function(p As Cart) p.Quantity, "Quantity")
        
        Public Property Quantity() As System.Int32
            Get 
                Return GetProperty(_quantityProperty)
            End Get
            Set (ByVal value As System.Int32)
                SetProperty(_quantityProperty, value)
            End Set
        End Property

        'Associations.Where(Function(a) a.AssociationType = AssociationType.ManyToOne OrElse a.AssociationType = AssociationType.ManyToZeroOrOne)
        Private Shared ReadOnly _profileProperty As PropertyInfo(Of Profile) = RegisterProperty(Of Profile)(Function(p As Cart) p.Profile, Csla.RelationshipTypes.Child)
        Public ReadOnly Property Profile() As Profile
            Get
                Dim cancel As Boolean = False
                OnChildLoading(_profileProperty, cancel)
                
                If Not cancel Then
                    If(False) Then
                        Return Nothing
                    End If
    
                    If Not(FieldManager.FieldExists(_profileProperty))
                        Dim criteria As New PetShop.Tests.OF.StoredProcedures.ProfileCriteria()
                        criteria.UniqueID = UniqueID

                        If (PetShop.Tests.OF.StoredProcedures.Profile.Exists(criteria)) Then
                            LoadProperty(_profileProperty, PetShop.Tests.OF.StoredProcedures.Profile.GetByUniqueID(UniqueID))
                        End If
                    End If
                End If

                Return GetProperty(_profileProperty) 
            End Get
        End Property

#End Region
    
#Region "Synchronous Factory Methods"

        ''' <summary>
        ''' Creates a new object of type <see cref="Cart"/>. 
        ''' </summary>
        ''' <returns>Returns a newly instantiated collection of type <see cref="Cart"/>.</returns>
        Friend Shared Function NewCart() As Cart 
            Return DataPortal.CreateChild(Of Cart)()
        End Function

        ''' <summary>
        ''' Returns a <see cref="Cart"/> object of the specified criteria. 
        ''' </summary>
        ''' <param name="cartId">No additional detail available.</param>
        ''' <returns>A <see cref="Cart"/> object of the specified criteria.</returns>
        Friend Shared Function GetByCartId(ByVal cartId As System.Int32) As Cart
            Dim criteria As New CartCriteria()
                        criteria.CartId = cartId
    
            Return DataPortal.Fetch(Of Cart)(criteria)
        End Function

        ''' <summary>
        ''' Returns a <see cref="Cart"/> object of the specified criteria. 
        ''' </summary>
        ''' <param name="uniqueID">No additional detail available.</param>
        ''' <returns>A <see cref="Cart"/> object of the specified criteria.</returns>
        Friend Shared Function GetByUniqueID(ByVal uniqueID As System.Int32) As Cart
            Dim criteria As New CartCriteria()
                        criteria.UniqueID = uniqueID
    
            Return DataPortal.Fetch(Of Cart)(criteria)
        End Function

        ''' <summary>
        ''' Returns a <see cref="Cart"/> object of the specified criteria. 
        ''' </summary>
        ''' <param name="isShoppingCart">No additional detail available.</param>
        ''' <returns>A <see cref="Cart"/> object of the specified criteria.</returns>
        Friend Shared Function GetByIsShoppingCart(ByVal isShoppingCart As System.Boolean) As Cart
            Dim criteria As New CartCriteria()
                        criteria.IsShoppingCart = isShoppingCart
    
            Return DataPortal.Fetch(Of Cart)(criteria)
        End Function

#End Region

#Region "Asynchronous Factory Methods"

        Friend Shared Sub NewCartAsync(ByVal handler As EventHandler(Of DataPortalResult(Of Cart)))
            Dim dp As New DataPortal(Of Cart)()
            AddHandler dp.CreateCompleted, handler
            dp.BeginCreate()
        End Sub
    
        Friend Shared Sub GetByCartIdAsync(ByVal cartId As System.Int32, ByVal handler As EventHandler(Of DataPortalResult(Of AsyncChildLoader(Of Cart))))
            Dim criteria As New CartCriteria()
            criteria.CartId = cartId

            DataPortal.BeginFetch(Of AsyncChildLoader(Of Cart))(criteria, handler)
        End Sub
    
        Friend Shared Sub GetByUniqueIDAsync(ByVal uniqueID As System.Int32, ByVal handler As EventHandler(Of DataPortalResult(Of AsyncChildLoader(Of Cart))))
            Dim criteria As New CartCriteria()
            criteria.UniqueID = uniqueID

            DataPortal.BeginFetch(Of AsyncChildLoader(Of Cart))(criteria, handler)
        End Sub
    
        Friend Shared Sub GetByIsShoppingCartAsync(ByVal isShoppingCart As System.Boolean, ByVal handler As EventHandler(Of DataPortalResult(Of AsyncChildLoader(Of Cart))))
            Dim criteria As New CartCriteria()
            criteria.IsShoppingCart = isShoppingCart

            DataPortal.BeginFetch(Of AsyncChildLoader(Of Cart))(criteria, handler)
        End Sub

#End Region
    
#Region "Overridden properties"
    
            ''' <summary>
            ''' Returns true if the business object or any of its children properties are dirty.
            ''' </summary>
            Public Overloads Overrides ReadOnly Property IsDirty() As Boolean
                Get
                    If MyBase.IsDirty Then
                        Return True
                    End If
    
                    If (FieldManager.FieldExists(_profileProperty) AndAlso Profile.IsDirty) Then
                        Return True
                    End If
                    Return False
                End Get
            End Property
    
#End Region
    
#Region "ChildPortal partial methods"
    
        ''' <summary>
        ''' CodeSmith generated stub method that is called when creating the child <see cref="Cart"/> object. 
        ''' </summary>
        ''' <param name="cancel">Value returned from the method indicating whether the object creation should proceed.</param>
        Partial Private Sub OnChildCreating(ByRef cancel As Boolean)
        End Sub

        ''' <summary>
        ''' CodeSmith generated stub method that is called after the child <see cref="Cart"/> object has been created. 
        ''' </summary>
        Partial Private Sub OnChildCreated()
        End Sub

        ''' <summary>
        ''' CodeSmith generated stub method that is called when fetching the child <see cref="Cart"/> object. 
        ''' </summary>
        ''' <param name="criteria"><see cref="CartCriteria"/> object containing the criteria of the object to fetch.</param>
        ''' <param name="cancel">Value returned from the method indicating whether the object fetching should proceed.</param>
        Partial Private Sub OnChildFetching(ByVal criteria As CartCriteria, ByRef cancel As Boolean)
        End Sub

        ''' <summary>
        ''' CodeSmith generated stub method that is called after the child <see cref="Cart"/> object has been fetched. 
        ''' </summary>
        Partial Private Sub OnChildFetched()
        End Sub

        ''' <summary>
        ''' CodeSmith generated stub method that is called when mapping the child <see cref="Cart"/> object. 
        ''' </summary>
        ''' <param name="cancel">Value returned from the method indicating whether the object mapping should proceed.</param>
        Partial Private Sub OnMapping(ByRef cancel As Boolean)
        End Sub

        ''' <summary>
        ''' CodeSmith generated stub method that is called when mapping the child <see cref="Cart"/> object. 
        ''' </summary>
        ''' <param name="reader"></param>
        ''' <param name="cancel">Value returned from the method indicating whether the object mapping should proceed.</param>
        Partial Private Sub OnMapping(ByVal reader As SafeDataReader, ByRef cancel As Boolean)
        End Sub

        ''' <summary>
        ''' CodeSmith generated stub method that is called after the child <see cref="Cart"/> object has been mapped. 
        ''' </summary>
        Partial Private Sub OnMapped()
        End Sub

        ''' <summary>
        ''' CodeSmith generated stub method that is called when inserting the child <see cref="Cart"/> object. 
        ''' </summary>
        ''' <param name="cancel">Value returned from the method indicating whether the object insertion should proceed.</param>
        Partial Private Sub OnChildInserting(ByRef cancel As Boolean)
        End Sub

        ''' <summary>
        ''' CodeSmith generated stub method that is called when inserting the child <see cref="Cart"/> object. 
        ''' </summary>
        ''' <param name="connection"></param>
        ''' <param name="cancel">Value returned from the method indicating whether the object insertion should proceed.</param>
        Partial Private Sub OnChildInserting(ByVal connection As SqlConnection, ByRef cancel As Boolean)
        End Sub

        ''' <summary>
        ''' CodeSmith generated stub method that is called when inserting the child <see cref="Cart"/> object. 
        ''' </summary>
        Partial Private Sub OnChildInserting(ByVal profile As Profile, ByVal connection As SqlConnection, ByRef cancel As Boolean)
        End Sub

        ''' <summary>
        ''' CodeSmith generated stub method that is called after the child <see cref="Cart"/> object has been inserted. 
        ''' </summary>
        Partial Private Sub OnChildInserted()
        End Sub

        ''' <summary>
        ''' CodeSmith generated stub method that is called when updating the child <see cref="Cart"/> object. 
        ''' </summary>
        ''' <param name="cancel">Value returned from the method indicating whether the object creation should proceed.</param>
        Partial Private Sub OnChildUpdating(ByRef cancel As Boolean)
        End Sub

        ''' <summary>
        ''' CodeSmith generated stub method that is called when updating the child <see cref="Cart"/> object. 
        ''' </summary>
        Partial Private Sub OnChildUpdating(ByVal connection As SqlConnection, ByRef cancel As Boolean)
        End Sub

        ''' <summary>
        ''' CodeSmith generated stub method that is called when updating the child <see cref="Cart"/> object. 
        ''' </summary>
        ''' <param name="connection"></param>
        ''' <param name="cancel">Value returned from the method indicating whether the object insertion should proceed.</param>
        Partial Private Sub OnChildUpdating(ByVal profile As Profile, ByVal connection As SqlConnection, ByRef cancel As Boolean)
        End Sub

        ''' <summary>
        ''' CodeSmith generated stub method that is called after the child <see cref="Cart"/> object has been updated. 
        ''' </summary>
        Partial Private Sub OnChildUpdated()
        End Sub

        ''' <summary>
        ''' CodeSmith generated stub method that is called when self deleting the child <see cref="Cart"/> object. 
        ''' </summary>
        ''' <param name="cancel">Value returned from the method indicating whether the object self deletion should proceed.</param>
        Partial Private Sub OnChildSelfDeleting(ByRef cancel As Boolean)
        End Sub

        ''' <summary>
        ''' CodeSmith generated stub method that is called when self deleting the child <see cref="Cart"/> object. 
        ''' </summary>
        ''' <param name="connection"></param>
        ''' <param name="cancel">Value returned from the method indicating whether the object self deletion should proceed.</param>
        Partial Private Sub OnChildSelfDeleting(ByVal connection As SqlConnection, ByRef cancel As Boolean)
        End Sub

        ''' <summary>
        ''' CodeSmith generated stub method that is called after the child <see cref="Cart"/> object has been deleted. 
        ''' </summary>
        Partial Private Sub OnChildSelfDeleted()
        End Sub

        ''' <summary>
        ''' CodeSmith generated stub method that is called when deleting the child <see cref="Cart"/> object. 
        ''' </summary>
        ''' <param name="criteria"><see cref="CartCriteria"/> object containing the criteria of the object to delete.</param>
        ''' <param name="cancel">Value returned from the method indicating whether the object deletion should proceed.</param>
        Partial Private Sub OnDeleting(ByVal criteria As CartCriteria, ByRef cancel As Boolean)
        End Sub

        ''' <summary>
        ''' CodeSmith generated stub method that is called when deleting the child <see cref="Cart"/> object. 
        ''' </summary>
        ''' <param name="criteria"><see cref="CartCriteria"/> object containing the criteria of the object to delete.</param>
        ''' <param name="connection"></param>
        ''' <param name="cancel">Value returned from the method indicating whether the object deletion should proceed.</param>
        Partial Private Sub OnDeleting(ByVal criteria As CartCriteria, ByVal connection As SqlConnection, ByRef cancel As Boolean)
        End Sub

        ''' <summary>
        ''' CodeSmith generated stub method that is called after the child <see cref="Cart"/> object with the specified criteria has been deleted. 
        ''' </summary>
        Partial Private Sub OnDeleted()
        End Sub
        Private Partial Sub OnChildLoading(ByVal childProperty As Global.Csla.Core.IPropertyInfo, ByRef cancel As Boolean)
        End Sub
    
#End Region
#Region "Exists Command"

        ''' <summary>
        ''' Determines if a record exists in the [dbo].[Cart] table in the database for the specified criteria. 
        ''' </summary>
        ''' <param name="criteria">The criteria parameter is an <see cref="Cart"/> object.</param>
        ''' <returns>A boolean value of true is returned if a record is found.</returns>
        Public Shared Function Exists(ByVal criteria As CartCriteria) As Boolean
            Return PetShop.Tests.OF.StoredProcedures.ExistsCommand.Execute(criteria)
        End Function

        ''' <summary>
        ''' Determines if a record exists in the [dbo].[Cart] table in the database for the specified criteria. 
        ''' </summary>
        Public Shared Sub ExistsAsync(ByVal criteria As CartCriteria, ByVal handler As EventHandler(Of DataPortalResult(Of ExistsCommand)))
            PetShop.Tests.OF.StoredProcedures.ExistsCommand.ExecuteAsync(criteria, handler)
        End Sub

#End Region
    End Class
End Namespace
