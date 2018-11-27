Imports System.Xml
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
        StrLbl.Text = CStr(WorkingHero.GetStrength())
        WorkingHero.UpdatePoints()
    End Sub

    Private Sub AgilityNumBox_ValueChanged(sender As Object, e As EventArgs) Handles AgilityNumBox.ValueChanged
        WorkingHero.AgilityRanks = AgilityNumBox.Value
        AgiLbl.Text = CStr(WorkingHero.GetAgility())
        DodgeLbl.Text = CStr(WorkingHero.GetDodge())
        WorkingHero.UpdatePoints()
    End Sub

    Private Sub FightingNumBox_ValueChanged(sender As Object, e As EventArgs) Handles FightingNumBox.ValueChanged
        WorkingHero.FightingRanks = FightingNumBox.Value
        FgtLbl.Text = CStr(WorkingHero.GetFighting())
        ParryLbl.Text = CStr(WorkingHero.GetParry())
        WorkingHero.UpdatePoints()
    End Sub

    Private Sub AwarenessNumBox_ValueChanged(sender As Object, e As EventArgs) Handles AwarenessNumBox.ValueChanged
        WorkingHero.AwarenessRanks = AwarenessNumBox.Value
        AweLbl.Text = CStr(WorkingHero.GetAwareness())
        WillLbl.Text = CStr(WorkingHero.GetWill())
        WorkingHero.UpdatePoints()
    End Sub

    Private Sub StaminaNumBox_ValueChanged(sender As Object, e As EventArgs) Handles StaminaNumBox.ValueChanged
        WorkingHero.StaminaRanks = StaminaNumBox.Value
        StaLbl.Text = CStr(WorkingHero.GetStamina())
        FortitudeLbl.Text = CStr(WorkingHero.GetFortitude())
        ToughnessLbl.Text = CStr(WorkingHero.GetToughness())
        WorkingHero.UpdatePoints()
    End Sub

    Private Sub DexterityNumBox_ValueChanged(sender As Object, e As EventArgs) Handles DexterityNumBox.ValueChanged
        WorkingHero.DexterityRanks = DexterityNumBox.Value
        DexLbl.Text = CStr(WorkingHero.GetDexterity())
        WorkingHero.UpdatePoints()
    End Sub

    Private Sub IntellectNumBox_ValueChanged(sender As Object, e As EventArgs) Handles IntellectNumBox.ValueChanged
        WorkingHero.IntellectRanks = IntellectNumBox.Value
        IntLbl.Text = CStr(WorkingHero.GetIntellect())
        WorkingHero.UpdatePoints()
    End Sub

    Private Sub PresencesNumBox_ValueChanged(sender As Object, e As EventArgs) Handles PresencesNumBox.ValueChanged
        WorkingHero.PresenceRanks = PresencesNumBox.Value
        PreLbl.Text = CStr(WorkingHero.GetPresence())
        WorkingHero.UpdatePoints()
    End Sub

    Private Sub DodgeNumberBox_ValueChanged(sender As Object, e As EventArgs) Handles DodgeNumberBox.ValueChanged
        WorkingHero.DodgeRanks = DodgeNumberBox.Value
        DodgeLbl.Text = CStr(WorkingHero.GetDodge())
        WorkingHero.UpdatePoints()
    End Sub

    Private Sub ParryNumberBox_ValueChanged(sender As Object, e As EventArgs) Handles ParryNumberBox.ValueChanged
        WorkingHero.ParryRanks = ParryNumberBox.Value
        ParryLbl.Text = CStr(WorkingHero.GetParry())
        WorkingHero.UpdatePoints()
    End Sub

    Private Sub FortitudeNumberBox_ValueChanged(sender As Object, e As EventArgs) Handles FortitudeNumberBox.ValueChanged
        WorkingHero.FortitudeRanks = FortitudeNumberBox.Value
        FortitudeLbl.Text = CStr(WorkingHero.GetFortitude())
        WorkingHero.UpdatePoints()
    End Sub

    Private Sub ToughnessNumberBox_ValueChanged(sender As Object, e As EventArgs) Handles ToughnessNumberBox.ValueChanged
        WorkingHero.ToughnessRanks = ToughnessNumberBox.Value
        ToughnessLbl.Text = CStr(WorkingHero.GetToughness())
        WorkingHero.UpdatePoints()
    End Sub

    Private Sub WillNumberBox_ValueChanged(sender As Object, e As EventArgs) Handles WillNumberBox.ValueChanged
        WorkingHero.WillRanks = WillNumberBox.Value
        WillLbl.Text = CStr(WorkingHero.GetWill())
        WorkingHero.UpdatePoints()
    End Sub
    Private Sub AcroNumBox_ValueChanged(sender As Object, e As EventArgs) Handles AcroNumBox.ValueChanged
        WorkingHero.AcrobaticsRanks = WillNumberBox.Value
        AcrLbl.Text = CStr(WorkingHero.GetAcrobatics())
        WorkingHero.UpdatePoints()
    End Sub

    Private Sub AthNumBox_ValueChanged(sender As Object, e As EventArgs) Handles AthNumBox.ValueChanged
        WorkingHero.AthleticsRanks = AthNumBox.Value
        AthLbl.Text = CStr(WorkingHero.GetAthletics())
        WorkingHero.UpdatePoints()
    End Sub

    Private Sub CCmb1NumBox_ValueChanged(sender As Object, e As EventArgs) Handles CCmb1NumBox.ValueChanged
        WorkingHero.CloseCombat1Ranks = CCmb1NumBox.Value
        CCmb1Lbl.Text = CStr(WorkingHero.GetCloseCombat1())
        WorkingHero.UpdatePoints()
    End Sub

    Private Sub CCmb2NumBox_ValueChanged(sender As Object, e As EventArgs) Handles CCmb2NumBox.ValueChanged
        WorkingHero.CloseCombat2Ranks = CCmb2NumBox.Value
        CCmb2Lbl.Text = CStr(WorkingHero.GetCloseCombat2())
        WorkingHero.UpdatePoints()
    End Sub

    Private Sub CCmb3NumBox_ValueChanged(sender As Object, e As EventArgs) Handles CCmb3NumBox.ValueChanged
        WorkingHero.CloseCombat3Ranks = CCmb3NumBox.Value
        CCmb3Lbl.Text = CStr(WorkingHero.GetCloseCombat3())
        WorkingHero.UpdatePoints()
    End Sub

    Private Sub DecNumBox_ValueChanged(sender As Object, e As EventArgs) Handles DecNumBox.ValueChanged
        WorkingHero.DeceptionRanks = DecNumBox.Value
        DecLbl.Text = CStr(WorkingHero.GetDeception())
        WorkingHero.UpdatePoints()
    End Sub

    Private Sub Exp1NumBox_ValueChanged(sender As Object, e As EventArgs) Handles Exp1NumBox.ValueChanged
        WorkingHero.Expertise1Ranks = Exp1NumBox.Value
        Exp1Lbl.Text = CStr(WorkingHero.GetExpertise1())
        WorkingHero.UpdatePoints()
    End Sub

    Private Sub Exp2NumBox_ValueChanged(sender As Object, e As EventArgs) Handles Exp2NumBox.ValueChanged
        WorkingHero.Expertise2Ranks = Exp2NumBox.Value
        Exp2Lbl.Text = CStr(WorkingHero.GetExpertise2())
        WorkingHero.UpdatePoints()
    End Sub

    Private Sub Exp3NumBox_ValueChanged(sender As Object, e As EventArgs) Handles Exp3NumBox.ValueChanged
        WorkingHero.Expertise3Ranks = Exp3NumBox.Value
        Exp3Lbl.Text = CStr(WorkingHero.GetExpertise3())
        WorkingHero.UpdatePoints()
    End Sub

    Private Sub Exp4NumBox_ValueChanged(sender As Object, e As EventArgs) Handles Exp4NumBox.ValueChanged
        WorkingHero.Expertise4Ranks = Exp4NumBox.Value
        Exp4Lbl.Text = CStr(WorkingHero.GetExpertise4())
        WorkingHero.UpdatePoints()
    End Sub

    Private Sub InsNumBox_ValueChanged(sender As Object, e As EventArgs) Handles InsNumBox.ValueChanged
        WorkingHero.InsightRanks = InsNumBox.Value
        InsLbl.Text = CStr(WorkingHero.GetInsight())
        WorkingHero.UpdatePoints()
    End Sub

    Private Sub IntiNumBox_ValueChanged(sender As Object, e As EventArgs) Handles IntiNumBox.ValueChanged
        WorkingHero.IntellectRanks = IntellectNumBox.Value
        IntLbl.Text = CStr(WorkingHero.GetIntellect())
        WorkingHero.UpdatePoints()
    End Sub

    Private Sub InvNumBox_ValueChanged(sender As Object, e As EventArgs) Handles InvNumBox.ValueChanged
        WorkingHero.InvestigationRanks = InvNumBox.Value
        InvLbl.Text = CStr(WorkingHero.GetInvestigation())
        WorkingHero.UpdatePoints()
    End Sub

    Private Sub PercNumBox_ValueChanged(sender As Object, e As EventArgs) Handles PercNumBox.ValueChanged
        WorkingHero.PerceptionRanks = PercNumBox.Value
        PercLbl.Text = CStr(WorkingHero.GetPerception())
        WorkingHero.UpdatePoints()
    End Sub

    Private Sub PersNumBox_ValueChanged(sender As Object, e As EventArgs) Handles PersNumBox.ValueChanged

    End Sub

    Private Sub RCmb1NumBox_ValueChanged(sender As Object, e As EventArgs) Handles RCmb1NumBox.ValueChanged

    End Sub

    Private Sub RCmb2NumBox_ValueChanged(sender As Object, e As EventArgs) Handles RCmb2NumBox.ValueChanged

    End Sub

    Private Sub RCmb3NumBox_ValueChanged(sender As Object, e As EventArgs) Handles RCmb3NumBox.ValueChanged

    End Sub

    Private Sub SoHNumBox_ValueChanged(sender As Object, e As EventArgs) Handles SoHNumBox.ValueChanged

    End Sub

    Private Sub SteNumBox_ValueChanged(sender As Object, e As EventArgs) Handles SteNumBox.ValueChanged

    End Sub

    Private Sub TechNumBox_ValueChanged(sender As Object, e As EventArgs) Handles TechNumBox.ValueChanged

    End Sub

    Private Sub TreNumBox_ValueChanged(sender As Object, e As EventArgs) Handles TreNumBox.ValueChanged

    End Sub

    Private Sub VehNumBox_ValueChanged(sender As Object, e As EventArgs) Handles VehNumBox.ValueChanged

    End Sub
End Class
