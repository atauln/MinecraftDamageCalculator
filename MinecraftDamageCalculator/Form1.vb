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
    Dim ASwordDmg, AAxeDmg, AStrength, AHelmDef, AChestDef, ALeggingsDef, ABootsDef As Double
#End Region
    Private Sub HomePage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbSharpASword.SelectedItem = "(None)"
        lbSwordsA.SelectedItem = "(None)"
        lbSharpAAxe.SelectedItem = "(None)"
        lbAxeA.SelectedItem = "(None)"
    End Sub
    Private Sub tmrAll_Tick(sender As Object, e As EventArgs) Handles tmrAll.Tick
        lblAxeDmgA.Text = AAxeDmg.ToString + " (" + (AAxeDmg * 1.5).ToString + ")"
        lblSwordDmgA.Text = ASwordDmg.ToString + " (" + (ASwordDmg * 1.5).ToString + ")"
        lblHelmDefA.Text = AHelmDef
        lblChestDefA.Text = AChestDef
        lblLeggingsDefA.Text = ALeggingsDef
        lblBootsDefA.Text = ABootsDef
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
            lbProtAHelm.Enabled = True
        Else
            AHelmDef = 0
            lbProtAHelm.Enabled = False
        End If
    End Sub
    Private Sub lbChestA_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbChestA.SelectedIndexChanged
        If lbChestA.SelectedItem <> "(None)" Then
            AChestDef = ChestDefValues(lbChestA.SelectedItem)
        Else
            AChestDef = 0
        End If
    End Sub
    Private Sub lbLeggingsA_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbLeggingsA.SelectedIndexChanged
        If lbLeggingsA.SelectedItem <> "(None)" Then
            ALeggingsDef = LeggingsDefValues(lbLeggingsA.SelectedItem)
        Else
            ALeggingsDef = 0
        End If
    End Sub
    Private Sub lbBootsA_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbBootsA.SelectedIndexChanged
        If lbBootsA.SelectedItem <> "(None)" Then
            ABootsDef = BootsDefValues(lbBootsA.SelectedItem)
        Else
            ABootsDef = 0
        End If
    End Sub
End Class