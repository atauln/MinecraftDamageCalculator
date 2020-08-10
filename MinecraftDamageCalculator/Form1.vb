Public Class HomePage
#Region "Global Variables"
    Dim SwordDmgValues = New Dictionary(Of String, Integer) From {{"Wood", 4}, {"Stone", 5}, {"Gold", 4}, {"Iron", 6}, {"Diamond", 7}, {"Netherite", 8}, {"(None)", 0}}
    Dim SharpLevelsDmg = New Dictionary(Of String, Integer) From {{"Sharp I", 1}, {"Sharp II", 2}, {"Sharp III", 3}, {"Sharp IV", 4}, {"Sharp V", 5}, {"None", 0}}
    Dim ASwordDmg, AAxeDmg, AStrength As Double
    Dim AxeDmgValues = New Dictionary(Of String, Integer) From {{"Wood", 7}, {"Stone", 9}, {"Iron", 9}, {"Diamond", 9}, {"Gold", 7}, {"Netherite", 10}, {"(None)", 0}}
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
End Class