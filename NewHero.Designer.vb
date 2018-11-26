<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewHero
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
        Me.NewHeroName = New System.Windows.Forms.TextBox()
        Me.HeroNameLabel = New System.Windows.Forms.Label()
        Me.PlayerName = New System.Windows.Forms.TextBox()
        Me.PlayerNameLabel = New System.Windows.Forms.Label()
        Me.HeroType = New System.Windows.Forms.ListBox()
        Me.HeroAutomation = New System.Windows.Forms.ListBox()
        Me.PCPanel = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PowerLevel = New System.Windows.Forms.NumericUpDown()
        Me.StartingPP = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.OkayBtn = New System.Windows.Forms.Button()
        Me.CloseBtn = New System.Windows.Forms.Button()
        Me.NPCPanel = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PPPerLevel = New System.Windows.Forms.NumericUpDown()
        Me.PCPanel.SuspendLayout()
        CType(Me.PowerLevel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NPCPanel.SuspendLayout()
        CType(Me.PPPerLevel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NewHeroName
        '
        Me.NewHeroName.Location = New System.Drawing.Point(12, 12)
        Me.NewHeroName.Name = "NewHeroName"
        Me.NewHeroName.Size = New System.Drawing.Size(219, 20)
        Me.NewHeroName.TabIndex = 0
        Me.NewHeroName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'HeroNameLabel
        '
        Me.HeroNameLabel.AutoSize = True
        Me.HeroNameLabel.Location = New System.Drawing.Point(101, 35)
        Me.HeroNameLabel.Name = "HeroNameLabel"
        Me.HeroNameLabel.Size = New System.Drawing.Size(61, 13)
        Me.HeroNameLabel.TabIndex = 1
        Me.HeroNameLabel.Text = "Hero Name"
        '
        'PlayerName
        '
        Me.PlayerName.Location = New System.Drawing.Point(12, 51)
        Me.PlayerName.Name = "PlayerName"
        Me.PlayerName.Size = New System.Drawing.Size(219, 20)
        Me.PlayerName.TabIndex = 2
        Me.PlayerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PlayerNameLabel
        '
        Me.PlayerNameLabel.AutoSize = True
        Me.PlayerNameLabel.Location = New System.Drawing.Point(95, 74)
        Me.PlayerNameLabel.Name = "PlayerNameLabel"
        Me.PlayerNameLabel.Size = New System.Drawing.Size(67, 13)
        Me.PlayerNameLabel.TabIndex = 3
        Me.PlayerNameLabel.Text = "Player Name"
        '
        'HeroType
        '
        Me.HeroType.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HeroType.FormattingEnabled = True
        Me.HeroType.ItemHeight = 15
        Me.HeroType.Items.AddRange(New Object() {"Create PC - PP / PL limites applied", "Create NPC - no PP / PL limites"})
        Me.HeroType.Location = New System.Drawing.Point(11, 90)
        Me.HeroType.Name = "HeroType"
        Me.HeroType.Size = New System.Drawing.Size(223, 34)
        Me.HeroType.TabIndex = 4
        '
        'HeroAutomation
        '
        Me.HeroAutomation.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HeroAutomation.FormattingEnabled = True
        Me.HeroAutomation.ItemHeight = 15
        Me.HeroAutomation.Items.AddRange(New Object() {"Construct - Automation", "Construct - Immobile", "Normal Hero - not a Construct"})
        Me.HeroAutomation.Location = New System.Drawing.Point(12, 130)
        Me.HeroAutomation.Name = "HeroAutomation"
        Me.HeroAutomation.Size = New System.Drawing.Size(222, 49)
        Me.HeroAutomation.TabIndex = 5
        '
        'PCPanel
        '
        Me.PCPanel.Controls.Add(Me.PPPerLevel)
        Me.PCPanel.Controls.Add(Me.Label3)
        Me.PCPanel.Controls.Add(Me.Label2)
        Me.PCPanel.Controls.Add(Me.StartingPP)
        Me.PCPanel.Controls.Add(Me.PowerLevel)
        Me.PCPanel.Controls.Add(Me.Label1)
        Me.PCPanel.Location = New System.Drawing.Point(12, 185)
        Me.PCPanel.Name = "PCPanel"
        Me.PCPanel.Size = New System.Drawing.Size(222, 59)
        Me.PCPanel.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(156, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Power Level"
        '
        'PowerLevel
        '
        Me.PowerLevel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PowerLevel.Location = New System.Drawing.Point(159, 0)
        Me.PowerLevel.Name = "PowerLevel"
        Me.PowerLevel.Size = New System.Drawing.Size(60, 35)
        Me.PowerLevel.TabIndex = 1
        Me.PowerLevel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.PowerLevel.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'StartingPP
        '
        Me.StartingPP.Location = New System.Drawing.Point(120, 27)
        Me.StartingPP.Name = "StartingPP"
        Me.StartingPP.ReadOnly = True
        Me.StartingPP.Size = New System.Drawing.Size(34, 20)
        Me.StartingPP.TabIndex = 3
        Me.StartingPP.Text = "150"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "PP / Power Level:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(0, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(114, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Starting Power Points: "
        '
        'OkayBtn
        '
        Me.OkayBtn.Location = New System.Drawing.Point(15, 262)
        Me.OkayBtn.Name = "OkayBtn"
        Me.OkayBtn.Size = New System.Drawing.Size(75, 23)
        Me.OkayBtn.TabIndex = 7
        Me.OkayBtn.Text = "Okay"
        Me.OkayBtn.UseVisualStyleBackColor = True
        '
        'CloseBtn
        '
        Me.CloseBtn.Location = New System.Drawing.Point(156, 262)
        Me.CloseBtn.Name = "CloseBtn"
        Me.CloseBtn.Size = New System.Drawing.Size(75, 23)
        Me.CloseBtn.TabIndex = 8
        Me.CloseBtn.Text = "Close"
        Me.CloseBtn.UseVisualStyleBackColor = True
        '
        'NPCPanel
        '
        Me.NPCPanel.Controls.Add(Me.Label4)
        Me.NPCPanel.Location = New System.Drawing.Point(12, 185)
        Me.NPCPanel.Name = "NPCPanel"
        Me.NPCPanel.Size = New System.Drawing.Size(222, 59)
        Me.NPCPanel.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(186, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "NPCs have no power limit. Neat right?"
        '
        'PPPerLevel
        '
        Me.PPPerLevel.Location = New System.Drawing.Point(120, 1)
        Me.PPPerLevel.Name = "PPPerLevel"
        Me.PPPerLevel.Size = New System.Drawing.Size(34, 20)
        Me.PPPerLevel.TabIndex = 6
        Me.PPPerLevel.Value = New Decimal(New Integer() {15, 0, 0, 0})
        '
        'NewHero
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(246, 297)
        Me.Controls.Add(Me.CloseBtn)
        Me.Controls.Add(Me.OkayBtn)
        Me.Controls.Add(Me.HeroAutomation)
        Me.Controls.Add(Me.HeroType)
        Me.Controls.Add(Me.PlayerNameLabel)
        Me.Controls.Add(Me.PlayerName)
        Me.Controls.Add(Me.HeroNameLabel)
        Me.Controls.Add(Me.NewHeroName)
        Me.Controls.Add(Me.PCPanel)
        Me.Controls.Add(Me.NPCPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "NewHero"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hero Toolkit"
        Me.PCPanel.ResumeLayout(False)
        Me.PCPanel.PerformLayout()
        CType(Me.PowerLevel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NPCPanel.ResumeLayout(False)
        Me.NPCPanel.PerformLayout()
        CType(Me.PPPerLevel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NewHeroName As TextBox
    Friend WithEvents HeroNameLabel As Label
    Friend WithEvents PlayerName As TextBox
    Friend WithEvents PlayerNameLabel As Label
    Friend WithEvents HeroType As ListBox
    Friend WithEvents HeroAutomation As ListBox
    Friend WithEvents PCPanel As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents StartingPP As TextBox
    Friend WithEvents PowerLevel As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents OkayBtn As Button
    Friend WithEvents CloseBtn As Button
    Friend WithEvents NPCPanel As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents PPPerLevel As NumericUpDown
End Class
