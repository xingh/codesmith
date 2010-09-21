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

Namespace PetShop.Tests.ParameterizedSQL
    Public Partial Class Order
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
    
            'AuthorizationRules.AllowCreate(GetType(Order), admin)
            'AuthorizationRules.AllowDelete(GetType(Order), admin)
            'AuthorizationRules.AllowEdit(GetType(Order), canWrite)
            'AuthorizationRules.AllowGet(GetType(Order), canRead)
    
            ''OrderId
            'AuthorizationRules.AllowRead(_orderIdProperty, canRead)
    
            ''UserId
            'AuthorizationRules.AllowWrite(_userIdProperty, canWrite)
            'AuthorizationRules.AllowRead(_userIdProperty, canRead)
    
            ''OrderDate
            'AuthorizationRules.AllowWrite(_orderDateProperty, canWrite)
            'AuthorizationRules.AllowRead(_orderDateProperty, canRead)
    
            ''ShipAddr1
            'AuthorizationRules.AllowWrite(_shipAddr1Property, canWrite)
            'AuthorizationRules.AllowRead(_shipAddr1Property, canRead)
    
            ''ShipAddr2
            'AuthorizationRules.AllowWrite(_shipAddr2Property, canWrite)
            'AuthorizationRules.AllowRead(_shipAddr2Property, canRead)
    
            ''ShipCity
            'AuthorizationRules.AllowWrite(_shipCityProperty, canWrite)
            'AuthorizationRules.AllowRead(_shipCityProperty, canRead)
    
            ''ShipState
            'AuthorizationRules.AllowWrite(_shipStateProperty, canWrite)
            'AuthorizationRules.AllowRead(_shipStateProperty, canRead)
    
            ''ShipZip
            'AuthorizationRules.AllowWrite(_shipZipProperty, canWrite)
            'AuthorizationRules.AllowRead(_shipZipProperty, canRead)
    
            ''ShipCountry
            'AuthorizationRules.AllowWrite(_shipCountryProperty, canWrite)
            'AuthorizationRules.AllowRead(_shipCountryProperty, canRead)
    
            ''BillAddr1
            'AuthorizationRules.AllowWrite(_billAddr1Property, canWrite)
            'AuthorizationRules.AllowRead(_billAddr1Property, canRead)
    
            ''BillAddr2
            'AuthorizationRules.AllowWrite(_billAddr2Property, canWrite)
            'AuthorizationRules.AllowRead(_billAddr2Property, canRead)
    
            ''BillCity
            'AuthorizationRules.AllowWrite(_billCityProperty, canWrite)
            'AuthorizationRules.AllowRead(_billCityProperty, canRead)
    
            ''BillState
            'AuthorizationRules.AllowWrite(_billStateProperty, canWrite)
            'AuthorizationRules.AllowRead(_billStateProperty, canRead)
    
            ''BillZip
            'AuthorizationRules.AllowWrite(_billZipProperty, canWrite)
            'AuthorizationRules.AllowRead(_billZipProperty, canRead)
    
            ''BillCountry
            'AuthorizationRules.AllowWrite(_billCountryProperty, canWrite)
            'AuthorizationRules.AllowRead(_billCountryProperty, canRead)
    
            ''Courier
            'AuthorizationRules.AllowWrite(_courierProperty, canWrite)
            'AuthorizationRules.AllowRead(_courierProperty, canRead)
    
            ''TotalPrice
            'AuthorizationRules.AllowWrite(_totalPriceProperty, canWrite)
            'AuthorizationRules.AllowRead(_totalPriceProperty, canRead)
    
            ''BillToFirstName
            'AuthorizationRules.AllowWrite(_billToFirstNameProperty, canWrite)
            'AuthorizationRules.AllowRead(_billToFirstNameProperty, canRead)
    
            ''BillToLastName
            'AuthorizationRules.AllowWrite(_billToLastNameProperty, canWrite)
            'AuthorizationRules.AllowRead(_billToLastNameProperty, canRead)
    
            ''ShipToFirstName
            'AuthorizationRules.AllowWrite(_shipToFirstNameProperty, canWrite)
            'AuthorizationRules.AllowRead(_shipToFirstNameProperty, canRead)
    
            ''ShipToLastName
            'AuthorizationRules.AllowWrite(_shipToLastNameProperty, canWrite)
            'AuthorizationRules.AllowRead(_shipToLastNameProperty, canRead)
    
            ''AuthorizationNumber
            'AuthorizationRules.AllowWrite(_authorizationNumberProperty, canWrite)
            'AuthorizationRules.AllowRead(_authorizationNumberProperty, canRead)
    
            ''Locale
            'AuthorizationRules.AllowWrite(_localeProperty, canWrite)
            'AuthorizationRules.AllowRead(_localeProperty, canRead)
    
    ' NOTE: Many-To-Many support coming soon.
            ''LineItems
            'AuthorizationRules.AllowRead(_lineItemsProperty, canRead)
    
            ''OrderStatuses
            'AuthorizationRules.AllowRead(_orderStatusesProperty, canRead)
    
        End Sub
    
#End Region
    End Class
End Namespace