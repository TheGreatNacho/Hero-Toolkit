Imports System.Xml
Public Class Main

    Public powers As New List(Of Power)
    Private Sub LoadPowers()
        Dim powerXML As XDocument = XDocument.Load(Application.StartupPath & "\Powers.xml")
        For Each power In From element In powerXML.<Powers>.<Power>
            Dim LoadPower As New Power
            LoadPower.Name = power.<Name>.Value
            LoadPower.SetType(power.<Type>.Value)
            LoadPower.SetAction(power.<Action>.Value)
            LoadPower.SetRange(power.<Range>.Value)
            LoadPower.SetDuration(power.<Duration>.Value)

            powers.Add(LoadPower)
        Next
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub AddPower_Click(sender As Object, e As EventArgs) Handles AddPower.Click
        'AddPower.Location = New Point(AddPower.Location.X, AddPower.Location.Y + 30)
        SelectPowerWindow.Show()
    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadPowers()
    End Sub
End Class
