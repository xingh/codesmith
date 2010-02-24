﻿'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated using CodeSmith: v5.2.1, CSLA Templates: v2.0.0.1440, CSLA Framework: v3.8.2.
'     Changes to this file will be lost after each regeneration.
'     To extend the functionality of this class, please modify the partial class 'ProfileList.vb.
'
'     Template: EditableRootList.Generated.cst
'     Template website: http://code.google.com/p/codesmith/
' </autogenerated>
'------------------------------------------------------------------------------
Option Explicit On
Option Strict On

Imports System

Imports Csla
Imports Csla.Data

<Serializable()> _
Public Partial Class ProfileList 
    Inherits BusinessListBase(Of ProfileList, Profile)

    #Region "Contructor(s)"
    
    Private Sub New()
        AllowNew = true
    End Sub
    
    #End Region

    #Region "Factory Methods"

    Public Shared Function NewList() As ProfileList
        Return DataPortal.Create(Of ProfileList)()
    End Function

    Public Shared Function GetByUniqueID(ByVal uniqueID As System.Int32) As ProfileList 
        Dim criteria As New ProfileCriteria()
        criteria.UniqueID = uniqueID

        Return DataPortal.Fetch(Of ProfileList)(criteria)
    End Function

    Public Shared Function GetByUsernameApplicationName(ByVal username As System.String, ByVal applicationName As System.String) As ProfileList 
        Dim criteria As New ProfileCriteria()
        criteria.Username = username
			criteria.ApplicationName = applicationName

        Return DataPortal.Fetch(Of ProfileList)(criteria)
    End Function

    Public Shared Function GetAll() As ProfileList
        Return DataPortal.Fetch(Of ProfileList)(New ProfileCriteria())
    End Function

    #End Region

    #Region "Properties"

    Protected Overrides Function AddNewCore() As Object
        Dim item As Profile = PetShop.Business.Profile.NewProfile()
        Me.Add(item)
        Return item
    End Function

    #End Region

    #Region "Exists Command"

    Public Shared Function Exists(ByVal criteria As ProfileCriteria) As Boolean
        Return PetShop.Business.Profile.Exists(criteria)
    End Function

    #End Region

End Class