Public Class HomePage
#Region "Global Variables"
    Dim SwordDmgValues = New Dictionary(Of String, Integer) From {{"Wood", 4}, {"Stone", 5}, {"Gold", 4}, {"Iron", 6}, {"Diamond", 7}, {"Netherite", 8}, {"(None)", 0}}
    Dim SharpLevelsDmg = New Dictionary(Of String, Integer) From {{"Sharp I", 1}, {"Sharp II", 2}, {"Sharp III", 3}, {"Sharp IV", 4}, {"Sharp V", 5}, {"None", 0}}
    Dim AxeDmgValues = New Dictionary(Of String, Integer) From {{"Wood", 7}, {"Stone", 9}, {"Iron", 9}, {"Diamond", 9}, {"Gold", 7}, {"Netherite", 10}, {"(None)", 0}}
    Dim ProtLevelsEPF = New Dictionary(Of String, Integer) From {{"Prot I", 1}, {"Prot II", 2}, {"Prot III", 3}, {"Prot IV", 4}, {"(None)", 0}}
    Dim HelmDefValues = New Dictionary(Of String, Integer) From {{"Leather", 1}, {"Turtle", 2}, {"Chainmail", 2}, {"Gold", 2}, {"Iron", 2}, {"Diamond", 3}, {"Netherite", 3}}
    Dim ChestDefValues = New Dictionary(Of String, Integer) From {{"Leather", 3}, {"Chainmail", 5}, {"Gold", 5}, {"Iron", 6}, {"Diamond", 8}, {"Netherite", 8}}
    Dim LeggingsDefValues = New Dictionary(Of String, Integer) From {{"Leather", 2}, {"Chainmail", 4}, {"Gold", 3}, {"Iron", 5}, {"Diamond", 6}, {"Netherite", 6}}
    Dim BootsDefValues = New Dictionary(Of String, Integer) From {{"Leather", 1}, {"Chainmail", 1}, {"Gold", 1}, {"Iron", 2}, {"Diamond", 3}, {"Netherite", 3}}
    Dim ToughnessValues = New Dictionary(Of String, Integer) From {{"Leather", 0}, {"Turtle", 0}, {"Chainmail", 0}, {"Gold", 0}, {"Iron", 0}, {"Diamond", 2}, {"Netherite", 3}}
    Dim PowerLevelValues = New Dictionary(Of String, Integer) From {{"Power I", 1}, {"Power II", 2}, {"Power III", 3}, {"Power IV", 4}, {"Power V", 5}, {"None", 0}}
    Dim AxeSpeed = New Dictionary(Of String, Integer) From {{"Wood", 1.25}, {"Stone", 1.25}, {"Iron", 1.11}, {"Diamond", 1}, {"Gold", 1}, {"Netherite", 1}, {"(None)", 1}}
    Dim CR, ASwordDmg, AAxeDmg, ABowDmg, AStrength, AHelmDef, AChestDef, ALeggingsDef, ABootsDef, AHelmEPF, AChestEPF, ALeggingsEPF, ABootsEPF, AHelmToughness, AChestToughness, ABootsToughness, ALeggingsToughness, ToughnessA, EPFA, DefPointsA, DRA
#End Region
    Private Sub HomePage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbSharpASword.SelectedItem = "(None)"
        lbSwordsA.SelectedItem = "(None)"
        lbSharpAAxe.SelectedItem = "(None)"
        lbAxeA.SelectedItem = "(None)"
        lbPower.SelectedItem = "(None)"
    End Sub
    Private Sub tmrAll_Tick(sender As Object, e As EventArgs) Handles tmrAll.Tick
        lblAxeDmgA.Text = AAxeDmg.ToString + " (" + (AAxeDmg * 1.5).ToString + ")"
        lblSwordDmgA.Text = ASwordDmg.ToString + " (" + (ASwordDmg * 1.5).ToString + ")"
        lblHelmDefA.Text = AHelmDef
        lblChestDefA.Text = AChestDef
        lblLeggingsDefA.Text = ALeggingsDef
        lblBootsDefA.Text = ABootsDef
        lblHelmEPFA.Text = AHelmEPF
        lblChestEPFA.Text = AChestEPF
        lblLeggingsEPFA.Text = ALeggingsEPF
        lblBootsEPFA.Text = ABootsEPF
        lblBowDmgA.Text = ABowDmg
        CR = ((AAxeDmg / AxeSpeed(lbAxeA.SelectedItem)) + (ASwordDmg / 0.625) + ABowDmg) * 10
        lblCombatRating.Text = CR
        DefPointsA = AHelmDef + AChestDef + ALeggingsDef + ABootsDef
        ToughnessA = AHelmToughness + AChestToughness + ALeggingsToughness + ABootsToughness
        EPFA = (AHelmEPF + AChestEPF + ALeggingsEPF + ABootsEPF)
        DRA = (100 - ((6 * (1 - (Math.Min(20, Math.Max(DefPointsA / 5, DefPointsA - (6 / (2 + ToughnessA / 4))))) / 25)) / 6) * 100)
        lblDefPointsA.Text = "Defense Points: " + DefPointsA.ToString
        lblToughnessA.Text = "Toughness: " + ToughnessA.ToString
        lblEPFA.Text = "EPF: " + EPFA.ToString
        If EPFA <> 0 Then
            lblArmorDRA.Text = "Armor DR (%): " + ((((((EPFA * 0.75) * 4) / 100) * ((100 - DRA) / 100)) * 100) + DRA).ToString
            lblArmorRating.Text = Math.Round(((((((EPFA * 0.75) * 4) / 100) * ((100 - DRA) / 100)) * 100) + DRA) * 10, 1)
        Else
            lblArmorDRA.Text = "Armor DR (%): " + DRA.ToString
            lblArmorRating.Text = Math.Round(DRA * 10, 1)
        End If
        lblOverallRating.Text = Math.Round((Convert.ToInt32(lblArmorRating.Text) + CR) / 2, 1)
        If lbSharpASword.SelectedItem <> "(None)" Then
            ASwordDmg = SwordDmgValues(lbSwordsA.SelectedItem) + (0.5 * SharpLevelsDmg(lbSharpASword.SelectedItem) + 0.5) + AStrength
        Else
            ASwordDmg = SwordDmgValues(lbSwordsA.SelectedItem) + AStrength
        End If
        If lbSharpAAxe.SelectedItem <> "(None)" Then
            AAxeDmg = AxeDmgValues(lbAxeA.SelectedItem) + (0.5 * SharpLevelsDmg(lbSharpAAxe.SelectedItem) + 0.5) + AStrength
        Else
            AAxeDmg = AxeDmgValues(lbAxeA.SelectedItem) + AStrength
        End If
        If cbBowA.Checked = True Then
            If lbPower.SelectedItem <> "(None)" Then
                ABowDmg = Math.Round((9 + ((0.25 * (PowerLevelValues(lbPower.SelectedItem) + 1) * 9))) * 2) / 2
            Else
                ABowDmg = 9
            End If
            lbPower.Enabled = True
        Else
            ABowDmg = 0
            lbPower.Enabled = False
        End If
        If CR < 200 Then
            lblCombatRating.ForeColor = Color.Red
        ElseIf CR < 400 Then
            lblCombatRating.ForeColor = Color.Orange
        Else
            lblCombatRating.ForeColor = Color.Green
        End If
        If Convert.ToInt32(lblArmorRating.Text) < 300 Then
            lblArmorRating.ForeColor = Color.Red
        ElseIf Convert.ToInt32(lblArmorRating.Text) < 650 Then
            lblArmorRating.ForeColor = Color.Orange
        Else
            lblArmorRating.ForeColor = Color.Green
        End If
        If Convert.ToInt32(lblOverallRating.Text) < 250 Then
            lblArmorRating.ForeColor = Color.Red
        ElseIf Convert.ToInt32(lblOverallRating.Text) < 475 Then
            lblArmorRating.ForeColor = Color.Orange
        Else
            lblArmorRating.ForeColor = Color.Green
        End If
    End Sub
    Private Sub lbSwordsA_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbSwordsA.SelectedIndexChanged
        If lbSwordsA.SelectedItem <> "(None)" Then
            lbSharpASword.Enabled = True
        Else
            ASwordDmg = 0
            lbSharpASword.Enabled = False
            lbSharpASword.SelectedItem = "(None)"
        End If
    End Sub
    Private Sub lbSharpASword_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbSharpASword.SelectedIndexChanged
        If lbSwordsA.SelectedItem = "(None)" Then
            ASwordDmg = 0
        End If
    End Sub
    Private Sub lbAxeA_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbAxeA.SelectedIndexChanged
        If lbAxeA.SelectedItem <> "(None)" Then
            lbSharpAAxe.Enabled = True
        Else
            AAxeDmg = 0
            lbSharpAAxe.Enabled = False
            lbSharpAAxe.SelectedItem = "(None)"
        End If
    End Sub
    Private Sub lbSharpAAxe_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbSharpAAxe.SelectedIndexChanged
        If lbAxeA.SelectedItem = "(None)" Then
            AAxeDmg = 0
        End If
    End Sub
    Private Sub cbStrengthIA_CheckedChanged(sender As Object, e As EventArgs) Handles cbStrengthIA.CheckedChanged
        If cbStrengthIA.Checked = True Then
            If cbStrengthIIA.Checked = True Then
                cbStrengthIIA.Checked = False
            End If
            AStrength = 3
        Else
            AStrength = 0
        End If
    End Sub
    Private Sub cbStrengthIIA_CheckedChanged(sender As Object, e As EventArgs) Handles cbStrengthIIA.CheckedChanged
        If cbStrengthIIA.Checked = True Then
            If cbStrengthIA.Checked = True Then
                cbStrengthIA.Checked = False
            End If
            AStrength = 6
        Else
            AStrength = 0
        End If
    End Sub
    Private Sub lbHelmA_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbHelmA.SelectedIndexChanged
        If lbHelmA.SelectedItem <> "(None)" Then
            AHelmDef = HelmDefValues(lbHelmA.SelectedItem)
            AHelmToughness = ToughnessValues(lbHelmA.SelectedItem)
            lbProtAHelm.Enabled = True
        Else
            AHelmDef = 0
            AHelmToughness = 0
            lbProtAHelm.Enabled = False
        End If
    End Sub
    Private Sub lbChestA_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbChestA.SelectedIndexChanged
        If lbChestA.SelectedItem <> "(None)" Then
            AChestDef = ChestDefValues(lbChestA.SelectedItem)
            AChestToughness = ToughnessValues(lbChestA.SelectedItem)
            lbProtAChest.Enabled = True
        Else
            AChestDef = 0
            AChestToughness = 0
            lbProtAChest.Enabled = False
        End If
    End Sub
    Private Sub lbLeggingsA_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbLeggingsA.SelectedIndexChanged
        If lbLeggingsA.SelectedItem <> "(None)" Then
            ALeggingsDef = LeggingsDefValues(lbLeggingsA.SelectedItem)
            ALeggingsToughness = ToughnessValues(lbLeggingsA.SelectedItem)
            lbProtALeggings.Enabled = True
        Else
            ALeggingsDef = 0
            ALeggingsToughness = 0
            lbProtALeggings.Enabled = False
        End If
    End Sub
    Private Sub lbBootsA_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbBootsA.SelectedIndexChanged
        If lbBootsA.SelectedItem <> "(None)" Then
            ABootsDef = BootsDefValues(lbBootsA.SelectedItem)
            ABootsToughness = ToughnessValues(lbBootsA.SelectedItem)
            lbProtABoots.Enabled = True
        Else
            ABootsDef = 0
            ABootsToughness = 0
            lbBootsA.Enabled = False
        End If
    End Sub
    Private Sub lbProtAHelm_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbProtAHelm.SelectedIndexChanged
        AHelmEPF = ProtLevelsEPF(lbProtAHelm.SelectedItem)
    End Sub
    Private Sub lbProtAChest_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbProtAChest.SelectedIndexChanged
        AChestEPF = ProtLevelsEPF(lbProtAChest.SelectedItem)
    End Sub
    Private Sub lbProtALeggings_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbProtALeggings.SelectedIndexChanged
        ALeggingsEPF = ProtLevelsEPF(lbProtALeggings.SelectedItem)
    End Sub
    Private Sub lbProtABoots_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbProtABoots.SelectedIndexChanged
        ABootsEPF = ProtLevelsEPF(lbProtABoots.SelectedItem)
    End Sub
End Class