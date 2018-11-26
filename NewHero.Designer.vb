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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.PlayerNameLabel = New System.Windows.Forms.Label()
        Me.HeroType = New System.Windows.Forms.ListBox()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'NewHeroName
        '
        Me.NewHeroName.Location = New System.Drawing.Point(12, 12)
        Me.NewHeroName.Name = "NewHeroName"
        Me.NewHeroName.Size = New System.Drawing.Size(186, 20)
        Me.NewHeroName.TabIndex = 0
        '
        'HeroNameLabel
        '
        Me.HeroNameLabel.AutoSize = True
        Me.HeroNameLabel.Location = New System.Drawing.Point(75, 35)
        Me.HeroNameLabel.Name = "HeroNameLabel"
        Me.HeroNameLabel.Size = New System.Drawing.Size(61, 13)
        Me.HeroNameLabel.TabIndex = 1
        Me.HeroNameLabel.Text = "Hero Name"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 51)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(186, 20)
        Me.TextBox1.TabIndex = 2
        '
        'PlayerNameLabel
        '
        Me.PlayerNameLabel.AutoSize = True
        Me.PlayerNameLabel.Location = New System.Drawing.Point(69, 74)
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
        Me.HeroType.Size = New System.Drawing.Size(187, 34)
        Me.HeroType.TabIndex = 4
        '
        'ListBox2
        '
        Me.ListBox2.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.ItemHeight = 15
        Me.ListBox2.Items.AddRange(New Object() {"Construct - Automation", "Construct - Immobile", "Normal Hero - not a Construct"})
        Me.ListBox2.Location = New System.Drawing.Point(12, 130)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(186, 49)
        Me.ListBox2.TabIndex = 5
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(12, 185)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(186, 82)
        Me.Panel1.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(210, 279)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.HeroType)
        Me.Controls.Add(Me.PlayerNameLabel)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.HeroNameLabel)
        Me.Controls.Add(Me.NewHeroName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form1"
        Me.Text = "Hero Toolkit"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NewHeroName As TextBox
    Friend WithEvents HeroNameLabel As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents PlayerNameLabel As Label
    Friend WithEvents HeroType As ListBox
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents Panel1 As Panel
End Class
