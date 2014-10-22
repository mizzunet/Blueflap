Public Class messageboxe

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub messageboxe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Computer.Audio.PlaySystemSound( _
       System.Media.SystemSounds.Asterisk)
    End Sub
End Class