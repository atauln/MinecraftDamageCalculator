<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HomePage
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
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
        Me.lblProtAHelm = New System.Windows.Forms.Label()
        Me.lbProtAHelm = New System.Windows.Forms.ListBox()
        Me.pnlChestA = New System.Windows.Forms.Panel()
        Me.pnlSwordA.SuspendLayout()
        Me.pnlAxeA.SuspendLayout()
        Me.pnlExtrasA.SuspendLayout()
        Me.pnlHelmA.SuspendLayout()
        Me.pnlChestA.SuspendLayout()
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
        Me.lbLeggingsA.Location = New System.Drawing.Point(86, 595)
        Me.lbLeggingsA.Name = "lbLeggingsA"
        Me.lbLeggingsA.Size = New System.Drawing.Size(163, 43)
        Me.lbLeggingsA.TabIndex = 5
        '
        'lblLeggingsA
        '
        Me.lblLeggingsA.AutoSize = True
        Me.lblLeggingsA.Location = New System.Drawing.Point(83, 579)
        Me.lblLeggingsA.Name = "lblLeggingsA"
        Me.lblLeggingsA.Size = New System.Drawing.Size(53, 13)
        Me.lblLeggingsA.TabIndex = 4
        Me.lblLeggingsA.Text = "Leggings:"
        '
        'lbBootsA
        '
        Me.lbBootsA.FormattingEnabled = True
        Me.lbBootsA.Items.AddRange(New Object() {"(None)", "Leather", "Chainmail", "Turtle", "Gold", "Diamond", "Netherite"})
        Me.lbBootsA.Location = New System.Drawing.Point(320, 508)
        Me.lbBootsA.Name = "lbBootsA"
        Me.lbBootsA.Size = New System.Drawing.Size(163, 43)
        Me.lbBootsA.TabIndex = 7
        '
        'lblBootsA
        '
        Me.lblBootsA.AutoSize = True
        Me.lblBootsA.Location = New System.Drawing.Point(317, 492)
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
        Me.lblBowA.Location = New System.Drawing.Point(511, 401)
        Me.lblBowA.Name = "lblBowA"
        Me.lblBowA.Size = New System.Drawing.Size(34, 13)
        Me.lblBowA.TabIndex = 12
        Me.lblBowA.Text = "Bow?"
        '
        'cbBowA
        '
        Me.cbBowA.AutoSize = True
        Me.cbBowA.Location = New System.Drawing.Point(529, 417)
        Me.cbBowA.Name = "cbBowA"
        Me.cbBowA.Size = New System.Drawing.Size(44, 17)
        Me.cbBowA.TabIndex = 13
        Me.cbBowA.Text = "Yes"
        Me.cbBowA.UseVisualStyleBackColor = True
        '
        'pnlSwordA
        '
        Me.pnlSwordA.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.pnlSwordA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlSwordA.Controls.Add(Me.lblSwordDmgA)
        Me.pnlSwordA.Controls.Add(Me.lblSharpASword)
        Me.pnlSwordA.Controls.Add(Me.lbSharpASword)
        Me.pnlSwordA.Controls.Add(Me.lblSwordA)
        Me.pnlSwordA.Controls.Add(Me.lbSwordsA)
        Me.pnlSwordA.Location = New System.Drawing.Point(12, 12)
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
        Me.pnlAxeA.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.pnlAxeA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlAxeA.Controls.Add(Me.lblSharpAAxe)
        Me.pnlAxeA.Controls.Add(Me.lbSharpAAxe)
        Me.pnlAxeA.Controls.Add(Me.lblAxeDmgA)
        Me.pnlAxeA.Controls.Add(Me.lbAxeA)
        Me.pnlAxeA.Controls.Add(Me.lblAxeA)
        Me.pnlAxeA.Location = New System.Drawing.Point(201, 12)
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
        Me.pnlExtrasA.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.pnlExtrasA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlExtrasA.Controls.Add(Me.cbStrengthIIA)
        Me.pnlExtrasA.Controls.Add(Me.cbStrengthIA)
        Me.pnlExtrasA.Location = New System.Drawing.Point(390, 12)
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
        Me.pnlHelmA.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.pnlHelmA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlHelmA.Controls.Add(Me.lblProtAHelm)
        Me.pnlHelmA.Controls.Add(Me.lbProtAHelm)
        Me.pnlHelmA.Controls.Add(Me.lbHelmA)
        Me.pnlHelmA.Controls.Add(Me.LblHelmA)
        Me.pnlHelmA.Location = New System.Drawing.Point(12, 171)
        Me.pnlHelmA.Name = "pnlHelmA"
        Me.pnlHelmA.Size = New System.Drawing.Size(183, 153)
        Me.pnlHelmA.TabIndex = 17
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
        Me.pnlChestA.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.pnlChestA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlChestA.Controls.Add(Me.lbChestA)
        Me.pnlChestA.Controls.Add(Me.lblChestA)
        Me.pnlChestA.Location = New System.Drawing.Point(201, 171)
        Me.pnlChestA.Name = "pnlChestA"
        Me.pnlChestA.Size = New System.Drawing.Size(183, 153)
        Me.pnlChestA.TabIndex = 18
        '
        'HomePage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(868, 583)
        Me.Controls.Add(Me.pnlChestA)
        Me.Controls.Add(Me.pnlHelmA)
        Me.Controls.Add(Me.pnlExtrasA)
        Me.Controls.Add(Me.pnlAxeA)
        Me.Controls.Add(Me.pnlSwordA)
        Me.Controls.Add(Me.cbBowA)
        Me.Controls.Add(Me.lblBowA)
        Me.Controls.Add(Me.lbBootsA)
        Me.Controls.Add(Me.lblBootsA)
        Me.Controls.Add(Me.lbLeggingsA)
        Me.Controls.Add(Me.lblLeggingsA)
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
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
    Friend WithEvents cbStrengthIA As CheckBox
    Friend WithEvents cbStrengthIIA As CheckBox
    Friend WithEvents pnlHelmA As Panel
    Friend WithEvents pnlChestA As Panel
    Friend WithEvents lblProtAHelm As Label
    Friend WithEvents lbProtAHelm As ListBox
End Class
