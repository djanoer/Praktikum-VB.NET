Public Class Frmcoba
    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Btntampilkan_Click(sender As Object, e As EventArgs) Handles Btntampilkan.Click
        MessageBox.Show(txtnama.Text & vbCrLf & cbojeniskelamin.Text & vbCrLf & cbofakultas.Text, "Hasil Pengisian", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class
