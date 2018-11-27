Public Class Hero
    Public Enum HeroType
        Normal
        Automation
        Immobile
    End Enum

    'Basics
    Public Age As Double = 0
    Public NPC As Boolean = 0
    Public Eyes As String = ""
    Public Hair As String = ""
    Public Name As String = ""
    Public Type As HeroType = HeroType.Normal
    Public Player As String = ""
    Public Gender As String = ""
    Public Height As Double = 0
    Public Weight As Double = 0
    Public Identity As String = ""
    Public Secret As Boolean = False
    Public GroupAffiliation As String = ""
    Public BaseOfOpperations As String = ""

    'Power Points
    Public PowerLevel As Integer = 10
    Public PowerPoints As Double = 150
    Public PowerPointPerLevel As Integer = 15
    Public AbilityRanks As Integer = 0
    Public PowerRanks As Integer = 0
    Public SkillRanks As Double = 0
    Public AdvantageRanks As Integer = 0
    Public DefenceRanks As Integer = 0
    Public TotalPowerPoints As Double = 0

    'Abilitiees
    Public StrengthRanks As Integer = 0
    Public StrengthMisc As Integer = 0
    Public AgilityRanks As Integer = 0
    Public AgilityMisc As Integer = 0
    Public FightingRanks As Integer = 0
    Public FightingMisc As Integer = 0
    Public AwarenessRanks As Integer = 0
    Public AwarenessMisc As Integer = 0
    Public StaminaRanks As Integer = 0
    Public StaminaMisc As Integer = 0
    Public DexterityRanks As Integer = 0
    Public DexterityMisc As Integer = 0
    Public IntellectRanks As Integer = 0
    Public IntellectMisc As Integer = 0
    Public PresenceRanks As Integer = 0
    Public PresenceMisc As Integer = 0

    'Defence
    Public DodgeRanks As Integer = 0
    Public DodgeMisc As Integer = 0
    Public ParryRanks As Integer = 0
    Public ParryMisc As Integer = 0
    Public FortitudeRanks As Integer = 0
    Public FortitudeMisc As Integer = 0
    Public ToughnessRanks As Integer = 0
    Public ToughnessMisc As Integer = 0
    Public WillRanks As Integer = 0
    Public WillMisc As Integer = 0

    'Skills
    Public AcrobaticsRanks As Integer = 0
    Public AthleticsRanks As Integer = 0
    Public CloseCombat1Ranks As Integer = 0
    Public CloseCombat2Ranks As Integer = 0
    Public CloseCombat3Ranks As Integer = 0
    Public DeceptionRanks As Integer = 0
    Public Expertise1Ranks As Integer = 0
    Public Expertise2Ranks As Integer = 0
    Public Expertise3Ranks As Integer = 0
    Public Expertise4Ranks As Integer = 0
    Public InsightRanks As Integer = 0
    Public IntimidationRanks As Integer = 0
    Public InvestigationRanks As Integer = 0
    Public PerceptionRanks As Integer = 0
    Public PersuasionRanks As Integer = 0
    Public RangedCombat1Ranks As Integer = 0
    Public RangedCombat2Ranks As Integer = 0
    Public RangedCombat3Ranks As Integer = 0
    Public SlightOfHandRanks As Integer = 0
    Public StealthRanks As Integer = 0
    Public TechnologyRanks As Integer = 0
    Public TreatmentRanks As Integer = 0
    Public VehicleRanks As Integer = 0
    Public AcrobaticsMisc As Integer = 0
    Public AthleticsMisc As Integer = 0
    Public CloseCombat1Misc As Integer = 0
    Public CloseCombat2Misc As Integer = 0
    Public CloseCombat3Misc As Integer = 0
    Public DeceptionMisc As Integer = 0
    Public Expertise1Misc As Integer = 0
    Public Expertise2Misc As Integer = 0
    Public Expertise3Misc As Integer = 0
    Public Expertise4Misc As Integer = 0
    Public InsightMisc As Integer = 0
    Public IntimidationMisc As Integer = 0
    Public InvestigationMisc As Integer = 0
    Public PerceptionMisc As Integer = 0
    Public PersuasionMisc As Integer = 0
    Public RangedCombat1Misc As Integer = 0
    Public RangedCombat2Misc As Integer = 0
    Public RangedCombat3Misc As Integer = 0
    Public SlightOfHandMisc As Integer = 0
    Public StealthMisc As Integer = 0
    Public TechnologyMisc As Integer = 0
    Public TreatmentMisc As Integer = 0
    Public VehicleMisc As Integer = 0

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
        Main.IntiLbl.Text = CStr(GetIntimidation())
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
