Imports System.Xml
Imports System.IO

Public Class Main
    Public WorkingHero As New Hero
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
        Dim SelectPowerForm As New SelectPowerWindow
        SelectPowerForm.Show()
    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadPowers()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Dim NewHeroForm As New NewHero
        BootTool.Visible = False
        NewHeroForm.Show()
    End Sub

    Private Sub FromScratchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FromScratchToolStripMenuItem.Click
        Dim NewHeroForm As New NewHero
        BootTool.Visible = False
        NewHeroForm.Show()
    End Sub

    Private Sub StrengthNumBox_ValueChanged(sender As Object, e As EventArgs) Handles StrengthNumBox.ValueChanged
        WorkingHero.StrengthRanks = StrengthNumBox.Value
        WorkingHero.UpdatePoints()
    End Sub

    Private Sub AgilityNumBox_ValueChanged(sender As Object, e As EventArgs) Handles AgilityNumBox.ValueChanged
        WorkingHero.AgilityRanks = AgilityNumBox.Value
        WorkingHero.UpdatePoints()
    End Sub

    Private Sub FightingNumBox_ValueChanged(sender As Object, e As EventArgs) Handles FightingNumBox.ValueChanged
        WorkingHero.FightingRanks = FightingNumBox.Value
        WorkingHero.UpdatePoints()
    End Sub

    Private Sub AwarenessNumBox_ValueChanged(sender As Object, e As EventArgs) Handles AwarenessNumBox.ValueChanged
        WorkingHero.AwarenessRanks = AwarenessNumBox.Value
        WorkingHero.UpdatePoints()
    End Sub

    Private Sub StaminaNumBox_ValueChanged(sender As Object, e As EventArgs) Handles StaminaNumBox.ValueChanged
        WorkingHero.StaminaRanks = StaminaNumBox.Value
        WorkingHero.UpdatePoints()
    End Sub

    Private Sub DexterityNumBox_ValueChanged(sender As Object, e As EventArgs) Handles DexterityNumBox.ValueChanged
        WorkingHero.DexterityRanks = DexterityNumBox.Value
        WorkingHero.UpdatePoints()
    End Sub

    Private Sub IntellectNumBox_ValueChanged(sender As Object, e As EventArgs) Handles IntellectNumBox.ValueChanged
        WorkingHero.IntellectRanks = IntellectNumBox.Value
        WorkingHero.UpdatePoints()
    End Sub

    Private Sub PresencesNumBox_ValueChanged(sender As Object, e As EventArgs) Handles PresenceNumBox.ValueChanged
        WorkingHero.PresenceRanks = PresenceNumBox.Value
        WorkingHero.UpdatePoints()
    End Sub

    Private Sub DodgeNumberBox_ValueChanged(sender As Object, e As EventArgs) Handles DodgeNumberBox.ValueChanged
        WorkingHero.DodgeRanks = DodgeNumberBox.Value
        WorkingHero.UpdatePoints()
    End Sub

    Private Sub ParryNumberBox_ValueChanged(sender As Object, e As EventArgs) Handles ParryNumberBox.ValueChanged
        WorkingHero.ParryRanks = ParryNumberBox.Value
        WorkingHero.UpdatePoints()
    End Sub

    Private Sub FortitudeNumberBox_ValueChanged(sender As Object, e As EventArgs) Handles FortitudeNumberBox.ValueChanged
        WorkingHero.FortitudeRanks = FortitudeNumberBox.Value
        WorkingHero.UpdatePoints()
    End Sub

    Private Sub ToughnessNumberBox_ValueChanged(sender As Object, e As EventArgs) Handles ToughnessNumberBox.ValueChanged
        WorkingHero.ToughnessRanks = ToughnessNumberBox.Value
        WorkingHero.UpdatePoints()
    End Sub

    Private Sub WillNumberBox_ValueChanged(sender As Object, e As EventArgs) Handles WillNumberBox.ValueChanged
        WorkingHero.WillRanks = WillNumberBox.Value
        WorkingHero.UpdatePoints()
    End Sub
    Private Sub AcroNumBox_ValueChanged(sender As Object, e As EventArgs) Handles AcroNumBox.ValueChanged
        WorkingHero.AcrobaticsRanks = AcroNumBox.Value
        WorkingHero.UpdatePoints()
    End Sub

    Private Sub AthNumBox_ValueChanged(sender As Object, e As EventArgs) Handles AthNumBox.ValueChanged
        WorkingHero.AthleticsRanks = AthNumBox.Value
        WorkingHero.UpdatePoints()
    End Sub

    Private Sub CCmb1NumBox_ValueChanged(sender As Object, e As EventArgs) Handles CCmb1NumBox.ValueChanged
        WorkingHero.CloseCombat1Ranks = CCmb1NumBox.Value
        WorkingHero.UpdatePoints()
    End Sub

    Private Sub CCmb2NumBox_ValueChanged(sender As Object, e As EventArgs) Handles CCmb2NumBox.ValueChanged
        WorkingHero.CloseCombat2Ranks = CCmb2NumBox.Value
        WorkingHero.UpdatePoints()
    End Sub

    Private Sub CCmb3NumBox_ValueChanged(sender As Object, e As EventArgs) Handles CCmb3NumBox.ValueChanged
        WorkingHero.CloseCombat3Ranks = CCmb3NumBox.Value
        WorkingHero.UpdatePoints()
    End Sub

    Private Sub DecNumBox_ValueChanged(sender As Object, e As EventArgs) Handles DecNumBox.ValueChanged
        WorkingHero.DeceptionRanks = DecNumBox.Value
        WorkingHero.UpdatePoints()
    End Sub

    Private Sub Exp1NumBox_ValueChanged(sender As Object, e As EventArgs) Handles Exp1NumBox.ValueChanged
        WorkingHero.Expertise1Ranks = Exp1NumBox.Value
        WorkingHero.UpdatePoints()
    End Sub

    Private Sub Exp2NumBox_ValueChanged(sender As Object, e As EventArgs) Handles Exp2NumBox.ValueChanged
        WorkingHero.Expertise2Ranks = Exp2NumBox.Value
        WorkingHero.UpdatePoints()
    End Sub

    Private Sub Exp3NumBox_ValueChanged(sender As Object, e As EventArgs) Handles Exp3NumBox.ValueChanged
        WorkingHero.Expertise3Ranks = Exp3NumBox.Value
        WorkingHero.UpdatePoints()
    End Sub

    Private Sub Exp4NumBox_ValueChanged(sender As Object, e As EventArgs) Handles Exp4NumBox.ValueChanged
        WorkingHero.Expertise4Ranks = Exp4NumBox.Value
        WorkingHero.UpdatePoints()
    End Sub

    Private Sub InsNumBox_ValueChanged(sender As Object, e As EventArgs) Handles InsNumBox.ValueChanged
        WorkingHero.InsightRanks = InsNumBox.Value
        WorkingHero.UpdatePoints()
    End Sub

    Private Sub IntiNumBox_ValueChanged(sender As Object, e As EventArgs) Handles IntiNumBox.ValueChanged
        WorkingHero.IntimidationRanks = IntiNumBox.Value
        WorkingHero.UpdatePoints()
    End Sub

    Private Sub InvNumBox_ValueChanged(sender As Object, e As EventArgs) Handles InvNumBox.ValueChanged
        WorkingHero.InvestigationRanks = InvNumBox.Value
        WorkingHero.UpdatePoints()
    End Sub

    Private Sub PercNumBox_ValueChanged(sender As Object, e As EventArgs) Handles PercNumBox.ValueChanged
        WorkingHero.PerceptionRanks = PercNumBox.Value
        WorkingHero.UpdatePoints()
    End Sub

    Private Sub PersNumBox_ValueChanged(sender As Object, e As EventArgs) Handles PersNumBox.ValueChanged
        WorkingHero.PersuasionRanks = PersNumBox.Value
        WorkingHero.UpdatePoints()
    End Sub

    Private Sub RCmb1NumBox_ValueChanged(sender As Object, e As EventArgs) Handles RCmb1NumBox.ValueChanged
        WorkingHero.RangedCombat1Ranks = RCmb1NumBox.Value
        WorkingHero.UpdatePoints()
    End Sub

    Private Sub RCmb2NumBox_ValueChanged(sender As Object, e As EventArgs) Handles RCmb2NumBox.ValueChanged
        WorkingHero.RangedCombat2Ranks = RCmb2NumBox.Value
        WorkingHero.UpdatePoints()
    End Sub

    Private Sub RCmb3NumBox_ValueChanged(sender As Object, e As EventArgs) Handles RCmb3NumBox.ValueChanged
        WorkingHero.RangedCombat3Ranks = RCmb3NumBox.Value
        WorkingHero.UpdatePoints()
    End Sub

    Private Sub SoHNumBox_ValueChanged(sender As Object, e As EventArgs) Handles SoHNumBox.ValueChanged
        WorkingHero.SlightOfHandRanks = SoHNumBox.Value
        WorkingHero.UpdatePoints()
    End Sub

    Private Sub SteNumBox_ValueChanged(sender As Object, e As EventArgs) Handles SteNumBox.ValueChanged
        WorkingHero.StealthRanks = SteNumBox.Value
        WorkingHero.UpdatePoints()
    End Sub

    Private Sub TechNumBox_ValueChanged(sender As Object, e As EventArgs) Handles TechNumBox.ValueChanged
        WorkingHero.TechnologyRanks = TechNumBox.Value
        WorkingHero.UpdatePoints()
    End Sub

    Private Sub TreNumBox_ValueChanged(sender As Object, e As EventArgs) Handles TreNumBox.ValueChanged
        WorkingHero.TreatmentRanks = TreNumBox.Value
        WorkingHero.UpdatePoints()
    End Sub

    Private Sub VehNumBox_ValueChanged(sender As Object, e As EventArgs) Handles VehNumBox.ValueChanged
        WorkingHero.VehicleRanks = VehNumBox.Value
        WorkingHero.UpdatePoints()
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        If (SaveHeroDialog.FileName.Length > 0) Then
            WorkingHero.SaveHero(SaveHeroDialog.FileName)
        Else
            SaveHeroDialog.Filter = "Hero File|*.hero"
            SaveHeroDialog.Title = "Save Hero"
            SaveHeroDialog.ShowDialog()
        End If
    End Sub

    Private Sub SaveHeroDialog_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles SaveHeroDialog.FileOk
        WorkingHero.SaveHero(SaveHeroDialog.FileName)
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        OpenHeroDialog.Filter = "Hero File|*.hero"
        OpenHeroDialog.Title = "Open Hero"
        OpenHeroDialog.ShowDialog()
    End Sub

    Private Sub OpenHeroDialog_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenHeroDialog.FileOk
        WorkingHero.LoadHero(OpenHeroDialog.FileName)
        TabPanel.Enabled = True
    End Sub

    Private Sub HeroNameTextBox_TextChanged(sender As Object, e As EventArgs) Handles HeroNameTextBox.TextChanged
        WorkingHero.Name = HeroNameTextBox.Text
    End Sub

    Private Sub PlayerNameTextBox_TextChanged(sender As Object, e As EventArgs) Handles PlayerNameTextBox.TextChanged
        WorkingHero.Player = PlayerNameTextBox.Text
    End Sub

    Private Sub IdentityTextBox_TextChanged(sender As Object, e As EventArgs) Handles IdentityTextBox.TextChanged
        WorkingHero.Identity = IdentityTextBox.Text
    End Sub

    Private Sub GenderTextBox_TextChanged(sender As Object, e As EventArgs) Handles GenderTextBox.TextChanged
        WorkingHero.Gender = GenderTextBox.Text
    End Sub

    Private Sub SecretIdentityChkBox_CheckedChanged(sender As Object, e As EventArgs) Handles SecretIdentityChkBox.CheckedChanged
        WorkingHero.Secret = SecretIdentityChkBox.Checked
    End Sub

    Private Sub AgeTextBox_TextChanged(sender As Object, e As EventArgs) Handles AgeTextBox.TextChanged
        WorkingHero.Age = AgeTextBox.Text
    End Sub

    Private Sub HeightTextBox_TextChanged(sender As Object, e As EventArgs) Handles HeightTextBox.TextChanged
        WorkingHero.Height = HeightTextBox.Text
    End Sub

    Private Sub WeightTextBox_TextChanged(sender As Object, e As EventArgs) Handles WeightTextBox.TextChanged
        WorkingHero.Weight = WeightTextBox.Text
    End Sub

    Private Sub EyesTextBox_TextChanged(sender As Object, e As EventArgs) Handles EyesTextBox.TextChanged
        WorkingHero.Eyes = EyesTextBox.Text
    End Sub

    Private Sub HairTextBox_TextChanged(sender As Object, e As EventArgs) Handles HairTextBox.TextChanged
        WorkingHero.Hair = HairTextBox.Text
    End Sub

    Private Sub GroupAffiliationsTextBox_TextChanged(sender As Object, e As EventArgs) Handles GroupAffiliationsTextBox.TextChanged
        WorkingHero.GroupAffiliation = GroupAffiliationsTextBox.Text
    End Sub

    Private Sub BOOTextBox_TextChanged(sender As Object, e As EventArgs) Handles BOOTextBox.TextChanged
        WorkingHero.BaseOfOpperations = BOOTextBox.Text
    End Sub

    Private Sub CloseCombat1_TextChanged(sender As Object, e As EventArgs) Handles CloseCombat1.TextChanged
        WorkingHero.CloseCombat1Name = CloseCombat1.Text
    End Sub

    Private Sub CloseCombat2_TextChanged(sender As Object, e As EventArgs) Handles CloseCombat2.TextChanged
        WorkingHero.CloseCombat2Name = CloseCombat2.Text
    End Sub

    Private Sub CloseCombat3_TextChanged(sender As Object, e As EventArgs) Handles CloseCombat3.TextChanged
        WorkingHero.CloseCombat3Name = CloseCombat3.Text
    End Sub

    Private Sub Expertise1_TextChanged(sender As Object, e As EventArgs) Handles Expertise1.TextChanged
        WorkingHero.Expertise1Name = Expertise1.Text
    End Sub

    Private Sub Expertise2_TextChanged(sender As Object, e As EventArgs) Handles Expertise2.TextChanged
        WorkingHero.Expertise2Name = Expertise2.Text
    End Sub

    Private Sub Expertise3_TextChanged(sender As Object, e As EventArgs) Handles Expertise3.TextChanged
        WorkingHero.Expertise2Name = Expertise3.Text
    End Sub

    Private Sub Expertise4_TextChanged(sender As Object, e As EventArgs) Handles Expertise4.TextChanged
        WorkingHero.Expertise2Name = Expertise4.Text
    End Sub

    Private Sub RangedCombat1_TextChanged(sender As Object, e As EventArgs) Handles RangedCombat1.TextChanged
        WorkingHero.RangedCombat1Name = RangedCombat1.Text
    End Sub

    Private Sub RangedCombat2_TextChanged(sender As Object, e As EventArgs) Handles RangedCombat2.TextChanged
        WorkingHero.RangedCombat2Name = RangedCombat2.Text
    End Sub

    Private Sub RangedCombat3_TextChanged(sender As Object, e As EventArgs) Handles RangedCombat3.TextChanged
        WorkingHero.RangedCombat3Name = RangedCombat3.Text
    End Sub
End Class
