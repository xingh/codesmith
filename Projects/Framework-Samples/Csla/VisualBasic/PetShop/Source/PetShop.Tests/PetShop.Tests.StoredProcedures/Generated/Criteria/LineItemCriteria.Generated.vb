'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated using CodeSmith: v5.2.1, CSLA Templates: v1.5.0.0, CSLA Framework: v3.8.0.
'     Changes to this file will be lost after each regeneration.
'     To extend the functionality of this class, please modify the partial class 'LineItem.vb.
'
'     Template: Criteria.Generated.cst
'     Template website: http://code.google.com/p/codesmith/
' </autogenerated>
'------------------------------------------------------------------------------
Option Explicit On
'Option Strict On

#Region "Using declarations"

Imports System
Imports System.Collections.Generic
Imports System.Data.SqlClient

Imports Csla

#End Region

<Serializable()> _
Public Partial Class LineItemCriteria
    Inherits CriteriaBase
    Implements IGeneratedCriteria

    #Region "Private Read-Only Members"
    
    Private ReadOnly _bag As New Dictionary(Of String, Object)()
    
    #End Region

    #Region "Constructors"

    Public Sub New()
        MyBase.New(GetType(LineItem))
    End Sub
    
    Public Sub New(ByVal orderId As System.Int32, ByVal lineNum As System.Int32) 
        MyBase.New(GetType(LineItem))
        
        Me.OrderId = orderId
        Me.LineNum = lineNum
    End Sub

    
    #End Region

    #Region "Public Properties"
    
    #Region "Read-Write"
    
    Public Property OrderId() As System.Int32
        Get
            Return GetValue(Of System.Int32)("OrderId")
        End Get
        Set
            _bag("OrderId") = value
        End Set
    End Property
    
    Public Property LineNum() As System.Int32
        Get
            Return GetValue(Of System.Int32)("LineNum")
        End Get
        Set
            _bag("LineNum") = value
        End Set
    End Property
    
    Public Property ItemId() As System.String
        Get
            Return GetValue(Of System.String)("ItemId")
        End Get
        Set
            _bag("ItemId") = value
        End Set
    End Property
    
    Public Property Quantity() As System.Int32
        Get
            Return GetValue(Of System.Int32)("Quantity")
        End Get
        Set
            _bag("Quantity") = value
        End Set
    End Property
    
    Public Property UnitPrice() As System.Decimal
        Get
            Return GetValue(Of System.Decimal)("UnitPrice")
        End Get
        Set
            _bag("UnitPrice") = value
        End Set
    End Property

    #End Region
    
    #Region "Read-Only"
    
    ''' <summary>
    ''' Returns a list of all the modified properties and values.
    ''' </summary>
    Public ReadOnly Property StateBag() As Dictionary(Of String, Object) Implements IGeneratedCriteria.StateBag
        Get
            Return _bag
        End Get
    End Property

    ''' <summary>
    ''' Returns a list of all the modified properties and values.
    ''' </summary>
    Public ReadOnly Property TableName() As String Implements IGeneratedCriteria.TableName
        Get
            Return "[dbo].LineItem"
        End Get
    End Property

    #End Region

    #End Region

    #region "Overrides"

    Public Overrides Function ToString() As String
        If _bag.Count = 0 Then
            Return "No criterion was specified"
        End If

        Dim result As String = String.Empty
        For Each key As KeyValuePair(Of String, Object) In _bag
            result += String.Format("[{0}] = '{1}' AND ", key.Key, key.Value)
        Next

        Return result.Remove(result.Length - 5, 5)
    End Function

    #End Region

    #Region "Private Methods"
    
    Private Function GetValue(Of T)(name As String) As T
        Dim value As T
        If _bag.TryGetValue(name, value) Then
            Return DirectCast(value, T)
        End If
    
        Return Nothing
    End Function
    
    #End Region

End Class