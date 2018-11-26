Public Class Hero
    Public Enum HeroType
        Normal
        Automation
        Immobile
    End Enum

    'Basics
    Public Age As Double
    Public NPC As Boolean
    Public Eyes As String
    Public Hair As String
    Public Name As String
    Public Type As HeroType
    Public Player As String
    Public Gender As String
    Public Height As Double
    Public Weight As Double
    Public Identity As String
    Public Secret As Boolean = False
    Public GroupAffiliation As String
    Public BaseOfOpperations As String

    'Power Points
    Public PowerLevel As Integer
    Public PowerPoints As Double
    Public PowerPointPerLevel As Integer
    Public AbilityRanks As Integer
    Public PowerRanks As Integer
    Public SkillRanks As Double
    Public AdvantageRanks As Integer
    Public DefenceRanks As Integer
    Public TotalPowerPoints As Double

    'Abilitiees
    Public StrengthRanks As Integer
    Public StrengthMisc As Integer
    Public AgilityRanks As Integer
    Public AgilityMisc As Integer
    Public FightingRanks As Integer
    Public FightingMisc As Integer
    Public AwarenessRanks As Integer
    Public AwarenessMisc As Integer
    Public StaminaRanks As Integer
    Public StaminaMisc As Integer
    Public DexterityRanks As Integer
    Public DexterityMisc As Integer
    Public IntellectRanks As Integer
    Public IntellectMisc As Integer
    Public PresenceRanks As Integer
    Public PresenceMisc As Integer

    'Defence
    Public Dodge As Integer
    Public Parry As Integer
    Public Fortitude As Integer
    Public Toughness As Integer
    Public Will As Integer

    Public Powers As New List(Of Power)



    Public Sub UpdatePoints()
        'Abilities
        AbilityRanks = (Strength + Agility + Fighting + Awareness + Stamina + Dexterity + Intellect + Presence) * 2

        'Power Ranks
        For Each heropower In Powers
            PowerRanks = PowerRanks + (heropower.Cost * heropower.Ranks)
        Next

        TotalPowerPoints = AbilityRanks + PowerRanks + SkillRanks + AdvantageRanks + DefenceRanks

        Main.AbilitiesToolLabel.Text = "Abilities: " + CStr(AbilityRanks)
        Main.PowersToolLabel.Text = "Powers: " + CStr(PowerRanks)
        Main.AdvantagesToolLabel.Text = "Advantages: " + CStr(AdvantageRanks)
        Main.SkillsToolLabel.Text = "Skills: " + CStr(SkillRanks)
        Main.DefencesToolLabel.Text = "Defences: " + CStr(DefenceRanks)
        Main.TotalToolLabel.Text = "Total: " + CStr(TotalPowerPoints) + "/" + CStr(PowerPoints)
    End Sub
End Class
