<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        lblFirstName = New Label()
        lblWeight = New Label()
        txtFirstName = New TextBox()
        txtWeight = New TextBox()
        btnStart = New Button()
        SuspendLayout()
        ' 
        ' lblFirstName
        ' 
        lblFirstName.AutoSize = True
        lblFirstName.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblFirstName.Location = New Point(28, 28)
        lblFirstName.Margin = New Padding(4, 0, 4, 0)
        lblFirstName.Name = "lblFirstName"
        lblFirstName.Size = New Size(65, 15)
        lblFirstName.TabIndex = 0
        lblFirstName.Text = "First name"
        ' 
        ' lblWeight
        ' 
        lblWeight.AutoSize = True
        lblWeight.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblWeight.Location = New Point(28, 95)
        lblWeight.Margin = New Padding(4, 0, 4, 0)
        lblWeight.Name = "lblWeight"
        lblWeight.Size = New Size(48, 15)
        lblWeight.TabIndex = 2
        lblWeight.Text = "Weight"
        ' 
        ' txtFirstName
        ' 
        txtFirstName.Location = New Point(28, 48)
        txtFirstName.Margin = New Padding(4, 3, 4, 3)
        txtFirstName.Name = "txtFirstName"
        txtFirstName.Size = New Size(268, 23)
        txtFirstName.TabIndex = 1
        ' 
        ' txtWeight
        ' 
        txtWeight.Location = New Point(28, 115)
        txtWeight.Margin = New Padding(4, 3, 4, 3)
        txtWeight.Name = "txtWeight"
        txtWeight.Size = New Size(268, 23)
        txtWeight.TabIndex = 3
        ' 
        ' btnStart
        ' 
        btnStart.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnStart.Location = New Point(28, 166)
        btnStart.Margin = New Padding(4, 3, 4, 3)
        btnStart.Name = "btnStart"
        btnStart.Size = New Size(128, 35)
        btnStart.TabIndex = 4
        btnStart.Text = "Start"
        btnStart.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(331, 231)
        Controls.Add(btnStart)
        Controls.Add(txtWeight)
        Controls.Add(lblWeight)
        Controls.Add(txtFirstName)
        Controls.Add(lblFirstName)
        Margin = New Padding(4, 3, 4, 3)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()

    End Sub
    Friend WithEvents lblFirstName As System.Windows.Forms.Label
    Friend WithEvents lblWeight As System.Windows.Forms.Label
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents txtWeight As System.Windows.Forms.TextBox
    Friend WithEvents btnStart As System.Windows.Forms.Button

End Class