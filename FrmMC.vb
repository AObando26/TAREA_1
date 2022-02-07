Public Class FrmMC
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'variable
        Dim centimetro As Integer
        If IsNumeric(txtIngreso.Text) Then
            centimetro = CInt(txtIngreso.Text) * 100
            lblRsp.Text = centimetro


        End If
    End Sub
End Class