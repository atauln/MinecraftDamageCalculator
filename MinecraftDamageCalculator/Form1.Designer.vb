﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class HomePage
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HomePage))
        Me.LblHelmA = New System.Windows.Forms.Label()
        Me.lbHelmA = New System.Windows.Forms.ListBox()
        Me.lbChestA = New System.Windows.Forms.ListBox()
        Me.lblChestA = New System.Windows.Forms.Label()
        Me.lbLeggingsA = New System.Windows.Forms.ListBox()
        Me.lblLeggingsA = New System.Windows.Forms.Label()
        Me.lbBootsA = New System.Windows.Forms.ListBox()
        Me.lblBootsA = New System.Windows.Forms.Label()
        Me.lbSwordsA = New System.Windows.Forms.ListBox()
        Me.lblSwordA = New System.Windows.Forms.Label()
        Me.lbAxeA = New System.Windows.Forms.ListBox()
        Me.lblAxeA = New System.Windows.Forms.Label()
        Me.lblBowA = New System.Windows.Forms.Label()
        Me.cbBowA = New System.Windows.Forms.CheckBox()
        Me.pnlSwordA = New System.Windows.Forms.Panel()
        Me.lblSwordDmgA = New System.Windows.Forms.Label()
        Me.lblSharpASword = New System.Windows.Forms.Label()
        Me.lbSharpASword = New System.Windows.Forms.ListBox()
        Me.tmrAll = New System.Windows.Forms.Timer(Me.components)
        Me.pnlAxeA = New System.Windows.Forms.Panel()
        Me.lblSharpAAxe = New System.Windows.Forms.Label()
        Me.lbSharpAAxe = New System.Windows.Forms.ListBox()
        Me.lblAxeDmgA = New System.Windows.Forms.Label()
        Me.pnlExtrasA = New System.Windows.Forms.Panel()
        Me.cbStrengthIIA = New System.Windows.Forms.CheckBox()
        Me.cbStrengthIA = New System.Windows.Forms.CheckBox()
        Me.pnlHelmA = New System.Windows.Forms.Panel()
        Me.lblHelmEPFA = New System.Windows.Forms.Label()
        Me.lblHelmDefA = New System.Windows.Forms.Label()
        Me.lblProtAHelm = New System.Windows.Forms.Label()
        Me.lbProtAHelm = New System.Windows.Forms.ListBox()
        Me.pnlChestA = New System.Windows.Forms.Panel()
        Me.lblChestEPFA = New System.Windows.Forms.Label()
        Me.lblProtAChest = New System.Windows.Forms.Label()
        Me.lbProtAChest = New System.Windows.Forms.ListBox()
        Me.lblChestDefA = New System.Windows.Forms.Label()
        Me.pnlLeggingsA = New System.Windows.Forms.Panel()
        Me.lblLeggingsEPFA = New System.Windows.Forms.Label()
        Me.lblProtALeggings = New System.Windows.Forms.Label()
        Me.lbProtALeggings = New System.Windows.Forms.ListBox()
        Me.lblLeggingsDefA = New System.Windows.Forms.Label()
        Me.pnlBootsA = New System.Windows.Forms.Panel()
        Me.lblBootsEPFA = New System.Windows.Forms.Label()
        Me.lblProtABoots = New System.Windows.Forms.Label()
        Me.lbProtABoots = New System.Windows.Forms.ListBox()
        Me.lblBootsDefA = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblArmorDRA = New System.Windows.Forms.Label()
        Me.lblEPFA = New System.Windows.Forms.Label()
        Me.lblToughnessA = New System.Windows.Forms.Label()
        Me.lblDefPointsA = New System.Windows.Forms.Label()
        Me.pnlBowA = New System.Windows.Forms.Panel()
        Me.lblPowerA = New System.Windows.Forms.Label()
        Me.lbPower = New System.Windows.Forms.ListBox()
        Me.lblBowDmgA = New System.Windows.Forms.Label()
        Me.lblCombatRating = New System.Windows.Forms.Label()
        Me.lblArmorRating = New System.Windows.Forms.Label()
        Me.lblOverallRating = New System.Windows.Forms.Label()
        Me.pnlSwordA.SuspendLayout()
        Me.pnlAxeA.SuspendLayout()
        Me.pnlExtrasA.SuspendLayout()
        Me.pnlHelmA.SuspendLayout()
        Me.pnlChestA.SuspendLayout()
        Me.pnlLeggingsA.SuspendLayout()
        Me.pnlBootsA.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.pnlBowA.SuspendLayout()
        Me.SuspendLayout()
        '
        'LblHelmA
        '
        Me.LblHelmA.AutoSize = True
        Me.LblHelmA.Location = New System.Drawing.Point(9, 10)
        Me.LblHelmA.Name = "LblHelmA"
        Me.LblHelmA.Size = New System.Drawing.Size(43, 13)
        Me.LblHelmA.TabIndex = 0
        Me.LblHelmA.Text = "Helmet:"
        '
        'lbHelmA
        '
        Me.lbHelmA.FormattingEnabled = True
        Me.lbHelmA.Items.AddRange(New Object() {"(None)", "Leather", "Chainmail", "Turtle", "Iron", "Gold", "Diamond", "Netherite"})
        Me.lbHelmA.Location = New System.Drawing.Point(9, 26)
        Me.lbHelmA.Name = "lbHelmA"
        Me.lbHelmA.Size = New System.Drawing.Size(163, 43)
        Me.lbHelmA.TabIndex = 1
        '
        'lbChestA
        '
        Me.lbChestA.FormattingEnabled = True
        Me.lbChestA.Items.AddRange(New Object() {"(None/Elytra)", "Leather", "Chainmail", "Iron", "Gold", "Diamond", "Netherite"})
        Me.lbChestA.Location = New System.Drawing.Point(9, 26)
        Me.lbChestA.Name = "lbChestA"
        Me.lbChestA.Size = New System.Drawing.Size(163, 43)
        Me.lbChestA.TabIndex = 3
        '
        'lblChestA
        '
        Me.lblChestA.AutoSize = True
        Me.lblChestA.Location = New System.Drawing.Point(8, 10)
        Me.lblChestA.Name = "lblChestA"
        Me.lblChestA.Size = New System.Drawing.Size(60, 13)
        Me.lblChestA.TabIndex = 2
        Me.lblChestA.Text = "Chestplate:"
        '
        'lbLeggingsA
        '
        Me.lbLeggingsA.FormattingEnabled = True
        Me.lbLeggingsA.Items.AddRange(New Object() {"(None)", "Leather", "Chainmail", "Iron", "Gold", "Diamond", "Netherite"})
        Me.lbLeggingsA.Location = New System.Drawing.Point(9, 26)
        Me.lbLeggingsA.Name = "lbLeggingsA"
        Me.lbLeggingsA.Size = New System.Drawing.Size(163, 43)
        Me.lbLeggingsA.TabIndex = 5
        '
        'lblLeggingsA
        '
        Me.lblLeggingsA.AutoSize = True
        Me.lblLeggingsA.Location = New System.Drawing.Point(6, 10)
        Me.lblLeggingsA.Name = "lblLeggingsA"
        Me.lblLeggingsA.Size = New System.Drawing.Size(53, 13)
        Me.lblLeggingsA.TabIndex = 4
        Me.lblLeggingsA.Text = "Leggings:"
        '
        'lbBootsA
        '
        Me.lbBootsA.FormattingEnabled = True
        Me.lbBootsA.Items.AddRange(New Object() {"(None)", "Leather", "Chainmail", "Iron", "Gold", "Diamond", "Netherite"})
        Me.lbBootsA.Location = New System.Drawing.Point(9, 26)
        Me.lbBootsA.Name = "lbBootsA"
        Me.lbBootsA.Size = New System.Drawing.Size(163, 43)
        Me.lbBootsA.TabIndex = 7
        '
        'lblBootsA
        '
        Me.lblBootsA.AutoSize = True
        Me.lblBootsA.Location = New System.Drawing.Point(6, 10)
        Me.lblBootsA.Name = "lblBootsA"
        Me.lblBootsA.Size = New System.Drawing.Size(37, 13)
        Me.lblBootsA.TabIndex = 6
        Me.lblBootsA.Text = "Boots:"
        '
        'lbSwordsA
        '
        Me.lbSwordsA.FormattingEnabled = True
        Me.lbSwordsA.Items.AddRange(New Object() {"(None)", "Wood", "Stone", "Iron", "Gold", "Diamond", "Netherite"})
        Me.lbSwordsA.Location = New System.Drawing.Point(9, 28)
        Me.lbSwordsA.Name = "lbSwordsA"
        Me.lbSwordsA.Size = New System.Drawing.Size(163, 43)
        Me.lbSwordsA.TabIndex = 9
        '
        'lblSwordA
        '
        Me.lblSwordA.AutoSize = True
        Me.lblSwordA.Location = New System.Drawing.Point(6, 12)
        Me.lblSwordA.Name = "lblSwordA"
        Me.lblSwordA.Size = New System.Drawing.Size(40, 13)
        Me.lblSwordA.TabIndex = 8
        Me.lblSwordA.Text = "Sword:"
        '
        'lbAxeA
        '
        Me.lbAxeA.FormattingEnabled = True
        Me.lbAxeA.Items.AddRange(New Object() {"(None)", "Wood", "Stone", "Iron", "Gold", "Diamond", "Netherite"})
        Me.lbAxeA.Location = New System.Drawing.Point(9, 28)
        Me.lbAxeA.Name = "lbAxeA"
        Me.lbAxeA.Size = New System.Drawing.Size(163, 43)
        Me.lbAxeA.TabIndex = 11
        '
        'lblAxeA
        '
        Me.lblAxeA.AutoSize = True
        Me.lblAxeA.Location = New System.Drawing.Point(6, 12)
        Me.lblAxeA.Name = "lblAxeA"
        Me.lblAxeA.Size = New System.Drawing.Size(28, 13)
        Me.lblAxeA.TabIndex = 10
        Me.lblAxeA.Text = "Axe:"
        '
        'lblBowA
        '
        Me.lblBowA.AutoSize = True
        Me.lblBowA.Location = New System.Drawing.Point(16, 12)
        Me.lblBowA.Name = "lblBowA"
        Me.lblBowA.Size = New System.Drawing.Size(34, 13)
        Me.lblBowA.TabIndex = 12
        Me.lblBowA.Text = "Bow?"
        '
        'cbBowA
        '
        Me.cbBowA.AutoSize = True
        Me.cbBowA.Location = New System.Drawing.Point(34, 28)
        Me.cbBowA.Name = "cbBowA"
        Me.cbBowA.Size = New System.Drawing.Size(44, 17)
        Me.cbBowA.TabIndex = 13
        Me.cbBowA.Text = "Yes"
        Me.cbBowA.UseVisualStyleBackColor = True
        '
        'pnlSwordA
        '
        Me.pnlSwordA.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pnlSwordA.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.pnlSwordA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlSwordA.Controls.Add(Me.lblSwordDmgA)
        Me.pnlSwordA.Controls.Add(Me.lblSharpASword)
        Me.pnlSwordA.Controls.Add(Me.lbSharpASword)
        Me.pnlSwordA.Controls.Add(Me.lblSwordA)
        Me.pnlSwordA.Controls.Add(Me.lbSwordsA)
        Me.pnlSwordA.Location = New System.Drawing.Point(6, 10)
        Me.pnlSwordA.Name = "pnlSwordA"
        Me.pnlSwordA.Size = New System.Drawing.Size(183, 153)
        Me.pnlSwordA.TabIndex = 14
        '
        'lblSwordDmgA
        '
        Me.lblSwordDmgA.AutoSize = True
        Me.lblSwordDmgA.Location = New System.Drawing.Point(52, 12)
        Me.lblSwordDmgA.Name = "lblSwordDmgA"
        Me.lblSwordDmgA.Size = New System.Drawing.Size(28, 13)
        Me.lblSwordDmgA.TabIndex = 15
        Me.lblSwordDmgA.Text = "0 (0)"
        '
        'lblSharpASword
        '
        Me.lblSharpASword.AutoSize = True
        Me.lblSharpASword.Location = New System.Drawing.Point(6, 76)
        Me.lblSharpASword.Name = "lblSharpASword"
        Me.lblSharpASword.Size = New System.Drawing.Size(60, 13)
        Me.lblSharpASword.TabIndex = 10
        Me.lblSharpASword.Text = "Sharpness:"
        '
        'lbSharpASword
        '
        Me.lbSharpASword.FormattingEnabled = True
        Me.lbSharpASword.Items.AddRange(New Object() {"(None)", "Sharp I", "Sharp II", "Sharp III", "Sharp IV", "Sharp V"})
        Me.lbSharpASword.Location = New System.Drawing.Point(9, 92)
        Me.lbSharpASword.Name = "lbSharpASword"
        Me.lbSharpASword.Size = New System.Drawing.Size(163, 43)
        Me.lbSharpASword.TabIndex = 11
        '
        'tmrAll
        '
        Me.tmrAll.Enabled = True
        Me.tmrAll.Interval = 50
        '
        'pnlAxeA
        '
        Me.pnlAxeA.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pnlAxeA.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.pnlAxeA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlAxeA.Controls.Add(Me.lblSharpAAxe)
        Me.pnlAxeA.Controls.Add(Me.lbSharpAAxe)
        Me.pnlAxeA.Controls.Add(Me.lblAxeDmgA)
        Me.pnlAxeA.Controls.Add(Me.lbAxeA)
        Me.pnlAxeA.Controls.Add(Me.lblAxeA)
        Me.pnlAxeA.Location = New System.Drawing.Point(195, 10)
        Me.pnlAxeA.Name = "pnlAxeA"
        Me.pnlAxeA.Size = New System.Drawing.Size(183, 153)
        Me.pnlAxeA.TabIndex = 15
        '
        'lblSharpAAxe
        '
        Me.lblSharpAAxe.AutoSize = True
        Me.lblSharpAAxe.Location = New System.Drawing.Point(6, 76)
        Me.lblSharpAAxe.Name = "lblSharpAAxe"
        Me.lblSharpAAxe.Size = New System.Drawing.Size(60, 13)
        Me.lblSharpAAxe.TabIndex = 17
        Me.lblSharpAAxe.Text = "Sharpness:"
        '
        'lbSharpAAxe
        '
        Me.lbSharpAAxe.FormattingEnabled = True
        Me.lbSharpAAxe.Items.AddRange(New Object() {"(None)", "Sharp I", "Sharp II", "Sharp III", "Sharp IV", "Sharp V"})
        Me.lbSharpAAxe.Location = New System.Drawing.Point(9, 92)
        Me.lbSharpAAxe.Name = "lbSharpAAxe"
        Me.lbSharpAAxe.Size = New System.Drawing.Size(163, 43)
        Me.lbSharpAAxe.TabIndex = 18
        '
        'lblAxeDmgA
        '
        Me.lblAxeDmgA.AutoSize = True
        Me.lblAxeDmgA.Location = New System.Drawing.Point(40, 12)
        Me.lblAxeDmgA.Name = "lblAxeDmgA"
        Me.lblAxeDmgA.Size = New System.Drawing.Size(28, 13)
        Me.lblAxeDmgA.TabIndex = 16
        Me.lblAxeDmgA.Text = "0 (0)"
        '
        'pnlExtrasA
        '
        Me.pnlExtrasA.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pnlExtrasA.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.pnlExtrasA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlExtrasA.Controls.Add(Me.cbStrengthIIA)
        Me.pnlExtrasA.Controls.Add(Me.cbStrengthIA)
        Me.pnlExtrasA.Location = New System.Drawing.Point(384, 169)
        Me.pnlExtrasA.Name = "pnlExtrasA"
        Me.pnlExtrasA.Size = New System.Drawing.Size(183, 153)
        Me.pnlExtrasA.TabIndex = 16
        '
        'cbStrengthIIA
        '
        Me.cbStrengthIIA.AutoSize = True
        Me.cbStrengthIIA.Location = New System.Drawing.Point(14, 28)
        Me.cbStrengthIIA.Name = "cbStrengthIIA"
        Me.cbStrengthIIA.Size = New System.Drawing.Size(81, 17)
        Me.cbStrengthIIA.TabIndex = 18
        Me.cbStrengthIIA.Text = "Strength II?"
        Me.cbStrengthIIA.UseVisualStyleBackColor = True
        '
        'cbStrengthIA
        '
        Me.cbStrengthIA.AutoSize = True
        Me.cbStrengthIA.Location = New System.Drawing.Point(14, 12)
        Me.cbStrengthIA.Name = "cbStrengthIA"
        Me.cbStrengthIA.Size = New System.Drawing.Size(78, 17)
        Me.cbStrengthIA.TabIndex = 17
        Me.cbStrengthIA.Text = "Strength I?"
        Me.cbStrengthIA.UseVisualStyleBackColor = True
        '
        'pnlHelmA
        '
        Me.pnlHelmA.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pnlHelmA.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.pnlHelmA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlHelmA.Controls.Add(Me.lblHelmEPFA)
        Me.pnlHelmA.Controls.Add(Me.lblHelmDefA)
        Me.pnlHelmA.Controls.Add(Me.lblProtAHelm)
        Me.pnlHelmA.Controls.Add(Me.lbProtAHelm)
        Me.pnlHelmA.Controls.Add(Me.lbHelmA)
        Me.pnlHelmA.Controls.Add(Me.LblHelmA)
        Me.pnlHelmA.Location = New System.Drawing.Point(6, 169)
        Me.pnlHelmA.Name = "pnlHelmA"
        Me.pnlHelmA.Size = New System.Drawing.Size(183, 153)
        Me.pnlHelmA.TabIndex = 17
        '
        'lblHelmEPFA
        '
        Me.lblHelmEPFA.AutoSize = True
        Me.lblHelmEPFA.Location = New System.Drawing.Point(73, 78)
        Me.lblHelmEPFA.Name = "lblHelmEPFA"
        Me.lblHelmEPFA.Size = New System.Drawing.Size(13, 13)
        Me.lblHelmEPFA.TabIndex = 21
        Me.lblHelmEPFA.Text = "0"
        '
        'lblHelmDefA
        '
        Me.lblHelmDefA.AutoSize = True
        Me.lblHelmDefA.Location = New System.Drawing.Point(58, 10)
        Me.lblHelmDefA.Name = "lblHelmDefA"
        Me.lblHelmDefA.Size = New System.Drawing.Size(13, 13)
        Me.lblHelmDefA.TabIndex = 16
        Me.lblHelmDefA.Text = "0"
        '
        'lblProtAHelm
        '
        Me.lblProtAHelm.AutoSize = True
        Me.lblProtAHelm.Location = New System.Drawing.Point(9, 78)
        Me.lblProtAHelm.Name = "lblProtAHelm"
        Me.lblProtAHelm.Size = New System.Drawing.Size(58, 13)
        Me.lblProtAHelm.TabIndex = 12
        Me.lblProtAHelm.Text = "Protection:"
        '
        'lbProtAHelm
        '
        Me.lbProtAHelm.FormattingEnabled = True
        Me.lbProtAHelm.Items.AddRange(New Object() {"(None)", "Prot I", "Prot II", "Prot III", "Prot IV"})
        Me.lbProtAHelm.Location = New System.Drawing.Point(9, 94)
        Me.lbProtAHelm.Name = "lbProtAHelm"
        Me.lbProtAHelm.Size = New System.Drawing.Size(163, 43)
        Me.lbProtAHelm.TabIndex = 13
        '
        'pnlChestA
        '
        Me.pnlChestA.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pnlChestA.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.pnlChestA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlChestA.Controls.Add(Me.lblChestEPFA)
        Me.pnlChestA.Controls.Add(Me.lblProtAChest)
        Me.pnlChestA.Controls.Add(Me.lbProtAChest)
        Me.pnlChestA.Controls.Add(Me.lblChestDefA)
        Me.pnlChestA.Controls.Add(Me.lbChestA)
        Me.pnlChestA.Controls.Add(Me.lblChestA)
        Me.pnlChestA.Location = New System.Drawing.Point(195, 169)
        Me.pnlChestA.Name = "pnlChestA"
        Me.pnlChestA.Size = New System.Drawing.Size(183, 153)
        Me.pnlChestA.TabIndex = 18
        '
        'lblChestEPFA
        '
        Me.lblChestEPFA.AutoSize = True
        Me.lblChestEPFA.Location = New System.Drawing.Point(73, 78)
        Me.lblChestEPFA.Name = "lblChestEPFA"
        Me.lblChestEPFA.Size = New System.Drawing.Size(13, 13)
        Me.lblChestEPFA.TabIndex = 22
        Me.lblChestEPFA.Text = "0"
        '
        'lblProtAChest
        '
        Me.lblProtAChest.AutoSize = True
        Me.lblProtAChest.Location = New System.Drawing.Point(9, 78)
        Me.lblProtAChest.Name = "lblProtAChest"
        Me.lblProtAChest.Size = New System.Drawing.Size(58, 13)
        Me.lblProtAChest.TabIndex = 18
        Me.lblProtAChest.Text = "Protection:"
        '
        'lbProtAChest
        '
        Me.lbProtAChest.FormattingEnabled = True
        Me.lbProtAChest.Items.AddRange(New Object() {"(None)", "Prot I", "Prot II", "Prot III", "Prot IV"})
        Me.lbProtAChest.Location = New System.Drawing.Point(9, 94)
        Me.lbProtAChest.Name = "lbProtAChest"
        Me.lbProtAChest.Size = New System.Drawing.Size(163, 43)
        Me.lbProtAChest.TabIndex = 19
        '
        'lblChestDefA
        '
        Me.lblChestDefA.AutoSize = True
        Me.lblChestDefA.Location = New System.Drawing.Point(74, 10)
        Me.lblChestDefA.Name = "lblChestDefA"
        Me.lblChestDefA.Size = New System.Drawing.Size(13, 13)
        Me.lblChestDefA.TabIndex = 17
        Me.lblChestDefA.Text = "0"
        '
        'pnlLeggingsA
        '
        Me.pnlLeggingsA.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pnlLeggingsA.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.pnlLeggingsA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlLeggingsA.Controls.Add(Me.lblLeggingsEPFA)
        Me.pnlLeggingsA.Controls.Add(Me.lblProtALeggings)
        Me.pnlLeggingsA.Controls.Add(Me.lbProtALeggings)
        Me.pnlLeggingsA.Controls.Add(Me.lblLeggingsDefA)
        Me.pnlLeggingsA.Controls.Add(Me.lbLeggingsA)
        Me.pnlLeggingsA.Controls.Add(Me.lblLeggingsA)
        Me.pnlLeggingsA.Location = New System.Drawing.Point(6, 328)
        Me.pnlLeggingsA.Name = "pnlLeggingsA"
        Me.pnlLeggingsA.Size = New System.Drawing.Size(183, 153)
        Me.pnlLeggingsA.TabIndex = 19
        '
        'lblLeggingsEPFA
        '
        Me.lblLeggingsEPFA.AutoSize = True
        Me.lblLeggingsEPFA.Location = New System.Drawing.Point(73, 78)
        Me.lblLeggingsEPFA.Name = "lblLeggingsEPFA"
        Me.lblLeggingsEPFA.Size = New System.Drawing.Size(13, 13)
        Me.lblLeggingsEPFA.TabIndex = 22
        Me.lblLeggingsEPFA.Text = "0"
        '
        'lblProtALeggings
        '
        Me.lblProtALeggings.AutoSize = True
        Me.lblProtALeggings.Location = New System.Drawing.Point(9, 78)
        Me.lblProtALeggings.Name = "lblProtALeggings"
        Me.lblProtALeggings.Size = New System.Drawing.Size(58, 13)
        Me.lblProtALeggings.TabIndex = 18
        Me.lblProtALeggings.Text = "Protection:"
        '
        'lbProtALeggings
        '
        Me.lbProtALeggings.FormattingEnabled = True
        Me.lbProtALeggings.Items.AddRange(New Object() {"(None)", "Prot I", "Prot II", "Prot III", "Prot IV"})
        Me.lbProtALeggings.Location = New System.Drawing.Point(9, 94)
        Me.lbProtALeggings.Name = "lbProtALeggings"
        Me.lbProtALeggings.Size = New System.Drawing.Size(163, 43)
        Me.lbProtALeggings.TabIndex = 19
        '
        'lblLeggingsDefA
        '
        Me.lblLeggingsDefA.AutoSize = True
        Me.lblLeggingsDefA.Location = New System.Drawing.Point(65, 10)
        Me.lblLeggingsDefA.Name = "lblLeggingsDefA"
        Me.lblLeggingsDefA.Size = New System.Drawing.Size(13, 13)
        Me.lblLeggingsDefA.TabIndex = 17
        Me.lblLeggingsDefA.Text = "0"
        '
        'pnlBootsA
        '
        Me.pnlBootsA.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pnlBootsA.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.pnlBootsA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlBootsA.Controls.Add(Me.lblBootsEPFA)
        Me.pnlBootsA.Controls.Add(Me.lblProtABoots)
        Me.pnlBootsA.Controls.Add(Me.lbProtABoots)
        Me.pnlBootsA.Controls.Add(Me.lblBootsDefA)
        Me.pnlBootsA.Controls.Add(Me.lbBootsA)
        Me.pnlBootsA.Controls.Add(Me.lblBootsA)
        Me.pnlBootsA.Location = New System.Drawing.Point(195, 328)
        Me.pnlBootsA.Name = "pnlBootsA"
        Me.pnlBootsA.Size = New System.Drawing.Size(183, 153)
        Me.pnlBootsA.TabIndex = 20
        '
        'lblBootsEPFA
        '
        Me.lblBootsEPFA.AutoSize = True
        Me.lblBootsEPFA.Location = New System.Drawing.Point(73, 78)
        Me.lblBootsEPFA.Name = "lblBootsEPFA"
        Me.lblBootsEPFA.Size = New System.Drawing.Size(13, 13)
        Me.lblBootsEPFA.TabIndex = 22
        Me.lblBootsEPFA.Text = "0"
        '
        'lblProtABoots
        '
        Me.lblProtABoots.AutoSize = True
        Me.lblProtABoots.Location = New System.Drawing.Point(9, 78)
        Me.lblProtABoots.Name = "lblProtABoots"
        Me.lblProtABoots.Size = New System.Drawing.Size(58, 13)
        Me.lblProtABoots.TabIndex = 18
        Me.lblProtABoots.Text = "Protection:"
        '
        'lbProtABoots
        '
        Me.lbProtABoots.FormattingEnabled = True
        Me.lbProtABoots.Items.AddRange(New Object() {"(None)", "Prot I", "Prot II", "Prot III", "Prot IV"})
        Me.lbProtABoots.Location = New System.Drawing.Point(9, 94)
        Me.lbProtABoots.Name = "lbProtABoots"
        Me.lbProtABoots.Size = New System.Drawing.Size(163, 43)
        Me.lbProtABoots.TabIndex = 19
        '
        'lblBootsDefA
        '
        Me.lblBootsDefA.AutoSize = True
        Me.lblBootsDefA.Location = New System.Drawing.Point(49, 10)
        Me.lblBootsDefA.Name = "lblBootsDefA"
        Me.lblBootsDefA.Size = New System.Drawing.Size(13, 13)
        Me.lblBootsDefA.TabIndex = 17
        Me.lblBootsDefA.Text = "0"
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lblArmorDRA)
        Me.Panel1.Controls.Add(Me.lblEPFA)
        Me.Panel1.Controls.Add(Me.lblToughnessA)
        Me.Panel1.Controls.Add(Me.lblDefPointsA)
        Me.Panel1.Location = New System.Drawing.Point(384, 328)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(183, 153)
        Me.Panel1.TabIndex = 19
        '
        'lblArmorDRA
        '
        Me.lblArmorDRA.AutoSize = True
        Me.lblArmorDRA.Location = New System.Drawing.Point(11, 49)
        Me.lblArmorDRA.Name = "lblArmorDRA"
        Me.lblArmorDRA.Size = New System.Drawing.Size(82, 13)
        Me.lblArmorDRA.TabIndex = 24
        Me.lblArmorDRA.Text = "Armor DR (%): 0"
        '
        'lblEPFA
        '
        Me.lblEPFA.AutoSize = True
        Me.lblEPFA.Location = New System.Drawing.Point(11, 36)
        Me.lblEPFA.Name = "lblEPFA"
        Me.lblEPFA.Size = New System.Drawing.Size(39, 13)
        Me.lblEPFA.TabIndex = 23
        Me.lblEPFA.Text = "EPF: 0"
        '
        'lblToughnessA
        '
        Me.lblToughnessA.AutoSize = True
        Me.lblToughnessA.Location = New System.Drawing.Point(11, 23)
        Me.lblToughnessA.Name = "lblToughnessA"
        Me.lblToughnessA.Size = New System.Drawing.Size(104, 13)
        Me.lblToughnessA.TabIndex = 22
        Me.lblToughnessA.Text = "Toughness Points: 0"
        '
        'lblDefPointsA
        '
        Me.lblDefPointsA.AutoSize = True
        Me.lblDefPointsA.Location = New System.Drawing.Point(11, 10)
        Me.lblDefPointsA.Name = "lblDefPointsA"
        Me.lblDefPointsA.Size = New System.Drawing.Size(91, 13)
        Me.lblDefPointsA.TabIndex = 21
        Me.lblDefPointsA.Text = "Defense Points: 0"
        '
        'pnlBowA
        '
        Me.pnlBowA.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pnlBowA.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.pnlBowA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlBowA.Controls.Add(Me.lblPowerA)
        Me.pnlBowA.Controls.Add(Me.lbPower)
        Me.pnlBowA.Controls.Add(Me.lblBowDmgA)
        Me.pnlBowA.Controls.Add(Me.cbBowA)
        Me.pnlBowA.Controls.Add(Me.lblBowA)
        Me.pnlBowA.Location = New System.Drawing.Point(384, 10)
        Me.pnlBowA.Name = "pnlBowA"
        Me.pnlBowA.Size = New System.Drawing.Size(183, 153)
        Me.pnlBowA.TabIndex = 19
        '
        'lblPowerA
        '
        Me.lblPowerA.AutoSize = True
        Me.lblPowerA.Location = New System.Drawing.Point(11, 76)
        Me.lblPowerA.Name = "lblPowerA"
        Me.lblPowerA.Size = New System.Drawing.Size(40, 13)
        Me.lblPowerA.TabIndex = 19
        Me.lblPowerA.Text = "Power:"
        '
        'lbPower
        '
        Me.lbPower.FormattingEnabled = True
        Me.lbPower.Items.AddRange(New Object() {"(None)", "Power I", "Power II", "Power III", "Power IV", "Power V"})
        Me.lbPower.Location = New System.Drawing.Point(14, 92)
        Me.lbPower.Name = "lbPower"
        Me.lbPower.Size = New System.Drawing.Size(163, 43)
        Me.lbPower.TabIndex = 20
        '
        'lblBowDmgA
        '
        Me.lblBowDmgA.AutoSize = True
        Me.lblBowDmgA.Location = New System.Drawing.Point(56, 12)
        Me.lblBowDmgA.Name = "lblBowDmgA"
        Me.lblBowDmgA.Size = New System.Drawing.Size(28, 13)
        Me.lblBowDmgA.TabIndex = 17
        Me.lblBowDmgA.Text = "0 (0)"
        '
        'lblCombatRating
        '
        Me.lblCombatRating.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblCombatRating.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCombatRating.Font = New System.Drawing.Font("Microsoft Sans Serif", 40.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCombatRating.Location = New System.Drawing.Point(573, 10)
        Me.lblCombatRating.Name = "lblCombatRating"
        Me.lblCombatRating.Size = New System.Drawing.Size(183, 153)
        Me.lblCombatRating.TabIndex = 21
        Me.lblCombatRating.Text = "0"
        Me.lblCombatRating.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblArmorRating
        '
        Me.lblArmorRating.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblArmorRating.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblArmorRating.Font = New System.Drawing.Font("Microsoft Sans Serif", 40.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblArmorRating.Location = New System.Drawing.Point(573, 169)
        Me.lblArmorRating.Name = "lblArmorRating"
        Me.lblArmorRating.Size = New System.Drawing.Size(183, 153)
        Me.lblArmorRating.TabIndex = 22
        Me.lblArmorRating.Text = "0"
        Me.lblArmorRating.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblOverallRating
        '
        Me.lblOverallRating.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblOverallRating.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblOverallRating.Font = New System.Drawing.Font("Microsoft Sans Serif", 40.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOverallRating.Location = New System.Drawing.Point(573, 328)
        Me.lblOverallRating.Name = "lblOverallRating"
        Me.lblOverallRating.Size = New System.Drawing.Size(183, 153)
        Me.lblOverallRating.TabIndex = 23
        Me.lblOverallRating.Text = "0"
        Me.lblOverallRating.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'HomePage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(763, 493)
        Me.Controls.Add(Me.lblOverallRating)
        Me.Controls.Add(Me.lblArmorRating)
        Me.Controls.Add(Me.lblCombatRating)
        Me.Controls.Add(Me.pnlBowA)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pnlBootsA)
        Me.Controls.Add(Me.pnlLeggingsA)
        Me.Controls.Add(Me.pnlChestA)
        Me.Controls.Add(Me.pnlHelmA)
        Me.Controls.Add(Me.pnlExtrasA)
        Me.Controls.Add(Me.pnlAxeA)
        Me.Controls.Add(Me.pnlSwordA)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "HomePage"
        Me.Text = "Minecraft Damage Calculator (1.16.*)"
        Me.pnlSwordA.ResumeLayout(False)
        Me.pnlSwordA.PerformLayout()
        Me.pnlAxeA.ResumeLayout(False)
        Me.pnlAxeA.PerformLayout()
        Me.pnlExtrasA.ResumeLayout(False)
        Me.pnlExtrasA.PerformLayout()
        Me.pnlHelmA.ResumeLayout(False)
        Me.pnlHelmA.PerformLayout()
        Me.pnlChestA.ResumeLayout(False)
        Me.pnlChestA.PerformLayout()
        Me.pnlLeggingsA.ResumeLayout(False)
        Me.pnlLeggingsA.PerformLayout()
        Me.pnlBootsA.ResumeLayout(False)
        Me.pnlBootsA.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.pnlBowA.ResumeLayout(False)
        Me.pnlBowA.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LblHelmA As Label
    Friend WithEvents lbHelmA As ListBox
    Friend WithEvents lbChestA As ListBox
    Friend WithEvents lblChestA As Label
    Friend WithEvents lbLeggingsA As ListBox
    Friend WithEvents lblLeggingsA As Label
    Friend WithEvents lbBootsA As ListBox
    Friend WithEvents lblBootsA As Label
    Friend WithEvents lbSwordsA As ListBox
    Friend WithEvents lblSwordA As Label
    Friend WithEvents lbAxeA As ListBox
    Friend WithEvents lblAxeA As Label
    Friend WithEvents lblBowA As Label
    Friend WithEvents cbBowA As CheckBox
    Friend WithEvents pnlSwordA As Panel
    Friend WithEvents lblSwordDmgA As Label
    Friend WithEvents lblSharpASword As Label
    Friend WithEvents lbSharpASword As ListBox
    Friend WithEvents tmrAll As Timer
    Friend WithEvents pnlAxeA As Panel
    Friend WithEvents lblAxeDmgA As Label
    Friend WithEvents lblSharpAAxe As Label
    Friend WithEvents lbSharpAAxe As ListBox
    Friend WithEvents pnlExtrasA As Panel
    Friend WithEvents pnlHelmA As Panel
    Friend WithEvents pnlChestA As Panel
    Friend WithEvents lblProtAHelm As Label
    Friend WithEvents lbProtAHelm As ListBox
    Friend WithEvents lblHelmDefA As Label
    Friend WithEvents lblChestDefA As Label
    Friend WithEvents pnlLeggingsA As Panel
    Friend WithEvents lblLeggingsDefA As Label
    Friend WithEvents pnlBootsA As Panel
    Friend WithEvents lblBootsDefA As Label
    Friend WithEvents lblHelmEPFA As Label
    Friend WithEvents lblChestEPFA As Label
    Friend WithEvents lblProtAChest As Label
    Friend WithEvents lbProtAChest As ListBox
    Friend WithEvents lblLeggingsEPFA As Label
    Friend WithEvents lblProtALeggings As Label
    Friend WithEvents lbProtALeggings As ListBox
    Friend WithEvents lblBootsEPFA As Label
    Friend WithEvents lblProtABoots As Label
    Friend WithEvents lbProtABoots As ListBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblEPFA As Label
    Friend WithEvents lblToughnessA As Label
    Friend WithEvents lblDefPointsA As Label
    Friend WithEvents lblArmorDRA As Label
    Friend WithEvents cbStrengthIIA As CheckBox
    Friend WithEvents cbStrengthIA As CheckBox
    Friend WithEvents pnlBowA As Panel
    Friend WithEvents lblBowDmgA As Label
    Friend WithEvents lblPowerA As Label
    Friend WithEvents lbPower As ListBox
    Friend WithEvents lblCombatRating As Label
    Friend WithEvents lblArmorRating As Label
    Friend WithEvents lblOverallRating As Label
End Class
