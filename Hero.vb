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
    Public DodgeRanks As Integer
    Public DodgeMisc As Integer
    Public ParryRanks As Integer
    Public ParryMisc As Integer
    Public FortitudeRanks As Integer
    Public FortitudeMisc As Integer
    Public ToughnessRanks As Integer
    Public ToughnessMisc As Integer
    Public WillRanks As Integer
    Public WillMisc As Integer

    'Skills
    Public AcrobaticsRanks As Integer
    Public AthleticsRanks As Integer
    Public CloseCombat1Ranks As Integer
    Public CloseCombat2Ranks As Integer
    Public CloseCombat3Ranks As Integer
    Public DeceptionRanks As Integer
    Public Expertise1Ranks As Integer
    Public Expertise2Ranks As Integer
    Public Expertise3Ranks As Integer
    Public Expertise4Ranks As Integer
    Public InsightRanks As Integer
    Public IntimidationRanks As Integer
    Public InvestigationRanks As Integer
    Public PerceptionRanks As Integer
    Public PersuasionRanks As Integer
    Public RangedCombat1Ranks As Integer
    Public RangedCombat2Ranks As Integer
    Public RangedCombat3Ranks As Integer
    Public SlightOfHandRanks As Integer
    Public StealthRanks As Integer
    Public TechnologyRanks As Integer
    Public TreatmentRanks As Integer
    Public AcrobaticsMisc As Integer
    Public AthleticsMisc As Integer
    Public CloseCombat1Misc As Integer
    Public CloseCombat2Misc As Integer
    Public CloseCombat3Misc As Integer
    Public DeceptionMisc As Integer
    Public Expertise1Misc As Integer
    Public Expertise2Misc As Integer
    Public Expertise3Misc As Integer
    Public Expertise4Misc As Integer
    Public InsightMisc As Integer
    Public IntimidationMisc As Integer
    Public InvestigationMisc As Integer
    Public PerceptionMisc As Integer
    Public PersuasionMisc As Integer
    Public RangedCombat1Misc As Integer
    Public RangedCombat2Misc As Integer
    Public RangedCombat3Misc As Integer
    Public SlightOfHandMisc As Integer
    Public StealthMisc As Integer
    Public TechnologyMisc As Integer
    Public TreatmentMisc As Integer

    Public Powers As New List(Of Power)


    Public Function GetStrength()
        Return (StrengthRanks + StrengthMisc)
    End Function
    Public Function GetAgility()
        Return (AgilityRanks + AgilityMisc)
    End Function
    Public Function GetFighting()
        Return (FightingRanks + FightingMisc)
    End Function
    Public Function GetAwareness()
        Return (AwarenessRanks + AwarenessMisc)
    End Function
    Public Function GetStamina()
        Return (StaminaRanks + StaminaMisc)
    End Function
    Public Function GetDexterity()
        Return (DexterityRanks + DexterityMisc)
    End Function
    Public Function GetIntellect()
        Return (IntellectRanks + IntellectMisc)
    End Function
    Public Function GetPresence()
        Return (PresenceRanks + PresenceMisc)
    End Function
    Public Function GetDodge()
        Return (DodgeRanks + DodgeMisc) + GetAgility()
    End Function
    Public Function GetParry()
        Return (ParryRanks + ParryMisc) + GetFighting()
    End Function
    Public Function GetFortitude()
        Return (FortitudeRanks + FortitudeMisc) + GetStamina()
    End Function
    Public Function GetToughness()
        Return (ToughnessRanks + ToughnessMisc) + GetStamina()
    End Function
    Public Function GetWill()
        Return (WillRanks + WillMisc) + GetAwareness()
    End Function

    Public Function GetAcrobatics()
        Return AcrobaticsRanks + AcrobaticsMisc
    End Function

    Public Function GetAthletics()
        Return AthleticsRanks + AthleticsMisc
    End Function

    Public Function GetCloseCombat1()
        Return CloseCombat1Ranks + CloseCombat1Misc
    End Function

    Public Function GetCloseCombat2()
        Return CloseCombat2Ranks + CloseCombat2Misc
    End Function

    Public Function GetCloseCombat3()
        Return CloseCombat3Ranks + CloseCombat3Misc
    End Function

    Public Function GetDeception()
        Return DeceptionRanks + DeceptionMisc
    End Function

    Public Function GetExpertise1()
        Return Expertise1Ranks + Expertise1Misc
    End Function

    Public Function GetExpertise2()
        Return Expertise2Ranks + Expertise2Misc
    End Function

    Public Function GetExpertise3()
        Return Expertise3Ranks + Expertise3Misc
    End Function

    Public Function GetExpertise4()
        Return Expertise4Ranks + Expertise4Misc
    End Function

    Public Function GetInsight()
        Return InsightRanks + InsightMisc
    End Function

    Public Function GetIntimidation()
        Return IntimidationRanks + IntimidationMisc
    End Function

    Public Function GetInvestigation()
        Return InvestigationRanks + InvestigationMisc
    End Function

    Public Function GetPerception()
        Return PerceptionRanks + PerceptionMisc
    End Function

    Public Function GetPersuasion()
        Return PersuasionRanks + PersuasionMisc
    End Function

    Public Function GetRangedCombat1()
        Return RangedCombat1Ranks + RangedCombat1Misc
    End Function

    Public Function GetRangedCombat2()
        Return RangedCombat2Ranks + RangedCombat2Misc
    End Function

    Public Function GetRangedCombat3()
        Return RangedCombat3Ranks + RangedCombat3Misc
    End Function

    Public Function GetSlightOfHand()
        Return SlightOfHandRanks + SlightOfHandMisc
    End Function

    Public Function GetStealth()
        Return StealthRanks + StealthMisc
    End Function

    Public Function GetTechnology()
        Return TechnologyRanks + TechnologyMisc
    End Function

    Public Function GetTreatment()
        Return TreatmentRanks + TreatmentMisc
    End Function

    Public Sub UpdatePoints()
        'Abilities
        AbilityRanks = (StrengthRanks + AgilityRanks + FightingRanks + AwarenessRanks + StaminaRanks + DexterityRanks + IntellectRanks + PresenceRanks) * 2

        'Defence
        DefenceRanks = (DodgeRanks + ParryRanks + ToughnessRanks + FortitudeRanks + WillRanks)

        'SKills
        SkillRanks = (AcrobaticsRanks + AthleticsRanks + CloseCombat1Ranks + CloseCombat2Ranks + CloseCombat3Ranks + DeceptionRanks + Expertise1Ranks + Expertise2Ranks + Expertise3Ranks + Expertise4Ranks)
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
