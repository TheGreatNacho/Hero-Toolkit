Public Class SelectPowerWindow

    Private Sub PopulatePowerlist(ByVal SearchTerm As String)
        PowerList.Items.Clear()
        For Each power In Main.powers
            If (power.Name.ToLower().Contains(SearchTerm.ToLower())) Then
                PowerList.Items.Add(power.Name)
            End If
        Next
    End Sub

    Private Sub SearchPower_TextChanged(sender As Object, e As EventArgs) Handles SearchPower.TextChanged
        PopulatePowerlist(SearchPower.Text)
    End Sub

    Private Sub SelectPowerWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PopulatePowerlist("")
    End Sub
End Class