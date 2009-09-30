﻿
'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated by a CodeSmith Template.
'
'     DO NOT MODIFY contents of this file. Changes to this
'     file will be lost if the code is regenerated.
' </autogenerated>
'------------------------------------------------------------------------------

Imports System
Imports System.Data.Linq
Imports System.Linq
Imports System.Runtime.CompilerServices
Imports System.Linq.Dynamic

Namespace PetShop.Core.Data
    ''' <summary>
    ''' The query extension class for Product.
    ''' </summary>
    Public Module ProductExtensions
        ''' <summary>
        ''' Gets an instance by the primary key.
        ''' </summary>
        <System.Runtime.CompilerServices.Extension> _
        Public Function GetByKey(ByVal queryable As IQueryable(Of PetShop.Core.Data.Product), ByVal productId As String) As PetShop.Core.Data.Product

            Dim entity As System.Data.Linq.Table(Of PetShop.Core.Data.Product) = CType(queryable, Table(Of PetShop.Core.Data.Product))
            If (entity IsNot Nothing AndAlso entity.Context.LoadOptions Is Nothing) Then
                Return Query.GetByKey.Invoke(DirectCast(entity.Context, PetShop.Core.Data.PetshopDataContext), productId)
            End If

            Return queryable.FirstOrDefault(Function(p)p.ProductId = productId)
        End Function
        
        ''' <summary>
        ''' Immediately deletes the entity by the primary key from the underlying data source with a single delete command.
        ''' </summary>
        ''' <param name="table">Represents a table for a particular type in the underlying database containing rows are to be deleted.</param>
        ''' <returns>The number of rows deleted from the database.</returns>
        <System.Runtime.CompilerServices.Extension> _
        Public Function Delete(ByVal table As System.Data.Linq.Table(Of PetShop.Core.Data.Product), ByVal productId As String) As Integer
            Return table.Delete(Function(p)p.ProductId = productId)
        End Function

        ''' <summary>
        ''' Gets a query for <see cref="PetShop.Core.Data.Product"/>.
        ''' </summary>
        ''' <param name="queryable">Query to append where clause.</param>
        ''' <param name="productId">ProductId to search for.</param>
        ''' <returns>IQueryable with additional where clause.</returns>
        <System.Runtime.CompilerServices.Extension> _
        Public Function ByProductId(queryable As IQueryable(Of PetShop.Core.Data.Product), productId As String) As IQueryable(Of PetShop.Core.Data.Product)
            Return queryable.Where(Function(p)p.ProductId = productId)
        End Function
        
        ''' <summary>
        ''' Gets a query for <see cref="PetShop.Core.Data.Product"/>.
        ''' </summary>
        ''' <param name="queryable">Query to append where clause.</param>
        ''' <param name="productId">ProductId to search for.</param>
        ''' <param name="additionalValues">Additional values to search for.</param>
        ''' <returns>IQueryable with additional where clause.</returns>
        <System.Runtime.CompilerServices.Extension> _
        Public Function ByProductId(queryable As IQueryable(Of PetShop.Core.Data.Product), productId As String, ParamArray additionalValues As String()) As IQueryable(Of PetShop.Core.Data.Product)
            Dim ProductIdList = New List(Of String)()
            ProductIdList.Add(productId)
        
            If additionalValues IsNot Nothing Then
                ProductIdList.AddRange(additionalValues)
            End If
        
            If ProductIdList.Count = 1 Then
                Return queryable.ByProductId(ProductIdList(0))
            End If
        
            Dim expression = DynamicExpression.BuildExpression(Of PetShop.Core.Data.Product, Boolean)("ProductId", ProductIdList)
            Return queryable.Where(expression)
        End Function

        ''' <summary>
        ''' Gets a query for <see cref="PetShop.Core.Data.Product"/>.
        ''' </summary>
        ''' <param name="queryable">Query to append where clause.</param>
        ''' <param name="categoryId">CategoryId to search for.</param>
        ''' <returns>IQueryable with additional where clause.</returns>
        <System.Runtime.CompilerServices.Extension> _
        Public Function ByCategoryId(queryable As IQueryable(Of PetShop.Core.Data.Product), categoryId As String) As IQueryable(Of PetShop.Core.Data.Product)
            Return queryable.Where(Function(p)p.CategoryId = categoryId)
        End Function
        
        ''' <summary>
        ''' Gets a query for <see cref="PetShop.Core.Data.Product"/>.
        ''' </summary>
        ''' <param name="queryable">Query to append where clause.</param>
        ''' <param name="categoryId">CategoryId to search for.</param>
        ''' <param name="additionalValues">Additional values to search for.</param>
        ''' <returns>IQueryable with additional where clause.</returns>
        <System.Runtime.CompilerServices.Extension> _
        Public Function ByCategoryId(queryable As IQueryable(Of PetShop.Core.Data.Product), categoryId As String, ParamArray additionalValues As String()) As IQueryable(Of PetShop.Core.Data.Product)
            Dim CategoryIdList = New List(Of String)()
            CategoryIdList.Add(categoryId)
        
            If additionalValues IsNot Nothing Then
                CategoryIdList.AddRange(additionalValues)
            End If
        
            If CategoryIdList.Count = 1 Then
                Return queryable.ByCategoryId(CategoryIdList(0))
            End If
        
            Dim expression = DynamicExpression.BuildExpression(Of PetShop.Core.Data.Product, Boolean)("CategoryId", CategoryIdList)
            Return queryable.Where(expression)
        End Function

        ''' <summary>
        ''' Gets a query for <see cref="PetShop.Core.Data.Product"/>.
        ''' </summary>
        ''' <param name="queryable">Query to append where clause.</param>
        ''' <param name="name">Name to search for.</param>
        ''' <returns>IQueryable with additional where clause.</returns>
        <System.Runtime.CompilerServices.Extension> _
        Public Function ByName(queryable As IQueryable(Of PetShop.Core.Data.Product), name As String) As IQueryable(Of PetShop.Core.Data.Product)
            Return queryable.Where(Function(p) Object.Equals(p.Name, name))
        End Function
        
        ''' <summary>
        ''' Gets a query for <see cref="PetShop.Core.Data.Product"/>.
        ''' </summary>
        ''' <param name="queryable">Query to append where clause.</param>
        ''' <param name="name">Name to search for.</param>
        ''' <param name="additionalValues">Additional values to search for.</param>
        ''' <returns>IQueryable with additional where clause.</returns>
        <System.Runtime.CompilerServices.Extension> _
        Public Function ByName(queryable As IQueryable(Of PetShop.Core.Data.Product), name As String, ParamArray additionalValues As String()) As IQueryable(Of PetShop.Core.Data.Product)
            Dim NameList = New List(Of String)()
            NameList.Add(name)
        
            If additionalValues IsNot Nothing Then
                NameList.AddRange(additionalValues)
            Else
                NameList.Add(Nothing)
            End If
        
            If NameList.Count = 1 Then
                Return queryable.ByName(NameList(0))
            End If
        
            Dim expression = DynamicExpression.BuildExpression(Of PetShop.Core.Data.Product, Boolean)("Name", NameList)
            Return queryable.Where(expression)
        End Function

        ''' <summary>
        ''' Gets a query for <see cref="PetShop.Core.Data.Product"/>.
        ''' </summary>
        ''' <param name="queryable">Query to append where clause.</param>
        ''' <param name="descn">Descn to search for.</param>
        ''' <returns>IQueryable with additional where clause.</returns>
        <System.Runtime.CompilerServices.Extension> _
        Public Function ByDescn(queryable As IQueryable(Of PetShop.Core.Data.Product), descn As String) As IQueryable(Of PetShop.Core.Data.Product)
            Return queryable.Where(Function(p) Object.Equals(p.Descn, descn))
        End Function
        
        ''' <summary>
        ''' Gets a query for <see cref="PetShop.Core.Data.Product"/>.
        ''' </summary>
        ''' <param name="queryable">Query to append where clause.</param>
        ''' <param name="descn">Descn to search for.</param>
        ''' <param name="additionalValues">Additional values to search for.</param>
        ''' <returns>IQueryable with additional where clause.</returns>
        <System.Runtime.CompilerServices.Extension> _
        Public Function ByDescn(queryable As IQueryable(Of PetShop.Core.Data.Product), descn As String, ParamArray additionalValues As String()) As IQueryable(Of PetShop.Core.Data.Product)
            Dim DescnList = New List(Of String)()
            DescnList.Add(descn)
        
            If additionalValues IsNot Nothing Then
                DescnList.AddRange(additionalValues)
            Else
                DescnList.Add(Nothing)
            End If
        
            If DescnList.Count = 1 Then
                Return queryable.ByDescn(DescnList(0))
            End If
        
            Dim expression = DynamicExpression.BuildExpression(Of PetShop.Core.Data.Product, Boolean)("Descn", DescnList)
            Return queryable.Where(expression)
        End Function

        ''' <summary>
        ''' Gets a query for <see cref="PetShop.Core.Data.Product"/>.
        ''' </summary>
        ''' <param name="queryable">Query to append where clause.</param>
        ''' <param name="image">Image to search for.</param>
        ''' <returns>IQueryable with additional where clause.</returns>
        <System.Runtime.CompilerServices.Extension> _
        Public Function ByImage(queryable As IQueryable(Of PetShop.Core.Data.Product), image As String) As IQueryable(Of PetShop.Core.Data.Product)
            Return queryable.Where(Function(p) Object.Equals(p.Image, image))
        End Function
        
        ''' <summary>
        ''' Gets a query for <see cref="PetShop.Core.Data.Product"/>.
        ''' </summary>
        ''' <param name="queryable">Query to append where clause.</param>
        ''' <param name="image">Image to search for.</param>
        ''' <param name="additionalValues">Additional values to search for.</param>
        ''' <returns>IQueryable with additional where clause.</returns>
        <System.Runtime.CompilerServices.Extension> _
        Public Function ByImage(queryable As IQueryable(Of PetShop.Core.Data.Product), image As String, ParamArray additionalValues As String()) As IQueryable(Of PetShop.Core.Data.Product)
            Dim ImageList = New List(Of String)()
            ImageList.Add(image)
        
            If additionalValues IsNot Nothing Then
                ImageList.AddRange(additionalValues)
            Else
                ImageList.Add(Nothing)
            End If
        
            If ImageList.Count = 1 Then
                Return queryable.ByImage(ImageList(0))
            End If
        
            Dim expression = DynamicExpression.BuildExpression(Of PetShop.Core.Data.Product, Boolean)("Image", ImageList)
            Return queryable.Where(expression)
        End Function

        'Insert User Defined Extensions here.
        'Anything outside of this Region will be lost at regeneration
        #Region "User Extensions"


        #End Region

        #Region "Query"
        ''' <summary>
        ''' A private class for lazy loading static compiled queries.
        ''' </summary>
        Private Partial Class Query


            Friend Shared ReadOnly GetByKey As Func(Of PetshopDataContext, String, PetShop.Core.Data.Product) = _
                CompiledQuery.Compile( _
                    Function(db As PetshopDataContext , ByVal productId As String) _
                        db.Product.FirstOrDefault(Function(p)p.ProductId = productId))

            ' Add your compiled queries here.
            'Anything outside of this Region will be lost at regeneration
            #Region "User Queries"

            #End Region

        End Class
        #End Region
    End Module
End Namespace

