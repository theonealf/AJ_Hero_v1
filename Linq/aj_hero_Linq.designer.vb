﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.Linq
Imports System.Data.Linq.Mapping
Imports System.Linq
Imports System.Linq.Expressions
Imports System.Reflection


<Global.System.Data.Linq.Mapping.DatabaseAttribute(Name:="dnndev.me")>  _
Partial Public Class aj_hero_LinqDataContext
	Inherits System.Data.Linq.DataContext
	
	Private Shared mappingSource As System.Data.Linq.Mapping.MappingSource = New AttributeMappingSource()
	
  #Region "Extensibility Method Definitions"
  Partial Private Sub OnCreated()
  End Sub
  Partial Private Sub Inserttbl_aj_hero_v1(instance As tbl_aj_hero_v1)
    End Sub
  Partial Private Sub Updatetbl_aj_hero_v1(instance As tbl_aj_hero_v1)
    End Sub
  Partial Private Sub Deletetbl_aj_hero_v1(instance As tbl_aj_hero_v1)
    End Sub
  #End Region
	
	Public Sub New()
		MyBase.New(Global.System.Configuration.ConfigurationManager.ConnectionStrings("dnndev_meConnectionString").ConnectionString, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As String)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As System.Data.IDbConnection)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As String, ByVal mappingSource As System.Data.Linq.Mapping.MappingSource)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As System.Data.IDbConnection, ByVal mappingSource As System.Data.Linq.Mapping.MappingSource)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public ReadOnly Property tbl_aj_hero_v1s() As System.Data.Linq.Table(Of tbl_aj_hero_v1)
		Get
			Return Me.GetTable(Of tbl_aj_hero_v1)
		End Get
	End Property
End Class

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.tbl_aj_hero_v1")>  _
Partial Public Class tbl_aj_hero_v1
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _heroid As Integer
	
	Private _ModuleId As Integer
	
	Private _Itemblock1 As String
	
	Private _Itemblock2 As String
	
	Private _CreatedOnDate As Date
	
	Private _CreatedByUserId As Integer
	
	Private _LastModifiedOnDate As Date
	
	Private _LastModifiedByUserId As Integer
	
    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnheroidChanging(value As Integer)
    End Sub
    Partial Private Sub OnheroidChanged()
    End Sub
    Partial Private Sub OnModuleIdChanging(value As Integer)
    End Sub
    Partial Private Sub OnModuleIdChanged()
    End Sub
    Partial Private Sub OnItemblock1Changing(value As String)
    End Sub
    Partial Private Sub OnItemblock1Changed()
    End Sub
    Partial Private Sub OnItemblock2Changing(value As String)
    End Sub
    Partial Private Sub OnItemblock2Changed()
    End Sub
    Partial Private Sub OnCreatedOnDateChanging(value As Date)
    End Sub
    Partial Private Sub OnCreatedOnDateChanged()
    End Sub
    Partial Private Sub OnCreatedByUserIdChanging(value As Integer)
    End Sub
    Partial Private Sub OnCreatedByUserIdChanged()
    End Sub
    Partial Private Sub OnLastModifiedOnDateChanging(value As Date)
    End Sub
    Partial Private Sub OnLastModifiedOnDateChanged()
    End Sub
    Partial Private Sub OnLastModifiedByUserIdChanging(value As Integer)
    End Sub
    Partial Private Sub OnLastModifiedByUserIdChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		OnCreated
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_heroid", AutoSync:=AutoSync.OnInsert, DbType:="Int NOT NULL IDENTITY", IsPrimaryKey:=true, IsDbGenerated:=true)>  _
	Public Property heroid() As Integer
		Get
			Return Me._heroid
		End Get
		Set
			If ((Me._heroid = value)  _
						= false) Then
				Me.OnheroidChanging(value)
				Me.SendPropertyChanging
				Me._heroid = value
				Me.SendPropertyChanged("heroid")
				Me.OnheroidChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_ModuleId", DbType:="Int NOT NULL")>  _
	Public Property ModuleId() As Integer
		Get
			Return Me._ModuleId
		End Get
		Set
			If ((Me._ModuleId = value)  _
						= false) Then
				Me.OnModuleIdChanging(value)
				Me.SendPropertyChanging
				Me._ModuleId = value
				Me.SendPropertyChanged("ModuleId")
				Me.OnModuleIdChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Itemblock1", DbType:="NVarChar(MAX) NOT NULL", CanBeNull:=false)>  _
	Public Property Itemblock1() As String
		Get
			Return Me._Itemblock1
		End Get
		Set
			If (String.Equals(Me._Itemblock1, value) = false) Then
				Me.OnItemblock1Changing(value)
				Me.SendPropertyChanging
				Me._Itemblock1 = value
				Me.SendPropertyChanged("Itemblock1")
				Me.OnItemblock1Changed
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Itemblock2", DbType:="NVarChar(MAX) NOT NULL", CanBeNull:=false)>  _
	Public Property Itemblock2() As String
		Get
			Return Me._Itemblock2
		End Get
		Set
			If (String.Equals(Me._Itemblock2, value) = false) Then
				Me.OnItemblock2Changing(value)
				Me.SendPropertyChanging
				Me._Itemblock2 = value
				Me.SendPropertyChanged("Itemblock2")
				Me.OnItemblock2Changed
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_CreatedOnDate", DbType:="DateTime NOT NULL")>  _
	Public Property CreatedOnDate() As Date
		Get
			Return Me._CreatedOnDate
		End Get
		Set
			If ((Me._CreatedOnDate = value)  _
						= false) Then
				Me.OnCreatedOnDateChanging(value)
				Me.SendPropertyChanging
				Me._CreatedOnDate = value
				Me.SendPropertyChanged("CreatedOnDate")
				Me.OnCreatedOnDateChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_CreatedByUserId", DbType:="Int NOT NULL")>  _
	Public Property CreatedByUserId() As Integer
		Get
			Return Me._CreatedByUserId
		End Get
		Set
			If ((Me._CreatedByUserId = value)  _
						= false) Then
				Me.OnCreatedByUserIdChanging(value)
				Me.SendPropertyChanging
				Me._CreatedByUserId = value
				Me.SendPropertyChanged("CreatedByUserId")
				Me.OnCreatedByUserIdChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_LastModifiedOnDate", DbType:="DateTime NOT NULL")>  _
	Public Property LastModifiedOnDate() As Date
		Get
			Return Me._LastModifiedOnDate
		End Get
		Set
			If ((Me._LastModifiedOnDate = value)  _
						= false) Then
				Me.OnLastModifiedOnDateChanging(value)
				Me.SendPropertyChanging
				Me._LastModifiedOnDate = value
				Me.SendPropertyChanged("LastModifiedOnDate")
				Me.OnLastModifiedOnDateChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_LastModifiedByUserId", DbType:="Int NOT NULL")>  _
	Public Property LastModifiedByUserId() As Integer
		Get
			Return Me._LastModifiedByUserId
		End Get
		Set
			If ((Me._LastModifiedByUserId = value)  _
						= false) Then
				Me.OnLastModifiedByUserIdChanging(value)
				Me.SendPropertyChanging
				Me._LastModifiedByUserId = value
				Me.SendPropertyChanged("LastModifiedByUserId")
				Me.OnLastModifiedByUserIdChanged
			End If
		End Set
	End Property
	
	Public Event PropertyChanging As PropertyChangingEventHandler Implements System.ComponentModel.INotifyPropertyChanging.PropertyChanging
	
	Public Event PropertyChanged As PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
	
	Protected Overridable Sub SendPropertyChanging()
		If ((Me.PropertyChangingEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
		End If
	End Sub
	
	Protected Overridable Sub SendPropertyChanged(ByVal propertyName As [String])
		If ((Me.PropertyChangedEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
		End If
	End Sub
End Class