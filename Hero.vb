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
    Public VehicleRanks As Integer
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
    Public VehicleMisc As Integer

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
        Return AcrobaticsRanks + AcrobaticsMisc + GetAgility()
    End Function

    Public Function GetAthletics()
        Return AthleticsRanks + AthleticsMisc + GetStrength()
    End Function

    Public Function GetCloseCombat1()
        Return CloseCombat1Ranks + CloseCombat1Misc + GetFighting()
    End Function

    Public Function GetCloseCombat2()
        Return CloseCombat2Ranks + CloseCombat2Misc + GetFighting()
    End Function

    Public Function GetCloseCombat3()
        Return CloseCombat3Ranks + CloseCombat3Misc + GetFighting()
    End Function

    Public Function GetDeception()
        Return DeceptionRanks + DeceptionMisc + GetPresence()
    End Function

    Public Function GetExpertise1()
        Return Expertise1Ranks + Expertise1Misc + GetIntellect()
    End Function

    Public Function GetExpertise2()
        Return Expertise2Ranks + Expertise2Misc + GetIntellect()
    End Function

    Public Function GetExpertise3()
        Return Expertise3Ranks + Expertise3Misc + GetIntellect()
    End Function

    Public Function GetExpertise4()
        Return Expertise4Ranks + Expertise4Misc + GetIntellect()
    End Function

    Public Function GetInsight()
        Return InsightRanks + InsightMisc + GetAwareness()
    End Function

    Public Function GetIntimidation()
        Return IntimidationRanks + IntimidationMisc + GetPresence()
    End Function

    Public Function GetInvestigation()
        Return InvestigationRanks + InvestigationMisc + GetIntellect()
    End Function

    Public Function GetPerception()
        Return PerceptionRanks + PerceptionMisc + GetAwareness()
    End Function

    Public Function GetPersuasion()
        Return PersuasionRanks + PersuasionMisc + GetPresence()
    End Function

    Public Function GetRangedCombat1()
        Return RangedCombat1Ranks + RangedCombat1Misc + GetDexterity()
    End Function

    Public Function GetRangedCombat2()
        Return RangedCombat2Ranks + RangedCombat2Misc + GetDexterity()
    End Function

    Public Function GetRangedCombat3()
        Return RangedCombat3Ranks + RangedCombat3Misc + GetDexterity()
    End Function

    Public Function GetSlightOfHand()
        Return SlightOfHandRanks + SlightOfHandMisc + GetDexterity()
    End Function

    Public Function GetStealth()
        Return StealthRanks + StealthMisc + GetAgility()
    End Function

    Public Function GetTechnology()
        Return TechnologyRanks + TechnologyMisc + GetIntellect()
    End Function

    Public Function GetTreatment()
        Return TreatmentRanks + TreatmentMisc + GetIntellect()
    End Function

    Public Function GetVehicle()
        Return VehicleRanks + VehicleMisc + GetDexterity()
    End Function

    Public Sub UpdatePoints()
        'Abilities
        AbilityRanks = (StrengthRanks + AgilityRanks + FightingRanks + AwarenessRanks + StaminaRanks + DexterityRanks + IntellectRanks + PresenceRanks) * 2

        'Defence
        DefenceRanks = (DodgeRanks + ParryRanks + ToughnessRanks + FortitudeRanks + WillRanks)

        'SKills
        SkillRanks = (AcrobaticsRanks + AthleticsRanks + CloseCombat1Ranks + CloseCombat2Ranks + CloseCombat3Ranks + DeceptionRanks + Expertise1Ranks + Expertise2Ranks + Expertise3Ranks + Expertise4Ranks + InsightRanks + IntimidationRanks + InvestigationRanks + PerceptionRanks + PersuasionRanks + RangedCombat1Ranks + RangedCombat2Ranks + RangedCombat3Ranks + SlightOfHandRanks + StealthRanks + TechnologyRanks + TreatmentRanks + VehicleRanks) / 2

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

        Main.StrLbl.Text = CStr(GetStrength())
        Main.AgiLbl.Text = CStr(GetAgility())
        Main.FgtLbl.Text = CStr(GetFighting())
        Main.AweLbl.Text = CStr(GetAwareness())
        Main.StaLbl.Text = CStr(GetStamina())
        Main.DexLbl.Text = CStr(GetDexterity())
        Main.IntLbl.Text = CStr(GetIntellect())
        Main.PreLbl.Text = CStr(GetPresence())

        Main.FortitudeLbl.Text = CStr(GetFortitude())
        Main.ToughnessLbl.Text = CStr(GetToughness())
        Main.WillLbl.Text = CStr(GetWill())
        Main.ParryLbl.Text = CStr(GetParry())
        Main.DodgeLbl.Text = CStr(GetDodge())


        Main.AcrLbl.Text = CStr(GetAcrobatics())
        Main.AthLbl.Text = CStr(GetAthletics())
        Main.CCmb1Lbl.Text = CStr(GetCloseCombat1())
        Main.CCmb2Lbl.Text = CStr(GetCloseCombat2())
        Main.CCmb3Lbl.Text = CStr(GetCloseCombat3())
        Main.DecLbl.Text = CStr(GetDeception())
        Main.Exp1Lbl.Text = CStr(GetExpertise1())
        Main.Exp2Lbl.Text = CStr(GetExpertise2())
        Main.Exp3Lbl.Text = CStr(GetExpertise3())
        Main.Exp4Lbl.Text = CStr(GetExpertise4())
        Main.InsLbl.Text = CStr(GetInsight())
        Main.IntLbl.Text = CStr(GetIntimidation())
        Main.InvLbl.Text = CStr(GetInvestigation())
        Main.PercLbl.Text = CStr(GetPerception())
        Main.Perslbl.Text = CStr(GetPersuasion())
        Main.RCmb1Lbl.Text = CStr(GetRangedCombat1())
        Main.RCmb2Lbl.Text = CStr(GetRangedCombat2())
        Main.RCmb3Lbl.Text = CStr(GetRangedCombat3())
        Main.SoHLbl.Text = CStr(GetSlightOfHand())
        Main.SteLbl.Text = CStr(GetStealth())
        Main.TechLbl.Text = CStr(GetTechnology())
        Main.TreLbl.Text = CStr(GetTreatment())
        Main.VehLbl.Text = CStr(GetVehicle())

    End Sub
End Class
