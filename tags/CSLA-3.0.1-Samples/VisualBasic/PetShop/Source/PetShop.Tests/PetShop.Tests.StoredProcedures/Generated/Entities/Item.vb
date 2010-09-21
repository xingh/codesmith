﻿'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated using CodeSmith: v5.2.2, CSLA Templates: v3.0.0.0, CSLA Framework: v3.8.4.
'       Changes to this template will not be lost.
'
'     Template: SwitchableObject.cst
'     Template website: http://code.google.com/p/codesmith/
' </autogenerated>
'------------------------------------------------------------------------------
Option Explicit On
Option Strict On

Imports System

Imports Csla
Imports Csla.Security
Imports Csla.Validation

Namespace PetShop.Tests.StoredProcedures
    Public Partial Class Item
#Region "Business Rules"
    
        ''' <summary>
        ''' All custom rules need to be placed in this method.
        ''' </summary>
        ''' <Returns>Return true to override the generated rules If false generated rules will be run.</Returns>
        Protected Function AddBusinessValidationRules() As Boolean
            ' TODO: add validation rules
            'ValidationRules.AddRule(RuleMethod, "")
    
            Return False
        End Function
    
#End Region
    
#Region "Authorization Rules"
    
    
        Protected Overrides Sub AddAuthorizationRules()
            ''More information on these rules can be found here (http://www.devx.com/codemag/Article/40663/1763/page/2).
    
            'Dim canWrite As String() = { "AdminUser", "RegularUser" }
            'Dim canRead As String() = { "AdminUser", "RegularUser", "ReadOnlyUser" }
            'Dim admin As String() = { "AdminUser" }
    
            'AuthorizationRules.AllowCreate(GetType(Item), admin)
            'AuthorizationRules.AllowDelete(GetType(Item), admin)
            'AuthorizationRules.AllowEdit(GetType(Item), canWrite)
            'AuthorizationRules.AllowGet(GetType(Item), canRead)
    
            ''ItemId
            'AuthorizationRules.AllowWrite(_itemIdProperty, canWrite)
            'AuthorizationRules.AllowRead(_itemIdProperty, canRead)
    
            ''ProductId
            'AuthorizationRules.AllowWrite(_productIdProperty, canWrite)
            'AuthorizationRules.AllowRead(_productIdProperty, canRead)
    
            ''ListPrice
            'AuthorizationRules.AllowWrite(_listPriceProperty, canWrite)
            'AuthorizationRules.AllowRead(_listPriceProperty, canRead)
    
            ''UnitCost
            'AuthorizationRules.AllowWrite(_unitCostProperty, canWrite)
            'AuthorizationRules.AllowRead(_unitCostProperty, canRead)
    
            ''Supplier
            'AuthorizationRules.AllowWrite(_supplierProperty, canWrite)
            'AuthorizationRules.AllowRead(_supplierProperty, canRead)
    
            ''Status
            'AuthorizationRules.AllowWrite(_statusProperty, canWrite)
            'AuthorizationRules.AllowRead(_statusProperty, canRead)
    
            ''Name
            'AuthorizationRules.AllowWrite(_nameProperty, canWrite)
            'AuthorizationRules.AllowRead(_nameProperty, canRead)
    
            ''Image
            'AuthorizationRules.AllowWrite(_imageProperty, canWrite)
            'AuthorizationRules.AllowRead(_imageProperty, canRead)
    
            ''ProductMember
            'AuthorizationRules.AllowRead(_productMemberProperty, canRead)
    
            ''SupplierMember
            'AuthorizationRules.AllowRead(_supplierMemberProperty, canRead)
    
    ' NOTE: Many-To-Many support coming soon.
        End Sub
    
#End Region
    End Class
End Namespace