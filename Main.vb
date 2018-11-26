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
End Class
