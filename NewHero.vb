Public Class NewHero
    Private Sub NewHero_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HeroType.SetSelected(0, 1)
        HeroAutomation.SetSelected(2, 1)
    End Sub

    Private Sub CloseBtn_Click(sender As Object, e As EventArgs) Handles CloseBtn.Click
        Me.Hide()
    End Sub

    Private Sub HeroType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles HeroType.SelectedIndexChanged
        If HeroType.SelectedIndex = 0 Then
            NPCPanel.Visible = False
            PCPanel.Visible = True
        ElseIf HeroType.SelectedIndex = 1 Then
            NPCPanel.Visible = True
            PCPanel.Visible = False
        End If


    End Sub

    Private Sub PowerLevel_ValueChanged(sender As Object, e As EventArgs) Handles PowerLevel.ValueChanged
        StartingPP.Text = PPPerLevel.Value * PowerLevel.Value
    End Sub

    Private Sub PPPerLevel_ValueChanged(sender As Object, e As EventArgs) Handles PPPerLevel.ValueChanged
        StartingPP.Text = PPPerLevel.Value * PowerLevel.Value
    End Sub

    Private Sub OkayBtn_Click(sender As Object, e As EventArgs) Handles OkayBtn.Click
        Main.WorkingHero = New Hero
        Main.WorkingHero.Name = NewHeroName.Text
        Main.WorkingHero.Player = PlayerName.Text
        If (HeroType.SelectedIndex = 0) Then
            Main.WorkingHero.NPC = False
            Main.WorkingHero.PowerLevel = PowerLevel.Value
            Main.WorkingHero.PowerPoints = CDbl(StartingPP.Text)
        Else
            Main.WorkingHero.NPC = True
        End If

        Select Case HeroType.SelectedIndex
            Case 0
                Main.WorkingHero.Type = Hero.HeroType.Automation
            Case 1
                Main.WorkingHero.Type = Hero.HeroType.Immobile
            Case 2
                Main.WorkingHero.Type = Hero.HeroType.Normal
        End Select

        Main.RefreshWorkingHero()
        Main.WorkingHero.UpdatePoints()
        Me.Close()
    End Sub
End Class