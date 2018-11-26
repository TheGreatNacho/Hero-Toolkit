Public Class Power
    Public Enum PowerType
        Attack
        Movement
        Sensory
        Control
        Defense
        General
        Other
    End Enum
    Public Enum Action
        Standard
        Free
        None
        Reaction
        Move
        Other
    End Enum
    Public Enum Range
        Close
        Ranged
        Personal
        Rank
        Perception
        Other
    End Enum
    Public Enum Duration
        Instant
        Sustained
        Permanent
        Other
    End Enum

    Public Name As String
    Private Type As PowerType
    Private PowerAction As Action
    Private PowerRange As Range
    Private PowerDuration As Duration
    Public Description As String
    Public Cost As Integer
    Public Ranks As Integer

    Public ResistFort As Boolean = False
    Public ResistWill As Boolean = False
    Public ResistToughness As Boolean = False
    Public ResistAwareness As Boolean = False
    Public RankedResistance As Boolean = False


    Public Sub SetAction(ByVal str As String)
        Try
            PowerAction = DirectCast([Enum].Parse(GetType(Action), str), Action)
        Catch ex As Exception
            PowerAction = Action.Other
        End Try

    End Sub

    Public Sub SetType(ByVal str As String)
        Try
            Type = DirectCast([Enum].Parse(GetType(PowerType), str), PowerType)
        Catch ex As Exception
            Type = PowerType.Other
        End Try

    End Sub

    Public Sub SetRange(ByVal str As String)
        Try
            PowerRange = DirectCast([Enum].Parse(GetType(Range), str), Range)
        Catch ex As Exception
            PowerRange = Range.Other
        End Try

    End Sub

    Public Sub SetDuration(ByVal str As String)
        Try
            PowerDuration = DirectCast([Enum].Parse(GetType(Duration), str), Duration)
        Catch ex As Exception
            PowerDuration = Duration.Other
        End Try
    End Sub

End Class
