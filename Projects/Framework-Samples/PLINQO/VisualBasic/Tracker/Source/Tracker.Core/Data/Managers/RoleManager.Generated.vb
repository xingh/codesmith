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
Imports System.Collections.Generic
Imports System.Data.Linq
Imports System.Linq
Imports System.Text

Namespace Tracker.Core.Data
    ''' <summary>
    ''' The manager class for Role.
    ''' </summary>
    Partial Public Class RoleManager 
        Inherits CodeSmith.Data.EntityManagerBase(Of TrackerDataManager, Tracker.Core.Data.Role)

        ''' <summary>
        ''' Initializes the <see cref="RoleManager"/> class.
        ''' </summary>
        ''' <param name="manager">The current manager.</param>
        Public Sub New(ByVal manager As TrackerDataManager) 
            MyBase.New(manager)
            OnCreated()
        End Sub

        ''' <summary>
        ''' Gets the current context.
        ''' </summary>
        Protected ReadOnly Property Context() As Tracker.Core.Data.TrackerDataContext
            Get
                return Manager.Context
            End Get
        End Property
        
        ''' <summary>
        ''' Gets the entity for this manager.
        ''' </summary>
        Protected ReadOnly Property Entity() As System.Data.Linq.Table(Of Tracker.Core.Data.Role)
            Get 
                return Manager.Context.Role
            End Get
        End Property
        
        
        ''' <summary>
        ''' Creates the key for this entity.
        ''' </summary>
        Public Shared Function CreateKey(ByVal id As Integer) As CodeSmith.Data.IEntityKey(Of Integer)
            Return New CodeSmith.Data.EntityKey(Of Integer)(id)
        End Function
        
        ''' <summary>
        ''' Gets an entity by the primary key.
        ''' </summary>
        ''' <param name="key">The key for the entity.</param>
        ''' <returns>
        ''' An instance of the entity or null if not found.
        ''' </returns>
        ''' <remarks>
        ''' This method is expecting key to be of type IEntityKey(Of Integer).
        ''' </remarks>
        ''' <exception cref="ArgumentException">Thrown when key is not of type IEntityKey(Of Integer).</exception>
        Public Overrides Function GetByKey(ByVal key As CodeSmith.Data.IEntityKey) As Tracker.Core.Data.Role
            If (key Is GetType(CodeSmith.Data.IEntityKey(Of Integer))) Then
                Dim entityKey As CodeSmith.Data.IEntityKey(Of Integer) = DirectCast(key, CodeSmith.Data.IEntityKey(Of Integer))
                return GetByKey(entityKey.Key)
            Else
                Throw New ArgumentException("Invalid key, expected key to be of type IEntityKey(Of Integer)")
            End If
        End Function
        
        ''' <summary>
        ''' Gets an instance by the primary key.
        ''' </summary>
        ''' <returns>An instance of the entity or null if not found.</returns>
        Public Overloads Function GetByKey(ByVal id As Integer) As Tracker.Core.Data.Role
            If (Context.LoadOptions Is Nothing) Then 
                return Query.GetByKey.Invoke(Context, id)
            Else
                return Entity.FirstOrDefault(Function(r)r.Id = id)
            End If
        End Function
        
        ''' <summary>
        ''' Immediately deletes the entity by the primary key from the underlying data source with a single delete command.
        ''' </summary>
        ''' <returns>The number of rows deleted from the database.</returns>
        Public Function Delete(ByVal id As Integer) As Integer
            return Entity.Delete(Function(r)r.Id = id)
        End Function

        #Region "Extensibility Method Definitions"
        ''' <summary>Called when the class is created.</summary>
        Partial Private Sub OnCreated()
        End Sub
        #End Region
        
        #Region "Query"
        ''' <summary>
        ''' A private class for lazy loading static compiled queries.
        ''' </summary>
        Private Partial Class Query

            Friend Shared Readonly GetByKey As Func(Of Tracker.Core.Data.TrackerDataContext, Integer, Tracker.Core.Data.Role) = _
                CompiledQuery.Compile( _
                     Function(db As Tracker.Core.Data.TrackerDataContext, ByVal id As Integer) _
                        db.Role.FirstOrDefault(Function(r)r.Id = id))

        End Class
        #End Region
    End Class
End Namespace

