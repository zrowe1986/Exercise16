Imports System.Windows

Public Class Form1
    Public FirstName As String
    Public Weight As Single

    Private Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click
        FirstName = txtFirstName.Text
        Weight = CSng(txtWeight.Text)

        Dim form2 As New Form2
        form2.FirstName = FirstName
        form2.Weight = Weight
        form2.ShowDialog()

        Me.Close()
    End Sub
End Class