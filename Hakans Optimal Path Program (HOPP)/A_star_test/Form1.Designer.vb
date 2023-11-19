<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.OpenFD = New System.Windows.Forms.OpenFileDialog()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.radStart = New System.Windows.Forms.RadioButton()
        Me.radEnd = New System.Windows.Forms.RadioButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.radWall = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Loadbtn = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserManualToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TheProgramToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContactToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1168, 70)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(103, 28)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Select Lulc Map"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(1168, 348)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(103, 28)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Find Optimal Path"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'OpenFD
        '
        Me.OpenFD.FileName = "OpenFileDialog1"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(1168, 382)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(103, 28)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Clear Path"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'radStart
        '
        Me.radStart.AutoSize = True
        Me.radStart.Location = New System.Drawing.Point(6, 19)
        Me.radStart.Name = "radStart"
        Me.radStart.Size = New System.Drawing.Size(86, 17)
        Me.radStart.TabIndex = 4
        Me.radStart.TabStop = True
        Me.radStart.Text = "Starting Pixel"
        Me.radStart.UseVisualStyleBackColor = True
        '
        'radEnd
        '
        Me.radEnd.AutoSize = True
        Me.radEnd.Location = New System.Drawing.Point(6, 42)
        Me.radEnd.Name = "radEnd"
        Me.radEnd.Size = New System.Drawing.Size(83, 17)
        Me.radEnd.TabIndex = 5
        Me.radEnd.TabStop = True
        Me.radEnd.Text = "Ending Pixel"
        Me.radEnd.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(12, 70)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(891, 514)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.Location = New System.Drawing.Point(1078, 458)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(193, 23)
        Me.Label1.TabIndex = 14
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label2.Location = New System.Drawing.Point(1081, 490)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(190, 23)
        Me.Label2.TabIndex = 15
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'radWall
        '
        Me.radWall.AutoSize = True
        Me.radWall.Location = New System.Drawing.Point(6, 65)
        Me.radWall.Name = "radWall"
        Me.radWall.Size = New System.Drawing.Size(46, 17)
        Me.radWall.TabIndex = 16
        Me.radWall.TabStop = True
        Me.radWall.Text = "Wall"
        Me.radWall.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radEnd)
        Me.GroupBox1.Controls.Add(Me.radWall)
        Me.GroupBox1.Controls.Add(Me.radStart)
        Me.GroupBox1.Location = New System.Drawing.Point(1165, 251)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(106, 91)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "The Selection"
        '
        'Label3
        '
        Me.Label3.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label3.Location = New System.Drawing.Point(1081, 522)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(190, 23)
        Me.Label3.TabIndex = 18
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Loadbtn
        '
        Me.Loadbtn.Location = New System.Drawing.Point(1196, 138)
        Me.Loadbtn.Name = "Loadbtn"
        Me.Loadbtn.Size = New System.Drawing.Size(75, 28)
        Me.Loadbtn.TabIndex = 20
        Me.Loadbtn.Text = "Load Maps"
        Me.Loadbtn.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(1081, 75)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(81, 20)
        Me.TextBox1.TabIndex = 21
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.ForestGreen
        Me.Label5.Location = New System.Drawing.Point(1096, 180)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(175, 23)
        Me.Label5.TabIndex = 22
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(1168, 104)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(103, 28)
        Me.Button4.TabIndex = 25
        Me.Button4.Text = "Select Slope Map"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox2.Enabled = False
        Me.TextBox2.Location = New System.Drawing.Point(1081, 109)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(81, 20)
        Me.TextBox2.TabIndex = 27
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(1168, 416)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(103, 28)
        Me.Button5.TabIndex = 28
        Me.Button5.Text = "EXIT"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.MenuStrip1.Size = New System.Drawing.Size(1284, 24)
        Me.MenuStrip1.TabIndex = 29
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UserManualToolStripMenuItem, Me.TheProgramToolStripMenuItem, Me.ContactToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(40, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'UserManualToolStripMenuItem
        '
        Me.UserManualToolStripMenuItem.Name = "UserManualToolStripMenuItem"
        Me.UserManualToolStripMenuItem.Size = New System.Drawing.Size(219, 22)
        Me.UserManualToolStripMenuItem.Text = "User Manual "
        '
        'TheProgramToolStripMenuItem
        '
        Me.TheProgramToolStripMenuItem.Name = "TheProgramToolStripMenuItem"
        Me.TheProgramToolStripMenuItem.Size = New System.Drawing.Size(219, 22)
        Me.TheProgramToolStripMenuItem.Text = "Hakan's Optimal Path Finder"
        '
        'ContactToolStripMenuItem
        '
        Me.ContactToolStripMenuItem.Name = "ContactToolStripMenuItem"
        Me.ContactToolStripMenuItem.Size = New System.Drawing.Size(219, 22)
        Me.ContactToolStripMenuItem.Text = "Contact"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1284, 751)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Loadbtn)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hakan's Optimal Pathfinder (HOP)"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents OpenFD As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents radStart As System.Windows.Forms.RadioButton
    Friend WithEvents radEnd As System.Windows.Forms.RadioButton
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents radWall As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Loadbtn As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UserManualToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TheProgramToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContactToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
