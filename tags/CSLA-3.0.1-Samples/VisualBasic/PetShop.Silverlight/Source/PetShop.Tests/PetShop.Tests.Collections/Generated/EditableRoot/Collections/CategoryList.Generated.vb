﻿'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated using CodeSmith: v5.2.3, CSLA Templates: v3.0.1.1934, CSLA Framework: v4.0.0.
'     Changes to this file will be lost after each regeneration.
'     To extend the functionality of this class, please modify the partial class 'Category.vb.
'
'     Template: DynamicListBase.Generated.cst
'     Template website: http://code.google.com/p/codesmith/
' </autogenerated>
'------------------------------------------------------------------------------
Option Explicit On
Option Strict On

Imports System

Imports Csla
Imports Csla.Data

Namespace PetShop.Tests.Collections.EditableRoot
    <Serializable()> _
    Public Partial Class CategoryList
        Inherits DynamicListBase(Of Category)
    
#Region "Constructor(s)"
        
        Private Sub New()
            AllowNew = True
        End Sub
    
#End Region
    
#Region "Method Overrides"
        
        Protected Overrides Function AddNewCore() As Category
            Dim item As Category = PetShop.Tests.Collections.EditableRoot.Category.NewCategory()
    
            Dim cancel As Boolean = False
            OnAddNewCore(item, cancel)
            If Not (cancel) Then
                ' Check to see if someone set the item to null in the OnAddNewCore.
                If(item Is Nothing) Then
                    item = PetShop.Tests.Collections.EditableRoot.Category.NewCategory()
                End If
                
                Add(item)
            End If

            Return item
        End Function
        
#End Region
    
#Region "Synchronous Factory Methods"
        
        Public Shared Function NewList() As CategoryList
            Return DataPortal.Create(Of CategoryList)()
        End Function

        Public Shared Function GetAll() As CategoryList
            Return DataPortal.Fetch(Of CategoryList)(New CategoryCriteria())
        End Function

    
        Public Shared Function GetByCategoryId(ByVal categoryId As System.String) As CategoryList 
            Dim criteria As New CategoryCriteria()
            criteria.CategoryId = categoryId

            Return DataPortal.Fetch(Of CategoryList)(criteria)
        End Function
    
#End Region

#Region "DataPortal partial methods"
    
        Partial Private Sub OnCreating(ByRef cancel As Boolean)
        End Sub
        Partial Private Sub OnCreated()
        End Sub
        Partial Private Sub OnFetching(ByVal criteria As CategoryCriteria, ByRef cancel As Boolean)
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
        Partial Private Sub OnAddNewCore(ByVal item As Category, ByRef cancel As Boolean)
        End Sub
    
#End Region

#Region "Exists Command"

        Public Shared Function Exists(ByVal criteria As CategoryCriteria) As Boolean
            Return PetShop.Tests.Collections.EditableRoot.Category.Exists(criteria)
        End Function

#End Region
    End Class
End Namespace