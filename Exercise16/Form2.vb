Public Class Form2
    Public Weight As Single
    Public FirstName As String
    Dim Gweight As Single
    Dim Planet As String
    Dim PlanetArray(8) As String
    Dim GravArray(8) As Single
    Dim I As Integer

    Private Sub mnuEarth_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEarth.Click
        Planet = "Earth"
        
    End Sub

    Private Sub mnuMercury_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuMercury.Click
        Planet = "Mercury"

    End Sub

    Private Sub mnuVenus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuVenus.Click
        Planet = "Venus"

    End Sub

    Private Sub mnuMars_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuMars.Click
        Planet = "Mars"

    End Sub

    Private Sub mnuJupiter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuJupiter.Click
        Planet = "Jupiter"

    End Sub

    Private Sub mnuSaturn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSaturn.Click
        Planet = "Saturn"

    End Sub

    Private Sub mnuUranus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuUranus.Click
        Planet = "Uranus"

    End Sub

    Private Sub mnuNeptune_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuNeptune.Click
        Planet = "Neptune"

    End Sub

    Private Sub mnuPluto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuPluto.Click
        Planet = "Pluto"

    End Sub

    Private Sub btnShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow.Click
        If Planet = "" Then
            lblGravity.Text = "Pick a planet first"
        Else
            For I = 0 To 8
                If PlanetArray(I) = Planet Then
                    Gweight = Weight * GravArray(I)
                    lblGravity.Text = FirstName & " Your weight on planet " & Planet & " is " & Math.Round(Gweight, 2)
                    Exit For
                End If
            Next
        End If
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        lblGravity.Text = ""
    End Sub

    Private Sub btnQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuit.Click
        Me.Close()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PlanetArray(0) = "Earth"
        PlanetArray(1) = "Mercury"
        PlanetArray(2) = "Venus"
        PlanetArray(3) = "Mars"
        PlanetArray(4) = "Jupiter"
        PlanetArray(5) = "Saturn"
        PlanetArray(6) = "Uranus"
        PlanetArray(7) = "Neptune"
        PlanetArray(8) = "Pluto"

        GravArray(0) = 1
        GravArray(1) = 1.9
        GravArray(2) = 0.86
        GravArray(3) = 0.37
        GravArray(4) = 2.64
        GravArray(5) = 1.17
        GravArray(6) = 0.92
        GravArray(7) = 1.44
        GravArray(8) = 0.33
    End Sub
End Class