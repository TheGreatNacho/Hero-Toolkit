Imports System.Xml
Imports System.IO

Public Class Main
    Public WorkingHero As New Hero
    Public powers As New List(Of Power)

    Public Sub RefreshWorkingHero()
        'Loading all the data from WorkingHero
        HeroNameTextBox.Text = WorkingHero.Name
        PlayerNameTextBox.Text = WorkingHero.Player
        IdentityTextBox.Text = WorkingHero.Identity
        GenderTextBox.Text = WorkingHero.Gender
        SecretIdentityChkBox.Checked = WorkingHero.Secret
        AgeTextBox.Text = WorkingHero.Age
        HeightTextBox.Text = WorkingHero.Height
        WeightTextBox.Text = WorkingHero.Weight
        EyesTextBox.Text = WorkingHero.Eyes
        HairTextBox.Text = WorkingHero.Hair
        GroupAffiliationsTextBox.Text = WorkingHero.GroupAffiliation
        BOOTextBox.Text = WorkingHero.BaseOfOpperations

        'A hero was loaded/created, so give access to stuff
        TabPanel.Enabled = True
        AbilitiesToolLabel.Visible = True
        PowersToolLabel.Visible = True
        AdvantagesToolLabel.Visible = True
        SkillsToolLabel.Visible = True
        DefencesToolLabel.Visible = True
        TotalToolLabel.Visible = True
    End Sub
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
        SaveHeroDialog.Filter = "Hero File|*.hero"
        SaveHeroDialog.Title = "Save Hero"
        SaveHeroDialog.ShowDialog()
    End Sub

    Private Sub SaveHeroDialog_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles SaveHeroDialog.FileOk
        Dim fs As New FileStream(SaveHeroDialog.FileName, FileMode.OpenOrCreate)
        Dim bw As New BinaryWriter(fs)

        bw.Write(WorkingHero.Age)
        bw.Write(WorkingHero.NPC)
        bw.Write(WorkingHero.Eyes)
        bw.Write(WorkingHero.Hair)
        bw.Write(WorkingHero.Name)
        'bw.Write(WorkingHero.Type)
        bw.Write(WorkingHero.Player)
        bw.Write(WorkingHero.Gender)
        bw.Write(WorkingHero.Height)
        bw.Write(WorkingHero.Weight)
        bw.Write(WorkingHero.Identity)
        bw.Write(WorkingHero.Secret)
        bw.Write(WorkingHero.GroupAffiliation)
        bw.Write(WorkingHero.BaseOfOpperations)

        'Power Points
        bw.Write(WorkingHero.PowerLevel)
        bw.Write(WorkingHero.PowerPoints)
        bw.Write(WorkingHero.PowerPointPerLevel)
        bw.Write(WorkingHero.AbilityRanks)
        bw.Write(WorkingHero.PowerRanks)
        bw.Write(WorkingHero.SkillRanks)
        bw.Write(WorkingHero.AdvantageRanks)
        bw.Write(WorkingHero.DefenceRanks)
        bw.Write(WorkingHero.TotalPowerPoints)

        'Abilitiees
        bw.Write(WorkingHero.StrengthRanks)
        bw.Write(WorkingHero.StrengthMisc)
        bw.Write(WorkingHero.AgilityRanks)
        bw.Write(WorkingHero.AgilityMisc)
        bw.Write(WorkingHero.FightingRanks)
        bw.Write(WorkingHero.FightingMisc)
        bw.Write(WorkingHero.AwarenessRanks)
        bw.Write(WorkingHero.AwarenessMisc)
        bw.Write(WorkingHero.StaminaRanks)
        bw.Write(WorkingHero.StaminaMisc)
        bw.Write(WorkingHero.DexterityRanks)
        bw.Write(WorkingHero.DexterityMisc)
        bw.Write(WorkingHero.IntellectRanks)
        bw.Write(WorkingHero.IntellectMisc)
        bw.Write(WorkingHero.PresenceRanks)
        bw.Write(WorkingHero.PresenceMisc)

        'Defence
        bw.Write(WorkingHero.DodgeRanks)
        bw.Write(WorkingHero.DodgeMisc)
        bw.Write(WorkingHero.ParryRanks)
        bw.Write(WorkingHero.ParryMisc)
        bw.Write(WorkingHero.FortitudeRanks)
        bw.Write(WorkingHero.FortitudeMisc)
        bw.Write(WorkingHero.ToughnessRanks)
        bw.Write(WorkingHero.ToughnessMisc)
        bw.Write(WorkingHero.WillRanks)
        bw.Write(WorkingHero.WillMisc)

        'Skills
        bw.Write(WorkingHero.AcrobaticsRanks)
        bw.Write(WorkingHero.AthleticsRanks)
        bw.Write(WorkingHero.CloseCombat1Ranks)
        bw.Write(WorkingHero.CloseCombat2Ranks)
        bw.Write(WorkingHero.CloseCombat3Ranks)
        bw.Write(WorkingHero.DeceptionRanks)
        bw.Write(WorkingHero.Expertise1Ranks)
        bw.Write(WorkingHero.Expertise2Ranks)
        bw.Write(WorkingHero.Expertise3Ranks)
        bw.Write(WorkingHero.Expertise4Ranks)
        bw.Write(WorkingHero.InsightRanks)
        bw.Write(WorkingHero.IntimidationRanks)
        bw.Write(WorkingHero.InvestigationRanks)
        bw.Write(WorkingHero.PerceptionRanks)
        bw.Write(WorkingHero.PersuasionRanks)
        bw.Write(WorkingHero.RangedCombat1Ranks)
        bw.Write(WorkingHero.RangedCombat2Ranks)
        bw.Write(WorkingHero.RangedCombat3Ranks)
        bw.Write(WorkingHero.SlightOfHandRanks)
        bw.Write(WorkingHero.StealthRanks)
        bw.Write(WorkingHero.TechnologyRanks)
        bw.Write(WorkingHero.TreatmentRanks)
        bw.Write(WorkingHero.VehicleRanks)
        bw.Write(WorkingHero.AcrobaticsMisc)
        bw.Write(WorkingHero.AthleticsMisc)
        bw.Write(WorkingHero.CloseCombat1Misc)
        bw.Write(WorkingHero.CloseCombat2Misc)
        bw.Write(WorkingHero.CloseCombat3Misc)
        bw.Write(WorkingHero.DeceptionMisc)
        bw.Write(WorkingHero.Expertise1Misc)
        bw.Write(WorkingHero.Expertise2Misc)
        bw.Write(WorkingHero.Expertise3Misc)
        bw.Write(WorkingHero.Expertise4Misc)
        bw.Write(WorkingHero.InsightMisc)
        bw.Write(WorkingHero.IntimidationMisc)
        bw.Write(WorkingHero.InvestigationMisc)
        bw.Write(WorkingHero.PerceptionMisc)
        bw.Write(WorkingHero.PersuasionMisc)
        bw.Write(WorkingHero.RangedCombat1Misc)
        bw.Write(WorkingHero.RangedCombat2Misc)
        bw.Write(WorkingHero.RangedCombat3Misc)
        bw.Write(WorkingHero.SlightOfHandMisc)
        bw.Write(WorkingHero.StealthMisc)
        bw.Write(WorkingHero.TechnologyMisc)
        bw.Write(WorkingHero.TreatmentMisc)
        bw.Write(WorkingHero.VehicleMisc)

        bw.Close()
        fs.Close()
    End Sub
End Class
