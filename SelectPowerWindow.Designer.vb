<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SelectPowerWindow
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PowerList = New System.Windows.Forms.ListBox()
        Me.SearchPower = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.PowerList)
        Me.Panel1.Controls.Add(Me.SearchPower)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(266, 723)
        Me.Panel1.TabIndex = 0
        '
        'PowerList
        '
        Me.PowerList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PowerList.FormattingEnabled = True
        Me.PowerList.Location = New System.Drawing.Point(0, 20)
        Me.PowerList.Name = "PowerList"
        Me.PowerList.Size = New System.Drawing.Size(266, 703)
        Me.PowerList.TabIndex = 1
        '
        'SearchPower
        '
        Me.SearchPower.Dock = System.Windows.Forms.DockStyle.Top
        Me.SearchPower.ForeColor = System.Drawing.SystemColors.WindowText
        Me.SearchPower.Location = New System.Drawing.Point(0, 0)
        Me.SearchPower.Name = "SearchPower"
        Me.SearchPower.Size = New System.Drawing.Size(266, 20)
        Me.SearchPower.TabIndex = 0
        Me.SearchPower.Text = "Type to search"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(266, 687)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(360, 36)
        Me.Panel2.TabIndex = 1
        '
        'Button2
        '
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button2.Location = New System.Drawing.Point(214, 0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(146, 36)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Close"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Button1.Location = New System.Drawing.Point(0, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(157, 36)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Add"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichTextBox1.Location = New System.Drawing.Point(266, 0)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.Size = New System.Drawing.Size(360, 687)
        Me.RichTextBox1.TabIndex = 2
        Me.RichTextBox1.Text = ""
        '
        'SelectPowerWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(626, 723)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "SelectPowerWindow"
        Me.Text = "Hero Toolkit"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents SearchPower As TextBox
    Friend WithEvents PowerList As ListBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Button2 As Button
End Class
