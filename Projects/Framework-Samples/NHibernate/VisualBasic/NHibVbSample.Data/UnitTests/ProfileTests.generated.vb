Imports System
Imports System.Collections.Generic
Imports System.Text
Imports NUnit.Framework
Imports NHibVbSample.Generated.ManagerObjects
Imports NHibVbSample.Generated.BusinessObjects
Imports NHibVbSample.Generated.Base

Namespace NHibVbSample.Generated.UnitTests
	<TestFixture()> _
	Public Partial Class ProfileTests
		Inherits UNuitTestBase
		
		Protected manager As IProfileManager

		Public Sub New()
			manager = managerFactory.GetProfileManager()
		End Sub

		Protected Function CreateNewProfile() As Profile
			Dim entity As New Profile()

			
			entity.Username = "Test Test "
			entity.ApplicationName = "Test Test "
			entity.IsAnonymous = True
			entity.LastActivityDate = DateTime.Now
			entity.LastUpdatedDate = DateTime.Now

			Return entity
		End Function
		Protected Function GetFirstProfile() As Profile
			Dim entityList As IList(Of Profile) = manager.GetAll(1)
			If entityList.Count = 0 Then
				Assert.Fail("All tables must have at least one row for unit tests to succeed.")
			End If
			Return entityList(0)
		End Function

		<Test()> _
		Public Sub Create()
			Try
				Dim entity As Profile = CreateNewProfile()

				Dim result As Object = manager.Save(entity)

				Assert.IsNotNull(result)
			Catch ex As Exception
				Assert.Fail(ex.ToString())
			End Try
		End Sub
		<Test()> _
		Public Sub Read()
			Try
				Dim entityA As Profile = CreateNewProfile()
				manager.Save(entityA)

				Dim entityB As Profile = manager.GetById(entityA.Id)

				Assert.AreEqual(entityA, entityB)
			Catch ex As Exception
				Assert.Fail(ex.ToString())
			End Try
		End Sub
		<Test()> _
		Public Sub Update()
			Try
				Dim entityA As Profile = GetFirstProfile()
				
				entityA.Username = "Test Test "
				
				manager.Update(entityA)

				Dim entityB As Profile = manager.GetById(entityA.Id)

				Assert.AreEqual(entityA.Username, entityB.Username)
			Catch ex As Exception
				Assert.Fail(ex.ToString())
			End Try
		End Sub
		<Test()> _
		Public Sub Delete()
			Try
				Dim entity As Profile = GetFirstProfile()

				manager.Delete(entity)

                entity = manager.GetById(entity.Id)
                Assert.IsNull(entity)
			Catch ex As Exception
				Assert.Fail(ex.ToString())
			End Try
		End Sub
	End Class
End Namespace

