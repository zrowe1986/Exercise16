<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        mnuPlanets = New MenuStrip()
        PlanetsToolStripMenuItem = New ToolStripMenuItem()
        mnuEarth = New ToolStripMenuItem()
        mnuMercury = New ToolStripMenuItem()
        mnuVenus = New ToolStripMenuItem()
        mnuMars = New ToolStripMenuItem()
        mnuJupiter = New ToolStripMenuItem()
        mnuSaturn = New ToolStripMenuItem()
        mnuUranus = New ToolStripMenuItem()
        mnuNeptune = New ToolStripMenuItem()
        mnuPluto = New ToolStripMenuItem()
        lblGravity = New Label()
        btnShow = New Button()
        btnClear = New Button()
        btnQuit = New Button()
        mnuPlanets.SuspendLayout()
        SuspendLayout()
        ' 
        ' mnuPlanets
        ' 
        mnuPlanets.Items.AddRange(New ToolStripItem() {PlanetsToolStripMenuItem})
        mnuPlanets.Location = New Point(0, 0)
        mnuPlanets.Name = "mnuPlanets"
        mnuPlanets.Padding = New Padding(7, 2, 0, 2)
        mnuPlanets.Size = New Size(420, 24)
        mnuPlanets.TabIndex = 0
        mnuPlanets.Text = "mnuPlanets"
        ' 
        ' PlanetsToolStripMenuItem
        ' 
        PlanetsToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {mnuEarth, mnuMercury, mnuVenus, mnuMars, mnuJupiter, mnuSaturn, mnuUranus, mnuNeptune, mnuPluto})
        PlanetsToolStripMenuItem.Name = "PlanetsToolStripMenuItem"
        PlanetsToolStripMenuItem.Size = New Size(57, 20)
        PlanetsToolStripMenuItem.Text = "Planets"
        ' 
        ' mnuEarth
        ' 
        mnuEarth.Name = "mnuEarth"
        mnuEarth.Size = New Size(120, 22)
        mnuEarth.Text = "Earth"
        ' 
        ' mnuMercury
        ' 
        mnuMercury.Name = "mnuMercury"
        mnuMercury.Size = New Size(120, 22)
        mnuMercury.Text = "Mercury"
        ' 
        ' mnuVenus
        ' 
        mnuVenus.Name = "mnuVenus"
        mnuVenus.Size = New Size(120, 22)
        mnuVenus.Text = "Venus"
        ' 
        ' mnuMars
        ' 
        mnuMars.Name = "mnuMars"
        mnuMars.Size = New Size(120, 22)
        mnuMars.Text = "Mars"
        ' 
        ' mnuJupiter
        ' 
        mnuJupiter.Name = "mnuJupiter"
        mnuJupiter.Size = New Size(120, 22)
        mnuJupiter.Text = "Jupiter"
        ' 
        ' mnuSaturn
        ' 
        mnuSaturn.Name = "mnuSaturn"
        mnuSaturn.Size = New Size(120, 22)
        mnuSaturn.Text = "Saturn"
        ' 
        ' mnuUranus
        ' 
        mnuUranus.Name = "mnuUranus"
        mnuUranus.Size = New Size(120, 22)
        mnuUranus.Text = "Uranus"
        ' 
        ' mnuNeptune
        ' 
        mnuNeptune.Name = "mnuNeptune"
        mnuNeptune.Size = New Size(120, 22)
        mnuNeptune.Text = "Neptune"
        ' 
        ' mnuPluto
        ' 
        mnuPluto.Name = "mnuPluto"
        mnuPluto.Size = New Size(120, 22)
        mnuPluto.Text = "Pluto"
        ' 
        ' lblGravity
        ' 
        lblGravity.BorderStyle = BorderStyle.FixedSingle
        lblGravity.Location = New Point(23, 52)
        lblGravity.Margin = New Padding(4, 0, 4, 0)
        lblGravity.Name = "lblGravity"
        lblGravity.Size = New Size(373, 69)
        lblGravity.TabIndex = 1
        ' 
        ' btnShow
        ' 
        btnShow.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnShow.Location = New Point(23, 144)
        btnShow.Margin = New Padding(4, 3, 4, 3)
        btnShow.Name = "btnShow"
        btnShow.Size = New Size(117, 35)
        btnShow.TabIndex = 2
        btnShow.Text = "Show weight"
        btnShow.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnClear.Location = New Point(152, 144)
        btnClear.Margin = New Padding(4, 3, 4, 3)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(117, 35)
        btnClear.TabIndex = 3
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' btnQuit
        ' 
        btnQuit.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnQuit.Location = New Point(280, 144)
        btnQuit.Margin = New Padding(4, 3, 4, 3)
        btnQuit.Name = "btnQuit"
        btnQuit.Size = New Size(117, 35)
        btnQuit.TabIndex = 4
        btnQuit.Text = "Quit"
        btnQuit.UseVisualStyleBackColor = True
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(420, 208)
        Controls.Add(btnQuit)
        Controls.Add(btnClear)
        Controls.Add(btnShow)
        Controls.Add(lblGravity)
        Controls.Add(mnuPlanets)
        MainMenuStrip = mnuPlanets
        Margin = New Padding(4, 3, 4, 3)
        Name = "Form2"
        Text = "Form2"
        mnuPlanets.ResumeLayout(False)
        mnuPlanets.PerformLayout()
        ResumeLayout(False)
        PerformLayout()

    End Sub
    Friend WithEvents mnuPlanets As System.Windows.Forms.MenuStrip
    Friend WithEvents PlanetsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuEarth As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuMercury As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuVenus As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuMars As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuJupiter As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSaturn As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuUranus As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuNeptune As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuPluto As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblGravity As System.Windows.Forms.Label
    Friend WithEvents btnShow As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnQuit As System.Windows.Forms.Button

End Class