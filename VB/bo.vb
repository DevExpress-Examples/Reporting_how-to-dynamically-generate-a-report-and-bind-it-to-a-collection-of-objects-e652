Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic

Namespace K18078
	Public Class MyComplexObject
		Private age_Renamed As Integer

		<Reportable(LenFactor := 1)> _
		Public Property Age() As Integer
			Get
				Return age_Renamed
			End Get
			Set(ByVal value As Integer)
				age_Renamed = value
			End Set
		End Property
		Private firstName_Renamed As String
		'[Reportable(LenFactor = 2)]
		Public Property FirstName() As String
			Get
				Return firstName_Renamed
			End Get
			Set(ByVal value As String)
				firstName_Renamed = value
			End Set
		End Property
		Private lastName_Renamed As String
		'[Reportable(LenFactor = 2,AlternateName = "Surname")]
		Public Property LastName() As String
			Get
				Return lastName_Renamed
			End Get
			Set(ByVal value As String)
				lastName_Renamed = value
			End Set
		End Property

		<Reportable(LenFactor := 3, AlternateName := "Full name")> _
		Public ReadOnly Property Name() As String
			Get
				Return firstName_Renamed & " " & lastName_Renamed
			End Get
		End Property
		Private address_Renamed As String

		<Reportable(LenFactor := 3)> _
		Public Property Address() As String
			Get
				Return address_Renamed
			End Get
			Set(ByVal value As String)
				address_Renamed = value
			End Set
		End Property
		Private city_Renamed As String

		<Reportable(LenFactor := 1)> _
		Public Property City() As String
			Get
				Return city_Renamed
			End Get
			Set(ByVal value As String)
				city_Renamed = value
			End Set
		End Property
		Private federalId_Renamed As String

		<Reportable(AlternateName := "Social Security Number", LenFactor := 3)> _
		Public Property FederalId() As String
			Get
				Return federalId_Renamed
			End Get
			Set(ByVal value As String)
				federalId_Renamed = value
			End Set
		End Property
		Private salary_Renamed As Double

		Public Property Salary() As Double
			Get
				Return salary_Renamed
			End Get
			Set(ByVal value As Double)
				salary_Renamed = value
			End Set
		End Property
	End Class
	<AttributeUsage(AttributeTargets.All, AllowMultiple := True)> _
	Public Class Reportable
		Inherits Attribute
		Private altName As String
		Public Property AlternateName() As String
			Get
				Return Me.altName
			End Get
			Set(ByVal value As String)
				Me.altName = value
			End Set
		End Property
		Private lenFactor_Renamed As Integer
		Public Property LenFactor() As Integer
			Get
				Return Me.lenFactor_Renamed
			End Get
			Set(ByVal value As Integer)
				Me.lenFactor_Renamed = value
			End Set
		End Property
	End Class
End Namespace
