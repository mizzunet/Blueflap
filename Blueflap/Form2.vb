Public Class Form2

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text = Fenetre_Principale.Stng_MP.Text Then
            TextBox1.ForeColor = Color.Green
            Accept.Enabled = True
        Else
            TextBox1.ForeColor = Color.Red
            Accept.Enabled = False
        End If
    End Sub

    Private Sub Accept_Click(sender As Object, e As EventArgs) Handles Accept.Click
        Fenetre_Principale.ABlueflap_Verrouillage.Visible = True
        Fenetre_Principale.ABlueflap_Verrouillage.BringToFront()
        Me.Close()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.linguuu = "English" Then
            Label1.Text = "Please enter your password to lock Blueflap"
        End If
    End Sub
End Class