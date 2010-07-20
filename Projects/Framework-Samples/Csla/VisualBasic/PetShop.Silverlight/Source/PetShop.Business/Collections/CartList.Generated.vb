﻿'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated using CodeSmith: v5.2.2, CSLA Templates: v3.0.0.1845, CSLA Framework: v4.0.0.
'     Changes to this file will be lost after each regeneration.
'     To extend the functionality of this class, please modify the partial class 'CartList.vb.
'
'     Template: EditableChildList.Generated.cst
'     Template website: http://code.google.com/p/codesmith/
' </autogenerated>
'------------------------------------------------------------------------------
Option Explicit On
Option Strict On

Imports System
Imports System.Collections.Generic

Imports Csla
#If SILVERLIGHT Then
Imports Csla.Serialization
#Else
Imports Csla.Data
#End If

Namespace PetShop.Business
    <Serializable()> _
    Public Partial Class CartList 
        Inherits BusinessListBase(Of CartList, Cart)
    
#Region "Contructor(s)"
    #If Not SILVERLIGHT Then
        Private Sub New()
            AllowNew = true
            MarkAsChild()
        End Sub
    #Else
        public Sub New()
            AllowNew = true
            MarkAsChild()
        End Sub
    #End If
    
#End Region
    
    #If Not SILVERLIGHT Then
#Region "Synchronous Factory Methods" 
    
        Friend Shared Function NewList() As CartList
            Return DataPortal.CreateChild(Of CartList)()
        End Function
    
        Friend Shared Function GetByCartId(ByVal cartId As System.Int32) As CartList 
            Dim criteria As New CartCriteria()
            criteria.CartId = cartId
    
            Return DataPortal.FetchChild(Of CartList)(criteria)
        End Function
    
        Friend Shared Function GetByUniqueID(ByVal uniqueID As System.Int32) As CartList 
            Dim criteria As New CartCriteria()
            criteria.UniqueID = uniqueID
    
            Return DataPortal.FetchChild(Of CartList)(criteria)
        End Function
    
        Friend Shared Function GetByIsShoppingCart(ByVal isShoppingCart As System.Boolean) As CartList 
            Dim criteria As New CartCriteria()
            criteria.IsShoppingCart = isShoppingCart
    
            Return DataPortal.FetchChild(Of CartList)(criteria)
        End Function
    
        Friend Shared Function GetAll() As CartList
            Return DataPortal.FetchChild(Of CartList)(New CartCriteria())
        End Function
    
#End Region
    
    #End If        
    
#Region "Asynchronous Factory Methods"
    
        Friend Shared Sub NewCartListAsync(ByVal handler As EventHandler(Of DataPortalResult(Of Cart)))
            Dim dp As New DataPortal(Of Cart)()
            AddHandler dp.CreateCompleted, handler
            dp.BeginCreate()
        End Sub
    
    ' Child objects do not expose asynchronous factory get methods.
    
    #End Region
    
#Region "Method Overrides"
    
    #If Not SILVERLIGHT Then
        Protected Overrides Function AddNewCore() As Cart
            Dim item As Cart = PetShop.Business.Cart.NewCart()
    
            Dim cancel As Boolean = False
            OnAddNewCore(item, cancel)
            If Not (cancel) Then
                ' Check to see if someone set the item to null in the OnAddNewCore.
                If(item Is Nothing) Then
                    item = PetShop.Business.Cart.NewCart()
                End If
            ' Pass the parent value down to the child.
                Dim profile As Profile = CType(Me.Parent, Profile)
                If Not(profile Is Nothing)
                    item.UniqueID = profile.UniqueID
                End If
                Add(item)
            End If
    
            Return item
        End Function
    #Else
    
        Protected Overrides Sub AddNewCore() 
            Dim item As Cart = PetShop.Business.Cart.NewCart()
    
            Dim cancel As Boolean = False
            OnAddNewCore(item, cancel)
            If Not (cancel) Then
                ' Check to see if someone set the item to null in the OnAddNewCore.
                If(item Is Nothing) Then
                    item = PetShop.Business.Cart.NewCart()
                End If
            ' Pass the parent value down to the child.
                Dim profile As Profile = CType(Me.Parent, Profile)
                If Not(profile Is Nothing)
                    item.UniqueID = profile.UniqueID
                End If
                Add(item)
            End If
        End Sub
    
    #End If
    
        Protected Sub AddNewCoreAsync(ByVal handler As EventHandler(Of DataPortalResult(Of Cart)))
            CartList.NewCartListAsync(Sub(o, e)
                    If e.Error Is Nothing Then
                        Add(e.Object)
                        handler.Invoke(Me, New DataPortalResult(Of Cart)(e.Object, Nothing, Nothing))
                    End If
                End Sub)
        End Sub
    
    
#End Region
    
    
#Region "DataPortal partial methods"
    
    #If Not SILVERLIGHT Then
        Partial Private Sub OnCreating(ByRef cancel As Boolean)
        End Sub
        Partial Private Sub OnCreated()
        End Sub
        Partial Private Sub OnFetching(ByVal criteria As CartCriteria, ByRef cancel As Boolean)
        End Sub
        Partial Private Sub OnFetched()
        End Sub
        Partial Private Sub OnMapping(ByVal reader As SafeDataReader, ByRef cancel As Boolean)
        End Sub
        Partial Private Sub OnMapped()
        End Sub
        Partial Private Sub OnUpdating(ByRef cancel As Boolean)
        End Sub
        Partial Private Sub OnUpdated()
        End Sub
    #End If
        Partial Private Sub OnAddNewCore(ByVal item As Cart, ByRef cancel As Boolean)
        End Sub
    
#End Region

#Region "Exists Command"
    
    #If Not SILVERLIGHT Then
        Public Shared Function Exists(ByVal criteria As CartCriteria) As Boolean
            Return PetShop.Business.Cart.Exists(criteria)
        End Function
    #End If
    
#End Region

    End Class
End Namespace