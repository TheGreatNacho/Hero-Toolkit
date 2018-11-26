Public Class Hero
    'Basics
    Public Age As Double
    Public Eyes As String
    Public Hair As String
    Public Name As String
    Public Player As String
    Public Gender As String
    Public Height As Double
    Public Weight As Double
    Public Identity As String
    Public PowerLevel As Integer
    Public Secret As Boolean = False
    Public GroupAffiliation As String
    Public BaseOfOpperations As String

    'Abilitiees
    Public Strength As Integer
    Public Agility As Integer
    Public Fighting As Integer
    Public Awareness As Integer
    Public Stamina As Integer
    Public Dexterity As Integer
    Public Intelect As Integer
    Public Presence As Integer

    'Defence
    Public Dodge As Integer
    Public Parry As Integer
    Public Fortitude As Integer
    Public Toughness As Integer
    Public Will As Integer

    Public Powers As New List(Of Power)
End Class
