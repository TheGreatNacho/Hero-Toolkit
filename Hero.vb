Imports System.IO

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
    Public Height As String = ""
    Public Weight As String = ""
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
    Public CloseCombat1Name As String = ""
    Public CloseCombat2Name As String = ""
    Public CloseCombat3Name As String = ""
    Public Expertise1Name As String = ""
    Public Expertise2Name As String = ""
    Public Expertise3Name As String = ""
    Public Expertise4Name As String = ""
    Public RangedCombat1Name As String = ""
    Public RangedCombat2Name As String = ""
    Public RangedCombat3Name As String = ""

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

    Public Sub SaveHero(ByVal Location As String)
        Dim fs As New FileStream(Location, FileMode.OpenOrCreate)
        Dim bw As New BinaryWriter(fs)

        bw.Write(Age)
        bw.Write(NPC)
        bw.Write(Eyes)
        bw.Write(Hair)
        bw.Write(Name)
        'bw.Write(Type)
        bw.Write(Player)
        bw.Write(Gender)
        bw.Write(Height)
        bw.Write(Weight)
        bw.Write(Identity)
        bw.Write(Secret)
        bw.Write(GroupAffiliation)
        bw.Write(BaseOfOpperations)

        'Power Points
        bw.Write(PowerLevel)
        bw.Write(PowerPoints)
        bw.Write(PowerPointPerLevel)
        bw.Write(AbilityRanks)
        bw.Write(PowerRanks)
        bw.Write(SkillRanks)
        bw.Write(AdvantageRanks)
        bw.Write(DefenceRanks)
        bw.Write(TotalPowerPoints)

        'Abilitiees
        bw.Write(StrengthRanks)
        bw.Write(StrengthMisc)
        bw.Write(AgilityRanks)
        bw.Write(AgilityMisc)
        bw.Write(FightingRanks)
        bw.Write(FightingMisc)
        bw.Write(AwarenessRanks)
        bw.Write(AwarenessMisc)
        bw.Write(StaminaRanks)
        bw.Write(StaminaMisc)
        bw.Write(DexterityRanks)
        bw.Write(DexterityMisc)
        bw.Write(IntellectRanks)
        bw.Write(IntellectMisc)
        bw.Write(PresenceRanks)
        bw.Write(PresenceMisc)

        'Defence
        bw.Write(DodgeRanks)
        bw.Write(DodgeMisc)
        bw.Write(ParryRanks)
        bw.Write(ParryMisc)
        bw.Write(FortitudeRanks)
        bw.Write(FortitudeMisc)
        bw.Write(ToughnessRanks)
        bw.Write(ToughnessMisc)
        bw.Write(WillRanks)
        bw.Write(WillMisc)

        'Skills
        bw.Write(CloseCombat1Name)
        bw.Write(CloseCombat2Name)
        bw.Write(CloseCombat3Name)
        bw.Write(Expertise1Name)
        bw.Write(Expertise2Name)
        bw.Write(Expertise3Name)
        bw.Write(Expertise4Name)
        bw.Write(RangedCombat1Name)
        bw.Write(RangedCombat2Name)
        bw.Write(RangedCombat3Name)
        bw.Write(AcrobaticsRanks)
        bw.Write(AthleticsRanks)
        bw.Write(CloseCombat1Ranks)
        bw.Write(CloseCombat2Ranks)
        bw.Write(CloseCombat3Ranks)
        bw.Write(DeceptionRanks)
        bw.Write(Expertise1Ranks)
        bw.Write(Expertise2Ranks)
        bw.Write(Expertise3Ranks)
        bw.Write(Expertise4Ranks)
        bw.Write(InsightRanks)
        bw.Write(IntimidationRanks)
        bw.Write(InvestigationRanks)
        bw.Write(PerceptionRanks)
        bw.Write(PersuasionRanks)
        bw.Write(RangedCombat1Ranks)
        bw.Write(RangedCombat2Ranks)
        bw.Write(RangedCombat3Ranks)
        bw.Write(SlightOfHandRanks)
        bw.Write(StealthRanks)
        bw.Write(TechnologyRanks)
        bw.Write(TreatmentRanks)
        bw.Write(VehicleRanks)
        bw.Write(AcrobaticsMisc)
        bw.Write(AthleticsMisc)
        bw.Write(CloseCombat1Misc)
        bw.Write(CloseCombat2Misc)
        bw.Write(CloseCombat3Misc)
        bw.Write(DeceptionMisc)
        bw.Write(Expertise1Misc)
        bw.Write(Expertise2Misc)
        bw.Write(Expertise3Misc)
        bw.Write(Expertise4Misc)
        bw.Write(InsightMisc)
        bw.Write(IntimidationMisc)
        bw.Write(InvestigationMisc)
        bw.Write(PerceptionMisc)
        bw.Write(PersuasionMisc)
        bw.Write(RangedCombat1Misc)
        bw.Write(RangedCombat2Misc)
        bw.Write(RangedCombat3Misc)
        bw.Write(SlightOfHandMisc)
        bw.Write(StealthMisc)
        bw.Write(TechnologyMisc)
        bw.Write(TreatmentMisc)
        bw.Write(VehicleMisc)

        bw.Close()
        fs.Close()
    End Sub

    Public Sub LoadHero(ByVal Filename As String)
        Dim fs As New FileStream(Filename, FileMode.Open)
        Dim br As New BinaryReader(fs)
        Try
            Age = br.ReadDouble()
            NPC = br.ReadBoolean()
            Eyes = br.ReadString()
            Hair = br.ReadString()
            Name = br.ReadString()
            'Type = br.ReadHeroType()
            Player = br.ReadString()
            Gender = br.ReadString()
            Height = br.ReadString()
            Weight = br.ReadString()
            Identity = br.ReadString()
            Secret = br.ReadBoolean()
            GroupAffiliation = br.ReadString()
            BaseOfOpperations = br.ReadString()

            'Power Points
            PowerLevel = br.ReadInt32()
            PowerPoints = br.ReadDouble()
            PowerPointPerLevel = br.ReadInt32()
            AbilityRanks = br.ReadInt32()
            PowerRanks = br.ReadInt32()
            SkillRanks = br.ReadDouble()
            AdvantageRanks = br.ReadInt32()
            DefenceRanks = br.ReadInt32()
            TotalPowerPoints = br.ReadDouble()

            'Abilitiees
            StrengthRanks = br.ReadInt32()
            StrengthMisc = br.ReadInt32()
            AgilityRanks = br.ReadInt32()
            AgilityMisc = br.ReadInt32()
            FightingRanks = br.ReadInt32()
            FightingMisc = br.ReadInt32()
            AwarenessRanks = br.ReadInt32()
            AwarenessMisc = br.ReadInt32()
            StaminaRanks = br.ReadInt32()
            StaminaMisc = br.ReadInt32()
            DexterityRanks = br.ReadInt32()
            DexterityMisc = br.ReadInt32()
            IntellectRanks = br.ReadInt32()
            IntellectMisc = br.ReadInt32()
            PresenceRanks = br.ReadInt32()
            PresenceMisc = br.ReadInt32()

            'Defence
            DodgeRanks = br.ReadInt32()
            DodgeMisc = br.ReadInt32()
            ParryRanks = br.ReadInt32()
            ParryMisc = br.ReadInt32()
            FortitudeRanks = br.ReadInt32()
            FortitudeMisc = br.ReadInt32()
            ToughnessRanks = br.ReadInt32()
            ToughnessMisc = br.ReadInt32()
            WillRanks = br.ReadInt32()
            WillMisc = br.ReadInt32()

            'Skills
            CloseCombat1Name = br.ReadString()
            CloseCombat2Name = br.ReadString()
            CloseCombat3Name = br.ReadString()
            Expertise1Name = br.ReadString()
            Expertise2Name = br.ReadString()
            Expertise3Name = br.ReadString()
            Expertise4Name = br.ReadString()
            RangedCombat1Name = br.ReadString()
            RangedCombat2Name = br.ReadString()
            RangedCombat3Name = br.ReadString()
            AcrobaticsRanks = br.ReadInt32()
            AthleticsRanks = br.ReadInt32()
            CloseCombat1Ranks = br.ReadInt32()
            CloseCombat2Ranks = br.ReadInt32()
            CloseCombat3Ranks = br.ReadInt32()
            DeceptionRanks = br.ReadInt32()
            Expertise1Ranks = br.ReadInt32()
            Expertise2Ranks = br.ReadInt32()
            Expertise3Ranks = br.ReadInt32()
            Expertise4Ranks = br.ReadInt32()
            InsightRanks = br.ReadInt32()
            IntimidationRanks = br.ReadInt32()
            InvestigationRanks = br.ReadInt32()
            PerceptionRanks = br.ReadInt32()
            PersuasionRanks = br.ReadInt32()
            RangedCombat1Ranks = br.ReadInt32()
            RangedCombat2Ranks = br.ReadInt32()
            RangedCombat3Ranks = br.ReadInt32()
            SlightOfHandRanks = br.ReadInt32()
            StealthRanks = br.ReadInt32()
            TechnologyRanks = br.ReadInt32()
            TreatmentRanks = br.ReadInt32()
            VehicleRanks = br.ReadInt32()
            AcrobaticsMisc = br.ReadInt32()
            AthleticsMisc = br.ReadInt32()
            CloseCombat1Misc = br.ReadInt32()
            CloseCombat2Misc = br.ReadInt32()
            CloseCombat3Misc = br.ReadInt32()
            DeceptionMisc = br.ReadInt32()
            Expertise1Misc = br.ReadInt32()
            Expertise2Misc = br.ReadInt32()
            Expertise3Misc = br.ReadInt32()
            Expertise4Misc = br.ReadInt32()
            InsightMisc = br.ReadInt32()
            IntimidationMisc = br.ReadInt32()
            InvestigationMisc = br.ReadInt32()
            PerceptionMisc = br.ReadInt32()
            PersuasionMisc = br.ReadInt32()
            RangedCombat1Misc = br.ReadInt32()
            RangedCombat2Misc = br.ReadInt32()
            RangedCombat3Misc = br.ReadInt32()
            SlightOfHandMisc = br.ReadInt32()
            StealthMisc = br.ReadInt32()
            TechnologyMisc = br.ReadInt32()
            TreatmentMisc = br.ReadInt32()
            VehicleMisc = br.ReadInt32()

            'A hero was loaded/created, so give access to stuff
            Main.TabPanel.Enabled = True
            Main.AbilitiesToolLabel.Visible = True
            Main.PowersToolLabel.Visible = True
            Main.AdvantagesToolLabel.Visible = True
            Main.SkillsToolLabel.Visible = True
            Main.DefencesToolLabel.Visible = True
            Main.TotalToolLabel.Visible = True

            BasicsNumberboxes()
            UpdatePoints()
        Catch ex As Exception

            MsgBox("Can not load hero - Hero is unsupported")
        End Try


        br.Close()
        fs.Close()
    End Sub

    Public Sub ClearHero()
        Age = 0
        NPC = False
        Eyes = ""
        Hair = ""
        Name = ""
        'Type = br.ReadHeroType()
        Player = ""
        Gender = ""
        Height = ""
        Weight = ""
        Identity = ""
        Secret = False
        GroupAffiliation = ""
        BaseOfOpperations = ""

        'Power Points
        PowerLevel = 0
        PowerPoints = 0
        PowerPointPerLevel = 0
        AbilityRanks = 0
        PowerRanks = 0
        SkillRanks = 0
        AdvantageRanks = 0
        DefenceRanks = 0
        TotalPowerPoints = 0

        'Abilitiees
        StrengthRanks = 0
        StrengthMisc = 0
        AgilityRanks = 0
        AgilityMisc = 0
        FightingRanks = 0
        FightingMisc = 0
        AwarenessRanks = 0
        AwarenessMisc = 0
        StaminaRanks = 0
        StaminaMisc = 0
        DexterityRanks = 0
        DexterityMisc = 0
        IntellectRanks = 0
        IntellectMisc = 0
        PresenceRanks = 0
        PresenceMisc = 0

        'Defence
        DodgeRanks = 0
        DodgeMisc = 0
        ParryRanks = 0
        ParryMisc = 0
        FortitudeRanks = 0
        FortitudeMisc = 0
        ToughnessRanks = 0
        ToughnessMisc = 0
        WillRanks = 0
        WillMisc = 0

        'Skills
        CloseCombat1Name = ""
        CloseCombat2Name = ""
        CloseCombat3Name = ""
        Expertise1Name = ""
        Expertise2Name = ""
        Expertise3Name = ""
        Expertise4Name = ""
        RangedCombat1Name = ""
        RangedCombat2Name = ""
        RangedCombat3Name = ""
        AcrobaticsRanks = 0
        AthleticsRanks = 0
        CloseCombat1Ranks = 0
        CloseCombat2Ranks = 0
        CloseCombat3Ranks = 0
        DeceptionRanks = 0
        Expertise1Ranks = 0
        Expertise2Ranks = 0
        Expertise3Ranks = 0
        Expertise4Ranks = 0
        InsightRanks = 0
        IntimidationRanks = 0
        InvestigationRanks = 0
        PerceptionRanks = 0
        PersuasionRanks = 0
        RangedCombat1Ranks = 0
        RangedCombat2Ranks = 0
        RangedCombat3Ranks = 0
        SlightOfHandRanks = 0
        StealthRanks = 0
        TechnologyRanks = 0
        TreatmentRanks = 0
        VehicleRanks = 0
        AcrobaticsMisc = 0
        AthleticsMisc = 0
        CloseCombat1Misc = 0
        CloseCombat2Misc = 0
        CloseCombat3Misc = 0
        DeceptionMisc = 0
        Expertise1Misc = 0
        Expertise2Misc = 0
        Expertise3Misc = 0
        Expertise4Misc = 0
        InsightMisc = 0
        IntimidationMisc = 0
        InvestigationMisc = 0
        PerceptionMisc = 0
        PersuasionMisc = 0
        RangedCombat1Misc = 0
        RangedCombat2Misc = 0
        RangedCombat3Misc = 0
        SlightOfHandMisc = 0
        StealthMisc = 0
        TechnologyMisc = 0
        TreatmentMisc = 0
        VehicleMisc = 0

        'A hero was loaded/created, so give access to stuff
        Main.TabPanel.Enabled = True
        Main.AbilitiesToolLabel.Visible = True
        Main.PowersToolLabel.Visible = True
        Main.AdvantagesToolLabel.Visible = True
        Main.SkillsToolLabel.Visible = True
        Main.DefencesToolLabel.Visible = True
        Main.TotalToolLabel.Visible = True

        BasicsNumberboxes()
        UpdatePoints()
    End Sub

    Public Sub BasicsNumberboxes()
        'Update Basics Page
        'Bio
        Main.HeroNameTextBox.Text = Name
        Main.PlayerNameTextBox.Text = Player
        Main.IdentityTextBox.Text = Identity
        Main.GenderTextBox.Text = Gender
        Main.SecretIdentityChkBox.Checked = Secret
        Main.AgeTextBox.Text = Age
        Main.HeightTextBox.Text = Height
        Main.WeightTextBox.Text = Weight
        Main.EyesTextBox.Text = Eyes
        Main.HairTextBox.Text = Hair
        Main.GroupAffiliationsTextBox.Text = GroupAffiliation
        Main.BOOTextBox.Text = BaseOfOpperations
        'Abilities
        Main.StrengthNumBox.Value = StrengthRanks
        Main.AgilityNumBox.Value = AgilityRanks
        Main.FightingNumBox.Value = FightingRanks
        Main.AwarenessNumBox.Value = AwarenessRanks
        Main.StaminaNumBox.Value = StaminaRanks
        Main.DexterityNumBox.Value = DexterityRanks
        Main.IntellectNumBox.Value = IntellectRanks
        Main.PresenceNumBox.Value = PresenceRanks
        'Defences
        Main.DodgeNumberBox.Value = DodgeRanks
        Main.ParryNumberBox.Value = ParryRanks
        Main.ToughnessNumberBox.Value = ToughnessRanks
        Main.FortitudeNumberBox.Value = FortitudeRanks
        Main.WillNumberBox.Value = WillRanks
        'Skills
        Main.CloseCombat1.Text = CloseCombat1Name
        Main.CloseCombat2.Text = CloseCombat2Name
        Main.CloseCombat3.Text = CloseCombat3Name
        Main.Expertise1.Text = Expertise1Name
        Main.Expertise2.Text = Expertise2Name
        Main.Expertise3.Text = Expertise3Name
        Main.Expertise4.Text = Expertise4Name
        Main.RangedCombat1.Text = RangedCombat1Name
        Main.RangedCombat2.Text = RangedCombat2Name
        Main.RangedCombat3.Text = RangedCombat3Name

        Main.AcroNumBox.Value = AcrobaticsRanks
        Main.AthNumBox.Value = AthleticsRanks
        Main.CCmb1NumBox.Value = CloseCombat1Ranks
        Main.CCmb2NumBox.Value = CloseCombat2Ranks
        Main.CCmb3NumBox.Value = CloseCombat3Ranks
        Main.DecNumBox.Value = DeceptionRanks
        Main.Exp1NumBox.Value = Expertise1Ranks
        Main.Exp2NumBox.Value = Expertise2Ranks
        Main.Exp3NumBox.Value = Expertise3Ranks
        Main.Exp4NumBox.Value = Expertise4Ranks
        Main.InsNumBox.Value = InsightRanks
        Main.IntiNumBox.Value = IntimidationRanks
        Main.InvNumBox.Value = InvestigationRanks
        Main.PercNumBox.Value = PerceptionRanks
        Main.PersNumBox.Value = PersuasionRanks
        Main.RCmb1NumBox.Value = RangedCombat1Ranks
        Main.RCmb2NumBox.Value = RangedCombat2Ranks
        Main.RCmb3NumBox.Value = RangedCombat3Ranks
        Main.SoHNumBox.Value = SlightOfHandRanks
        Main.TechNumBox.Value = TechnologyRanks
        Main.TreNumBox.Value = TreatmentRanks
        Main.VehNumBox.Value = VehicleRanks

    End Sub

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

        'Set Basics Menu Ability Labels
        Main.StrLbl.Text = CStr(GetStrength())
        Main.AgiLbl.Text = CStr(GetAgility())
        Main.FgtLbl.Text = CStr(GetFighting())
        Main.AweLbl.Text = CStr(GetAwareness())
        Main.StaLbl.Text = CStr(GetStamina())
        Main.DexLbl.Text = CStr(GetDexterity())
        Main.IntLbl.Text = CStr(GetIntellect())
        Main.PreLbl.Text = CStr(GetPresence())

        'Set Basics Menu Defence Labels
        Main.FortitudeLbl.Text = CStr(GetFortitude())
        Main.ToughnessLbl.Text = CStr(GetToughness())
        Main.WillLbl.Text = CStr(GetWill())
        Main.ParryLbl.Text = CStr(GetParry())
        Main.DodgeLbl.Text = CStr(GetDodge())

        'Set Basics Menu Skills Labels
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
