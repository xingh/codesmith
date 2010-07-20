﻿'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated by a CodeSmith Template.
'
'     DO Not MODIfY contents of this file. Changes to this
'     file will be lost if the code is regenerated.
' </autogenerated>
'------------------------------------------------------------------------------
Imports System
Imports System.Linq

Namespace PetShop.Core.Data
    ''' <summary>
    ''' The class representing the dbo.Account table.
    ''' </summary>
    <System.Data.Linq.Mapping.Table(Name:="dbo.Account")> _
    <System.Runtime.Serialization.DataContract(IsReference:=True)> _
    <System.ComponentModel.DataAnnotations.ScaffoldTable(True)> _
    <System.ComponentModel.DataAnnotations.MetadataType(GetType(Account.Metadata))> _
    <System.Data.Services.Common.DataServiceKey("AccountID")> _
    <System.Diagnostics.DebuggerDisplay("AccountID: {AccountID}")> _
    Partial Public Class Account
        Inherits LinqEntityBase
        Implements ICloneable

#Region "Static Constructor"
        ''' <summary>
        ''' Initializes the <see cref="Account"/> class.
        ''' </summary>
        Shared Sub New()
            AddSharedRules()
        End Sub
#End Region

#Region "Default Constructor"
        ''' <summary>
        ''' Initializes a new instance of the <see cref="Account"/> class.
        ''' </summary>
        <System.Diagnostics.DebuggerNonUserCode()> _
        Public Sub New()
            Initialize()
        End Sub

        Private Sub Initialize()
            _profile = Nothing
            OnCreated()
        End Sub
#End Region

#Region "Column Mapped Properties"

        Private _accountID As Integer = Nothing

        ''' <summary>
        ''' Gets the AccountID column value.
        ''' </summary>
        <System.Data.Linq.Mapping.Column(Name:="AccountID", Storage:="_accountID", DbType:="int NOT NULL IDENTITY", IsPrimaryKey:=True, IsDbGenerated:=True, CanBeNull:=False)> _
        <System.Runtime.Serialization.DataMember(Order:=1)> _
        Public Property AccountID() As Integer
            Get
                Return _accountID
            End Get
            Set(ByVal value As Integer)
                If ((Me._accountID = value) = False) Then
                    OnAccountIDChanging(value)
                    SendPropertyChanging("AccountID")
                    _accountID = value
                    SendPropertyChanged("AccountID")
                    OnAccountIDChanged()
                End If
            End Set
        End Property

        Private _uniqueID As Integer

        ''' <summary>
        ''' Gets or sets the UniqueID column value.
        ''' </summary>
        <System.Data.Linq.Mapping.Column(Name:="UniqueID", Storage:="_uniqueID", DbType:="int NOT NULL", CanBeNull:=False)> _
        <System.Runtime.Serialization.DataMember(Order:=2)> _
        Public Property UniqueID() As Integer
            Get
                Return _uniqueID
            End Get
            Set(ByVal value As Integer)
                If ((Me._uniqueID = value) = False) Then
                    If (_profile.HasLoadedOrAssignedValue) Then
                        Throw New System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException()
                    End If
                    OnUniqueIDChanging(value)
                    SendPropertyChanging("UniqueID")
                    _uniqueID = value
                    SendPropertyChanged("UniqueID")
                    OnUniqueIDChanged()
                End If
            End Set
        End Property

        Private _email As String

        ''' <summary>
        ''' Gets or sets the Email column value.
        ''' </summary>
        <System.Data.Linq.Mapping.Column(Name:="Email", Storage:="_email", DbType:="varchar(80) NOT NULL", CanBeNull:=False)> _
        <ComponentModel.DataAnnotations.StringLength(80)> _
        <System.Runtime.Serialization.DataMember(Order:=3)> _
        Public Property Email() As String
            Get
                Return _email
            End Get
            Set(ByVal value As String)
                If (String.Equals(Me._email, value) = False) Then
                    OnEmailChanging(value)
                    SendPropertyChanging("Email")
                    _email = value
                    SendPropertyChanged("Email")
                    OnEmailChanged()
                End If
            End Set
        End Property

        Private _firstName As String

        ''' <summary>
        ''' Gets or sets the FirstName column value.
        ''' </summary>
        <System.Data.Linq.Mapping.Column(Name:="FirstName", Storage:="_firstName", DbType:="varchar(80) NOT NULL", CanBeNull:=False)> _
        <ComponentModel.DataAnnotations.StringLength(80)> _
        <System.Runtime.Serialization.DataMember(Order:=4)> _
        Public Property FirstName() As String
            Get
                Return _firstName
            End Get
            Set(ByVal value As String)
                If (String.Equals(Me._firstName, value) = False) Then
                    OnFirstNameChanging(value)
                    SendPropertyChanging("FirstName")
                    _firstName = value
                    SendPropertyChanged("FirstName")
                    OnFirstNameChanged()
                End If
            End Set
        End Property

        Private _lastName As String

        ''' <summary>
        ''' Gets or sets the LastName column value.
        ''' </summary>
        <System.Data.Linq.Mapping.Column(Name:="LastName", Storage:="_lastName", DbType:="varchar(80) NOT NULL", CanBeNull:=False)> _
        <ComponentModel.DataAnnotations.StringLength(80)> _
        <System.Runtime.Serialization.DataMember(Order:=5)> _
        Public Property LastName() As String
            Get
                Return _lastName
            End Get
            Set(ByVal value As String)
                If (String.Equals(Me._lastName, value) = False) Then
                    OnLastNameChanging(value)
                    SendPropertyChanging("LastName")
                    _lastName = value
                    SendPropertyChanged("LastName")
                    OnLastNameChanged()
                End If
            End Set
        End Property

        Private _address1 As String

        ''' <summary>
        ''' Gets or sets the Address1 column value.
        ''' </summary>
        <System.Data.Linq.Mapping.Column(Name:="Address1", Storage:="_address1", DbType:="varchar(80) NOT NULL", CanBeNull:=False)> _
        <ComponentModel.DataAnnotations.StringLength(80)> _
        <System.Runtime.Serialization.DataMember(Order:=6)> _
        Public Property Address1() As String
            Get
                Return _address1
            End Get
            Set(ByVal value As String)
                If (String.Equals(Me._address1, value) = False) Then
                    OnAddress1Changing(value)
                    SendPropertyChanging("Address1")
                    _address1 = value
                    SendPropertyChanged("Address1")
                    OnAddress1Changed()
                End If
            End Set
        End Property

        Private _address2 As String

        ''' <summary>
        ''' Gets or sets the Address2 column value.
        ''' </summary>
        <System.Data.Linq.Mapping.Column(Name:="Address2", Storage:="_address2", DbType:="varchar(80)")> _
        <ComponentModel.DataAnnotations.StringLength(80)> _
        <System.Runtime.Serialization.DataMember(Order:=7)> _
        Public Property Address2() As String
            Get
                Return _address2
            End Get
            Set(ByVal value As String)
                If (String.Equals(Me._address2, value) = False) Then
                    OnAddress2Changing(value)
                    SendPropertyChanging("Address2")
                    _address2 = value
                    SendPropertyChanged("Address2")
                    OnAddress2Changed()
                End If
            End Set
        End Property

        Private _city As String

        ''' <summary>
        ''' Gets or sets the City column value.
        ''' </summary>
        <System.Data.Linq.Mapping.Column(Name:="City", Storage:="_city", DbType:="varchar(80) NOT NULL", CanBeNull:=False)> _
        <ComponentModel.DataAnnotations.StringLength(80)> _
        <System.Runtime.Serialization.DataMember(Order:=8)> _
        Public Property City() As String
            Get
                Return _city
            End Get
            Set(ByVal value As String)
                If (String.Equals(Me._city, value) = False) Then
                    OnCityChanging(value)
                    SendPropertyChanging("City")
                    _city = value
                    SendPropertyChanged("City")
                    OnCityChanged()
                End If
            End Set
        End Property

        Private _state As String

        ''' <summary>
        ''' Gets or sets the State column value.
        ''' </summary>
        <System.Data.Linq.Mapping.Column(Name:="State", Storage:="_state", DbType:="varchar(80) NOT NULL", CanBeNull:=False)> _
        <ComponentModel.DataAnnotations.StringLength(80)> _
        <System.Runtime.Serialization.DataMember(Order:=9)> _
        Public Property State() As String
            Get
                Return _state
            End Get
            Set(ByVal value As String)
                If (String.Equals(Me._state, value) = False) Then
                    OnStateChanging(value)
                    SendPropertyChanging("State")
                    _state = value
                    SendPropertyChanged("State")
                    OnStateChanged()
                End If
            End Set
        End Property

        Private _zip As String

        ''' <summary>
        ''' Gets or sets the Zip column value.
        ''' </summary>
        <System.Data.Linq.Mapping.Column(Name:="Zip", Storage:="_zip", DbType:="varchar(20) NOT NULL", CanBeNull:=False)> _
        <ComponentModel.DataAnnotations.StringLength(20)> _
        <System.Runtime.Serialization.DataMember(Order:=10)> _
        Public Property Zip() As String
            Get
                Return _zip
            End Get
            Set(ByVal value As String)
                If (String.Equals(Me._zip, value) = False) Then
                    OnZipChanging(value)
                    SendPropertyChanging("Zip")
                    _zip = value
                    SendPropertyChanged("Zip")
                    OnZipChanged()
                End If
            End Set
        End Property

        Private _country As String

        ''' <summary>
        ''' Gets or sets the Country column value.
        ''' </summary>
        <System.Data.Linq.Mapping.Column(Name:="Country", Storage:="_country", DbType:="varchar(20) NOT NULL", CanBeNull:=False)> _
        <ComponentModel.DataAnnotations.StringLength(20)> _
        <System.Runtime.Serialization.DataMember(Order:=11)> _
        Public Property Country() As String
            Get
                Return _country
            End Get
            Set(ByVal value As String)
                If (String.Equals(Me._country, value) = False) Then
                    OnCountryChanging(value)
                    SendPropertyChanging("Country")
                    _country = value
                    SendPropertyChanged("Country")
                    OnCountryChanged()
                End If
            End Set
        End Property

        Private _phone As String

        ''' <summary>
        ''' Gets or sets the Phone column value.
        ''' </summary>
        <System.Data.Linq.Mapping.Column(Name:="Phone", Storage:="_phone", DbType:="varchar(20)")> _
        <ComponentModel.DataAnnotations.StringLength(20)> _
        <System.Runtime.Serialization.DataMember(Order:=12)> _
        Public Property Phone() As String
            Get
                Return _phone
            End Get
            Set(ByVal value As String)
                If (String.Equals(Me._phone, value) = False) Then
                    OnPhoneChanging(value)
                    SendPropertyChanging("Phone")
                    _phone = value
                    SendPropertyChanged("Phone")
                    OnPhoneChanged()
                End If
            End Set
        End Property
#End Region

#Region "Association Mapped Properties"

        Private  _profile As System.Data.Linq.EntityRef(Of Profile)

        ''' <summary>
        ''' Gets or sets the Profile association.
        ''' </summary>
        <System.Data.Linq.Mapping.Association(Name:="Profile_Account", Storage:="_profile", ThisKey:="UniqueID", OtherKey:="UniqueID", IsUnique:=true, IsForeignKey:=true, DeleteRule:="CASCADE")> _
        <System.Runtime.Serialization.DataMember(Order:=13, EmitDefaultValue:=False)> _
        Public Property Profile() As Profile
            Get
                If (serializing AndAlso Not _profile.HasLoadedOrAssignedValue) Then
                    Return Nothing
                Else
                    Return _profile.Entity
                End If
            End Get
            Set(ByVal value As Profile)
                Dim previousValue As Profile = _profile.Entity
                If ((Object.Equals(previousValue, value) = False) OrElse (Me._profile.HasLoadedOrAssignedValue = False)) Then
                    SendPropertyChanging("Profile")
                    If ((previousValue Is Nothing) = False) Then
                        _profile.Entity = Nothing
                        previousValue.AccountList.Remove(Me)
                    End If
                    _profile.Entity = value
                    If ((value Is Nothing) = False) Then
                        value.AccountList.Add(Me)
                        _uniqueID = value.UniqueID
                    Else
                        _uniqueID = Nothing
                    End If
                    SendPropertyChanged("Profile")
                End If
            End Set
        End Property
#End Region

#Region "Extensibility Method Definitions"

        ''' <summary>Called by the Shared constructor to add shared rules.</summary>
        Partial Private Shared Sub AddSharedRules()
        End Sub
        ''' <summary>Called when this instance is loaded.</summary>
        Partial Private Sub OnLoaded()
        End Sub
        ''' <summary>Called when this instance is being saved.</summary>
        Partial Private Sub OnValidate(ByVal action As System.Data.Linq.ChangeAction)
        End Sub
        ''' <summary>Called when this instance is created.</summary>
        Partial Private Sub OnCreated()
        End Sub
        ''' <summary>Called when AccountID is changing.</summary>
        ''' <param name="value">The new value.</param>
        Partial Private Sub OnAccountIDChanging(ByVal value As Integer)
        End Sub
        ''' <summary>Called after AccountID has Changed.</summary>
        Partial Private Sub OnAccountIDChanged()
        End Sub
        ''' <summary>Called when UniqueID is changing.</summary>
        ''' <param name="value">The new value.</param>
        Partial Private Sub OnUniqueIDChanging(ByVal value As Integer)
        End Sub
        ''' <summary>Called after UniqueID has Changed.</summary>
        Partial Private Sub OnUniqueIDChanged()
        End Sub
        ''' <summary>Called when Email is changing.</summary>
        ''' <param name="value">The new value.</param>
        Partial Private Sub OnEmailChanging(ByVal value As String)
        End Sub
        ''' <summary>Called after Email has Changed.</summary>
        Partial Private Sub OnEmailChanged()
        End Sub
        ''' <summary>Called when FirstName is changing.</summary>
        ''' <param name="value">The new value.</param>
        Partial Private Sub OnFirstNameChanging(ByVal value As String)
        End Sub
        ''' <summary>Called after FirstName has Changed.</summary>
        Partial Private Sub OnFirstNameChanged()
        End Sub
        ''' <summary>Called when LastName is changing.</summary>
        ''' <param name="value">The new value.</param>
        Partial Private Sub OnLastNameChanging(ByVal value As String)
        End Sub
        ''' <summary>Called after LastName has Changed.</summary>
        Partial Private Sub OnLastNameChanged()
        End Sub
        ''' <summary>Called when Address1 is changing.</summary>
        ''' <param name="value">The new value.</param>
        Partial Private Sub OnAddress1Changing(ByVal value As String)
        End Sub
        ''' <summary>Called after Address1 has Changed.</summary>
        Partial Private Sub OnAddress1Changed()
        End Sub
        ''' <summary>Called when Address2 is changing.</summary>
        ''' <param name="value">The new value.</param>
        Partial Private Sub OnAddress2Changing(ByVal value As String)
        End Sub
        ''' <summary>Called after Address2 has Changed.</summary>
        Partial Private Sub OnAddress2Changed()
        End Sub
        ''' <summary>Called when City is changing.</summary>
        ''' <param name="value">The new value.</param>
        Partial Private Sub OnCityChanging(ByVal value As String)
        End Sub
        ''' <summary>Called after City has Changed.</summary>
        Partial Private Sub OnCityChanged()
        End Sub
        ''' <summary>Called when State is changing.</summary>
        ''' <param name="value">The new value.</param>
        Partial Private Sub OnStateChanging(ByVal value As String)
        End Sub
        ''' <summary>Called after State has Changed.</summary>
        Partial Private Sub OnStateChanged()
        End Sub
        ''' <summary>Called when Zip is changing.</summary>
        ''' <param name="value">The new value.</param>
        Partial Private Sub OnZipChanging(ByVal value As String)
        End Sub
        ''' <summary>Called after Zip has Changed.</summary>
        Partial Private Sub OnZipChanged()
        End Sub
        ''' <summary>Called when Country is changing.</summary>
        ''' <param name="value">The new value.</param>
        Partial Private Sub OnCountryChanging(ByVal value As String)
        End Sub
        ''' <summary>Called after Country has Changed.</summary>
        Partial Private Sub OnCountryChanged()
        End Sub
        ''' <summary>Called when Phone is changing.</summary>
        ''' <param name="value">The new value.</param>
        Partial Private Sub OnPhoneChanging(ByVal value As String)
        End Sub
        ''' <summary>Called after Phone has Changed.</summary>
        Partial Private Sub OnPhoneChanged()
        End Sub
#End Region

#Region "Serialization"

        Private serializing As Boolean

        ''' <summary>
        ''' Called when serializing.
        ''' </summary>
        ''' <param name="context">The <see cref="System.Runtime.Serialization.StreamingContext"/> for the serialization.</param>
        <System.Runtime.Serialization.OnSerializing(), _
         System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)> _
        Public Sub OnSerializing(ByVal context As System.Runtime.Serialization.StreamingContext)
            serializing = True
        End Sub

        ''' <summary>
        ''' Called when serializing.
        ''' </summary>
        ''' <param name="context">The <see cref="System.Runtime.Serialization.StreamingContext"/> for the serialization.</param>
        <System.Runtime.Serialization.OnSerialized(), _
         System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)> _
        Public Sub OnSerialized(ByVal context As System.Runtime.Serialization.StreamingContext)
            serializing = False
        End Sub

        ''' <summary>
        ''' Called when deserializing.
        ''' </summary>
        ''' <param name="context">The <see cref="System.Runtime.Serialization.StreamingContext"/> for the serialization.</param>
        <System.Runtime.Serialization.OnDeserializing(), _
         System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)> _
        Public Sub OnDeserializing(ByVal context As System.Runtime.Serialization.StreamingContext)
            Initialize()
        End Sub
        
        ''' <summary>
        ''' Deserializes an instance of <see cref="Account"/> from XML.
        ''' </summary>
        ''' <param name="xml">The XML string representing a <see cref="Account"/> instance.</param>
        ''' <returns>An instance of <see cref="Account"/> that is deserialized from the XML string.</returns>
        Public Shared Function FromXml(ByVal xml As String) As Account
            Dim deserializer = New System.Runtime.Serialization.DataContractSerializer(GetType(Account))
            
            Using sr = New System.IO.StringReader(xml)
                Using reader = System.Xml.XmlReader.Create(sr)
                    Return TryCast(deserializer.ReadObject(reader), Account)
                End Using
            End Using
        End Function

        ''' <summary>
        ''' Deserializes an instance of <see cref="Account"/>.
        ''' </summary>
        ''' <param name="buffer">The byte array representing a <see cref="Account"/> instance.</param>
        ''' <returns>An instance of <see cref="Account"/> that is deserialized from the byte array.</returns>
        Public Shared Function FromBinary(ByVal buffer As Byte()) As Account
            Dim deserializer = New System.Runtime.Serialization.DataContractSerializer(GetType(Account))

            Using ms = New System.IO.MemoryStream(buffer)
                Using reader = System.Xml.XmlDictionaryReader.CreateBinaryReader(ms, System.Xml.XmlDictionaryReaderQuotas.Max)
                    Return TryCast(deserializer.ReadObject(reader), Account)
                End Using
            End Using
        End Function
#End Region

#Region "Clone"
        ''' <summary>
        ''' Creates a new object that is a copy of the current instance.
        ''' </summary>
        ''' <returns>
        ''' A new object that is a copy of this instance.
        ''' </returns>
        Private Function ICloneable_Clone() As Object Implements ICloneable.Clone
            Dim serializer As New System.Runtime.Serialization.DataContractSerializer([GetType]())
            Using ms As New System.IO.MemoryStream()
                serializer.WriteObject(ms, Me)
                ms.Position = 0
                Return serializer.ReadObject(ms)
            End Using
        End Function

        ''' <summary>
        ''' Creates a new object that is a copy of the current instance.
        ''' </summary>
        ''' <returns>
        ''' A new object that is a copy of this instance.
        ''' </returns>
        ''' <remarks>
        ''' This method is equivalent to a Detach from the current <see cref="System.Data.Linq.DataContext"/>.
        ''' Only loaded EntityRef and EntitySet child accessions will be cloned.
        ''' </remarks>
        Public Function Clone() As Account
            Return DirectCast(DirectCast(Me, ICloneable).Clone(), Account)
        End Function
#End Region

#Region "Detach Methods"
        ''' <summary>
        ''' Detach this instance from the <see cref="System.Data.Linq.DataContext"/>.
        ''' </summary>
        ''' <remarks>
        ''' Detaching the entity will allow it to be attached to another <see cref="System.Data.Linq.DataContext"/>.
        ''' </remarks>
        Public Overrides Sub Detach()

            If (Not IsAttached()) Then
                Return
            End If

            MyBase.Detach()
            _profile = Detach(_profile)
        End Sub
#End Region
    End Class
End Namespace
