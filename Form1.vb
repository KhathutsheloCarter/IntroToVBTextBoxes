Public Class Form1
    Private Sub btnGreet_Click(sender As Object, e As EventArgs) Handles btnGreet.Click


        Dim stFirstName As String
        Dim stLastName As String
        Dim stGender As String

        stFirstName = txtFirstName.Text
        stLastName = txtLastName.Text
        stGender = txtGender.Text

        MessageBox.Show("Hello " & vbNewLine _
                        & stLastName &
                        vbNewLine & stLastName &
                        vbNewLine & stGender)





    End Sub
End Class
