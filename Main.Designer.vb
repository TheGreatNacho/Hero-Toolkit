<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FromScratchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FromArchtypeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveAsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.PrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintPreviewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SavePDFToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabPanel = New System.Windows.Forms.TabControl()
        Me.BasicsTab = New System.Windows.Forms.TabPage()
        Me.AbilitiesTab = New System.Windows.Forms.TabPage()
        Me.SkillsTab = New System.Windows.Forms.TabPage()
        Me.AdvantagesTab = New System.Windows.Forms.TabPage()
        Me.PowersTab = New System.Windows.Forms.TabPage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.AddPower = New System.Windows.Forms.Button()
        Me.EquipmentTab = New System.Windows.Forms.TabPage()
        Me.ComplicationsTab = New System.Windows.Forms.TabPage()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.MenuStrip1.SuspendLayout()
        Me.TabPanel.SuspendLayout()
        Me.PowersTab.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1432, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.OpenToolStripMenuItem, Me.SaveToolStripMenuItem, Me.SaveAsToolStripMenuItem, Me.ToolStripSeparator1, Me.PrintToolStripMenuItem, Me.PrintPreviewToolStripMenuItem, Me.SavePDFToolStripMenuItem, Me.ToolStripSeparator2, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FromScratchToolStripMenuItem, Me.FromArchtypeToolStripMenuItem})
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.NewToolStripMenuItem.Text = "New"
        '
        'FromScratchToolStripMenuItem
        '
        Me.FromScratchToolStripMenuItem.Name = "FromScratchToolStripMenuItem"
        Me.FromScratchToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.FromScratchToolStripMenuItem.Text = "From Scratch"
        '
        'FromArchtypeToolStripMenuItem
        '
        Me.FromArchtypeToolStripMenuItem.Name = "FromArchtypeToolStripMenuItem"
        Me.FromArchtypeToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.FromArchtypeToolStripMenuItem.Text = "From Archtype"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.OpenToolStripMenuItem.Text = "Open"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'SaveAsToolStripMenuItem
        '
        Me.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem"
        Me.SaveAsToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.SaveAsToolStripMenuItem.Text = "Save As"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(140, 6)
        '
        'PrintToolStripMenuItem
        '
        Me.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        Me.PrintToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.PrintToolStripMenuItem.Text = "Print"
        '
        'PrintPreviewToolStripMenuItem
        '
        Me.PrintPreviewToolStripMenuItem.Name = "PrintPreviewToolStripMenuItem"
        Me.PrintPreviewToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.PrintPreviewToolStripMenuItem.Text = "Print Preview"
        '
        'SavePDFToolStripMenuItem
        '
        Me.SavePDFToolStripMenuItem.Name = "SavePDFToolStripMenuItem"
        Me.SavePDFToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.SavePDFToolStripMenuItem.Text = "Save PDF"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(140, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'TabPanel
        '
        Me.TabPanel.Controls.Add(Me.BasicsTab)
        Me.TabPanel.Controls.Add(Me.AbilitiesTab)
        Me.TabPanel.Controls.Add(Me.SkillsTab)
        Me.TabPanel.Controls.Add(Me.AdvantagesTab)
        Me.TabPanel.Controls.Add(Me.PowersTab)
        Me.TabPanel.Controls.Add(Me.EquipmentTab)
        Me.TabPanel.Controls.Add(Me.ComplicationsTab)
        Me.TabPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.TabPanel.Location = New System.Drawing.Point(0, 24)
        Me.TabPanel.Name = "TabPanel"
        Me.TabPanel.SelectedIndex = 0
        Me.TabPanel.Size = New System.Drawing.Size(1432, 699)
        Me.TabPanel.TabIndex = 1
        '
        'BasicsTab
        '
        Me.BasicsTab.Location = New System.Drawing.Point(4, 22)
        Me.BasicsTab.Name = "BasicsTab"
        Me.BasicsTab.Padding = New System.Windows.Forms.Padding(3)
        Me.BasicsTab.Size = New System.Drawing.Size(1424, 752)
        Me.BasicsTab.TabIndex = 0
        Me.BasicsTab.Text = "Basics"
        Me.BasicsTab.UseVisualStyleBackColor = True
        '
        'AbilitiesTab
        '
        Me.AbilitiesTab.Location = New System.Drawing.Point(4, 22)
        Me.AbilitiesTab.Name = "AbilitiesTab"
        Me.AbilitiesTab.Padding = New System.Windows.Forms.Padding(3)
        Me.AbilitiesTab.Size = New System.Drawing.Size(1424, 752)
        Me.AbilitiesTab.TabIndex = 1
        Me.AbilitiesTab.Text = "Abilities"
        Me.AbilitiesTab.UseVisualStyleBackColor = True
        '
        'SkillsTab
        '
        Me.SkillsTab.Location = New System.Drawing.Point(4, 22)
        Me.SkillsTab.Name = "SkillsTab"
        Me.SkillsTab.Size = New System.Drawing.Size(1424, 752)
        Me.SkillsTab.TabIndex = 2
        Me.SkillsTab.Text = "Skills"
        Me.SkillsTab.UseVisualStyleBackColor = True
        '
        'AdvantagesTab
        '
        Me.AdvantagesTab.Location = New System.Drawing.Point(4, 22)
        Me.AdvantagesTab.Name = "AdvantagesTab"
        Me.AdvantagesTab.Size = New System.Drawing.Size(1424, 752)
        Me.AdvantagesTab.TabIndex = 3
        Me.AdvantagesTab.Text = "Advantages"
        Me.AdvantagesTab.UseVisualStyleBackColor = True
        '
        'PowersTab
        '
        Me.PowersTab.Controls.Add(Me.Panel1)
        Me.PowersTab.Location = New System.Drawing.Point(4, 22)
        Me.PowersTab.Name = "PowersTab"
        Me.PowersTab.Size = New System.Drawing.Size(1424, 673)
        Me.PowersTab.TabIndex = 4
        Me.PowersTab.Text = "Powers"
        Me.PowersTab.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.AddPower)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(495, 673)
        Me.Panel1.TabIndex = 0
        '
        'AddPower
        '
        Me.AddPower.Location = New System.Drawing.Point(3, 3)
        Me.AddPower.Name = "AddPower"
        Me.AddPower.Size = New System.Drawing.Size(489, 23)
        Me.AddPower.TabIndex = 0
        Me.AddPower.Text = "Add Power"
        Me.AddPower.UseVisualStyleBackColor = True
        '
        'EquipmentTab
        '
        Me.EquipmentTab.Location = New System.Drawing.Point(4, 22)
        Me.EquipmentTab.Name = "EquipmentTab"
        Me.EquipmentTab.Size = New System.Drawing.Size(1424, 752)
        Me.EquipmentTab.TabIndex = 5
        Me.EquipmentTab.Text = "Equipment"
        Me.EquipmentTab.UseVisualStyleBackColor = True
        '
        'ComplicationsTab
        '
        Me.ComplicationsTab.Location = New System.Drawing.Point(4, 22)
        Me.ComplicationsTab.Name = "ComplicationsTab"
        Me.ComplicationsTab.Size = New System.Drawing.Size(1424, 752)
        Me.ComplicationsTab.TabIndex = 6
        Me.ComplicationsTab.Text = "Complications"
        Me.ComplicationsTab.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 780)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1432, 22)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(1432, 802)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.TabPanel)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Main"
        Me.Text = "Hero Toolkit"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.TabPanel.ResumeLayout(False)
        Me.PowersTab.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveAsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents PrintToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrintPreviewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SavePDFToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FromScratchToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FromArchtypeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TabPanel As TabControl
    Friend WithEvents BasicsTab As TabPage
    Friend WithEvents AbilitiesTab As TabPage
    Friend WithEvents SkillsTab As TabPage
    Friend WithEvents AdvantagesTab As TabPage
    Friend WithEvents PowersTab As TabPage
    Friend WithEvents EquipmentTab As TabPage
    Friend WithEvents ComplicationsTab As TabPage
    Friend WithEvents Panel1 As Panel
    Friend WithEvents AddPower As Button
    Friend WithEvents StatusStrip1 As StatusStrip
End Class
