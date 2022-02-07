Public Class FrmKL
    Private Sub btnRespuesta_Click(sender As Object, e As EventArgs) Handles btnRespuesta.Click
        'variable
        Dim libras As Integer
        libras = CInt(txtKilo.Text) * 2.2

        lblLibra.Text = libras

    End Sub
End Class