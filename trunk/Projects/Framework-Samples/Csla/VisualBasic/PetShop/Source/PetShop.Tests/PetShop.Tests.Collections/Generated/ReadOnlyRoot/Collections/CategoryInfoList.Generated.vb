﻿'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated using CodeSmith: v5.2.2, CSLA Templates: v3.0.0.0, CSLA Framework: v3.8.4.
'     Changes to this file will be lost after each regeneration.
'     To extend the functionality of this class, please modify the partial class 'CategoryInfoList.vb.
'
'     Template: ReadOnlyList.Generated.cst
'     Template website: http://code.google.com/p/codesmith/
' </autogenerated>
'------------------------------------------------------------------------------
Option Explicit On
Option Strict On

Imports System
Imports System.Collections.Generic

Imports Csla
Imports Csla.Data

Namespace PetShop.Tests.Collections.ReadOnlyRoot
    <Serializable()> _
    Public Partial Class CategoryInfoList
        Inherits ReadOnlyListBase(Of CategoryInfoList, CategoryInfo)
    
#Region "Contructor(s)"
        Private Sub New()
        End Sub
        
#End Region
    
#Region "Synchronous Factory Methods"
    
        Public Shared Function GetByCategoryId(ByVal categoryId As System.String) As CategoryInfoList 
            Dim criteria As New CategoryCriteria()
            criteria.CategoryId = categoryId
    
            Return DataPortal.Fetch(Of CategoryInfoList)(criteria)
        End Function
    
        Public Shared Function GetAll() As CategoryInfoList
            Return DataPortal.Fetch(Of CategoryInfoList)(New CategoryCriteria())
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
        Partial Private Sub OnAddNewCore(ByVal item As CategoryInfo, ByRef cancel As Boolean)
        End Sub
    
#End Region

#Region "Exists Command"

        Public Shared Function Exists(ByVal criteria As CategoryCriteria) As Boolean
            Return PetShop.Tests.Collections.ReadOnlyRoot.CategoryInfo.Exists(criteria)
        End Function

#End Region
    End Class
End Namespace